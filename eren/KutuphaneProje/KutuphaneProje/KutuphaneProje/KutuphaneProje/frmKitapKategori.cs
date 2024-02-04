using kutuphaneProjesi.Helper;
using System;
using System.Data;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class frmKitapKategori : Form
    {
        public frmKitapKategori()
        {
            InitializeComponent();
        }

        Database db = new Database();
        private int seciliKategoriId = 0;
        
        private void frmKitapKategori_Load(object sender, EventArgs e)
        {
            
            KategorileriGetir();
        }


        private void GirdileriTemizle()
        {
            txtKategoriAdi.Text = "";
            btnKaydet.Text = "Kaydet";
            btnTemizle.Visible = false;
            seciliKategoriId = 0;
        }


        private void KategorileriGetir()
        {
            lvKategoriAdiListe.Items.Clear();
            try
            {
                DataTable dtKitapKategoriListe = db.getData("SELECT * FROM KitapKategori");
                if (dtKitapKategoriListe != null && dtKitapKategoriListe.Rows.Count > 0)
                {
                    for (int i = 0; i < dtKitapKategoriListe.Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(dtKitapKategoriListe.Rows[i]["Id"].ToString());
                        item.SubItems.Add(dtKitapKategoriListe.Rows[i]["KategoriAdi"].ToString());
                        lvKategoriAdiListe.Items.Add(item);
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
            string kategoriAdi = txtKategoriAdi.Text.Trim();
            if (string.IsNullOrEmpty(kategoriAdi))
            {
                MessageBox.Show("Lütfen kategori adı bilgisinin dolu olduğunu kontrol edin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnKaydet.Text == "Kaydet")
            {

                DataTable kategoriData = db.getData("SELECT KategoriAdi FROM KitapKategori WHERE KategoriAdi='" + kategoriAdi + "'");
                if (kategoriData.Rows.Count > 0)
                {
                    MessageBox.Show("Kayıt işlemi tamamlanamadı bu kayıt zaten mevcut, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int kayitEkle = db.execute("INSERT INTO KitapKategori(KategoriAdi) VALUES('" + kategoriAdi + "')");
                if (kayitEkle > 0)
                {
                    MessageBox.Show("Kayıt işlemi başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KategorileriGetir();
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi tamamlanamadı, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // kayıt güncelleme işlemi
                if (seciliKategoriId > 0)
                {
                    DataTable kategoriData = db.getData("SELECT KategoriAdi FROM KitapKategori WHERE KategoriAdi='" + kategoriAdi + "'");
                    if (kategoriData.Rows.Count > 0)
                    {
                        MessageBox.Show("Kayıt işlemi tamamlanamadı bu kayıt zaten mevcut, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int kayitGuncelle = db.execute("UPDATE KitapKategori SET KategoriAdi = '" + kategoriAdi + "' WHERE Id=" + seciliKategoriId + "");
                    if (kayitGuncelle > 0)
                    {
                        MessageBox.Show("Kayıt güncelleme başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KategorileriGetir();
                        GirdileriTemizle();
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
            DataTable kategoriData = db.getData("SELECT KategoriAdi FROM KitapKategori WHERE Id='" + seciliKategoriId + "'");

            if (kategoriData.Rows.Count > 0) // DataTable'da satır var mı kontrolü
            {
                ListViewItem selectedRow = lvKategoriAdiListe.SelectedItems.Count > 0 ? lvKategoriAdiListe.SelectedItems[0] : null;

                if (selectedRow != null)
                {
                    seciliKategoriId = Convert.ToInt32(selectedRow.SubItems[0].Text);

                    string kategoriAdi = kategoriData.Rows[0]["KategoriAdi"].ToString();

                    if (MessageBox.Show("Bu kaydı " + kategoriAdi + " gerçekten silmek istiyor musunuz?", "Kayıt Silinsin mi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int kayitSil = db.execute("DELETE FROM KitapKategori WHERE Id=" + seciliKategoriId + "");

                        if (kayitSil > 0)
                        {
                            MessageBox.Show("Kayıt güncelleme başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KategorileriGetir();
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
            else
            {
                MessageBox.Show("Veritabanında böyle bir kayıt bulunamadı, Lütfen çift tıkladığınızdan emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void lvKategoriAdiListe_DoubleClick(object sender, EventArgs e)
        {
            if (lvKategoriAdiListe.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lvKategoriAdiListe.SelectedItems[0];
                txtKategoriAdi.Text = selectedRow.SubItems[1].Text;
                seciliKategoriId = Convert.ToInt32(selectedRow.SubItems[0].Text);
                btnKaydet.Text = "Düzenle";
                btnTemizle.Visible = true;
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
