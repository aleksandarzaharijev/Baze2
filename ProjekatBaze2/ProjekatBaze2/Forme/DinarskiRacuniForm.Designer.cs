namespace ProjekatBaze2.Forme
{
    partial class DinarskiRacuniForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaDinarskiRacuni = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumOtvaranja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Saldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajRacun = new System.Windows.Forms.Button();
            this.btnIzmeniRacun = new System.Windows.Forms.Button();
            this.btnOvlascenaLica = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaDinarskiRacuni);
            this.groupBox1.Location = new System.Drawing.Point(27, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dinarski racuni";
            // 
            // listaDinarskiRacuni
            // 
            this.listaDinarskiRacuni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.DatumOtvaranja,
            this.Saldo});
            this.listaDinarskiRacuni.FullRowSelect = true;
            this.listaDinarskiRacuni.GridLines = true;
            this.listaDinarskiRacuni.HideSelection = false;
            this.listaDinarskiRacuni.Location = new System.Drawing.Point(6, 19);
            this.listaDinarskiRacuni.MultiSelect = false;
            this.listaDinarskiRacuni.Name = "listaDinarskiRacuni";
            this.listaDinarskiRacuni.Size = new System.Drawing.Size(359, 351);
            this.listaDinarskiRacuni.TabIndex = 0;
            this.listaDinarskiRacuni.UseCompatibleStateImageBehavior = false;
            this.listaDinarskiRacuni.View = System.Windows.Forms.View.Details;
            this.listaDinarskiRacuni.SelectedIndexChanged += new System.EventHandler(this.listaDinarskiRacuni_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Broj računa";
            this.Id.Width = 118;
            // 
            // DatumOtvaranja
            // 
            this.DatumOtvaranja.Text = "Datum otvaranja";
            this.DatumOtvaranja.Width = 103;
            // 
            // Saldo
            // 
            this.Saldo.Text = "Saldo";
            this.Saldo.Width = 90;
            // 
            // btnDodajRacun
            // 
            this.btnDodajRacun.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajRacun.Location = new System.Drawing.Point(429, 51);
            this.btnDodajRacun.Name = "btnDodajRacun";
            this.btnDodajRacun.Size = new System.Drawing.Size(126, 27);
            this.btnDodajRacun.TabIndex = 1;
            this.btnDodajRacun.Text = "Dodaj racun";
            this.btnDodajRacun.UseVisualStyleBackColor = false;
            // 
            // btnIzmeniRacun
            // 
            this.btnIzmeniRacun.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzmeniRacun.Location = new System.Drawing.Point(429, 101);
            this.btnIzmeniRacun.Name = "btnIzmeniRacun";
            this.btnIzmeniRacun.Size = new System.Drawing.Size(126, 27);
            this.btnIzmeniRacun.TabIndex = 2;
            this.btnIzmeniRacun.Text = "Izmeni racun";
            this.btnIzmeniRacun.UseVisualStyleBackColor = false;
            // 
            // btnOvlascenaLica
            // 
            this.btnOvlascenaLica.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOvlascenaLica.Location = new System.Drawing.Point(429, 193);
            this.btnOvlascenaLica.Name = "btnOvlascenaLica";
            this.btnOvlascenaLica.Size = new System.Drawing.Size(126, 27);
            this.btnOvlascenaLica.TabIndex = 3;
            this.btnOvlascenaLica.Text = "Ovlascena lica";
            this.btnOvlascenaLica.UseVisualStyleBackColor = false;
            // 
            // DinarskiRacuniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.btnOvlascenaLica);
            this.Controls.Add(this.btnIzmeniRacun);
            this.Controls.Add(this.btnDodajRacun);
            this.Controls.Add(this.groupBox1);
            this.Name = "DinarskiRacuniForm";
            this.Text = "DinarskiRacuniForm";
            this.Load += new System.EventHandler(this.DinarskiRacuniForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaDinarskiRacuni;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader DatumOtvaranja;
        private System.Windows.Forms.ColumnHeader Saldo;
        private System.Windows.Forms.Button btnDodajRacun;
        private System.Windows.Forms.Button btnIzmeniRacun;
        private System.Windows.Forms.Button btnOvlascenaLica;
    }
}