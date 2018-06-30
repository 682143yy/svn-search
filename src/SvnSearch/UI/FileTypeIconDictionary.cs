using System.Collections.Generic;
using System.Drawing;

namespace SvnSearch.UI {
    /// <summary>
    /// Provides functionality for retrieving file-type images.
    /// </summary>
    internal class FileTypeIconDictionary {
        #region -  Fields  -

        private readonly Dictionary<string, Icon> _iconCache = new Dictionary<string, Icon>();

        #endregion

        #region -  Constructors  -

        /// <summary>
        /// Initializes a new instance of the <see cref="FileTypeIconDictionary"/> class.
        /// </summary>
        internal FileTypeIconDictionary() { }

        #endregion

        #region -  Methods  -

        /// <summary>
        /// Gets the file type image for the given file extension.
        /// </summary>
        /// <param name="extension">The extension whose file type image to retrieve.</param>
        /// <returns>The image that represents the given file type.</returns>
        internal Icon GetFileTypeIcon(string extension) {
            if (!_iconCache.ContainsKey(extension)) {
                _iconCache.Add(extension, IconHandler.IconFromExtension(extension, IconSize.Small));
            }
            return _iconCache[extension];
        }

        #endregion
    }
}