using KutuphaneProje.Model;
using kutuphaneProjesi.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class frmKitapTeslimEt : Form
    {
        private int? secilenKitapId = null;
        public frmKitapTeslimEt(int? seciliKitapId = null)
        {
            InitializeComponent();

            secilenKitapId = seciliKitapId;
        }

        Database db = new Database();

        private void frmKitapTeslim_Load(object sender, EventArgs e)
        {
            List<Kitap> kitaplar = KitaplariGetir();
            List<Uye> uyeler = UyeleriGetir();

            cbKitap.Items.Clear();
            cbKitap.DataSource = kitaplar;
            cbKitap.DisplayMember = "KitapAdi";
            cbKitap.ValueMember = "Id";

            cbUye.Items.Clear();
            cbUye.DataSource = uyeler;
            cbUye.DisplayMember = "AdiSoyadi";
            cbUye.ValueMember = "Id";

            if (secilenKitapId.HasValue)
            {
                for (int i = 0; i < cbKitap.Items.Count; i++)
                {
                    if (((Kitap)cbKitap.Items[i]).Id == secilenKitapId.Value)
                    {
                        cbKitap.SelectedIndex = i;
                        break;
                    }
                }
            }

        }

        public List<Kitap> KitaplariGetir()
        {
            List<Kitap> kitapListesi = new List<Kitap>();
            DataTable dtkitapListesi = db.getData("SELECT * FROM Kitap WHERE Adet>0 ORDER BY KitapAdi ASC");
            if (dtkitapListesi != null && dtkitapListesi.Rows.Count > 0)
            {
                for (int i = 0; i < dtkitapListesi.Rows.Count; i++)
                {
                    kitapListesi.Add(new Kitap
                    {
                        Id = Convert.ToInt32(dtkitapListesi.Rows[i]["Id"]),
                        KitapAdi = dtkitapListesi.Rows[i]["KitapAdi"].ToString()
                    });
                }
            }
            return kitapListesi;
        }

        public List<Uye> UyeleriGetir()
        {
            List<Uye> uyeListesi = new List<Uye>();
            DataTable dtuyeListesi = db.getData("SELECT * FROM Uye ORDER BY Adi ASC");
            if (dtuyeListesi != null && dtuyeListesi.Rows.Count > 0)
            {
                for (int i = 0; i < dtuyeListesi.Rows.Count; i++)
                {
                    uyeListesi.Add(new Uye
                    {
                        Id = Convert.ToInt32(dtuyeListesi.Rows[i]["Id"]),
                        AdiSoyadi = dtuyeListesi.Rows[i]["Adi"].ToString() + " " + dtuyeListesi.Rows[i]["Soyadi"].ToString()
                    });
                }
            }
            return uyeListesi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int kitapId = ((Kitap)cbKitap.SelectedItem).Id;
            int uyeId = ((Uye)cbUye.SelectedItem).Id;
            string verilisTarihi = dtTarih.Value.ToString("yyyy-MM-dd HH:mm:ss");
            int kayitEkle = db.execute("INSERT INTO KitapTeslim(UyeId, KitapId, VerilisTarihi, TeslimAlindiMi) Values(" + uyeId + ", " + kitapId + ",'" + verilisTarihi + "', 0)");
            if (kayitEkle > 0)
            {
                db.execute("Update Kitap set Adet = Adet - 1  Where Id=" + kitapId + "");

                MessageBox.Show("Kayıt işlemi başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }
    }
}
