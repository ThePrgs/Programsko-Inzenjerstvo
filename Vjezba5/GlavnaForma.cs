using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba5
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void uxDodajIgraca_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text != "")
            {
                Igraci noviIgrac = new Igraci(textBox1.Text, textBox2.Text);
                Igraci.IgraciPopis.Add(noviIgrac);
            }
        }

        private void uxIgracUTim_Click(object sender, EventArgs e)
        {
            TimForma novaTimForma = new TimForma();
            novaTimForma.ShowDialog();
        }
    }
}
