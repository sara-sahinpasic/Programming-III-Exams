
namespace DLWMS.WinForms.IB140261
{
    partial class frmScanIspitaIB140261
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
            this.lblPregledIspitaStudenta = new System.Windows.Forms.Label();
            this.btnDodajScanIspita = new System.Windows.Forms.Button();
            this.dgvPregledIspita = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ScanIspita = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledIspita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled ispita za studenta: ";
            // 
            // lblPregledIspitaStudenta
            // 
            this.lblPregledIspitaStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregledIspitaStudenta.Location = new System.Drawing.Point(152, 9);
            this.lblPregledIspitaStudenta.Name = "lblPregledIspitaStudenta";
            this.lblPregledIspitaStudenta.Size = new System.Drawing.Size(198, 26);
            this.lblPregledIspitaStudenta.TabIndex = 1;
            // 
            // btnDodajScanIspita
            // 
            this.btnDodajScanIspita.Location = new System.Drawing.Point(666, 12);
            this.btnDodajScanIspita.Name = "btnDodajScanIspita";
            this.btnDodajScanIspita.Size = new System.Drawing.Size(122, 23);
            this.btnDodajScanIspita.TabIndex = 2;
            this.btnDodajScanIspita.Text = "Dodaj scan ispita";
            this.btnDodajScanIspita.UseVisualStyleBackColor = true;
            this.btnDodajScanIspita.Click += new System.EventHandler(this.btnDodajScanIspita_Click);
            // 
            // dgvPregledIspita
            // 
            this.dgvPregledIspita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledIspita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledIspita.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.ScanIspita,
            this.Brisi});
            this.dgvPregledIspita.Location = new System.Drawing.Point(15, 50);
            this.dgvPregledIspita.Name = "dgvPregledIspita";
            this.dgvPregledIspita.Size = new System.Drawing.Size(773, 303);
            this.dgvPregledIspita.TabIndex = 3;
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.FillWeight = 117.9946F;
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.FillWeight = 121.8274F;
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            // 
            // Varanje
            // 
            this.Varanje.DataPropertyName = "Varanje";
            this.Varanje.FillWeight = 86.72601F;
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.Name = "Varanje";
            this.Varanje.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Varanje.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ScanIspita
            // 
            this.ScanIspita.DataPropertyName = "SkeniraniIspit";
            this.ScanIspita.FillWeight = 86.72601F;
            this.ScanIspita.HeaderText = "ScanIspita";
            this.ScanIspita.Name = "ScanIspita";
            // 
            // Brisi
            // 
            this.Brisi.FillWeight = 86.72601F;
            this.Brisi.HeaderText = "Briši";
            this.Brisi.Name = "Brisi";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(666, 370);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(122, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            // 
            // frmScanIspitaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dgvPregledIspita);
            this.Controls.Add(this.btnDodajScanIspita);
            this.Controls.Add(this.lblPregledIspitaStudenta);
            this.Controls.Add(this.label1);
            this.Name = "frmScanIspitaIB140261";
            this.Text = "frmScanIspita";
            this.Load += new System.EventHandler(this.frmScanIspitaBrojIndeksa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledIspita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPregledIspitaStudenta;
        private System.Windows.Forms.Button btnDodajScanIspita;
        private System.Windows.Forms.DataGridView dgvPregledIspita;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewImageColumn ScanIspita;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}