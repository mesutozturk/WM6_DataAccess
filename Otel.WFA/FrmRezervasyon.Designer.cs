namespace Otel.WFA
{
    partial class FrmRezervasyon
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
            this.lstOdalar = new System.Windows.Forms.ListBox();
            this.btnRezervasyonKayit = new System.Windows.Forms.Button();
            this.nKisi = new System.Windows.Forms.NumericUpDown();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nKisi)).BeginInit();
            this.SuspendLayout();
            // 
            // lstOdalar
            // 
            this.lstOdalar.FormattingEnabled = true;
            this.lstOdalar.Location = new System.Drawing.Point(13, 13);
            this.lstOdalar.Name = "lstOdalar";
            this.lstOdalar.Size = new System.Drawing.Size(147, 355);
            this.lstOdalar.TabIndex = 0;
            // 
            // btnRezervasyonKayit
            // 
            this.btnRezervasyonKayit.Location = new System.Drawing.Point(167, 91);
            this.btnRezervasyonKayit.Name = "btnRezervasyonKayit";
            this.btnRezervasyonKayit.Size = new System.Drawing.Size(156, 52);
            this.btnRezervasyonKayit.TabIndex = 1;
            this.btnRezervasyonKayit.Text = "Rezervasyon Kayıt";
            this.btnRezervasyonKayit.UseVisualStyleBackColor = true;
            this.btnRezervasyonKayit.Click += new System.EventHandler(this.btnRezervasyonKayit_Click);
            // 
            // nKisi
            // 
            this.nKisi.Location = new System.Drawing.Point(167, 13);
            this.nKisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nKisi.Name = "nKisi";
            this.nKisi.Size = new System.Drawing.Size(156, 20);
            this.nKisi.TabIndex = 2;
            // 
            // dtpGiris
            // 
            this.dtpGiris.Location = new System.Drawing.Point(167, 39);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(157, 20);
            this.dtpGiris.TabIndex = 3;
            // 
            // dtpCikis
            // 
            this.dtpCikis.Location = new System.Drawing.Point(166, 65);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(158, 20);
            this.dtpCikis.TabIndex = 3;
            // 
            // FrmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpCikis);
            this.Controls.Add(this.dtpGiris);
            this.Controls.Add(this.nKisi);
            this.Controls.Add(this.btnRezervasyonKayit);
            this.Controls.Add(this.lstOdalar);
            this.Name = "FrmRezervasyon";
            this.Text = "FrmRezervasyon";
            this.Load += new System.EventHandler(this.FrmRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nKisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOdalar;
        private System.Windows.Forms.Button btnRezervasyonKayit;
        private System.Windows.Forms.NumericUpDown nKisi;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.DateTimePicker dtpCikis;
    }
}