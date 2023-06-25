using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace Lab_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int parrots = 38;
            textBox1.Text = parrots.ToString("X8");

            int myvalue = 4;
            textBox1.Text = Convert.ToString(myvalue, 2);

            int myValue = 365;
            MessageBox.Show(Convert.ToString(myValue, 8));
            MessageBox.Show(Convert.ToString(myValue, 16));

            
            

        }
        private void butIsNumericVB_Click(object sender, EventArgs e)
        {
            string numstring = textBox1.Text;
            bool bResult1;
            bResult1 = Information.IsNumeric(numstring);
            MessageBox.Show("Является ли " + numstring + " числом: " + bResult1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
