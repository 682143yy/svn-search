using SharpSvn;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System;
using System.Threading;

namespace SvnSearch.Search {
    public class SvnSearcher {
        #region -  Fields  -

        private readonly SvnTarget _target;

        #endregion

        #region -  Constructors  -

        public SvnSearcher(Uri location, SvnRevision revision) {
            // todo: Implement IDisposable.
            // todo: Make sure location and revision aren't null.
            _target = new SvnUriTarget(location, revision);
        }

        #endregion

        #region -  Methods  -

        public async Task<List<SvnListEventArgs>> SearchAsync(string searchText, bool caseSensitive, ValidatorType type, string fileFilter, string authorFilter, bool recursive, CancellationToken token, IProgress<SvnListEventArgs> progress) {
            return await Task.Run(
                () => SearchInternal(searchText, caseSensitive, type, fileFilter, authorFilter, recursive, token, progress), 
                token
            );
        }

        private List<SvnListEventArgs> SearchInternal(string searchText, bool caseSensitive, ValidatorType type, string fileFilter, string authorFilter, bool recursive, CancellationToken token, IProgress<SvnListEventArgs> progress) {
            using (var client = new SvnClient()) { 
                var results = new Collection<SvnListEventArgs>();
                var args = new SvnListArgs() {
                    RetrieveEntries = SvnDirEntryItems.AllFieldsV15,
                    Depth = (recursive) ? SvnDepth.Infinity : SvnDepth.Children
                };
                var validator = new ResultValidator() {
                    SearchText = searchText,
                    CaseSensitive = caseSensitive,
                    FileFilter = fileFilter,
                    AuthorFilter = authorFilter,
                    Type = type
                };

                if (token != null) { args.Cancel += (sender, e) => e.Cancel = token.IsCancellationRequested; }
                if (progress != null) {
                    args.List += (sender, e) => {
                        if (!string.IsNullOrEmpty(e.Path) && validator.Validate(e)) {
                            progress.Report(e);
                        }
                    };
                }
                try {
                    if (!client.GetList(_target, args, out results)) { return null; }

                    return (from r in results where !string.IsNullOrEmpty(r.Path) && validator.Validate(r) select r).ToList();
                } catch (SvnOperationCanceledException) {
                    token.ThrowIfCancellationRequested();
                    return null;
                }
            }
        }

        private void Args_List(object sender, SvnListEventArgs e) {
            throw new NotImplementedException();
        }

        #endregion
    }
}