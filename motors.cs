using CSharp_Rental_System_Car;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;    

namespace WindowsFormsApp1
{
    public partial class motors : Form
    {

        DataTable motorDataTable = new DataTable();
        public motors()
        {
            InitializeComponent();
        }

        private void btnCloseC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            NewMotor f = new NewMotor(this);
            f.Show();
            
        }

        public void LoadMotors()
        {
            int i = 1;
            DGVmotor.Rows.Clear();
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from motor", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                DGVmotor.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6], db.dr[7]);

            }
            db.cn.Close();
        }

        private void Motors_Load(object sender, EventArgs e)
        {
            LoadMotors();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

            db.cn.Open();
            string query = "SELECT * FROM motor WHERE m_marka LIKE @search OR m_model LIKE @search OR m_renk LIKE @search OR m_plaka LIKE @search OR m_km LIKE @search OR m_kiraUcreti LIKE @search OR m_uretimYili LIKE @search";
            db.cm = new SqlCommand(query, db.cn);
            db.cm.Parameters.AddWithValue("@search", "%" + TxtSearch.Text + "%");
            db.da = new SqlDataAdapter(db.cm);
            DataTable dt = new DataTable();
            db.da.Fill(dt);
            DGVmotor.DataSource = dt;
            db.cn.Close();
        }


        

        

        

        private void DGVmotor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGVmotor.Columns[e.ColumnIndex].Name;
            if (colName == "ColEdit")
            {
                NewMotor f = new NewMotor(this);
                db._id = (int)DGVmotor.CurrentRow.Cells[0].Value;
                f.TxtPlaka.Text = DGVmotor.CurrentRow.Cells[1].Value.ToString();
                f.TxtMarka.Text = DGVmotor.CurrentRow.Cells[2].Value.ToString();
                f.TxtModel.Text = DGVmotor.CurrentRow.Cells[3].Value.ToString();
                f.TxtUretimYili.Text = DGVmotor.CurrentRow.Cells[4].Value.ToString();
                f.TxtKm.Text = DGVmotor.CurrentRow.Cells[5].Value.ToString();
                f.TxtRenk.Text = DGVmotor.CurrentRow.Cells[6].Value.ToString();
                f.TxtUcret.Text = DGVmotor.CurrentRow.Cells[7].Value.ToString();

                f.ShowDialog();




            }
            else if (colName == "ColDelete")
            {
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("delete from motor where id like '" + DGVmotor.CurrentRow.Cells[0].Value + "'", db.cn);
                db.cm.ExecuteNonQuery();
                MessageBox.Show("Recent Motor Deleted");
                db.cn.Close();
                LoadMotors();

            }
        }

        private void motors_Load_1(object sender, EventArgs e)
        {
            LoadMotors();
        }

        private void TxtSearch_TextChanged_1(object sender, EventArgs e)
        {

            db.cn.Open();
            db.cm.Parameters.AddWithValue("@search", "%" + TxtSearch.Text + "%");

            string query = "SELECT * FROM motor WHERE m_marka LIKE '%" + TxtSearch.Text + "%'  OR m_model LIKE '%" + TxtSearch.Text + "%' OR m_renk LIKE '%" + TxtSearch.Text + "%' OR m_plaka LIKE '%" + TxtSearch.Text + "%' OR m_km LIKE '%" + TxtSearch.Text + "%' OR m_kiraUcreti LIKE '%" + TxtSearch.Text + "%' OR m_uretimYili LIKE '%" + TxtSearch.Text + "%'";

            db.cm = new SqlCommand(query, db.cn);
            var reader = db.cm.ExecuteReader();
            DGVmotor.Rows.Clear();
            while (reader.Read())
            {
                DGVmotor.Rows.Add(reader["id"], reader["m_Plaka"], reader["m_Marka"], reader["m_Model"], reader["m_UretimYili"], reader["m_Km"], reader["m_Renk"], reader["m_kiraUcreti"]);
            }
            db.cn.Close();
        }

        
    }
}
