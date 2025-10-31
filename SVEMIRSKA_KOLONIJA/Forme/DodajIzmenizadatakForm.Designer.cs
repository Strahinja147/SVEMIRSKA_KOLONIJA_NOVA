namespace SVEMIRSKA_KOLONIJA.Forme
{
    partial class DodajIzmenizadatakForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOpisCilja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.cmbTipZad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbOpstiPodaci = new System.Windows.Forms.GroupBox();
            this.chkDatumZav = new System.Windows.Forms.CheckBox();
            this.clbSpecijalizacije = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDatumZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.numOcenaUspesnosti = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numOcekivanoTrajanje = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numBrojUcesnika = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNadzadatak = new System.Windows.Forms.ComboBox();
            this.gbEvakuacija = new System.Windows.Forms.GroupBox();
            this.numBrOsobaEvakuacije = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOblastEvakuacije = new System.Windows.Forms.TextBox();
            this.gbMedIntervencija = new System.Windows.Forms.GroupBox();
            this.numStepenKriticnosti = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numBrojPovredjenih = new System.Windows.Forms.NumericUpDown();
            this.gbEksperiment = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNivoOpasnosti = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnAngazuj = new System.Windows.Forms.Button();
            this.listViewAngazovani = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbOpstiPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOcenaUspesnosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOcekivanoTrajanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojUcesnika)).BeginInit();
            this.gbEvakuacija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrOsobaEvakuacije)).BeginInit();
            this.gbMedIntervencija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepenKriticnosti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojPovredjenih)).BeginInit();
            this.gbEksperiment.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOpisCilja
            // 
            this.txtOpisCilja.Location = new System.Drawing.Point(80, 27);
            this.txtOpisCilja.Multiline = true;
            this.txtOpisCilja.Name = "txtOpisCilja";
            this.txtOpisCilja.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOpisCilja.Size = new System.Drawing.Size(172, 48);
            this.txtOpisCilja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Opis cilja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rezultat:";
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(80, 81);
            this.txtRezultat.Multiline = true;
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRezultat.Size = new System.Drawing.Size(172, 41);
            this.txtRezultat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lokacija:";
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(80, 128);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(172, 20);
            this.txtLokacija.TabIndex = 4;
            // 
            // cmbTipZad
            // 
            this.cmbTipZad.FormattingEnabled = true;
            this.cmbTipZad.Location = new System.Drawing.Point(91, 24);
            this.cmbTipZad.Name = "cmbTipZad";
            this.cmbTipZad.Size = new System.Drawing.Size(124, 21);
            this.cmbTipZad.TabIndex = 6;
            this.cmbTipZad.SelectedIndexChanged += new System.EventHandler(this.cmbTipZad_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tip zadatka:";
            // 
            // gbOpstiPodaci
            // 
            this.gbOpstiPodaci.Controls.Add(this.chkDatumZav);
            this.gbOpstiPodaci.Controls.Add(this.clbSpecijalizacije);
            this.gbOpstiPodaci.Controls.Add(this.label11);
            this.gbOpstiPodaci.Controls.Add(this.dtpDatumZavrsetka);
            this.gbOpstiPodaci.Controls.Add(this.dtpDatumPocetka);
            this.gbOpstiPodaci.Controls.Add(this.numOcenaUspesnosti);
            this.gbOpstiPodaci.Controls.Add(this.label10);
            this.gbOpstiPodaci.Controls.Add(this.label9);
            this.gbOpstiPodaci.Controls.Add(this.label8);
            this.gbOpstiPodaci.Controls.Add(this.numOcekivanoTrajanje);
            this.gbOpstiPodaci.Controls.Add(this.label7);
            this.gbOpstiPodaci.Controls.Add(this.numBrojUcesnika);
            this.gbOpstiPodaci.Controls.Add(this.label6);
            this.gbOpstiPodaci.Controls.Add(this.label5);
            this.gbOpstiPodaci.Controls.Add(this.cmbNadzadatak);
            this.gbOpstiPodaci.Controls.Add(this.txtRezultat);
            this.gbOpstiPodaci.Controls.Add(this.txtOpisCilja);
            this.gbOpstiPodaci.Controls.Add(this.label1);
            this.gbOpstiPodaci.Controls.Add(this.label3);
            this.gbOpstiPodaci.Controls.Add(this.label2);
            this.gbOpstiPodaci.Controls.Add(this.txtLokacija);
            this.gbOpstiPodaci.Location = new System.Drawing.Point(11, 61);
            this.gbOpstiPodaci.Name = "gbOpstiPodaci";
            this.gbOpstiPodaci.Size = new System.Drawing.Size(258, 463);
            this.gbOpstiPodaci.TabIndex = 8;
            this.gbOpstiPodaci.TabStop = false;
            this.gbOpstiPodaci.Text = "Opsti podaci";
            // 
            // chkDatumZav
            // 
            this.chkDatumZav.AutoSize = true;
            this.chkDatumZav.Location = new System.Drawing.Point(136, 290);
            this.chkDatumZav.Name = "chkDatumZav";
            this.chkDatumZav.Size = new System.Drawing.Size(15, 14);
            this.chkDatumZav.TabIndex = 9;
            this.chkDatumZav.UseVisualStyleBackColor = true;
            this.chkDatumZav.CheckedChanged += new System.EventHandler(this.chkDatumZav_CheckedChanged);
            // 
            // clbSpecijalizacije
            // 
            this.clbSpecijalizacije.FormattingEnabled = true;
            this.clbSpecijalizacije.Location = new System.Drawing.Point(9, 333);
            this.clbSpecijalizacije.Name = "clbSpecijalizacije";
            this.clbSpecijalizacije.Size = new System.Drawing.Size(243, 124);
            this.clbSpecijalizacije.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Potrebne specijalizacije:";
            // 
            // dtpDatumZavrsetka
            // 
            this.dtpDatumZavrsetka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumZavrsetka.Location = new System.Drawing.Point(158, 284);
            this.dtpDatumZavrsetka.Name = "dtpDatumZavrsetka";
            this.dtpDatumZavrsetka.Size = new System.Drawing.Size(94, 20);
            this.dtpDatumZavrsetka.TabIndex = 17;
            // 
            // dtpDatumPocetka
            // 
            this.dtpDatumPocetka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPocetka.Location = new System.Drawing.Point(158, 258);
            this.dtpDatumPocetka.Name = "dtpDatumPocetka";
            this.dtpDatumPocetka.Size = new System.Drawing.Size(94, 20);
            this.dtpDatumPocetka.TabIndex = 9;
            // 
            // numOcenaUspesnosti
            // 
            this.numOcenaUspesnosti.DecimalPlaces = 1;
            this.numOcenaUspesnosti.Location = new System.Drawing.Point(198, 233);
            this.numOcenaUspesnosti.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOcenaUspesnosti.Name = "numOcenaUspesnosti";
            this.numOcenaUspesnosti.Size = new System.Drawing.Size(54, 20);
            this.numOcenaUspesnosti.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ocena uspešnosti:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Datum završetka:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Datum početka:";
            // 
            // numOcekivanoTrajanje
            // 
            this.numOcekivanoTrajanje.Location = new System.Drawing.Point(198, 207);
            this.numOcekivanoTrajanje.Name = "numOcekivanoTrajanje";
            this.numOcekivanoTrajanje.Size = new System.Drawing.Size(54, 20);
            this.numOcekivanoTrajanje.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Očekivano trajanje u danima:";
            // 
            // numBrojUcesnika
            // 
            this.numBrojUcesnika.Location = new System.Drawing.Point(198, 181);
            this.numBrojUcesnika.Name = "numBrojUcesnika";
            this.numBrojUcesnika.Size = new System.Drawing.Size(54, 20);
            this.numBrojUcesnika.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Broj potrebnih učesnika:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nadzadatak:";
            // 
            // cmbNadzadatak
            // 
            this.cmbNadzadatak.FormattingEnabled = true;
            this.cmbNadzadatak.Location = new System.Drawing.Point(80, 154);
            this.cmbNadzadatak.Name = "cmbNadzadatak";
            this.cmbNadzadatak.Size = new System.Drawing.Size(172, 21);
            this.cmbNadzadatak.TabIndex = 8;
            // 
            // gbEvakuacija
            // 
            this.gbEvakuacija.Controls.Add(this.numBrOsobaEvakuacije);
            this.gbEvakuacija.Controls.Add(this.label12);
            this.gbEvakuacija.Controls.Add(this.label13);
            this.gbEvakuacija.Controls.Add(this.txtOblastEvakuacije);
            this.gbEvakuacija.Location = new System.Drawing.Point(287, 61);
            this.gbEvakuacija.Name = "gbEvakuacija";
            this.gbEvakuacija.Size = new System.Drawing.Size(230, 88);
            this.gbEvakuacija.TabIndex = 9;
            this.gbEvakuacija.TabStop = false;
            this.gbEvakuacija.Text = "Evakuacija";
            this.gbEvakuacija.Visible = false;
            // 
            // numBrOsobaEvakuacije
            // 
            this.numBrOsobaEvakuacije.Location = new System.Drawing.Point(170, 49);
            this.numBrOsobaEvakuacije.Name = "numBrOsobaEvakuacije";
            this.numBrOsobaEvakuacije.Size = new System.Drawing.Size(54, 20);
            this.numBrOsobaEvakuacije.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Oblast evakuacije:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Broj osoba za evakuaciju:";
            // 
            // txtOblastEvakuacije
            // 
            this.txtOblastEvakuacije.Location = new System.Drawing.Point(107, 23);
            this.txtOblastEvakuacije.Name = "txtOblastEvakuacije";
            this.txtOblastEvakuacije.Size = new System.Drawing.Size(117, 20);
            this.txtOblastEvakuacije.TabIndex = 19;
            // 
            // gbMedIntervencija
            // 
            this.gbMedIntervencija.Controls.Add(this.numStepenKriticnosti);
            this.gbMedIntervencija.Controls.Add(this.label15);
            this.gbMedIntervencija.Controls.Add(this.label14);
            this.gbMedIntervencija.Controls.Add(this.numBrojPovredjenih);
            this.gbMedIntervencija.Location = new System.Drawing.Point(287, 155);
            this.gbMedIntervencija.Name = "gbMedIntervencija";
            this.gbMedIntervencija.Size = new System.Drawing.Size(230, 85);
            this.gbMedIntervencija.TabIndex = 10;
            this.gbMedIntervencija.TabStop = false;
            this.gbMedIntervencija.Text = "Medicinska intervencija";
            this.gbMedIntervencija.Visible = false;
            // 
            // numStepenKriticnosti
            // 
            this.numStepenKriticnosti.Location = new System.Drawing.Point(170, 49);
            this.numStepenKriticnosti.Name = "numStepenKriticnosti";
            this.numStepenKriticnosti.Size = new System.Drawing.Size(54, 20);
            this.numStepenKriticnosti.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Broj povređenih:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Stepen kritičnosti:";
            // 
            // numBrojPovredjenih
            // 
            this.numBrojPovredjenih.Location = new System.Drawing.Point(170, 23);
            this.numBrojPovredjenih.Name = "numBrojPovredjenih";
            this.numBrojPovredjenih.Size = new System.Drawing.Size(54, 20);
            this.numBrojPovredjenih.TabIndex = 13;
            // 
            // gbEksperiment
            // 
            this.gbEksperiment.Controls.Add(this.label16);
            this.gbEksperiment.Controls.Add(this.txtNivoOpasnosti);
            this.gbEksperiment.Location = new System.Drawing.Point(287, 242);
            this.gbEksperiment.Name = "gbEksperiment";
            this.gbEksperiment.Size = new System.Drawing.Size(230, 57);
            this.gbEksperiment.TabIndex = 10;
            this.gbEksperiment.TabStop = false;
            this.gbEksperiment.Text = "Eksperiment";
            this.gbEksperiment.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Nivo opasnosti:";
            // 
            // txtNivoOpasnosti
            // 
            this.txtNivoOpasnosti.Location = new System.Drawing.Point(107, 16);
            this.txtNivoOpasnosti.Name = "txtNivoOpasnosti";
            this.txtNivoOpasnosti.Size = new System.Drawing.Size(117, 20);
            this.txtNivoOpasnosti.TabIndex = 21;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(11, 530);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(110, 27);
            this.btnSacuvaj.TabIndex = 11;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnAngazuj
            // 
            this.btnAngazuj.Location = new System.Drawing.Point(407, 530);
            this.btnAngazuj.Name = "btnAngazuj";
            this.btnAngazuj.Size = new System.Drawing.Size(110, 27);
            this.btnAngazuj.TabIndex = 12;
            this.btnAngazuj.Text = "Angažuj učesnika";
            this.btnAngazuj.UseVisualStyleBackColor = true;
            this.btnAngazuj.Click += new System.EventHandler(this.btnAngazuj_Click);
            // 
            // listViewAngazovani
            // 
            this.listViewAngazovani.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader1});
            this.listViewAngazovani.HideSelection = false;
            this.listViewAngazovani.Location = new System.Drawing.Point(287, 394);
            this.listViewAngazovani.Name = "listViewAngazovani";
            this.listViewAngazovani.Size = new System.Drawing.Size(230, 124);
            this.listViewAngazovani.TabIndex = 13;
            this.listViewAngazovani.UseCompatibleStateImageBehavior = false;
            this.listViewAngazovani.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Tip";
            this.ID.Width = 110;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Naziv";
            this.columnHeader1.Width = 110;
            // 
            // DodajIzmenizadatakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 569);
            this.Controls.Add(this.listViewAngazovani);
            this.Controls.Add(this.btnAngazuj);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.gbEksperiment);
            this.Controls.Add(this.gbMedIntervencija);
            this.Controls.Add(this.gbEvakuacija);
            this.Controls.Add(this.gbOpstiPodaci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipZad);
            this.Name = "DodajIzmenizadatakForm";
            this.Text = "DodajIzmenizadatakForm";
            this.Load += new System.EventHandler(this.DodajIzmenizadatakForm_Load);
            this.gbOpstiPodaci.ResumeLayout(false);
            this.gbOpstiPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOcenaUspesnosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOcekivanoTrajanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojUcesnika)).EndInit();
            this.gbEvakuacija.ResumeLayout(false);
            this.gbEvakuacija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrOsobaEvakuacije)).EndInit();
            this.gbMedIntervencija.ResumeLayout(false);
            this.gbMedIntervencija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStepenKriticnosti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojPovredjenih)).EndInit();
            this.gbEksperiment.ResumeLayout(false);
            this.gbEksperiment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpisCilja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.ComboBox cmbTipZad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbOpstiPodaci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNadzadatak;
        private System.Windows.Forms.NumericUpDown numOcekivanoTrajanje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numBrojUcesnika;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numOcenaUspesnosti;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetka;
        private System.Windows.Forms.CheckedListBox clbSpecijalizacije;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDatumZavrsetka;
        private System.Windows.Forms.CheckBox chkDatumZav;
        private System.Windows.Forms.GroupBox gbEvakuacija;
        private System.Windows.Forms.GroupBox gbMedIntervencija;
        private System.Windows.Forms.GroupBox gbEksperiment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOblastEvakuacije;
        private System.Windows.Forms.NumericUpDown numBrOsobaEvakuacije;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numStepenKriticnosti;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numBrojPovredjenih;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNivoOpasnosti;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnAngazuj;
        private System.Windows.Forms.ListView listViewAngazovani;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}