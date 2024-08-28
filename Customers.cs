using CSharp_Rental_System_Car;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Customers : Form
    {
        DataTable CusDataTable = new DataTable();
        public Customers()
        {
            InitializeComponent();
        }
        public void loadCus()
        {
            try
            {
                int i = 0;
                DGVcus.Rows.Clear();
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("select * from musteri", db.cn);
                db.dr = db.cm.ExecuteReader();
                while (db.dr.Read())
                {
                    DGVcus.Rows.Add(db.dr[0], db.dr[2], db.dr[1], db.dr[3], db.dr[5], db.dr[4]);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            db.cn.Close();
        }

        private void cus_load(object sender, EventArgs e)
        {
            loadCus();
        }

        private void btnCloseC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NewCus f = new NewCus(this);
            f.Show();
            
        }
        

        private void DGVcus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGVcus.Columns[e.ColumnIndex].Name;
            if (colName == "ColEdit")
            {
                NewCus f = new NewCus(this);
                db._id = (int)DGVcus.CurrentRow.Cells[0].Value;
                f.TxtTc.Text = DGVcus.CurrentRow.Cells[2].Value.ToString();
                f.TxtName.Text = DGVcus.CurrentRow.Cells[1].Value.ToString();
                f.TxtTelNo.Text = DGVcus.CurrentRow.Cells[3].Value.ToString();
                f.TxtMail.Text = DGVcus.CurrentRow.Cells[4].Value.ToString();
                f.TxtAdress.Text = DGVcus.CurrentRow.Cells[5].Value.ToString();

                f.ShowDialog();




            }
            else if (colName == "ColDelete")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("delete from musteri where id like '" + DGVcus.CurrentRow.Cells[0].Value + "'", db.cn);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Recent Car Deleted");
                db.cn.Close();
                loadCus();
            }
        }

        
    }
}
