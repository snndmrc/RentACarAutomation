﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama_Otomasyonu
{
    public partial class YetkiVer : Form
    {
        public YetkiVer()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GVRME3L\\SQLEXPRESS;Initial Catalog=arac_kiralama;Integrated Security=True");
        private void YetkiVer_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string calisanNo = "select isim,soyisim,tc from tblCalisan where calisan_no="+label6.Text;
            SqlCommand command3 = new SqlCommand(calisanNo, baglanti);
            SqlDataReader reader2 = command3.ExecuteReader();
            reader2.Read();


            textBox1.Text= reader2["tc"].ToString();
            textBox2.Text = reader2["isim"].ToString();
            textBox3.Text = reader2["soyisim"].ToString();
            reader2.Close();
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kaydet = "insert into tblKullanici values("+label6.Text+",'"+textBox5.Text+"','"+textBox4.Text+"','"+comboBox1.Text+"')";
            SqlCommand komut = new SqlCommand(kaydet,baglanti);
            MessageBox.Show("Yetkilendirme Başarıyla Tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void YetkiVer_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
