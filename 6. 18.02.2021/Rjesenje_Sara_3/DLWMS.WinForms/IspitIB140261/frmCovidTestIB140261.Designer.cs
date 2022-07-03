
namespace DLWMS.WinForms.IspitIB140261
{
    partial class frmCovidTestIB140261
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
            this.cmbStudneti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRezultatTesta = new System.Windows.Forms.ComboBox();
            this.cbNalazDostavljen = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.lblBrojTestova = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojTestova = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NalazDostavljen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student:";
            // 
            // cmbStudneti
            // 
            this.cmbStudneti.FormattingEnabled = true;
            this.cmbStudneti.Location = new System.Drawing.Point(15, 25);
            this.cmbStudneti.Name = "cmbStudneti";
            this.cmbStudneti.Size = new System.Drawing.Size(242, 21);
            this.cmbStudneti.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum testiranja:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(263, 26);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rezultat testa:";
            // 
            // cmbRezultatTesta
            // 
            this.cmbRezultatTesta.FormattingEnabled = true;
            this.cmbRezultatTesta.Location = new System.Drawing.Point(467, 25);
            this.cmbRezultatTesta.Name = "cmbRezultatTesta";
            this.cmbRezultatTesta.Size = new System.Drawing.Size(121, 21);
            this.cmbRezultatTesta.TabIndex = 5;
            // 
            // cbNalazDostavljen
            // 
            this.cbNalazDostavljen.AutoSize = true;
            this.cbNalazDostavljen.Location = new System.Drawing.Point(595, 28);
            this.cbNalazDostavljen.Name = "cbNalazDostavljen";
            this.cbNalazDostavljen.Size = new System.Drawing.Size(104, 17);
            this.cbNalazDostavljen.TabIndex = 6;
            this.cbNalazDostavljen.Text = "Nalaz dostavljen";
            this.cbNalazDostavljen.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(705, 22);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Rezultat,
            this.NalazDostavljen});
            this.dgvPretraga.Location = new System.Drawing.Point(12, 52);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.Size = new System.Drawing.Size(768, 205);
            this.dgvPretraga.TabIndex = 8;
            // 
            // lblBrojTestova
            // 
            this.lblBrojTestova.Location = new System.Drawing.Point(12, 280);
            this.lblBrojTestova.Name = "lblBrojTestova";
            this.lblBrojTestova.Size = new System.Drawing.Size(181, 17);
            this.lblBrojTestova.TabIndex = 9;
            this.lblBrojTestova.Text = "/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerisi);
            this.groupBox1.Controls.Add(this.txtBrojTestova);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(199, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 55);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generisanje testova";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Broj testova:";
            // 
            // txtBrojTestova
            // 
            this.txtBrojTestova.Location = new System.Drawing.Point(83, 17);
            this.txtBrojTestova.Name = "txtBrojTestova";
            this.txtBrojTestova.Size = new System.Drawing.Size(100, 20);
            this.txtBrojTestova.TabIndex = 12;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(189, 15);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(75, 23);
            this.btnGenerisi.TabIndex = 11;
            this.btnGenerisi.Text = "Generisi";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObrisi);
            this.groupBox2.Location = new System.Drawing.Point(482, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 55);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brisanje testova";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(6, 19);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(131, 23);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "OBRIŠI TESTOVE";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(705, 284);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 14;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Studenti";
            this.Student.FillWeight = 117.7665F;
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.FillWeight = 117.5664F;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Rezultat
            // 
            this.Rezultat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rezultat.DataPropertyName = "Rezultat";
            this.Rezultat.FillWeight = 89.82803F;
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.Name = "Rezultat";
            // 
            // NalazDostavljen
            // 
            this.NalazDostavljen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NalazDostavljen.DataPropertyName = "NalazDostavljen";
            this.NalazDostavljen.FillWeight = 74.83905F;
            this.NalazDostavljen.HeaderText = "NalazDostavljen";
            this.NalazDostavljen.Name = "NalazDostavljen";
            // 
            // frmCovidTestIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBrojTestova);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbNalazDostavljen);
            this.Controls.Add(this.cmbRezultatTesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStudneti);
            this.Controls.Add(this.label1);
            this.Name = "frmCovidTestIB140261";
            this.Text = "frmCovidTestIB140261";
            this.Load += new System.EventHandler(this.frmCovidTestIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStudneti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRezultatTesta;
        private System.Windows.Forms.CheckBox cbNalazDostavljen;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.Label lblBrojTestova;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.TextBox txtBrojTestova;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NalazDostavljen;
    }
}