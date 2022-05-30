namespace ProjekatBaze2.Forme
{
    partial class DodajFilijaluForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtRadnoVreme = new System.Windows.Forms.TextBox();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            this.btnDodajFilijaluKonacno = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajFilijaluKonacno);
            this.groupBox1.Controls.Add(this.txtBrojTelefona);
            this.groupBox1.Controls.Add(this.txtRadnoVreme);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o filijali";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radno vreme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj telefona: ";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(156, 42);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 22);
            this.txtAdresa.TabIndex = 3;
            // 
            // txtRadnoVreme
            // 
            this.txtRadnoVreme.Location = new System.Drawing.Point(156, 99);
            this.txtRadnoVreme.Name = "txtRadnoVreme";
            this.txtRadnoVreme.Size = new System.Drawing.Size(100, 22);
            this.txtRadnoVreme.TabIndex = 4;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(156, 158);
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(100, 22);
            this.txtBrojTelefona.TabIndex = 5;
            // 
            // btnDodajFilijaluKonacno
            // 
            this.btnDodajFilijaluKonacno.Location = new System.Drawing.Point(40, 208);
            this.btnDodajFilijaluKonacno.Name = "btnDodajFilijaluKonacno";
            this.btnDodajFilijaluKonacno.Size = new System.Drawing.Size(216, 23);
            this.btnDodajFilijaluKonacno.TabIndex = 6;
            this.btnDodajFilijaluKonacno.Text = "Dodaj ";
            this.btnDodajFilijaluKonacno.UseVisualStyleBackColor = true;
            this.btnDodajFilijaluKonacno.Click += new System.EventHandler(this.btnDodajFilijaluKonacno_Click);
            // 
            // DodajFilijaluForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 254);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajFilijaluForm";
            this.Text = "DodajFilijaluForm";
            this.Load += new System.EventHandler(this.DodajFilijaluForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajFilijaluKonacno;
        private System.Windows.Forms.TextBox txtBrojTelefona;
        private System.Windows.Forms.TextBox txtRadnoVreme;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label3;
    }
}