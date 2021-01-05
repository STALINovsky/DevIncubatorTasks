using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task24
{
    /// <summary>
    /// Class for describing information in table format
    /// </summary>
    /// <typeparam name="TRow"></typeparam>
    class Table<TRow> : IEnumerable<TRow>
    {
        private readonly List<TRow> _rows = new List<TRow>();
        private readonly string _tableHeader;

        public Table(string tableHeader)
        {
            this._tableHeader = tableHeader;
        }

        public Table(string tableHeader, IEnumerable<TRow> initialData) : this(tableHeader)
        {
            this._rows.AddRange(initialData);
        }

        public void AddRow(TRow row)
        {
            _rows.Add(row);
        }

        public override string ToString()
        {
            var tableDataStringBuilder = new StringBuilder();
            tableDataStringBuilder.AppendLine(_tableHeader);

            tableDataStringBuilder.AppendJoin('\n', _rows);

            return tableDataStringBuilder.ToString();
        }

        public IEnumerator<TRow> GetEnumerator()
        {
            return _rows.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _rows.GetEnumerator();
        }
    }
}
