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
    public partial class NewCus : Form
    {
        Customers f = new Customers();
        public NewCus(Customers f)
        {
            InitializeComponent();
            this.f = f;
        }

        

        private void btnCloseC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewCus_Click_1(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("insert into musteri (TcNo, adSoyad, telNo, adres, mail ) values (@TcNo, @adSoyad, @telNo, @adres, @mail)", db.cn);
            db.cm.Parameters.AddWithValue("@TcNo", TxtTc.Text);
            db.cm.Parameters.AddWithValue("@adSoyad", TxtName.Text);
            db.cm.Parameters.AddWithValue("@telNo", TxtTelNo.Text);
            db.cm.Parameters.AddWithValue("@mail", TxtMail.Text);
            db.cm.Parameters.AddWithValue("@adres", TxtAdress.Text);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Müşteri başarıyla kaydedildi");
            db.cn.Close();
            TxtAdress.Clear();
            TxtTc.Clear();
            TxtMail.Clear();
            TxtName.Clear();
            TxtTelNo.Clear();
            f.loadCus();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            db.cn.Open();
            db.cm = new System.Data.SqlClient.SqlCommand("update musteri set TcNo= @TcNo, adSoyad = @adSoyad, telNo= @telNo, mail= @mail, adres=@adres where id =@id", db.cn);
            db.cm.Parameters.AddWithValue("@id", db._id);
            db.cm.Parameters.AddWithValue("@TcNo", TxtTc.Text);
            db.cm.Parameters.AddWithValue("@adSoyad", TxtName.Text);
            db.cm.Parameters.AddWithValue("@telNo", TxtTelNo.Text);
            db.cm.Parameters.AddWithValue("@mail", TxtMail.Text);
            db.cm.Parameters.AddWithValue("@adres", TxtAdress.Text);
            db.cm.ExecuteNonQuery();
            MessageBox.Show("Müşteri başarıyla Düzenlendi");
            db.cn.Close();
            TxtAdress.Clear();
            TxtTc.Clear();
            TxtMail.Clear();
            TxtName.Clear();
            TxtTelNo.Clear();
            f.loadCus();
            Dispose();
        }
    }
}
