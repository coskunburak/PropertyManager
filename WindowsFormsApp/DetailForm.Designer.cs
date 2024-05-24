namespace WindowsFormsApp
{
    partial class DetailForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEmlakNumarasi;
        private System.Windows.Forms.TextBox txtEmlakNumarasi;
        private System.Windows.Forms.Label lblOdaSayisi;
        private System.Windows.Forms.TextBox txtOdaSayisi;
        private System.Windows.Forms.Label lblKatNumarasi;
        private System.Windows.Forms.TextBox txtKatNumarasi;
        private System.Windows.Forms.Label lblSemti;
        private System.Windows.Forms.TextBox txtSemti;
        private System.Windows.Forms.Label lblAlani;
        private System.Windows.Forms.TextBox txtAlani;
        private System.Windows.Forms.Label lblYapimTarihi;
        private System.Windows.Forms.DateTimePicker dtpYapimTarihi;
        private System.Windows.Forms.Label lblTuru;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnOpenImages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEmlakNumarasi = new System.Windows.Forms.Label();
            this.txtEmlakNumarasi = new System.Windows.Forms.TextBox();
            this.lblOdaSayisi = new System.Windows.Forms.Label();
            this.txtOdaSayisi = new System.Windows.Forms.TextBox();
            this.lblKatNumarasi = new System.Windows.Forms.Label();
            this.txtKatNumarasi = new System.Windows.Forms.TextBox();
            this.lblSemti = new System.Windows.Forms.Label();
            this.txtSemti = new System.Windows.Forms.TextBox();
            this.lblAlani = new System.Windows.Forms.Label();
            this.txtAlani = new System.Windows.Forms.TextBox();
            this.lblYapimTarihi = new System.Windows.Forms.Label();
            this.dtpYapimTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTuru = new System.Windows.Forms.Label();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnOpenImages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmlakNumarasi
            // 
            this.lblEmlakNumarasi.AutoSize = true;
            this.lblEmlakNumarasi.Location = new System.Drawing.Point(20, 23);
            this.lblEmlakNumarasi.Name = "lblEmlakNumarasi";
            this.lblEmlakNumarasi.Size = new System.Drawing.Size(83, 13);
            this.lblEmlakNumarasi.TabIndex = 0;
            this.lblEmlakNumarasi.Text = "Emlak Numarası";
            // 
            // txtEmlakNumarasi
            // 
            this.txtEmlakNumarasi.Location = new System.Drawing.Point(120, 20);
            this.txtEmlakNumarasi.Name = "txtEmlakNumarasi";
            this.txtEmlakNumarasi.ReadOnly = true;
            this.txtEmlakNumarasi.Size = new System.Drawing.Size(200, 20);
            this.txtEmlakNumarasi.TabIndex = 1;
            // 
            // lblOdaSayisi
            // 
            this.lblOdaSayisi.AutoSize = true;
            this.lblOdaSayisi.Location = new System.Drawing.Point(20, 53);
            this.lblOdaSayisi.Name = "lblOdaSayisi";
            this.lblOdaSayisi.Size = new System.Drawing.Size(58, 13);
            this.lblOdaSayisi.TabIndex = 2;
            this.lblOdaSayisi.Text = "Oda Sayısı";
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(120, 50);
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(200, 20);
            this.txtOdaSayisi.TabIndex = 3;
            // 
            // lblKatNumarasi
            // 
            this.lblKatNumarasi.AutoSize = true;
            this.lblKatNumarasi.Location = new System.Drawing.Point(20, 83);
            this.lblKatNumarasi.Name = "lblKatNumarasi";
            this.lblKatNumarasi.Size = new System.Drawing.Size(69, 13);
            this.lblKatNumarasi.TabIndex = 4;
            this.lblKatNumarasi.Text = "Kat Numarası";
            // 
            // txtKatNumarasi
            // 
            this.txtKatNumarasi.Location = new System.Drawing.Point(120, 80);
            this.txtKatNumarasi.Name = "txtKatNumarasi";
            this.txtKatNumarasi.Size = new System.Drawing.Size(200, 20);
            this.txtKatNumarasi.TabIndex = 5;
            // 
            // lblSemti
            // 
            this.lblSemti.AutoSize = true;
            this.lblSemti.Location = new System.Drawing.Point(20, 113);
            this.lblSemti.Name = "lblSemti";
            this.lblSemti.Size = new System.Drawing.Size(32, 13);
            this.lblSemti.TabIndex = 6;
            // 
            // txtSemti
            // 
            this.txtSemti.Location = new System.Drawing.Point(120, 110);
            this.txtSemti.Name = "txtSemti";
            this.txtSemti.Size = new System.Drawing.Size(200, 20);
            this.txtSemti.TabIndex = 7;
            // 
            // lblAlani
            // 
            this.lblAlani.AutoSize = true;
            this.lblAlani.Location = new System.Drawing.Point(20, 143);
            this.lblAlani.Name = "lblAlani";
            this.lblAlani.Size = new System.Drawing.Size(30, 13);
            this.lblAlani.TabIndex = 8;
            this.lblAlani.Text = "Alan";
            // 
            // txtAlani
            // 
            this.txtAlani.Location = new System.Drawing.Point(120, 140);
            this.txtAlani.Name = "txtAlani";
            this.txtAlani.Size = new System.Drawing.Size(200, 20);
            this.txtAlani.TabIndex = 9;
            // 
            // lblYapimTarihi
            // 
            this.lblYapimTarihi.AutoSize = true;
            this.lblYapimTarihi.Location = new System.Drawing.Point(20, 173);
            this.lblYapimTarihi.Name = "lblYapimTarihi";
            this.lblYapimTarihi.Size = new System.Drawing.Size(66, 13);
            this.lblYapimTarihi.TabIndex = 10;
            // 
            // dtpYapimTarihi
            // 
            this.dtpYapimTarihi.Location = new System.Drawing.Point(120, 170);
            this.dtpYapimTarihi.Name = "dtpYapimTarihi";
            this.dtpYapimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpYapimTarihi.TabIndex = 11;
            // 
            // lblTuru
            // 
            this.lblTuru.AutoSize = true;
            this.lblTuru.Location = new System.Drawing.Point(20, 203);
            this.lblTuru.Name = "lblTuru";
            this.lblTuru.Size = new System.Drawing.Size(28, 13);
            this.lblTuru.TabIndex = 12;
            this.lblTuru.Text = "Türü";
            // 
            // cmbTuru
            // 
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Location = new System.Drawing.Point(120, 200);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(200, 21);
            this.cmbTuru.TabIndex = 13;
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Location = new System.Drawing.Point(120, 230);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(47, 17);
            this.chkAktif.TabIndex = 14;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(280, 260);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(75, 23);
            this.btnArchive.TabIndex = 17;
            this.btnArchive.Text = "Arşivle";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnOpenImages
            // 
            this.btnOpenImages.Location = new System.Drawing.Point(360, 260);
            this.btnOpenImages.Name = "btnOpenImages";
            this.btnOpenImages.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImages.TabIndex = 18;
            this.btnOpenImages.Text = "Görselleri Aç";
            this.btnOpenImages.UseVisualStyleBackColor = true;
            this.btnOpenImages.Click += new System.EventHandler(this.btnOpenImages_Click);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnOpenImages);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkAktif);
            this.Controls.Add(this.cmbTuru);
            this.Controls.Add(this.lblTuru);
            this.Controls.Add(this.dtpYapimTarihi);
            this.Controls.Add(this.lblYapimTarihi);
            this.Controls.Add(this.txtAlani);
            this.Controls.Add(this.lblAlani);
            this.Controls.Add(this.txtSemti);
            this.Controls.Add(this.lblSemti);
            this.Controls.Add(this.txtKatNumarasi);
            this.Controls.Add(this.lblKatNumarasi);
            this.Controls.Add(this.txtOdaSayisi);
            this.Controls.Add(this.lblOdaSayisi);
            this.Controls.Add(this.txtEmlakNumarasi);
            this.Controls.Add(this.lblEmlakNumarasi);
            this.Name = "DetailForm";
            this.Text = "Ev Detayları";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
