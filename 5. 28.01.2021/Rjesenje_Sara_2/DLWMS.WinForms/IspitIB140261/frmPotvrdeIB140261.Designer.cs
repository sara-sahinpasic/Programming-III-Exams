
namespace DLWMS.WinForms.IspitIB140261
{
    partial class frmPotvrdeIB140261
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
            this.txtBrojPotvrda = new System.Windows.Forms.TextBox();
            this.btnGenerisiPotvrde = new System.Windows.Forms.Button();
            this.btnObrisiPotvrde = new System.Windows.Forms.Button();
            this.btnSpasiUFajl = new System.Windows.Forms.Button();
            this.dgvPotvrde = new System.Windows.Forms.DataGridView();
            this.lblTrenutnoPotvrda = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrojPotvrda
            // 
            this.txtBrojPotvrda.Location = new System.Drawing.Point(12, 12);
            this.txtBrojPotvrda.Name = "txtBrojPotvrda";
            this.txtBrojPotvrda.Size = new System.Drawing.Size(157, 20);
            this.txtBrojPotvrda.TabIndex = 0;
            // 
            // btnGenerisiPotvrde
            // 
            this.btnGenerisiPotvrde.Location = new System.Drawing.Point(175, 12);
            this.btnGenerisiPotvrde.Name = "btnGenerisiPotvrde";
            this.btnGenerisiPotvrde.Size = new System.Drawing.Size(132, 23);
            this.btnGenerisiPotvrde.TabIndex = 1;
            this.btnGenerisiPotvrde.Text = "Generiši potvrde";
            this.btnGenerisiPotvrde.UseVisualStyleBackColor = true;
            this.btnGenerisiPotvrde.Click += new System.EventHandler(this.btnGenerisiPotvrde_Click);
            // 
            // btnObrisiPotvrde
            // 
            this.btnObrisiPotvrde.Location = new System.Drawing.Point(407, 12);
            this.btnObrisiPotvrde.Name = "btnObrisiPotvrde";
            this.btnObrisiPotvrde.Size = new System.Drawing.Size(132, 23);
            this.btnObrisiPotvrde.TabIndex = 2;
            this.btnObrisiPotvrde.Text = "Obriši potvrde";
            this.btnObrisiPotvrde.UseVisualStyleBackColor = true;
            this.btnObrisiPotvrde.Click += new System.EventHandler(this.btnObrisiPotvrde_Click);
            // 
            // btnSpasiUFajl
            // 
            this.btnSpasiUFajl.Location = new System.Drawing.Point(656, 12);
            this.btnSpasiUFajl.Name = "btnSpasiUFajl";
            this.btnSpasiUFajl.Size = new System.Drawing.Size(132, 23);
            this.btnSpasiUFajl.TabIndex = 3;
            this.btnSpasiUFajl.Text = "Spasi u fajl";
            this.btnSpasiUFajl.UseVisualStyleBackColor = true;
            this.btnSpasiUFajl.Click += new System.EventHandler(this.btnSpasiUFajl_Click);
            // 
            // dgvPotvrde
            // 
            this.dgvPotvrde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotvrde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Svrha,
            this.Izdata});
            this.dgvPotvrde.Location = new System.Drawing.Point(12, 41);
            this.dgvPotvrde.Name = "dgvPotvrde";
            this.dgvPotvrde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPotvrde.Size = new System.Drawing.Size(776, 367);
            this.dgvPotvrde.TabIndex = 4;
            // 
            // lblTrenutnoPotvrda
            // 
            this.lblTrenutnoPotvrda.Location = new System.Drawing.Point(12, 411);
            this.lblTrenutnoPotvrda.Name = "lblTrenutnoPotvrda";
            this.lblTrenutnoPotvrda.Size = new System.Drawing.Size(295, 23);
            this.lblTrenutnoPotvrda.TabIndex = 5;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.FillWeight = 105.5838F;
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.FillWeight = 107.7319F;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.FillWeight = 104.3436F;
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.Name = "Svrha";
            // 
            // Izdata
            // 
            this.Izdata.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Izdata.DataPropertyName = "Izdata";
            this.Izdata.FillWeight = 82.34074F;
            this.Izdata.HeaderText = "Izdata";
            this.Izdata.Name = "Izdata";
            // 
            // frmPotvrdeIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTrenutnoPotvrda);
            this.Controls.Add(this.dgvPotvrde);
            this.Controls.Add(this.btnSpasiUFajl);
            this.Controls.Add(this.btnObrisiPotvrde);
            this.Controls.Add(this.btnGenerisiPotvrde);
            this.Controls.Add(this.txtBrojPotvrda);
            this.Name = "frmPotvrdeIB140261";
            this.Text = "Potvrde";
            this.Load += new System.EventHandler(this.frmPotvrdeIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojPotvrda;
        private System.Windows.Forms.Button btnGenerisiPotvrde;
        private System.Windows.Forms.Button btnObrisiPotvrde;
        private System.Windows.Forms.Button btnSpasiUFajl;
        private System.Windows.Forms.DataGridView dgvPotvrde;
        private System.Windows.Forms.Label lblTrenutnoPotvrda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Svrha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izdata;
    }
}