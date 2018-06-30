using SharpSvn;
using SvnSearch.Search;
using SvnSearch.UI;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SvnSearch {
    public partial class MainForm : Form {
        #region -  Fields  -

        const string DIR = "dir";

        private static readonly FileTypeIconDictionary _icons = new FileTypeIconDictionary();
        private static readonly MostRecentlyUsed _mru = new MostRecentlyUsed();

        private static readonly SvnClient _svnClient = new SvnClient();

        private bool _isSearching = false;
        private CancellationTokenSource _currentToken;

        #endregion

        #region -  Constructors  -

        public MainForm() {
            InitializeComponent();
            imgFileTypes.Images.Add(DIR, Properties.Resources.Folder16);
        }

        #endregion

        #region -  Event Handlers  -

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            RefreshMru();
            if (cmbUrl.Items.Count > 0) cmbUrl.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (!_isSearching) {
                cmbUrl.Text = cmbUrl.Text.Replace('\\', '/').Trim();
                PerformSearch();
            } else {
                _currentToken.Cancel();
                _currentToken = null;
                EndSearch();
            }
        }

        private void lstResults_DoubleClick(object sender, EventArgs e) {
            showInTortoiseSVNToolStripMenuItem_Click(sender, e);
        }

        private void rdoRevision_CheckedChanged(object sender, EventArgs e) {
            txtRevision.Enabled = rdoRevision.Checked;
        }

        private void showInTortoiseSVNToolStripMenuItem_Click(object sender, EventArgs e) {
            if (lstResults.SelectedItems.Count < 1) return;
            var item = (SvnListViewItem)lstResults.SelectedItems[0];
            var rev = (rdoHeadRevision.Checked) ? "HEAD" : item.Result.Entry.Revision.ToString();
            TortoiseProc("repobrowser", item.Result.Uri, "/rev:" + rev);
        }

        private void showLogToolStripMenuItem_Click(object sender, EventArgs e) {
            if (lstResults.SelectedItems.Count < 1) return;
            var item = (SvnListViewItem)lstResults.SelectedItems[0];
            var rev = (rdoHeadRevision.Checked) ? "HEAD" : item.Result.Entry.Revision.ToString();
            TortoiseProc("log", item.Result.Uri, "/startrev:" + rev);
        }

        private void blameToolStripMenuItem_Click(object sender, EventArgs e) {
            if (lstResults.SelectedItems.Count < 1) return;
            var item = (SvnListViewItem)lstResults.SelectedItems[0];
            TortoiseProc("blame", item.Result.Uri, string.Empty);
        }

        private void ctxResults_Opening(object sender, CancelEventArgs e) {
            if (lstResults.SelectedItems.Count < 1) {
                e.Cancel = true;
                return;
            }
            blameToolStripMenuItem.Visible = (((SvnListViewItem)lstResults.SelectedItems[0]).Result.Entry.NodeKind == SvnNodeKind.File);
        }

        #endregion

        #region -  Private Methods  -

        private void TortoiseProc(string command, Uri path, string rev) {
            var args = string.Format("/command:{0} /path:\"{1}\" {2}", command, path, rev);
            // todo: Support revisions.
            var tPath = @"C:\Program Files\TortoiseSVN\bin\TortoiseProc.exe";
            if (!File.Exists(tPath)) tPath = "TortoiseProc.exe";
            try {
                Process.Start(tPath, args);
            } catch (FileNotFoundException) {
                MessageBox.Show("Unable to start TortoiseProc. Please make sure the TortoiseSVN bin directory is in your PATH variable.");
            }
        }

        private async void PerformSearch() {
            try {
                // Validation.
                Uri location;
                if (!Uri.TryCreate(cmbUrl.Text, UriKind.Absolute, out location)) {
                    MessageBox.Show(this, "Location must be a valid SVN URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbUrl.Focus();
                    return;
                }

                var svnRevision = SvnRevision.Head;
                if (rdoRevision.Checked) {
                    var revision = -1;
                    if (!int.TryParse(txtRevision.Text, out revision) || revision < 1) {
                        MessageBox.Show(this, "Revisions must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRevision.Focus();
                        return;
                    }
                    svnRevision = new SvnRevision(revision);
                }

                lstResults.Items.Clear();
                lstResults.Refresh();

                BeginSearch();

                var searcher = new SvnSearcher(location, svnRevision);
                var searchType = rdoRegex.Checked ? ValidatorType.Regex : ValidatorType.Text;

                using (CancellationTokenSource cts = new CancellationTokenSource()) {
                    _currentToken = cts;

                    var updateProgress = new Progress<SvnListEventArgs>((a) => {
                        lstResults.Items.Add(GetDisplayItem(a));
                    });

                    try {
                        var results = await searcher.SearchAsync(
                            txtSearchFor.Text,
                            chkCaseSensitive.Checked,
                            searchType,
                            txtFileFilter.Text,
                            txtFilterByAuthor.Text,
                            chkIncludeSubfolders.Checked,
                            cts.Token,
                            updateProgress
                        );
                        _mru.Push(cmbUrl.Text);
                        RefreshMru();
                    } catch (OperationCanceledException) {
                        // Do nothing. 
                    } catch (Exception ex) {
                        MessageBox.Show(this, "An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } finally {
                EndSearch();
            }
        }

        private void BeginSearch() {
            _isSearching = true;
            lblResults.Visible = false;
            prgSearch.Visible = true;
            prgSearch.Value = 50;
            btnSearch.Text = "&Cancel";
        }

        private void EndSearch() {
            _isSearching = false;
            prgSearch.Visible = false;
            prgSearch.Value = 0;
            btnSearch.Text = "&Search";
            lblResults.Text = lstResults.Items.Count.ToString() + " results found";
            lblResults.Visible = true;
        }

        private ListViewItem GetDisplayItem(SvnListEventArgs result) {
            var item = new SvnListViewItem(result);
            item.ImageKey = GetFileKey(result);
            return item;
        }

        private string GetFileKey(SvnListEventArgs result) {
            var key = result.Entry.NodeKind == SvnNodeKind.File ? Path.GetExtension(result.Name) : DIR;
            if (key != DIR && !imgFileTypes.Images.ContainsKey(key)) {
                imgFileTypes.Images.Add(key, _icons.GetFileTypeIcon(key));
            }
            return key;
        }

        private void RefreshMru() {
            cmbUrl.Items.Clear();
            foreach (var item in _mru.Files) {
                cmbUrl.Items.Add(item);
            }
        }

        #endregion

        #region -  SvnListViewItem  -

        private class SvnListViewItem : ListViewItem {
            public SvnListViewItem(SvnListEventArgs result) {
                Result = result;
                Text = result.Name;
                SubItems.Add(result.Path);
                SubItems.Add(result.Entry.Revision.ToString());
                SubItems.Add(result.Entry.Author);

                var sizeUnit = "bytes";
                var size = (decimal)result.Entry.FileSize;
                if (size > 1024) { size /= 1024; sizeUnit = "KB"; }
                if (size > 1024) { size /= 1024; sizeUnit = "MB"; }
                if (size > 1024) { size /= 1024; sizeUnit = "GB"; }
                size = Math.Round(size, 2);
                SubItems.Add((size > 0) ? size.ToString() + sizeUnit : string.Empty);

                SubItems.Add(result.Entry.Time.ToString("dd/MM/yyyy HH:mm:ss"));
            }
            public SvnListEventArgs Result { get; private set; }
        }

        #endregion
    }
}