
namespace IndvDesktop
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rankingSeriesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.rankingSeriesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingSeriesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 213);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1288, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(26, 148);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "TABLE II";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(26, 494);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(65, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "TABLE III";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 560);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.Size = new System.Drawing.Size(1288, 256);
            this.dataGridView2.TabIndex = 3;
            // 
            // rankingSeriesLabel
            // 
            this.rankingSeriesLabel.AutoSize = true;
            this.rankingSeriesLabel.Depth = 0;
            this.rankingSeriesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rankingSeriesLabel.Location = new System.Drawing.Point(26, 879);
            this.rankingSeriesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rankingSeriesLabel.Name = "rankingSeriesLabel";
            this.rankingSeriesLabel.Size = new System.Drawing.Size(1, 0);
            this.rankingSeriesLabel.TabIndex = 5;
            // 
            // rankingSeriesChart
            // 
            chartArea2.Name = "ChartArea1";
            this.rankingSeriesChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend3";
            this.rankingSeriesChart.Legends.Add(legend2);
            this.rankingSeriesChart.Location = new System.Drawing.Point(1336, 213);
            this.rankingSeriesChart.Name = "rankingSeriesChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend3";
            series2.Name = "Проект pn";
            this.rankingSeriesChart.Series.Add(series2);
            this.rankingSeriesChart.Size = new System.Drawing.Size(805, 366);
            this.rankingSeriesChart.TabIndex = 7;
            this.rankingSeriesChart.Text = "chart1";
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Depth = 0;
            this.resLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resLabel.Location = new System.Drawing.Point(572, 1018);
            this.resLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(1, 0);
            this.resLabel.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2229, 1319);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.rankingSeriesChart);
            this.Controls.Add(this.rankingSeriesLabel);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankingSeriesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialLabel rankingSeriesLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart rankingSeriesChart;
        private MaterialSkin.Controls.MaterialLabel resLabel;
    }
}