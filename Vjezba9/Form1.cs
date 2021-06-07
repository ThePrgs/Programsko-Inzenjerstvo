using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba9
{
    public partial class Form1 : Form
    {

        northwndCopy_2019Entities entities = new northwndCopy_2019Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            orderDataGridView.EndEdit();
            entities.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entities.Orders.Load();
            orderBindingSource.DataSource = entities.Orders.Local;
            
        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            entities.Order_Details.Load();
            order_DetailBindingSource.DataSource = (orderBindingSource.Current as Order).Order_Details;
            
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if((toolStripTextBox1.Text!="") && (toolStripTextBox2.Text!=""))
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ukupno = 0;
            for (int i = 0; i < order_DetailDataGridView.Rows.Count; i++)
            {
                double cijenaJednog = Convert.ToDouble(order_DetailDataGridView.Rows[i].Cells[2].Value);
                double kolicina = Convert.ToDouble(order_DetailDataGridView.Rows[i].Cells[3].Value);
                ukupno += kolicina * cijenaJednog;
            }
            double porez = ukupno * 0.13;
            MessageBox.Show("Ukupno: " + ukupno.ToString() + " Porez: " + porez.ToString());
        }
    }
}
