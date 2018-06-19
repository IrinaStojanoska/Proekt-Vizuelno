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
    public partial class NovaRelacija : Form
    {
        public Relacii rel { get; set; }
        public NovaRelacija()
        {
            InitializeComponent();
        
        }

        private void NovaRelacija_Load(object sender, EventArgs e)
        {
       
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(textBox1.Text.Trim().Length==0)
            {
                errorProvider1.SetError(textBox1, "Vnesi pojdovna destinacija");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
                e.Cancel = false;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(textBox2, "Vnesi krajna destinacija");
                e.Cancel = true;
            }
            else
            {
                errorProvider2.SetError(textBox2, null);
                e.Cancel = false;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
        
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text.Trim().Length == 0)
            {
                errorProvider3.SetError(textBox4, "Vnesi cena");
                e.Cancel = true;
            }
            else
            {
                errorProvider3.SetError(textBox4, null);
                e.Cancel = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            rel = new Relacii(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox4.Text));
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private void button1_Validated(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
