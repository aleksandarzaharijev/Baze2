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
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajBrojBanke
            // 
            this.btnDodajBrojBanke.Location = new System.Drawing.Point(546, 40);
            this.btnDodajBrojBanke.Name = "btnDodajBrojBanke";
            this.btnDodajBrojBanke.Size = new System.Drawing.Size(166, 23);
            this.btnDodajBrojBanke.TabIndex = 0;
            this.btnDodajBrojBanke.Text = "Dodaj kontakt telefon";
            this.btnDodajBrojBanke.UseVisualStyleBackColor = true;
            // 
            // btnObrisiBrojBanke
            // 
            this.btnObrisiBrojBanke.Location = new System.Drawing.Point(547, 146);
            this.btnObrisiBrojBanke.Name = "btnObrisiBrojBanke";
            this.btnObrisiBrojBanke.Size = new System.Drawing.Size(166, 23);
            this.btnObrisiBrojBanke.TabIndex = 1;
            this.btnObrisiBrojBanke.Text = "Obrisi kontakt telefon";
            this.btnObrisiBrojBanke.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniBrojBanke
            // 
            this.btnIzmeniBrojBanke.Location = new System.Drawing.Point(547, 95);
            this.btnIzmeniBrojBanke.Name = "btnIzmeniBrojBanke";
            this.btnIzmeniBrojBanke.Size = new System.Drawing.Size(166, 23);
            this.btnIzmeniBrojBanke.TabIndex = 2;
            this.btnIzmeniBrojBanke.Text = "Zameni kontakt telefon";
            this.btnIzmeniBrojBanke.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(478, 326);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btnObrisiBrojBanke);
            this.groupBox1.Controls.Add(this.btnIzmeniBrojBanke);
            this.groupBox1.Controls.Add(this.btnDodajBrojBanke);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 393);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BankaTelefoniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 393);
            this.Controls.Add(this.groupBox1);
            this.Name = "BankaTelefoniForm";
            this.Text = "BankaTelefoniForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajBrojBanke;
        private System.Windows.Forms.Button btnObrisiBrojBanke;
        private System.Windows.Forms.Button btnIzmeniBrojBanke;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}