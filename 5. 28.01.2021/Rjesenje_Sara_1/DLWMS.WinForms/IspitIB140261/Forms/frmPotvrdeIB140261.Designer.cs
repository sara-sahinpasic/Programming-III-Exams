
namespace DLWMS.WinForms.IspitIB140261.Forms
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
            this.btnSpasi = new System.Windows.Forms.Button();
            this.dgvStudentiPotvrde = new System.Windows.Forms.DataGridView();
            this.lblTrenutnoPotvrda = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPotvrde)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrojPotvrda
            // 
            this.txtBrojPotvrda.Location = new System.Drawing.Point(12, 31);
            this.txtBrojPotvrda.Name = "txtBrojPotvrda";
            this.txtBrojPotvrda.Size = new System.Drawing.Size(148, 20);
            this.txtBrojPotvrda.TabIndex = 0;
            // 
            // btnGenerisiPotvrde
            // 
            this.btnGenerisiPotvrde.Location = new System.Drawing.Point(166, 31);
            this.btnGenerisiPotvrde.Name = "btnGenerisiPotvrde";
            this.btnGenerisiPotvrde.Size = new System.Drawing.Size(108, 23);
            this.btnGenerisiPotvrde.TabIndex = 1;
            this.btnGenerisiPotvrde.Text = "Generiši potvrde";
            this.btnGenerisiPotvrde.UseVisualStyleBackColor = true;
            this.btnGenerisiPotvrde.Click += new System.EventHandler(this.btnGenerisiPotvrde_Click);
            // 
            // btnObrisiPotvrde
            // 
            this.btnObrisiPotvrde.Location = new System.Drawing.Point(354, 31);
            this.btnObrisiPotvrde.Name = "btnObrisiPotvrde";
            this.btnObrisiPotvrde.Size = new System.Drawing.Size(108, 23);
            this.btnObrisiPotvrde.TabIndex = 2;
            this.btnObrisiPotvrde.Text = "Obriši potvrde";
            this.btnObrisiPotvrde.UseVisualStyleBackColor = true;
            this.btnObrisiPotvrde.Click += new System.EventHandler(this.btnObrisiPotvrde_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(596, 31);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(108, 23);
            this.btnSpasi.TabIndex = 3;
            this.btnSpasi.Text = "Spasi u fajl";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // dgvStudentiPotvrde
            // 
            this.dgvStudentiPotvrde.AllowUserToAddRows = false;
            this.dgvStudentiPotvrde.AllowUserToOrderColumns = true;
            this.dgvStudentiPotvrde.AllowUserToResizeColumns = false;
            this.dgvStudentiPotvrde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentiPotvrde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Svrha,
            this.Izdata});
            this.dgvStudentiPotvrde.Location = new System.Drawing.Point(12, 60);
            this.dgvStudentiPotvrde.Name = "dgvStudentiPotvrde";
            this.dgvStudentiPotvrde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentiPotvrde.Size = new System.Drawing.Size(692, 228);
            this.dgvStudentiPotvrde.TabIndex = 4;
            // 
            // lblTrenutnoPotvrda
            // 
            this.lblTrenutnoPotvrda.Location = new System.Drawing.Point(12, 291);
            this.lblTrenutnoPotvrda.Name = "lblTrenutnoPotvrda";
            this.lblTrenutnoPotvrda.Size = new System.Drawing.Size(214, 23);
            this.lblTrenutnoPotvrda.TabIndex = 5;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.Name = "Svrha";
            // 
            // Izdata
            // 
            this.Izdata.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Izdata.DataPropertyName = "Izdata";
            this.Izdata.HeaderText = "Izdata";
            this.Izdata.Name = "Izdata";
            // 
            // frmPotvrdeIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 323);
            this.Controls.Add(this.lblTrenutnoPotvrda);
            this.Controls.Add(this.dgvStudentiPotvrde);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnObrisiPotvrde);
            this.Controls.Add(this.btnGenerisiPotvrde);
            this.Controls.Add(this.txtBrojPotvrda);
            this.Name = "frmPotvrdeIB140261";
            this.Text = "Potvrde";
            this.Load += new System.EventHandler(this.frmPotvrdeIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentiPotvrde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojPotvrda;
        private System.Windows.Forms.Button btnGenerisiPotvrde;
        private System.Windows.Forms.Button btnObrisiPotvrde;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.DataGridView dgvStudentiPotvrde;
        private System.Windows.Forms.Label lblTrenutnoPotvrda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Svrha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izdata;
    }
}