namespace Uretim
{
    partial class FrmStokKayitlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokKayitlari));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sbtnStokListesi = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnGrupKodListesi = new DevExpress.XtraEditors.SimpleButton();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKDVOrani = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKDVOrani.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(141, 32);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(154, 22);
            this.txtStokKodu.TabIndex = 2;
            this.txtStokKodu.Leave += new System.EventHandler(this.txtStokKodu_Leave);
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(141, 76);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(204, 22);
            this.txtStokAdi.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(40, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı";
            // 
            // txtGrupKodu
            // 
            this.txtGrupKodu.Location = new System.Drawing.Point(141, 120);
            this.txtGrupKodu.Name = "txtGrupKodu";
            this.txtGrupKodu.Size = new System.Drawing.Size(58, 22);
            this.txtGrupKodu.TabIndex = 5;
            this.txtGrupKodu.Leave += new System.EventHandler(this.txtGrupKodu_Leave);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(22, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 22);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Grup Kodu";
            // 
            // sbtnStokListesi
            // 
            this.sbtnStokListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnStokListesi.ImageOptions.Image")));
            this.sbtnStokListesi.Location = new System.Drawing.Point(301, 27);
            this.sbtnStokListesi.Name = "sbtnStokListesi";
            this.sbtnStokListesi.Size = new System.Drawing.Size(44, 32);
            this.sbtnStokListesi.TabIndex = 3;
            this.sbtnStokListesi.Click += new System.EventHandler(this.sbtnStokListesi_Click);
            // 
            // sbtnGrupKodListesi
            // 
            this.sbtnGrupKodListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnGrupKodListesi.ImageOptions.Image")));
            this.sbtnGrupKodListesi.Location = new System.Drawing.Point(205, 115);
            this.sbtnGrupKodListesi.Name = "sbtnGrupKodListesi";
            this.sbtnGrupKodListesi.Size = new System.Drawing.Size(44, 32);
            this.sbtnGrupKodListesi.TabIndex = 6;
            this.sbtnGrupKodListesi.Click += new System.EventHandler(this.sbtnGrupKodListesi_Click);
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Enabled = false;
            this.txtGrupAdi.Location = new System.Drawing.Point(255, 121);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Size = new System.Drawing.Size(90, 22);
            this.txtGrupAdi.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtGrupAdi);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.sbtnGrupKodListesi);
            this.groupBox1.Controls.Add(this.txtStokKodu);
            this.groupBox1.Controls.Add(this.sbtnStokListesi);
            this.groupBox1.Controls.Add(this.txtStokAdi);
            this.groupBox1.Controls.Add(this.txtGrupKodu);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(20, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 22);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(121, 30);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(79, 22);
            this.txtFiyat.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(91, 22);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "KDV Oranı";
            // 
            // txtKDVOrani
            // 
            this.txtKDVOrani.Location = new System.Drawing.Point(121, 80);
            this.txtKDVOrani.Name = "txtKDVOrani";
            this.txtKDVOrani.Size = new System.Drawing.Size(79, 22);
            this.txtKDVOrani.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.txtKDVOrani);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 141);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Bilgisi";
            // 
            // sbtnKaydet
            // 
            this.sbtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnKaydet.ImageOptions.Image")));
            this.sbtnKaydet.Location = new System.Drawing.Point(248, 235);
            this.sbtnKaydet.Name = "sbtnKaydet";
            this.sbtnKaydet.Size = new System.Drawing.Size(109, 37);
            this.sbtnKaydet.TabIndex = 11;
            this.sbtnKaydet.Text = "Kaydet";
            // 
            // sbtnSil
            // 
            this.sbtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSil.ImageOptions.Image")));
            this.sbtnSil.Location = new System.Drawing.Point(248, 285);
            this.sbtnSil.Name = "sbtnSil";
            this.sbtnSil.Size = new System.Drawing.Size(109, 37);
            this.sbtnSil.TabIndex = 12;
            this.sbtnSil.Text = "Sil";
            // 
            // FrmStokKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 365);
            this.Controls.Add(this.sbtnSil);
            this.Controls.Add(this.sbtnKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStokKayitlari";
            this.Text = "Stok Kartı Kayıtları";
            this.Activated += new System.EventHandler(this.FrmStokKayitlari_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStokKayitlari_FormClosed);
            this.Load += new System.EventHandler(this.FrmStokKayitlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKDVOrani.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGrupKodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbtnStokListesi;
        private DevExpress.XtraEditors.SimpleButton sbtnGrupKodListesi;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtKDVOrani;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton sbtnKaydet;
        private DevExpress.XtraEditors.SimpleButton sbtnSil;
    }
}