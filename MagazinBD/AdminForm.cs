using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinBD
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SotrudnikForm frm = new SotrudnikForm();
            frm.Owner = this;
            frm.Show();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TovarForm frm = new TovarForm();
            frm.Owner = this;
            frm.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KlientForm frm = new KlientForm();
            frm.Owner = this;
            frm.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frm = new AboutForm();
            frm.Owner = this;
            frm.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZakazForm frm = new ZakazForm();
            frm.Owner = this;
            frm.Show();
        }

        private void выполненныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VypolnennyiZakazForm frm = new VypolnennyiZakazForm();
            frm.Owner = this;
            frm.Show();
        }

        private void ожиданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OjidanieZakazaForm frm = new OjidanieZakazaForm();
            frm.Owner = this;
            frm.Show();
        }
    }
}
