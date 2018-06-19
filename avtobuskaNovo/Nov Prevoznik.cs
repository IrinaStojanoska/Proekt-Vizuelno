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
    public partial class Nov_Prevoznik : Form
    {
      public  Prevoznik prevoznik { get; set; }
        public Nov_Prevoznik()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(textBox1.Text=="")
            {
                errorProvider1.SetError(textBox1, "Vnesi ime");
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
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Vnesi mesto");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox2, null);
                e.Cancel = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nov_Prevoznik_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          prevoznik=new Prevoznik(textBox1.Text, textBox2.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
