
namespace DLWMS.WinForms.IB140261
{
    partial class frmKonsultacijeIB140261
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
            this.lblListaKonsultacijeStudnet = new System.Windows.Forms.Label();
            this.btnDodajZahtjev = new System.Windows.Forms.Button();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojZahtjeva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnDodajTh = new System.Windows.Forms.Button();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaKonsultacijeStudnet
            // 
            this.lblListaKonsultacijeStudnet.Location = new System.Drawing.Point(12, 9);
            this.lblListaKonsultacijeStudnet.Name = "lblListaKonsultacijeStudnet";
            this.lblListaKonsultacijeStudnet.Size = new System.Drawing.Size(480, 23);
            this.lblListaKonsultacijeStudnet.TabIndex = 0;
            this.lblListaKonsultacijeStudnet.Text = "/";
            // 
            // btnDodajZahtjev
            // 
            this.btnDodajZahtjev.Location = new System.Drawing.Point(689, 12);
            this.btnDodajZahtjev.Name = "btnDodajZahtjev";
            this.btnDodajZahtjev.Size = new System.Drawing.Size(99, 23);
            this.btnDodajZahtjev.TabIndex = 1;
            this.btnDodajZahtjev.Text = "Dodaj zahjtev";
            this.btnDodajZahtjev.UseVisualStyleBackColor = true;
            this.btnDodajZahtjev.Click += new System.EventHandler(this.btnDodajZahtjev_Click);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Vrijeme,
            this.Napomena,
            this.Brisi});
            this.dgvPretraga.Location = new System.Drawing.Point(12, 41);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.Size = new System.Drawing.Size(776, 226);
            this.dgvPretraga.TabIndex = 2;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj zahtjeva:";
            // 
            // txtBrojZahtjeva
            // 
            this.txtBrojZahtjeva.Location = new System.Drawing.Point(24, 325);
            this.txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            this.txtBrojZahtjeva.Size = new System.Drawing.Size(121, 20);
            this.txtBrojZahtjeva.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Predmet:";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(24, 364);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(121, 21);
            this.cmbPredmeti.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Info:";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(151, 325);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(537, 89);
            this.txtInfo.TabIndex = 8;
            // 
            // btnDodajTh
            // 
            this.btnDodajTh.Location = new System.Drawing.Point(70, 391);
            this.btnDodajTh.Name = "btnDodajTh";
            this.btnDodajTh.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTh.TabIndex = 9;
            this.btnDodajTh.Text = "Dodaj =>";
            this.btnDodajTh.UseVisualStyleBackColor = true;
            this.btnDodajTh.Click += new System.EventHandler(this.btnDodajTh_Click);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(713, 289);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 10;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 153);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje zahtjeva";
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmeti";
            this.Predmet.FillWeight = 76.82809F;
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // Vrijeme
            // 
            this.Vrijeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vrijeme.DataPropertyName = "VrijemeOdrzavanja";
            this.Vrijeme.FillWeight = 75.29153F;
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.Name = "Vrijeme";
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.FillWeight = 172.5888F;
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            // 
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brisi.FillWeight = 75.29153F;
            this.Brisi.HeaderText = "";
            this.Brisi.Name = "Brisi";
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // frmKonsultacijeIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.btnDodajTh);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojZahtjeva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.btnDodajZahtjev);
            this.Controls.Add(this.lblListaKonsultacijeStudnet);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKonsultacijeIB140261";
            this.Text = "frmKonsultacijeIB140261";
            this.Load += new System.EventHandler(this.frmKonsultacijeIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaKonsultacijeStudnet;
        private System.Windows.Forms.Button btnDodajZahtjev;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojZahtjeva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnDodajTh;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}