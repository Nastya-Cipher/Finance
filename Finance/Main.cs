using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using MaterialSkin.Controls;
using System.Drawing;

namespace Finance
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Main_FormClosed(object sender, FormClosedEventArgs e) //обработка закрытия формы входа
        {
            if (this.DialogResult != DialogResult.OK) //если была нажата кнопка входа, то DialogResult формы станет  равным OK, иначе он будет не определен и выполнится следующая строка
                Application.Exit(); //программа закрывается со всеми формами вместе
        }

        int idd;
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=finance;password=root;");
        string name_table = "expense";
        string name_id_table = "id_akk_exp";

        public void Load_Balance()
        {
            conn.Open();
            string sql = $"SELECT (SELECT sum(sum) FROM income), (SELECT sum(sum) FROM expense)";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            double inc;
            double exp;
            while (reader.Read())
            {
                inc = Convert.ToDouble(reader[0].ToString());
                exp = Convert.ToDouble(reader[1].ToString());
                balance.Text = $"Баланс: {(inc - exp).ToString()}";
            }
            reader.Close();
            conn.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataGridView_finance.DataSource = GetEmployeesList();
            buttonInc.ForeColor = Color.Crimson;
            button_expense.ForeColor = Color.Crimson;
            Load_Balance();
        }

        public DataTable GetEmployeesList()
        {
            DataTable dtEmployees = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"Select * From {name_table} where {name_id_table} = {Bank.id_person_akk}", con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtEmployees.Load(reader);
                }
            }

            this.dataGridView_finance.Columns["id"].Visible = false;
            return dtEmployees;
        }

        private void button_income_Click(object sender, EventArgs e)
        {
            button_income.ForeColor = Color.Crimson;
            button_expense.ForeColor = Color.Black;
            name_table = "income";
            name_id_table = "id_akk_inc";
            dataGridView_finance.DataSource = GetEmployeesList();
        }

        private void button_expense_Click(object sender, EventArgs e)
        {
            button_expense.ForeColor = Color.Crimson;
            button_income.ForeColor = Color.Black;
            name_table = "expense";
            name_id_table = "id_akk_exp";
            dataGridView_finance.DataSource = GetEmployeesList();
        }

        private void Add_record_Click(object sender, EventArgs e)
        {
            add_rec.Visible = true;
            buttonSave.Visible = false;
            buttonInc.PerformClick();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            add_rec.Visible = false;
            buttonSave.Visible = true;
            buttonInc.Visible = true;
            buttonExp.Visible = true;
            Create.Visible = true;
            comboBoxCategory.SelectedItem = "";
            textDescription.Text = "";
            dateTimePickerFinance.Value = DateTime.Now;
            textSum.Text = "";
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                string category = comboBoxCategory.SelectedItem.ToString();
                string description = textDescription.Text;
                DateTime dt = dateTimePickerFinance.Value.Date;

                if (textSum.Text != "" & name_table != "")
                {

                    double sum = Convert.ToDouble(textSum.Text);
                    MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=finance;password=root;");
                    conn.Open();
                    string sql = $"Insert into {name_table} (name, description, data, sum, {name_id_table}) values ('{category}', '{description}', @data, '{sum}', '{Bank.id_person_akk}')";

                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.Add("@data", MySqlDbType.Datetime).Value = dt;
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Данные добавленны!");
                    add_rec.Visible = false;
                    Load_Balance();
                    comboBoxCategory.SelectedItem = "";
                    textDescription.Text = "";
                    textSum.Text = "";
                    if (name_table == "income")
                    {
                        buttonInc.PerformClick();
                    }
                    else
                    {
                        buttonExp.PerformClick();
                    }
                    buttonSave.Visible = true;
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля");
            }

           
           
        }

        private void buttonInc_Click(object sender, EventArgs e)
        {
            buttonInc.ForeColor = Color.Crimson;
            buttonExp.ForeColor = Color.Black;
            name_table = "income";
            name_id_table = "id_akk_inc";
            Load_categories();
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            buttonInc.ForeColor = Color.Black;
            buttonExp.ForeColor = Color.Crimson;
            name_table = "expense";
            name_id_table = "id_akk_exp";
            Load_categories();
        }

        public void Load_categories()
        {
            comboBoxCategory.Items.Clear();
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=finance;password=root;");
            conn.Open();
            string sql = $"SELECT name FROM categories WHERE tbl = '{name_table}'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxCategory.Items.Add($"{reader[0].ToString()}"); 
            }
            reader.Close();
            conn.Close();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            panelAddCategory.Visible = true;
        }

        private void buttonCategoryCancel_Click(object sender, EventArgs e)
        {
            panelAddCategory.Visible = false;
        }

        private void buttonCategoryAdd_Click(object sender, EventArgs e)
        {
            string category = textBoxAddCategory.Text;
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=finance;password=root;");
            conn.Open();
            string sql = $"Insert into categories (name, tbl) values ('{category}', '{name_table}')";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Данные добавлены");
            textBoxAddCategory.Text = "";
            panelAddCategory.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string category = comboBoxCategory.SelectedItem.ToString();
                MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=finance;password=root;");
                conn.Open();
                string sql = $"DELETE FROM categories WHERE name = '{category}'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                Load_categories();
                comboBoxCategory.SelectedItem = "";
            }
            catch
            {

            }
            
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
                int idd = 0;
                foreach (DataGridViewRow item in this.dataGridView_finance.SelectedRows)
                {
                    idd = (int)dataGridView_finance[0, dataGridView_finance.CurrentRow.Index].Value;
                    dataGridView_finance.Rows.RemoveAt(item.Index);
                }
                using (MySqlCommand cmd = new MySqlCommand($"DELETE FROM {name_table} WHERE id = '{idd}'", conn))
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                }
            conn.Close();
                Load_Balance();
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            buttonInc.Visible = false;
            buttonExp.Visible = false;
            Create.Visible = false;
            add_rec.Visible = true;
            Load_categories();

            foreach (DataGridViewRow item in this.dataGridView_finance.SelectedRows)
            {
                idd = (int)dataGridView_finance[0, dataGridView_finance.CurrentRow.Index].Value;
                comboBoxCategory.SelectedIndex = comboBoxCategory.FindString((dataGridView_finance[1, dataGridView_finance.CurrentRow.Index].Value).ToString());
                textDescription.Text = (dataGridView_finance[2, dataGridView_finance.CurrentRow.Index].Value).ToString();
                dateTimePickerFinance.Value = Convert.ToDateTime(dataGridView_finance[3, dataGridView_finance.CurrentRow.Index].Value);
                textSum.Text = (dataGridView_finance[4, dataGridView_finance.CurrentRow.Index].Value).ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            conn.Open();
            DateTime dt = dateTimePickerFinance.Value.Date;
            string sql = $"UPDATE {name_table} SET name = '{comboBoxCategory.SelectedItem.ToString()}', description = '{textDescription.Text}', data = @data, sum = '{textSum.Text}' WHERE id = {idd}";
            //string sql = $"UPDATE {name_table} SET name = '{comboBoxCategory.SelectedItem.ToString()}', description = '{textDescription.Text}', @data, sum = 'textSum.Text' WHERE id = {idd}";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.Add("@data", MySqlDbType.Datetime).Value = dt;
            command.ExecuteNonQuery();
            conn.Close();
            comboBoxCategory.SelectedItem = "";
            textDescription.Text = "";
            dateTimePickerFinance.Value = DateTime.Now;
            textSum.Text = "";
            if (name_table == "income")
            {
                buttonInc.PerformClick();
            }
            else
            {
                buttonExp.PerformClick();
            }
            add_rec.Visible = false;
        }

        DateTime DataSort = DateTime.Now.Date;

        public DataTable DataSortMetod(string str)
        {
            DataTable dtEmployees = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(str, con))
                {
                    cmd.Parameters.Add("@data", MySqlDbType.Datetime).Value = DataSort;
                    cmd.Parameters.Add("@datanow", MySqlDbType.Datetime).Value = DateTime.Now.Date;
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtEmployees.Load(reader);
                }
            }

            this.dataGridView_finance.Columns["id"].Visible = false;
            return dtEmployees;
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            DataSort = DateTime.Now.Date;
            string str = $"Select * FROM {name_table} WHERE data = @data";
            dataGridView_finance.DataSource = DataSortMetod(str);
        }

        private void buttonWeek_Click(object sender, EventArgs e)
        {
            DataSort = DateTime.Now.Date;
            DataSort = DataSort.AddDays(-7);
            string str = $"Select * FROM {name_table} WHERE (data >= @data and data <= @datanow)";
            dataGridView_finance.DataSource = DataSortMetod(str);
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            DataSort = DateTime.Now.Date;
            DataSort = DataSort.AddMonths(-1);
            string str = $"Select * FROM {name_table} WHERE (data >= @data and data <= @datanow)";
            dataGridView_finance.DataSource = DataSortMetod(str);
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            DataSort = DateTime.Now.Date;
            DataSort = DataSort.AddYears(-1);
            string str = $"Select * FROM {name_table} WHERE (data >= @data and data <= @datanow)";
            dataGridView_finance.DataSource = DataSortMetod(str);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}