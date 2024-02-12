
namespace Donem2_Hafta1_Diziler_Uygulama1
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtDersNotu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnYuksek = new System.Windows.Forms.Button();
            this.txtEnYuksek = new System.Windows.Forms.TextBox();
            this.txtEnDusuk = new System.Windows.Forms.TextBox();
            this.btnEnDusuk = new System.Windows.Forms.Button();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "AdSoyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(148, 42);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(148, 121);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(438, 12);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(173, 264);
            this.lbListe.TabIndex = 3;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(667, 82);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtDersNotu
            // 
            this.txtDersNotu.Location = new System.Drawing.Point(148, 95);
            this.txtDersNotu.Name = "txtDersNotu";
            this.txtDersNotu.Size = new System.Drawing.Size(100, 20);
            this.txtDersNotu.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "DersNotu";
            // 
            // btnEnYuksek
            // 
            this.btnEnYuksek.Location = new System.Drawing.Point(148, 151);
            this.btnEnYuksek.Name = "btnEnYuksek";
            this.btnEnYuksek.Size = new System.Drawing.Size(75, 23);
            this.btnEnYuksek.TabIndex = 7;
            this.btnEnYuksek.Text = "En Yüksek";
            this.btnEnYuksek.UseVisualStyleBackColor = true;
            this.btnEnYuksek.Click += new System.EventHandler(this.btnEnYuksek_Click);
            // 
            // txtEnYuksek
            // 
            this.txtEnYuksek.Location = new System.Drawing.Point(240, 151);
            this.txtEnYuksek.Name = "txtEnYuksek";
            this.txtEnYuksek.Size = new System.Drawing.Size(100, 20);
            this.txtEnYuksek.TabIndex = 8;
            // 
            // txtEnDusuk
            // 
            this.txtEnDusuk.Location = new System.Drawing.Point(240, 189);
            this.txtEnDusuk.Name = "txtEnDusuk";
            this.txtEnDusuk.Size = new System.Drawing.Size(100, 20);
            this.txtEnDusuk.TabIndex = 10;
            // 
            // btnEnDusuk
            // 
            this.btnEnDusuk.Location = new System.Drawing.Point(148, 189);
            this.btnEnDusuk.Name = "btnEnDusuk";
            this.btnEnDusuk.Size = new System.Drawing.Size(75, 23);
            this.btnEnDusuk.TabIndex = 9;
            this.btnEnDusuk.Text = "En Düşük";
            this.btnEnDusuk.UseVisualStyleBackColor = true;
            this.btnEnDusuk.Click += new System.EventHandler(this.btnEnDusuk_Click);
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(240, 228);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalama.TabIndex = 12;
            // 
            // btnOrtalama
            // 
            this.btnOrtalama.Location = new System.Drawing.Point(148, 228);
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.Size = new System.Drawing.Size(75, 23);
            this.btnOrtalama.TabIndex = 11;
            this.btnOrtalama.Text = "Ortalama";
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 328);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.btnOrtalama);
            this.Controls.Add(this.txtEnDusuk);
            this.Controls.Add(this.btnEnDusuk);
            this.Controls.Add(this.txtEnYuksek);
            this.Controls.Add(this.btnEnYuksek);
            this.Controls.Add(this.txtDersNotu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Diziler Uygulama1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtDersNotu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnYuksek;
        private System.Windows.Forms.TextBox txtEnYuksek;
        private System.Windows.Forms.TextBox txtEnDusuk;
        private System.Windows.Forms.Button btnEnDusuk;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Button btnOrtalama;
    }
}

