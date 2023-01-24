using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleR.Classes
{
    public class Echo
    {
        private object[,] values;
        private string[] header;

        public Echo(List<Dictionary<string, object>> echo)
        {
            Set(echo);
        }

        public Echo() { }

        public void SetSize(int height, int width)
        {
            values = new object[height, width];
        }

        public void SetHeader(string[] colNames)
        {
            header = colNames;
        }

        public void SetValue(int row, string key, object value)
        {
            int col = Array.IndexOf(header, key);
            if (col < 0)
                throw new KeyNotFoundException();
            SetValue(row, col, value);
        }

        public void SetValue(int row, int col, object value)
        {
            values[row, col] = value;
        }
        
        public object GetValue(int row, string key)
        {
            int col = Array.IndexOf(header, key);
            if (col < 0)
                throw new KeyNotFoundException();
            return GetValue(row, col);
        }

        public object GetValue(int row, int col)
        {
            return values[row, col];
        }

        public void Set(List<Dictionary<string, object>> echo)
        {
            if (echo.Count > 0)
            {
                header = echo.First().Keys.ToArray();
                values = new object[echo.Count, header.Length];
                int i = 0, j;
                foreach (Dictionary<string, object> line in echo)
                {
                    for (j = 0; j < header.Length; j++)
                        values[i, j] = line[header[j]];
                    i++;
                }
            }
        }

        public string ToString(bool includeHead = false)
        {
            StringBuilder sb = new StringBuilder();
            int height = GetHeight();
            if (includeHead)
                sb.Append(string.Join(" ", header)).Append("\n");
            for (int i = 0; i < height - 1; i++)
                sb.Append(string.Join(" ", GetRow(i))).Append("\n");
            sb.Append(string.Join(" ", GetRow(height - 1)));
            
            return sb.ToString();
        }

        public int GetHeight()
        {
            return values.GetLength(0);
        }

        public int GetWidth()
        {
            return values.GetLength(1);
        }

        public object[] GetRow(int rowNumber)
        {
            int width = GetWidth();
            object[] result = new object[width];
            for (int i = 0; i < width; i++)
                result[i] = values[rowNumber, i];
            return result;
        }

        public object[] GetCol(int colNumber)
        {
            int height = GetHeight();
            object[] result = new object[height];
            for (int i = 0; i < height; i++)
                result[i] = values[i, colNumber];
            return result;
        }
    }
}
