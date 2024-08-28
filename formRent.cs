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

namespace WindowsFormsApp1
{
    public partial class formRent : Form
    {
        
        public formRent()
        {
            InitializeComponent();

            loadCus();
            loadCars();
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
        public void loadCus()
        {

            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("select * from musteri ", db.cn);
            db.dr = db.cm.ExecuteReader();
            Dictionary<int, string> customers = new Dictionary<int, string>(); // Müşteri ID'lerini ve isimlerini saklamak için bir dictionary oluşturun
            while (db.dr.Read())
            {
                int customerID = Convert.ToInt32(db.dr["ID"]);
                string customerName = db.dr["adSoyad"].ToString();
                customers.Add(customerID, customerName); // Her müşteriyi dictionary'e ekle
            }
            db.cn.Close();

            // Combobox'ı müşterilerle doldurun
            combCustomer.DataSource = new BindingSource(customers, null);
            combCustomer.DisplayMember = "Value"; // Combobox'ta müşteri isimlerini göster
            combCustomer.ValueMember = "Key";

        }
        public void loadCars()
        {
            try
            {
                DGVavailableCars.Rows.Clear();
                db.cn.Open();
                db.cm = new System.Data.SqlClient.SqlCommand("select * from araba where durumu ='0' ", db.cn);
                db.dr = db.cm.ExecuteReader();
                while (db.dr.Read())
                {
                    DGVavailableCars.Rows.Add(db.dr[0], db.dr[1], db.dr[2], db.dr[3], db.dr[4], db.dr[5], db.dr[6], db.dr[7]);
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
            DGVavailableCars.Refresh();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {

        }

        private void formRent_Load(object sender, EventArgs e)
        {
            loadCars();
        }

        public void loadAboutRent()
        {

            formRent formRentInstance = new formRent();
            formRentInstance.loadAboutRent();
        }

        private void DGVavailableCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGVavailableCars.Rows[e.RowIndex];
                int arabaID = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn1"].Value);

                if (combCustomer.SelectedItem == null)
                {
                    MessageBox.Show("Önce müşteriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int musteriID = Convert.ToInt32(combCustomer.SelectedValue);
                DateTime rentDate = datee.Value; // DateTimePicker'den tarihi al

                try
                {
                    if (db.cn.State == ConnectionState.Closed)
                        db.cn.Open();

                    db.cm = new System.Data.SqlClient.SqlCommand("INSERT INTO kirala (MusteriID, AracID, RentDate) VALUES (@musteriID, @arabaID, @rentDate)", db.cn);
                    db.cm.Parameters.AddWithValue("@musteriID", musteriID);
                    db.cm.Parameters.AddWithValue("@arabaID", arabaID);
                    db.cm.Parameters.AddWithValue("@rentDate", rentDate); // Tarihi veritabanına ekle
                    db.cm.ExecuteNonQuery();

                    db.cm = new System.Data.SqlClient.SqlCommand("UPDATE araba SET durumu = 1 WHERE id = @id", db.cn);
                    db.cm.Parameters.AddWithValue("@id", arabaID);
                    db.cm.ExecuteNonQuery();

                    MessageBox.Show("Araç durumu değiştirildi ve kiralama işlemi tamamlandı.");

                    DGVavailableCars.Refresh();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
                finally
                {
                    db.cn.Close();
                }
            }

        }

        
    }
}