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
    public partial class RegistrForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-V19EI0C;Initial Catalog=MagazinBD;Integrated Security=True";

        public RegistrForm()
        {
            InitializeComponent();
        }

        private void addKlient()
        {
            if(textBox1.Text =="" || textBox2.Text=="" || textBox6.Text=="" || textBox7.Text == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                string sqlExpression = "INSERT INTO Klient (lastName, firstName, patronymic, email, phone, login, password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "');";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    int number = command.ExecuteNonQuery();
                }

                ClearAllFields();
                this.Hide();
                Form lgnForm = new LoginForm();
                lgnForm.Show();
                MessageBox.Show("АККАУНТ УСПЕШНО СОЗДАН!", "Новый аккаунт", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearAllFields()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form logForm = new LoginForm();
            this.Hide();
            logForm.Show();
        }

        private void btnRegistr_Click(object sender, EventArgs e)
        {
            addKlient();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form logForm = new LoginForm();
            this.Hide();
            logForm.Show();
        }
    }
}
