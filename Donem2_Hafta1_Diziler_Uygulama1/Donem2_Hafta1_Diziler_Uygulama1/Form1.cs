﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donem2_Hafta1_Diziler_Uygulama1
{
    public partial class Form1 : Form
    {
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            isimler[index] = txtAdSoyad.Text;
            notlar[index] = int.Parse(txtDersNotu.Text);
            index++;
            txtAdSoyad.Text = "";
            txtDersNotu.Text = "";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                {
                    lbListe.Items.Add(isimler[i] + "-->" + notlar[i]);
                }
            }
        }

        private void btnEnYuksek_Click(object sender, EventArgs e)
        {
            int enYuksek = notlar[0];
            for(int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] > enYuksek)
                {
                    enYuksek = notlar[i];
                }
            }

            txtEnYuksek.Text = enYuksek.ToString();
        }

        private void btnEnDusuk_Click(object sender, EventArgs e)
        {
            int enDusuk = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] < enDusuk)
                {
                    enDusuk = notlar[i];
                }
            }

            txtEnDusuk.Text = enDusuk.ToString();
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            
            int toplam = 0;
            double ortalama = 0;

            for(int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            txtOrtalama.Text = ortalama.ToString();
        }
    }
    }

