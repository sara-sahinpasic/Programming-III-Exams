
namespace DLWMS.WinForms.IspitIB140261
{
    partial class frmStudentSeminarskiIB140261
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblPredmet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.lblStranicaOdDo = new System.Windows.Forms.Label();
            this.pbGalerijaSlika = new System.Windows.Forms.PictureBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOpisGalerija = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnNaprijed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalerijaSlika)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(77, 9);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(337, 30);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "/";
            this.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPredmet
            // 
            this.lblPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmet.Location = new System.Drawing.Point(77, 39);
            this.lblPredmet.Name = "lblPredmet";
            this.lblPredmet.Size = new System.Drawing.Size(337, 27);
            this.lblPredmet.TabIndex = 1;
            this.lblPredmet.Text = "/";
            this.lblPredmet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Slika:";
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(12, 100);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(136, 91);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 3;
            this.pbSlika.TabStop = false;
            this.pbSlika.DoubleClick += new System.EventHandler(this.pbSlika_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(154, 100);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(309, 61);
            this.txtOpis.TabIndex = 5;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(388, 168);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 6;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // lblStranicaOdDo
            // 
            this.lblStranicaOdDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStranicaOdDo.Location = new System.Drawing.Point(77, 241);
            this.lblStranicaOdDo.Name = "lblStranicaOdDo";
            this.lblStranicaOdDo.Size = new System.Drawing.Size(337, 39);
            this.lblStranicaOdDo.TabIndex = 7;
            this.lblStranicaOdDo.Text = "/";
            this.lblStranicaOdDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbGalerijaSlika
            // 
            this.pbGalerijaSlika.Location = new System.Drawing.Point(159, 283);
            this.pbGalerijaSlika.Name = "pbGalerijaSlika";
            this.pbGalerijaSlika.Size = new System.Drawing.Size(191, 183);
            this.pbGalerijaSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGalerijaSlika.TabIndex = 8;
            this.pbGalerijaSlika.TabStop = false;
            // 
            // lblDatum
            // 
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(93, 272);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(279, 39);
            this.lblDatum.TabIndex = 9;
            this.lblDatum.Text = "/";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpisGalerija
            // 
            this.lblOpisGalerija.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpisGalerija.Location = new System.Drawing.Point(62, 311);
            this.lblOpisGalerija.Name = "lblOpisGalerija";
            this.lblOpisGalerija.Size = new System.Drawing.Size(337, 64);
            this.lblOpisGalerija.TabIndex = 10;
            this.lblOpisGalerija.Text = "/";
            this.lblOpisGalerija.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(65, 157);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(49, 23);
            this.btnNazad.TabIndex = 11;
            this.btnNazad.Text = "<==";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnNaprijed
            // 
            this.btnNaprijed.Location = new System.Drawing.Point(350, 157);
            this.btnNaprijed.Name = "btnNaprijed";
            this.btnNaprijed.Size = new System.Drawing.Size(49, 23);
            this.btnNaprijed.TabIndex = 12;
            this.btnNaprijed.Text = "==>";
            this.btnNaprijed.UseVisualStyleBackColor = true;
            this.btnNaprijed.Click += new System.EventHandler(this.btnNaprijed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDatum);
            this.groupBox1.Controls.Add(this.lblOpisGalerija);
            this.groupBox1.Controls.Add(this.btnNazad);
            this.groupBox1.Controls.Add(this.btnNaprijed);
            this.groupBox1.Location = new System.Drawing.Point(15, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 387);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled seminarskog";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmStudentSeminarskiIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 607);
            this.Controls.Add(this.pbGalerijaSlika);
            this.Controls.Add(this.lblStranicaOdDo);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPredmet);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudentSeminarskiIB140261";
            this.Text = "frmStudentSeminarskiIB140261";
            this.Load += new System.EventHandler(this.frmStudentSeminarskiIB140261_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGalerijaSlika)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblPredmet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label lblStranicaOdDo;
        private System.Windows.Forms.PictureBox pbGalerijaSlika;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOpisGalerija;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnNaprijed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider err;
    }
}