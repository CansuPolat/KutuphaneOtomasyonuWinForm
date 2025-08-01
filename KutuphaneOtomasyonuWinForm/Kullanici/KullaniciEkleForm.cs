using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuWinForm
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        public void Listele()
        {
            
            {
                var kullanicilar = db.Kullanicilar.ToList();
                dataGridView1.DataSource = kullanicilar;
            }
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.kullanici_ad = kullaniciAdtxt.Text;
            kullanicilar.kullanici_soyad = kullaniciSoyadtxt.Text;
            kullanicilar.kullanici_tc = kullaniciTCtxt.Text;
            kullanicilar.kullanici_tel = kullaniciTeltxt.Text;
            kullanicilar.kullanici_mail = kullaniciMailtxt.Text;
            kullanicilar.kullanici_ceza = Convert.ToDouble(kullaniciCezatxt.Text);
            if (radioK.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "K";
            }
            else
            {
                kullanicilar.kullanici_cinsiyet = "E";
            }
            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
        }
    }
}