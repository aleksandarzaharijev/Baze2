namespace ProjekatBaze2
{
    partial class PocetnaStranica
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
            this.btnBanka = new System.Windows.Forms.Button();
            this.btnBankomati = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBanka
            // 
            this.btnBanka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBanka.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBanka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBanka.Location = new System.Drawing.Point(210, 191);
            this.btnBanka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBanka.Name = "btnBanka";
            this.btnBanka.Size = new System.Drawing.Size(212, 58);
            this.btnBanka.TabIndex = 1;
            this.btnBanka.Text = "Banka";
            this.btnBanka.UseVisualStyleBackColor = false;
            this.btnBanka.Click += new System.EventHandler(this.btnBanka_Click);
            // 
            // btnBankomati
            // 
            this.btnBankomati.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBankomati.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBankomati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBankomati.Location = new System.Drawing.Point(210, 264);
            this.btnBankomati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBankomati.Name = "btnBankomati";
            this.btnBankomati.Size = new System.Drawing.Size(212, 58);
            this.btnBankomati.TabIndex = 2;
            this.btnBankomati.Text = "Bankomati";
            this.btnBankomati.UseVisualStyleBackColor = false;
            this.btnBankomati.Click += new System.EventHandler(this.btnBankomati_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ProjekatBaze2.Properties.Resources.bankomat;
            this.pictureBox1.Location = new System.Drawing.Point(210, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 391);
            this.Controls.Add(this.btnBankomati);
            this.Controls.Add(this.btnBanka);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PocetnaStranica";
            this.Text = "Početna stranica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBanka;
        private System.Windows.Forms.Button btnBankomati;
    }
}