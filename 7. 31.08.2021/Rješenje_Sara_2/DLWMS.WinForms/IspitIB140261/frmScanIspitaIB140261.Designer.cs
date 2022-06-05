
namespace DLWMS.WinForms.IspitIB140261
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.dgvPredmet = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ScanIspita = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodajScan = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled ispita za studenta: ";
            // 
            // lblStudent
            // 
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(202, 17);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(184, 18);
            this.lblStudent.TabIndex = 1;
            // 
            // dgvPredmet
            // 
            this.dgvPredmet.AllowUserToAddRows = false;
            this.dgvPredmet.AllowUserToDeleteRows = false;
            this.dgvPredmet.AllowUserToOrderColumns = true;
            this.dgvPredmet.AllowUserToResizeColumns = false;
            this.dgvPredmet.AllowUserToResizeRows = false;
            this.dgvPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.ScanIspita,
            this.Brisi});
            this.dgvPredmet.Location = new System.Drawing.Point(15, 47);
            this.dgvPredmet.Name = "dgvPredmet";
            this.dgvPredmet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredmet.Size = new System.Drawing.Size(773, 242);
            this.dgvPredmet.TabIndex = 2;
            this.dgvPredmet.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPredmet_CellContentDoubleClick);
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.FillWeight = 120.3702F;
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.FillWeight = 126.9036F;
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            // 
            // Varanje
            // 
            this.Varanje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Varanje.DataPropertyName = "Varanje";
            this.Varanje.FillWeight = 87.42395F;
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.Name = "Varanje";
            // 
            // ScanIspita
            // 
            this.ScanIspita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScanIspita.DataPropertyName = "SkeniranIspit";
            this.ScanIspita.FillWeight = 84.45585F;
            this.ScanIspita.HeaderText = "Scan ispita";
            this.ScanIspita.Name = "ScanIspita";
            // 
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brisi.FillWeight = 80.8465F;
            this.Brisi.HeaderText = "";
            this.Brisi.Name = "Brisi";
            this.Brisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnDodajScan
            // 
            this.btnDodajScan.Location = new System.Drawing.Point(685, 18);
            this.btnDodajScan.Name = "btnDodajScan";
            this.btnDodajScan.Size = new System.Drawing.Size(103, 23);
            this.btnDodajScan.TabIndex = 3;
            this.btnDodajScan.Text = "Dodaj scan ispita";
            this.btnDodajScan.UseVisualStyleBackColor = true;
            this.btnDodajScan.Click += new System.EventHandler(this.btnDodajScan_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(685, 295);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(103, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmScanIspitaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodajScan);
            this.Controls.Add(this.dgvPredmet);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmScanIspitaIB140261";
            this.Text = "frmScanIspitaIB140261";
            this.Load += new System.EventHandler(this.frmScanIspitaIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.DataGridView dgvPredmet;
        private System.Windows.Forms.Button btnDodajScan;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewImageColumn ScanIspita;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}