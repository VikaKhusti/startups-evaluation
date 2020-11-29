
namespace IndvDesktop
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Головна = new System.Windows.Forms.TabPage();
            this.Налаштування = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbSheet = new MaterialSkin.Controls.MaterialComboBox();
            this.txtFileName = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBrowse = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.Головна.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Головна);
            this.materialTabControl1.Controls.Add(this.Налаштування);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(943, 425);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Головна
            // 
            this.Головна.BackColor = System.Drawing.Color.White;
            this.Головна.Controls.Add(this.btnBrowse);
            this.Головна.Controls.Add(this.txtFileName);
            this.Головна.Controls.Add(this.cmbSheet);
            this.Головна.Controls.Add(this.dataGridView1);
            this.Головна.ImageKey = "home32.png";
            this.Головна.Location = new System.Drawing.Point(4, 39);
            this.Головна.Name = "Головна";
            this.Головна.Padding = new System.Windows.Forms.Padding(3);
            this.Головна.Size = new System.Drawing.Size(935, 382);
            this.Головна.TabIndex = 0;
            this.Головна.Text = "Головна";
            // 
            // Налаштування
            // 
            this.Налаштування.BackColor = System.Drawing.Color.White;
            this.Налаштування.ImageKey = "settings32.png";
            this.Налаштування.Location = new System.Drawing.Point(4, 39);
            this.Налаштування.Name = "Налаштування";
            this.Налаштування.Padding = new System.Windows.Forms.Padding(3);
            this.Налаштування.Size = new System.Drawing.Size(850, 340);
            this.Налаштування.TabIndex = 1;
            this.Налаштування.Text = "Налаштування";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home32.png");
            this.imageList1.Images.SetKeyName(1, "settings32.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 133);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbSheet
            // 
            this.cmbSheet.AutoResize = false;
            this.cmbSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSheet.Depth = 0;
            this.cmbSheet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSheet.DropDownHeight = 174;
            this.cmbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSheet.DropDownWidth = 121;
            this.cmbSheet.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSheet.FormattingEnabled = true;
            this.cmbSheet.IntegralHeight = false;
            this.cmbSheet.ItemHeight = 43;
            this.cmbSheet.Location = new System.Drawing.Point(9, 222);
            this.cmbSheet.MaxDropDownItems = 4;
            this.cmbSheet.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSheet.Name = "cmbSheet";
            this.cmbSheet.Size = new System.Drawing.Size(587, 49);
            this.cmbSheet.TabIndex = 2;
            this.cmbSheet.SelectedIndexChanged += new System.EventHandler(this.cmbSheet_SelectedIndexChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Depth = 0;
            this.txtFileName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtFileName.Location = new System.Drawing.Point(9, 158);
            this.txtFileName.MaxLength = 50;
            this.txtFileName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFileName.Multiline = false;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(587, 50);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.Text = "";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Depth = 0;
            this.btnBrowse.DrawShadows = true;
            this.btnBrowse.HighEmphasis = true;
            this.btnBrowse.Icon = null;
            this.btnBrowse.Location = new System.Drawing.Point(603, 161);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(95, 36);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Відкрити";
            this.btnBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowse.UseAccentColor = false;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 425);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.materialTabControl1.ResumeLayout(false);
            this.Головна.ResumeLayout(false);
            this.Головна.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Головна;
        private System.Windows.Forms.TabPage Налаштування;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialComboBox cmbSheet;
        private MaterialSkin.Controls.MaterialTextBox txtFileName;
        private MaterialSkin.Controls.MaterialButton btnBrowse;
    }
}

