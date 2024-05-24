namespace WindowsFormsApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView lvEvler;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.GroupBox gbActions;

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
            this.components = new System.ComponentModel.Container();
            this.lvEvler = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControls = new System.Windows.Forms.Panel();
            this.gbActions = new System.Windows.Forms.GroupBox();

            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // lvEvler
            // 
            this.lvEvler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            new System.Windows.Forms.ColumnHeader() { Text = "Emlak No", Width = 80 },
            new System.Windows.Forms.ColumnHeader() { Text = "Oda Sayısı", Width = 70 },
            new System.Windows.Forms.ColumnHeader() { Text = "Kat No", Width = 50 },
            new System.Windows.Forms.ColumnHeader() { Text = "Semt", Width = 100 },
            new System.Windows.Forms.ColumnHeader() { Text = "Alan", Width = 70 },
            new System.Windows.Forms.ColumnHeader() { Text = "Yapım Tarihi", Width = 90 },
            new System.Windows.Forms.ColumnHeader() { Text = "Türü", Width = 80 },
            new System.Windows.Forms.ColumnHeader() { Text = "Durum", Width = 60 }
            });
            this.lvEvler.FullRowSelect = true;
            this.lvEvler.GridLines = true;
            this.lvEvler.Location = new System.Drawing.Point(12, 80);
            this.lvEvler.Name = "lvEvler";
            this.lvEvler.Size = new System.Drawing.Size(760, 400);
            this.lvEvler.TabIndex = 1;
            this.lvEvler.UseCompatibleStateImageBehavior = false;
            this.lvEvler.View = System.Windows.Forms.View.Details;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Emlak Yönetimi";
            // 
            // panelControls
            // 
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControls.Controls.Add(this.gbActions);
            this.panelControls.Location = new System.Drawing.Point(12, 490);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(760, 100);
            this.panelControls.TabIndex = 3;
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.btnAdd);
            this.gbActions.Controls.Add(this.btnQuery);
            this.gbActions.Location = new System.Drawing.Point(10, 10);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(740, 80);
            this.gbActions.TabIndex = 0;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "İşlemler";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Yeni Ev Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(620, 30);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 30);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Ev Sorgula";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvEvler);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Emlak Yönetimi";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.gbActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
