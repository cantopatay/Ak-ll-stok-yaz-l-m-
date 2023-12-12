namespace Uretim
{
    partial class FrmMusteriKayitlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriKayitlari));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusteriKodu = new DevExpress.XtraEditors.TextEdit();
            this.sbtnStokListesi = new DevExpress.XtraEditors.SimpleButton();
            this.txtMusteriAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEPosta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnSatici = new System.Windows.Forms.RadioButton();
            this.rbtnAlici = new System.Windows.Forms.RadioButton();
            this.sbtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEPosta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtMusteriKodu);
            this.groupBox1.Controls.Add(this.sbtnStokListesi);
            this.groupBox1.Controls.Add(this.txtMusteriAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genel Bilgiler";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Müşteri Adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Müşteri Kodu";
            // 
            // txtMusteriKodu
            // 
            this.txtMusteriKodu.Location = new System.Drawing.Point(141, 32);
            this.txtMusteriKodu.Name = "txtMusteriKodu";
            this.txtMusteriKodu.Size = new System.Drawing.Size(255, 22);
            this.txtMusteriKodu.TabIndex = 2;
            this.txtMusteriKodu.Leave += new System.EventHandler(this.txtMusteriKodu_Leave);
            // 
            // sbtnStokListesi
            // 
            this.sbtnStokListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnStokListesi.ImageOptions.Image")));
            this.sbtnStokListesi.Location = new System.Drawing.Point(402, 29);
            this.sbtnStokListesi.Name = "sbtnStokListesi";
            this.sbtnStokListesi.Size = new System.Drawing.Size(44, 32);
            this.sbtnStokListesi.TabIndex = 3;
            this.sbtnStokListesi.Click += new System.EventHandler(this.sbtnStokListesi_Click);
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(141, 76);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(305, 22);
            this.txtMusteriAdi.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxIlce);
            this.groupBox2.Controls.Add(this.cbxIl);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 115);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lokasyon Bilgileri";
            // 
            // cbxIlce
            // 
            this.cbxIlce.Location = new System.Drawing.Point(284, 76);
            this.cbxIlce.Name = "cbxIlce";
            this.cbxIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxIlce.Size = new System.Drawing.Size(125, 22);
            this.cbxIlce.TabIndex = 7;
            // 
            // cbxIl
            // 
            this.cbxIl.Location = new System.Drawing.Point(34, 75);
            this.cbxIl.Name = "cbxIl";
            this.cbxIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxIl.Size = new System.Drawing.Size(125, 22);
            this.cbxIl.TabIndex = 6;
            this.cbxIl.Leave += new System.EventHandler(this.cbxIl_Leave);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(237, 75);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 22);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "İlçe";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(12, 22);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "İl";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 22);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(89, 36);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(269, 22);
            this.txtAdres.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(402, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(44, 32);
            this.simpleButton1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEPosta);
            this.groupBox3.Controls.Add(this.labelControl7);
            this.groupBox3.Controls.Add(this.labelControl8);
            this.groupBox3.Controls.Add(this.txtTelefon);
            this.groupBox3.Location = new System.Drawing.Point(12, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 115);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İletişim Bilgileri";
            // 
            // txtEPosta
            // 
            this.txtEPosta.Location = new System.Drawing.Point(104, 76);
            this.txtEPosta.Name = "txtEPosta";
            this.txtEPosta.Size = new System.Drawing.Size(175, 22);
            this.txtEPosta.TabIndex = 4;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(11, 75);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 22);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "E Posta";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(6, 32);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(61, 22);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(104, 33);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Mask.EditMask = "(\\d?\\d?\\d?) \\d\\d\\d \\d\\d \\d\\d";
            this.txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtTelefon.Size = new System.Drawing.Size(175, 22);
            this.txtTelefon.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnSatici);
            this.groupBox4.Controls.Add(this.rbtnAlici);
            this.groupBox4.Location = new System.Drawing.Point(341, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(145, 115);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Müşteri Tipi";
            // 
            // rbtnSatici
            // 
            this.rbtnSatici.AutoSize = true;
            this.rbtnSatici.Location = new System.Drawing.Point(17, 63);
            this.rbtnSatici.Name = "rbtnSatici";
            this.rbtnSatici.Size = new System.Drawing.Size(77, 26);
            this.rbtnSatici.TabIndex = 1;
            this.rbtnSatici.TabStop = true;
            this.rbtnSatici.Text = "Satıcı";
            this.rbtnSatici.UseVisualStyleBackColor = true;
            // 
            // rbtnAlici
            // 
            this.rbtnAlici.AutoSize = true;
            this.rbtnAlici.Location = new System.Drawing.Point(17, 30);
            this.rbtnAlici.Name = "rbtnAlici";
            this.rbtnAlici.Size = new System.Drawing.Size(72, 26);
            this.rbtnAlici.TabIndex = 0;
            this.rbtnAlici.TabStop = true;
            this.rbtnAlici.Text = "Alıcı";
            this.rbtnAlici.UseVisualStyleBackColor = true;
            // 
            // sbtnKaydet
            // 
            this.sbtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnKaydet.ImageOptions.Image")));
            this.sbtnKaydet.Location = new System.Drawing.Point(101, 395);
            this.sbtnKaydet.Name = "sbtnKaydet";
            this.sbtnKaydet.Size = new System.Drawing.Size(96, 42);
            this.sbtnKaydet.TabIndex = 6;
            this.sbtnKaydet.Text = "Kaydet";
            this.sbtnKaydet.Click += new System.EventHandler(this.sbtnKaydet_Click);
            // 
            // sbtnSil
            // 
            this.sbtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnSil.ImageOptions.Image")));
            this.sbtnSil.Location = new System.Drawing.Point(225, 395);
            this.sbtnSil.Name = "sbtnSil";
            this.sbtnSil.Size = new System.Drawing.Size(107, 42);
            this.sbtnSil.TabIndex = 8;
            this.sbtnSil.Text = "Sil";
            this.sbtnSil.Click += new System.EventHandler(this.sbtnSil_Click);
            // 
            // FrmMusteriKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 449);
            this.Controls.Add(this.sbtnSil);
            this.Controls.Add(this.sbtnKaydet);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMusteriKayitlari";
            this.Text = "Müşteri Kayıtları";
            this.Activated += new System.EventHandler(this.FrmMusteriKayitlari_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMusteriKayitlari_FormClosed);
            this.Load += new System.EventHandler(this.FrmMusteriKayitlari_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteriAdi.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEPosta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMusteriKodu;
        private DevExpress.XtraEditors.SimpleButton sbtnStokListesi;
        private DevExpress.XtraEditors.TextEdit txtMusteriAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit txtEPosta;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnSatici;
        private System.Windows.Forms.RadioButton rbtnAlici;
        private DevExpress.XtraEditors.ComboBoxEdit cbxIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cbxIl;
        private DevExpress.XtraEditors.SimpleButton sbtnKaydet;
        private DevExpress.XtraEditors.SimpleButton sbtnSil;
    }
}