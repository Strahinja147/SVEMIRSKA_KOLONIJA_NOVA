namespace SVEMIRSKA_KOLONIJA.Forme
{
    partial class DodajSpecijalizacijuStanovnikuForm
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
            this.labelSpecijalizacija = new System.Windows.Forms.Label();
            this.labelNivo = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelInstitucija = new System.Windows.Forms.Label();
            this.cmbSpecijalizacija = new System.Windows.Forms.ComboBox();
            this.dtpDatumSticanja = new System.Windows.Forms.DateTimePicker();
            this.txtInstitucija = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.cmbNivoEks = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelSpecijalizacija
            // 
            this.labelSpecijalizacija.AutoSize = true;
            this.labelSpecijalizacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpecijalizacija.Location = new System.Drawing.Point(12, 31);
            this.labelSpecijalizacija.Name = "labelSpecijalizacija";
            this.labelSpecijalizacija.Size = new System.Drawing.Size(92, 13);
            this.labelSpecijalizacija.TabIndex = 0;
            this.labelSpecijalizacija.Text = "Specijalizacija:";
            this.labelSpecijalizacija.Click += new System.EventHandler(this.labelSpecijalizacija_Click);
            // 
            // labelNivo
            // 
            this.labelNivo.AutoSize = true;
            this.labelNivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivo.Location = new System.Drawing.Point(12, 73);
            this.labelNivo.Name = "labelNivo";
            this.labelNivo.Size = new System.Drawing.Size(99, 13);
            this.labelNivo.TabIndex = 1;
            this.labelNivo.Text = "Nivo ekspertize:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.Location = new System.Drawing.Point(12, 115);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(95, 13);
            this.labelDatum.TabIndex = 2;
            this.labelDatum.Text = "Datum sticanja:";
            // 
            // labelInstitucija
            // 
            this.labelInstitucija.AutoSize = true;
            this.labelInstitucija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstitucija.Location = new System.Drawing.Point(12, 159);
            this.labelInstitucija.Name = "labelInstitucija";
            this.labelInstitucija.Size = new System.Drawing.Size(66, 13);
            this.labelInstitucija.TabIndex = 3;
            this.labelInstitucija.Text = "Institucija:";
            // 
            // cmbSpecijalizacija
            // 
            this.cmbSpecijalizacija.BackColor = System.Drawing.Color.LightGray;
            this.cmbSpecijalizacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecijalizacija.FormattingEnabled = true;
            this.cmbSpecijalizacija.Location = new System.Drawing.Point(150, 28);
            this.cmbSpecijalizacija.Name = "cmbSpecijalizacija";
            this.cmbSpecijalizacija.Size = new System.Drawing.Size(179, 21);
            this.cmbSpecijalizacija.TabIndex = 4;
            this.cmbSpecijalizacija.TabStop = false;
            // 
            // dtpDatumSticanja
            // 
            this.dtpDatumSticanja.Location = new System.Drawing.Point(150, 109);
            this.dtpDatumSticanja.Name = "dtpDatumSticanja";
            this.dtpDatumSticanja.Size = new System.Drawing.Size(179, 20);
            this.dtpDatumSticanja.TabIndex = 6;
            // 
            // txtInstitucija
            // 
            this.txtInstitucija.BackColor = System.Drawing.Color.LightGray;
            this.txtInstitucija.Location = new System.Drawing.Point(150, 156);
            this.txtInstitucija.Name = "txtInstitucija";
            this.txtInstitucija.Size = new System.Drawing.Size(179, 20);
            this.txtInstitucija.TabIndex = 7;
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSnimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSnimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSnimi.Location = new System.Drawing.Point(243, 194);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(86, 32);
            this.btnSnimi.TabIndex = 8;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // cmbNivoEks
            // 
            this.cmbNivoEks.BackColor = System.Drawing.Color.LightGray;
            this.cmbNivoEks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivoEks.FormattingEnabled = true;
            this.cmbNivoEks.Items.AddRange(new object[] {
            "Osnovni",
            "Srednji",
            "Napredni"});
            this.cmbNivoEks.Location = new System.Drawing.Point(150, 70);
            this.cmbNivoEks.Name = "cmbNivoEks";
            this.cmbNivoEks.Size = new System.Drawing.Size(179, 21);
            this.cmbNivoEks.TabIndex = 9;
            this.cmbNivoEks.TabStop = false;
            // 
            // DodajSpecijalizacijuStanovnikuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(347, 245);
            this.Controls.Add(this.cmbNivoEks);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtInstitucija);
            this.Controls.Add(this.dtpDatumSticanja);
            this.Controls.Add(this.cmbSpecijalizacija);
            this.Controls.Add(this.labelInstitucija);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelNivo);
            this.Controls.Add(this.labelSpecijalizacija);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "DodajSpecijalizacijuStanovnikuForm";
            this.Text = "DodajSpecijalizacijuStanovnikuForm";
            this.Load += new System.EventHandler(this.DodajSpecijalizacijuStanovnikuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpecijalizacija;
        private System.Windows.Forms.Label labelNivo;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelInstitucija;
        private System.Windows.Forms.ComboBox cmbSpecijalizacija;
        private System.Windows.Forms.DateTimePicker dtpDatumSticanja;
        private System.Windows.Forms.TextBox txtInstitucija;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ComboBox cmbNivoEks;
    }
}