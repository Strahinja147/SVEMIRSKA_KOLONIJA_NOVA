using SVEMIRSKA_KOLONIJA.DTOs;
using System;
using System.Windows.Forms;

namespace SVEMIRSKA_KOLONIJA.Forme
{
    public partial class DodajSpecijalizacijuStanovnikuForm : Form
    {
        public PosedujePregled NovaSpecijalizacija { get; private set; }

        public DodajSpecijalizacijuStanovnikuForm()
        {
            InitializeComponent();
        }

        private void DodajSpecijalizacijuStanovnikuForm_Load(object sender, EventArgs e)
        {
            PopuniSpecijalizacije();
        }

        private void PopuniSpecijalizacije()
        {
            var specijalizacije = DTOManager.VratiSveSpecijalizacije();
            cmbSpecijalizacija.DataSource = specijalizacije;
            cmbSpecijalizacija.DisplayMember = "Naziv";
            cmbSpecijalizacija.ValueMember = "Id";
        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            // === VALIDACIJA: Proveravamo SVA polja PRE korišćenja ===

            if (cmbSpecijalizacija.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati specijalizaciju!");
                return; // Prekida izvršavanje metode
            }

            // Provera koja je nedostajala i koja je izazvala grešku
            if (cmbNivoEks.SelectedItem == null)
            {
                MessageBox.Show("Morate izabrati nivo ekspertize!");
                return; // Prekida izvršavanje metode
            }

            // Dodatna provera za tekstualno polje je dobra praksa
            if (string.IsNullOrWhiteSpace(txtInstitucija.Text))
            {
                MessageBox.Show("Morate uneti naziv institucije!");
                return; // Prekida izvršavanje metode
            }

            // === KRAJ VALIDACIJE ===


            // Ovaj deo koda će se izvršiti SAMO AKO su sve gornje provere prošle.
            // Sada je sigurno koristiti .SelectedItem i .Text jer znamo da nisu prazni.

            var izabranaSpecijalizacija = (SpecijalizacijaPregled)cmbSpecijalizacija.SelectedItem;
            var izabranNivoEkspertize = cmbNivoEks.SelectedItem;

            this.NovaSpecijalizacija = new PosedujePregled
            {
                Specijalizacija = izabranaSpecijalizacija,
                NazivSpecijalizacije = izabranaSpecijalizacija.Naziv,
                NivoEkspertize = izabranNivoEkspertize.ToString(),
                DatumSticanja = dtpDatumSticanja.Value,
                Institucija = txtInstitucija.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void labelSpecijalizacija_Click(object sender, EventArgs e)
        {

        }
    }
}