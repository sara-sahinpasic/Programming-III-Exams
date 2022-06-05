
namespace DLWMS.WinForms.IspitIB140261
{
    partial class frmPretragaIB140261
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
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozeniPredmeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblProsjekOcjen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.lblZnakovi = new System.Windows.Forms.Label();
            this.lblSuglasnik = new System.Windows.Forms.Label();
            this.lblSamoglasnik = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(93, 12);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(695, 20);
            this.txtImePrezime.TabIndex = 1;
            this.txtImePrezime.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.PolozeniPredmeti,
            this.BrojPolozenih,
            this.Prosjek,
            this.Ispiti});
            this.dgvPretraga.Location = new System.Drawing.Point(15, 38);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(773, 236);
            this.dgvPretraga.TabIndex = 2;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "Student";
            this.ImePrezime.FillWeight = 128.4916F;
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // PolozeniPredmeti
            // 
            this.PolozeniPredmeti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PolozeniPredmeti.DataPropertyName = "Predmet";
            this.PolozeniPredmeti.FillWeight = 129.0126F;
            this.PolozeniPredmeti.HeaderText = "Polozeni predmeti";
            this.PolozeniPredmeti.Name = "PolozeniPredmeti";
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPolozenih.DataPropertyName = "BrojPolozenih";
            this.BrojPolozenih.FillWeight = 73.59167F;
            this.BrojPolozenih.HeaderText = "Broj položenih";
            this.BrojPolozenih.Name = "BrojPolozenih";
            // 
            // Prosjek
            // 
            this.Prosjek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.FillWeight = 67.38124F;
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.Name = "Prosjek";
            // 
            // Ispiti
            // 
            this.Ispiti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ispiti.FillWeight = 101.5228F;
            this.Ispiti.HeaderText = "";
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Najveći prosjek ostvario:";
            // 
            // lblStudent
            // 
            this.lblStudent.Location = new System.Drawing.Point(688, 277);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(100, 23);
            this.lblStudent.TabIndex = 6;
            // 
            // lblProsjekOcjen
            // 
            this.lblProsjekOcjen.Location = new System.Drawing.Point(149, 277);
            this.lblProsjekOcjen.Name = "lblProsjekOcjen";
            this.lblProsjekOcjen.Size = new System.Drawing.Size(100, 23);
            this.lblProsjekOcjen.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerisi);
            this.groupBox1.Controls.Add(this.lblZnakovi);
            this.groupBox1.Controls.Add(this.lblSuglasnik);
            this.groupBox1.Controls.Add(this.lblSamoglasnik);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSadrzaj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 197);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(645, 124);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(122, 23);
            this.btnGenerisi.TabIndex = 20;
            this.btnGenerisi.Text = "Generiši info";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // lblZnakovi
            // 
            this.lblZnakovi.Location = new System.Drawing.Point(192, 168);
            this.lblZnakovi.Name = "lblZnakovi";
            this.lblZnakovi.Size = new System.Drawing.Size(103, 16);
            this.lblZnakovi.TabIndex = 19;
            // 
            // lblSuglasnik
            // 
            this.lblSuglasnik.Location = new System.Drawing.Point(189, 152);
            this.lblSuglasnik.Name = "lblSuglasnik";
            this.lblSuglasnik.Size = new System.Drawing.Size(103, 16);
            this.lblSuglasnik.TabIndex = 18;
            // 
            // lblSamoglasnik
            // 
            this.lblSamoglasnik.Location = new System.Drawing.Point(189, 139);
            this.lblSamoglasnik.Name = "lblSamoglasnik";
            this.lblSamoglasnik.Size = new System.Drawing.Size(103, 16);
            this.lblSamoglasnik.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(83, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Znakova (?,!,<,>,*):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Suglasnika:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Samoglasnika:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sadržaj info:";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(9, 32);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(758, 86);
            this.txtSadrzaj.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unesite sadržaj:";
            // 
            // frmPretragaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProsjekOcjen);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB140261";
            this.Text = "frmPretragaIB140261";
            this.Load += new System.EventHandler(this.frmPretragaIB140261_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblProsjekOcjen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Label lblZnakovi;
        private System.Windows.Forms.Label lblSuglasnik;
        private System.Windows.Forms.Label lblSamoglasnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
    }
}