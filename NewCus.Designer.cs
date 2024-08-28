namespace WindowsFormsApp1
{
    partial class NewCus
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCloseC = new System.Windows.Forms.Button();
            this.btnNewCus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTelNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnUpdate.FlatAppearance.BorderSize = 5;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(308, 495);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(185, 75);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Müşteri Düzenle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCloseC
            // 
            this.btnCloseC.BackColor = System.Drawing.Color.DimGray;
            this.btnCloseC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnCloseC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseC.Location = new System.Drawing.Point(540, 13);
            this.btnCloseC.Name = "btnCloseC";
            this.btnCloseC.Size = new System.Drawing.Size(39, 40);
            this.btnCloseC.TabIndex = 18;
            this.btnCloseC.Text = "X";
            this.btnCloseC.UseVisualStyleBackColor = false;
            this.btnCloseC.Click += new System.EventHandler(this.btnCloseC_Click);
            // 
            // btnNewCus
            // 
            this.btnNewCus.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnNewCus.FlatAppearance.BorderSize = 5;
            this.btnNewCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewCus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewCus.Location = new System.Drawing.Point(87, 495);
            this.btnNewCus.Name = "btnNewCus";
            this.btnNewCus.Size = new System.Drawing.Size(176, 75);
            this.btnNewCus.TabIndex = 16;
            this.btnNewCus.Text = "Yeni Müşteri Ekle";
            this.btnNewCus.UseVisualStyleBackColor = true;
            this.btnNewCus.Click += new System.EventHandler(this.btnNewCus_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mail";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(323, 78);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(170, 26);
            this.TxtMail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adres";
            // 
            // TxtAdress
            // 
            this.TxtAdress.Location = new System.Drawing.Point(87, 272);
            this.TxtAdress.Multiline = true;
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(406, 160);
            this.TxtAdress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tel No";
            // 
            // TxtTelNo
            // 
            this.TxtTelNo.Location = new System.Drawing.Point(323, 158);
            this.TxtTelNo.Name = "TxtTelNo";
            this.TxtTelNo.Size = new System.Drawing.Size(170, 26);
            this.TxtTelNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı Soyadı";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(87, 158);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(156, 26);
            this.TxtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC NO";
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(87, 78);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(156, 26);
            this.TxtTc.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnCloseC);
            this.panel1.Controls.Add(this.btnNewCus);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtMail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtAdress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtTelNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtTc);
            this.panel1.Location = new System.Drawing.Point(25, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 599);
            this.panel1.TabIndex = 1;
            // 
            // NewCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(649, 664);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewCus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCloseC;
        public System.Windows.Forms.Button btnNewCus;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtTelNo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.Panel panel1;
    }
}