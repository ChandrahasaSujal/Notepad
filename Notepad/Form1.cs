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

        private void fontWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontWrapToolStripMenuItem.Checked)
            {
                fontWrapToolStripMenuItem.Checked = false;
            }
            else
            {
                fontWrapToolStripMenuItem.Checked = true;
            }
        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void statusBarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem1.Checked)
            {
                statusStrip1.Visible = true;
            }
            if (statusBarToolStripMenuItem1.Checked == false)
            {
                statusStrip1.Visible = false;
            }
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Get in touch through Email : chandra.sujihal@gmail.com");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon you will come to know");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soon you will get this feature");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
