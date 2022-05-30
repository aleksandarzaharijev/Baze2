namespace ProjekatBaze2.Forme
{
    partial class FilijalaForm
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
            this.listaFilijala = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.brojTelefona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radnoVreme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajFilijalu = new System.Windows.Forms.Button();
            this.btnIzmeniFilijalu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzmeniFilijalu);
            this.groupBox1.Controls.Add(this.btnDodajFilijalu);
            this.groupBox1.Controls.Add(this.listaFilijala);
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o filijalama";
            // 
            // listaFilijala
            // 
            this.listaFilijala.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Adresa,
            this.brojTelefona,
            this.radnoVreme});
            this.listaFilijala.HideSelection = false;
            this.listaFilijala.Location = new System.Drawing.Point(17, 34);
            this.listaFilijala.Name = "listaFilijala";
            this.listaFilijala.Size = new System.Drawing.Size(381, 275);
            this.listaFilijala.TabIndex = 0;
            this.listaFilijala.UseCompatibleStateImageBehavior = false;
            this.listaFilijala.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 80;
            // 
            // brojTelefona
            // 
            this.brojTelefona.Text = "Broj telefona";
            this.brojTelefona.Width = 112;
            // 
            // radnoVreme
            // 
            this.radnoVreme.Text = "Radno vreme";
            this.radnoVreme.Width = 134;
            // 
            // btnDodajFilijalu
            // 
            this.btnDodajFilijalu.Location = new System.Drawing.Point(427, 34);
            this.btnDodajFilijalu.Name = "btnDodajFilijalu";
            this.btnDodajFilijalu.Size = new System.Drawing.Size(122, 49);
            this.btnDodajFilijalu.TabIndex = 1;
            this.btnDodajFilijalu.Text = "Dodaj filijalu";
            this.btnDodajFilijalu.UseVisualStyleBackColor = true;
            this.btnDodajFilijalu.Click += new System.EventHandler(this.btnDodajFilijalu_Click);
            // 
            // btnIzmeniFilijalu
            // 
            this.btnIzmeniFilijalu.Location = new System.Drawing.Point(427, 113);
            this.btnIzmeniFilijalu.Name = "btnIzmeniFilijalu";
            this.btnIzmeniFilijalu.Size = new System.Drawing.Size(122, 49);
            this.btnIzmeniFilijalu.TabIndex = 2;
            this.btnIzmeniFilijalu.Text = "Izmeni filijalu";
            this.btnIzmeniFilijalu.UseVisualStyleBackColor = true;
            // 
            // FilijalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 357);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilijalaForm";
            this.Text = "FilijalaForm";
            this.Load += new System.EventHandler(this.FilijalaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaFilijala;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Adresa;
        private System.Windows.Forms.Button btnIzmeniFilijalu;
        private System.Windows.Forms.Button btnDodajFilijalu;
        private System.Windows.Forms.ColumnHeader brojTelefona;
        private System.Windows.Forms.ColumnHeader radnoVreme;
    }
}