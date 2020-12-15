using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;

namespace Finance
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text;
            string password = textPassword.Text;
            if (login!= "" & password != "")
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=finance;password=root;");
                    conn.Open();
                    string sql = $"SELECT password, id FROM akk WHERE login = '{login}'";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    string passwordDB ="";
                    while (reader.Read())
                    {
                        passwordDB = reader[0].ToString();
                        Bank.id_person_akk = Convert.ToInt32(reader[1]);
                    }
                    reader.Close();
                    conn.Close();
                    if (password == passwordDB)
                    {
                        Main m = new Main();
                        this.Hide();
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                        textPassword.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Неверный логин!");
                    textLogin.Text = "";
                    textPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private void CreareAkk_Click(object sender, EventArgs e)
        {
            CreateAkk CA = new CreateAkk();
            this.Hide();
            CA.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank.id_person_akk = 2;
            Main m = new Main();
            this.Hide();
            m.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
