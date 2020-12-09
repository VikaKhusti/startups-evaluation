using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Forms.DataVisualization.Charting;

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
            FillChart();
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
                    dataGridView1[j, i].Value = Math.Round(Math.Abs(ui[i] - Convert.ToDouble(dtI.Rows[i][j]))
                        / Math.Max(ui[i] - GetMinMax(dtI, i).Item1, GetMinMax(dtI, i).Item2 - ui[i]), 3);
                    dataGridView2[j, i].Value = Math.Round(1 - Convert.ToDouble(dtII.Rows[i][j]),3);
                }
            }

        }

        private Tuple<double, double> GetMinMax(DataTable dt, int row)
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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Parameters.z[j] += Parameters.GetWi(i) * Convert.ToDouble(dtIII.Rows[i][j+1]);
                }
            }

            rankingSeriesLabel.Text = "{ p1 = " 
                + Math.Round(Parameters.z[0],3).ToString() + ", p2 = "
                + Math.Round(Parameters.z[1], 3).ToString() + ", p3 = "
                + Math.Round(Parameters.z[2], 3).ToString() + ", p4 = "
                + Math.Round(Parameters.z[3], 3).ToString() + ", p5 = "
                + Math.Round(Parameters.z[4], 3).ToString() + " }";

            double max = Parameters.z.Max();
            int index = Array.IndexOf(Parameters.z, max);
            resLabel.Text = "Hайкращий стартап проект враховуючи цілі інвесторів – p" + index+1 + " з найбільшою оцінкою " + Math.Round(max, 3);

        }      
                
                
        private void FillChart()
        {
            rankingSeriesChart.Series[0].Points.DataBindY(Parameters.z);
            System.Windows.Forms.DataVisualization.Charting.Axis axisX = rankingSeriesChart.ChartAreas[0].AxisX;
            double axisLabelPos = 0.5;
            for (int i = 0; i < 5; i++)
            {
                axisX.CustomLabels.Add(axisLabelPos, axisLabelPos + 1, Parameters.labels[i]);
                axisLabelPos = axisLabelPos + 1.0;
            }
        }
    }
}
