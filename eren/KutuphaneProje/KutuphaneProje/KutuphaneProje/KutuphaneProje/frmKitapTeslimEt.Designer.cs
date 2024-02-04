namespace KutuphaneProje
{
    partial class frmKitapTeslimEt
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
            this.cbKitap = new System.Windows.Forms.ComboBox();
            this.cbUye = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKitap
            // 
            this.cbKitap.FormattingEnabled = true;
            this.cbKitap.Location = new System.Drawing.Point(16, 55);
            this.cbKitap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKitap.Name = "cbKitap";
            this.cbKitap.Size = new System.Drawing.Size(420, 25);
            this.cbKitap.TabIndex = 18;
            // 
            // cbUye
            // 
            this.cbUye.FormattingEnabled = true;
            this.cbUye.Location = new System.Drawing.Point(16, 105);
            this.cbUye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUye.Name = "cbUye";
            this.cbUye.Size = new System.Drawing.Size(420, 25);
            this.cbUye.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Üye Bilgisi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(264, 151);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(173, 28);
            this.btnKaydet.TabIndex = 36;
            this.btnKaydet.Text = "Kitabı Teslim Et";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(16, 154);
            this.dtTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(224, 24);
            this.dtTarih.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Veriliş Tarihi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtTarih);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbUye);
            this.groupBox1.Controls.Add(this.cbKitap);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(469, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Teslim bilgileri";
            // 
            // frmKitapTeslimEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 225);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitapTeslimEt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Teslim verme";
            this.Load += new System.EventHandler(this.frmKitapTeslim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKitap;
        private System.Windows.Forms.ComboBox cbUye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}