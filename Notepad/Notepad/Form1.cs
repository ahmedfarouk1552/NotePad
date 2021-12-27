using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if ( saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                richTextBox1.Clear();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
                path = openFileDialog1.FileName;

            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(path != null)
            {
                richTextBox1.SaveFile(path);
                richTextBox1.Clear();
                path = null;
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    richTextBox1.Clear();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            path = null;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if(richTextBox1.SelectedText != "")
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                }
                else
                {
                    richTextBox1.Font = fontDialog1.Font;
                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if(richTextBox1.SelectedText != "")
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.ForeColor = colorDialog1.Color;
                }
            }
        }
    }
    
}
