﻿
namespace Donem2_Hafta2_List_Koleksiyon_Form
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.btnEkleSayi = new System.Windows.Forms.Button();
            this.lbSayi = new System.Windows.Forms.ListBox();
            this.lbMetin = new System.Windows.Forms.ListBox();
            this.btnEkleMetin = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNesne = new System.Windows.Forms.ListBox();
            this.btnEkleNesne = new System.Windows.Forms.Button();
            this.txtNumaraN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyadN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(114, 34);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 1;
            // 
            // btnEkleSayi
            // 
            this.btnEkleSayi.Location = new System.Drawing.Point(114, 76);
            this.btnEkleSayi.Name = "btnEkleSayi";
            this.btnEkleSayi.Size = new System.Drawing.Size(75, 23);
            this.btnEkleSayi.TabIndex = 2;
            this.btnEkleSayi.Text = "Sayı  Ekle";
            this.btnEkleSayi.UseVisualStyleBackColor = true;
            this.btnEkleSayi.Click += new System.EventHandler(this.btnEkleSayi_Click);
            // 
            // lbSayi
            // 
            this.lbSayi.FormattingEnabled = true;
            this.lbSayi.Location = new System.Drawing.Point(104, 155);
            this.lbSayi.Name = "lbSayi";
            this.lbSayi.Size = new System.Drawing.Size(120, 212);
            this.lbSayi.TabIndex = 3;
            // 
            // lbMetin
            // 
            this.lbMetin.FormattingEnabled = true;
            this.lbMetin.Location = new System.Drawing.Point(357, 155);
            this.lbMetin.Name = "lbMetin";
            this.lbMetin.Size = new System.Drawing.Size(120, 212);
            this.lbMetin.TabIndex = 7;
            // 
            // btnEkleMetin
            // 
            this.btnEkleMetin.Location = new System.Drawing.Point(367, 76);
            this.btnEkleMetin.Name = "btnEkleMetin";
            this.btnEkleMetin.Size = new System.Drawing.Size(75, 23);
            this.btnEkleMetin.TabIndex = 6;
            this.btnEkleMetin.Text = "Metin Ekle";
            this.btnEkleMetin.UseVisualStyleBackColor = true;
            this.btnEkleMetin.Click += new System.EventHandler(this.btnEkleMetin_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(367, 34);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ad Soyad";
            // 
            // lbNesne
            // 
            this.lbNesne.FormattingEnabled = true;
            this.lbNesne.Location = new System.Drawing.Point(601, 151);
            this.lbNesne.Name = "lbNesne";
            this.lbNesne.Size = new System.Drawing.Size(120, 212);
            this.lbNesne.TabIndex = 11;
            // 
            // btnEkleNesne
            // 
            this.btnEkleNesne.Location = new System.Drawing.Point(623, 108);
            this.btnEkleNesne.Name = "btnEkleNesne";
            this.btnEkleNesne.Size = new System.Drawing.Size(75, 23);
            this.btnEkleNesne.TabIndex = 10;
            this.btnEkleNesne.Text = "Nesne Ekle";
            this.btnEkleNesne.UseVisualStyleBackColor = true;
            this.btnEkleNesne.Click += new System.EventHandler(this.btnEkleNesne_Click);
            // 
            // txtNumaraN
            // 
            this.txtNumaraN.Location = new System.Drawing.Point(611, 30);
            this.txtNumaraN.Name = "txtNumaraN";
            this.txtNumaraN.Size = new System.Drawing.Size(100, 20);
            this.txtNumaraN.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numara";
            // 
            // txtAdSoyadN
            // 
            this.txtAdSoyadN.Location = new System.Drawing.Point(611, 69);
            this.txtAdSoyadN.Name = "txtAdSoyadN";
            this.txtAdSoyadN.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyadN.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ad Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAdSoyadN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNesne);
            this.Controls.Add(this.btnEkleNesne);
            this.Controls.Add(this.txtNumaraN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMetin);
            this.Controls.Add(this.btnEkleMetin);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSayi);
            this.Controls.Add(this.btnEkleSayi);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Button btnEkleSayi;
        private System.Windows.Forms.ListBox lbSayi;
        private System.Windows.Forms.ListBox lbMetin;
        private System.Windows.Forms.Button btnEkleMetin;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbNesne;
        private System.Windows.Forms.Button btnEkleNesne;
        private System.Windows.Forms.TextBox txtNumaraN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyadN;
        private System.Windows.Forms.Label label4;
    }
}

