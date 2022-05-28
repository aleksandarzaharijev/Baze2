namespace ProjekatBaze2.Forme
{
    partial class IzmeniBankaTelefonForm
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
            this.txtIzmenaTelefona = new System.Windows.Forms.TextBox();
            this.btnIzmeniBrojBanke = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzmeniBrojBanke);
            this.groupBox1.Controls.Add(this.txtIzmenaTelefona);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmena telefona";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(137, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite novi broj telefona ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(20, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj telefona: ";
            // 
            // txtIzmenaTelefona
            // 
            this.txtIzmenaTelefona.Location = new System.Drawing.Point(141, 131);
            this.txtIzmenaTelefona.Name = "txtIzmenaTelefona";
            this.txtIzmenaTelefona.Size = new System.Drawing.Size(199, 22);
            this.txtIzmenaTelefona.TabIndex = 2;
            // 
            // btnIzmeniBrojBanke
            // 
            this.btnIzmeniBrojBanke.Location = new System.Drawing.Point(141, 212);
            this.btnIzmeniBrojBanke.Name = "btnIzmeniBrojBanke";
            this.btnIzmeniBrojBanke.Size = new System.Drawing.Size(199, 23);
            this.btnIzmeniBrojBanke.TabIndex = 3;
            this.btnIzmeniBrojBanke.Text = "Izmeni\r\n";
            this.btnIzmeniBrojBanke.UseVisualStyleBackColor = true;
            this.btnIzmeniBrojBanke.Click += new System.EventHandler(this.btnIzmeniBrojBanke_Click);
            // 
            // IzmeniBankaTelefonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 293);
            this.Controls.Add(this.groupBox1);
            this.Name = "IzmeniBankaTelefonForm";
            this.Text = "IzmeniBankaTelefonForm";
            this.Load += new System.EventHandler(this.IzmeniBankaTelefonForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIzmenaTelefona;
        private System.Windows.Forms.Button btnIzmeniBrojBanke;
    }
}