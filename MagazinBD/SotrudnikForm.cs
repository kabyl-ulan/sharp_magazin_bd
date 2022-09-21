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
    public partial class SotrudnikForm : Form
    {
        public SotrudnikForm()
        {
            InitializeComponent();
        }

        private void sotrudnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sotrudnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazinBDDataSet);

        }

        private void SotrudnikForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinBDDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.magazinBDDataSet.Sotrudnik);
        }
    }
}
