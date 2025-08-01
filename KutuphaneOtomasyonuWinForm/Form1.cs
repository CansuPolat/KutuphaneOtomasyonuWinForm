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
    public partial class Form1 : Form

    {
        KutuphaneOtomasyonEntities db= new KutuphaneOtomasyonEntities();    
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
            string gelenAd=adGiristxt.Text;
            string gelenSifre = sifreGiristxt.Text;
            //linq sorgusu
            var personel = db.Personeller
    .Where(x => x.personel_ad.Equals(gelenAd) && x.personel_sifre.Equals(gelenSifre))
    .FirstOrDefault();

            if (personel==null)
            {
                MessageBox.Show(text: "Kullanıcı adı veya şifre hatalı");

            }
            else
            {
                MessageBox.Show(text: "Başarılı");
                IslemPaneli panel=new IslemPaneli();
                panel.Show();
                this.Hide();


            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
