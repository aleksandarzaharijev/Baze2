namespace ProjekatBaze2.Forme
{
    partial class DodajBankaTelefonForm
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
            this.txtDodajBankaBroj = new System.Windows.Forms.TextBox();
            this.btnDodajBankaBroj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj telefona:";
            // 
            // txtDodajBankaBroj
            // 
            this.txtDodajBankaBroj.Location = new System.Drawing.Point(183, 60);
            this.txtDodajBankaBroj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDodajBankaBroj.Name = "txtDodajBankaBroj";
            this.txtDodajBankaBroj.Size = new System.Drawing.Size(236, 22);
            this.txtDodajBankaBroj.TabIndex = 1;
            // 
            // btnDodajBankaBroj
            // 
            this.btnDodajBankaBroj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDodajBankaBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajBankaBroj.Location = new System.Drawing.Point(131, 107);
            this.btnDodajBankaBroj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajBankaBroj.Name = "btnDodajBankaBroj";
            this.btnDodajBankaBroj.Size = new System.Drawing.Size(167, 44);
            this.btnDodajBankaBroj.TabIndex = 2;
            this.btnDodajBankaBroj.Text = "Dodaj broj";
            this.btnDodajBankaBroj.UseVisualStyleBackColor = false;
            this.btnDodajBankaBroj.Click += new System.EventHandler(this.button1_Click);
            // 
            // DodajBankaTelefonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 186);
            this.Controls.Add(this.btnDodajBankaBroj);
            this.Controls.Add(this.txtDodajBankaBroj);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DodajBankaTelefonForm";
            this.Text = "DodajTelefon";
            this.Load += new System.EventHandler(this.DodajBankaTelefonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDodajBankaBroj;
        private System.Windows.Forms.Button btnDodajBankaBroj;
    }
}