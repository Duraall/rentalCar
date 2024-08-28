namespace WindowsFormsApp1
{
    partial class formCreateNew
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
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.TxtAdminPassword = new System.Windows.Forms.TextBox();
            this.TxtAdminName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._ee7ffed8_5f08_4e61_bd1a_51eed5197526;
            this.panel1.Controls.Add(this.BtnReturn);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.TxtAdminPassword);
            this.panel1.Controls.Add(this.TxtAdminName);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Location = new System.Drawing.Point(0, -90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 1026);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnReturn.Location = new System.Drawing.Point(244, 861);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(486, 62);
            this.BtnReturn.TabIndex = 6;
            this.BtnReturn.Text = "Geri Dön";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCreate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCreate.Location = new System.Drawing.Point(244, 772);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(486, 70);
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "Oluştur";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // TxtAdminPassword
            // 
            this.TxtAdminPassword.Location = new System.Drawing.Point(507, 673);
            this.TxtAdminPassword.Name = "TxtAdminPassword";
            this.TxtAdminPassword.PasswordChar = '*';
            this.TxtAdminPassword.Size = new System.Drawing.Size(223, 26);
            this.TxtAdminPassword.TabIndex = 3;
            // 
            // TxtAdminName
            // 
            this.TxtAdminName.Location = new System.Drawing.Point(507, 582);
            this.TxtAdminName.Name = "TxtAdminName";
            this.TxtAdminName.Size = new System.Drawing.Size(223, 26);
            this.TxtAdminName.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(246, 673);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 37);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(246, 582);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(205, 37);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // formCreateNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 934);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formCreateNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCreateNew";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TxtAdminPassword;
        private System.Windows.Forms.TextBox TxtAdminName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
    }
}