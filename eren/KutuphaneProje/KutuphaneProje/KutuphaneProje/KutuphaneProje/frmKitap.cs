using KutuphaneProje.Model;
using kutuphaneProjesi.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class frmKitap : Form
    {
        Database db = new Database();
        private bool guncellemeIslemi = false;
        private int? guncellenecekKitapId = null;
        public frmKitap(int? kitapId = null)
        {
            InitializeComponent();
            if (kitapId.HasValue)
            {
                guncellemeIslemi = true;
            }
            guncellenecekKitapId = kitapId;
        }

        private void frmKitap_Load(object sender, EventArgs e)
        {
            List<KitapKategori> kategoriler = KategorileriGetir();
            List<KitapTur> turler = KitapTurleriGetir();
            List<Yazar> yazarlar = YazarGetir();

            cbKitapKategori.Items.Clear();
            cbKitapKategori.DataSource = kategoriler;
            cbKitapKategori.DisplayMember = "KategoriAdi";
            cbKitapKategori.ValueMember = "Id";

            cbKitapTur.Items.Clear();
            cbKitapTur.DataSource = turler;
            cbKitapTur.DisplayMember = "TurAdi";
            cbKitapTur.ValueMember = "Id";

            cbYazar.Items.Clear();
            cbYazar.DataSource = yazarlar;
            cbYazar.DisplayMember = "YazarAdi";
            cbYazar.ValueMember = "Id";

            if(guncellemeIslemi && guncellenecekKitapId.HasValue)
            {
                DataTable dtKitapDetay = db.getData("SELECT * FROM Kitap WHERE Id=" + guncellenecekKitapId.Value + "");
                if(dtKitapDetay!= null && dtKitapDetay.Rows.Count > 0)
                {
                    txtDil.Text = dtKitapDetay.Rows[0]["Dil"].ToString();
                    txtKitapAdi.Text = dtKitapDetay.Rows[0]["KitapAdi"].ToString();
                    txtYayinEvi.Text = dtKitapDetay.Rows[0]["YayinEvi"].ToString();
                    txtBasimYili.Text = dtKitapDetay.Rows[0]["YayinYili"].ToString();
                    txtSayfaSayisi.Text = dtKitapDetay.Rows[0]["SayfaSayisi"].ToString();
                    nmStokAdet.Value = Convert.ToInt32(dtKitapDetay.Rows[0]["Adet"].ToString());

                    for (int i = 0; i < cbKitapKategori.Items.Count; i++)
                    {
                        if (((KitapKategori)cbKitapKategori.Items[i]).Id == Convert.ToInt32(dtKitapDetay.Rows[0]["KategoriId"].ToString()))
                        {
                            cbKitapKategori.SelectedIndex = i;
                            break;
                        }
                    }

                    for (int i = 0; i < cbKitapTur.Items.Count; i++)
                    {
                        if (((KitapTur)cbKitapTur.Items[i]).Id == Convert.ToInt32(dtKitapDetay.Rows[0]["TurId"].ToString()))
                        {
                            cbKitapTur.SelectedIndex = i;
                            break;
                        }
                    }

                    for (int i = 0; i < cbYazar.Items.Count; i++)
                    {
                        if (((Yazar)cbYazar.Items[i]).Id == Convert.ToInt32(dtKitapDetay.Rows[0]["YazarId"].ToString()))
                        {
                            cbYazar.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }


        public List<KitapKategori> KategorileriGetir()
        {
            List<KitapKategori> kategoriListesi = new List<KitapKategori>();
            DataTable dtKategoriListesi = db.getData("SELECT * FROM KitapKategori ORDER BY KategoriAdi ASC");
            if (dtKategoriListesi != null && dtKategoriListesi.Rows.Count > 0)
            {
                for (int i = 0; i < dtKategoriListesi.Rows.Count; i++)
                {
                    kategoriListesi.Add(new KitapKategori
                    {
                        Id = Convert.ToInt32(dtKategoriListesi.Rows[i]["Id"]),
                        KategoriAdi = dtKategoriListesi.Rows[i]["KategoriAdi"].ToString()
                    });
                }
            }
            return kategoriListesi;
        }

        public List<KitapTur> KitapTurleriGetir()
        {
            List<KitapTur> kitapTurListesi = new List<KitapTur>();
            DataTable dtKitapTurListesi = db.getData("SELECT * FROM KitapTuru ORDER BY TurAdi ASC");
            if (dtKitapTurListesi != null && dtKitapTurListesi.Rows.Count > 0)
            {
                for (int i = 0; i < dtKitapTurListesi.Rows.Count; i++)
                {
                    kitapTurListesi.Add(new KitapTur
                    {
                        Id = Convert.ToInt32(dtKitapTurListesi.Rows[i]["Id"]),
                        TurAdi = dtKitapTurListesi.Rows[i]["TurAdi"].ToString()
                    });
                }
            }
            return kitapTurListesi;
        }

        public List<Yazar> YazarGetir()
        {
            List<Yazar> yazarListesi = new List<Yazar>();
            DataTable dtYazarListesi = db.getData("SELECT * FROM Yazar ORDER BY AdiSoyadi ASC");
            if (dtYazarListesi != null && dtYazarListesi.Rows.Count > 0)
            {
                for (int i = 0; i < dtYazarListesi.Rows.Count; i++)
                {
                    yazarListesi.Add(new Yazar
                    {
                        Id = Convert.ToInt32(dtYazarListesi.Rows[i]["Id"]),
                        YazarAdi = dtYazarListesi.Rows[i]["AdiSoyadi"].ToString()
                    });
                }
            }
            return yazarListesi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int kategoriId = ((KitapKategori)cbKitapKategori.SelectedItem).Id;
            int kitapTurId = ((KitapTur)cbKitapTur.SelectedItem).Id;
            int yazarId = ((Yazar)cbYazar.SelectedItem).Id;
            string kitapAdi = txtKitapAdi.Text.Trim();
            string yayinEvi = txtYayinEvi.Text.Trim();
            string basimDili = txtDil.Text.Trim();
            int stokAdet = Convert.ToInt32(nmStokAdet.Value);
            int basimYili = Convert.ToInt32(txtBasimYili.Text);
            int sayfaSayisi = Convert.ToInt32(txtSayfaSayisi.Text);

            if (string.IsNullOrEmpty(kitapAdi))
            {
                MessageBox.Show("Lütfen kitap adı bilgisini boş bırakmayınız.", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sqlSorgu = string.Empty;

            if (guncellemeIslemi == false && guncellenecekKitapId.HasValue == false)
            {
                sqlSorgu = @"
                    INSERT INTO Kitap (KategoriId,YazarId,TurId,KitapAdi,Adet,YayinEvi,YayinYili,SayfaSayisi,Dil)
                         VALUES
                               (" + kategoriId + "," + yazarId + "," + kitapTurId + ",'" + kitapAdi + "', " + stokAdet + ", '" + yayinEvi + "', " + basimYili + ", " + sayfaSayisi + ", '" + basimDili + "')";

                int kaydet = db.execute(sqlSorgu);
                if (kaydet > 0)
                {
                    MessageBox.Show("Kayıt işlemi başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                sqlSorgu = @"UPDATE Kitap
                           SET KategoriId = " + kategoriId + @"
                              ,YazarId = " + yazarId + @"
                              ,TurId = " + kitapTurId + @"
                              ,KitapAdi = '" + kitapAdi + @"'
                              ,Adet = " + stokAdet + @"
                              ,YayinEvi = '" + yayinEvi + @"'
                              ,YayinYili = " + basimYili + @"
                              ,SayfaSayisi = " + sayfaSayisi + @"
                              ,Dil = '" + basimDili + @"'
                         WHERE Id=" + guncellenecekKitapId + "";

                int kayitGuncelle = db.execute(sqlSorgu);
                if(kayitGuncelle > 0)
                {
                    MessageBox.Show("Kayıt güncelleme işlemi başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}