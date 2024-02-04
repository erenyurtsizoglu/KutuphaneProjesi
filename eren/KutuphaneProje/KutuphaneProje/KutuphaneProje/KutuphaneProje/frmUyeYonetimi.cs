using kutuphaneProjesi.Helper;
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
    public partial class frmUyeYonetimi : Form
    {

        Database db = new Database();
        private int seciliUyeId = 0;

        public frmUyeYonetimi()
        {
            InitializeComponent();
        }

        private void GirdileriTemizle()
        {
            txtUyeAdi.Text = "";
            txtUyeSoyadi.Text = "";
            txtUyeMailAdresi.Text = "";
            txtUyeTelefon.Text = "";
            btnKaydet.Text = "Kaydet";
            seciliUyeId = 0;
            btn_temizle.Visible = false;
        }


        private void UyeleriGetir()
        {
            lvUyeListe.Items.Clear();
            try
            {
                DataTable dtUyeListe = db.getData("SELECT * FROM Uye");
                if (dtUyeListe != null && dtUyeListe.Rows.Count > 0)
                {
                    for (int i = 0; i < dtUyeListe.Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(dtUyeListe.Rows[i]["Id"].ToString());
                        item.SubItems.Add(dtUyeListe.Rows[i]["Adi"].ToString());
                        item.SubItems.Add(dtUyeListe.Rows[i]["Soyadi"].ToString());
                        item.SubItems.Add(dtUyeListe.Rows[i]["EmailAdresi"].ToString());
                        item.SubItems.Add(dtUyeListe.Rows[i]["Telefon"].ToString());
                        lvUyeListe.Items.Add(item);
                        GirdileriTemizle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu." + ex.Message.ToString(), "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmUyeYonetimi_Load(object sender, EventArgs e)
        {
            UyeleriGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string UyeAdi = txtUyeAdi.Text.Trim();
            string UyeSoyadi = txtUyeSoyadi.Text.Trim();
            string UyeMail = txtUyeMailAdresi.Text.Trim();
            string UyeTelefon = txtUyeTelefon.Text.Trim();
            if (string.IsNullOrEmpty(UyeAdi) || string.IsNullOrEmpty(UyeSoyadi) || string.IsNullOrEmpty(UyeMail) || string.IsNullOrEmpty(UyeTelefon) )
            {
                MessageBox.Show("Lütfen kategori adı bilgisinin dolu olduğunu kontrol edin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnKaydet.Text == "Kaydet")
            {
                DataTable uyeTelefonData = db.getData("SELECT Telefon FROM Uye WHERE Telefon='" + UyeTelefon + "'");
                DataTable uyeMailData = db.getData("SELECT EmailAdresi FROM Uye WHERE EmailAdresi='" + UyeMail + "'");
                if (uyeTelefonData.Rows.Count > 0 || uyeMailData.Rows.Count > 0)
                {
                    MessageBox.Show("Kayıt işlemi tamamlanamadı bu telefonu veya maili kullanan üye zaten mevcut, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int kayitEkle = db.execute("INSERT INTO Uye(Adi,Soyadi,EmailAdresi,Telefon) VALUES('" + UyeAdi + "','" + UyeSoyadi + "','" + UyeMail + "','" + UyeTelefon + "')");
                if (kayitEkle > 0)
                {
                    MessageBox.Show("Kayıt işlemi başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UyeleriGetir();
                }
                else
                {
                    MessageBox.Show("Maalesef, Kayıt işlemi tamamlanamadı bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (seciliUyeId > 0)
                {
                    DataTable uyeTelefonData = db.getData("SELECT Telefon FROM Uye WHERE Telefon='" + UyeTelefon + "'");
                    DataTable uyeMailData = db.getData("SELECT EmailAdresi FROM Uye WHERE EmailAdresi='" + UyeMail + "'");
                    if (uyeTelefonData.Rows.Count > 0 || uyeMailData.Rows.Count > 0)
                    {
                        MessageBox.Show("Kayıt güncelleme işlemi tamamlanamadı bu telefonu veya maili kullanan üye zaten mevcut, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int kayitGuncelle = db.execute("UPDATE Uye SET Adi = '" + UyeAdi + "', Soyadi = '" + UyeSoyadi + "', EmailAdresi = '" + UyeMail + "', Telefon = '" + UyeTelefon + "' WHERE Id=" + seciliUyeId + "");
                    if (kayitGuncelle > 0)
                    {
                        MessageBox.Show("Kayıt güncelleme başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UyeleriGetir();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işlemi tamamlanamadı, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataTable uyeData = db.getData("SELECT Adi FROM Uye WHERE Id='" + seciliUyeId + "'");

            if (uyeData.Rows.Count > 0) // DataTable'da satır var mı kontrolü
            {
                ListViewItem selectedRow = lvUyeListe.SelectedItems.Count > 0 ? lvUyeListe.SelectedItems[0] : null;

                if (selectedRow != null)
                {
                    seciliUyeId = Convert.ToInt32(selectedRow.SubItems[0].Text);

                    string uyeAdi = uyeData.Rows[0]["Adi"].ToString();

                    if (MessageBox.Show("Bu kaydı " + uyeAdi + " gerçekten silmek istiyor musunuz?", "Kayıt Silinsin mi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int kayitSil = db.execute("DELETE FROM Uye WHERE Id=" + seciliUyeId + "");

                        if (kayitSil > 0)
                        {
                            MessageBox.Show("Kayıt silme işlemi başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UyeleriGetir();
                            GirdileriTemizle();
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi Tamamlanamadı bu kategoride kitap veya kitaplar mevcut.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }

            private void lvUyeListe_DoubleClick(object sender, EventArgs e)
        {
            if (lvUyeListe.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lvUyeListe.SelectedItems[0];
                txtUyeAdi.Text = selectedRow.SubItems[1].Text;
                txtUyeSoyadi.Text = selectedRow.SubItems[2].Text;
                txtUyeMailAdresi.Text = selectedRow.SubItems[3].Text;
                txtUyeTelefon.Text = selectedRow.SubItems[4].Text;
                seciliUyeId = Convert.ToInt32(selectedRow.SubItems[0].Text);
                btnKaydet.Text = "Düzenle";
                btn_temizle.Visible = true;
            }
            else
            {
                btnKaydet.Text = "Kaydet";
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            GirdileriTemizle();
        }
    }
}
