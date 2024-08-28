namespace WindowsFormsApp1
{
    partial class NewCar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCloseC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUretimYili = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combModel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.combModel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnCloseC);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtPlaka);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtUretimYili);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtUcret);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtKm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtRenk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtMarka);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 676);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.btnUpdate.FlatAppearance.BorderSize = 5;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(354, 603);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(245, 57);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Araba Düzenle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCloseC
            // 
            this.btnCloseC.BackColor = System.Drawing.Color.DimGray;
            this.btnCloseC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnCloseC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCloseC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseC.Location = new System.Drawing.Point(618, 14);
            this.btnCloseC.Name = "btnCloseC";
            this.btnCloseC.Size = new System.Drawing.Size(39, 40);
            this.btnCloseC.TabIndex = 18;
            this.btnCloseC.Text = "X";
            this.btnCloseC.UseVisualStyleBackColor = false;
            this.btnCloseC.Click += new System.EventHandler(this.btnCloseC_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.GreenYellow;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(63, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 57);
            this.button1.TabIndex = 16;
            this.button1.Text = "Yeni Araba Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "plakası";
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Location = new System.Drawing.Point(339, 149);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(156, 26);
            this.TxtPlaka.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Üretim yılı";
            // 
            // TxtUretimYili
            // 
            this.TxtUretimYili.Location = new System.Drawing.Point(339, 69);
            this.TxtUretimYili.Name = "TxtUretimYili";
            this.TxtUretimYili.Size = new System.Drawing.Size(156, 26);
            this.TxtUretimYili.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ücreti";
            // 
            // TxtUcret
            // 
            this.TxtUcret.Location = new System.Drawing.Point(63, 396);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(156, 26);
            this.TxtUcret.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "km";
            // 
            // TxtKm
            // 
            this.TxtKm.Location = new System.Drawing.Point(63, 313);
            this.TxtKm.Name = "TxtKm";
            this.TxtKm.Size = new System.Drawing.Size(156, 26);
            this.TxtKm.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "rengi";
            // 
            // TxtRenk
            // 
            this.TxtRenk.Location = new System.Drawing.Point(63, 238);
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(156, 26);
            this.TxtRenk.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Araba markası";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(63, 149);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(156, 26);
            this.TxtMarka.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Araba modeli";
            // 
            // combModel
            // 
            this.combModel.FormattingEnabled = true;
            this.combModel.Location = new System.Drawing.Point(63, 69);
            this.combModel.Name = "combModel";
            this.combModel.Size = new System.Drawing.Size(156, 28);
            this.combModel.TabIndex = 20;
            this.combModel.SelectedIndexChanged += new System.EventHandler(this.combModel_SelectedIndexChanged);
            this.combModel.Click += new System.EventHandler(this.combModel_Click);
            // 
            // NewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(699, 700);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCloseC;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox TxtMarka;
        public System.Windows.Forms.TextBox TxtUcret;
        public System.Windows.Forms.TextBox TxtKm;
        public System.Windows.Forms.TextBox TxtRenk;
        public System.Windows.Forms.TextBox TxtPlaka;
        public System.Windows.Forms.TextBox TxtUretimYili;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combModel;
    }
}