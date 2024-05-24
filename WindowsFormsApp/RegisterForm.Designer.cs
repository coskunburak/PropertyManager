namespace WindowsFormsApp
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
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
        private System.Windows.Forms.RadioButton rbtnKiralik;
        private System.Windows.Forms.RadioButton rbtnSatilik;
        private System.Windows.Forms.Label lblDepozitosu;
        private System.Windows.Forms.TextBox txtDepozitosu;
        private System.Windows.Forms.Label lblKirasi;
        private System.Windows.Forms.TextBox txtKirasi;
        private System.Windows.Forms.Label lblFiyati;
        private System.Windows.Forms.TextBox txtFiyati;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbKiralikSatilik;

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
            this.rbtnKiralik = new System.Windows.Forms.RadioButton();
            this.rbtnSatilik = new System.Windows.Forms.RadioButton();
            this.lblDepozitosu = new System.Windows.Forms.Label();
            this.txtDepozitosu = new System.Windows.Forms.TextBox();
            this.lblKirasi = new System.Windows.Forms.Label();
            this.txtKirasi = new System.Windows.Forms.TextBox();
            this.lblFiyati = new System.Windows.Forms.Label();
            this.txtFiyati = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbKiralikSatilik = new System.Windows.Forms.GroupBox();
            this.gbKiralikSatilik.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOdaSayisi
            // 
            this.lblOdaSayisi.AutoSize = true;
            this.lblOdaSayisi.Location = new System.Drawing.Point(20, 20);
            this.lblOdaSayisi.Name = "lblOdaSayisi";
            this.lblOdaSayisi.Size = new System.Drawing.Size(58, 13);
            this.lblOdaSayisi.TabIndex = 0;
            this.lblOdaSayisi.Text = "Oda Sayısı";
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(120, 20);
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(200, 20);
            this.txtOdaSayisi.TabIndex = 1;
            // 
            // lblKatNumarasi
            // 
            this.lblKatNumarasi.AutoSize = true;
            this.lblKatNumarasi.Location = new System.Drawing.Point(20, 50);
            this.lblKatNumarasi.Name = "lblKatNumarasi";
            this.lblKatNumarasi.Size = new System.Drawing.Size(69, 13);
            this.lblKatNumarasi.TabIndex = 2;
            this.lblKatNumarasi.Text = "Kat Numarası";
            // 
            // txtKatNumarasi
            // 
            this.txtKatNumarasi.Location = new System.Drawing.Point(120, 50);
            this.txtKatNumarasi.Name = "txtKatNumarasi";
            this.txtKatNumarasi.Size = new System.Drawing.Size(200, 20);
            this.txtKatNumarasi.TabIndex = 3;
            // 
            // lblSemti
            // 
            this.lblSemti.AutoSize = true;
            this.lblSemti.Location = new System.Drawing.Point(20, 80);
            this.lblSemti.Name = "lblSemti";
            this.lblSemti.Size = new System.Drawing.Size(32, 13);
            this.lblSemti.TabIndex = 4;
            this.lblSemti.Text = "Semt";
            // 
            // txtSemti
            // 
            this.txtSemti.Location = new System.Drawing.Point(120, 80);
            this.txtSemti.Name = "txtSemti";
            this.txtSemti.Size = new System.Drawing.Size(200, 20);
            this.txtSemti.TabIndex = 5;
            // 
            // lblAlani
            // 
            this.lblAlani.AutoSize = true;
            this.lblAlani.Location = new System.Drawing.Point(20, 110);
            this.lblAlani.Name = "lblAlani";
            this.lblAlani.Size = new System.Drawing.Size(30, 13);
            this.lblAlani.TabIndex = 6;
            this.lblAlani.Text = "Alan";
            // 
            // txtAlani
            // 
            this.txtAlani.Location = new System.Drawing.Point(120, 110);
            this.txtAlani.Name = "txtAlani";
            this.txtAlani.Size = new System.Drawing.Size(200, 20);
            this.txtAlani.TabIndex = 7;
            // 
            // lblYapimTarihi
            // 
            this.lblYapimTarihi.AutoSize = true;
            this.lblYapimTarihi.Location = new System.Drawing.Point(20, 140);
            this.lblYapimTarihi.Name = "lblYapimTarihi";
            this.lblYapimTarihi.Size = new System.Drawing.Size(66, 13);
            this.lblYapimTarihi.TabIndex = 8;
            this.lblYapimTarihi.Text = "Yapım Tarihi";
            // 
            // dtpYapimTarihi
            // 
            this.dtpYapimTarihi.Location = new System.Drawing.Point(120, 140);
            this.dtpYapimTarihi.Name = "dtpYapimTarihi";
            this.dtpYapimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpYapimTarihi.TabIndex = 9;
            // 
            // lblTuru
            // 
            this.lblTuru.AutoSize = true;
            this.lblTuru.Location = new System.Drawing.Point(20, 170);
            this.lblTuru.Name = "lblTuru";
            this.lblTuru.Size = new System.Drawing.Size(28, 13);
            this.lblTuru.TabIndex = 10;
            this.lblTuru.Text = "Türü";
            // 
            // cmbTuru
            // 
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Location = new System.Drawing.Point(120, 170);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(200, 21);
            this.cmbTuru.TabIndex = 11;
            // 
            // gbKiralikSatilik
            // 
            this.gbKiralikSatilik.Controls.Add(this.rbtnKiralik);
            this.gbKiralikSatilik.Controls.Add(this.rbtnSatilik);
            this.gbKiralikSatilik.Location = new System.Drawing.Point(23, 200);
            this.gbKiralikSatilik.Name = "gbKiralikSatilik";
            this.gbKiralikSatilik.Size = new System.Drawing.Size(297, 45);
            this.gbKiralikSatilik.TabIndex = 12;
            this.gbKiralikSatilik.TabStop = false;
            this.gbKiralikSatilik.Text = "Kiralık / Satılık";
            // 
            // rbtnKiralik
            // 
            this.rbtnKiralik.AutoSize = true;
            this.rbtnKiralik.Location = new System.Drawing.Point(10, 19);
            this.rbtnKiralik.Name = "rbtnKiralik";
            this.rbtnKiralik.Size = new System.Drawing.Size(54, 17);
            this.rbtnKiralik.TabIndex = 0;
            this.rbtnKiralik.TabStop = true;
            this.rbtnKiralik.Text = "Kiralık";
            this.rbtnKiralik.UseVisualStyleBackColor = true;
            this.rbtnKiralik.CheckedChanged += new System.EventHandler(this.rbtnKiralik_CheckedChanged);
            // 
            // rbtnSatilik
            // 
            this.rbtnSatilik.AutoSize = true;
            this.rbtnSatilik.Location = new System.Drawing.Point(100, 19);
            this.rbtnSatilik.Name = "rbtnSatilik";
            this.rbtnSatilik.Size = new System.Drawing.Size(54, 17);
            this.rbtnSatilik.TabIndex = 1;
            this.rbtnSatilik.TabStop = true;
            this.rbtnSatilik.Text = "Satılık";
            this.rbtnSatilik.UseVisualStyleBackColor = true;
            this.rbtnSatilik.CheckedChanged += new System.EventHandler(this.rbtnSatilik_CheckedChanged);
            // 
            // lblDepozitosu
            // 
            this.lblDepozitosu.AutoSize = true;
            this.lblDepozitosu.Location = new System.Drawing.Point(20, 260);
            this.lblDepozitosu.Name = "lblDepozitosu";
            this.lblDepozitosu.Size = new System.Drawing.Size(59, 13);
            this.lblDepozitosu.TabIndex = 13;
            this.lblDepozitosu.Text = "Depozitosu";
            // 
            // txtDepozitosu
            // 
            this.txtDepozitosu.Location = new System.Drawing.Point(120, 260);
            this.txtDepozitosu.Name = "txtDepozitosu";
            this.txtDepozitosu.Size = new System.Drawing.Size(200, 20);
            this.txtDepozitosu.TabIndex = 14;
            // 
            // lblKirasi
            // 
            this.lblKirasi.AutoSize = true;
            this.lblKirasi.Location = new System.Drawing.Point(20, 290);
            this.lblKirasi.Name = "lblKirasi";
            this.lblKirasi.Size = new System.Drawing.Size(33, 13);
            this.lblKirasi.TabIndex = 15;
            this.lblKirasi.Text = "Kirası";
            // 
            // txtKirasi
            // 
            this.txtKirasi.Location = new System.Drawing.Point(120, 290);
            this.txtKirasi.Name = "txtKirasi";
            this.txtKirasi.Size = new System.Drawing.Size(200, 20);
            this.txtKirasi.TabIndex = 16;
            // 
            // lblFiyati
            // 
            this.lblFiyati.AutoSize = true;
            this.lblFiyati.Location = new System.Drawing.Point(20, 320);
            this.lblFiyati.Name = "lblFiyati";
            this.lblFiyati.Size = new System.Drawing.Size(32, 13);
            this.lblFiyati.TabIndex = 17;
            this.lblFiyati.Text = "Fiyatı";
            // 
            // txtFiyati
            // 
            this.txtFiyati.Location = new System.Drawing.Point(120, 320);
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Size = new System.Drawing.Size(200, 20);
            this.txtFiyati.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 401);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFiyati);
            this.Controls.Add(this.lblFiyati);
            this.Controls.Add(this.txtKirasi);
            this.Controls.Add(this.lblKirasi);
            this.Controls.Add(this.txtDepozitosu);
            this.Controls.Add(this.lblDepozitosu);
            this.Controls.Add(this.gbKiralikSatilik);
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
            this.Name = "RegisterForm";
            this.Text = "Yeni Ev Kaydı";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.gbKiralikSatilik.ResumeLayout(false);
            this.gbKiralikSatilik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
