using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MagazinBD
{
    public partial class StiralnayMashForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-V19EI0C;Initial Catalog=MagazinBD;Integrated Security=True";

        private BindingSource bs = new BindingSource();

        private SqlConnection connect;

        public StiralnayMashForm()
        {
            InitializeComponent();
        }

        private void StiralnayMashForm_Load(object sender, EventArgs e)
        {
            OpenConnect();
            ExecSql("SELECT * FROM Tovar WHERE name LIKE 'Стирал%'");
            ViewQuery();
            CloseConnect();
        }

        private void OpenConnect()
        {
            connect = new SqlConnection(connectionString);

            try
            {
                connect.Open();
            }

            catch
            {
                string mes = "Ошибка!";
                string error = "Невозможно подключиться к БД!";
                MessageBox.Show(mes, error, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExecSql(string sqltext)
        {
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = sqltext;
            cmd.ExecuteNonQuery();
            DataTable tab = new DataTable();
            tab.Load(cmd.ExecuteReader());
            bs.DataSource = tab.DefaultView;
        }

        public void ViewQuery()
        {
            dataGridView1.DataSource = bs;
        }

        private void CloseConnect()
        {
            connect.Close();
        }

    }
}
