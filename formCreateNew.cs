using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CSharp_Rental_System_Car;

namespace WindowsFormsApp1
{
    public partial class formCreateNew : Form
    {
        
        public formCreateNew()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=LAPTOP-MBBQNF15\\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True;Encrypt=False;TrustServerCertificate=False";

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Dispose();

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into admin(adminUserName, adminPassword) values (@adminUserName, @adminPassword)", db.cn);
            db.cm.Parameters.AddWithValue("@adminUserName", TxtAdminName.Text);
            db.cm.Parameters.AddWithValue("@adminPassword", TxtAdminPassword.Text);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("successfuly created");
            
            db.cn.Close();  
            
            FormLogin f = new FormLogin();
            f.Show();
            this.Dispose();
            



        }
    }
}
