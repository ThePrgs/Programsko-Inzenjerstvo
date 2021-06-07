using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal pretvorba;
        public decimal kuna;
        public decimal tecaj;
        

       

        private void button1_Click(object sender, EventArgs e)
        {
            kuna = decimal.Parse(textBox1.Text);
            tecaj = numericUpDown1.Value;
            pretvorba = kuna / tecaj;
            textBox2.Text =pretvorba.ToString();
            PovjestListe unos = new PovjestListe(kuna, pretvorba);
            PovjestListe.povjest.Add(unos);
            foreach (PovjestListe item in PovjestListe.povjest)
            {
                if (item.kune != kuna)
                {
                    textBox3.Text = item.kune + "-" + item.euri;
                }
            }
            
        }

       

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            kuna = decimal.Parse(textBox1.Text);
            tecaj = numericUpDown1.Value;
            pretvorba = kuna / tecaj;
            textBox2.Text = pretvorba.ToString();
            PovjestListe unos = new PovjestListe(kuna, pretvorba);
            PovjestListe.povjest.Add(unos);
            foreach (PovjestListe item in PovjestListe.povjest)
            {
                if (item.euri != pretvorba)
                {
                    textBox3.Text = item.kune + "-" + item.euri;
                }
            }
        }

       
    }
}
