namespace Otel.WFA
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node5", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("asdasd", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node12");
            this.tvCategory = new System.Windows.Forms.TreeView();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.btnKategoriKaydet = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.cbSatistaMi = new System.Windows.Forms.CheckBox();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // tvCategory
            // 
            this.tvCategory.FullRowSelect = true;
            this.tvCategory.Location = new System.Drawing.Point(180, 13);
            this.tvCategory.Name = "tvCategory";
            treeNode1.Name = "Node8";
            treeNode1.Text = "Node8";
            treeNode2.Name = "Node9";
            treeNode2.Text = "Node9";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Node5";
            treeNode4.Name = "Node10";
            treeNode4.Text = "Node10";
            treeNode5.Name = "Node11";
            treeNode5.Text = "Node11";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Node1";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Node2";
            treeNode10.Name = "Node3";
            treeNode10.Text = "Node3";
            treeNode11.Name = "Node0";
            treeNode11.Text = "asdasd";
            treeNode12.Name = "Node4";
            treeNode12.Text = "Node4";
            treeNode13.Name = "Node12";
            treeNode13.Text = "Node12";
            this.tvCategory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            this.tvCategory.Size = new System.Drawing.Size(252, 450);
            this.tvCategory.TabIndex = 0;
            this.tvCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategory_AfterSelect);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(12, 12);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(162, 21);
            this.cmbKategori.TabIndex = 1;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(12, 40);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(162, 20);
            this.txtKategoriAdi.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(12, 67);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(162, 111);
            this.txtAciklama.TabIndex = 3;
            this.txtAciklama.Text = "";
            // 
            // btnKategoriKaydet
            // 
            this.btnKategoriKaydet.Location = new System.Drawing.Point(12, 185);
            this.btnKategoriKaydet.Name = "btnKategoriKaydet";
            this.btnKategoriKaydet.Size = new System.Drawing.Size(162, 39);
            this.btnKategoriKaydet.TabIndex = 4;
            this.btnKategoriKaydet.Text = "Kaydet";
            this.btnKategoriKaydet.UseVisualStyleBackColor = true;
            this.btnKategoriKaydet.Click += new System.EventHandler(this.btnKategoriKaydet_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(438, 13);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(167, 134);
            this.lstUrunler.TabIndex = 5;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(439, 154);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(166, 20);
            this.txtUrunAdi.TabIndex = 6;
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Location = new System.Drawing.Point(439, 181);
            this.nFiyat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(166, 20);
            this.nFiyat.TabIndex = 7;
            // 
            // cbSatistaMi
            // 
            this.cbSatistaMi.AutoSize = true;
            this.cbSatistaMi.Location = new System.Drawing.Point(438, 207);
            this.cbSatistaMi.Name = "cbSatistaMi";
            this.cbSatistaMi.Size = new System.Drawing.Size(78, 17);
            this.cbSatistaMi.TabIndex = 8;
            this.cbSatistaMi.Text = "Satışta Mı?";
            this.cbSatistaMi.UseVisualStyleBackColor = true;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(439, 231);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(166, 39);
            this.btnUrunKaydet.TabIndex = 9;
            this.btnUrunKaydet.Text = "Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 475);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.cbSatistaMi);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.btnKategoriKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.tvCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvCategory;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Button btnKategoriKaydet;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.CheckBox cbSatistaMi;
        private System.Windows.Forms.Button btnUrunKaydet;
    }
}

