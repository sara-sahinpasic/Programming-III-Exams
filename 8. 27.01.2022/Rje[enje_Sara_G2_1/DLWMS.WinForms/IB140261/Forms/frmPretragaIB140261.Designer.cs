
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
            this.cmbOcjene = new System.Windows.Forms.ComboBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.Rb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seminarski = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtUnosBrojaOcjena = new System.Windows.Forms.TextBox();
            this.cmbStudenti = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.btnTeorija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maksimalna ocjena:";
            // 
            // cmbOcjene
            // 
            this.cmbOcjene.FormattingEnabled = true;
            this.cmbOcjene.Location = new System.Drawing.Point(119, 12);
            this.cmbOcjene.Name = "cmbOcjene";
            this.cmbOcjene.Size = new System.Drawing.Size(121, 21);
            this.cmbOcjene.TabIndex = 1;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(246, 10);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rb,
            this.ImePrezime,
            this.Predmet,
            this.DatumPolaganja,
            this.Ocjena,
            this.Seminarski});
            this.dgvPretraga.Location = new System.Drawing.Point(12, 41);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(776, 150);
            this.dgvPretraga.TabIndex = 3;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // Rb
            // 
            this.Rb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rb.FillWeight = 47.4763F;
            this.Rb.HeaderText = "Rb";
            this.Rb.Name = "Rb";
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "Student";
            this.ImePrezime.FillWeight = 117.5982F;
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.FillWeight = 111.6559F;
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumPolaganja.DataPropertyName = "DatumPolaganja";
            this.DatumPolaganja.FillWeight = 106.5281F;
            this.DatumPolaganja.HeaderText = "Datum polaganja";
            this.DatumPolaganja.Name = "DatumPolaganja";
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.FillWeight = 110.1426F;
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // Seminarski
            // 
            this.Seminarski.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seminarski.FillWeight = 106.599F;
            this.Seminarski.HeaderText = "";
            this.Seminarski.Name = "Seminarski";
            this.Seminarski.Text = "Seminarski";
            this.Seminarski.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.txtUnosBrojaOcjena);
            this.groupBox1.Controls.Add(this.cmbStudenti);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje položenih:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(55, 131);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(141, 48);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(437, 106);
            this.txtInfo.TabIndex = 9;
            // 
            // txtUnosBrojaOcjena
            // 
            this.txtUnosBrojaOcjena.Location = new System.Drawing.Point(9, 48);
            this.txtUnosBrojaOcjena.Name = "txtUnosBrojaOcjena";
            this.txtUnosBrojaOcjena.Size = new System.Drawing.Size(118, 20);
            this.txtUnosBrojaOcjena.TabIndex = 8;
            // 
            // cmbStudenti
            // 
            this.cmbStudenti.FormattingEnabled = true;
            this.cmbStudenti.Location = new System.Drawing.Point(9, 97);
            this.cmbStudenti.Name = "cmbStudenti";
            this.cmbStudenti.Size = new System.Drawing.Size(121, 21);
            this.cmbStudenti.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Info:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj ocjena:";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(713, 197);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 5;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // btnTeorija
            // 
            this.btnTeorija.Location = new System.Drawing.Point(713, 242);
            this.btnTeorija.Name = "btnTeorija";
            this.btnTeorija.Size = new System.Drawing.Size(75, 23);
            this.btnTeorija.TabIndex = 6;
            this.btnTeorija.Text = "Teorija";
            this.btnTeorija.UseVisualStyleBackColor = true;
            this.btnTeorija.Click += new System.EventHandler(this.btnTeorija_Click);
            // 
            // frmPretragaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.btnTeorija);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.cmbOcjene);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB140261";
            this.Load += new System.EventHandler(this.frmPretragaIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOcjene;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtUnosBrojaOcjena;
        private System.Windows.Forms.ComboBox cmbStudenti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Button btnTeorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Seminarski;
    }
}