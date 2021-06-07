using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba6
{
    public partial class PrevoditeljForma : Form
    {
        public PrevoditeljForma()
        {
            InitializeComponent();
            foreach (Jezik item in Jezik.PopisJezika)
            {
                comboBox1.Items.Add(item.NazivJezika);
                comboBox2.Items.Add(item.NazivJezika);
            }
            Stanje = new StanjeProjekta();
        }

        public StanjeProjekta Stanje;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(" ") || !textBox1.Text.Contains("."))
            {
                Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.PrijevodManjeOdJedneRijeci);
            }
            string rijec="";
         
            string recenica = "";
            if (textBox1.Text != "")
            {             
                foreach (var item in textBox1.Text)
                {
                    if ((item.ToString() == " ") || (item.ToString()=="."))
                    {
                        recenica += Jezik.Prijevod(comboBox1.Text, comboBox2.Text, rijec);
                        rijec = "";
                    }
                    else
                    {
                        rijec += item.ToString();
                    }
                    
                    

                }
                textBox2.Text = recenica;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.RijecUpisanaZaPrijevod);
        }
    }
}
