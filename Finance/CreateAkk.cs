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
    public partial class CreateAkk : MaterialForm
    {
        public CreateAkk()
        {
            InitializeComponent();
        }

        

        private void Create_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text;
            string password = textPassword.Text;
            string repeat_password = textRepeatPassword.Text;
            if (login != "" & password != "" & repeat_password != "")
            {
                if (password == repeat_password)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=finance;password=root;");
                    conn.Open();
                    string sql = $"Insert into akk (login, password) values ('{login}', '{password}')";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Данные успешно добавлены");
                    Login l = new Login();
                    l.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
            else
            {
                MessageBox.Show("Данные введены неверно");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
