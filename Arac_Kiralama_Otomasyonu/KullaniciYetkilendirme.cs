using System;
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
    public partial class KullaniciYetkilendirme : Form
    {
        public KullaniciYetkilendirme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SVJ939G;Initial Catalog=arac_kiralama;Integrated Security=True");
        private void KullaniciYetkilendirme_Load(object sender, EventArgs e)
        {
            string cumle = "select tblCalisan.calisan_no,tblCalisan.tc,tblCalisan.isim,tblCalisan.soyisim,tblKullanici.kullaniciadi,tblKullanici.sifre,tblKullanici.yetki from tblCalisan FULL OUTER JOIN tblKullanici on tblCalisan.calisan_no=tblKullanici.calisan_no";

            baglanti.Open();
            string calisancek = "select * from tblCalisan";
            SqlDataAdapter da = new SqlDataAdapter(cumle,baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn2);
            btn2.HeaderText = "İşlem";
            btn2.Text = "Yetki Ver";
            btn2.Name = "yetkiver";
            btn2.UseColumnTextForButtonValue = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["yetkiver"].Index)
            {
                YetkiVer yetkiver = new YetkiVer();
                yetkiver.label6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                yetkiver.Show();
            }
        }
    }
}
