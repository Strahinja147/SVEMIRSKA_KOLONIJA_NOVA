using SVEMIRSKA_KOLONIJA.DTOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SVEMIRSKA_KOLONIJA.Forme
{
    public partial class DodajStanovnikaForm : Form
    {
        private StanovnikDetalji Stanovnik;
        private List<PosedujePregled> privremeneSpecijalizacije;
        private List<KontaktNaZemljiPregled> privremeniKontakti;

        // Konstruktor za DODAVANJE
        public DodajStanovnikaForm()
        {
            InitializeComponent();
            this.Text = "DODAJ NOVOG STANOVNIKA";
            groupBoxPovezaniPodaci.Visible = false;
            this.Stanovnik = new StanovnikDetalji();
            this.privremeneSpecijalizacije = new List<PosedujePregled>();
            this.privremeniKontakti = new List<KontaktNaZemljiPregled>();
        }

        // Konstruktor za IZMENU
        public DodajStanovnikaForm(StanovnikDetalji stanovnik)
        {
            InitializeComponent();
            this.Stanovnik = stanovnik ?? new StanovnikDetalji();
            this.Text = $"IZMENI STANOVNIKA: {stanovnik.Ime} {stanovnik.Prezime}";
            //PopuniPodacima();
            this.privremeneSpecijalizacije = new List<PosedujePregled>(this.Stanovnik.Specijalizacije);
            this.privremeniKontakti = new List<KontaktNaZemljiPregled>(stanovnik.KontaktiNaZemlji ?? new List<KontaktNaZemljiPregled>());
        }

        private void DodajStanovnikaForm_Load(object sender, EventArgs e)
        {

            cmbPol.Items.Add('M');
            cmbPol.Items.Add('Z');

            // Ako je Stanovnik prosleđen (režim izmene), popunjavamo formu
            if (this.Stanovnik != null)
            {
                PopuniPodacima();
            }
        }

        private void PopuniPodacima()
        {
            // Popunjavanje osnovnih podataka
            txtIme.Text = this.Stanovnik.Ime;
            txtPrezime.Text = this.Stanovnik.Prezime;
            txtNacionalnost.Text = this.Stanovnik.Nacionalnost;
            txtZanimanje.Text = this.Stanovnik.Zanimanje;
            cmbPol.SelectedItem = this.Stanovnik.Pol;

            if (this.Stanovnik.DatumRodjenja.HasValue)
                dtpDatumRodjenja.Value = this.Stanovnik.DatumRodjenja.Value;
            if (this.Stanovnik.GodineUKoloniji.HasValue)
                numGodine.Value = this.Stanovnik.GodineUKoloniji.Value;

            // Popunjavanje ListView kontrola za povezane podatke
            PopuniPovezanePodatke();
        }

        private void PopuniPovezanePodatke()
        {
            // Koristimo BeginUpdate/EndUpdate za bolje performanse i manje treperenja

            // --- Kontakti na Zemlji ---
            listViewKontakti.BeginUpdate();
            listViewKontakti.Items.Clear();
            if (listViewKontakti.Columns.Count == 0)
            {
                listViewKontakti.Columns.Add("Ime");
                listViewKontakti.Columns.Add("Odnos");
            }
            foreach (var kontakt in this.privremeniKontakti)
            {
                listViewKontakti.Items.Add(new ListViewItem(new string[] { kontakt.Ime, kontakt.Odnos }));
            }
            // ISPRAVKA: Ručno podešavanje širine kolona
            listViewKontakti.Columns[1].Width = -1; // Kolona "Odnos" se širi po svom sadržaju
            listViewKontakti.Columns[0].Width = -2; // Kolona "Ime" popunjava ostatak
            listViewKontakti.EndUpdate();


            // --- Specijalizacije ---
            listViewSpecijalizacije.BeginUpdate();
            listViewSpecijalizacije.Items.Clear();
            if (listViewSpecijalizacije.Columns.Count == 0)
            {
                listViewSpecijalizacije.Columns.Add("Naziv");
                listViewSpecijalizacije.Columns.Add("Nivo Ekspertize");
            }
            foreach (var spec in this.privremeneSpecijalizacije)
            {
                string naziv = spec.Specijalizacija?.Naziv ?? spec.NazivSpecijalizacije;
                listViewSpecijalizacije.Items.Add(new ListViewItem(new string[] { naziv, spec.NivoEkspertize }));
            }
            // ISPRAVKA: Ručno podešavanje širine kolona
            listViewSpecijalizacije.Columns[1].Width = -1; // Kolona "Nivo" se širi po svom sadržaju
            listViewSpecijalizacije.Columns[0].Width = -2; // Kolona "Naziv" popunjava ostatak
            listViewSpecijalizacije.EndUpdate();


            // --- Sektori koje vodi ---
            listViewSektoriKojeVodi.BeginUpdate();
            listViewSektoriKojeVodi.Items.Clear();
            if (listViewSektoriKojeVodi.Columns.Count == 0)
            {
                listViewSektoriKojeVodi.Columns.Add("Naziv Sektora");
                listViewSektoriKojeVodi.Columns.Add("Tip");
            }
            if (this.Stanovnik.SektoriKojeVodi != null)
            {
                foreach (var sektor in this.Stanovnik.SektoriKojeVodi)
                {
                    listViewSektoriKojeVodi.Items.Add(new ListViewItem(new string[] { sektor.Naziv, sektor.TipSektora }));
                }
            }
            // ISPRAVKA: Ručno podešavanje širine kolona
            listViewSektoriKojeVodi.Columns[1].Width = -1; // Kolona "Tip" se širi po svom sadržaju
            listViewSektoriKojeVodi.Columns[0].Width = -2; // Kolona "Naziv Sektora" popunjava ostatak
            listViewSektoriKojeVodi.EndUpdate();


            // --- Odgovoran za robote ---
            listViewOdgovoranZa.BeginUpdate();
            listViewOdgovoranZa.Items.Clear();
            if (listViewOdgovoranZa.Columns.Count == 0)
            {
                listViewOdgovoranZa.Columns.Add("Šifra Robota");
                listViewOdgovoranZa.Columns.Add("Tip");
            }
            if (this.Stanovnik.OdgovoranZaRobote != null)
            {
                foreach (var robot in this.Stanovnik.OdgovoranZaRobote)
                {
                    listViewOdgovoranZa.Items.Add(new ListViewItem(new string[] { robot.Sifra, robot.Tip }));
                }
            }
            // ISPRAVKA: Ručno podešavanje širine kolona
            listViewOdgovoranZa.Columns[1].Width = -1;
            listViewOdgovoranZa.Columns[0].Width = -2;
            listViewOdgovoranZa.EndUpdate();


            // --- Programirao robote ---
            listViewProgramirao.BeginUpdate();
            listViewProgramirao.Items.Clear();
            if (listViewProgramirao.Columns.Count == 0)
            {
                listViewProgramirao.Columns.Add("Šifra Robota");
                listViewProgramirao.Columns.Add("Tip");
            }
            if (this.Stanovnik.ProgramiraniRoboti != null)
            {
                foreach (var robot in this.Stanovnik.ProgramiraniRoboti)
                {
                    listViewProgramirao.Items.Add(new ListViewItem(new string[] { robot.Sifra, robot.Tip }));
                }
            }
            // ISPRAVKA: Ručno podešavanje širine kolona
            listViewProgramirao.Columns[1].Width = -1;
            listViewProgramirao.Columns[0].Width = -2;
            listViewProgramirao.EndUpdate();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text) || string.IsNullOrEmpty(txtPrezime.Text) || cmbPol.SelectedItem == null)
            {
                MessageBox.Show("Sva polja su obavezna!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.Stanovnik == null)
            {
                this.Stanovnik = new StanovnikDetalji();
            }

            this.Stanovnik.Ime = txtIme.Text;
            this.Stanovnik.Prezime = txtPrezime.Text;
            this.Stanovnik.Nacionalnost = txtNacionalnost.Text;
            this.Stanovnik.Zanimanje = txtZanimanje.Text;
            this.Stanovnik.Pol = cmbPol.SelectedItem.ToString()[0];
            this.Stanovnik.DatumRodjenja = dtpDatumRodjenja.Value;
            this.Stanovnik.GodineUKoloniji = (int)numGodine.Value;

            if (this.Stanovnik.Id == 0)
            {
                var sacuvaniStanovnik = DTOManager.DodajStanovnika(this.Stanovnik);
                if (sacuvaniStanovnik != null)
                {
                    foreach (var spec in this.privremeneSpecijalizacije)
                    {
                        DTOManager.DodajSpecijalizacijuStanovniku(sacuvaniStanovnik.Id, spec.Specijalizacija.Id, spec);
                    }
                    foreach (var kontakt in this.privremeniKontakti)
                    {
                        DTOManager.DodajKontaktZaStanovnika(sacuvaniStanovnik.Id, kontakt);
                    }
                }
            }
            else
            {
                DTOManager.AzurirajStanovnika(this.Stanovnik);
            }

            MessageBox.Show("Podaci su uspešno sačuvani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDodajSpecijalizaciju_Click(object sender, EventArgs e)
        {
            DodajSpecijalizacijuStanovnikuForm form = new DodajSpecijalizacijuStanovnikuForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var novaSpecijalizacija = form.NovaSpecijalizacija;
                novaSpecijalizacija.NazivSpecijalizacije = novaSpecijalizacija.Specijalizacija.Naziv;

                if (this.Stanovnik != null && this.Stanovnik.Id != 0 )
                {
                    DTOManager.DodajSpecijalizacijuStanovniku(this.Stanovnik.Id, novaSpecijalizacija.Specijalizacija.Id, novaSpecijalizacija);
                }

                this.privremeneSpecijalizacije.Add(novaSpecijalizacija);
                PopuniPovezanePodatke();
            }
        }

        private void btnDodajKontakt_Click(object sender, EventArgs e)
        {
            DodajKontaktForm form = new DodajKontaktForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var noviKontakt = form.NoviKontakt;

                if (this.Stanovnik.Id != 0)
                {
                    DTOManager.DodajKontaktZaStanovnika(this.Stanovnik.Id, noviKontakt);
                }

                this.privremeniKontakti.Add(noviKontakt);
                PopuniPovezanePodatke();
            }
        }

        private void listViewSpecijalizacije_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}