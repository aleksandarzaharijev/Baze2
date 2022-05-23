namespace ProjekatBaze2.Forme
{
    partial class DodajBankuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankaIme = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.TxtAdresaCentrale = new System.Windows.Forms.TextBox();
            this.btnDodajBankuKonacno = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime banke:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(34, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Web adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(34, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(34, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresa centrale:";
            // 
            // txtBankaIme
            // 
            this.txtBankaIme.Location = new System.Drawing.Point(194, 78);
            this.txtBankaIme.Name = "txtBankaIme";
            this.txtBankaIme.Size = new System.Drawing.Size(178, 22);
            this.txtBankaIme.TabIndex = 4;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(194, 123);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(178, 22);
            this.txtAdresa.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(194, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // TxtAdresaCentrale
            // 
            this.TxtAdresaCentrale.Location = new System.Drawing.Point(194, 224);
            this.TxtAdresaCentrale.Name = "TxtAdresaCentrale";
            this.TxtAdresaCentrale.Size = new System.Drawing.Size(178, 22);
            this.TxtAdresaCentrale.TabIndex = 7;
            // 
            // btnDodajBankuKonacno
            // 
            this.btnDodajBankuKonacno.BackColor = System.Drawing.Color.Teal;
            this.btnDodajBankuKonacno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDodajBankuKonacno.Location = new System.Drawing.Point(38, 271);
            this.btnDodajBankuKonacno.Name = "btnDodajBankuKonacno";
            this.btnDodajBankuKonacno.Size = new System.Drawing.Size(334, 41);
            this.btnDodajBankuKonacno.TabIndex = 8;
            this.btnDodajBankuKonacno.Text = "Dodaj";
            this.btnDodajBankuKonacno.UseVisualStyleBackColor = false;
            this.btnDodajBankuKonacno.Click += new System.EventHandler(this.btnDodajBankuKonacno_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.3F);
            this.label5.Location = new System.Drawing.Point(35, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unošenje osnovnih podataka banke";
            // 
            // DodajBankuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajBankuKonacno);
            this.Controls.Add(this.TxtAdresaCentrale);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtBankaIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodajBankuForm";
            this.Text = "Dodaj banku";
            this.Load += new System.EventHandler(this.DodajBankuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBankaIme;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox TxtAdresaCentrale;
        private System.Windows.Forms.Button btnDodajBankuKonacno;
        private System.Windows.Forms.Label label5;
    }
}