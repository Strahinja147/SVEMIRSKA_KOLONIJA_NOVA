namespace SVEMIRSKA_KOLONIJA.Forme
{
    partial class OdabirStanovnikaForm
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
            this.lbStanovnici = new System.Windows.Forms.ListBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStanovnici
            // 
            this.lbStanovnici.FormattingEnabled = true;
            this.lbStanovnici.Location = new System.Drawing.Point(9, 10);
            this.lbStanovnici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbStanovnici.Name = "lbStanovnici";
            this.lbStanovnici.Size = new System.Drawing.Size(269, 264);
            this.lbStanovnici.Sorted = true;
            this.lbStanovnici.TabIndex = 0;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOdaberi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnOdaberi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnOdaberi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaberi.Location = new System.Drawing.Point(322, 20);
            this.btnOdaberi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(92, 88);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOdustani.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnOdustani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Location = new System.Drawing.Point(322, 162);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(92, 88);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // OdabirStanovnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(435, 286);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.lbStanovnici);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OdabirStanovnikaForm";
            this.Text = "DodeliUpravitelja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStanovnici;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnOdustani;
    }
}