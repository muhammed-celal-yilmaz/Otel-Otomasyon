﻿namespace Otel_Otomasyon
{
    partial class FrmUpdateCheck
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
            this.BtnKod = new System.Windows.Forms.Button();
            this.BtnOnay = new System.Windows.Forms.Button();
            this.TxtOnay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Onay Kodu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sisteme kayıtlı mail adresinize gelen onay kodunu giriniz :";
            // 
            // BtnKod
            // 
            this.BtnKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKod.Location = new System.Drawing.Point(392, 66);
            this.BtnKod.Name = "BtnKod";
            this.BtnKod.Size = new System.Drawing.Size(171, 32);
            this.BtnKod.TabIndex = 2;
            this.BtnKod.Text = "Kodu Gönder";
            this.BtnKod.UseVisualStyleBackColor = true;
            this.BtnKod.Click += new System.EventHandler(this.BtnKod_Click);
            // 
            // BtnOnay
            // 
            this.BtnOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOnay.Location = new System.Drawing.Point(177, 122);
            this.BtnOnay.Name = "BtnOnay";
            this.BtnOnay.Size = new System.Drawing.Size(94, 39);
            this.BtnOnay.TabIndex = 3;
            this.BtnOnay.Text = "Onayla";
            this.BtnOnay.UseVisualStyleBackColor = true;
            this.BtnOnay.Click += new System.EventHandler(this.BtnOnay_Click);
            // 
            // TxtOnay
            // 
            this.TxtOnay.Location = new System.Drawing.Point(116, 78);
            this.TxtOnay.Name = "TxtOnay";
            this.TxtOnay.Size = new System.Drawing.Size(209, 20);
            this.TxtOnay.TabIndex = 4;
            // 
            // FrmUpdateCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 185);
            this.Controls.Add(this.TxtOnay);
            this.Controls.Add(this.BtnOnay);
            this.Controls.Add(this.BtnKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateCheck";
            this.Text = "FrmUpdateCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKod;
        private System.Windows.Forms.Button BtnOnay;
        private System.Windows.Forms.TextBox TxtOnay;
    }
}