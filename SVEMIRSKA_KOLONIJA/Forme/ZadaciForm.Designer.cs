namespace SVEMIRSKA_KOLONIJA.Forme
{
    partial class ZadaciForm
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
            this.listViewZadaci = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajZad = new System.Windows.Forms.Button();
            this.btnIzmeniZad = new System.Windows.Forms.Button();
            this.btnObrisiZad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewZadaci
            // 
            this.listViewZadaci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewZadaci.FullRowSelect = true;
            this.listViewZadaci.GridLines = true;
            this.listViewZadaci.HideSelection = false;
            this.listViewZadaci.Location = new System.Drawing.Point(12, 12);
            this.listViewZadaci.Name = "listViewZadaci";
            this.listViewZadaci.Size = new System.Drawing.Size(466, 290);
            this.listViewZadaci.TabIndex = 0;
            this.listViewZadaci.UseCompatibleStateImageBehavior = false;
            this.listViewZadaci.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Opis cilja";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip zadatka";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum Pocetka";
            this.columnHeader4.Width = 120;
            // 
            // btnDodajZad
            // 
            this.btnDodajZad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajZad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDodajZad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajZad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajZad.Location = new System.Drawing.Point(497, 179);
            this.btnDodajZad.Name = "btnDodajZad";
            this.btnDodajZad.Size = new System.Drawing.Size(96, 31);
            this.btnDodajZad.TabIndex = 1;
            this.btnDodajZad.Text = "Dodaj Zadatak";
            this.btnDodajZad.UseVisualStyleBackColor = false;
            this.btnDodajZad.Click += new System.EventHandler(this.btnDodajZad_Click);
            // 
            // btnIzmeniZad
            // 
            this.btnIzmeniZad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIzmeniZad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnIzmeniZad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnIzmeniZad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzmeniZad.Location = new System.Drawing.Point(497, 225);
            this.btnIzmeniZad.Name = "btnIzmeniZad";
            this.btnIzmeniZad.Size = new System.Drawing.Size(96, 31);
            this.btnIzmeniZad.TabIndex = 2;
            this.btnIzmeniZad.Text = "Izmeni Zadatak";
            this.btnIzmeniZad.UseVisualStyleBackColor = false;
            this.btnIzmeniZad.Click += new System.EventHandler(this.btnIzmeniZad_Click);
            // 
            // btnObrisiZad
            // 
            this.btnObrisiZad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnObrisiZad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnObrisiZad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnObrisiZad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiZad.Location = new System.Drawing.Point(497, 271);
            this.btnObrisiZad.Name = "btnObrisiZad";
            this.btnObrisiZad.Size = new System.Drawing.Size(96, 31);
            this.btnObrisiZad.TabIndex = 3;
            this.btnObrisiZad.Text = "Obrisi Zadatak";
            this.btnObrisiZad.UseVisualStyleBackColor = false;
            // 
            // ZadaciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(609, 324);
            this.Controls.Add(this.btnObrisiZad);
            this.Controls.Add(this.btnIzmeniZad);
            this.Controls.Add(this.btnDodajZad);
            this.Controls.Add(this.listViewZadaci);
            this.Name = "ZadaciForm";
            this.Text = "ZadaciForm";
            this.Load += new System.EventHandler(this.ZadaciForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewZadaci;
        private System.Windows.Forms.Button btnDodajZad;
        private System.Windows.Forms.Button btnIzmeniZad;
        private System.Windows.Forms.Button btnObrisiZad;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}