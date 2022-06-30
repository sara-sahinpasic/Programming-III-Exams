
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
            this.txtUnosBroja = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpasiFile = new System.Windows.Forms.Button();
            this.dgvPotvrde = new System.Windows.Forms.DataGridView();
            this.lblTrenutnoPotvrda = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnosBroja
            // 
            this.txtUnosBroja.Location = new System.Drawing.Point(12, 12);
            this.txtUnosBroja.Name = "txtUnosBroja";
            this.txtUnosBroja.Size = new System.Drawing.Size(150, 20);
            this.txtUnosBroja.TabIndex = 0;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(168, 12);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(120, 23);
            this.btnGenerisi.TabIndex = 1;
            this.btnGenerisi.Text = "Generiši potvrde";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(386, 12);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(120, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši potvrde";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpasiFile
            // 
            this.btnSpasiFile.Location = new System.Drawing.Point(668, 12);
            this.btnSpasiFile.Name = "btnSpasiFile";
            this.btnSpasiFile.Size = new System.Drawing.Size(120, 23);
            this.btnSpasiFile.TabIndex = 3;
            this.btnSpasiFile.Text = "Spasi u fajl";
            this.btnSpasiFile.UseVisualStyleBackColor = true;
            this.btnSpasiFile.Click += new System.EventHandler(this.btnSpasiFile_Click);
            // 
            // dgvPotvrde
            // 
            this.dgvPotvrde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotvrde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Datum,
            this.Svrha,
            this.Izdata});
            this.dgvPotvrde.Location = new System.Drawing.Point(15, 60);
            this.dgvPotvrde.Name = "dgvPotvrde";
            this.dgvPotvrde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPotvrde.Size = new System.Drawing.Size(773, 224);
            this.dgvPotvrde.TabIndex = 4;
            // 
            // lblTrenutnoPotvrda
            // 
            this.lblTrenutnoPotvrda.Location = new System.Drawing.Point(12, 287);
            this.lblTrenutnoPotvrda.Name = "lblTrenutnoPotvrda";
            this.lblTrenutnoPotvrda.Size = new System.Drawing.Size(409, 23);
            this.lblTrenutnoPotvrda.TabIndex = 5;
            this.lblTrenutnoPotvrda.Text = "/";
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Studenti";
            this.Student.FillWeight = 107.6142F;
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.FillWeight = 105.6988F;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.FillWeight = 105.3275F;
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.Name = "Svrha";
            // 
            // Izdata
            // 
            this.Izdata.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Izdata.DataPropertyName = "Izdata";
            this.Izdata.FillWeight = 81.35946F;
            this.Izdata.HeaderText = "Izdata";
            this.Izdata.Name = "Izdata";
            // 
            // frmPotvrdeIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.lblTrenutnoPotvrda);
            this.Controls.Add(this.dgvPotvrde);
            this.Controls.Add(this.btnSpasiFile);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.txtUnosBroja);
            this.Name = "frmPotvrdeIB140261";
            this.Text = "Potvrde";
            this.Load += new System.EventHandler(this.frmPotvrdeIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosBroja;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpasiFile;
        private System.Windows.Forms.DataGridView dgvPotvrde;
        private System.Windows.Forms.Label lblTrenutnoPotvrda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Svrha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izdata;
    }
}