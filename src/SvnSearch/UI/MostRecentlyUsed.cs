using Microsoft.Win32;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Collections.ObjectModel;
using System;

namespace SvnSearch.UI {
    public class MostRecentlyUsed {
        #region -  Fields  -

        private readonly RegistryKey _mruKey;
        private readonly List<string> _mruFiles = new List<string>();
        private readonly ReadOnlyCollection<string> _readonlyCollection;

        #endregion

        #region -  Constructors  -

        public MostRecentlyUsed() : this("mru") { }

        public MostRecentlyUsed(string subKey) : this(subKey, 10) { }

        public MostRecentlyUsed(string subKey, int maxLength) {
            MaxLength = maxLength;

            var baseAssembly = Assembly.GetCallingAssembly();
            var company = baseAssembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company;
            var product = baseAssembly.GetCustomAttribute<AssemblyProductAttribute>().Product;
            var fullKey = "Software\\" + company + "\\" + product + "\\" + subKey;
            _mruKey = Registry.CurrentUser.CreateSubKey(fullKey);

            _mruFiles = Load();
            _readonlyCollection = new ReadOnlyCollection<string>(_mruFiles);
        }

        #endregion

        #region -  Properties  -

        public int MaxLength { get; set; }
        public ReadOnlyCollection<string> Files { get { return _readonlyCollection; } }

        #endregion

        #region -  Methods  -

        public void Push(string file) {
            // Normalize slashes.
            file = file.Replace('\\', '/').TrimEnd(new char[] { '/' });

            _mruFiles.RemoveAll((item) => item.Equals(file, StringComparison.OrdinalIgnoreCase));

            // Insert new item.
            _mruFiles.Insert(0, file);
            if (_mruFiles.Count > MaxLength) { _mruFiles.RemoveAt(_mruFiles.Count - 1); }

            // Save back to the registry.
            Save(_mruFiles);
        }

        #endregion

        #region -  Private Methods  -

        private List<string> Load() {
            return (from name in _mruKey.GetValueNames() orderby name select _mruKey.GetValue(name).ToString()).ToList();
        }

        private void Save(List<string> values) {
            // Delete old values.
            foreach (var name in _mruKey.GetValueNames()) { _mruKey.DeleteValue(name); }
            // Save new ones.
            for (var x = 0; x < values.Count; x++) {
                _mruKey.SetValue(x.ToString(), values[x]);
            }
        }

        #endregion
    }
}