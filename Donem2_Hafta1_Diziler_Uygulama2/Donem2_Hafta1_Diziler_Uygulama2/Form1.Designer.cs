
namespace Donem2_Hafta1_Diziler_Uygulama2
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNot4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listeleNotlar = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdSoyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(103, 23);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazılı1";
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(30, 110);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(34, 20);
            this.txtNot1.TabIndex = 3;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(88, 110);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(34, 20);
            this.txtNot2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazılı2";
            // 
            // txtNot3
            // 
            this.txtNot3.Location = new System.Drawing.Point(154, 110);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.Size = new System.Drawing.Size(34, 20);
            this.txtNot3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sözlü1";
            // 
            // txtNot4
            // 
            this.txtNot4.Location = new System.Drawing.Point(216, 110);
            this.txtNot4.Name = "txtNot4";
            this.txtNot4.Size = new System.Drawing.Size(34, 20);
            this.txtNot4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sözlü2";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(286, 110);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // listeleNotlar
            // 
            this.listeleNotlar.FormattingEnabled = true;
            this.listeleNotlar.Location = new System.Drawing.Point(396, 26);
            this.listeleNotlar.Name = "listeleNotlar";
            this.listeleNotlar.Size = new System.Drawing.Size(150, 173);
            this.listeleNotlar.TabIndex = 11;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(434, 221);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 272);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.listeleNotlar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtNot4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNot3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNot1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "İki Boyutlu diziler Uygulama1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNot3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNot4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listeleNotlar;
        private System.Windows.Forms.Button btnListele;
    }
}

