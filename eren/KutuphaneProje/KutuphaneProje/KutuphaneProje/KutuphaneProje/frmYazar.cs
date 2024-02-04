﻿using kutuphaneProjesi.Helper;
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
    public partial class frmYazar : Form
    {
        public frmYazar()
        {
            InitializeComponent();
        }

        private void GirdileriTemizle()
        {
            txtYazarAdi.Text = "";
            btnKaydet.Text = "Kaydet";
            btnTemizle.Visible = false;
            seciliYazarId = 0;
        }

        Database db = new Database();
        private int seciliYazarId = 0;

        private void YazarlarıGetir()
        {
            lvYazarAdiListe.Items.Clear();
            try
            {
                DataTable dtYazarListe = db.getData("SELECT * FROM Yazar");
                if (dtYazarListe != null && dtYazarListe.Rows.Count > 0)
                {
                    for (int i = 0; i < dtYazarListe.Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(dtYazarListe.Rows[i]["Id"].ToString());
                        item.SubItems.Add(dtYazarListe.Rows[i]["AdiSoyadi"].ToString());
                        lvYazarAdiListe.Items.Add(item);
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

        private void frmYazar_Load(object sender, EventArgs e)
        {
            YazarlarıGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string yazarAdi = txtYazarAdi.Text.Trim();
            if (string.IsNullOrEmpty(yazarAdi))
            {
                MessageBox.Show("Lütfen yazar adı soyadı bilgisinin dolu olduğunu kontrol edin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnKaydet.Text == "Kaydet")
            {
                DataTable yazarData = db.getData("SELECT AdiSoyadi FROM Yazar WHERE AdiSoyadi='" + yazarAdi + "'");
                if (yazarData.Rows.Count > 0)
                {
                    MessageBox.Show("Kayıt işlemi tamamlanamadı bu kayıt zaten mevcut, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int kayitEkle = db.execute("INSERT INTO Yazar(AdiSoyadi) VALUES('" + yazarAdi + "')");
                if (kayitEkle > 0)
                {
                    MessageBox.Show("Kayıt işlemi başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    YazarlarıGetir();
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi tamamlanamadı, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (seciliYazarId > 0)
                {
                    DataTable yazarData = db.getData("SELECT AdiSoyadi FROM Yazar WHERE AdiSoyadi='" + yazarAdi + "'");
                    if (yazarData.Rows.Count > 0)
                    {
                        MessageBox.Show("Kayıt işlemi tamamlanamadı bu kayıt zaten mevcut, lütfen bilgilerinizi kontrol edin.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int kayitGuncelle = db.execute("UPDATE Yazar SET AdiSoyadi = '" + yazarAdi + "' WHERE Id=" + seciliYazarId + "");
                    if (kayitGuncelle > 0)
                    {
                        MessageBox.Show("Kayıt güncelleme başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        YazarlarıGetir();
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
            DataTable yazarData = db.getData("SELECT AdiSoyadi FROM Yazar WHERE Id='" + seciliYazarId + "'");

            if (yazarData.Rows.Count > 0) // DataTable'da satır var mı kontrolü
            {
                ListViewItem selectedRow = lvYazarAdiListe.SelectedItems.Count > 0 ? lvYazarAdiListe.SelectedItems[0] : null;

                if (selectedRow != null)
                {
                    seciliYazarId = Convert.ToInt32(selectedRow.SubItems[0].Text);

                    string yazarAdi = yazarData.Rows[0]["AdiSoyadi"].ToString();

                    if (MessageBox.Show("Bu kaydı " + yazarAdi + " gerçekten silmek istiyor musunuz?", "Kayıt Silinsin mi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int kayitSil = db.execute("DELETE FROM Yazar WHERE Id=" + seciliYazarId + "");

                        if (kayitSil > 0)
                        {
                            MessageBox.Show("Kayıt silme başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            YazarlarıGetir();
                            GirdileriTemizle();
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi Tamamlanamadı bu yazarın kütüphanede mevcut yazdığı kitap veya kitaplar mevcut.", "İşlem Tamamlanamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen çift tıkladığınızdan emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvYazarAdiListe_DoubleClick(object sender, EventArgs e)
        {
            if (lvYazarAdiListe.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lvYazarAdiListe.SelectedItems[0];
                txtYazarAdi.Text = selectedRow.SubItems[1].Text;
                seciliYazarId = Convert.ToInt32(selectedRow.SubItems[0].Text);
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
