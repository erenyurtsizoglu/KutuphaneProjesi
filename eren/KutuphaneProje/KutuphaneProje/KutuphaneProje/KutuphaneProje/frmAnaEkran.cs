using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class frmAnaEkran : Form
    {
        private string _kullaniciAdi = string.Empty;
        public frmAnaEkran(string kullaniciAdi)
        {
            InitializeComponent();
            _kullaniciAdi = kullaniciAdi;
        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            stLabelKullaniciAdi.Text = _kullaniciAdi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKutuphane frmKutuphane = new frmKutuphane();
            frmKutuphane.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKitapTeslimAl frmKitapTeslimAl = new frmKitapTeslimAl();
            frmKitapTeslimAl.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUyeYonetimi frmUyeYonetimi = new frmUyeYonetimi();
            frmUyeYonetimi.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKitapTeslimEt frmKitapTeslimEt = new frmKitapTeslimEt();
            frmKitapTeslimEt.ShowDialog();
        }
    }
}