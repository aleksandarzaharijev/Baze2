namespace ProjekatBaze2.Forme
{
    partial class IzmeniBankuForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtImeBankeIzmeni = new System.Windows.Forms.TextBox();
            this.txtAdresaBankeIzmeni = new System.Windows.Forms.TextBox();
            this.txtWebBankeIzmeni = new System.Windows.Forms.TextBox();
            this.txtEmailBankeIzmeni = new System.Windows.Forms.TextBox();
            this.btnAzurirajBanku = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAzurirajBanku);
            this.groupBox1.Controls.Add(this.txtEmailBankeIzmeni);
            this.groupBox1.Controls.Add(this.txtWebBankeIzmeni);
            this.groupBox1.Controls.Add(this.txtAdresaBankeIzmeni);
            this.groupBox1.Controls.Add(this.txtImeBankeIzmeni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o bankama";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime banke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa centrale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Web adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txtImeBankeIzmeni
            // 
            this.txtImeBankeIzmeni.Location = new System.Drawing.Point(184, 55);
            this.txtImeBankeIzmeni.Name = "txtImeBankeIzmeni";
            this.txtImeBankeIzmeni.Size = new System.Drawing.Size(142, 22);
            this.txtImeBankeIzmeni.TabIndex = 4;
            // 
            // txtAdresaBankeIzmeni
            // 
            this.txtAdresaBankeIzmeni.Location = new System.Drawing.Point(184, 106);
            this.txtAdresaBankeIzmeni.Name = "txtAdresaBankeIzmeni";
            this.txtAdresaBankeIzmeni.Size = new System.Drawing.Size(142, 22);
            this.txtAdresaBankeIzmeni.TabIndex = 5;
            // 
            // txtWebBankeIzmeni
            // 
            this.txtWebBankeIzmeni.Location = new System.Drawing.Point(184, 152);
            this.txtWebBankeIzmeni.Name = "txtWebBankeIzmeni";
            this.txtWebBankeIzmeni.Size = new System.Drawing.Size(142, 22);
            this.txtWebBankeIzmeni.TabIndex = 6;
            // 
            // txtEmailBankeIzmeni
            // 
            this.txtEmailBankeIzmeni.Location = new System.Drawing.Point(184, 202);
            this.txtEmailBankeIzmeni.Name = "txtEmailBankeIzmeni";
            this.txtEmailBankeIzmeni.Size = new System.Drawing.Size(142, 22);
            this.txtEmailBankeIzmeni.TabIndex = 7;
            // 
            // btnAzurirajBanku
            // 
            this.btnAzurirajBanku.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAzurirajBanku.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAzurirajBanku.Location = new System.Drawing.Point(42, 256);
            this.btnAzurirajBanku.Name = "btnAzurirajBanku";
            this.btnAzurirajBanku.Size = new System.Drawing.Size(284, 37);
            this.btnAzurirajBanku.TabIndex = 8;
            this.btnAzurirajBanku.Text = "Izmeni";
            this.btnAzurirajBanku.UseVisualStyleBackColor = false;
            this.btnAzurirajBanku.Click += new System.EventHandler(this.btnAzurirajBanku_Click);
            // 
            // IzmeniBankuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 331);
            this.Controls.Add(this.groupBox1);
            this.Name = "IzmeniBankuForm";
            this.Text = "Azuriranje banke";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAzurirajBanku;
        private System.Windows.Forms.TextBox txtEmailBankeIzmeni;
        private System.Windows.Forms.TextBox txtWebBankeIzmeni;
        private System.Windows.Forms.TextBox txtAdresaBankeIzmeni;
        private System.Windows.Forms.TextBox txtImeBankeIzmeni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}