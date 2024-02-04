namespace KutuphaneProje
{
    partial class frmKutuphane
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvKitapList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bilgileriDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödünçVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKategorileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTürleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1156, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Sorgula";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(4, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1148, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvKitapList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 114);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1156, 484);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap Listesi";
            // 
            // lvKitapList
            // 
            this.lvKitapList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvKitapList.ContextMenuStrip = this.contextMenuStrip1;
            this.lvKitapList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKitapList.FullRowSelect = true;
            this.lvKitapList.GridLines = true;
            this.lvKitapList.HideSelection = false;
            this.lvKitapList.Location = new System.Drawing.Point(4, 19);
            this.lvKitapList.Margin = new System.Windows.Forms.Padding(4);
            this.lvKitapList.Name = "lvKitapList";
            this.lvKitapList.Size = new System.Drawing.Size(1148, 461);
            this.lvKitapList.TabIndex = 0;
            this.lvKitapList.UseCompatibleStateImageBehavior = false;
            this.lvKitapList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kitap Adı";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kitap türü";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yazar";
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sayfa Sayısı";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Yayın Yılı";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Dil";
            this.columnHeader8.Width = 82;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgileriDüzenleToolStripMenuItem,
            this.ödünçVerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 52);
            // 
            // bilgileriDüzenleToolStripMenuItem
            // 
            this.bilgileriDüzenleToolStripMenuItem.Name = "bilgileriDüzenleToolStripMenuItem";
            this.bilgileriDüzenleToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.bilgileriDüzenleToolStripMenuItem.Text = "Bilgileri Düzenle";
            this.bilgileriDüzenleToolStripMenuItem.Click += new System.EventHandler(this.bilgileriDüzenleToolStripMenuItem_Click);
            // 
            // ödünçVerToolStripMenuItem
            // 
            this.ödünçVerToolStripMenuItem.Name = "ödünçVerToolStripMenuItem";
            this.ödünçVerToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.ödünçVerToolStripMenuItem.Text = "Ödünç Ver";
            this.ödünçVerToolStripMenuItem.Click += new System.EventHandler(this.ödünçVerToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1156, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapİşlemleriToolStripMenuItem,
            this.yeniKitapEkleToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapKategorileriToolStripMenuItem,
            this.kitapTürleriToolStripMenuItem,
            this.yazarlarToolStripMenuItem});
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.kitapİşlemleriToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // kitapKategorileriToolStripMenuItem
            // 
            this.kitapKategorileriToolStripMenuItem.Name = "kitapKategorileriToolStripMenuItem";
            this.kitapKategorileriToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.kitapKategorileriToolStripMenuItem.Text = "Kitap Kategorileri";
            this.kitapKategorileriToolStripMenuItem.Click += new System.EventHandler(this.kitapKategorileriToolStripMenuItem_Click);
            // 
            // kitapTürleriToolStripMenuItem
            // 
            this.kitapTürleriToolStripMenuItem.Name = "kitapTürleriToolStripMenuItem";
            this.kitapTürleriToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.kitapTürleriToolStripMenuItem.Text = "Kitap Türleri";
            this.kitapTürleriToolStripMenuItem.Click += new System.EventHandler(this.kitapTürleriToolStripMenuItem_Click);
            // 
            // yazarlarToolStripMenuItem
            // 
            this.yazarlarToolStripMenuItem.Name = "yazarlarToolStripMenuItem";
            this.yazarlarToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.yazarlarToolStripMenuItem.Text = "Yazarlar";
            this.yazarlarToolStripMenuItem.Click += new System.EventHandler(this.yazarlarToolStripMenuItem_Click);
            // 
            // yeniKitapEkleToolStripMenuItem
            // 
            this.yeniKitapEkleToolStripMenuItem.Name = "yeniKitapEkleToolStripMenuItem";
            this.yeniKitapEkleToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.yeniKitapEkleToolStripMenuItem.Text = "Yeni Kitap Ekle";
            this.yeniKitapEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniKitapEkleToolStripMenuItem_Click);
            // 
            // frmKutuphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 598);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKutuphane";
            this.Text = "Kütüphane Yönetimi";
            this.Load += new System.EventHandler(this.frmKutuphane_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvKitapList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapKategorileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapTürleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKitapEkleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bilgileriDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödünçVerToolStripMenuItem;
    }
}