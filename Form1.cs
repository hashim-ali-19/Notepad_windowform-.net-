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
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dawood = new OpenFileDialog();
            Dawood.Title = "Open";
            Dawood.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (Dawood.ShowDialog() == DialogResult.OK) ;
            richTextBox1.LoadFile(Dawood.FileName, RichTextBoxStreamType.PlainText);
            this.Text = Dawood.FileName;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dawood = new SaveFileDialog();
            Dawood.Title = "Save";
            Dawood.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (Dawood.ShowDialog() == DialogResult.OK) ;
            richTextBox1.SaveFile(Dawood.FileName, RichTextBoxStreamType.PlainText);
            this.Text = Dawood.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fnt.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = fnt.Color;
        }

        private void characterCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = richTextBox1.Text.Length;
            richTextBox1.Text = "Characters: " + count;
        }

        private void wordCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text.Trim();
            int words = text.Split(' ').Length;

            richTextBox1.Text = "Words: " + words;
        }
    }
}
