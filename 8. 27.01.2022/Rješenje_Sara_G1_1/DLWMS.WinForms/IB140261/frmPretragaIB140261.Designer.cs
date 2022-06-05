
namespace DLWMS.WinForms.IB140261
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
            this.txtNazivPredmeta = new System.Windows.Forms.TextBox();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrisiPredmet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Slike = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOd = new System.Windows.Forms.TextBox();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.txtTeorija = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predmeta:";
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.Location = new System.Drawing.Point(102, 6);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(686, 20);
            this.txtNazivPredmeta.TabIndex = 1;
            this.txtNazivPredmeta.TextChanged += new System.EventHandler(this.txtNazivPredmeta_TextChanged);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.AllowUserToAddRows = false;
            this.dgvPretraga.AllowUserToResizeColumns = false;
            this.dgvPretraga.AllowUserToResizeRows = false;
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Predmet,
            this.DatumPolaganja,
            this.Ocjena,
            this.BrisiPredmet,
            this.Slike});
            this.dgvPretraga.Location = new System.Drawing.Point(15, 32);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(773, 273);
            this.dgvPretraga.TabIndex = 2;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "Student";
            this.ImePrezime.FillWeight = 111.0525F;
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmeti";
            this.Predmet.FillWeight = 97.7599F;
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumPolaganja.DataPropertyName = "DatumPolaganja";
            this.DatumPolaganja.FillWeight = 98.09573F;
            this.DatumPolaganja.HeaderText = "Datum polaganja";
            this.DatumPolaganja.Name = "DatumPolaganja";
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.FillWeight = 76.14214F;
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // BrisiPredmet
            // 
            this.BrisiPredmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrisiPredmet.FillWeight = 110.696F;
            this.BrisiPredmet.HeaderText = "";
            this.BrisiPredmet.Name = "BrisiPredmet";
            this.BrisiPredmet.Text = "Briši predmet";
            this.BrisiPredmet.UseColumnTextForButtonValue = true;
            // 
            // Slike
            // 
            this.Slike.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slike.FillWeight = 106.2538F;
            this.Slike.HeaderText = "";
            this.Slike.Name = "Slike";
            this.Slike.Text = "Slike";
            this.Slike.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sumiraj brojeve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Do:";
            // 
            // txtOd
            // 
            this.txtOd.Location = new System.Drawing.Point(15, 348);
            this.txtOd.Name = "txtOd";
            this.txtOd.Size = new System.Drawing.Size(100, 20);
            this.txtOd.TabIndex = 6;
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(121, 348);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(100, 20);
            this.txtDo.TabIndex = 7;
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(234, 346);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSumiraj.TabIndex = 8;
            this.btnSumiraj.Text = "Sumiraj =>";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Suma:";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(713, 311);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 11;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // txtTeorija
            // 
            this.txtTeorija.Location = new System.Drawing.Point(713, 345);
            this.txtTeorija.Name = "txtTeorija";
            this.txtTeorija.Size = new System.Drawing.Size(75, 23);
            this.txtTeorija.TabIndex = 12;
            this.txtTeorija.Text = "Teorija";
            this.txtTeorija.UseVisualStyleBackColor = true;
            this.txtTeorija.Click += new System.EventHandler(this.txtTeorija_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(322, 348);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.ReadOnly = true;
            this.txtSuma.Size = new System.Drawing.Size(287, 20);
            this.txtSuma.TabIndex = 13;
            // 
            // frmPretragaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.txtTeorija);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSumiraj);
            this.Controls.Add(this.txtDo);
            this.Controls.Add(this.txtOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.txtNazivPredmeta);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB140261";
            this.Load += new System.EventHandler(this.frmPretragaIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivPredmeta;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOd;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Button txtTeorija;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn BrisiPredmet;
        private System.Windows.Forms.DataGridViewButtonColumn Slike;
    }
}