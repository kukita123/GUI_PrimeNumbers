using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PrimeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
        }

        string strNumber;
        string primeNumbers = "";
        int number, i, j;

        private void button1_Click(object sender, EventArgs e)
        {
            string value = "Въведи число тук!";
            if (Tmp.InputBox("Формуляр за въвеждане", "Въведи число:", ref value) == DialogResult.OK)
            {
                strNumber = value;
            }

            label1.Text += strNumber;
            number = Convert.ToInt32(strNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for ( i = 1; i < number-1; i++)
            {
                for ( j = 2; j < i; j++)
                {
                    if (i % j == 0) break;
                }
                if (j == i) primeNumbers += " "+i;
            }
            label2.Text = primeNumbers;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            strNumber = "";
            primeNumbers = "";
            label1.Text = "Прости числа от 1 до ";
            label2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
