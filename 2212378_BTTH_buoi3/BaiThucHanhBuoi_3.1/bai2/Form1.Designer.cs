namespace bai2
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdxanh = new System.Windows.Forms.RadioButton();
            this.rddo = new System.Windows.Forms.RadioButton();
            this.Btntomau = new System.Windows.Forms.Button();
            this.txtHopMau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Location = new System.Drawing.Point(204, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn giới tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(31, 19);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(31, 67);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 0;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btntomau);
            this.groupBox2.Controls.Add(this.rdxanh);
            this.groupBox2.Controls.Add(this.rddo);
            this.groupBox2.Location = new System.Drawing.Point(91, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "chọn màu";
            // 
            // rdxanh
            // 
            this.rdxanh.AutoSize = true;
            this.rdxanh.Location = new System.Drawing.Point(31, 67);
            this.rdxanh.Name = "rdxanh";
            this.rdxanh.Size = new System.Drawing.Size(71, 17);
            this.rdxanh.TabIndex = 0;
            this.rdxanh.Text = "màu xanh";
            this.rdxanh.UseVisualStyleBackColor = true;
            // 
            // rddo
            // 
            this.rddo.AutoSize = true;
            this.rddo.Checked = true;
            this.rddo.Location = new System.Drawing.Point(31, 19);
            this.rddo.Name = "rddo";
            this.rddo.Size = new System.Drawing.Size(61, 17);
            this.rddo.TabIndex = 0;
            this.rddo.TabStop = true;
            this.rddo.Text = "màu đỏ";
            this.rddo.UseVisualStyleBackColor = true;
            this.rddo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Btntomau
            // 
            this.Btntomau.Location = new System.Drawing.Point(116, 41);
            this.Btntomau.Name = "Btntomau";
            this.Btntomau.Size = new System.Drawing.Size(75, 23);
            this.Btntomau.TabIndex = 1;
            this.Btntomau.Text = "Tô Màu";
            this.Btntomau.UseVisualStyleBackColor = true;
            this.Btntomau.Click += new System.EventHandler(this.Btntomau_Click);
            // 
            // txtHopMau
            // 
            this.txtHopMau.Location = new System.Drawing.Point(314, 261);
            this.txtHopMau.Name = "txtHopMau";
            this.txtHopMau.ReadOnly = true;
            this.txtHopMau.Size = new System.Drawing.Size(182, 20);
            this.txtHopMau.TabIndex = 2;
            this.txtHopMau.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHopMau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "bài 2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdxanh;
        private System.Windows.Forms.RadioButton rddo;
        private System.Windows.Forms.Button Btntomau;
        private System.Windows.Forms.TextBox txtHopMau;
    }
}

