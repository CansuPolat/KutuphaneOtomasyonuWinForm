using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonuWinForm.Kayit
{
    public partial class geriAlForm : Form
    {
        public geriAlForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
        private void geriAlForm_Load(object sender, EventArgs e)
        {
            var kayitlar = db.Kayitlar.Where(x => x.durum == false).ToList();

            dataGridView1.DataSource = kayitlar.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKayitId=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.Kayitlar.Where(x => x.kayit_id == secilenKayitId).FirstOrDefault();

            kayit.durum = true;
            db.SaveChanges();

            List<Kayitlar> kayitlar = db.Kayitlar.Where(x => x.durum == false).ToList();

            dataGridView1.DataSource = kayitlar.ToList();
            

        }
    }
}
