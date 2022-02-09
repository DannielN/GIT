using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo = Convert.ToInt32(textBox1.Text);
            int fakt = 1;
            for (int k = 2; k <= cislo; k++)
            {
                fakt *= k;
            }
            label1.Text = ("Faktorial = " + fakt);
        }
    }
}
