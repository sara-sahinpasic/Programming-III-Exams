
namespace cSharpIntroWinForms.IB140261
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
            this.dgvPretragaPredmeta = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnosBrojaThread = new System.Windows.Forms.TextBox();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumaThreading = new System.Windows.Forms.Label();
            this.lblProsjekOcjena = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaPredmeta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predmeta:";
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.Location = new System.Drawing.Point(102, 19);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(607, 20);
            this.txtNazivPredmeta.TabIndex = 1;
            this.txtNazivPredmeta.TextChanged += new System.EventHandler(this.txtNazivPredmeta_TextChanged);
            // 
            // dgvPretragaPredmeta
            // 
            this.dgvPretragaPredmeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretragaPredmeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Poruke});
            this.dgvPretragaPredmeta.Location = new System.Drawing.Point(15, 55);
            this.dgvPretragaPredmeta.Name = "dgvPretragaPredmeta";
            this.dgvPretragaPredmeta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretragaPredmeta.Size = new System.Drawing.Size(694, 232);
            this.dgvPretragaPredmeta.TabIndex = 2;
            this.dgvPretragaPredmeta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretragaPredmeta_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "Korisnik";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.FillWeight = 40F;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.FillWeight = 40F;
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // Poruke
            // 
            this.Poruke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Poruke.FillWeight = 55F;
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.Name = "Poruke";
            this.Poruke.Text = "Poruke";
            this.Poruke.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // txtUnosBrojaThread
            // 
            this.txtUnosBrojaThread.Location = new System.Drawing.Point(6, 23);
            this.txtUnosBrojaThread.Name = "txtUnosBrojaThread";
            this.txtUnosBrojaThread.Size = new System.Drawing.Size(176, 20);
            this.txtUnosBrojaThread.TabIndex = 5;
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(188, 19);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSumiraj.TabIndex = 6;
            this.btnSumiraj.Text = "Sumiraj";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Suma:";
            // 
            // lblSumaThreading
            // 
            this.lblSumaThreading.Location = new System.Drawing.Point(6, 98);
            this.lblSumaThreading.Name = "lblSumaThreading";
            this.lblSumaThreading.Size = new System.Drawing.Size(100, 23);
            this.lblSumaThreading.TabIndex = 8;
            // 
            // lblProsjekOcjena
            // 
            this.lblProsjekOcjena.Location = new System.Drawing.Point(155, 314);
            this.lblProsjekOcjena.Name = "lblProsjekOcjena";
            this.lblProsjekOcjena.Size = new System.Drawing.Size(53, 13);
            this.lblProsjekOcjena.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnosBrojaThread);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSumaThreading);
            this.groupBox1.Controls.Add(this.btnSumiraj);
            this.groupBox1.Location = new System.Drawing.Point(440, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 124);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // frmPretragaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.lblProsjekOcjena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPretragaPredmeta);
            this.Controls.Add(this.txtNazivPredmeta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPretragaIB140261";
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretragaPredmeta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivPredmeta;
        private System.Windows.Forms.DataGridView dgvPretragaPredmeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnosBrojaThread;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumaThreading;
        private System.Windows.Forms.Label lblProsjekOcjena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Poruke;
    }
}