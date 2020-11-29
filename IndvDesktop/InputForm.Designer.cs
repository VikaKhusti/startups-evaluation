
namespace IndvDesktop
{
    partial class InputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmxA1 = new System.Windows.Forms.ComboBox();
            this.cmxA2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmxA3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перспективність старпат проекту:";
            // 
            // cmxA1
            // 
            this.cmxA1.FormattingEnabled = true;
            this.cmxA1.Location = new System.Drawing.Point(78, 51);
            this.cmxA1.Name = "cmxA1";
            this.cmxA1.Size = new System.Drawing.Size(368, 21);
            this.cmxA1.TabIndex = 1;
            this.cmxA1.SelectedIndexChanged += new System.EventHandler(this.cmxA1_SelectedIndexChanged);
            // 
            // cmxA2
            // 
            this.cmxA2.FormattingEnabled = true;
            this.cmxA2.Location = new System.Drawing.Point(78, 109);
            this.cmxA2.Name = "cmxA2";
            this.cmxA2.Size = new System.Drawing.Size(368, 21);
            this.cmxA2.TabIndex = 3;
            this.cmxA2.SelectedIndexChanged += new System.EventHandler(this.cmxA2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ризик реалізації проекту:";
            // 
            // cmxA3
            // 
            this.cmxA3.FormattingEnabled = true;
            this.cmxA3.Location = new System.Drawing.Point(78, 168);
            this.cmxA3.Name = "cmxA3";
            this.cmxA3.Size = new System.Drawing.Size(368, 21);
            this.cmxA3.TabIndex = 5;
            this.cmxA3.SelectedIndexChanged += new System.EventHandler(this.cmxA3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Компетенції команди  розробників стартап проекту:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 296);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmxA3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmxA2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmxA1);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmxA1;
        private System.Windows.Forms.ComboBox cmxA2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmxA3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
    }
}