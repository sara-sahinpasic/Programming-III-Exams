
namespace DLWMS.WinForms.IB140261
{
    partial class frmKonsultacije
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnDodajZahtjev = new System.Windows.Forms.Button();
            this.dgvKonsultacije = new System.Windows.Forms.DataGridView();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbPredmet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojZahtjeva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.Location = new System.Drawing.Point(12, 9);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(451, 23);
            this.lblStudent.TabIndex = 0;
            // 
            // btnDodajZahtjev
            // 
            this.btnDodajZahtjev.Location = new System.Drawing.Point(697, 12);
            this.btnDodajZahtjev.Name = "btnDodajZahtjev";
            this.btnDodajZahtjev.Size = new System.Drawing.Size(91, 23);
            this.btnDodajZahtjev.TabIndex = 1;
            this.btnDodajZahtjev.Text = "Dodaj zahtjev";
            this.btnDodajZahtjev.UseVisualStyleBackColor = true;
            this.btnDodajZahtjev.Click += new System.EventHandler(this.btnDodajZahtjev_Click);
            // 
            // dgvKonsultacije
            // 
            this.dgvKonsultacije.AllowUserToAddRows = false;
            this.dgvKonsultacije.AllowUserToOrderColumns = true;
            this.dgvKonsultacije.AllowUserToResizeColumns = false;
            this.dgvKonsultacije.AllowUserToResizeRows = false;
            this.dgvKonsultacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonsultacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Predmet,
            this.Vrijeme,
            this.Napomena,
            this.Brisi});
            this.dgvKonsultacije.Location = new System.Drawing.Point(15, 60);
            this.dgvKonsultacije.Name = "dgvKonsultacije";
            this.dgvKonsultacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKonsultacije.Size = new System.Drawing.Size(776, 191);
            this.dgvKonsultacije.TabIndex = 2;
            this.dgvKonsultacije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonsultacije_CellContentClick);
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.FillWeight = 52.81876F;
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // Vrijeme
            // 
            this.Vrijeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vrijeme.DataPropertyName = "VrijemeOdrzavanja";
            this.Vrijeme.FillWeight = 50.76142F;
            this.Vrijeme.HeaderText = "Vrijeme";
            this.Vrijeme.Name = "Vrijeme";
            // 
            // Napomena
            // 
            this.Napomena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.FillWeight = 181.0789F;
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            // 
            // Brisi
            // 
            this.Brisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brisi.FillWeight = 115.3409F;
            this.Brisi.HeaderText = "";
            this.Brisi.Name = "Brisi";
            this.Brisi.Text = "Briši";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.cmbPredmet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBrojZahtjeva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 157);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje zahtjeva";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(162, 32);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(524, 101);
            this.txtInfo.TabIndex = 6;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Info:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(55, 110);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbPredmet
            // 
            this.cmbPredmet.FormattingEnabled = true;
            this.cmbPredmet.Location = new System.Drawing.Point(9, 83);
            this.cmbPredmet.Name = "cmbPredmet";
            this.cmbPredmet.Size = new System.Drawing.Size(121, 21);
            this.cmbPredmet.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Predmet:";
            // 
            // txtBrojZahtjeva
            // 
            this.txtBrojZahtjeva.Location = new System.Drawing.Point(9, 32);
            this.txtBrojZahtjeva.Name = "txtBrojZahtjeva";
            this.txtBrojZahtjeva.Size = new System.Drawing.Size(121, 20);
            this.txtBrojZahtjeva.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj zahtjeva:";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(713, 263);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(75, 23);
            this.btnPrintaj.TabIndex = 7;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // frmKonsultacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKonsultacije);
            this.Controls.Add(this.btnDodajZahtjev);
            this.Controls.Add(this.lblStudent);
            this.Name = "frmKonsultacije";
            this.Text = "frmKonsultacije";
            this.Load += new System.EventHandler(this.frmKonsultacije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonsultacije)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnDodajZahtjev;
        private System.Windows.Forms.DataGridView dgvKonsultacije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbPredmet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojZahtjeva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrijeme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewButtonColumn Brisi;
    }
}