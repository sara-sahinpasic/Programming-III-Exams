
namespace DLWMS.WinForms.IB140261
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
            this.dgvCovid = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NalazDostavljen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbRezultati = new System.Windows.Forms.ComboBox();
            this.cbNalazDostavljen = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblBrojTestova = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.txtBrojTestova = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCovid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCovid
            // 
            this.dgvCovid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCovid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Rezultat,
            this.NalazDostavljen});
            this.dgvCovid.Location = new System.Drawing.Point(11, 65);
            this.dgvCovid.Name = "dgvCovid";
            this.dgvCovid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCovid.Size = new System.Drawing.Size(776, 247);
            this.dgvCovid.TabIndex = 0;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.FillWeight = 138.2579F;
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.FillWeight = 131.9797F;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Rezultat
            // 
            this.Rezultat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rezultat.DataPropertyName = "Rezultat";
            this.Rezultat.FillWeight = 60.01998F;
            this.Rezultat.HeaderText = "Rezultat";
            this.Rezultat.Name = "Rezultat";
            // 
            // NalazDostavljen
            // 
            this.NalazDostavljen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NalazDostavljen.DataPropertyName = "NalazDostavljen";
            this.NalazDostavljen.FillWeight = 69.74241F;
            this.NalazDostavljen.HeaderText = "NalazDostavljen";
            this.NalazDostavljen.Name = "NalazDostavljen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum testiranja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rezultat testa:";
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(12, 38);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(209, 21);
            this.cmbStudenti.TabIndex = 4;
        //    this.cmbStudenti.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(234, 39);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(234, 20);
            this.dtpDatum.TabIndex = 5;
            // 
            // cmbRezultati
            // 
            this.cmbRezultati.FormattingEnabled = true;
            this.cmbRezultati.Items.AddRange(new object[] {
            " ",
            "Negativan",
            "Pozitivan"});
            this.cmbRezultati.Location = new System.Drawing.Point(474, 38);
            this.cmbRezultati.Name = "cmbRezultati";
            this.cmbRezultati.Size = new System.Drawing.Size(121, 21);
            this.cmbRezultati.TabIndex = 6;
            // 
            // cbNalazDostavljen
            // 
            this.cbNalazDostavljen.AutoSize = true;
            this.cbNalazDostavljen.Location = new System.Drawing.Point(602, 41);
            this.cbNalazDostavljen.Name = "cbNalazDostavljen";
            this.cbNalazDostavljen.Size = new System.Drawing.Size(104, 17);
            this.cbNalazDostavljen.TabIndex = 7;
            this.cbNalazDostavljen.Text = "Nalaz dostavljen";
            this.cbNalazDostavljen.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(712, 35);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblBrojTestova
            // 
            this.lblBrojTestova.Location = new System.Drawing.Point(12, 335);
            this.lblBrojTestova.Name = "lblBrojTestova";
            this.lblBrojTestova.Size = new System.Drawing.Size(165, 23);
            this.lblBrojTestova.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerisi);
            this.groupBox1.Controls.Add(this.txtBrojTestova);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(209, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 64);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generisanje testova:";
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(184, 30);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(75, 23);
            this.btnGenerisi.TabIndex = 11;
            this.btnGenerisi.Text = "Generiši";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // txtBrojTestova
            // 
            this.txtBrojTestova.Location = new System.Drawing.Point(78, 33);
            this.txtBrojTestova.Name = "txtBrojTestova";
            this.txtBrojTestova.Size = new System.Drawing.Size(100, 20);
            this.txtBrojTestova.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Broj testova:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrisi);
            this.groupBox2.Location = new System.Drawing.Point(501, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 64);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brisanje testova:";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(6, 26);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(114, 23);
            this.btnBrisi.TabIndex = 11;
            this.btnBrisi.Text = "OBRIŠI TESTOVE";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(712, 344);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 14;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmCovidTestIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBrojTestova);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbNalazDostavljen);
            this.Controls.Add(this.cmbRezultati);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cmbStudenti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCovid);
            this.Name = "frmCovidTestIB140261";
            this.Text = "frmCovidTestIB140261";
            this.Load += new System.EventHandler(this.frmCovidTestIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCovid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCovid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cmbRezultati;
        private System.Windows.Forms.CheckBox cbNalazDostavljen;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblBrojTestova;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.TextBox txtBrojTestova;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rezultat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NalazDostavljen;
    }
}