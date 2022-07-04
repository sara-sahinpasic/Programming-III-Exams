
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
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblMaxProsjekOstvario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerisiInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSadrzajInfo = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(93, 9);
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
            this.dgvPretraga.Location = new System.Drawing.Point(12, 35);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(776, 197);
            this.dgvPretraga.TabIndex = 2;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.FillWeight = 136.6737F;
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // PolozeniPredmeti
            // 
            this.PolozeniPredmeti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PolozeniPredmeti.DataPropertyName = "NazivPredmeta";
            this.PolozeniPredmeti.FillWeight = 137.6575F;
            this.PolozeniPredmeti.HeaderText = "Polozeni predmeti";
            this.PolozeniPredmeti.Name = "PolozeniPredmeti";
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojPolozenih.DataPropertyName = "BrojPolozenih";
            this.BrojPolozenih.FillWeight = 68.9536F;
            this.BrojPolozenih.HeaderText = "Broj polozenih";
            this.BrojPolozenih.Name = "BrojPolozenih";
            // 
            // Prosjek
            // 
            this.Prosjek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prosjek.DataPropertyName = "Prosjek";
            this.Prosjek.FillWeight = 67.88267F;
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.Name = "Prosjek";
            // 
            // Ispiti
            // 
            this.Ispiti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ispiti.FillWeight = 88.83249F;
            this.Ispiti.HeaderText = "";
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.UseColumnTextForButtonValue = true;
            // 
            // lblProsjek
            // 
            this.lblProsjek.Location = new System.Drawing.Point(12, 235);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(358, 23);
            this.lblProsjek.TabIndex = 3;
            this.lblProsjek.Text = "/";
            // 
            // lblMaxProsjekOstvario
            // 
            this.lblMaxProsjekOstvario.Location = new System.Drawing.Point(430, 235);
            this.lblMaxProsjekOstvario.Name = "lblMaxProsjekOstvario";
            this.lblMaxProsjekOstvario.Size = new System.Drawing.Size(358, 23);
            this.lblMaxProsjekOstvario.TabIndex = 4;
            this.lblMaxProsjekOstvario.Text = "/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerisiInfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSadrzajInfo);
            this.groupBox1.Controls.Add(this.txtSadrzaj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 177);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // btnGenerisiInfo
            // 
            this.btnGenerisiInfo.Location = new System.Drawing.Point(666, 112);
            this.btnGenerisiInfo.Name = "btnGenerisiInfo";
            this.btnGenerisiInfo.Size = new System.Drawing.Size(101, 23);
            this.btnGenerisiInfo.TabIndex = 7;
            this.btnGenerisiInfo.Text = "Generiši info";
            this.btnGenerisiInfo.UseVisualStyleBackColor = true;
            this.btnGenerisiInfo.Click += new System.EventHandler(this.btnGenerisiInfo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sadržaj info:";
            // 
            // lblSadrzajInfo
            // 
            this.lblSadrzajInfo.Location = new System.Drawing.Point(84, 109);
            this.lblSadrzajInfo.Name = "lblSadrzajInfo";
            this.lblSadrzajInfo.Size = new System.Drawing.Size(358, 65);
            this.lblSadrzajInfo.TabIndex = 6;
            this.lblSadrzajInfo.Text = "/";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(6, 32);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(761, 74);
            this.txtSadrzaj.TabIndex = 6;
            this.txtSadrzaj.TextChanged += new System.EventHandler(this.txtSadrzaj_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unesite sadržaj:";
            // 
            // frmPretragaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMaxProsjekOstvario);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.label1);
            this.Name = "frmPretragaIB140261";
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIB140261_Load);
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
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label lblMaxProsjekOstvario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerisiInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSadrzajInfo;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozeniPredmeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
    }
}