﻿
namespace cSharpIntroWinForms.IB140261
{
    partial class frmGlavnaIB140261
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
            this.btnGodineStudija = new System.Windows.Forms.Button();
            this.btnPolozeniPredmeti = new System.Windows.Forms.Button();
            this.btnIzracunajSumu = new System.Windows.Forms.Button();
            this.txtUnosBroja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGodineStudija
            // 
            this.btnGodineStudija.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGodineStudija.Location = new System.Drawing.Point(26, 47);
            this.btnGodineStudija.Name = "btnGodineStudija";
            this.btnGodineStudija.Size = new System.Drawing.Size(182, 130);
            this.btnGodineStudija.TabIndex = 0;
            this.btnGodineStudija.Text = "Godine studija";
            this.btnGodineStudija.UseVisualStyleBackColor = true;
            this.btnGodineStudija.Click += new System.EventHandler(this.btnGodineStudija_Click);
            // 
            // btnPolozeniPredmeti
            // 
            this.btnPolozeniPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolozeniPredmeti.Location = new System.Drawing.Point(242, 47);
            this.btnPolozeniPredmeti.Name = "btnPolozeniPredmeti";
            this.btnPolozeniPredmeti.Size = new System.Drawing.Size(182, 130);
            this.btnPolozeniPredmeti.TabIndex = 1;
            this.btnPolozeniPredmeti.Text = "Položeni predmeti";
            this.btnPolozeniPredmeti.UseVisualStyleBackColor = true;
            this.btnPolozeniPredmeti.Click += new System.EventHandler(this.btnPolozeniPredmeti_Click);
            // 
            // btnIzracunajSumu
            // 
            this.btnIzracunajSumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzracunajSumu.Location = new System.Drawing.Point(459, 90);
            this.btnIzracunajSumu.Name = "btnIzracunajSumu";
            this.btnIzracunajSumu.Size = new System.Drawing.Size(182, 87);
            this.btnIzracunajSumu.TabIndex = 2;
            this.btnIzracunajSumu.Text = "Izračunaj sumu";
            this.btnIzracunajSumu.UseVisualStyleBackColor = true;
      //      this.btnIzracunajSumu.Click += new System.EventHandler(this.btnIzracunajSumu_ClickAsync);
            // 
            // txtUnosBroja
            // 
            this.txtUnosBroja.Location = new System.Drawing.Point(459, 47);
            this.txtUnosBroja.Name = "txtUnosBroja";
            this.txtUnosBroja.Size = new System.Drawing.Size(182, 20);
            this.txtUnosBroja.TabIndex = 3;
            // 
            // frmGlavnaIB140261
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 221);
            this.Controls.Add(this.txtUnosBroja);
            this.Controls.Add(this.btnIzracunajSumu);
            this.Controls.Add(this.btnPolozeniPredmeti);
            this.Controls.Add(this.btnGodineStudija);
            this.Name = "frmGlavnaIB140261";
            this.Text = "Glavna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGodineStudija;
        private System.Windows.Forms.Button btnPolozeniPredmeti;
        private System.Windows.Forms.Button btnIzracunajSumu;
        private System.Windows.Forms.TextBox txtUnosBroja;
    }
}