﻿using System.Collections;
using System.Collections.Generic;

namespace FikaAmazonAPI.ReportGeneration.ReportDataTable
{
    public class TableRows : IEnumerable<TableRow>
    {
        private readonly List<TableRow> innerList = new List<TableRow>();

        public int Count => innerList.Count;

        public TableRow this[int index] => innerList[index];

        public IEnumerator<TableRow> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        internal void Add(TableRow row)
        {
            innerList.Add(row);
        }
    }
}