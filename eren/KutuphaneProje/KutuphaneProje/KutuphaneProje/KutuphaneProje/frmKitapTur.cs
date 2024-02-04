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
    public partial class frmKitapTur : Form
    {
        public frmKitapTur()
        {
            InitializeComponent();
        }

        Database db = new Database();
        private int seciliTurId = 0;


        private void GirdileriTemizle()
        {
            txtTurAdi.Text = "";
            btnKaydet.Text = "Kaydet";
            btnTemizle.Visible = false;
            seciliTurId = 0;
        }


        private void TurleriGetir()
        {
            lvTurAdiListe.Items.Clear();
            try
            {
                DataTable dtKitapTurListe = db.getData("SELECT * FROM KitapTuru");
                if (dtKitapTurListe != null && dtKitapTurListe.Rows.Count > 0)
                {
                    for (int i = 0; i < dtKitapTurListe.Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(dtKitapTurListe.Rows[i]["Id"].ToString());
                        item.SubItems.Add(dtKitapTurListe.Rows[i]["TurAdi"].ToString());
                        lvTurAdiListe.Items.Add(item);
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


        private void btnKaydet_Click(object sender, EventArgs e)
        {

            string turAdi = txtTurAdi.Text.Trim();
            if (string.IsNullOrEmpty(turAdi))
            {
                MessageBox.Show("Lütfen kategori adı bilgisinin dolu olduğunu kontrol edin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnKaydet.Text == "Kaydet")
            {
                DataTable turData = db.getData("SELECT TurAdi FROM KitapTuru WHERE TurAdi='" + turAdi + "'");
                if (turData.Rows.Count > 0)
                {
                    MessageBox.Show("Kayıt işlemi tamamlanamadı bu kayıt zaten mevcut, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int kayitEkle = db.execute("INSERT INTO KitapTuru(TurAdi) VALUES('" + turAdi + "')");
                if (kayitEkle > 0)
                {
                    MessageBox.Show("Kayıt işlemi başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TurleriGetir();
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi tamamlanamadı, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                DataTable turData = db.getData("SELECT TurAdi FROM KitapTuru WHERE TurAdi='" + turAdi + "'");
                if (turData.Rows.Count > 0)
                {
                    MessageBox.Show("Kayıt işlemi tamamlanamadı bu kayıt zaten mevcut, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (seciliTurId > 0)
                {

                    int kayitGuncelle = db.execute("UPDATE KitapTuru SET TurAdi = '" + turAdi + "' WHERE Id=" + seciliTurId + "");
                    if (kayitGuncelle > 0)
                    {
                        MessageBox.Show("Kayıt güncelleme başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TurleriGetir();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt işlemi tamamlanamadı, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void frmKitapTur_Load(object sender, EventArgs e)
        {
            TurleriGetir();
        }

        private void lvTurAdiListe_DoubleClick(object sender, EventArgs e)
        {
            if (lvTurAdiListe.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lvTurAdiListe.SelectedItems[0];
                txtTurAdi.Text = selectedRow.SubItems[1].Text;
                seciliTurId = Convert.ToInt32(selectedRow.SubItems[0].Text);
                btnKaydet.Text = "Düzenle";
                btnTemizle.Visible = true;
            }
            else
            {
                btnKaydet.Text = "Kaydet";
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataTable kategoriData = db.getData("SELECT TurAdi FROM KitapTuru WHERE Id='" + seciliTurId + "'");

            if (kategoriData.Rows.Count > 0) // DataTable'da satır var mı kontrolü
            {
                ListViewItem selectedRow = lvTurAdiListe.SelectedItems.Count > 0 ? lvTurAdiListe.SelectedItems[0] : null;

                if (selectedRow != null)
                {
                    seciliTurId = Convert.ToInt32(selectedRow.SubItems[0].Text);

                    string TurAdi = kategoriData.Rows[0]["TurAdi"].ToString();

                    if (MessageBox.Show("Bu kaydı " + TurAdi + " gerçekten silmek istiyor musunuz?", "Kayıt Silinsin mi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int kayitSil = db.execute("DELETE FROM KitapTuru WHERE Id=" + seciliTurId + "");

                        if (kayitSil > 0)
                        {
                            MessageBox.Show("Kayıt güncelleme başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TurleriGetir();
                            GirdileriTemizle();
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi Tamamlanamadı bu türde kitap veya kitaplar mevcut.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veritabanında böyle bir kayıt bulunamadı, Lütfen çift tıkladığınızdan emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
          GirdileriTemizle();
        }
    }
}
