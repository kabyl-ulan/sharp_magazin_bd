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
    public partial class OjidanieZakazaForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-V19EI0C;Initial Catalog=MagazinBD;Integrated Security=True";

        private BindingSource bs = new BindingSource();

        private SqlConnection connect;

        public OjidanieZakazaForm()
        {
            InitializeComponent();
        }

        private void OjidanieZakazaForm_Load(object sender, EventArgs e)
        {
            OpenConnect();
            ExecSql("SELECT t1.lastName, t1.firstName, t1.email, t1.phone, t2.data_zakaza, t2.status, t3.kolichestvo_tovara FROM Klient t1 LEFT JOIN  Zakaz t2 ON t1.id_klient = t2.id_klient LEFT JOIN Spisok_zakazov t3 ON t3.id_zakaza = t2.id_zakaza WHERE t2.status LIKE 'Ожидание'; ");
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
