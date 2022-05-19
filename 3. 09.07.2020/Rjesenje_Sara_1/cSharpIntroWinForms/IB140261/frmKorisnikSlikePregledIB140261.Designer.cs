
namespace cSharpIntroWinForms.IB140261
{
    partial class frmKorisnikSlikePregledIB140261
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
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnNaprijed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(114, 12);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(222, 289);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
       //     this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            this.pbSlika.DoubleClick += new System.EventHandler(this.pbSlika_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnNazad
            // 
            this.btnNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNazad.Location = new System.Drawing.Point(22, 95);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 133);
            this.btnNazad.TabIndex = 1;
            this.btnNazad.Text = "<";
            this.btnNazad.UseVisualStyleBackColor = true;
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaprijed.Location = new System.Drawing.Point(355, 95);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(75, 133);
            this.btnNaprijed.TabIndex = 2;
            this.btnNaprijed.Text = ">";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            // 
            // frmKorisnikSlikePregledIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 322);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.pbSlika);
            this.Name = "frmKorisnikSlikePregledIB140261";
            this.Text = "Slike korisnika";
            this.Load += new System.EventHandler(this.frmKorisnikSlikePregledIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnNaprijed;
    }
}