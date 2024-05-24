using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Ev> evler = new List<Ev>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(evler);
            registerForm.ShowDialog();
            RefreshEvList();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var queryForm = new QueryForm(evler);
            queryForm.ShowDialog();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshEvList()
        {
            lvEvler.Items.Clear();
            foreach (var ev in evler)
            {
                var item = new ListViewItem(ev.EmlakNumarasi.ToString());
                item.SubItems.Add(ev.OdaSayisi.ToString());
                item.SubItems.Add(ev.KatNumarasi.ToString());
                item.SubItems.Add(ev.Semti);
                item.SubItems.Add(ev.Alani.ToString());
                item.SubItems.Add(ev.YapimTarihi.ToShortDateString());
                item.SubItems.Add(ev.Turu.ToString());
                item.SubItems.Add(ev.Aktif ? "Aktif" : "Pasif");
                lvEvler.Items.Add(item);
            }
        }
    }
}
