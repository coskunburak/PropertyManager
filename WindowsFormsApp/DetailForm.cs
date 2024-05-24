using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class DetailForm : Form
    {
        private Ev _ev;

        public DetailForm(Ev ev)
        {
            _ev = ev;
            InitializeComponent();
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            cmbTuru.DataSource = Enum.GetValues(typeof(EvTuru));

            txtEmlakNumarasi.Text = _ev.EmlakNumarasi.ToString();
            txtOdaSayisi.Text = _ev.OdaSayisi.ToString();
            txtKatNumarasi.Text = _ev.KatNumarasi.ToString();
            txtSemti.Text = _ev.Semti;
            txtAlani.Text = _ev.Alani.ToString();
            dtpYapimTarihi.Value = _ev.YapimTarihi;
            cmbTuru.SelectedItem = _ev.Turu;
            chkAktif.Checked = _ev.Aktif;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ev.OdaSayisi = int.Parse(txtOdaSayisi.Text);
            _ev.KatNumarasi = int.Parse(txtKatNumarasi.Text);
            _ev.Semti = txtSemti.Text;
            _ev.Alani = double.Parse(txtAlani.Text);
            _ev.YapimTarihi = dtpYapimTarihi.Value;
            _ev.Turu = (EvTuru)cmbTuru.SelectedItem;
            _ev.Aktif = chkAktif.Checked;

            MessageBox.Show("Değişiklikler kaydedildi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Emlak silindi.");
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            _ev.Aktif = false;
            MessageBox.Show("Emlak arşivlendi.");
        }

        private void btnOpenImages_Click(object sender, EventArgs e)
        {
            var folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", _ev.EmlakNumarasi.ToString());
            if (Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("Görseller bulunamadı.");
            }
        }
    }
}
