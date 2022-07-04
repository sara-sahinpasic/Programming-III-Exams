
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
            this.lblPregledIspitaStudent = new System.Windows.Forms.Label();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Varanje = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ScanIspita = new System.Windows.Forms.DataGridViewImageColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDodajScanIspita = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled ispita za studenta:";
            // 
            // lblPregledIspitaStudent
            // 
            this.lblPregledIspitaStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregledIspitaStudent.Location = new System.Drawing.Point(198, 9);
            this.lblPregledIspitaStudent.Name = "lblPregledIspitaStudent";
            this.lblPregledIspitaStudent.Size = new System.Drawing.Size(309, 18);
            this.lblPregledIspitaStudent.TabIndex = 1;
            this.lblPregledIspitaStudent.Text = "/";
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Napomena,
            this.Varanje,
            this.ScanIspita,
            this.Brisi});
            this.dgvPretraga.Location = new System.Drawing.Point(12, 39);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(776, 239);
            this.dgvPretraga.TabIndex = 2;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            this.dgvPretraga.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentDoubleClick);
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmeti";
            this.Predmet.FillWeight = 135.9963F;
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.FillWeight = 134.5178F;
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            // 
            // Varanje
            // 
            this.Varanje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Varanje.DataPropertyName = "Varanje";
            this.Varanje.FillWeight = 74.8038F;
            this.Varanje.HeaderText = "Varanje";
            this.Varanje.Name = "Varanje";
            // 
            // ScanIspita
            // 
            this.ScanIspita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScanIspita.DataPropertyName = "Ispit";
            this.ScanIspita.FillWeight = 78.06744F;
            this.ScanIspita.HeaderText = "Scan ispita";
            this.ScanIspita.Name = "ScanIspita";
            // 
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brisi.FillWeight = 76.61467F;
            this.Brisi.HeaderText = "";
            this.Brisi.Name = "Brisi";
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // btnDodajScanIspita
            // 
            this.btnDodajScanIspita.Location = new System.Drawing.Point(664, 4);
            this.btnDodajScanIspita.Name = "btnDodajScanIspita";
            this.btnDodajScanIspita.Size = new System.Drawing.Size(124, 23);
            this.btnDodajScanIspita.TabIndex = 3;
            this.btnDodajScanIspita.Text = "Dodaj scan ispita";
            this.btnDodajScanIspita.UseVisualStyleBackColor = true;
            this.btnDodajScanIspita.Click += new System.EventHandler(this.btnDodajScanIspita_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(664, 284);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(124, 23);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmScanIspitaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodajScanIspita);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.lblPregledIspitaStudent);
            this.Controls.Add(this.label1);
            this.Name = "frmScanIspitaIB140261";
            this.Text = "frmScanIspitaIB140261";
            this.Load += new System.EventHandler(this.frmScanIspitaIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPregledIspitaStudent;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.Button btnDodajScanIspita;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Varanje;
        private System.Windows.Forms.DataGridViewImageColumn ScanIspita;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}