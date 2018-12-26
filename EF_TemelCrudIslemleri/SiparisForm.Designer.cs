namespace EF_TemelCrudIslemleri
{
    partial class SiparisForm
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.cmsSepet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pSepetGuncelle = new System.Windows.Forms.Panel();
            this.nAdet = new System.Windows.Forms.NumericUpDown();
            this.nOran = new System.Windows.Forms.NumericUpDown();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbNakliye = new System.Windows.Forms.ComboBox();
            this.cmbCalisan = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.nNakliyeUcreti = new System.Windows.Forms.NumericUpDown();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.cmsSepet.SuspendLayout();
            this.pSepetGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNakliyeUcreti)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 44);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(182, 316);
            this.lstUrunler.TabIndex = 5;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(182, 20);
            this.txtAra.TabIndex = 6;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(12, 367);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(171, 37);
            this.btnSepeteEkle.TabIndex = 7;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(201, 44);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(236, 316);
            this.lstSepet.TabIndex = 8;
            // 
            // cmsSepet
            // 
            this.cmsSepet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkartToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.cmsSepet.Name = "cmsSepet";
            this.cmsSepet.Size = new System.Drawing.Size(121, 48);
            // 
            // çıkartToolStripMenuItem
            // 
            this.çıkartToolStripMenuItem.Name = "çıkartToolStripMenuItem";
            this.çıkartToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.çıkartToolStripMenuItem.Text = "Çıkart";
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // pSepetGuncelle
            // 
            this.pSepetGuncelle.Controls.Add(this.btnGuncelle);
            this.pSepetGuncelle.Controls.Add(this.nOran);
            this.pSepetGuncelle.Controls.Add(this.nAdet);
            this.pSepetGuncelle.Location = new System.Drawing.Point(444, 44);
            this.pSepetGuncelle.Name = "pSepetGuncelle";
            this.pSepetGuncelle.Size = new System.Drawing.Size(120, 112);
            this.pSepetGuncelle.TabIndex = 10;
            this.pSepetGuncelle.Visible = false;
            // 
            // nAdet
            // 
            this.nAdet.Location = new System.Drawing.Point(18, 17);
            this.nAdet.Name = "nAdet";
            this.nAdet.Size = new System.Drawing.Size(81, 20);
            this.nAdet.TabIndex = 0;
            // 
            // nOran
            // 
            this.nOran.DecimalPlaces = 3;
            this.nOran.Location = new System.Drawing.Point(18, 44);
            this.nOran.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nOran.Name = "nOran";
            this.nOran.Size = new System.Drawing.Size(81, 20);
            this.nOran.TabIndex = 1;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(18, 71);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(444, 162);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(171, 21);
            this.cmbMusteri.TabIndex = 11;
            // 
            // cmbNakliye
            // 
            this.cmbNakliye.FormattingEnabled = true;
            this.cmbNakliye.Location = new System.Drawing.Point(444, 189);
            this.cmbNakliye.Name = "cmbNakliye";
            this.cmbNakliye.Size = new System.Drawing.Size(171, 21);
            this.cmbNakliye.TabIndex = 11;
            // 
            // cmbCalisan
            // 
            this.cmbCalisan.FormattingEnabled = true;
            this.cmbCalisan.Location = new System.Drawing.Point(444, 216);
            this.cmbCalisan.Name = "cmbCalisan";
            this.cmbCalisan.Size = new System.Drawing.Size(171, 21);
            this.cmbCalisan.TabIndex = 11;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(444, 244);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(171, 20);
            this.dtpTarih.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // nNakliyeUcreti
            // 
            this.nNakliyeUcreti.Location = new System.Drawing.Point(444, 270);
            this.nNakliyeUcreti.Name = "nNakliyeUcreti";
            this.nNakliyeUcreti.Size = new System.Drawing.Size(171, 20);
            this.nNakliyeUcreti.TabIndex = 1;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(444, 297);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(171, 20);
            this.txtAdres.TabIndex = 14;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(443, 323);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(171, 37);
            this.btnSiparisVer.TabIndex = 15;
            this.btnSiparisVer.Text = "Sipariş Oluştur";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 414);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nNakliyeUcreti);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cmbCalisan);
            this.Controls.Add(this.cmbNakliye);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.pSepetGuncelle);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstUrunler);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.cmsSepet.ResumeLayout(false);
            this.pSepetGuncelle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNakliyeUcreti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.ContextMenuStrip cmsSepet;
        private System.Windows.Forms.ToolStripMenuItem çıkartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Panel pSepetGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.NumericUpDown nOran;
        private System.Windows.Forms.NumericUpDown nAdet;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbNakliye;
        private System.Windows.Forms.ComboBox cmbCalisan;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nNakliyeUcreti;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnSiparisVer;
    }
}