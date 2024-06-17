using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using FikaAmazonAPI.AmazonSpApiSDK.Models.Exceptions;

namespace FikaAmazonAPI.ReportGeneration.ReportDataTable
{
    public class TableRow : IDictionary<string, string>
    {
        private readonly string[] items;
        private readonly Table table;

        internal TableRow(Table table, string[] items)
        {
            for (var colIndex = 0; colIndex < items.Length; colIndex++)
                items[colIndex] = items[colIndex] ?? string.Empty;

            this.table = table;
            this.items = items;
        }

        public string this[int index] => items[index];

        public string this[string header]
        {
            get
            {
                var itemIndex = table.GetHeaderIndex(header);
                return items[itemIndex];
            }
            set
            {
                var keyIndex = table.GetHeaderIndex(header);
                items[keyIndex] = value;
            }
        }

        public int Count => items.Length;

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            Debug.Assert(items.Length == table.Header.Count());
            var itemIndex = 0;
            foreach (var header in table.Header)
            {
                yield return new KeyValuePair<string, string>(header, items[itemIndex]);
                itemIndex++;
            }
        }

        private AmazonException ThrowTableStructureCannotBeModified()
        {
            return new AmazonException(
                "The table rows must contain the same number of items as the header count of the table. The structure cannot be modified.");
        }

        #region Implementation of ICollection<KeyValuePair<string,string>>

        void ICollection<KeyValuePair<string, string>>.Add(KeyValuePair<string, string> item)
        {
            throw ThrowTableStructureCannotBeModified();
        }

        void ICollection<KeyValuePair<string, string>>.Clear()
        {
            throw ThrowTableStructureCannotBeModified();
        }

        bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item)
        {
            var keyIndex = table.GetHeaderIndex(item.Key, false);
            if (keyIndex < 0)
                return false;
            return items[keyIndex].Equals(item.Value);
        }

        void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
        {
            throw ThrowTableStructureCannotBeModified();
        }

        bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item)
        {
            throw ThrowTableStructureCannotBeModified();
        }

        bool ICollection<KeyValuePair<string, string>>.IsReadOnly => false;

        #endregion

        #region Implementation of IDictionary<string,string>

        public bool ContainsKey(string key)
        {
            return table.Header.Contains(key);
        }

        void IDictionary<string, string>.Add(string key, string value)
        {
            throw ThrowTableStructureCannotBeModified();
        }

        bool IDictionary<string, string>.Remove(string key)
        {
            throw ThrowTableStructureCannotBeModified();
        }

        public bool TryGetValue(string key, out string value)
        {
            var keyIndex = table.GetHeaderIndex(key, false);
            if (keyIndex < 0)
            {
                value = null;
                return false;
            }

            value = items[keyIndex];
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public ICollection<string> Keys => table.Header;

        public ICollection<string> Values => items;

        #endregion
    }
}