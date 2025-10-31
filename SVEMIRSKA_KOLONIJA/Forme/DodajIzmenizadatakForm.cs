using SVEMIRSKA_KOLONIJA.DTOs;
using SVEMIRSKA_KOLONIJA.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVEMIRSKA_KOLONIJA.Forme
{
    public partial class DodajIzmenizadatakForm : Form
    {
        ZadatakPregled ZadatakZaIzmenu { get; set; }

        public DodajIzmenizadatakForm()
        {
            InitializeComponent();
        }

        public DodajIzmenizadatakForm(ZadatakPregled zadatak)
        {
            InitializeComponent();
            this.ZadatakZaIzmenu = zadatak;
        }

        private void DodajIzmenizadatakForm_Load(object sender, EventArgs e)
        {

            cmbTipZad.Items.AddRange(new object[] { "Evakuacija", "Istraživanje", "Održavanje", "Medicinska intervencija", "Eksperiment" });

            var moguciNadzadaci = DTOManager.VratiSveZadatke(); 
            cmbNadzadatak.Items.Add("Nema nadzadatka");
            foreach (var z in moguciNadzadaci)
            {
                if (this.ZadatakZaIzmenu == null || this.ZadatakZaIzmenu.Id != z.Id)
                {
                    cmbNadzadatak.Items.Add(z);
                }
            }
            cmbNadzadatak.SelectedIndex = 0;

            var sveSpecijalizacije = DTOManager.VratiSveSpecijalizacije();
            foreach (var spec in sveSpecijalizacije)
            {
                clbSpecijalizacije.Items.Add(spec);
            }


            if (this.ZadatakZaIzmenu != null)
            {
                this.Text = "Izmena zadatka";
                btnAngazuj.Enabled = true;

                ZadatakDetalji detalji = DTOManager.VratiZadatakDetalji(this.ZadatakZaIzmenu.Id);

                if (detalji != null)
                {
                    txtOpisCilja.Text = detalji.OpisCilja;
                    txtLokacija.Text = detalji.Lokacija;
                    txtRezultat.Text = detalji.Rezultat;
                    numBrojUcesnika.Value = detalji.BrojPotrebnihUcesnika ?? 0;
                    numOcekivanoTrajanje.Value = detalji.OcekivanoTrajanjeDani ?? 0;
                    numOcenaUspesnosti.Value = (decimal)(detalji.OcenaUspesnosti ?? 0.0);

                    if (detalji.DatumPocetka.HasValue)
                        dtpDatumPocetka.Value = detalji.DatumPocetka.Value;

                    if (detalji.DatumZavrsetka.HasValue)
                    {
                        chkDatumZav.Checked = true;
                        dtpDatumZavrsetka.Enabled = true;
                        dtpDatumZavrsetka.Value = detalji.DatumZavrsetka.Value;
                    }
                    else
                    {
                        chkDatumZav.Checked = false;
                        dtpDatumZavrsetka.Enabled = false;
                    }

                    if (detalji.Nadzadatak != null)
                    {
                        foreach (var item in cmbNadzadatak.Items)
                        {
                            if (item is ZadatakPregled z && z.Id == detalji.Nadzadatak.Id)
                            {
                                cmbNadzadatak.SelectedItem = item;
                                break;
                            }
                        }
                    }
                    else
                    {
                        cmbNadzadatak.SelectedIndex = 0; 
                    }

                    for (int i = 0; i < clbSpecijalizacije.Items.Count; i++)
                    {
                        var specIzListe = (SpecijalizacijaPregled)clbSpecijalizacije.Items[i];
                        bool postoji = detalji.PotrebneSpecijalizacije.Any(p => p.Id == specIzListe.Id);
                        if (postoji)
                        {
                            clbSpecijalizacije.SetItemChecked(i, true);
                        }
                    }

                    string tipIzBaze = this.ZadatakZaIzmenu.TipZadatka;

                    PrikaziAngazovane(detalji);

                    switch (tipIzBaze)
                    {
                        case "Evakuacija":
                            cmbTipZad.SelectedItem = "Evakuacija";
                            break;
                        case "Istrazivanje":
                            cmbTipZad.SelectedItem = "Istraživanje"; 
                            break;
                        case "Odrzavanje":
                            cmbTipZad.SelectedItem = "Održavanje"; 
                            break;
                        case "MedicinskaIntervencija": 
                            cmbTipZad.SelectedItem = "Medicinska intervencija";
                            break;
                        case "Eksperiment":
                            cmbTipZad.SelectedItem = "Eksperiment";
                            break;
                        default:
                            cmbTipZad.SelectedIndex = 0;
                            break;
                    }

                    if (detalji is EvakuacijaDetalji evakuacija)
                    {
                        txtOblastEvakuacije.Text = evakuacija.OblastEvakuacije;
                        numBrOsobaEvakuacije.Value = evakuacija.BrojOsobaEvakuacije ?? 0;
                    }
                    else if (detalji is MedicinskaIntervencijaDetalji medicinska)
                    {
                        numBrojPovredjenih.Value = medicinska.BrojPovredjenih ?? 0;
                        numStepenKriticnosti.Value = medicinska.StepenKriticnosti ?? 0;
                    }
                    else if (detalji is EksperimentDetalji eksperiment)
                    {
                        txtNivoOpasnosti.Text = eksperiment.NivoOpasnosti;
                    }
                }
            }
            else
            {
                this.Text = "Dodavanje novog zadatka";
                cmbTipZad.SelectedIndex = 0;
                btnAngazuj.Enabled = false;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string izabraniTip = cmbTipZad.SelectedItem.ToString();
            ZadatakDetalji zadatakZaCuvanje = null;

            switch (izabraniTip)
            {
                case "Evakuacija":
                    zadatakZaCuvanje = new EvakuacijaDetalji();
                    break;
                case "Medicinska intervencija":
                    zadatakZaCuvanje = new MedicinskaIntervencijaDetalji();
                    break;
                case "Eksperiment":
                    zadatakZaCuvanje = new EksperimentDetalji();
                    break;
                case "Održavanje":
                    zadatakZaCuvanje = new OdrzavanjeDetalji();
                    break;
                case "Istraživanje":
                    zadatakZaCuvanje = new IstrazivanjeDetalji();
                    break;
                default:
                    MessageBox.Show("Izaberite validan tip zadatka!");
                    return;
            }

            zadatakZaCuvanje.OpisCilja = txtOpisCilja.Text;
            zadatakZaCuvanje.Lokacija = txtLokacija.Text;
            zadatakZaCuvanje.Rezultat = txtRezultat.Text;
            zadatakZaCuvanje.BrojPotrebnihUcesnika = (int)numBrojUcesnika.Value;
            zadatakZaCuvanje.OcekivanoTrajanjeDani = (int)numOcekivanoTrajanje.Value;
            zadatakZaCuvanje.OcenaUspesnosti = (double)numOcenaUspesnosti.Value;
            zadatakZaCuvanje.DatumPocetka = dtpDatumPocetka.Value;

            if (chkDatumZav.Checked)
            {
                zadatakZaCuvanje.DatumZavrsetka = dtpDatumZavrsetka.Value;
            }
            else
            {
                zadatakZaCuvanje.DatumZavrsetka = null;
            }

            if (cmbNadzadatak.SelectedItem is ZadatakPregled selektovaniNadzadatak)
            {
                zadatakZaCuvanje.Nadzadatak = selektovaniNadzadatak;
            }
            else
            {
                zadatakZaCuvanje.Nadzadatak = null;
            }

            zadatakZaCuvanje.PotrebneSpecijalizacije = new List<PotrebnaPregled>();
            foreach (var item in clbSpecijalizacije.CheckedItems)
            {
                var selektovanaSpecijalizacija = (SpecijalizacijaPregled)item;
                var potrebna = new PotrebnaPregled
                {
                    Id = selektovanaSpecijalizacija.Id,
                    NazivSpecijalizacije = selektovanaSpecijalizacija.Naziv
                };

                zadatakZaCuvanje.PotrebneSpecijalizacije.Add(potrebna);
            }

            if (zadatakZaCuvanje is EvakuacijaDetalji evakuacija)
            {
                evakuacija.OblastEvakuacije = txtOblastEvakuacije.Text;
                evakuacija.BrojOsobaEvakuacije = (int)numBrOsobaEvakuacije.Value;
            }
            else if (zadatakZaCuvanje is MedicinskaIntervencijaDetalji medicinska)
            {
                medicinska.BrojPovredjenih = (int)numBrojPovredjenih.Value;
                medicinska.StepenKriticnosti = (int)numStepenKriticnosti.Value;
            }
            else if (zadatakZaCuvanje is EksperimentDetalji eksperiment)
            {
                eksperiment.NivoOpasnosti = txtNivoOpasnosti.Text;
            }

            if (this.ZadatakZaIzmenu != null)
            {
                zadatakZaCuvanje.Id = this.ZadatakZaIzmenu.Id;
                DTOManager.AzurirajZadatak(zadatakZaCuvanje);
                MessageBox.Show("Uspešno ste ažurirali zadatak!");
            }
            else
            {
                DTOManager.DodajZadatak(zadatakZaCuvanje);
                MessageBox.Show("Uspešno ste dodali novi zadatak!");
            }

            this.Close();
        }

        private void cmbTipZad_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbEvakuacija.Visible = false;
            gbMedIntervencija.Visible = false; 
            gbEksperiment.Visible = false;         

            string izabraniTip = cmbTipZad.SelectedItem.ToString();

            switch (izabraniTip)
            {
                case "Evakuacija":
                    gbEvakuacija.Visible = true;
                    break;
                case "Medicinska intervencija":
                    gbMedIntervencija.Visible = true;
                    break;
                case "Eksperiment":
                    gbEksperiment.Visible = true;
                    break;
            }
        }

        private void chkDatumZav_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatumZavrsetka.Enabled = chkDatumZav.Checked;
        }

        private void btnAngazuj_Click(object sender, EventArgs e)
        {
            if (this.ZadatakZaIzmenu != null)
            {
                AngazujUcesnikaForm forma = new AngazujUcesnikaForm(this.ZadatakZaIzmenu.Id);
                forma.ShowDialog();
                ZadatakDetalji osvezeniDetalji = DTOManager.VratiZadatakDetalji(this.ZadatakZaIzmenu.Id);
                PrikaziAngazovane(osvezeniDetalji);
            }
            else
            {
                MessageBox.Show("Morate prvo sačuvati zadatak pre nego što angažujete učesnike.");
            }
        }

        private void PrikaziAngazovane(ZadatakDetalji detalji)
        {
            listViewAngazovani.Items.Clear();

            foreach (var ucesnik in detalji.AngazovaniUcesnici)
            {
                ListViewItem item = new ListViewItem(new string[] { ucesnik.Tip, ucesnik.Naziv });
                listViewAngazovani.Items.Add(item);
            }

            listViewAngazovani.Refresh();
        }
    }
}
