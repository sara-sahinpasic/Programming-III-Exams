
namespace DLWMS.WinForms.IB140261
{
    partial class frmStudentiSlikeIB140261
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
            this.label2 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSlikaOdDo = new System.Windows.Forms.Label();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis:";
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(15, 25);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(175, 192);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 2;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(210, 25);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(306, 115);
            this.txtOpis.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pregled slika:";
            // 
            // lblSlikaOdDo
            // 
            this.lblSlikaOdDo.AutoSize = true;
            this.lblSlikaOdDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlikaOdDo.Location = new System.Drawing.Point(361, 231);
            this.lblSlikaOdDo.Name = "lblSlikaOdDo";
            this.lblSlikaOdDo.Size = new System.Drawing.Size(14, 20);
            this.lblSlikaOdDo.TabIndex = 5;
            this.lblSlikaOdDo.Text = "/";
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(464, 316);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(52, 23);
            this.btnNaprijed.TabIndex = 6;
            this.btnNaprijed.Text = "=>";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(210, 316);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(52, 23);
            this.btnNazad.TabIndex = 7;
            this.btnNazad.Text = "<=";
            this.btnNazad.UseVisualStyleBackColor = true;
            // 
            // lblDatum
            // 
            this.lblDatum.Location = new System.Drawing.Point(210, 432);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(306, 18);
            this.lblDatum.TabIndex = 8;
       //     this.lblDatum.Click += new System.EventHandler(this.lblDatum_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.Location = new System.Drawing.Point(207, 450);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(309, 91);
            this.lblOpis.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(424, 146);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(92, 23);
            this.btnDodajSliku.TabIndex = 10;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // frmStudentiSlikeIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.lblSlikaOdDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentiSlikeIB140261";
            this.Text = "frmStudentiSlikeIB140261";
            this.Load += new System.EventHandler(this.frmStudentiSlikeIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSlikaOdDo;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDodajSliku;
    }
}