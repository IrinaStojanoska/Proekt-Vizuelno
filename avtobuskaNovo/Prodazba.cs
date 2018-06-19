using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using avtobuskaNovo.Properties;
using Microsoft.VisualBasic;
namespace avtobuskaNovo
{
    public partial class Prodazba : Form
    {
        public Bilet b {get;set;}
        public Relacii rel { get; set; }
        public object Strings { get; private set; }

        public Prodazba()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
           
        }

        private void Prodazba_Load(object sender, EventArgs e)
        {
            
        }

        private void Prodazba_Load_1(object sender, EventArgs e)
        {
           
        
        }
      /*  public static class StringExtension
        {
            public static string GetLast(string source, int tail)
            {
                if (tail >= source.Length)
                    return source;
                return source.Substring(source.Length - tail);
            }
        } */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = listBox1.SelectedIndex != -1;
           

            string niza = Convert.ToString(listBox1.SelectedItem);
            niza = niza.Substring(niza.Length - 3);
            if(checkBox1.Checked)
            {
                textBox1.Text = Convert.ToString(niza);
            }
            if(checkBox2.Checked)
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(niza) * 2);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни?", "Избриши релација", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни?", "Избриши превозник", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nov_Prevoznik prev = new Nov_Prevoznik();
            //  Prodazba pro = new Prodazba();
            if (prev.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                listBox2.Items.Add(prev.prevoznik);
                //  listBox1.Items.Add(pro.b);

            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
           if(textBox2.Text=="")
            {
                errorProvider1.SetError(textBox2, "Vnesi cas");
                e.Cancel = true;
            }
           else
            {
                errorProvider1.SetError(textBox2,null);
                e.Cancel = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToLongDateString();
            label7.Text = DateTime.Now.ToLongTimeString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(Properties.Resources.World_wide_bus_station1, 20, 20);
            e.Graphics.DrawString("Релација: " + listBox1.SelectedItem, new Font("Arial", 16), Brushes.Black, new Point(20, 200));
            e.Graphics.DrawString("Превозник: " + listBox2.SelectedItem, new Font("Arial", 16), Brushes.Black, new Point(20, 230));
            e.Graphics.DrawString("Час: " + textBox2.Text, new Font("Arial", 16), Brushes.Black, new Point(20, 260));
            e.Graphics.DrawString("Датум: " + dateTimePicker1.Value.ToShortDateString(), new Font("Arial", 16), Brushes.Black, new Point(20, 290));
            e.Graphics.DrawString("Цена: " + textBox1.Text, new Font("Arial", 16), Brushes.Black, new Point(20, 320));

            //e.Graphics.DrawString("Тип: " + radio, new Font("Arial", 16), Brushes.Black, new Point(20, 210));
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = listBox2.SelectedIndex != -1;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
