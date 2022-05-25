namespace ProjekatBaze2.Forme
{
    partial class BankaTelefoniForm
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
            this.btnDodajBrojBanke = new System.Windows.Forms.Button();
            this.btnObrisiBrojBanke = new System.Windows.Forms.Button();
            this.btnIzmeniBrojBanke = new System.Windows.Forms.Button();
            this.listaBrojBanke = new System.Windows.Forms.ListView();
            this.gbxKontaktTelefoni = new System.Windows.Forms.GroupBox();
            this.BrojTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxKontaktTelefoni.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajBrojBanke
            // 
            this.btnDodajBrojBanke.Location = new System.Drawing.Point(273, 79);
            this.btnDodajBrojBanke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajBrojBanke.Name = "btnDodajBrojBanke";
            this.btnDodajBrojBanke.Size = new System.Drawing.Size(124, 30);
            this.btnDodajBrojBanke.TabIndex = 0;
            this.btnDodajBrojBanke.Text = "Dodaj kontakt telefon";
            this.btnDodajBrojBanke.UseVisualStyleBackColor = true;
            this.btnDodajBrojBanke.Click += new System.EventHandler(this.btnDodajBrojBanke_Click);
            // 
            // btnObrisiBrojBanke
            // 
            this.btnObrisiBrojBanke.Location = new System.Drawing.Point(273, 165);
            this.btnObrisiBrojBanke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnObrisiBrojBanke.Name = "btnObrisiBrojBanke";
            this.btnObrisiBrojBanke.Size = new System.Drawing.Size(124, 30);
            this.btnObrisiBrojBanke.TabIndex = 1;
            this.btnObrisiBrojBanke.Text = "Obrisi kontakt telefon";
            this.btnObrisiBrojBanke.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniBrojBanke
            // 
            this.btnIzmeniBrojBanke.Location = new System.Drawing.Point(273, 123);
            this.btnIzmeniBrojBanke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzmeniBrojBanke.Name = "btnIzmeniBrojBanke";
            this.btnIzmeniBrojBanke.Size = new System.Drawing.Size(124, 30);
            this.btnIzmeniBrojBanke.TabIndex = 2;
            this.btnIzmeniBrojBanke.Text = "Izmeni kontakt telefon";
            this.btnIzmeniBrojBanke.UseVisualStyleBackColor = true;
            // 
            // listaBrojBanke
            // 
            this.listaBrojBanke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BrojTelefona});
            this.listaBrojBanke.HideSelection = false;
            this.listaBrojBanke.Location = new System.Drawing.Point(13, 17);
            this.listaBrojBanke.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaBrojBanke.Name = "listaBrojBanke";
            this.listaBrojBanke.Size = new System.Drawing.Size(256, 266);
            this.listaBrojBanke.TabIndex = 3;
            this.listaBrojBanke.UseCompatibleStateImageBehavior = false;
            this.listaBrojBanke.View = System.Windows.Forms.View.Details;
            // 
            // gbxKontaktTelefoni
            // 
            this.gbxKontaktTelefoni.Controls.Add(this.listaBrojBanke);
            this.gbxKontaktTelefoni.Controls.Add(this.btnObrisiBrojBanke);
            this.gbxKontaktTelefoni.Controls.Add(this.btnIzmeniBrojBanke);
            this.gbxKontaktTelefoni.Controls.Add(this.btnDodajBrojBanke);
            this.gbxKontaktTelefoni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxKontaktTelefoni.Location = new System.Drawing.Point(0, 0);
            this.gbxKontaktTelefoni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKontaktTelefoni.Name = "gbxKontaktTelefoni";
            this.gbxKontaktTelefoni.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxKontaktTelefoni.Size = new System.Drawing.Size(405, 319);
            this.gbxKontaktTelefoni.TabIndex = 4;
            this.gbxKontaktTelefoni.TabStop = false;
            this.gbxKontaktTelefoni.Text = "Kontakt telefoni";
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.Text = "Broj Telefona";
            this.BrojTelefona.Width = 250;
            // 
            // BankaTelefoniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 319);
            this.Controls.Add(this.gbxKontaktTelefoni);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BankaTelefoniForm";
            this.Text = "BankaTelefoniForm";
            this.Load += new System.EventHandler(this.BankaTelefoniForm_Load);
            this.gbxKontaktTelefoni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajBrojBanke;
        private System.Windows.Forms.Button btnObrisiBrojBanke;
        private System.Windows.Forms.Button btnIzmeniBrojBanke;
        private System.Windows.Forms.ListView listaBrojBanke;
        private System.Windows.Forms.GroupBox gbxKontaktTelefoni;
        private System.Windows.Forms.ColumnHeader BrojTelefona;
    }
}