using kutuphaneProjesi.Helper;
using System;
using System.Data;
using System.Windows.Forms;

namespace KutuphaneProje
{
    public partial class frmKutuphane : Form
    {
        public frmKutuphane()
        {
            InitializeComponent();
        }

        Database db = new Database();

        private void kitapKategorileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapKategori frmKitapKategori = new frmKitapKategori();
            frmKitapKategori.ShowDialog();
        }

        private void kitapTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapTur frmKitapTur = new frmKitapTur();
            frmKitapTur.ShowDialog();
        }

        private void yazarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYazar frmYazar = new frmYazar();
            frmYazar.ShowDialog();
        }

        private void frmKutuphane_Load(object sender, EventArgs e)
        {
            KitapGetir("");
        }

        private void KitapGetir(string aramaKelime)
        {
            string sqlSorgu = @"SELECT 
	                                Kitap.Id as Id,
                                    Kitap.KitapAdi as KitapAdi,
	                                Kitap.Adet as Adet,
	                                Kitap.Dil as Dil,
	                                Kitap.YayinEvi as YayinEvi,
	                                Kitap.YayinYili as YayinYili,
	                                Kitap.SayfaSayisi as SayfaSayisi,
	                                KitapKategori.KategoriAdi as KategoriAdi,
	                                KitapTuru.TurAdi as TurAdi,
	                                Yazar.AdiSoyadi as YazarAdi
                                FROM Kitap
                                Inner Join KitapKategori On Kitap.KategoriId = KitapKategori.Id
                                Inner Join KitapTuru On Kitap.TurId = KitapTuru.Id
                                Inner Join Yazar On Kitap.YazarId = Yazar.Id";
            string sqlWhereKosul = string.Empty;
            if (!string.IsNullOrEmpty(aramaKelime))
            {
                sqlWhereKosul = " WHERE Kitap.KitapAdi LIKE '%" + aramaKelime
                               + "%' OR Kitap.YayinEvi LIKE '%" + aramaKelime
                               + "%' OR KitapKategori.KategoriAdi LIKE '%" + aramaKelime
                               + "%' OR Yazar.AdiSoyadi LIKE '%" + aramaKelime + "%'";
            }

            string sqlKomut = string.Format("{0}{1}", sqlSorgu, sqlWhereKosul);
            
            lvKitapList.Items.Clear();
            DataTable dtKitapList = db.getData(sqlKomut);
            if(dtKitapList!= null && dtKitapList.Rows.Count> 0)
            {
                for (int i = 0; i < dtKitapList.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(dtKitapList.Rows[i]["Id"].ToString());
                    item.SubItems.Add(dtKitapList.Rows[i]["KitapAdi"].ToString());
                    item.SubItems.Add(dtKitapList.Rows[i]["KategoriAdi"].ToString());
                    item.SubItems.Add(dtKitapList.Rows[i]["TurAdi"].ToString());
                    item.SubItems.Add(dtKitapList.Rows[i]["YazarAdi"].ToString());
                    item.SubItems.Add(dtKitapList.Rows[i]["SayfaSayisi"].ToString());
                    item.SubItems.Add(dtKitapList.Rows[i]["YayinYili"].ToString());
                    item.SubItems.Add(dtKitapList.Rows[i]["Dil"].ToString());
                    lvKitapList.Items.Add(item);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KitapGetir(textBox1.Text);
        }

        private void yeniKitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitap frmKitap = new frmKitap();
            frmKitap.ShowDialog();
        }

        private void bilgileriDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int seciliKitapId = 0;
            if (lvKitapList.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lvKitapList.SelectedItems[0];
                seciliKitapId = Convert.ToInt32(selectedRow.SubItems[0].Text);
                frmKitap frmKitap = new frmKitap(seciliKitapId);
                frmKitap.ShowDialog();
            }
        }

        private void ödünçVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int seciliKitapId = 0;
            if (lvKitapList.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = lvKitapList.SelectedItems[0];
                seciliKitapId = Convert.ToInt32(selectedRow.SubItems[0].Text);
                frmKitapTeslimEt frmKitapTeslim = new frmKitapTeslimEt(seciliKitapId);
                frmKitapTeslim.ShowDialog();
            }

            
        }
    }
}