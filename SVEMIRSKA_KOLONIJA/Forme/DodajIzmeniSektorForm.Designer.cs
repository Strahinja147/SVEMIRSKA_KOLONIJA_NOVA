namespace SVEMIRSKA_KOLONIJA.Forme
{
    partial class DodajIzmeniSektorForm
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
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelKapacitet = new System.Windows.Forms.Label();
            this.labelPovrsina = new System.Windows.Forms.Label();
            this.labelVodja = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.txtPovrsina = new System.Windows.Forms.TextBox();
            this.txtVodjaSektora = new System.Windows.Forms.TextBox();
            this.btnDodeliVodju = new System.Windows.Forms.Button();
            this.gbRadnici = new System.Windows.Forms.GroupBox();
            this.lvRadnici = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodeliRadnika = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.btnUkloniRadnika = new System.Windows.Forms.Button();
            this.cmbTipSektora = new System.Windows.Forms.ComboBox();
            this.gbRadnici.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.Location = new System.Drawing.Point(12, 21);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(43, 13);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.Location = new System.Drawing.Point(12, 65);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(75, 13);
            this.labelTip.TabIndex = 1;
            this.labelTip.Text = "Tip sektora:";
            // 
            // labelKapacitet
            // 
            this.labelKapacitet.AutoSize = true;
            this.labelKapacitet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKapacitet.Location = new System.Drawing.Point(12, 108);
            this.labelKapacitet.Name = "labelKapacitet";
            this.labelKapacitet.Size = new System.Drawing.Size(65, 13);
            this.labelKapacitet.TabIndex = 2;
            this.labelKapacitet.Text = "Kapacitet:";
            // 
            // labelPovrsina
            // 
            this.labelPovrsina.AutoSize = true;
            this.labelPovrsina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPovrsina.Location = new System.Drawing.Point(12, 143);
            this.labelPovrsina.Name = "labelPovrsina";
            this.labelPovrsina.Size = new System.Drawing.Size(85, 13);
            this.labelPovrsina.TabIndex = 3;
            this.labelPovrsina.Text = "Površina (m²):";
            // 
            // labelVodja
            // 
            this.labelVodja.AutoSize = true;
            this.labelVodja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVodja.Location = new System.Drawing.Point(12, 187);
            this.labelVodja.Name = "labelVodja";
            this.labelVodja.Size = new System.Drawing.Size(87, 13);
            this.labelVodja.TabIndex = 4;
            this.labelVodja.Text = "Vođa sektora:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.LightGray;
            this.txtNaziv.Location = new System.Drawing.Point(139, 18);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(166, 20);
            this.txtNaziv.TabIndex = 5;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.BackColor = System.Drawing.Color.LightGray;
            this.txtKapacitet.Location = new System.Drawing.Point(139, 101);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(166, 20);
            this.txtKapacitet.TabIndex = 7;
            // 
            // txtPovrsina
            // 
            this.txtPovrsina.BackColor = System.Drawing.Color.LightGray;
            this.txtPovrsina.Location = new System.Drawing.Point(139, 140);
            this.txtPovrsina.Name = "txtPovrsina";
            this.txtPovrsina.Size = new System.Drawing.Size(166, 20);
            this.txtPovrsina.TabIndex = 8;
            // 
            // txtVodjaSektora
            // 
            this.txtVodjaSektora.BackColor = System.Drawing.Color.LightGray;
            this.txtVodjaSektora.Location = new System.Drawing.Point(139, 184);
            this.txtVodjaSektora.Name = "txtVodjaSektora";
            this.txtVodjaSektora.ReadOnly = true;
            this.txtVodjaSektora.Size = new System.Drawing.Size(166, 20);
            this.txtVodjaSektora.TabIndex = 9;
            // 
            // btnDodeliVodju
            // 
            this.btnDodeliVodju.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodeliVodju.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDodeliVodju.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnDodeliVodju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodeliVodju.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodeliVodju.Location = new System.Drawing.Point(331, 182);
            this.btnDodeliVodju.Name = "btnDodeliVodju";
            this.btnDodeliVodju.Size = new System.Drawing.Size(101, 23);
            this.btnDodeliVodju.TabIndex = 10;
            this.btnDodeliVodju.Text = "Izaberi vođu...";
            this.btnDodeliVodju.UseVisualStyleBackColor = false;
            this.btnDodeliVodju.Click += new System.EventHandler(this.btnDodeliVodju_Click);
            // 
            // gbRadnici
            // 
            this.gbRadnici.Controls.Add(this.lvRadnici);
            this.gbRadnici.Location = new System.Drawing.Point(15, 235);
            this.gbRadnici.Name = "gbRadnici";
            this.gbRadnici.Size = new System.Drawing.Size(309, 187);
            this.gbRadnici.TabIndex = 11;
            this.gbRadnici.TabStop = false;
            this.gbRadnici.Text = "Radnici u sektoru";
            // 
            // lvRadnici
            // 
            this.lvRadnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Ime,
            this.Prezime});
            this.lvRadnici.FullRowSelect = true;
            this.lvRadnici.GridLines = true;
            this.lvRadnici.HideSelection = false;
            this.lvRadnici.Location = new System.Drawing.Point(6, 19);
            this.lvRadnici.Name = "lvRadnici";
            this.lvRadnici.Size = new System.Drawing.Size(295, 162);
            this.lvRadnici.TabIndex = 0;
            this.lvRadnici.UseCompatibleStateImageBehavior = false;
            this.lvRadnici.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 50;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 120;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 120;
            // 
            // btnDodeliRadnika
            // 
            this.btnDodeliRadnika.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodeliRadnika.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDodeliRadnika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnDodeliRadnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodeliRadnika.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodeliRadnika.Location = new System.Drawing.Point(331, 254);
            this.btnDodeliRadnika.Name = "btnDodeliRadnika";
            this.btnDodeliRadnika.Size = new System.Drawing.Size(101, 43);
            this.btnDodeliRadnika.TabIndex = 12;
            this.btnDodeliRadnika.Text = "Dodeli radnika";
            this.btnDodeliRadnika.UseVisualStyleBackColor = false;
            this.btnDodeliRadnika.Click += new System.EventHandler(this.btnDodeliRadnika_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSnimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSnimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSnimi.Location = new System.Drawing.Point(331, 373);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(101, 43);
            this.btnSnimi.TabIndex = 13;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // btnUkloniRadnika
            // 
            this.btnUkloniRadnika.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUkloniRadnika.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnUkloniRadnika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloniRadnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUkloniRadnika.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUkloniRadnika.Location = new System.Drawing.Point(331, 312);
            this.btnUkloniRadnika.Name = "btnUkloniRadnika";
            this.btnUkloniRadnika.Size = new System.Drawing.Size(101, 43);
            this.btnUkloniRadnika.TabIndex = 14;
            this.btnUkloniRadnika.Text = "Ukloni radnika";
            this.btnUkloniRadnika.UseVisualStyleBackColor = false;
            this.btnUkloniRadnika.Click += new System.EventHandler(this.btnUkloniRadnika_Click);
            // 
            // cmbTipSektora
            // 
            this.cmbTipSektora.BackColor = System.Drawing.Color.LightGray;
            this.cmbTipSektora.FormattingEnabled = true;
            this.cmbTipSektora.Items.AddRange(new object[] {
            "Laboratorija ",
            "Biosfera ",
            "Spavaonica ",
            "Upravni centar",
            "Magacin"});
            this.cmbTipSektora.Location = new System.Drawing.Point(139, 62);
            this.cmbTipSektora.Name = "cmbTipSektora";
            this.cmbTipSektora.Size = new System.Drawing.Size(166, 21);
            this.cmbTipSektora.TabIndex = 15;
            // 
            // DodajIzmeniSektorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.cmbTipSektora);
            this.Controls.Add(this.btnUkloniRadnika);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.btnDodeliRadnika);
            this.Controls.Add(this.gbRadnici);
            this.Controls.Add(this.btnDodeliVodju);
            this.Controls.Add(this.txtVodjaSektora);
            this.Controls.Add(this.txtPovrsina);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.labelVodja);
            this.Controls.Add(this.labelPovrsina);
            this.Controls.Add(this.labelKapacitet);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelNaziv);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "DodajIzmeniSektorForm";
            this.Text = "DodajIzmeniSektorForm";
            this.Load += new System.EventHandler(this.DodajIzmeniSektorForm_Load);
            this.gbRadnici.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelKapacitet;
        private System.Windows.Forms.Label labelPovrsina;
        private System.Windows.Forms.Label labelVodja;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtPovrsina;
        private System.Windows.Forms.TextBox txtVodjaSektora;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.Button btnDodeliVodju;
        private System.Windows.Forms.GroupBox gbRadnici;
        private System.Windows.Forms.ListView lvRadnici;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.Button btnDodeliRadnika;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Button btnUkloniRadnika;
        private System.Windows.Forms.ComboBox cmbTipSektora;
    }
}