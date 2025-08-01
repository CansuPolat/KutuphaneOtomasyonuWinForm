
using KutuphaneOtomasyonuWinForm.Kayit;
using KutuphaneOtomasyonuWinForm.Kaynak;
using KutuphaneOtomasyonuWinForm.Kullanici;
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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            //kullanıcı butonları başlangıçta gizli olacak
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false;
            silKullanicibtn.Visible = false;

            //kaynak butonları başlangıçta gizli olacak
            ekleKaynakbtn.Visible = false;
            guncelleKaynakbtn.Visible = false;
            silKaynakbtn.Visible = false;
        }
        private KullaniciListeForm klisteForm;
        private void kullanicibtn_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
                KullaniciListeForm klisteForm = new KullaniciListeForm();
                klisteForm.MdiParent = this;
                klisteForm.Show();
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
                klisteForm.Close();
            }
            

        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();

        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            kullaniciSilForm kSil = new kullaniciSilForm();
            kSil.MdiParent = this;
            kSil.Show();

        }

        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleForm kGuncel = new KullaniciGuncelleForm();
            kGuncel.MdiParent = this;
            kGuncel.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleKaynakbtn.Visible == false)
            {
                ekleKaynakbtn.Visible = true;
                guncelleKaynakbtn.Visible = true;
                silKaynakbtn.Visible = true;
            }
            else
            {
                ekleKaynakbtn.Visible = false;
                guncelleKaynakbtn.Visible = false;
                silKaynakbtn.Visible = false;
            }
            kaynakListeForm klisteForm = new kaynakListeForm();
            klisteForm.MdiParent = this;
            klisteForm.Show();


        }

        private void ekleKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm ekleForm = new KaynakEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();

        }

        private void silKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm kSil = new KaynakSilForm();
            kSil.MdiParent = this;
            kSil.Show();

        }

        private void guncelleKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakGuncelleForm kGuncel = new KaynakGuncelleForm();
            kGuncel.MdiParent = this;
            kGuncel.Show();



        }

        private void button2_Click(object sender, EventArgs e)
        {
           OduncForm oduncForm = new OduncForm();   
            oduncForm.MdiParent = this;
            oduncForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            geriAlForm geriAlForm = new geriAlForm();
            geriAlForm.MdiParent = this;
            geriAlForm.Show();

        }
    } 
}


