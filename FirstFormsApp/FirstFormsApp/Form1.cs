using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Fuchsia;
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Lime;
        }

        private void Button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Aqua;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C# Programming in Easy Steps");
        }
    }
}
