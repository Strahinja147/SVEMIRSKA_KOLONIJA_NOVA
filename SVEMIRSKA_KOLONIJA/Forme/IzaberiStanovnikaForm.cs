﻿using SVEMIRSKA_KOLONIJA.DTOs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SVEMIRSKA_KOLONIJA.Forme
{
    public partial class IzaberiStanovnikaForm : Form
    {
        public StanovnikPregled IzabraniStanovnik { get; private set; }
        private List<int> idZaIzbegavanje;
        public IzaberiStanovnikaForm(List<int> postojeciIdjevi = null)
        {
            InitializeComponent();
            this.idZaIzbegavanje = postojeciIdjevi ?? new List<int>();
        }

        private void IzaberiStanovnikaForm_Load(object sender, EventArgs e)
        {
            PopuniPodacima();
        }

        private void PopuniPodacima()
        {
            lvStanovnici.Items.Clear();

            var stanovnici = DTOManager.VratiSveStanovnike();

            foreach (var s in stanovnici)
            {
                if (!this.idZaIzbegavanje.Contains(s.Id))
                {
                    ListViewItem item = new ListViewItem(new string[] { s.Id.ToString(), s.Ime, s.Prezime });
                    item.Tag = s;
                    lvStanovnici.Items.Add(item);
                }
            }

            lvStanovnici.Refresh();
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            if (lvStanovnici.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate izabrati stanovnika!");
                return;
            }

            this.IzabraniStanovnik = (StanovnikPregled)lvStanovnici.SelectedItems[0].Tag;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}