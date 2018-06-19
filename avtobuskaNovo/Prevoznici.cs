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
    public partial class Prevoznici : Form
    {
        public Prevoznici()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни?", "Избриши превозник", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nov_Prevoznik prev = new Nov_Prevoznik();
          //  Prodazba pro = new Prodazba();
            if (prev.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                listBox1.Items.Add(prev.prevoznik);
              //  listBox1.Items.Add(pro.b);

            }
        }   
    }
}
