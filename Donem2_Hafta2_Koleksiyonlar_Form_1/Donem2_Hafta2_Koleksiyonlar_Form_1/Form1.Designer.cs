
namespace Donem2_Hafta2_Koleksiyonlar_Form_1
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
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblSehir = new System.Windows.Forms.Label();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnArayaEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(142, 76);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSehirAdi.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(63, 114);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(68, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Add";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblSehir
            // 
            this.lblSehir.AutoSize = true;
            this.lblSehir.Location = new System.Drawing.Point(60, 169);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(35, 13);
            this.lblSehir.TabIndex = 3;
            this.lblSehir.Text = "label2";
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(483, 53);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(120, 173);
            this.lbListe.TabIndex = 4;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(511, 263);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnArayaEkle
            // 
            this.btnArayaEkle.Location = new System.Drawing.Point(154, 114);
            this.btnArayaEkle.Name = "btnArayaEkle";
            this.btnArayaEkle.Size = new System.Drawing.Size(62, 23);
            this.btnArayaEkle.TabIndex = 6;
            this.btnArayaEkle.Text = "Insert";
            this.btnArayaEkle.UseVisualStyleBackColor = true;
            this.btnArayaEkle.Click += new System.EventHandler(this.btnArayaEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(240, 114);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(62, 23);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Remove";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(329, 114);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(62, 23);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 337);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnArayaEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSehirAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnArayaEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAra;
    }
}

