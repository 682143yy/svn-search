namespace SvnSearch {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.cmbUrl = new System.Windows.Forms.ComboBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.rdoRegex = new System.Windows.Forms.RadioButton();
            this.txtSearchFor = new System.Windows.Forms.TextBox();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.grpLimit = new System.Windows.Forms.GroupBox();
            this.chkIncludeSubfolders = new System.Windows.Forms.CheckBox();
            this.rdoHeadRevision = new System.Windows.Forms.RadioButton();
            this.rdoRevision = new System.Windows.Forms.RadioButton();
            this.txtFilterByAuthor = new System.Windows.Forms.TextBox();
            this.txtFileFilter = new System.Windows.Forms.TextBox();
            this.lblFilterByAuthor = new System.Windows.Forms.Label();
            this.lblFilterHelp = new System.Windows.Forms.Label();
            this.lblFileFilter = new System.Windows.Forms.Label();
            this.txtRevision = new System.Windows.Forms.TextBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lstResults = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRevision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgFileTypes = new System.Windows.Forms.ImageList(this.components);
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.prgSearch = new System.Windows.Forms.ToolStripProgressBar();
            this.lblResults = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctxResults = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showInTortoiseSVNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLocation.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpLimit.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.stsMain.SuspendLayout();
            this.ctxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(6, 21);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(76, 22);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "URL";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(706, 254);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpLocation
            // 
            this.grpLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLocation.Controls.Add(this.cmbUrl);
            this.grpLocation.Controls.Add(this.lblLocation);
            this.grpLocation.Location = new System.Drawing.Point(12, 12);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(775, 55);
            this.grpLocation.TabIndex = 0;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location";
            // 
            // cmbUrl
            // 
            this.cmbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUrl.FormattingEnabled = true;
            this.cmbUrl.Location = new System.Drawing.Point(88, 22);
            this.cmbUrl.Name = "cmbUrl";
            this.cmbUrl.Size = new System.Drawing.Size(681, 21);
            this.cmbUrl.TabIndex = 1;
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.Controls.Add(this.chkCaseSensitive);
            this.grpSearch.Controls.Add(this.rdoText);
            this.grpSearch.Controls.Add(this.rdoRegex);
            this.grpSearch.Controls.Add(this.txtSearchFor);
            this.grpSearch.Controls.Add(this.lblSearchFor);
            this.grpSearch.Location = new System.Drawing.Point(12, 73);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(775, 72);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(201, 47);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(98, 17);
            this.chkCaseSensitive.TabIndex = 4;
            this.chkCaseSensitive.Text = "Case-sensitive";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.Checked = true;
            this.rdoText.Location = new System.Drawing.Point(88, 46);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(45, 17);
            this.rdoText.TabIndex = 2;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Text";
            this.rdoText.UseVisualStyleBackColor = true;
            // 
            // rdoRegex
            // 
            this.rdoRegex.AutoSize = true;
            this.rdoRegex.Location = new System.Drawing.Point(139, 46);
            this.rdoRegex.Name = "rdoRegex";
            this.rdoRegex.Size = new System.Drawing.Size(56, 17);
            this.rdoRegex.TabIndex = 3;
            this.rdoRegex.Text = "Regex";
            this.rdoRegex.UseVisualStyleBackColor = true;
            // 
            // txtSearchFor
            // 
            this.txtSearchFor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchFor.Location = new System.Drawing.Point(88, 18);
            this.txtSearchFor.Name = "txtSearchFor";
            this.txtSearchFor.Size = new System.Drawing.Size(681, 22);
            this.txtSearchFor.TabIndex = 1;
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.Location = new System.Drawing.Point(6, 18);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(76, 22);
            this.lblSearchFor.TabIndex = 0;
            this.lblSearchFor.Text = "Search for";
            this.lblSearchFor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpLimit
            // 
            this.grpLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLimit.Controls.Add(this.chkIncludeSubfolders);
            this.grpLimit.Controls.Add(this.rdoHeadRevision);
            this.grpLimit.Controls.Add(this.rdoRevision);
            this.grpLimit.Controls.Add(this.txtFilterByAuthor);
            this.grpLimit.Controls.Add(this.txtFileFilter);
            this.grpLimit.Controls.Add(this.lblFilterByAuthor);
            this.grpLimit.Controls.Add(this.lblFilterHelp);
            this.grpLimit.Controls.Add(this.lblFileFilter);
            this.grpLimit.Controls.Add(this.txtRevision);
            this.grpLimit.Location = new System.Drawing.Point(12, 151);
            this.grpLimit.Name = "grpLimit";
            this.grpLimit.Size = new System.Drawing.Size(775, 97);
            this.grpLimit.TabIndex = 2;
            this.grpLimit.TabStop = false;
            this.grpLimit.Text = "Limit";
            // 
            // chkIncludeSubfolders
            // 
            this.chkIncludeSubfolders.AutoSize = true;
            this.chkIncludeSubfolders.Location = new System.Drawing.Point(11, 21);
            this.chkIncludeSubfolders.Name = "chkIncludeSubfolders";
            this.chkIncludeSubfolders.Size = new System.Drawing.Size(122, 17);
            this.chkIncludeSubfolders.TabIndex = 0;
            this.chkIncludeSubfolders.Text = "Include subfolders";
            this.chkIncludeSubfolders.UseVisualStyleBackColor = true;
            // 
            // rdoHeadRevision
            // 
            this.rdoHeadRevision.AutoSize = true;
            this.rdoHeadRevision.Checked = true;
            this.rdoHeadRevision.Location = new System.Drawing.Point(11, 44);
            this.rdoHeadRevision.Name = "rdoHeadRevision";
            this.rdoHeadRevision.Size = new System.Drawing.Size(97, 17);
            this.rdoHeadRevision.TabIndex = 1;
            this.rdoHeadRevision.TabStop = true;
            this.rdoHeadRevision.Text = "HEAD revision";
            this.rdoHeadRevision.UseVisualStyleBackColor = true;
            // 
            // rdoRevision
            // 
            this.rdoRevision.AutoSize = true;
            this.rdoRevision.Location = new System.Drawing.Point(11, 67);
            this.rdoRevision.Name = "rdoRevision";
            this.rdoRevision.Size = new System.Drawing.Size(68, 17);
            this.rdoRevision.TabIndex = 2;
            this.rdoRevision.Text = "Revision";
            this.rdoRevision.UseVisualStyleBackColor = true;
            this.rdoRevision.CheckedChanged += new System.EventHandler(this.rdoRevision_CheckedChanged);
            // 
            // txtFilterByAuthor
            // 
            this.txtFilterByAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterByAuthor.Location = new System.Drawing.Point(280, 19);
            this.txtFilterByAuthor.Name = "txtFilterByAuthor";
            this.txtFilterByAuthor.Size = new System.Drawing.Size(489, 22);
            this.txtFilterByAuthor.TabIndex = 5;
            // 
            // txtFileFilter
            // 
            this.txtFileFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileFilter.Location = new System.Drawing.Point(280, 45);
            this.txtFileFilter.Name = "txtFileFilter";
            this.txtFileFilter.Size = new System.Drawing.Size(489, 22);
            this.txtFileFilter.TabIndex = 7;
            this.txtFileFilter.Text = "*.*";
            // 
            // lblFilterByAuthor
            // 
            this.lblFilterByAuthor.Location = new System.Drawing.Point(186, 19);
            this.lblFilterByAuthor.Name = "lblFilterByAuthor";
            this.lblFilterByAuthor.Size = new System.Drawing.Size(88, 22);
            this.lblFilterByAuthor.TabIndex = 4;
            this.lblFilterByAuthor.Text = "Filter by author";
            this.lblFilterByAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFilterHelp
            // 
            this.lblFilterHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterHelp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterHelp.Location = new System.Drawing.Point(280, 71);
            this.lblFilterHelp.Name = "lblFilterHelp";
            this.lblFilterHelp.Size = new System.Drawing.Size(489, 17);
            this.lblFilterHelp.TabIndex = 8;
            this.lblFilterHelp.Text = "Use \'|\' to separate multiple patterns, prepend \'-\' to exclude.";
            // 
            // lblFileFilter
            // 
            this.lblFileFilter.Location = new System.Drawing.Point(186, 45);
            this.lblFileFilter.Name = "lblFileFilter";
            this.lblFileFilter.Size = new System.Drawing.Size(88, 22);
            this.lblFileFilter.TabIndex = 6;
            this.lblFileFilter.Text = "File filter";
            this.lblFileFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRevision
            // 
            this.txtRevision.Enabled = false;
            this.txtRevision.Location = new System.Drawing.Point(88, 66);
            this.txtRevision.Name = "txtRevision";
            this.txtRevision.Size = new System.Drawing.Size(69, 22);
            this.txtRevision.TabIndex = 3;
            // 
            // grpResults
            // 
            this.grpResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResults.Controls.Add(this.lstResults);
            this.grpResults.Location = new System.Drawing.Point(12, 283);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(775, 264);
            this.grpResults.TabIndex = 4;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmPath,
            this.clmRevision,
            this.clmAuthor,
            this.clmSize,
            this.clmDate});
            this.lstResults.ContextMenuStrip = this.ctxResults;
            this.lstResults.FullRowSelect = true;
            this.lstResults.Location = new System.Drawing.Point(11, 21);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(758, 237);
            this.lstResults.SmallImageList = this.imgFileTypes;
            this.lstResults.TabIndex = 0;
            this.lstResults.UseCompatibleStateImageBehavior = false;
            this.lstResults.View = System.Windows.Forms.View.Details;
            this.lstResults.DoubleClick += new System.EventHandler(this.lstResults_DoubleClick);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 199;
            // 
            // clmPath
            // 
            this.clmPath.Text = "Path";
            this.clmPath.Width = 243;
            // 
            // clmRevision
            // 
            this.clmRevision.Text = "Revision";
            // 
            // clmAuthor
            // 
            this.clmAuthor.Text = "Author";
            // 
            // clmSize
            // 
            this.clmSize.Text = "Size";
            this.clmSize.Width = 68;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Date";
            this.clmDate.Width = 120;
            // 
            // imgFileTypes
            // 
            this.imgFileTypes.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgFileTypes.ImageSize = new System.Drawing.Size(16, 16);
            this.imgFileTypes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prgSearch,
            this.lblResults});
            this.stsMain.Location = new System.Drawing.Point(0, 550);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(799, 22);
            this.stsMain.TabIndex = 5;
            this.stsMain.Text = "statusStrip1";
            // 
            // prgSearch
            // 
            this.prgSearch.Name = "prgSearch";
            this.prgSearch.Size = new System.Drawing.Size(100, 16);
            this.prgSearch.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgSearch.Visible = false;
            // 
            // lblResults
            // 
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(85, 17);
            this.lblResults.Text = "0 results found";
            this.lblResults.Visible = false;
            // 
            // ctxResults
            // 
            this.ctxResults.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInTortoiseSVNToolStripMenuItem,
            this.showLogToolStripMenuItem,
            this.blameToolStripMenuItem});
            this.ctxResults.Name = "ctxResults";
            this.ctxResults.Size = new System.Drawing.Size(187, 92);
            this.ctxResults.Opening += new System.ComponentModel.CancelEventHandler(this.ctxResults_Opening);
            // 
            // showInTortoiseSVNToolStripMenuItem
            // 
            this.showInTortoiseSVNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInTortoiseSVNToolStripMenuItem.Image = global::SvnSearch.Properties.Resources.Tortoise16;
            this.showInTortoiseSVNToolStripMenuItem.Name = "showInTortoiseSVNToolStripMenuItem";
            this.showInTortoiseSVNToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showInTortoiseSVNToolStripMenuItem.Text = "Show in &TortoiseSVN";
            this.showInTortoiseSVNToolStripMenuItem.Click += new System.EventHandler(this.showInTortoiseSVNToolStripMenuItem_Click);
            // 
            // showLogToolStripMenuItem
            // 
            this.showLogToolStripMenuItem.Image = global::SvnSearch.Properties.Resources.ShowLog16;
            this.showLogToolStripMenuItem.Name = "showLogToolStripMenuItem";
            this.showLogToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showLogToolStripMenuItem.Text = "Show &Log";
            this.showLogToolStripMenuItem.Click += new System.EventHandler(this.showLogToolStripMenuItem_Click);
            // 
            // blameToolStripMenuItem
            // 
            this.blameToolStripMenuItem.Image = global::SvnSearch.Properties.Resources.Blame16;
            this.blameToolStripMenuItem.Name = "blameToolStripMenuItem";
            this.blameToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.blameToolStripMenuItem.Text = "&Blame...";
            this.blameToolStripMenuItem.Click += new System.EventHandler(this.blameToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 572);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpLimit);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpLocation);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(660, 460);
            this.Name = "MainForm";
            this.Text = "SVN Search";
            this.grpLocation.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpLimit.ResumeLayout(false);
            this.grpLimit.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.ctxResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearchFor;
        private System.Windows.Forms.Label lblSearchFor;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoRegex;
        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private System.Windows.Forms.GroupBox grpLimit;
        private System.Windows.Forms.CheckBox chkIncludeSubfolders;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.ListView lstResults;
        private System.Windows.Forms.RadioButton rdoRevision;
        private System.Windows.Forms.RadioButton rdoHeadRevision;
        private System.Windows.Forms.TextBox txtRevision;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmPath;
        private System.Windows.Forms.ColumnHeader clmRevision;
        private System.Windows.Forms.ColumnHeader clmAuthor;
        private System.Windows.Forms.ColumnHeader clmSize;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ImageList imgFileTypes;
        private System.Windows.Forms.ComboBox cmbUrl;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripProgressBar prgSearch;
        private System.Windows.Forms.ToolStripStatusLabel lblResults;
        private System.Windows.Forms.TextBox txtFileFilter;
        private System.Windows.Forms.Label lblFileFilter;
        private System.Windows.Forms.Label lblFilterHelp;
        private System.Windows.Forms.TextBox txtFilterByAuthor;
        private System.Windows.Forms.Label lblFilterByAuthor;
        private System.Windows.Forms.ContextMenuStrip ctxResults;
        private System.Windows.Forms.ToolStripMenuItem showInTortoiseSVNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blameToolStripMenuItem;
    }
}

