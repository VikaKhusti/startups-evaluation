
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmxA3 = new MaterialSkin.Controls.MaterialComboBox();
            this.cmxA2 = new MaterialSkin.Controls.MaterialComboBox();
            this.cmxA1 = new MaterialSkin.Controls.MaterialComboBox();
            this.btnBrowse = new MaterialSkin.Controls.MaterialButton();
            this.txtFileName = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbSheet = new MaterialSkin.Controls.MaterialComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Налаштування = new System.Windows.Forms.TabPage();
            this.cb3 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cb2 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cb1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.Головна.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Налаштування.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Головна);
            this.materialTabControl1.Controls.Add(this.Налаштування);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList2;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(732, 385);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Головна
            // 
            this.Головна.BackColor = System.Drawing.Color.White;
            this.Головна.Controls.Add(this.materialButton1);
            this.Головна.Controls.Add(this.materialLabel4);
            this.Головна.Controls.Add(this.materialLabel3);
            this.Головна.Controls.Add(this.materialLabel2);
            this.Головна.Controls.Add(this.materialLabel1);
            this.Головна.Controls.Add(this.cmxA3);
            this.Головна.Controls.Add(this.cmxA2);
            this.Головна.Controls.Add(this.cmxA1);
            this.Головна.Controls.Add(this.btnBrowse);
            this.Головна.Controls.Add(this.txtFileName);
            this.Головна.Controls.Add(this.cmbSheet);
            this.Головна.Controls.Add(this.dataGridView1);
            this.Головна.ImageKey = "home32.png";
            this.Головна.Location = new System.Drawing.Point(4, 23);
            this.Головна.Name = "Головна";
            this.Головна.Padding = new System.Windows.Forms.Padding(3);
            this.Головна.Size = new System.Drawing.Size(724, 358);
            this.Головна.TabIndex = 0;
            this.Головна.Text = "Головна";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(13, 485);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(118, 36);
            this.materialButton1.TabIndex = 17;
            this.materialButton1.Text = "Внести дані";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(10, 427);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(387, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Компетенції команди розробників стартап проекту";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(10, 371);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(187, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Ризик реалізації проекту";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(10, 320);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(255, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Перспективність стартап проекту";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(10, 287);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(147, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "Внесіть параметри:";
            // 
            // cmxA3
            // 
            this.cmxA3.AutoResize = false;
            this.cmxA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmxA3.Depth = 0;
            this.cmxA3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmxA3.DropDownHeight = 174;
            this.cmxA3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmxA3.DropDownWidth = 121;
            this.cmxA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmxA3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmxA3.FormattingEnabled = true;
            this.cmxA3.IntegralHeight = false;
            this.cmxA3.ItemHeight = 43;
            this.cmxA3.Location = new System.Drawing.Point(403, 413);
            this.cmxA3.MaxDropDownItems = 4;
            this.cmxA3.MouseState = MaterialSkin.MouseState.OUT;
            this.cmxA3.Name = "cmxA3";
            this.cmxA3.Size = new System.Drawing.Size(266, 49);
            this.cmxA3.TabIndex = 12;
            this.cmxA3.SelectedIndexChanged += new System.EventHandler(this.cmxA3_SelectedIndexChanged);
            // 
            // cmxA2
            // 
            this.cmxA2.AutoResize = false;
            this.cmxA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmxA2.Depth = 0;
            this.cmxA2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmxA2.DropDownHeight = 174;
            this.cmxA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmxA2.DropDownWidth = 121;
            this.cmxA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmxA2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmxA2.FormattingEnabled = true;
            this.cmxA2.IntegralHeight = false;
            this.cmxA2.ItemHeight = 43;
            this.cmxA2.Location = new System.Drawing.Point(205, 358);
            this.cmxA2.MaxDropDownItems = 4;
            this.cmxA2.MouseState = MaterialSkin.MouseState.OUT;
            this.cmxA2.Name = "cmxA2";
            this.cmxA2.Size = new System.Drawing.Size(201, 49);
            this.cmxA2.TabIndex = 10;
            this.cmxA2.SelectedIndexChanged += new System.EventHandler(this.cmxA2_SelectedIndexChanged);
            // 
            // cmxA1
            // 
            this.cmxA1.AutoResize = false;
            this.cmxA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmxA1.Depth = 0;
            this.cmxA1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmxA1.DropDownHeight = 174;
            this.cmxA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmxA1.DropDownWidth = 121;
            this.cmxA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmxA1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmxA1.FormattingEnabled = true;
            this.cmxA1.IntegralHeight = false;
            this.cmxA1.ItemHeight = 43;
            this.cmxA1.Location = new System.Drawing.Point(272, 303);
            this.cmxA1.MaxDropDownItems = 4;
            this.cmxA1.MouseState = MaterialSkin.MouseState.OUT;
            this.cmxA1.Name = "cmxA1";
            this.cmxA1.Size = new System.Drawing.Size(582, 49);
            this.cmxA1.TabIndex = 8;
            this.cmxA1.SelectedIndexChanged += new System.EventHandler(this.cmxA1_SelectedIndexChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Depth = 0;
            this.btnBrowse.DrawShadows = true;
            this.btnBrowse.HighEmphasis = true;
            this.btnBrowse.Icon = null;
            this.btnBrowse.Location = new System.Drawing.Point(558, 161);
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
            this.txtFileName.Size = new System.Drawing.Size(542, 50);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.Text = "";
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
            this.cmbSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSheet.FormattingEnabled = true;
            this.cmbSheet.IntegralHeight = false;
            this.cmbSheet.ItemHeight = 43;
            this.cmbSheet.Location = new System.Drawing.Point(9, 222);
            this.cmbSheet.MaxDropDownItems = 4;
            this.cmbSheet.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSheet.Name = "cmbSheet";
            this.cmbSheet.Size = new System.Drawing.Size(542, 49);
            this.cmbSheet.TabIndex = 2;
            this.cmbSheet.SelectedIndexChanged += new System.EventHandler(this.cmbSheet_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(644, 133);
            this.dataGridView1.TabIndex = 0;
            // 
            // Налаштування
            // 
            this.Налаштування.BackColor = System.Drawing.Color.White;
            this.Налаштування.Controls.Add(this.cb3);
            this.Налаштування.Controls.Add(this.materialLabel7);
            this.Налаштування.Controls.Add(this.cb2);
            this.Налаштування.Controls.Add(this.materialLabel6);
            this.Налаштування.Controls.Add(this.cb1);
            this.Налаштування.Controls.Add(this.materialLabel5);
            this.Налаштування.ImageKey = "settings32.png";
            this.Налаштування.Location = new System.Drawing.Point(4, 23);
            this.Налаштування.Name = "Налаштування";
            this.Налаштування.Padding = new System.Windows.Forms.Padding(3);
            this.Налаштування.Size = new System.Drawing.Size(724, 358);
            this.Налаштування.TabIndex = 1;
            this.Налаштування.Text = "Налаштування";
            // 
            // cb3
            // 
            this.cb3.AutoResize = false;
            this.cb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb3.Depth = 0;
            this.cb3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb3.DropDownHeight = 174;
            this.cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb3.DropDownWidth = 121;
            this.cb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb3.FormattingEnabled = true;
            this.cb3.IntegralHeight = false;
            this.cb3.ItemHeight = 43;
            this.cb3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb3.Location = new System.Drawing.Point(341, 13);
            this.cb3.Margin = new System.Windows.Forms.Padding(2);
            this.cb3.MaxDropDownItems = 4;
            this.cb3.MouseState = MaterialSkin.MouseState.OUT;
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(62, 49);
            this.cb3.TabIndex = 6;
            this.cb3.SelectedIndexChanged += new System.EventHandler(this.cb3_SelectedIndexChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(332, 25);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(4, 19);
            this.materialLabel7.TabIndex = 5;
            this.materialLabel7.Text = ";";
            // 
            // cb2
            // 
            this.cb2.AutoResize = false;
            this.cb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb2.Depth = 0;
            this.cb2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb2.DropDownHeight = 174;
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.DropDownWidth = 121;
            this.cb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb2.FormattingEnabled = true;
            this.cb2.IntegralHeight = false;
            this.cb2.ItemHeight = 43;
            this.cb2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb2.Location = new System.Drawing.Point(260, 14);
            this.cb2.Margin = new System.Windows.Forms.Padding(2);
            this.cb2.MaxDropDownItems = 4;
            this.cb2.MouseState = MaterialSkin.MouseState.OUT;
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(62, 49);
            this.cb2.TabIndex = 4;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(251, 25);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(4, 19);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = ";";
            // 
            // cb1
            // 
            this.cb1.AutoResize = false;
            this.cb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb1.Depth = 0;
            this.cb1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb1.DropDownHeight = 174;
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.DropDownWidth = 121;
            this.cb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb1.FormattingEnabled = true;
            this.cb1.IntegralHeight = false;
            this.cb1.ItemHeight = 43;
            this.cb1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb1.Location = new System.Drawing.Point(174, 14);
            this.cb1.Margin = new System.Windows.Forms.Padding(2);
            this.cb1.MaxDropDownItems = 4;
            this.cb1.MouseState = MaterialSkin.MouseState.OUT;
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(72, 49);
            this.cb1.TabIndex = 2;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(19, 28);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(142, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Вагові коефіціенти";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home32.png");
            this.imageList1.Images.SetKeyName(1, "settings32.png");
            this.imageList1.Images.SetKeyName(2, "graph32.png");
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 385);
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
            this.Налаштування.ResumeLayout(false);
            this.Налаштування.PerformLayout();
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
        private MaterialSkin.Controls.MaterialComboBox cmxA3;
        private MaterialSkin.Controls.MaterialComboBox cmxA2;
        private MaterialSkin.Controls.MaterialComboBox cmxA1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialComboBox cb1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox cb3;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox cb2;
        private System.Windows.Forms.ImageList imageList2;
    }
}

