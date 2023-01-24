using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScheduleR.Classes.Exceptions;

namespace ScheduleR.Classes
{
    public class Echo
    {
        private Dictionary<string, List<object>> values;

        public Echo() {
            values = new Dictionary<string, List<object>>();
        }

        public void AddColumns(params string[] colNames)
        {
            foreach (string colName in colNames)
                values.Add(colName, new List<object>());
        }

        public void AddRows(params Dictionary<string, object>[] rows)
        {
            foreach (Dictionary<string, object> row in rows)
                foreach (string key in values.Keys)
                {
                    object value;
                    if (row.TryGetValue(key, out value))
                        values[key].Add(value);
                    else
                        values[key].Add(null);
                }
        }

        public void AddValue(string key, object value)
        {
            values[key].Add(value);
        }

        public object GetValue(int row, string key, object defaultValue = null)
        {
            try
            {
                return values[key][row];
            } catch (Exception err)
            {
                return defaultValue;
            }
        }

        public int GetHeight()
        {
            if (values.Values.Count > 0)
                return values.Values.First().Count;
            return 0;
        }

        public string ToString(bool showHeader = false)
        {
            StringBuilder sb = new StringBuilder();
            if (showHeader) {
                foreach (string key in values.Keys)
                    sb.Append(key).Append(" ");
                sb.AppendLine();
            }

            int width = values.Keys.Count, i = 0;
            IEnumerator[] enumerators = new IEnumerator[width];
            foreach (string key in values.Keys)
            {
                enumerators[i++] = values[key].GetEnumerator();
            }

            bool running = true;
            while (running)
            {
                foreach (IEnumerator enumerator in enumerators)
                {
                    running = enumerator.MoveNext();
                    if (running)
                        sb.Append(enumerator.Current.ToString()).Append(" ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public Dictionary<string, object> RowToDict(int lineNum)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            foreach (string key in values.Keys)
                result.Add(key, values[key][lineNum]);
            return result;
        }
    }
}
