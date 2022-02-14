
namespace cSharpIntroWinForms.IB140261
{
    partial class frmPorukeIB140261
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
            this.lblKomunikacijaSa = new System.Windows.Forms.Label();
            this.dgvPoruke = new System.Windows.Forms.DataGridView();
            this.btnNovaPoruka = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Komunikacija sa:";
            // 
            // lblKomunikacijaSa
            // 
            this.lblKomunikacijaSa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKomunikacijaSa.Location = new System.Drawing.Point(105, 9);
            this.lblKomunikacijaSa.Name = "lblKomunikacijaSa";
            this.lblKomunikacijaSa.Size = new System.Drawing.Size(181, 24);
            this.lblKomunikacijaSa.TabIndex = 1;
            // 
            // dgvPoruke
            // 
            this.dgvPoruke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoruke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Sadrzaj,
            this.Slika,
            this.Brisi});
            this.dgvPoruke.Location = new System.Drawing.Point(12, 42);
            this.dgvPoruke.Name = "dgvPoruke";
            this.dgvPoruke.Size = new System.Drawing.Size(666, 217);
            this.dgvPoruke.TabIndex = 2;
            this.dgvPoruke.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoruke_CellDoubleClick);
            // 
            // btnNovaPoruka
            // 
            this.btnNovaPoruka.Location = new System.Drawing.Point(588, 13);
            this.btnNovaPoruka.Name = "btnNovaPoruka";
            this.btnNovaPoruka.Size = new System.Drawing.Size(90, 23);
            this.btnNovaPoruka.TabIndex = 3;
            this.btnNovaPoruka.Text = "NovaPoruka";
            this.btnNovaPoruka.UseVisualStyleBackColor = true;
            this.btnNovaPoruka.Click += new System.EventHandler(this.btnNovaPoruka_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(588, 265);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(90, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "DatumVrijemeSlanja";
            this.Datum.FillWeight = 101.5228F;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.DataPropertyName = "Poruke";
            this.Sadrzaj.FillWeight = 166.7355F;
            this.Sadrzaj.HeaderText = "Sadržaj";
            this.Sadrzaj.Name = "Sadrzaj";
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.FillWeight = 59.03715F;
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Brisi
            // 
            this.Brisi.FillWeight = 72.70445F;
            this.Brisi.HeaderText = "Briši";
            this.Brisi.Name = "Brisi";
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // frmPorukeIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 303);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnNovaPoruka);
            this.Controls.Add(this.dgvPoruke);
            this.Controls.Add(this.lblKomunikacijaSa);
            this.Controls.Add(this.label1);
            this.Name = "frmPorukeIB140261";
            this.Text = "Poruke";
            this.Load += new System.EventHandler(this.frmPorukeIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoruke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKomunikacijaSa;
        private System.Windows.Forms.DataGridView dgvPoruke;
        private System.Windows.Forms.Button btnNovaPoruka;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}