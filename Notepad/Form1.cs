using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Speech;
using System.Speech.Synthesis;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            newtab();
        }
        SpeechSynthesizer rd = new SpeechSynthesizer();
        private void newtab()
        {
            TabPage tp = new TabPage("New");
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;
            tp.Controls.Add(rtb);
            tabControl1.TabPages.Add(tp);
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("New");
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;
            tp.Controls.Add(rtb);
            tabControl1.TabPages.Add(tp);
        }
        private RichTextBox GetRichBox()
        {
            RichTextBox rtb = null;
            TabPage tp = tabControl1.SelectedTab;
            if (tp != null)
            {
                rtb = tp.Controls[0] as RichTextBox;
            }
            return rtb;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File(*.txt)|*.txt|Java Document(*.java)|*.java|All File(*.*)|*.*";
          //  ofd.Filter = "Java(*.java)|*.java";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                GetRichBox().Text = sr.ReadToEnd();
                tabControl1.SelectedTab.Text = Path.GetFileName(ofd.FileName);
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File(*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(sfd.FileName);
                sw.Write(GetRichBox().Text);
                tabControl1.SelectedTab.Text = Path.GetFileName(sfd.FileName);
                sw.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichBox().Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichBox().Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichBox().Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichBox().Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichBox().Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetRichBox().SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            string temp = GetRichBox().Text;
            GetRichBox().Text = "";
            GetRichBox().Text = temp;
            while (index < GetRichBox().Text.LastIndexOf(toolStripTextBox1.Text))
            {

                GetRichBox().Find(toolStripTextBox1.Text, index, GetRichBox().TextLength, RichTextBoxFinds.None);
                GetRichBox().SelectionBackColor = Color.GreenYellow;
                index = GetRichBox().Text.IndexOf(toolStripTextBox1.Text, index) + 1;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = 0;
            string temp = GetRichBox().Text;
            GetRichBox().Text = "";
            GetRichBox().Text = temp;
            while (index < GetRichBox().Text.LastIndexOf(toolStripTextBox1.Text))
            {

                GetRichBox().Find(toolStripTextBox1.Text, index, GetRichBox().TextLength, RichTextBoxFinds.None);
                GetRichBox().SelectionBackColor = Color.GreenYellow;
                index = GetRichBox().Text.IndexOf(toolStripTextBox1.Text, index) + 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabPage ct = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(ct);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FontDialog fdb = new FontDialog();
            fdb.ShowColor = true;
            if(fdb.ShowDialog()==DialogResult.OK & !string.IsNullOrEmpty(GetRichBox().Text))
            {
                GetRichBox().SelectionFont = fdb.Font;
            }
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = 0;
            string temp = GetRichBox().Text;
            GetRichBox().Text = "";
            GetRichBox().Text = temp;
            while (index < GetRichBox().Text.LastIndexOf(toolStripTextBox1.Text))
            {

                GetRichBox().Find(toolStripTextBox1.Text, index, GetRichBox().TextLength, RichTextBoxFinds.None);
                GetRichBox().SelectionBackColor = Color.GreenYellow;
                index = GetRichBox().Text.IndexOf(toolStripTextBox1.Text, index) + 1;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int index = 0;
            string temp = GetRichBox().Text;
            GetRichBox().Text = "";
            GetRichBox().Text = temp;
            while (index < GetRichBox().Text.LastIndexOf(toolStripTextBox1.Text))
            {

                GetRichBox().Find(toolStripTextBox1.Text, index, GetRichBox().TextLength, RichTextBoxFinds.None);
                GetRichBox().SelectionBackColor = Color.GreenYellow;
                index = GetRichBox().Text.IndexOf(toolStripTextBox1.Text, index) + 1;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TabPage ct = tabControl1.SelectedTab;
            tabControl1.TabPages.Remove(ct);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void autoFill()
        {
         //   AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
           // ac.AddRange(new string[]
            //{
           // "udayanga",
            //});
           
          
        }

        private void play_Click(object sender, EventArgs e)
        {
            if(GetRichBox().Text !="")
            {
                rd.Dispose();
                rd = new SpeechSynthesizer();
                rd.SpeakAsync(GetRichBox().Text);
            }
            else
            {
                MessageBox.Show("Notepad is empty !!");
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if(rd !=null)
            {
                if(rd.State==SynthesizerState.Speaking)
                {
                    rd.Pause();              
                }
            }
        }

        private void resume_Click(object sender, EventArgs e)
        {
            if (rd != null)
            {
                if (rd.State == SynthesizerState.Paused)
                {
                    rd.Resume();
                }
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if(rd!=null)
            {
                rd.Dispose();
            }
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }
    }
}