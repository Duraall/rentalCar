using CSharp_Rental_System_Car;
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

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            loadCarsAvailable();
            
            loadCus();
            loadAboutRent();



        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewV_Click(object sender, EventArgs e)
        {
            Cars f = new Cars();
            f.ShowDialog();
            
        }



        private void btnCars_Click(object sender, EventArgs e)
        {
            Cars f = new Cars();
            f.ShowDialog();
            
        }

        private void btnMotors_Click(object sender, EventArgs e)
        {
            motors f = new motors();
            f.ShowDialog();
        }

        

        private void btnNewCustomer_Click_1(object sender, EventArgs e)
        {
            Customers f = new Customers();
            f.ShowDialog();

        }

        public void loadCus()
        {
            int i = 0;
            DGVmainCus.Rows.Clear();
            if (db.cn.State == ConnectionState.Closed)
                db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from musteri ", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                DGVmainCus.Rows.Add(db.dr[0], db.dr[2], db.dr[1], db.dr[3], db.dr[5], db.dr[4]);
            }
            db.cn.Close();
        }


        public void loadCarsAvailable()
        {
            int i = 0;
            DGVavailableCars.Rows.Clear();
            if (db.cn.State == ConnectionState.Closed)
                db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from araba where durumu ='0' ", db.cn);
            db.dr = db.cm.ExecuteReader();
            while (db.dr.Read())
            {
                DGVavailableCars.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6], db.dr[7]);
            }


            db.cn.Close();
        }
        

        public void loadAboutRent()
        {
            try
            {
                if (db.cn.State == ConnectionState.Open)
                    db.cn.Close();

                DGVAboutRent.Rows.Clear();
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("SELECT k.ID, m.adSoyad, a.marka, a.model, m.telNo, a.ID as AracID, k.RentDate FROM Kirala k INNER JOIN musteri m ON k.MusteriID = m.ID INNER JOIN araba a ON k.AracID = a.ID WHERE a.durumu = 1", db.cn);
                db.dr = db.cm.ExecuteReader();
                while (db.dr.Read())
                {
                    DGVAboutRent.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                if (db.cn.State == ConnectionState.Open)
                    db.cn.Close();
            }
        }



        private void btnRentV_Click(object sender, EventArgs e)
        {
            formRent f = new formRent();
            f.ShowDialog();
        }

        private void DGVAboutRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DGVAboutRent.Columns[e.ColumnIndex].Name;
            if (colName == "ColDelete")
            {
                // AracID'nin hücredeki değerini al
                object arabaIDObject = DGVAboutRent.Rows[e.RowIndex].Cells["AracID"].Value;

                // AracID değeri null değilse dönüşüm yap
                if (arabaIDObject != DBNull.Value && arabaIDObject != null)
                {
                    // AracID'nin string olarak alınması
                    string arabaIDString = arabaIDObject.ToString();

                    // AracID'nin int türüne dönüştürülmesi
                    if (int.TryParse(arabaIDString, out int arabaID))
                    {
                        try
                        {
                            if (db.cn.State == ConnectionState.Closed)
                                db.cn.Open();

                            // Araba tablosundaki durumu güncelle ve aynı anda kirala tablosundan sil
                            db.cm = new System.Data.SqlClient.SqlCommand("UPDATE araba SET durumu = 0 WHERE id = @arabaID; " +
                                                                          "DELETE FROM Kirala WHERE AracID = @arabaID;", db.cn);
                            db.cm.Parameters.AddWithValue("@arabaID", arabaID);
                            db.cm.ExecuteNonQuery();

                            MessageBox.Show("Recent Car Deleted");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu: " + ex.Message);
                        }
                        finally
                        {
                            db.cn.Close();
                        }

                        // DataGridView'i yenile
                        DGVAboutRent.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("AracID dönüşümü başarısız oldu.");
                    }
                }
                else
                {
                    MessageBox.Show("AracID değeri null.");
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadCus();
            loadAboutRent();
            loadCarsAvailable();
        }
    }
}
    

