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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Jezik hrvatski = new Jezik("hrvatski");
            Jezik.PopisJezika.Add(hrvatski);
            Jezik engleski = new Jezik("engleski");
            Jezik.PopisJezika.Add(engleski);
            Stanje = new StanjeProjekta();
            
        }

        public StanjeProjekta Stanje;

        private void button2_Click(object sender, EventArgs e)
        {
            if((textBox1.Text != "") && (textBox2.Text != ""))
            {
                foreach (Jezik item in Jezik.PopisJezika)
                {
                    if (item.NazivJezika == textBox1.Text)
                    {
                        Stanje.IzvrsiPrijelaz(Enumeracija.Dogadjaj.RijecUnesena);
                        item.Rijeci.Add(textBox2.Text);
                    }
                }
            }
        }

        private void buttonPrevoditelj_Click(object sender, EventArgs e)
        {
            PrevoditeljForma novaForma = new PrevoditeljForma();
            novaForma.ShowDialog();
        }
    }
}
