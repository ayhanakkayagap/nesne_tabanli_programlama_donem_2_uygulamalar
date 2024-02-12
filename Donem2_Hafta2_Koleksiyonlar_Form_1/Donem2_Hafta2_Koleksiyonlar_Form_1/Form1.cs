using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donem2_Hafta2_Koleksiyonlar_Form_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList sehirler = new ArrayList();

        private void Listele()
        {
            lbListe.Items.Clear();
            foreach (string sehir in sehirler)
            {
                lbListe.Items.Add(sehir);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            sehirler.Add(txtSehirAdi.Text);
            txtSehirAdi.Text = "";
            lblSehir.Text = (string)sehirler[0];//unboxing
            

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lbListe.Items.Clear();
            for(int i = 0; i < sehirler.Count; i++)
            {
                lbListe.Items.Add(sehirler[i]);
            }
        }

        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            
            
            sehirler.Insert(0, "İstanbul");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            sehirler.Remove("Mardin");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (sehirler.Contains("Urfa"))
            {
                MessageBox.Show("Urfa ili var");
            }
            else
            {
                MessageBox.Show("Urfa ili yok");
            }
        }
    }
}
