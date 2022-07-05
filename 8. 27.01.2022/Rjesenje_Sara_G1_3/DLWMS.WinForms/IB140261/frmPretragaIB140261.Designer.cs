
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPolaganja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrisiPredmet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Slike = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDO = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.btnTeorija = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predmeta:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(102, 12);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(686, 20);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Predmet,
            this.DatumPolaganja,
            this.Ocjena,
            this.BrisiPredmet,
            this.Slike});
            this.dgvPretraga.Location = new System.Drawing.Point(15, 38);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(773, 225);
            this.dgvPretraga.TabIndex = 2;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "Student";
            this.ImePrezime.FillWeight = 106.5554F;
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.FillWeight = 106.0161F;
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // DatumPolaganja
            // 
            this.DatumPolaganja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumPolaganja.DataPropertyName = "DatumPolaganja";
            this.DatumPolaganja.FillWeight = 107.2339F;
            this.DatumPolaganja.HeaderText = "Datum polaganja";
            this.DatumPolaganja.Name = "DatumPolaganja";
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.FillWeight = 106.599F;
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // BrisiPredmet
            // 
            this.BrisiPredmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrisiPredmet.FillWeight = 88.02892F;
            this.BrisiPredmet.HeaderText = "";
            this.BrisiPredmet.Name = "BrisiPredmet";
            this.BrisiPredmet.Text = "Brisi predmet";
            this.BrisiPredmet.UseColumnTextForButtonValue = true;
            // 
            // Slike
            // 
            this.Slike.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Slike.FillWeight = 85.56676F;
            this.Slike.HeaderText = "";
            this.Slike.Name = "Slike";
            this.Slike.Text = "Slike";
            this.Slike.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sumiraj brojeve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Od:";
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(15, 318);
            this.txtOD.Name = "txtOD";
            this.txtOD.Size = new System.Drawing.Size(100, 20);
            this.txtOD.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Do:";
            // 
            // txtDO
            // 
            this.txtDO.Location = new System.Drawing.Point(126, 318);
            this.txtDO.Name = "txtDO";
            this.txtDO.Size = new System.Drawing.Size(100, 20);
            this.txtDO.TabIndex = 7;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(349, 318);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ReadOnly = true;
            this.txtRezultat.Size = new System.Drawing.Size(250, 20);
            this.txtRezultat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Suma:";
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(252, 318);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSumiraj.TabIndex = 10;
            this.btnSumiraj.Text = "Sumiraj =>";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(713, 272);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 11;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // btnTeorija
            // 
            this.btnTeorija.Location = new System.Drawing.Point(713, 315);
            this.btnTeorija.Name = "btnTeorija";
            this.btnTeorija.Size = new System.Drawing.Size(75, 23);
            this.btnTeorija.TabIndex = 12;
            this.btnTeorija.Text = "Teorija";
            this.btnTeorija.UseVisualStyleBackColor = true;
            this.btnTeorija.Click += new System.EventHandler(this.btnTeorija_Click);
            // 
            // frmPretragaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.btnTeorija);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnSumiraj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB140261";
            this.Text = "frmPretragaIB140261";
            this.Load += new System.EventHandler(this.frmPretragaIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDO;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Button btnTeorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPolaganja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn BrisiPredmet;
        private System.Windows.Forms.DataGridViewButtonColumn Slike;
    }
}