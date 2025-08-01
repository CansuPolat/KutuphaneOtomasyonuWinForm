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
    public partial class KaynakGuncelleForm : Form
    {
        public KaynakGuncelleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void KaynakGuncelleForm_Load(object sender, EventArgs e)
        {

            
            List<Kaynaklar> kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar;


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adKaynaktxt.Text =dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yazarKaynaktxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yayıncıKaynaktxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var guncellenecekKaynak = db.Kaynaklar.FirstOrDefault(x => x.kaynak_id == secilenId);

            guncellenecekKaynak.kaynak_ad = adKaynaktxt.Text;
            guncellenecekKaynak.kaynak_yazar = yazarKaynaktxt.Text;
            guncellenecekKaynak.kaynak_yayıncı = yayıncıKaynaktxt.Text;
            guncellenecekKaynak.kaynak_sayfasayisi = Convert.ToInt32(numericUpDown1.Value);
            guncellenecekKaynak.kaynak_basımtarihi = dateTimePicker1.Value;
            db.SaveChanges();

            List<Kaynaklar> kaynaklar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kaynaklar;


        }
    }
}
