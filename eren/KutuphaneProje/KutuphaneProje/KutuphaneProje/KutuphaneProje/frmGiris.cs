using KutuphaneProje.Helper;
using kutuphaneProjesi.Helper;
using System;
using System.Data;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //KullanıcıAdı: eren
            //Şifre: 123456
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve parola alanlarının dolu olduğunu kontrol edin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string parola = Sifreleme.MD5Sifrele(txtParola.Text.Trim());
            
            try
            {
                DataTable dtKullaniciGiris = db.getData("SELECT * FROM Kullanici WHERE KullaniciAdi='" + kullaniciAdi + "' and Parola='" + parola + "'");
                if (dtKullaniciGiris != null && dtKullaniciGiris.Rows.Count > 0)
                {
                    frmAnaEkran frmAnaEkran = new frmAnaEkran(kullaniciAdi);
                    frmAnaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı yada parolanız hatalıdır. Lütfen bilgilerinizi kontrol edin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu." + ex.Message.ToString(), "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}