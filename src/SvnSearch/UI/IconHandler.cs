using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace SvnSearch.UI {
    internal static class IconHandler {
        #region -  Native  -

#pragma warning disable 649, 169

        private struct SHFILEINFO {
            internal IntPtr hIcon;
            internal IntPtr iSIcon;
            internal uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            internal string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            internal string szTypeName;
        };

        [Flags]
        private enum FileInfoFlags {
            SHGFI_ICON = 0x000000100,
            SHGFI_USEFILEATTRIBUTES = 0x000000010
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA2101:SpecifyMarshalingForPInvokeStringArguments", MessageId = "0")]
        [DllImport("Shell32", CharSet = CharSet.Auto)]
        private extern static IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, out SHFILEINFO psfi, int cbFileInfo, FileInfoFlags uFlags);

#pragma warning restore 649, 169

        #endregion

        /// <summary>
        /// Gets the icon that represents the given file extension.
        /// </summary>
        /// <param name="extension"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        internal static Icon IconFromExtension(string extension, IconSize size) {
            if (extension == null) throw new ArgumentNullException("extension");
            if (extension.Length == 0 || extension == ".") throw new ArgumentException("Empty extension", "extension");
            if (extension[0] != '.') extension = '.' + extension;

            var fileInfo = new SHFILEINFO();
            SHGetFileInfo(extension, 0, out fileInfo, Marshal.SizeOf(fileInfo), FileInfoFlags.SHGFI_ICON | FileInfoFlags.SHGFI_USEFILEATTRIBUTES | (FileInfoFlags)size);
            return Icon.FromHandle(fileInfo.hIcon);
        }
    }
}