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
    public partial class NewCar : Form
    {
        Cars f = new Cars(); 
        public NewCar(Cars f)

        {
            InitializeComponent();
            this.f = f; 
        }

        

        private void btnCloseC_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into araba (plaka, marka, model, uretimYili, Km, renk, kiraUcreti ) values (@plaka, @marka, @model, @uretimYili, @Km, @renk, @kiraUcreti)", db.cn);
            db.cm.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
            db.cm.Parameters.AddWithValue("@marka", TxtMarka.Text);
            db.cm.Parameters.AddWithValue("@model", combModel.SelectedItem);
            db.cm.Parameters.AddWithValue("@uretimYili", TxtUretimYili.Text);
            db.cm.Parameters.AddWithValue("@Km", TxtKm.Text);
            db.cm.Parameters.AddWithValue("@renk", TxtRenk.Text);
            db.cm.Parameters.AddWithValue("@kiraUcreti",TxtUcret.Text);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Araba başarıyla kaydedildi");
            db.cn.Close();
            TxtKm.Clear();
            TxtPlaka.Clear();
            
            TxtUretimYili.Clear();
            TxtMarka.Clear();
            TxtRenk.Clear();
            TxtUcret.Clear();
            f.loadCars();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update araba set plaka= @plaka, marka = @marka, model= @model, uretimYili= @uretimYili, Km=@km, renk=@renk, kiraUcreti=@kiraUcreti where id =@id", db.cn);
            db.cm.Parameters.AddWithValue("@id",db._id);
            db.cm.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
            db.cm.Parameters.AddWithValue("@marka", TxtMarka.Text);
            db.cm.Parameters.AddWithValue("@model", combModel.SelectedItem);
            db.cm.Parameters.AddWithValue("@uretimYili", TxtUretimYili.Text);
            db.cm.Parameters.AddWithValue("@Km", TxtKm.Text);
            db.cm.Parameters.AddWithValue("@renk", TxtRenk.Text);
            db.cm.Parameters.AddWithValue("@kiraUcreti", TxtUcret.Text);
            //db.ConvertImageToSave(pic);
            //db.cm.Parameters.AddWithValue("@fotograf", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Araba başarıyla düzenlendi");
            db.cn.Close();
            TxtKm.Clear();
            TxtPlaka.Clear();
            
            TxtUretimYili.Clear();
            TxtMarka.Clear();
            TxtRenk.Clear();
            TxtUcret.Clear();
            f.loadCars();
            Dispose();
        }
        public ComboBox CombModel
        {
            get { return combModel; }
            set { combModel = value; }
        }

        private void TxtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void combModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void combModel_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("Select model from araba", db.cn);
            db.dr = db.cm.ExecuteReader();
            combModel.Items.Clear();

            while (db.dr.Read())
            {
                combModel.Items.Add(db.dr["model"]);
            }
            db.cn.Close();
        }
    }
}
