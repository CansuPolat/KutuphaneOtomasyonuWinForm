using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuWinForm.Kaynak
{
    public partial class KaynakSilForm : Form
    {
        public KaynakSilForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();   

        private void KaynakSilForm_Load(object sender, EventArgs e)
        {
            List<Kaynaklar> kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            // Kaynağı bul
            var silinenKaynak = db.Kaynaklar.FirstOrDefault(x => x.kaynak_id == secilenId);

            if (silinenKaynak != null)
            {
                db.Kaynaklar.Remove(silinenKaynak);
                db.SaveChanges();
            }

            // Listeyi güncelle
            var kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar;

        }
    }
}
