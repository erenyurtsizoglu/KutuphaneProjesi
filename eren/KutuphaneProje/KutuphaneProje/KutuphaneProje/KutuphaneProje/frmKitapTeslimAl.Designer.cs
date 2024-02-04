namespace KutuphaneProje
{
    partial class frmKitapTeslimAl
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
            this.cbUye = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvKitapListesi = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUye);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(549, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgisi";
            // 
            // cbUye
            // 
            this.cbUye.FormattingEnabled = true;
            this.cbUye.Location = new System.Drawing.Point(8, 23);
            this.cbUye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbUye.Name = "cbUye";
            this.cbUye.Size = new System.Drawing.Size(524, 24);
            this.cbUye.TabIndex = 0;
            this.cbUye.SelectedIndexChanged += new System.EventHandler(this.cbUye_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvKitapListesi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(549, 484);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Listesi";
            // 
            // lvKitapListesi
            // 
            this.lvKitapListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader2,
            this.columnHeader3});
            this.lvKitapListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKitapListesi.FullRowSelect = true;
            this.lvKitapListesi.GridLines = true;
            this.lvKitapListesi.HideSelection = false;
            this.lvKitapListesi.Location = new System.Drawing.Point(4, 19);
            this.lvKitapListesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvKitapListesi.Name = "lvKitapListesi";
            this.lvKitapListesi.Size = new System.Drawing.Size(541, 461);
            this.lvKitapListesi.TabIndex = 0;
            this.lvKitapListesi.UseCompatibleStateImageBehavior = false;
            this.lvKitapListesi.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kitap Adı";
            this.columnHeader2.Width = 218;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Veriliş Tarihi";
            this.columnHeader3.Width = 179;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTeslimAl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 483);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(549, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Location = new System.Drawing.Point(199, 30);
            this.btnTeslimAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(335, 28);
            this.btnTeslimAl.TabIndex = 0;
            this.btnTeslimAl.Text = "Kitabı Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // frmKitapTeslimAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitapTeslimAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Teslim Alma";
            this.Load += new System.EventHandler(this.frmKitapTeslimAl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbUye;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvKitapListesi;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTeslimAl;
    }
}