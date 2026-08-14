using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace guirtf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.Trim() != "") 
            {
                 richTextBox1.LoadFile(openFileDialog1.FileName.Trim());

            
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName.Trim() != "") 
            {
                 richTextBox1.SaveFile(saveFileDialog1.FileName.Trim());

            
            
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName.Trim() != "")
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName.Trim());



            }
            richTextBox1.Clear();

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName.Trim() != "")
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName.Trim());



            }
            richTextBox1.Clear();
            
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = richTextBox1.Rtf + "";
            int i = 0;
            s = s.Trim();
            i = s.LastIndexOf('}');
            s = s.Substring(0, i);

            s = s+ "\\b\\f1\\fs17 \\par} ";
            
            richTextBox1.Rtf = s;
            richTextBox1.SelectionStart = s.Length - 2;
        }

        private void noBoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = richTextBox1.Rtf + "";
            int i = 0;
            s = s.Trim();
            i = s.LastIndexOf('}');
            s = s.Substring(0, i);

            s=s+"\\b0\\f1\\fs17  \\par}";
            
            richTextBox1.Rtf = s;
            richTextBox1.SelectionStart = s.Length-2;

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = richTextBox1.Rtf + "";
            int i = 0;
            s = s.Trim();
            i = s.LastIndexOf('}');
            s = s.Substring(0, i);

            s = s + "\\f1\\fs22  \\par}";

            richTextBox1.Rtf = s;
            richTextBox1.SelectionStart = s.Length - 2;
        }

        private void font32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = richTextBox1.Rtf + "";
            int i = 0;
            s = s.Trim();
            i = s.LastIndexOf('}');
            s = s.Substring(0, i);

            s = s + "\\f1\\fs32  \\par}";

            richTextBox1.Rtf = s;
            richTextBox1.SelectionStart = s.Length - 2;

        }
    }
}
