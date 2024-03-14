

namespace Notepad
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private String file = "";

        private void searchWithBingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Text Files |*.txt";
            if (dr == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                read.Close();
                file = openFileDialog1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                write.Write(richTextBox1);
                write.Close();

            }
            else
            {
                try
                {
                    if (dr == DialogResult.OK)
                    {
                        StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                        write.Write(richTextBox1);
                        write.Close();

                    }
                }
                catch
                {

                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
            {
                richTextBox1.Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.Copy();
            }
        }

        private void pastsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                richTextBox1.Paste();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            richTextBox1.Text = dt.ToString();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void oNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = true;
        }

        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = false;
        }

        private void aboutNotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application create by Ayan", "About NoatPad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}