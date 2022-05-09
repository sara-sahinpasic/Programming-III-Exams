
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
            this.txtImeIliPrezime = new System.Windows.Forms.TextBox();
            this.dgvListaPredmeta = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PolozeniPredmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPolozenih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prosjek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispiti = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProsjekOcjena = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKoJeOstvarioNjaveciProsjek = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSadrzajInfo = new System.Windows.Forms.Label();
            this.btnGenerisiInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPredmeta)).BeginInit();
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
            // txtImeIliPrezime
            // 
            this.txtImeIliPrezime.Location = new System.Drawing.Point(93, 12);
            this.txtImeIliPrezime.Name = "txtImeIliPrezime";
            this.txtImeIliPrezime.Size = new System.Drawing.Size(695, 20);
            this.txtImeIliPrezime.TabIndex = 1;
            this.txtImeIliPrezime.TextChanged += new System.EventHandler(this.txtImeIliPrezime_TextChanged);
            // 
            // dgvListaPredmeta
            // 
            this.dgvListaPredmeta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPredmeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPredmeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.PolozeniPredmet,
            this.BrojPolozenih,
            this.Prosjek,
            this.Ispiti});
            this.dgvListaPredmeta.Location = new System.Drawing.Point(15, 38);
            this.dgvListaPredmeta.Name = "dgvListaPredmeta";
            this.dgvListaPredmeta.Size = new System.Drawing.Size(773, 190);
            this.dgvListaPredmeta.TabIndex = 2;
            this.dgvListaPredmeta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPredmeta_CellClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "Student";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // PolozeniPredmet
            // 
            this.PolozeniPredmet.DataPropertyName = "Predmet";
            this.PolozeniPredmet.HeaderText = "Polozeni predmet";
            this.PolozeniPredmet.Name = "PolozeniPredmet";
            // 
            // BrojPolozenih
            // 
            this.BrojPolozenih.DataPropertyName = "brojPolozenih";
            this.BrojPolozenih.HeaderText = "Broj polozenih";
            this.BrojPolozenih.Name = "BrojPolozenih";
            // 
            // Prosjek
            // 
            this.Prosjek.HeaderText = "Prosjek";
            this.Prosjek.Name = "Prosjek";
            // 
            // Ispiti
            // 
            this.Ispiti.HeaderText = "";
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ispiti.Text = "Ispiti";
            this.Ispiti.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prosjek prikazanih ocjena:";
            // 
            // lblProsjekOcjena
            // 
            this.lblProsjekOcjena.Location = new System.Drawing.Point(149, 242);
            this.lblProsjekOcjena.Name = "lblProsjekOcjena";
            this.lblProsjekOcjena.Size = new System.Drawing.Size(80, 13);
            this.lblProsjekOcjena.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Najveći prosjek ostvario:";
            // 
            // lblKoJeOstvarioNjaveciProsjek
            // 
            this.lblKoJeOstvarioNjaveciProsjek.Location = new System.Drawing.Point(627, 242);
            this.lblKoJeOstvarioNjaveciProsjek.Name = "lblKoJeOstvarioNjaveciProsjek";
            this.lblKoJeOstvarioNjaveciProsjek.Size = new System.Drawing.Size(161, 13);
            this.lblKoJeOstvarioNjaveciProsjek.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unesite sadržaj:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 311);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(764, 79);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sadržaj info:";
            // 
            // lblSadrzajInfo
            // 
            this.lblSadrzajInfo.Location = new System.Drawing.Point(74, 124);
            this.lblSadrzajInfo.Name = "lblSadrzajInfo";
            this.lblSadrzajInfo.Size = new System.Drawing.Size(205, 56);
            this.lblSadrzajInfo.TabIndex = 10;
            // 
            // btnGenerisiInfo
            // 
            this.btnGenerisiInfo.Location = new System.Drawing.Point(656, 119);
            this.btnGenerisiInfo.Name = "btnGenerisiInfo";
            this.btnGenerisiInfo.Size = new System.Drawing.Size(114, 23);
            this.btnGenerisiInfo.TabIndex = 11;
            this.btnGenerisiInfo.Text = "Generiši info";
            this.btnGenerisiInfo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSadrzajInfo);
            this.groupBox1.Controls.Add(this.btnGenerisiInfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 192);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Threading";
            // 
            // frmPretragaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblKoJeOstvarioNjaveciProsjek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProsjekOcjena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListaPredmeta);
            this.Controls.Add(this.txtImeIliPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPretragaIB140261";
            this.Text = "Pretraga";
            this.Load += new System.EventHandler(this.frmPretragaIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPredmeta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImeIliPrezime;
        private System.Windows.Forms.DataGridView dgvListaPredmeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProsjekOcjena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKoJeOstvarioNjaveciProsjek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSadrzajInfo;
        private System.Windows.Forms.Button btnGenerisiInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PolozeniPredmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPolozenih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prosjek;
        private System.Windows.Forms.DataGridViewButtonColumn Ispiti;
    }
}