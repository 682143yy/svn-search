using SharpSvn;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SvnSearch.Search {
    public class ResultValidator {
        #region -  Fields  -

        private Regex _cachedRegex;

        #endregion
        #region -  Constructor  -

        public ResultValidator() : this(string.Empty) { }

        public ResultValidator(string text) : this(text, ValidatorType.Text) { }

        public ResultValidator(string text, ValidatorType type) : this(text, type, false) { }

        public ResultValidator(string text, bool caseSensitive) : this(text, ValidatorType.Text, caseSensitive) { }

        public ResultValidator(string text, ValidatorType type, bool caseSensitive) {
            SearchText = text;
            Type = type;
            CaseSensitive = caseSensitive;
        }

        #endregion

        #region -  Properties  -

        public bool CaseSensitive { get; set; }
        public ValidatorType Type { get; set; }
        public string SearchText { get; set; }
        public string FileFilter { get; set; }
        public string AuthorFilter { get; set; }

        #endregion

        #region -  Methods -

        public bool Validate(SvnListEventArgs result) {
            if (!MatchFilter(FileFilter, result.Name)) { return false; }
            if (!MatchFilter(AuthorFilter, result.Entry.Author)) { return false; }
            switch (Type) {
                case ValidatorType.Regex: return _cachedRegex.IsMatch(Path.GetFileNameWithoutExtension(result.Name));
                default: return result.Name.IndexOf(SearchText, CaseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1;
            }
        }

        #endregion

        #region -  Private Methods  -

        private void RefreshRegex() {
            if (Type != ValidatorType.Regex) {
                _cachedRegex = null; return;
            }
            _cachedRegex = new Regex(SearchText, RegexOptions.Singleline | ((CaseSensitive) ? RegexOptions.None : RegexOptions.IgnoreCase));
        }

        private bool MatchFilter(string filter, string input) {
            if (string.IsNullOrWhiteSpace(filter) || filter.Trim() == "*.*") return true;

            var parts = filter.Split('|');
            if (parts.Length < 1) return true;
            foreach(var p in parts) {
                var part = p.Trim();
                var invert = false;
                if (part.StartsWith("-")) { invert = true; part = part.Substring(1); }
                var regex = "^" + part.Replace(".", "\\.").Replace("*", ".*") + "$";
                if (invert != Regex.IsMatch(input, regex)) return true;
            }
            return false;
        }

        #endregion
    }
}