namespace KutuphaneProje
{
    partial class frmKitap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtBasimYili = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmStokAdet = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYazar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKitapTur = new System.Windows.Forms.ComboBox();
            this.cbKitapKategori = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmStokAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSayfaSayisi);
            this.groupBox1.Controls.Add(this.txtBasimYili);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nmStokAdet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDil);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtYayinEvi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbYazar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbKitapTur);
            this.groupBox1.Controls.Add(this.cbKitapKategori);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(469, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Tanım Bilgileri";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(303, 347);
            this.txtSayfaSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(133, 24);
            this.txtSayfaSayisi.TabIndex = 38;
            // 
            // txtBasimYili
            // 
            this.txtBasimYili.Location = new System.Drawing.Point(160, 347);
            this.txtBasimYili.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBasimYili.Name = "txtBasimYili";
            this.txtBasimYili.Size = new System.Drawing.Size(133, 24);
            this.txtBasimYili.TabIndex = 37;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(20, 402);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(417, 28);
            this.btnKaydet.TabIndex = 36;
            this.btnKaydet.Text = "Bilgileri Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 327);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Sayfa Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 327);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Basım Yılı";
            // 
            // nmStokAdet
            // 
            this.nmStokAdet.Location = new System.Drawing.Point(16, 347);
            this.nmStokAdet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmStokAdet.Name = "nmStokAdet";
            this.nmStokAdet.Size = new System.Drawing.Size(135, 24);
            this.nmStokAdet.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 327);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Stok Adedi";
            // 
            // txtDil
            // 
            this.txtDil.Location = new System.Drawing.Point(16, 299);
            this.txtDil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDil.Name = "txtDil";
            this.txtDil.Size = new System.Drawing.Size(420, 24);
            this.txtDil.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Basım Dili";
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Location = new System.Drawing.Point(16, 251);
            this.txtYayinEvi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(420, 24);
            this.txtYayinEvi.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Yayın Evi";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(16, 203);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(420, 24);
            this.txtKitapAdi.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kitap Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Yazar Bilgisi";
            // 
            // cbYazar
            // 
            this.cbYazar.FormattingEnabled = true;
            this.cbYazar.Location = new System.Drawing.Point(16, 154);
            this.cbYazar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbYazar.Name = "cbYazar";
            this.cbYazar.Size = new System.Drawing.Size(420, 25);
            this.cbYazar.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kitap Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kitap Kategorisi";
            // 
            // cbKitapTur
            // 
            this.cbKitapTur.FormattingEnabled = true;
            this.cbKitapTur.Location = new System.Drawing.Point(16, 105);
            this.cbKitapTur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKitapTur.Name = "cbKitapTur";
            this.cbKitapTur.Size = new System.Drawing.Size(420, 25);
            this.cbKitapTur.TabIndex = 19;
            // 
            // cbKitapKategori
            // 
            this.cbKitapKategori.FormattingEnabled = true;
            this.cbKitapKategori.Location = new System.Drawing.Point(16, 55);
            this.cbKitapKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKitapKategori.Name = "cbKitapKategori";
            this.cbKitapKategori.Size = new System.Drawing.Size(420, 25);
            this.cbKitapKategori.TabIndex = 18;
            // 
            // frmKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 476);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Yönetimi";
            this.Load += new System.EventHandler(this.frmKitap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmStokAdet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmStokAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKitapTur;
        private System.Windows.Forms.ComboBox cbKitapKategori;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtBasimYili;
    }
}