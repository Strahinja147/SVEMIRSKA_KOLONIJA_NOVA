namespace SVEMIRSKA_KOLONIJA.Forme
{
    partial class DodajIzmeniResursForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.cbxSkladiste = new System.Windows.Forms.ComboBox();
            this.lvUpravitelji = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnDodeliUpravitelja = new System.Windows.Forms.Button();
            this.lblUpravitelji = new System.Windows.Forms.Label();
            this.btnUkloniUpravitelja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trenutna količina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sektor:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.Color.LightGray;
            this.txtNaziv.Location = new System.Drawing.Point(141, 33);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(145, 20);
            this.txtNaziv.TabIndex = 3;
            // 
            // numKolicina
            // 
            this.numKolicina.BackColor = System.Drawing.Color.LightGray;
            this.numKolicina.Location = new System.Drawing.Point(141, 84);
            this.numKolicina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numKolicina.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(144, 20);
            this.numKolicina.TabIndex = 4;
            // 
            // cbxSkladiste
            // 
            this.cbxSkladiste.BackColor = System.Drawing.Color.LightGray;
            this.cbxSkladiste.FormattingEnabled = true;
            this.cbxSkladiste.Location = new System.Drawing.Point(141, 140);
            this.cbxSkladiste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSkladiste.Name = "cbxSkladiste";
            this.cbxSkladiste.Size = new System.Drawing.Size(145, 21);
            this.cbxSkladiste.TabIndex = 5;
            // 
            // lvUpravitelji
            // 
            this.lvUpravitelji.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Ime,
            this.Prezime});
            this.lvUpravitelji.FullRowSelect = true;
            this.lvUpravitelji.GridLines = true;
            this.lvUpravitelji.HideSelection = false;
            this.lvUpravitelji.Location = new System.Drawing.Point(11, 224);
            this.lvUpravitelji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvUpravitelji.MultiSelect = false;
            this.lvUpravitelji.Name = "lvUpravitelji";
            this.lvUpravitelji.Scrollable = false;
            this.lvUpravitelji.Size = new System.Drawing.Size(275, 200);
            this.lvUpravitelji.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvUpravitelji.TabIndex = 7;
            this.lvUpravitelji.UseCompatibleStateImageBehavior = false;
            this.lvUpravitelji.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 114;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 143;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSacuvaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSacuvaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSacuvaj.Location = new System.Drawing.Point(301, 366);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(112, 57);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnDodeliUpravitelja
            // 
            this.btnDodeliUpravitelja.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodeliUpravitelja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDodeliUpravitelja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnDodeliUpravitelja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodeliUpravitelja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodeliUpravitelja.Location = new System.Drawing.Point(301, 224);
            this.btnDodeliUpravitelja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodeliUpravitelja.Name = "btnDodeliUpravitelja";
            this.btnDodeliUpravitelja.Size = new System.Drawing.Size(112, 57);
            this.btnDodeliUpravitelja.TabIndex = 9;
            this.btnDodeliUpravitelja.Text = "Dodeli upravitelja";
            this.btnDodeliUpravitelja.UseVisualStyleBackColor = false;
            this.btnDodeliUpravitelja.Click += new System.EventHandler(this.btnDodeliUpravitelja_Click);
            // 
            // lblUpravitelji
            // 
            this.lblUpravitelji.AutoSize = true;
            this.lblUpravitelji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpravitelji.Location = new System.Drawing.Point(13, 192);
            this.lblUpravitelji.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpravitelji.Name = "lblUpravitelji";
            this.lblUpravitelji.Size = new System.Drawing.Size(113, 13);
            this.lblUpravitelji.TabIndex = 10;
            this.lblUpravitelji.Text = "Upravitelji resursa:";
            // 
            // btnUkloniUpravitelja
            // 
            this.btnUkloniUpravitelja.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUkloniUpravitelja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnUkloniUpravitelja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnUkloniUpravitelja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUkloniUpravitelja.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUkloniUpravitelja.Location = new System.Drawing.Point(301, 296);
            this.btnUkloniUpravitelja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUkloniUpravitelja.Name = "btnUkloniUpravitelja";
            this.btnUkloniUpravitelja.Size = new System.Drawing.Size(112, 57);
            this.btnUkloniUpravitelja.TabIndex = 11;
            this.btnUkloniUpravitelja.Text = "Ukloni upravitelja";
            this.btnUkloniUpravitelja.UseVisualStyleBackColor = false;
            this.btnUkloniUpravitelja.Click += new System.EventHandler(this.btnUkloniUpravitelja_Click);
            // 
            // DodajIzmeniResursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(432, 461);
            this.Controls.Add(this.btnUkloniUpravitelja);
            this.Controls.Add(this.lblUpravitelji);
            this.Controls.Add(this.lvUpravitelji);
            this.Controls.Add(this.btnDodeliUpravitelja);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbxSkladiste);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DodajIzmeniResursForm";
            this.Text = "DodajIzmeniResursForm";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.ComboBox cbxSkladiste;
        private System.Windows.Forms.ListView lvUpravitelji;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnDodeliUpravitelja;
        private System.Windows.Forms.Label lblUpravitelji;
        private System.Windows.Forms.Button btnUkloniUpravitelja;
    }
}