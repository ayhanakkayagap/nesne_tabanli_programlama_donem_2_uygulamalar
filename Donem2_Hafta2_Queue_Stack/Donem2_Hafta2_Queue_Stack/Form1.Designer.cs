
namespace Donem2_Hafta2_Queue_Stack
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
            this.btnSiraAl = new System.Windows.Forms.Button();
            this.btnSiraCikart = new System.Windows.Forms.Button();
            this.listeSiralar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSiraAl
            // 
            this.btnSiraAl.Location = new System.Drawing.Point(98, 138);
            this.btnSiraAl.Name = "btnSiraAl";
            this.btnSiraAl.Size = new System.Drawing.Size(103, 115);
            this.btnSiraAl.TabIndex = 0;
            this.btnSiraAl.Text = "Sıra Al";
            this.btnSiraAl.UseVisualStyleBackColor = true;
            this.btnSiraAl.Click += new System.EventHandler(this.btnSiraAl_Click);
            // 
            // btnSiraCikart
            // 
            this.btnSiraCikart.Location = new System.Drawing.Point(543, 138);
            this.btnSiraCikart.Name = "btnSiraCikart";
            this.btnSiraCikart.Size = new System.Drawing.Size(103, 115);
            this.btnSiraCikart.TabIndex = 1;
            this.btnSiraCikart.Text = "Sıra Çıkart";
            this.btnSiraCikart.UseVisualStyleBackColor = true;
            this.btnSiraCikart.Click += new System.EventHandler(this.btnSiraCikart_Click);
            // 
            // listeSiralar
            // 
            this.listeSiralar.FormattingEnabled = true;
            this.listeSiralar.Location = new System.Drawing.Point(276, 77);
            this.listeSiralar.Name = "listeSiralar";
            this.listeSiralar.Size = new System.Drawing.Size(208, 290);
            this.listeSiralar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listeSiralar);
            this.Controls.Add(this.btnSiraCikart);
            this.Controls.Add(this.btnSiraAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiraAl;
        private System.Windows.Forms.Button btnSiraCikart;
        private System.Windows.Forms.ListBox listeSiralar;
    }
}

