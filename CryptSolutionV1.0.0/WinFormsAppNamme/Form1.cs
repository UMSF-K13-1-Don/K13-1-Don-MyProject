using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppNamme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sh1 = textBox1.Text;

            char[] ch1 = sh1.ToCharArray();

            for (int i=0;i<ch1.Length;i++)
            {
                textBox4.Text = Convert.ToString(ch1[i]);
            }
            
            //int key_str = Convert.ToInt32(textBox2.Text);
            //int key_sto = Convert.ToInt32(textBox3.Text);

        }
    }
}
