
namespace cSharpIntroWinForms.IB140261
{
    partial class frmGodineStudijaFormIB140261
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
            this.txtGodinaStudija = new System.Windows.Forms.TextBox();
            this.cbAktivna = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dgvGodineStudija = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodineStudija)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGodinaStudija
            // 
            this.txtGodinaStudija.Location = new System.Drawing.Point(12, 12);
            this.txtGodinaStudija.Name = "txtGodinaStudija";
            this.txtGodinaStudija.Size = new System.Drawing.Size(274, 20);
            this.txtGodinaStudija.TabIndex = 0;
            // 
            // cbAktivna
            // 
            this.cbAktivna.AutoSize = true;
            this.cbAktivna.Location = new System.Drawing.Point(292, 15);
            this.cbAktivna.Name = "cbAktivna";
            this.cbAktivna.Size = new System.Drawing.Size(62, 17);
            this.cbAktivna.TabIndex = 1;
            this.cbAktivna.Text = "Aktivna";
            this.cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(360, 15);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // dgvGodineStudija
            // 
            this.dgvGodineStudija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGodineStudija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Aktivna});
            this.dgvGodineStudija.Location = new System.Drawing.Point(12, 44);
            this.dgvGodineStudija.Name = "dgvGodineStudija";
            this.dgvGodineStudija.Size = new System.Drawing.Size(423, 192);
            this.dgvGodineStudija.TabIndex = 3;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Aktivna
            // 
            this.Aktivna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aktivna.DataPropertyName = "Aktivan";
            this.Aktivna.HeaderText = "Aktivna";
            this.Aktivna.Name = "Aktivna";
            // 
            // frmGodineStudijaFormIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 257);
            this.Controls.Add(this.dgvGodineStudija);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbAktivna);
            this.Controls.Add(this.txtGodinaStudija);
            this.Name = "frmGodineStudijaFormIB140261";
            this.Text = "GodineStudijaForm";
            this.Load += new System.EventHandler(this.frmGodineStudijaFormIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodineStudija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGodinaStudija;
        private System.Windows.Forms.CheckBox cbAktivna;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dgvGodineStudija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivna;
    }
}