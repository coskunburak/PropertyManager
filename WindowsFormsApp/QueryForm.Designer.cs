namespace WindowsFormsApp
{
    partial class QueryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOdaSayisi;
        private System.Windows.Forms.TextBox txtOdaSayisi;
        private System.Windows.Forms.Label lblSemti;
        private System.Windows.Forms.TextBox txtSemti;
        private System.Windows.Forms.Label lblTuru;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.Label lblTitle;

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
            this.lblSemti = new System.Windows.Forms.Label();
            this.txtSemti = new System.Windows.Forms.TextBox();
            this.lblTuru = new System.Windows.Forms.Label();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvResults = new System.Windows.Forms.ListView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOdaSayisi
            // 
            this.lblOdaSayisi.AutoSize = true;
            this.lblOdaSayisi.Location = new System.Drawing.Point(20, 50);
            this.lblOdaSayisi.Name = "lblOdaSayisi";
            this.lblOdaSayisi.Size = new System.Drawing.Size(58, 13);
            this.lblOdaSayisi.TabIndex = 0;
            this.lblOdaSayisi.Text = "Oda Sayısı";
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(120, 47);
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(200, 20);
            this.txtOdaSayisi.TabIndex = 1;
            // 
            // lblSemti
            // 
            this.lblSemti.AutoSize = true;
            this.lblSemti.Location = new System.Drawing.Point(20, 80);
            this.lblSemti.Name = "lblSemti";
            this.lblSemti.Size = new System.Drawing.Size(32, 13);
            this.lblSemti.TabIndex = 2;
            this.lblSemti.Text = "Semt";
            // 
            // txtSemti
            // 
            this.txtSemti.Location = new System.Drawing.Point(120, 77);
            this.txtSemti.Name = "txtSemti";
            this.txtSemti.Size = new System.Drawing.Size(200, 20);
            this.txtSemti.TabIndex = 3;
            // 
            // lblTuru
            // 
            this.lblTuru.AutoSize = true;
            this.lblTuru.Location = new System.Drawing.Point(20, 110);
            this.lblTuru.Name = "lblTuru";
            this.lblTuru.Size = new System.Drawing.Size(28, 13);
            this.lblTuru.TabIndex = 4;
            this.lblTuru.Text = "Türü";
            // 
            // cmbTuru
            // 
            this.cmbTuru.FormattingEnabled = true;
            this.cmbTuru.Location = new System.Drawing.Point(120, 107);
            this.cmbTuru.Name = "cmbTuru";
            this.cmbTuru.Size = new System.Drawing.Size(200, 21);
            this.cmbTuru.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(120, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvResults
            // 
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            new System.Windows.Forms.ColumnHeader() { Text = "Emlak No", Width = 80 },
            new System.Windows.Forms.ColumnHeader() { Text = "Oda Sayısı", Width = 70 },
            new System.Windows.Forms.ColumnHeader() { Text = "Kat No", Width = 50 },
            new System.Windows.Forms.ColumnHeader() { Text = "Semt", Width = 100 },
            new System.Windows.Forms.ColumnHeader() { Text = "Alan", Width = 70 },
            new System.Windows.Forms.ColumnHeader() { Text = "Yapım Tarihi", Width = 90 },
            new System.Windows.Forms.ColumnHeader() { Text = "Türü", Width = 80 },
            new System.Windows.Forms.ColumnHeader() { Text = "Durum", Width = 60 }
            });
            this.lvResults.FullRowSelect = true;
            this.lvResults.GridLines = true;
            this.lvResults.Location = new System.Drawing.Point(20, 180);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(600, 300);
            this.lvResults.TabIndex = 7;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 24);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Ev Sorgulama";
            // 
            // QueryForm
            // 
            this.ClientSize = new System.Drawing.Size(644, 511);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbTuru);
            this.Controls.Add(this.lblTuru);
            this.Controls.Add(this.txtSemti);
            this.Controls.Add(this.lblSemti);
            this.Controls.Add(this.txtOdaSayisi);
            this.Controls.Add(this.lblOdaSayisi);
            this.Name = "QueryForm";
            this.Text = "Ev Sorgulama";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
