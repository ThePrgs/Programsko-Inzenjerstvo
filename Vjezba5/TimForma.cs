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
    public partial class TimForma : Form
    {
        public TimForma()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> timDodaj = new List<string>();
            if (textBox1.Text!="" && textBox2.Text != "")
            {
                foreach (Tim item in Tim.PopisTimova)
                {
                    if (textBox2.Text != item.ImeTima)
                    {
                        break;
                    }
                    else
                    {
                        timDodaj = item.ImenaIgraca;
                    }

                }
                foreach (Igraci item in Igraci.IgraciPopis)
                {
                    if (item.Ime == textBox1.Text)
                    {
                        if (timDodaj.Count < 11)
                        {
                            timDodaj.Add(item.Ime);
                            textBox1.Clear();
                        }
                    }

                }
                Tim tim = new Tim(textBox1.Text, timDodaj);
                Tim.PopisTimova.Add(tim);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IspisForma ispis = new IspisForma();
            ispis.ShowDialog();
        }
    }
}
