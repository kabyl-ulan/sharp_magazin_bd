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
    public partial class ZakazForm : Form
    {
        public ZakazForm()
        {
            InitializeComponent();
        }

        private void zakazBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zakazBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.magazinBDDataSet);

        }

        private void ZakazForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinBDDataSet.Spisok_zakazov". При необходимости она может быть перемещена или удалена.
            this.spisok_zakazovTableAdapter.Fill(this.magazinBDDataSet.Spisok_zakazov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "magazinBDDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.magazinBDDataSet.Zakaz);

        }
    }
}
