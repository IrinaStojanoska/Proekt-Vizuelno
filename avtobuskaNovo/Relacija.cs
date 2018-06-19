using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtobuskaNovo
{
    public partial class Relacija : Form
    {
       // Relacii r = new Relacii("Skopje", "Kavadarci", 300);
        public Relacija()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни?", "Избриши релација", MessageBoxButtons.YesNo) ==System.Windows.Forms.DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
           NovaRelacija relacija = new NovaRelacija();
            //Prodazba prod = new Prodazba();
            if (relacija.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               
                    listBox1.Items.Add(relacija.rel);
              //  listBox1.Items.Add(prod.b);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
