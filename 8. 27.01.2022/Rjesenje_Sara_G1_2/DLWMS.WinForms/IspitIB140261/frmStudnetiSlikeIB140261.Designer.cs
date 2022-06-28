
namespace DLWMS.WinForms.IspitIB140261
{
    partial class frmStudnetiSlikeIB140261
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSlikaOdDo = new System.Windows.Forms.Label();
            this.pbGalerijaSlika = new System.Windows.Forms.PictureBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpisGalerija = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalerijaSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(12, 25);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(143, 131);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(164, 25);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(317, 102);
            this.txtOpis.TabIndex = 3;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(406, 133);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 4;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pregled slika:";
            // 
            // lblSlikaOdDo
            // 
            this.lblSlikaOdDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlikaOdDo.Location = new System.Drawing.Point(161, 208);
            this.lblSlikaOdDo.Name = "lblSlikaOdDo";
            this.lblSlikaOdDo.Size = new System.Drawing.Size(179, 31);
            this.lblSlikaOdDo.TabIndex = 6;
            this.lblSlikaOdDo.Text = "/";
            this.lblSlikaOdDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbGalerijaSlika
            // 
            this.pbGalerijaSlika.Location = new System.Drawing.Point(164, 242);
            this.pbGalerijaSlika.Name = "pbGalerijaSlika";
            this.pbGalerijaSlika.Size = new System.Drawing.Size(176, 180);
            this.pbGalerijaSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGalerijaSlika.TabIndex = 7;
            this.pbGalerijaSlika.TabStop = false;
            // 
            // lblDatum
            // 
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(161, 425);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(179, 31);
            this.lblDatum.TabIndex = 8;
            this.lblDatum.Text = "/";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpisGalerija
            // 
            this.lblOpisGalerija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpisGalerija.Location = new System.Drawing.Point(53, 456);
            this.lblOpisGalerija.Name = "lblOpisGalerija";
            this.lblOpisGalerija.Size = new System.Drawing.Size(394, 102);
            this.lblOpisGalerija.TabIndex = 9;
            this.lblOpisGalerija.Text = "/";
            this.lblOpisGalerija.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(346, 319);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(75, 23);
            this.btnNaprijed.TabIndex = 10;
            this.btnNaprijed.Text = "==>";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            this.btnNaprijed.Click += new System.EventHandler(this.btnNaprijed_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(83, 319);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(75, 23);
            this.btnNazad.TabIndex = 11;
            this.btnNazad.Text = "<==";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // frmStudnetiSlikeIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 580);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnNaprijed);
            this.Controls.Add(this.lblOpisGalerija);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.pbGalerijaSlika);
            this.Controls.Add(this.lblSlikaOdDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSlika);
            this.Name = "frmStudnetiSlikeIB140261";
            this.Text = "frmStudnetiSlikeIB140261";
            this.Load += new System.EventHandler(this.frmStudnetiSlikeIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalerijaSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSlikaOdDo;
        private System.Windows.Forms.PictureBox pbGalerijaSlika;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpisGalerija;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.Button btnNazad;
    }
}