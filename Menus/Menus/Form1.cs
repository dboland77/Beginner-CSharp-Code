using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }


        private void openFile()
        {
            openFileDialog1.Filter = "Text Files | *.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName,
                                    RichTextBoxStreamType.PlainText);
            }
        }

        private void newFile()
        {
            richTextBox1.Text = null;
            toolStripStatusLabel1.Text = "Ready";
        }

        private void saveFile()
        {
            saveFileDialog1.Filter= "Text Files | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,
                    RichTextBoxStreamType.PlainText);
            }
        }


    }
}
