using SVEMIRSKA_KOLONIJA.DTOs;
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
    public partial class ZadaciForm : Form
    {
        public ZadaciForm()
        {
            InitializeComponent();
        }

        private void PopuniPodacima()
        {
            listViewZadaci.Items.Clear();

            var zadaci = DTOManager.VratiSveZadatke();

            foreach (var z in zadaci)
            {
                ListViewItem item = new ListViewItem(new string[] 
                { z.Id.ToString(), z.OpisCilja, z.TipZadatka, z.DatumPocetka.ToString() });
                item.Tag = z;
                listViewZadaci.Items.Add(item);
            }
            listViewZadaci.Refresh();
        }

        private void ZadaciForm_Load(object sender, EventArgs e)
        {
            this.PopuniPodacima();
        }

        private void btnIzmeniZad_Click(object sender, EventArgs e)
        {
            if (listViewZadaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zadatak koji želite da izmenite!");
                return;
            }

            var selektovaniZadatak = (ZadatakPregled)listViewZadaci.SelectedItems[0].Tag;
            DodajIzmenizadatakForm forma = new DodajIzmenizadatakForm(selektovaniZadatak);
            forma.ShowDialog();
            this.PopuniPodacima();
        }

        private void btnDodajZad_Click(object sender, EventArgs e)
        {
            DodajIzmenizadatakForm forma = new DodajIzmenizadatakForm();
            forma.ShowDialog();
            this.PopuniPodacima();
        }
    }
}
