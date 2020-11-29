using ExcelDataReader;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndvDesktop
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Pink200,
                MaterialSkin.TextShade.WHITE);

            //int x = SystemInformation.WorkingArea.Width;
            //int y = SystemInformation.WorkingArea.Height;
            //Form1 form = new Form1();
            //form.WindowState = FormWindowState.Normal;
            //form.Location = new Point(0, 0);
            //form.Size = new Size(x, y);
        }

        private void cmbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cmbSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }

        DataTableCollection tableCollection;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = ("*.xls|*xlsx") })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet data = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = data.Tables;
                            cmbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cmbSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }

        //    private void btnOpenGoalWind_Click(object sender, EventArgs e)
        //    {
        //        InputForm form = new InputForm();
        //        form.ShowDialog();
        //    }
    }
}
