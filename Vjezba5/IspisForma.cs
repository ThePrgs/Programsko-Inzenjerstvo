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
    public partial class IspisForma : Form
    {
        public IspisForma()
        {
            InitializeComponent();
        }

        private void IspisForma_Load(object sender, EventArgs e)
        {
           




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Tim item in Tim.PopisTimova)
            {
                if (textBox1.Text == item.ImeTima)
                {
                    foreach (string item1 in item.ImenaIgraca)
                    {
                        textBox2.Text = item1;
                    }
                }

            }
        }
    }
}
