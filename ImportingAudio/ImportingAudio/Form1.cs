using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ImportingAudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer notifier = new SoundPlayer(Properties.Resources.Speech_Disambiguation);
        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Notifying...";
            notifier.Play();
        }
    }
}
