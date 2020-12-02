using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace IndvDesktop
{
    class ExcelHelper
    {
        public static DataTableCollection tableCollection;
        public static void OpenExcelFile(MaterialSkin.Controls.MaterialTextBox tb, ComboBox cb)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = ("*.xls|*xlsx") })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tb.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet data = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = data.Tables;
                            cb.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cb.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }
    }
}
