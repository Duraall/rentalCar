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
    public partial class NewMotor : Form
    {
        motors f = new motors();
        public NewMotor(motors f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btnCloseC_Click(object sender, EventArgs e)
        {
            motors f = new motors();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into motor (m_plaka, m_marka, m_model, m_uretimYili, m_Km, m_renk, m_kiraUcreti ) values (@plaka, @marka, @model, @uretimYili, @Km, @renk, @kiraUcreti)", db.cn);
            db.cm.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
            db.cm.Parameters.AddWithValue("@marka", TxtMarka.Text);
            db.cm.Parameters.AddWithValue("@model", TxtModel.Text);
            db.cm.Parameters.AddWithValue("@uretimYili", TxtUretimYili.Text);
            db.cm.Parameters.AddWithValue("@Km", TxtKm.Text);
            db.cm.Parameters.AddWithValue("@renk", TxtRenk.Text);
            db.cm.Parameters.AddWithValue("@kiraUcreti", TxtUcret.Text);
            //db.ConvertImageToSave(pic);
            //db.cm.Parameters.AddWithValue("@fotograf", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Motor başarıyla kaydedildi");
            db.cn.Close();
            TxtKm.Clear();
            TxtPlaka.Clear();
            TxtModel.Clear();
            TxtUretimYili.Clear();
            TxtMarka.Clear();
            TxtRenk.Clear();
            TxtUcret.Clear();
            f.LoadMotors();
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update motor set m_plaka= @plaka, m_marka = @marka, m_model= @model, m_uretimYili= @uretimYili, m_Km=@km, m_renk=@renk, m_kiraUcreti=@kiraUcreti where id =@id", db.cn);
            db.cm.Parameters.AddWithValue("@id", db._id);
            db.cm.Parameters.AddWithValue("@plaka", TxtPlaka.Text);
            db.cm.Parameters.AddWithValue("@marka", TxtMarka.Text);
            db.cm.Parameters.AddWithValue("@model", TxtModel.Text);
            db.cm.Parameters.AddWithValue("@uretimYili", TxtUretimYili.Text);
            db.cm.Parameters.AddWithValue("@Km", TxtKm.Text);
            db.cm.Parameters.AddWithValue("@renk", TxtRenk.Text);
            db.cm.Parameters.AddWithValue("@kiraUcreti", TxtUcret.Text);
            //db.ConvertImageToSave(pic);
            //db.cm.Parameters.AddWithValue("@fotograf", db._img);
            db.cm.ExecuteNonQuery();
            MessageBox.Show(" başarıyla düzenlendi");
            db.cn.Close();
            TxtKm.Clear();
            TxtPlaka.Clear();
            TxtModel.Clear();
            TxtUretimYili.Clear();
            TxtMarka.Clear();
            TxtRenk.Clear();
            TxtUcret.Clear();
            f.LoadMotors();
            Dispose();
        }
    }
}
