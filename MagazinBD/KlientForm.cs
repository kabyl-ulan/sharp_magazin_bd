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
    public partial class KlientForm : Form
    {
        public KlientForm()
        {
            InitializeComponent();
        }

        private void klientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazinBDDataSet);

        }

        private void KlientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinBDDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.magazinBDDataSet.Klient);

        }
    }
}
