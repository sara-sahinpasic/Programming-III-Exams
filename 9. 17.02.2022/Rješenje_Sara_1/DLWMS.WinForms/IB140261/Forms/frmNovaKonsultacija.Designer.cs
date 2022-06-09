
namespace DLWMS.WinForms.IB140261
{
    partial class frmNovaKonsultacija
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberite predmet:";
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Location = new System.Drawing.Point(15, 25);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(319, 21);
            this.cmbPredmeti.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odaberite vrijeme konsultacija:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(343, 26);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(319, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unesite napomenu:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(15, 76);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(647, 103);
            this.txtNapomena.TabIndex = 5;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(506, 185);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(587, 185);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmNovaKonsultacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 230);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPredmeti);
            this.Controls.Add(this.label1);
            this.Name = "frmNovaKonsultacija";
            this.Text = "Novi zahtjev za konsultacijama";
            this.Load += new System.EventHandler(this.frmNovaKonsultacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider err;
    }
}