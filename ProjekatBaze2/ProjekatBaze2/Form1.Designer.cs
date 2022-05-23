namespace ProjekatBaze2
{
    partial class Form1
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
            this.cmdUcitaj = new System.Windows.Forms.Button();
            this.cmdDodajBanku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUcitaj
            // 
            this.cmdUcitaj.Location = new System.Drawing.Point(175, 71);
            this.cmdUcitaj.Name = "cmdUcitaj";
            this.cmdUcitaj.Size = new System.Drawing.Size(314, 45);
            this.cmdUcitaj.TabIndex = 0;
            this.cmdUcitaj.Text = "Ucitaj";
            this.cmdUcitaj.UseVisualStyleBackColor = true;
            this.cmdUcitaj.Click += new System.EventHandler(this.cmdUcitaj_Click);
            // 
            // cmdDodajBanku
            // 
            this.cmdDodajBanku.Location = new System.Drawing.Point(175, 149);
            this.cmdDodajBanku.Name = "cmdDodajBanku";
            this.cmdDodajBanku.Size = new System.Drawing.Size(314, 30);
            this.cmdDodajBanku.TabIndex = 1;
            this.cmdDodajBanku.Text = "Dodaj banku";
            this.cmdDodajBanku.UseVisualStyleBackColor = true;
            this.cmdDodajBanku.Click += new System.EventHandler(this.cmdDodajBanku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdDodajBanku);
            this.Controls.Add(this.cmdUcitaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUcitaj;
        private System.Windows.Forms.Button cmdDodajBanku;
    }
}

