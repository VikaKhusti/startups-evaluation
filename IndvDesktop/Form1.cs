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
                MaterialSkin.TextShade.WHITE
                );

            cmxA1.DataSource = Parameters.arrayA1;
            cmxA2.DataSource = Parameters.arrayA2;
            cmxA3.DataSource = Parameters.arrayA3;

            cb1.SelectedIndex = 9;
            cb2.SelectedIndex = 7;
            cb3.SelectedIndex = 8;

            this.Text = "Оцінювання стартап проектів за цілями інвесторів";
        }
        public static DataTable dt;
        private void cmbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = ExcelHelper.tableCollection[cmbSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ExcelHelper.OpenExcelFile(txtFileName, cmbSheet);
        }

        private void cmxA1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameters.results[0] = cmxA1.SelectedIndex;
        }

        private void cmxA2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameters.results[1] = cmxA2.SelectedIndex;
        }

        private void cmxA3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameters.results[2] = cmxA3.SelectedIndex;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show(
                    "Не вірно внесені дані",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameters.coefficients[0] = cb1.SelectedIndex + 1;
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameters.coefficients[1] = cb2.SelectedIndex + 1;
        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parameters.coefficients[2] = cb3.SelectedIndex + 1;
        }


    }
}
