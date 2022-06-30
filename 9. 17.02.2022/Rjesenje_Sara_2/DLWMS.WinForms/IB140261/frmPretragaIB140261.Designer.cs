
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGodinaStudija = new System.Windows.Forms.ComboBox();
            this.dgvPretraga = new System.Windows.Forms.DataGridView();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Konsultacije = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPretraga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime ili prezime:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(93, 16);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(487, 20);
            this.txtImePrezime.TabIndex = 1;
            this.txtImePrezime.TextChanged += new System.EventHandler(this.txtImePrezime_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Godina studija:";
            // 
            // cmbGodinaStudija
            // 
            this.cmbGodinaStudija.FormattingEnabled = true;
            this.cmbGodinaStudija.Location = new System.Drawing.Point(667, 15);
            this.cmbGodinaStudija.Name = "cmbGodinaStudija";
            this.cmbGodinaStudija.Size = new System.Drawing.Size(121, 21);
            this.cmbGodinaStudija.TabIndex = 3;
            this.cmbGodinaStudija.SelectedIndexChanged += new System.EventHandler(this.cmbGodinaStudija_SelectedIndexChanged);
            // 
            // dgvPretraga
            // 
            this.dgvPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.GodinaStudija,
            this.ProsjecnaOcjena,
            this.Konsultacije});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPretraga.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPretraga.Location = new System.Drawing.Point(15, 51);
            this.dgvPretraga.Name = "dgvPretraga";
            this.dgvPretraga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPretraga.Size = new System.Drawing.Size(773, 182);
            this.dgvPretraga.TabIndex = 4;
            this.dgvPretraga.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPretraga_CellContentClick);
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.FillWeight = 102.42F;
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.FillWeight = 98.69554F;
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.Name = "GodinaStudija";
            // 
            // ProsjecnaOcjena
            // 
            this.ProsjecnaOcjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProsjecnaOcjena.DataPropertyName = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.FillWeight = 99.39204F;
            this.ProsjecnaOcjena.HeaderText = "Prosječna ocjena";
            this.ProsjecnaOcjena.Name = "ProsjecnaOcjena";
            // 
            // Konsultacije
            // 
            this.Konsultacije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Konsultacije.FillWeight = 99.49239F;
            this.Konsultacije.HeaderText = "";
            this.Konsultacije.Name = "Konsultacije";
            this.Konsultacije.Text = "Konsultacije";
            this.Konsultacije.UseColumnTextForButtonValue = true;
            // 
            // frmPretragaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 256);
            this.Controls.Add(this.dgvPretraga);
            this.Controls.Add(this.cmbGodinaStudija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImePrezime);
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
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGodinaStudija;
        private System.Windows.Forms.DataGridView dgvPretraga;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewButtonColumn Konsultacije;
    }
}