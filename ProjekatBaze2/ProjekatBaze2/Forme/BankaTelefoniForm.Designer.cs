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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxKontaktTelefoni = new System.Windows.Forms.GroupBox();
            this.gbxKontaktTelefoni.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajBrojBanke
            // 
            this.btnDodajBrojBanke.Location = new System.Drawing.Point(364, 97);
            this.btnDodajBrojBanke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajBrojBanke.Name = "btnDodajBrojBanke";
            this.btnDodajBrojBanke.Size = new System.Drawing.Size(165, 37);
            this.btnDodajBrojBanke.TabIndex = 0;
            this.btnDodajBrojBanke.Text = "Dodaj kontakt telefon";
            this.btnDodajBrojBanke.UseVisualStyleBackColor = true;
            this.btnDodajBrojBanke.Click += new System.EventHandler(this.btnDodajBrojBanke_Click);
            // 
            // btnObrisiBrojBanke
            // 
            this.btnObrisiBrojBanke.Location = new System.Drawing.Point(364, 203);
            this.btnObrisiBrojBanke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiBrojBanke.Name = "btnObrisiBrojBanke";
            this.btnObrisiBrojBanke.Size = new System.Drawing.Size(165, 37);
            this.btnObrisiBrojBanke.TabIndex = 1;
            this.btnObrisiBrojBanke.Text = "Obrisi kontakt telefon";
            this.btnObrisiBrojBanke.UseVisualStyleBackColor = true;
            this.btnObrisiBrojBanke.Click += new System.EventHandler(this.btnObrisiBrojBanke_Click);
            // 
            // btnIzmeniBrojBanke
            // 
            this.btnIzmeniBrojBanke.Location = new System.Drawing.Point(364, 151);
            this.btnIzmeniBrojBanke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzmeniBrojBanke.Name = "btnIzmeniBrojBanke";
            this.btnIzmeniBrojBanke.Size = new System.Drawing.Size(165, 37);
            this.btnIzmeniBrojBanke.TabIndex = 2;
            this.btnIzmeniBrojBanke.Text = "Izmeni kontakt telefon";
            this.btnIzmeniBrojBanke.UseVisualStyleBackColor = true;
            this.btnIzmeniBrojBanke.Click += new System.EventHandler(this.btnIzmeniBrojBanke_Click);
            // 
            // listaBrojBanke
            // 
            this.listaBrojBanke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listaBrojBanke.FullRowSelect = true;
            this.listaBrojBanke.GridLines = true;
            this.listaBrojBanke.HideSelection = false;
            this.listaBrojBanke.LabelWrap = false;
            this.listaBrojBanke.Location = new System.Drawing.Point(17, 21);
            this.listaBrojBanke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaBrojBanke.Name = "listaBrojBanke";
            this.listaBrojBanke.Size = new System.Drawing.Size(340, 326);
            this.listaBrojBanke.TabIndex = 3;
            this.listaBrojBanke.UseCompatibleStateImageBehavior = false;
            this.listaBrojBanke.View = System.Windows.Forms.View.Details;
            this.listaBrojBanke.SelectedIndexChanged += new System.EventHandler(this.listaBrojBanke_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Broj Telefona";
            this.columnHeader2.Width = 107;
            // 
            // gbxKontaktTelefoni
            // 
            this.gbxKontaktTelefoni.Controls.Add(this.listaBrojBanke);
            this.gbxKontaktTelefoni.Controls.Add(this.btnObrisiBrojBanke);
            this.gbxKontaktTelefoni.Controls.Add(this.btnIzmeniBrojBanke);
            this.gbxKontaktTelefoni.Controls.Add(this.btnDodajBrojBanke);
            this.gbxKontaktTelefoni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxKontaktTelefoni.Location = new System.Drawing.Point(0, 0);
            this.gbxKontaktTelefoni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxKontaktTelefoni.Name = "gbxKontaktTelefoni";
            this.gbxKontaktTelefoni.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxKontaktTelefoni.Size = new System.Drawing.Size(540, 393);
            this.gbxKontaktTelefoni.TabIndex = 4;
            this.gbxKontaktTelefoni.TabStop = false;
            this.gbxKontaktTelefoni.Text = "Kontakt telefoni";
            this.gbxKontaktTelefoni.Enter += new System.EventHandler(this.gbxKontaktTelefoni_Enter);
            // 
            // BankaTelefoniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 393);
            this.Controls.Add(this.gbxKontaktTelefoni);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}