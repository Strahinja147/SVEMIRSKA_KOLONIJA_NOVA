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
    public partial class AngazujUcesnikaForm : Form
    {
        private int zadatakId;

        public AngazujUcesnikaForm(int idZadatka)
        {
            InitializeComponent();
            this.zadatakId = idZadatka;
        }

        private void AngazujUcesnikaForm_Load(object sender, EventArgs e)
        {
            this.PopuniPodacima();
        }

        private void PopuniPodacima()
        {
            listViewUcesnici.Items.Clear();

            List<StanovnikPregled> stanovnici = DTOManager.VratiSveStanovnike();
            foreach (var s in stanovnici)
            {
                ListViewItem item = new ListViewItem(new string[] { s.Id.ToString(), s.Ime, "Stanovnik" });
                item.Tag = s;

                listViewUcesnici.Items.Add(item);
            }

            List<RobotPregled> roboti = DTOManager.VratiSveRobote(); 
            foreach (var r in roboti)
            {
                ListViewItem item = new ListViewItem(new string[] { r.Id.ToString(), r.Sifra, "Robot" });
                item.Tag = r;

                listViewUcesnici.Items.Add(item);
            }

            listViewUcesnici.Refresh();
        }

        private void btnAngazuj_Click(object sender, EventArgs e)
        {
            if (listViewUcesnici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo vas, izaberite učesnika kojeg želite da angažujete.");
                return;
            }

            ListViewItem selektovaniItem = listViewUcesnici.SelectedItems[0];
            object tag = selektovaniItem.Tag;

            if (tag is StanovnikPregled stanovnik)
            {
                DTOManager.AngazujUcesnikaNaZadatku(stanovnik.Id, "Stanovnik", this.zadatakId);
            }
            else if (tag is RobotPregled robot)
            {
                DTOManager.AngazujUcesnikaNaZadatku(robot.Id, "Robot", this.zadatakId);
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom prepoznavanja tipa učesnika.");
                return;
            }

            MessageBox.Show("Učesnik je uspešno angažovan na zadatku!");
            this.Close();
        }
    }
}
