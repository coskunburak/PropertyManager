using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class QueryForm : Form
    {
        private List<Ev> evler;

        public QueryForm(List<Ev> evler)
        {
            InitializeComponent();
            this.evler = evler;
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            cmbTuru.DataSource = Enum.GetValues(typeof(EvTuru));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool odaSayisiGirildi = int.TryParse(txtOdaSayisi.Text, out int odaSayisi);
            string semti = txtSemti.Text;
            EvTuru? turu = (EvTuru?)cmbTuru.SelectedItem;

            var filteredEvler = evler.Where(ev =>
                (!odaSayisiGirildi || ev.OdaSayisi == odaSayisi) &&
                (string.IsNullOrEmpty(semti) || ev.Semti.Contains(semti)) &&
                (!turu.HasValue || ev.Turu == turu.Value)
            ).ToList();

            lvResults.Items.Clear();
            foreach (var ev in filteredEvler)
            {
                var item = new ListViewItem(ev.EmlakNumarasi.ToString());
                item.SubItems.Add(ev.OdaSayisi.ToString());
                item.SubItems.Add(ev.KatNumarasi.ToString());
                item.SubItems.Add(ev.Semti);
                item.SubItems.Add(ev.Alani.ToString());
                item.SubItems.Add(ev.YapimTarihi.ToShortDateString());
                item.SubItems.Add(ev.Turu.ToString());
                item.SubItems.Add(ev.Aktif ? "Aktif" : "Pasif");
                lvResults.Items.Add(item);
            }
        }
    }
}
