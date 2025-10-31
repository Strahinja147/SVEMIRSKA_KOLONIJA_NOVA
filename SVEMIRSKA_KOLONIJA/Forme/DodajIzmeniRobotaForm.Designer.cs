namespace SVEMIRSKA_KOLONIJA.Forme
{
    partial class DodajIzmeniRobotaForm
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
            this.labelSifra = new System.Windows.Forms.Label();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelOdgovorni = new System.Windows.Forms.Label();
            this.labelProgramer = new System.Windows.Forms.Label();
            this.labelSektor = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtOdgovorni = new System.Windows.Forms.TextBox();
            this.txtProgramer = new System.Windows.Forms.TextBox();
            this.cmbSektor = new System.Windows.Forms.ComboBox();
            this.btnIzaberiOdgovornog = new System.Windows.Forms.Button();
            this.btnIzaberiProgramera = new System.Windows.Forms.Button();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.cmbTipRobota = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSifra.Location = new System.Drawing.Point(14, 50);
            this.labelSifra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(37, 13);
            this.labelSifra.TabIndex = 0;
            this.labelSifra.Text = "Šifra:";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.Location = new System.Drawing.Point(14, 83);
            this.labelTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(29, 13);
            this.labelTip.TabIndex = 1;
            this.labelTip.Text = "Tip:";
            // 
            // labelOdgovorni
            // 
            this.labelOdgovorni.AutoSize = true;
            this.labelOdgovorni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOdgovorni.Location = new System.Drawing.Point(14, 115);
            this.labelOdgovorni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOdgovorni.Name = "labelOdgovorni";
            this.labelOdgovorni.Size = new System.Drawing.Size(128, 13);
            this.labelOdgovorni.TabIndex = 2;
            this.labelOdgovorni.Text = "Odgovorni stanovnik:";
            // 
            // labelProgramer
            // 
            this.labelProgramer.AutoSize = true;
            this.labelProgramer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgramer.Location = new System.Drawing.Point(14, 145);
            this.labelProgramer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgramer.Name = "labelProgramer";
            this.labelProgramer.Size = new System.Drawing.Size(68, 13);
            this.labelProgramer.TabIndex = 3;
            this.labelProgramer.Text = "Programer:";
            // 
            // labelSektor
            // 
            this.labelSektor.AutoSize = true;
            this.labelSektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSektor.Location = new System.Drawing.Point(14, 177);
            this.labelSektor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSektor.Name = "labelSektor";
            this.labelSektor.Size = new System.Drawing.Size(48, 13);
            this.labelSektor.TabIndex = 4;
            this.labelSektor.Text = "Sektor:";
            // 
            // txtSifra
            // 
            this.txtSifra.BackColor = System.Drawing.Color.LightGray;
            this.txtSifra.Location = new System.Drawing.Point(170, 47);
            this.txtSifra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(198, 20);
            this.txtSifra.TabIndex = 5;
            // 
            // txtOdgovorni
            // 
            this.txtOdgovorni.BackColor = System.Drawing.Color.LightGray;
            this.txtOdgovorni.Location = new System.Drawing.Point(170, 112);
            this.txtOdgovorni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOdgovorni.Name = "txtOdgovorni";
            this.txtOdgovorni.ReadOnly = true;
            this.txtOdgovorni.Size = new System.Drawing.Size(198, 20);
            this.txtOdgovorni.TabIndex = 7;
            // 
            // txtProgramer
            // 
            this.txtProgramer.BackColor = System.Drawing.Color.LightGray;
            this.txtProgramer.Location = new System.Drawing.Point(170, 142);
            this.txtProgramer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProgramer.Name = "txtProgramer";
            this.txtProgramer.ReadOnly = true;
            this.txtProgramer.Size = new System.Drawing.Size(198, 20);
            this.txtProgramer.TabIndex = 8;
            // 
            // cmbSektor
            // 
            this.cmbSektor.BackColor = System.Drawing.Color.LightGray;
            this.cmbSektor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSektor.FormattingEnabled = true;
            this.cmbSektor.Location = new System.Drawing.Point(170, 174);
            this.cmbSektor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSektor.Name = "cmbSektor";
            this.cmbSektor.Size = new System.Drawing.Size(198, 21);
            this.cmbSektor.TabIndex = 9;
            // 
            // btnIzaberiOdgovornog
            // 
            this.btnIzaberiOdgovornog.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIzaberiOdgovornog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnIzaberiOdgovornog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnIzaberiOdgovornog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzaberiOdgovornog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzaberiOdgovornog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzaberiOdgovornog.Location = new System.Drawing.Point(394, 109);
            this.btnIzaberiOdgovornog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIzaberiOdgovornog.Name = "btnIzaberiOdgovornog";
            this.btnIzaberiOdgovornog.Size = new System.Drawing.Size(152, 24);
            this.btnIzaberiOdgovornog.TabIndex = 11;
            this.btnIzaberiOdgovornog.Text = "Izaberi odgovornog...";
            this.btnIzaberiOdgovornog.UseVisualStyleBackColor = false;
            this.btnIzaberiOdgovornog.Click += new System.EventHandler(this.btnIzaberiOdgovornog_Click);
            // 
            // btnIzaberiProgramera
            // 
            this.btnIzaberiProgramera.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIzaberiProgramera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnIzaberiProgramera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnIzaberiProgramera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzaberiProgramera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzaberiProgramera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzaberiProgramera.Location = new System.Drawing.Point(394, 139);
            this.btnIzaberiProgramera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIzaberiProgramera.Name = "btnIzaberiProgramera";
            this.btnIzaberiProgramera.Size = new System.Drawing.Size(152, 24);
            this.btnIzaberiProgramera.TabIndex = 12;
            this.btnIzaberiProgramera.Text = "Izaberi programera...";
            this.btnIzaberiProgramera.UseVisualStyleBackColor = false;
            this.btnIzaberiProgramera.Click += new System.EventHandler(this.btnIzaberiProgramera_Click);
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSnimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSnimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSnimi.Location = new System.Drawing.Point(197, 214);
            this.btnSnimi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(130, 49);
            this.btnSnimi.TabIndex = 13;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // cmbTipRobota
            // 
            this.cmbTipRobota.BackColor = System.Drawing.Color.LightGray;
            this.cmbTipRobota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipRobota.FormattingEnabled = true;
            this.cmbTipRobota.Items.AddRange(new object[] {
            "Transportni",
            "Inženjerski",
            "Medicinski",
            "Nadzorni"});
            this.cmbTipRobota.Location = new System.Drawing.Point(170, 80);
            this.cmbTipRobota.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTipRobota.Name = "cmbTipRobota";
            this.cmbTipRobota.Size = new System.Drawing.Size(198, 21);
            this.cmbTipRobota.TabIndex = 14;
            // 
            // DodajIzmeniRobotaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(576, 284);
            this.Controls.Add(this.cmbTipRobota);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.btnIzaberiProgramera);
            this.Controls.Add(this.btnIzaberiOdgovornog);
            this.Controls.Add(this.cmbSektor);
            this.Controls.Add(this.txtProgramer);
            this.Controls.Add(this.txtOdgovorni);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.labelSektor);
            this.Controls.Add(this.labelProgramer);
            this.Controls.Add(this.labelOdgovorni);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.labelSifra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DodajIzmeniRobotaForm";
            this.Text = "DodajIzmeniRobotaForm";
            this.Load += new System.EventHandler(this.DodajIzmeniRobotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelOdgovorni;
        private System.Windows.Forms.Label labelProgramer;
        private System.Windows.Forms.Label labelSektor;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtOdgovorni;
        private System.Windows.Forms.TextBox txtProgramer;
        private System.Windows.Forms.ComboBox cmbSektor;
        private System.Windows.Forms.Button btnIzaberiOdgovornog;
        private System.Windows.Forms.Button btnIzaberiProgramera;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.ComboBox cmbTipRobota;
    }
}