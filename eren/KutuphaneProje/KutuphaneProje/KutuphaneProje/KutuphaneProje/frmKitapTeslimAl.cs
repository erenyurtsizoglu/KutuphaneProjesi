using KutuphaneProje.Model;
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
    public partial class frmKitapTeslimAl : Form
    {
        public frmKitapTeslimAl()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void frmKitapTeslimAl_Load(object sender, EventArgs e)
        {
            List<Uye> uyeler = UyeleriGetir();

            cbUye.Items.Clear();
            cbUye.DataSource = uyeler;
            cbUye.DisplayMember = "AdiSoyadi";
            cbUye.ValueMember = "Id";
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

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            int seciliId = 0;
            int uyeId = ((Uye)cbUye.SelectedItem).Id;
            if (lvKitapListesi.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lvKitapListesi.SelectedItems[0];
                seciliId = Convert.ToInt32(selectedRow.SubItems[0].Text);

                int teslimAl = db.execute("update KitapTeslim SET TeslimAlindiMi=1, TeslimTarihi=GETDATE() WHERE Id=" + seciliId + "");
                if (teslimAl > 0)
                {
                    DataTable dtKayitDetay = db.getData("SELECT * FROM KitapTeslim WHERE Id=" + seciliId + "");
                    if (dtKayitDetay != null && dtKayitDetay.Rows.Count > 0)
                    {
                        int kitapId = Convert.ToInt32(dtKayitDetay.Rows[0]["KitapId"]);
                        db.execute("Update Kitap set Adet = Adet + 1  Where Id=" + kitapId + "");

                    }

                    MessageBox.Show("Kitap Teslimi başarılı bir şekilde tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void cbUye_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvKitapListesi.Items.Clear();
            if (cbUye.SelectedItem != null)
            {
                int secilenUyeId = ((Uye)cbUye.SelectedItem).Id;
                DataTable dtUyeKitaplari = db.getData("SELECT KitapTeslim.Id, KitapTeslim.VerilisTarihi as VerilisTarihi, Kitap.KitapAdi as KitapAdi FROM KitapTeslim INNER JOIN Kitap On Kitap.Id = KitapTeslim.KitapId WHERE UyeId = " + secilenUyeId + " AND TeslimAlindiMi=0");
                if (dtUyeKitaplari != null && dtUyeKitaplari.Rows.Count > 0)
                {
                    for (int i = 0; i < dtUyeKitaplari.Rows.Count; i++)
                    {
                        ListViewItem item = new ListViewItem(dtUyeKitaplari.Rows[i]["Id"].ToString());
                        item.SubItems.Add(dtUyeKitaplari.Rows[i]["KitapAdi"].ToString());
                        item.SubItems.Add(dtUyeKitaplari.Rows[i]["VerilisTarihi"].ToString());
                        lvKitapListesi.Items.Add(item);
                    }
                }
            }
        }
    }
}
