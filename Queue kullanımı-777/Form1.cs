using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue_kullanımı_777
{
    public partial class Form1 : Form
    {
        Stack<string> musteri = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void musteriCagir(Label lbl)
        {
            try
            {
                lbl.Text = musteri.Pop();
            }
            catch (Exception e){
                MessageBox.Show(e.Message);
            }      

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            musteri.Push(txtAd.Text);
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            musteri.Push("Ufuk");
            musteri.Push("Rabia");
            musteri.Push("Kübra");
            musteri.Push("Hayrunnisa");
            musteri.Push("Melisa");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira1);
        }

        private void btnGetir2_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira2);
        }

        private void btnGetir3_Click(object sender, EventArgs e)
        {
            musteriCagir(lblSira3);
        }

       
    }
}
