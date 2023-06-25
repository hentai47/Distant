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

namespace Lab_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string partBookTitle = "С# советы";
            string insertText = "Народные";
            string bookTitle = partBookTitle.Insert(3, insertText);
            MessageBox.Show(bookTitle);


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bookTitle = "C# народные советы ";
            bookTitle = bookTitle.Remove(2);
            MessageBox.Show(bookTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookTitle = "C# Народные советы";
            bookTitle = bookTitle.Substring(5, 3);
            MessageBox.Show(bookTitle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str1 = "oko";
            string str2 = "oko2";
            int i = str2.IndexOf(str1);
            if (i >= 0) MessageBox.Show(str1 + "Входит в строку " + str2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tankman = "4";
            string dog = "1";
            textBox1.Text = tankman + dog;
            int all = int.Parse(tankman) + int.Parse(dog);
            textBox1.Text += Environment.NewLine + all.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int charCode = 169;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text = specialChar.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            textBox1.Text += specialChar.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.String FiveStars = new System.String('*', 5);
            textBox1.Text = FiveStars;
        }
    }
}
