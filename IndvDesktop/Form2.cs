using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndvDesktop
{
    public partial class Form2 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public Form2()
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
            InitializeDataGridView();

        }

        double[] ui = new double[3];
       // DataGridView dgv;
        DataTable dtI = Form1.dt;
        DataTable dtII = new DataTable();
        private void InitializeDataGridView()
        {
            dtII = dtI.Copy();
            dataGridView1.DataSource = dtII;

            for (int i = 0; i < 3; i++)
            {
                ui[i] = Parameters.values[Parameters.results[i]];
            }

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    dataGridView1[j, i].Value = Math.Abs(ui[i] - Convert.ToDouble(dtI.Rows[i][j]))
                        / Math.Max(ui[i] - GetMinMax(dtI,i).Item1, GetMinMax(dtI, i).Item2 - ui[i]);
                }
            }

        }
        
        private Tuple<double, double> GetMinMax (DataTable dt, int row)
        {
            List<double> cells = new List<double>();
            for (int i = 1; i <= 5; i++)
            {
                cells.Add(Convert.ToDouble(dt.Rows[row][i]));
            }
            double min = Convert.ToDouble(cells.Min()); double max = Convert.ToDouble(cells.Max());
            return Tuple.Create(min, max);
        }
    }
}
