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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relacija rel = new Relacija();
            rel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prodazba prodazba = new Prodazba();
            prodazba.ShowDialog();

        }
    }
}
