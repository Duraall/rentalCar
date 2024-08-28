using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharp_Rental_System_Car;

namespace WindowsFormsApp1
{

    public partial class FormLogin : Form
    {

        
        public FormLogin()
        {
            InitializeComponent();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtAdminName.Text == "")
            {
                MessageBox.Show("Kullanıcı adı boş olamaz");
                TxtAdminName.Select();
                return;
            }
            else if (TxtAdminPassword.Text == "")
            {
                MessageBox.Show("Şifre boş olamaz");
                TxtAdminPassword.Select();
                return;
            }
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from admin where adminUserName like '"+TxtAdminName.Text+ "' and adminPassword like'"+TxtAdminPassword.Text+"'", db.cn);
            db.dr = db.cm.ExecuteReader();
            if (db.dr.HasRows)
            {
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
            }
            db.cn.Close();

            
                
            

        }

        private void BtnCreateNew_Click(object sender, EventArgs e)
        {
            formCreateNew f = new formCreateNew();
            f.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
