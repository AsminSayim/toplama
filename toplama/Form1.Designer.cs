﻿namespace toplama
{
    partial class Form1
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
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.txtKutu = new System.Windows.Forms.TextBox();
            this.txtKutu1 = new System.Windows.Forms.TextBox();
            this.btnToplam = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi1.Location = new System.Drawing.Point(12, 28);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(66, 24);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "Sayı 1";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi2.Location = new System.Drawing.Point(12, 53);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(66, 24);
            this.lblSayi2.TabIndex = 1;
            this.lblSayi2.Text = "Sayı 2";
            // 
            // txtKutu
            // 
            this.txtKutu.Location = new System.Drawing.Point(94, 31);
            this.txtKutu.Name = "txtKutu";
            this.txtKutu.Size = new System.Drawing.Size(100, 20);
            this.txtKutu.TabIndex = 2;
            // 
            // txtKutu1
            // 
            this.txtKutu1.Location = new System.Drawing.Point(94, 58);
            this.txtKutu1.Name = "txtKutu1";
            this.txtKutu1.Size = new System.Drawing.Size(100, 20);
            this.txtKutu1.TabIndex = 3;
            // 
            // btnToplam
            // 
            this.btnToplam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnToplam.Location = new System.Drawing.Point(205, 16);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(93, 35);
            this.btnToplam.TabIndex = 4;
            this.btnToplam.Text = "Toplam";
            this.btnToplam.UseVisualStyleBackColor = false;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // btnBol
            // 
            this.btnBol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBol.Location = new System.Drawing.Point(304, 58);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(93, 35);
            this.btnBol.TabIndex = 5;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = false;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnCıkar
            // 
            this.btnCıkar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCıkar.Location = new System.Drawing.Point(304, 16);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(93, 35);
            this.btnCıkar.TabIndex = 6;
            this.btnCıkar.Text = "Çıkar";
            this.btnCıkar.UseVisualStyleBackColor = false;
            this.btnCıkar.Click += new System.EventHandler(this.btnCıkar_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.BackColor = System.Drawing.Color.Yellow;
            this.btnCarp.Location = new System.Drawing.Point(205, 58);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(93, 35);
            this.btnCarp.TabIndex = 7;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = false;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(12, 112);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(70, 24);
            this.lblSonuc.TabIndex = 8;
            this.lblSonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 195);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.txtKutu1);
            this.Controls.Add(this.txtKutu);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.TextBox txtKutu;
        private System.Windows.Forms.TextBox txtKutu1;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Label lblSonuc;
    }
}

         