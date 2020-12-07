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
            GetResult();
        }

        double[] ui = new double[3];
       // DataGridView dgv;
        DataTable dtI = Form1.dt;
        DataTable dtII = new DataTable();
        DataTable dtIII = new DataTable();

        private void InitializeDataGridView()
        {
            dtII = dtI.Copy();
            dtIII = dtII.Copy();
            dataGridView1.DataSource = dtII;
            dataGridView2.DataSource = dtIII;

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
                    dataGridView2[j, i].Value = 1 - Convert.ToDouble(dtII.Rows[i][j]);
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

        private void GetResult()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Parameters.z[i] += Parameters.GetWi(j) * Convert.ToDouble(dtIII.Rows[++j][i]);
                }
                
            }
            resultLabel.Text = Parameters.z[0].ToString();
        }
    }
}
