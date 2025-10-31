namespace SVEMIRSKA_KOLONIJA.Forme
{
    partial class AngazujUcesnikaForm
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
            this.listViewUcesnici = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAngazuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewUcesnici
            // 
            this.listViewUcesnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Ime,
            this.columnHeader1});
            this.listViewUcesnici.FullRowSelect = true;
            this.listViewUcesnici.GridLines = true;
            this.listViewUcesnici.HideSelection = false;
            this.listViewUcesnici.Location = new System.Drawing.Point(12, 12);
            this.listViewUcesnici.Name = "listViewUcesnici";
            this.listViewUcesnici.Size = new System.Drawing.Size(284, 270);
            this.listViewUcesnici.TabIndex = 0;
            this.listViewUcesnici.UseCompatibleStateImageBehavior = false;
            this.listViewUcesnici.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 30;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tip";
            this.columnHeader1.Width = 100;
            // 
            // btnAngazuj
            // 
            this.btnAngazuj.Location = new System.Drawing.Point(12, 288);
            this.btnAngazuj.Name = "btnAngazuj";
            this.btnAngazuj.Size = new System.Drawing.Size(84, 23);
            this.btnAngazuj.TabIndex = 1;
            this.btnAngazuj.Text = "Angažuj";
            this.btnAngazuj.UseVisualStyleBackColor = true;
            this.btnAngazuj.Click += new System.EventHandler(this.btnAngazuj_Click);
            // 
            // AngazujUcesnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 323);
            this.Controls.Add(this.btnAngazuj);
            this.Controls.Add(this.listViewUcesnici);
            this.Name = "AngazujUcesnikaForm";
            this.Text = "AngazujUcesnikaForm";
            this.Load += new System.EventHandler(this.AngazujUcesnikaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUcesnici;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnAngazuj;
    }
}