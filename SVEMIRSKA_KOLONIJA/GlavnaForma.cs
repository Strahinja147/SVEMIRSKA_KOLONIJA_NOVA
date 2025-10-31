using SVEMIRSKA_KOLONIJA.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVEMIRSKA_KOLONIJA
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnStanovnici_Click(object sender, EventArgs e)
        {
            StanovniciForm form = new StanovniciForm();
            form.Show();
        }

        private void btnResursi_Click(object sender, EventArgs e)
        {
            ResursiForm form = new ResursiForm();
            form.Show();
        }

        private void btnSektori_Click(object sender, EventArgs e)
        {
            SektoriForm form = new SektoriForm();
            form.Show();
        }

        private void btnRoboti_Click(object sender, EventArgs e)
        {
            RobotiForm form = new RobotiForm();
            form.Show();
        }

        private void btnZadaci_Click(object sender, EventArgs e)
        {
            ZadaciForm form = new ZadaciForm();
            form.Show();
        }
    }
}
