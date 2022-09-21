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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form lgnFrm = new RegistrForm();
            this.Hide();
            lgnFrm.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con, con1;
                SqlCommand cmd, cmd1;
                SqlDataReader dr, dr1;

                string usr = textBox1.Text;
                string psw = textBox2.Text;
                con = new SqlConnection(@"Data Source=DESKTOP-V19EI0C;Initial Catalog=MagazinBD;Integrated Security=True");
                con1 = new SqlConnection(@"Data Source=DESKTOP-V19EI0C;Initial Catalog=MagazinBD;Integrated Security=True");

                cmd = new SqlCommand();

                con.Open();
                cmd.Connection = con;

                string str = "SELECT * FROM Admins where login='" + usr + "' AND password='" + psw + "'";
                cmd.CommandText = str;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    ClearAllFields();
                    AdminForm adminFrm = new AdminForm();
                    this.Hide();
                    adminFrm.Show();
                }

                else
                {
                    con1.Open();
                    cmd1 = new SqlCommand();
                    cmd1.Connection = con1;
                    string str1 = "SELECT * FROM Klient where login='" + usr + "' AND password='" + psw + "'";
                    cmd1.CommandText = str1;
                    dr1 = cmd1.ExecuteReader();
                    if (dr1.Read())
                    {
                        ClearAllFields();
                        MainForm mnFrm = new MainForm();
                        this.Hide();
                        mnFrm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearAllFields();
                    }

                }
                con.Close();
                con1.Close();
            }
        }

        private void ClearAllFields()
        {
            textBox1.Text = textBox2.Text = "";
        }
    }
}
