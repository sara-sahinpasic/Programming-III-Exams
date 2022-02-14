
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
            this.txtnazivPredmeta = new System.Windows.Forms.TextBox();
            this.dgvPolozeniPredmet = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProsjekOcjena = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThread = new System.Windows.Forms.TextBox();
            this.lblThreading = new System.Windows.Forms.Label();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmet)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // txtnazivPredmeta
            // 
            this.txtnazivPredmeta.Location = new System.Drawing.Point(102, 6);
            this.txtnazivPredmeta.Name = "txtnazivPredmeta";
            this.txtnazivPredmeta.Size = new System.Drawing.Size(562, 20);
            this.txtnazivPredmeta.TabIndex = 1;
            this.txtnazivPredmeta.TextChanged += new System.EventHandler(this.txtnazivPredmeta_TextChanged);
            // 
            // dgvPolozeniPredmet
            // 
            this.dgvPolozeniPredmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolozeniPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeniPredmet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Poruke});
            this.dgvPolozeniPredmet.Location = new System.Drawing.Point(15, 32);
            this.dgvPolozeniPredmet.Name = "dgvPolozeniPredmet";
            this.dgvPolozeniPredmet.Size = new System.Drawing.Size(649, 231);
            this.dgvPolozeniPredmet.TabIndex = 2;
            this.dgvPolozeniPredmet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolozeniPredmet_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "Korisnik";
            this.ImePrezime.FillWeight = 126.9035F;
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Predmet
            // 
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.FillWeight = 156.9224F;
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.FillWeight = 65.20933F;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.FillWeight = 60.46553F;
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // Poruke
            // 
            this.Poruke.FillWeight = 90.49918F;
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.Name = "Poruke";
            this.Poruke.Text = "Poruke";
            this.Poruke.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblProsjekOcjena
            // 
            this.lblProsjekOcjena.Location = new System.Drawing.Point(140, 266);
            this.lblProsjekOcjena.Name = "lblProsjekOcjena";
            this.lblProsjekOcjena.Size = new System.Drawing.Size(115, 13);
            this.lblProsjekOcjena.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Suma:";
            // 
            // txtThread
            // 
            this.txtThread.Location = new System.Drawing.Point(16, 15);
            this.txtThread.Name = "txtThread";
            this.txtThread.Size = new System.Drawing.Size(136, 20);
            this.txtThread.TabIndex = 6;
            // 
            // lblThreading
            // 
            this.lblThreading.Location = new System.Drawing.Point(13, 51);
            this.lblThreading.Name = "lblThreading";
            this.lblThreading.Size = new System.Drawing.Size(139, 27);
            this.lblThreading.TabIndex = 7;
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(163, 12);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSumiraj.TabIndex = 8;
            this.btnSumiraj.Text = "Sumiraj";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSumiraj);
            this.groupBox1.Controls.Add(this.lblThreading);
            this.groupBox1.Controls.Add(this.txtThread);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(416, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 99);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // frmPretragaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 382);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProsjekOcjena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPolozeniPredmet);
            this.Controls.Add(this.txtnazivPredmeta);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB140261";
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeniPredmet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnazivPredmeta;
        private System.Windows.Forms.DataGridView dgvPolozeniPredmet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProsjekOcjena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThread;
        private System.Windows.Forms.Label lblThreading;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Poruke;
    }
}