namespace SVEMIRSKA_KOLONIJA.Forme
{
    partial class DodajKontaktForm
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
            this.labelIme = new System.Windows.Forms.Label();
            this.labelOdnos = new System.Windows.Forms.Label();
            this.gbKontaktInfo = new System.Windows.Forms.GroupBox();
            this.lbKontaktInformacije = new System.Windows.Forms.ListBox();
            this.btnDodajInfo = new System.Windows.Forms.Button();
            this.txtKontaktInfo = new System.Windows.Forms.TextBox();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtOdnos = new System.Windows.Forms.TextBox();
            this.gbKontaktInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIme.Location = new System.Drawing.Point(12, 37);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(85, 13);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime kontakta:";
            // 
            // labelOdnos
            // 
            this.labelOdnos.AutoSize = true;
            this.labelOdnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOdnos.Location = new System.Drawing.Point(12, 79);
            this.labelOdnos.Name = "labelOdnos";
            this.labelOdnos.Size = new System.Drawing.Size(47, 13);
            this.labelOdnos.TabIndex = 1;
            this.labelOdnos.Text = "Odnos:";
            // 
            // gbKontaktInfo
            // 
            this.gbKontaktInfo.Controls.Add(this.lbKontaktInformacije);
            this.gbKontaktInfo.Controls.Add(this.btnDodajInfo);
            this.gbKontaktInfo.Controls.Add(this.txtKontaktInfo);
            this.gbKontaktInfo.Location = new System.Drawing.Point(15, 121);
            this.gbKontaktInfo.Name = "gbKontaktInfo";
            this.gbKontaktInfo.Size = new System.Drawing.Size(390, 317);
            this.gbKontaktInfo.TabIndex = 2;
            this.gbKontaktInfo.TabStop = false;
            this.gbKontaktInfo.Text = "Kontakt informacije";
            // 
            // lbKontaktInformacije
            // 
            this.lbKontaktInformacije.FormattingEnabled = true;
            this.lbKontaktInformacije.Location = new System.Drawing.Point(6, 72);
            this.lbKontaktInformacije.Name = "lbKontaktInformacije";
            this.lbKontaktInformacije.Size = new System.Drawing.Size(378, 238);
            this.lbKontaktInformacije.TabIndex = 4;
            // 
            // btnDodajInfo
            // 
            this.btnDodajInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDodajInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDodajInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnDodajInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodajInfo.Location = new System.Drawing.Point(267, 35);
            this.btnDodajInfo.Name = "btnDodajInfo";
            this.btnDodajInfo.Size = new System.Drawing.Size(117, 21);
            this.btnDodajInfo.TabIndex = 3;
            this.btnDodajInfo.Text = "Dodaj informaciju";
            this.btnDodajInfo.UseVisualStyleBackColor = false;
            this.btnDodajInfo.Click += new System.EventHandler(this.btnDodajInfo_Click);
            // 
            // txtKontaktInfo
            // 
            this.txtKontaktInfo.BackColor = System.Drawing.Color.LightGray;
            this.txtKontaktInfo.Location = new System.Drawing.Point(6, 36);
            this.txtKontaktInfo.Name = "txtKontaktInfo";
            this.txtKontaktInfo.Size = new System.Drawing.Size(246, 20);
            this.txtKontaktInfo.TabIndex = 0;
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSnimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSnimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSnimi.Location = new System.Drawing.Point(412, 393);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(111, 38);
            this.btnSnimi.TabIndex = 3;
            this.btnSnimi.Text = "Sačuvaj kontakt";
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.LightGray;
            this.txtIme.Location = new System.Drawing.Point(101, 34);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(166, 20);
            this.txtIme.TabIndex = 4;
            // 
            // txtOdnos
            // 
            this.txtOdnos.BackColor = System.Drawing.Color.LightGray;
            this.txtOdnos.Location = new System.Drawing.Point(101, 72);
            this.txtOdnos.Name = "txtOdnos";
            this.txtOdnos.Size = new System.Drawing.Size(166, 20);
            this.txtOdnos.TabIndex = 5;
            // 
            // DodajKontaktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.txtOdnos);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.gbKontaktInfo);
            this.Controls.Add(this.labelOdnos);
            this.Controls.Add(this.labelIme);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "DodajKontaktForm";
            this.Text = "DodajKontakt";
            this.gbKontaktInfo.ResumeLayout(false);
            this.gbKontaktInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelOdnos;
        private System.Windows.Forms.GroupBox gbKontaktInfo;
        private System.Windows.Forms.Button btnDodajInfo;
        private System.Windows.Forms.TextBox txtKontaktInfo;
        private System.Windows.Forms.ListBox lbKontaktInformacije;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtOdnos;
    }
}