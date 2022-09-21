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

namespace MagazinBD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm abFrm = new AboutForm();
            abFrm.Owner = this;
            abFrm.Show();
        }

        private void руководствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Руководство.pdf");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void холодильникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form xlFrm = new Xolodilnik();
            xlFrm.Owner = this;
            xlFrm.Show();
        }

        private void телевизорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form xlFrm = new TelevizorForm();
            xlFrm.Owner = this;
            xlFrm.Show();
        }

        private void стиральныяМашинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form strMashForm = new StiralnayMashForm();
            strMashForm.Owner = this;
            strMashForm.Show();
        }

        private void корзинаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
