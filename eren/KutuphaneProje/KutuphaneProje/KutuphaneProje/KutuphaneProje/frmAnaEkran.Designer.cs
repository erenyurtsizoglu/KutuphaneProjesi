namespace KutuphaneProje
{
    partial class frmAnaEkran
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
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSLKullanıcı = new System.Windows.Forms.ToolStripStatusLabel();
            this.stLabelKullaniciAdi = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnKtphnYonetim = new System.Windows.Forms.Button();
            this.btnUyeYonetim = new System.Windows.Forms.Button();
            this.btnKtpVer = new System.Windows.Forms.Button();
            this.btnKtpAl = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer3
            // 
            this.timer3.Interval = 750;
            // 
            // timer2
            // 
            this.timer2.Interval = 750;
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLKullanıcı,
            this.stLabelKullaniciAdi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSLKullanıcı
            // 
            this.tSSLKullanıcı.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tSSLKullanıcı.Name = "tSSLKullanıcı";
            this.tSSLKullanıcı.Size = new System.Drawing.Size(158, 20);
            this.tSSLKullanıcı.Text = "Giriş Yapan Kullanıcı: ";
            // 
            // stLabelKullaniciAdi
            // 
            this.stLabelKullaniciAdi.Name = "stLabelKullaniciAdi";
            this.stLabelKullaniciAdi.Size = new System.Drawing.Size(0, 20);
            // 
            // btnKtphnYonetim
            // 
            this.btnKtphnYonetim.Location = new System.Drawing.Point(33, 37);
            this.btnKtphnYonetim.Margin = new System.Windows.Forms.Padding(4);
            this.btnKtphnYonetim.Name = "btnKtphnYonetim";
            this.btnKtphnYonetim.Size = new System.Drawing.Size(343, 92);
            this.btnKtphnYonetim.TabIndex = 27;
            this.btnKtphnYonetim.Text = "Kütüphane Yönetimi";
            this.btnKtphnYonetim.UseVisualStyleBackColor = true;
            this.btnKtphnYonetim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUyeYonetim
            // 
            this.btnUyeYonetim.Location = new System.Drawing.Point(399, 37);
            this.btnUyeYonetim.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyeYonetim.Name = "btnUyeYonetim";
            this.btnUyeYonetim.Size = new System.Drawing.Size(343, 92);
            this.btnUyeYonetim.TabIndex = 28;
            this.btnUyeYonetim.Text = "Üye Yönetimi";
            this.btnUyeYonetim.UseVisualStyleBackColor = true;
            this.btnUyeYonetim.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKtpVer
            // 
            this.btnKtpVer.Location = new System.Drawing.Point(33, 137);
            this.btnKtpVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnKtpVer.Name = "btnKtpVer";
            this.btnKtpVer.Size = new System.Drawing.Size(343, 92);
            this.btnKtpVer.TabIndex = 29;
            this.btnKtpVer.Text = "Kitap Teslim Ver";
            this.btnKtpVer.UseVisualStyleBackColor = true;
            this.btnKtpVer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnKtpAl
            // 
            this.btnKtpAl.Location = new System.Drawing.Point(399, 137);
            this.btnKtpAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnKtpAl.Name = "btnKtpAl";
            this.btnKtpAl.Size = new System.Drawing.Size(343, 92);
            this.btnKtpAl.TabIndex = 30;
            this.btnKtpAl.Text = "Kitap Teslim Al";
            this.btnKtpAl.UseVisualStyleBackColor = true;
            this.btnKtpAl.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.btnKtpAl);
            this.Controls.Add(this.btnKtpVer);
            this.Controls.Add(this.btnUyeYonetim);
            this.Controls.Add(this.btnKtphnYonetim);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaEkran";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.frmAnaEkran_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLKullanıcı;
        private System.Windows.Forms.ToolStripStatusLabel stLabelKullaniciAdi;
        private System.Windows.Forms.Button btnKtphnYonetim;
        private System.Windows.Forms.Button btnUyeYonetim;
        private System.Windows.Forms.Button btnKtpVer;
        private System.Windows.Forms.Button btnKtpAl;
    }
}