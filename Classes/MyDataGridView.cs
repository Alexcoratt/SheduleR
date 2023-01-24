using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleR.Classes
{
    class MyDataGridView : DataGridView
    {
        public Dictionary<string, string> colDBNames;
        public MyDataGridView() : base() { }

        public void AddRow(Dictionary<string, object> dict)
        {
            int rowIndex = Rows.Add();
            DataGridViewRow row = Rows[rowIndex];
            for (int i = 0; i < row.Cells.Count; i++)
            {
                object value;
                if (dict.TryGetValue(colDBNames[Columns[i].Name], out value))
                    row.Cells[i].Value = value;
                else
                    row.Cells[i].Value = Columns[i].Name;
            }
        }

        public void AddEcho(Echo echo)
        {
            List<int> rowIndexes = new List<int>();
            int echoHeight = echo.GetHeight();
            int i;
            for (i = 0; i < echoHeight; i++)
                rowIndexes.Add(Rows.Add());

            foreach (int rowIndex in rowIndexes)
                for (i = 0; i < Columns.Count; i++)
                {
                    string dbName;
                    if (!colDBNames.TryGetValue(Columns[i].Name, out dbName))
                        dbName = Columns[i].Name;
                    Rows[rowIndex].Cells[i].Value = echo.GetValue(rowIndex - rowIndexes.First(), dbName, "");
                }
        }
    }
}
