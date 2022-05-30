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
            this.listaDinarskiRacuni.HideSelection = false;
            this.listaDinarskiRacuni.Location = new System.Drawing.Point(6, 19);
            this.listaDinarskiRacuni.Name = "listaDinarskiRacuni";
            this.listaDinarskiRacuni.Size = new System.Drawing.Size(359, 351);
            this.listaDinarskiRacuni.TabIndex = 0;
            this.listaDinarskiRacuni.UseCompatibleStateImageBehavior = false;
            this.listaDinarskiRacuni.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 83;
            // 
            // DatumOtvaranja
            // 
            this.DatumOtvaranja.Text = "Datum otvaranja";
            this.DatumOtvaranja.Width = 103;
            // 
            // Saldo
            // 
            this.Saldo.Text = "Saldo";
            this.Saldo.Width = 72;
            // 
            // DinarskiRacuniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}