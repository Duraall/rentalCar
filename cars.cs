using CSharp_Rental_System_Car;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Cars : Form

   
    {
        DataTable CarDataTable = new DataTable();
        public Cars()
        {
            InitializeComponent();
        }



        private void btnCloseC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCar f = new NewCar(this);
            f.Show();
            
        }

        
        public void loadCars()
        {
            int i = 0;
            DGV.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from araba", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                DGV.Rows.Add( db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6], db.dr[7]);
            }
            db.cn.Close();
        }
        private void Cars_Load(object sender, EventArgs e)
        {
            loadCars();
        }



        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

            db.cn.Open();
            db.cm.Parameters.AddWithValue("@search", "%" + TxtSearch.Text + "%");

            string query = "SELECT * FROM araba WHERE marka LIKE '%" + TxtSearch.Text +"%'  OR model LIKE '%" + TxtSearch.Text +"%' OR renk LIKE '%" + TxtSearch.Text +"%' OR plaka LIKE '%" + TxtSearch.Text +"%' OR km LIKE '%" + TxtSearch.Text +"%' OR kiraUcreti LIKE '%" + TxtSearch.Text +"%' OR uretimYili LIKE '%" + TxtSearch.Text +"%'";

            db.cm = new SqlCommand(query, db.cn);
            var reader = db.cm.ExecuteReader();
            DGV.Rows.Clear();
            while (reader.Read())
            {
                DGV.Rows.Add(reader["id"], reader["Plaka"], reader["Marka"], reader["Model"], reader["UretimYili"], reader["Km"], reader["Renk"], reader["kiraUcreti"]);
            }
            db.cn.Close();


        }



        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGV.Columns[e.ColumnIndex].Name;
            if (colName == "ColEdit")
            {
                NewCar f = new NewCar(this);
                db._id = (int)DGV.CurrentRow.Cells[0].Value;
                f.TxtPlaka.Text = DGV.CurrentRow.Cells[1].Value.ToString();
                f.TxtMarka.Text = DGV.CurrentRow.Cells[2].Value.ToString();
                f.CombModel.SelectedItem = DGV.CurrentRow.Cells[3].Value.ToString();
                f.TxtUretimYili.Text = DGV.CurrentRow.Cells[4].Value.ToString();
                f.TxtKm.Text = DGV.CurrentRow.Cells[5].Value.ToString();
                f.TxtRenk.Text = DGV.CurrentRow.Cells[6].Value.ToString();
                f.TxtUcret.Text = DGV.CurrentRow.Cells[7].Value.ToString();

                f.ShowDialog();




            }
            else if (colName == "ColDelete")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("delete from araba where id like '" + DGV.CurrentRow.Cells[0].Value + "'", db.cn);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Recent Car Deleted");
                db.cn.Close();
                loadCars();

            }


        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
