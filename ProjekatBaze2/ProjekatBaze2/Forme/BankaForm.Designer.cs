namespace ProjekatBaze2.Forme
{
    partial class BankaForm
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
            this.btnDodajBanku = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIzmeniBanku = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaBanke = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdresaCentrale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WebAdresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnBankaTelefoni = new System.Windows.Forms.Button();
            this.btnFilijale = new System.Windows.Forms.Button();
            this.btnDinarskiRacuni = new System.Windows.Forms.Button();
            this.btnDevizniRacuni = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajBanku
            // 
            this.btnDodajBanku.Location = new System.Drawing.Point(614, 33);
            this.btnDodajBanku.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajBanku.Name = "btnDodajBanku";
            this.btnDodajBanku.Size = new System.Drawing.Size(180, 38);
            this.btnDodajBanku.TabIndex = 0;
            this.btnDodajBanku.Text = "Dodaj banku";
            this.btnDodajBanku.UseVisualStyleBackColor = true;
            this.btnDodajBanku.Click += new System.EventHandler(this.btnDodajBanku_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Izmeni banku";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniBanku
            // 
            this.btnIzmeniBanku.Location = new System.Drawing.Point(614, 96);
            this.btnIzmeniBanku.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzmeniBanku.Name = "btnIzmeniBanku";
            this.btnIzmeniBanku.Size = new System.Drawing.Size(181, 38);
            this.btnIzmeniBanku.TabIndex = 2;
            this.btnIzmeniBanku.Text = "Izmeni banku";
            this.btnIzmeniBanku.UseVisualStyleBackColor = true;
            this.btnIzmeniBanku.Click += new System.EventHandler(this.btnIzmeniBanku_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaBanke);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(578, 523);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dostupne banke";
            // 
            // listaBanke
            // 
            this.listaBanke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.AdresaCentrale,
            this.WebAdresa,
            this.Ime,
            this.Email});
            this.listaBanke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaBanke.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.listaBanke.FullRowSelect = true;
            this.listaBanke.GridLines = true;
            this.listaBanke.HideSelection = false;
            this.listaBanke.Location = new System.Drawing.Point(2, 18);
            this.listaBanke.Margin = new System.Windows.Forms.Padding(2);
            this.listaBanke.Name = "listaBanke";
            this.listaBanke.Size = new System.Drawing.Size(574, 503);
            this.listaBanke.TabIndex = 4;
            this.listaBanke.UseCompatibleStateImageBehavior = false;
            this.listaBanke.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 133;
            // 
            // AdresaCentrale
            // 
            this.AdresaCentrale.Text = "Adresa";
            this.AdresaCentrale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdresaCentrale.Width = 126;
            // 
            // WebAdresa
            // 
            this.WebAdresa.Text = "Web adresa";
            this.WebAdresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WebAdresa.Width = 149;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ime.Width = 114;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 140;
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.Location = new System.Drawing.Point(614, 222);
            this.btnKlijenti.Margin = new System.Windows.Forms.Padding(2);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(181, 33);
            this.btnKlijenti.TabIndex = 4;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.UseVisualStyleBackColor = true;
            // 
            // btnBankaTelefoni
            // 
            this.btnBankaTelefoni.Location = new System.Drawing.Point(614, 153);
            this.btnBankaTelefoni.Margin = new System.Windows.Forms.Padding(2);
            this.btnBankaTelefoni.Name = "btnBankaTelefoni";
            this.btnBankaTelefoni.Size = new System.Drawing.Size(180, 30);
            this.btnBankaTelefoni.TabIndex = 5;
            this.btnBankaTelefoni.Text = "Kontakt telefoni";
            this.btnBankaTelefoni.UseVisualStyleBackColor = true;
            this.btnBankaTelefoni.Click += new System.EventHandler(this.btnBankaTelefoni_Click);
            // 
            // btnFilijale
            // 
            this.btnFilijale.Location = new System.Drawing.Point(614, 282);
            this.btnFilijale.Name = "btnFilijale";
            this.btnFilijale.Size = new System.Drawing.Size(181, 30);
            this.btnFilijale.TabIndex = 6;
            this.btnFilijale.Text = "Filijale";
            this.btnFilijale.UseVisualStyleBackColor = true;
            this.btnFilijale.Click += new System.EventHandler(this.btnFilijale_Click);
            // 
            // btnDinarskiRacuni
            // 
            this.btnDinarskiRacuni.Location = new System.Drawing.Point(614, 343);
            this.btnDinarskiRacuni.Name = "btnDinarskiRacuni";
            this.btnDinarskiRacuni.Size = new System.Drawing.Size(181, 27);
            this.btnDinarskiRacuni.TabIndex = 7;
            this.btnDinarskiRacuni.Text = "Dinarski racuni";
            this.btnDinarskiRacuni.UseVisualStyleBackColor = true;
            this.btnDinarskiRacuni.Click += new System.EventHandler(this.btnDinarskiRacuni_Click);
            // 
            // btnDevizniRacuni
            // 
            this.btnDevizniRacuni.Location = new System.Drawing.Point(614, 395);
            this.btnDevizniRacuni.Name = "btnDevizniRacuni";
            this.btnDevizniRacuni.Size = new System.Drawing.Size(181, 27);
            this.btnDevizniRacuni.TabIndex = 8;
            this.btnDevizniRacuni.Text = "Devizni racuni";
            this.btnDevizniRacuni.UseVisualStyleBackColor = true;
            // 
            // BankaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 555);
            this.Controls.Add(this.btnDevizniRacuni);
            this.Controls.Add(this.btnDinarskiRacuni);
            this.Controls.Add(this.btnFilijale);
            this.Controls.Add(this.btnBankaTelefoni);
            this.Controls.Add(this.btnKlijenti);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeniBanku);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodajBanku);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BankaForm";
            this.Text = "BankaForm";
            this.Load += new System.EventHandler(this.BankaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajBanku;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIzmeniBanku;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaBanke;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader AdresaCentrale;
        private System.Windows.Forms.ColumnHeader WebAdresa;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button btnBankaTelefoni;
        private System.Windows.Forms.Button btnFilijale;
        private System.Windows.Forms.Button btnDinarskiRacuni;
        private System.Windows.Forms.Button btnDevizniRacuni;
    }
}