using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxAndLabel
{
    public partial class Form1 : Form
    {
        private int num;
        public void setNum (int num) { this.num = num; }
        public int getNum() { return num; }
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            setNum(rnd.Next(1, 21));
        }

        public void rate(int guess, int num)
        {
            if (guess < num) label2.Text = "Too Low!";
            else
                if (guess > num) label2.Text = "Too high!";
            else
                label2.Text = "***Correct***";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt16(textBox1.Text);
            rate(guess, getNum());
        }
    }
}
