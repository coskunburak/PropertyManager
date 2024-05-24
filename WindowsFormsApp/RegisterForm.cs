using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class RegisterForm : Form
    {
        private List<Ev> evler;

        public RegisterForm(List<Ev> evler)
        {
            InitializeComponent();
            this.evler = evler;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cmbTuru.DataSource = Enum.GetValues(typeof(EvTuru));
            ToggleKiralikSatilikFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Oda Sayısı kontrolü
            if (!int.TryParse(txtOdaSayisi.Text, out int odaSayisi) || odaSayisi <= 0)
            {
                MessageBox.Show("Geçerli bir oda sayısı giriniz.");
                return;
            }

            // Kat Numarası kontrolü
            if (!int.TryParse(txtKatNumarasi.Text, out int katNumarasi) || katNumarasi < 0)
            {
                MessageBox.Show("Geçerli bir kat numarası giriniz.");
                return;
            }

            // Alan kontrolü
            if (!double.TryParse(txtAlani.Text, out double alani) || alani <= 0)
            {
                MessageBox.Show("Geçerli bir alan giriniz.");
                return;
            }

            // Genel veriler
            string semti = txtSemti.Text;
            DateTime yapimTarihi = dtpYapimTarihi.Value;
            EvTuru turu = (EvTuru)cmbTuru.SelectedItem;

            if (rbtnKiralik.Checked)
            {
                // Kiralık Ev için veriler
                if (!double.TryParse(txtDepozitosu.Text, out double depozitosu) || depozitosu < 0)
                {
                    MessageBox.Show("Geçerli bir depozito giriniz.");
                    return;
                }

                if (!double.TryParse(txtKirasi.Text, out double kirasi) || kirasi <= 0)
                {
                    MessageBox.Show("Geçerli bir kira bedeli giriniz.");
                    return;
                }

                KiralikEv kiralikEv = new KiralikEv(odaSayisi, katNumarasi, semti, alani, yapimTarihi, turu, depozitosu, kirasi);
                evler.Add(kiralikEv);
            }
            else if (rbtnSatilik.Checked)
            {
                // Satılık Ev için veriler
                if (!double.TryParse(txtFiyati.Text, out double fiyati) || fiyati <= 0)
                {
                    MessageBox.Show("Geçerli bir fiyat giriniz.");
                    return;
                }

                SatilikEv satilikEv = new SatilikEv(odaSayisi, katNumarasi, semti, alani, yapimTarihi, turu, fiyati);
                evler.Add(satilikEv);
            }
            else
            {
                MessageBox.Show("Kiralık veya Satılık türünü seçiniz.");
                return;
            }

            this.Close();
        }

        private void rbtnKiralik_CheckedChanged(object sender, EventArgs e)
        {
            ToggleKiralikSatilikFields();
        }

        private void rbtnSatilik_CheckedChanged(object sender, EventArgs e)
        {
            ToggleKiralikSatilikFields();
        }

        private void ToggleKiralikSatilikFields()
        {
            bool isKiralik = rbtnKiralik.Checked;
            lblDepozitosu.Visible = isKiralik;
            txtDepozitosu.Visible = isKiralik;
            lblKirasi.Visible = isKiralik;
            txtKirasi.Visible = isKiralik;

            lblFiyati.Visible = !isKiralik;
            txtFiyati.Visible = !isKiralik;
        }
    }
}
