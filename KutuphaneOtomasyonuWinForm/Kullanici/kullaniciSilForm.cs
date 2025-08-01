using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuWinForm.Kullanici
{
    public partial class kullaniciSilForm : Form
    {
        public kullaniciSilForm()
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
        private void kullaniciSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();

            db.Kullanicilar.Remove(kullanici);
            db.SaveChanges();
            Listele();
        }
    }
}
