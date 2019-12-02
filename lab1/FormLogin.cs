using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.ActiveControl = TopPanel;
            EmailField.Text = "Почта";
            EmailField.ForeColor = Color.Gray;
            PassField.Text = "Пароль";
            PassField.ForeColor = Color.Gray;

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 38);
        }

        public static Client customer = new Client();
        public static int orderNumber;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point LastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        public void LoginButton_Click(object sender, EventArgs e)
        {
            string userEmail = EmailField.Text;
            string userPass = PassField.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @uE AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = userEmail;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPass;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                string connStr = "server=localhost;port=3306;username=root;password=;database=e-shop";
                string sql = "SELECT * FROM `users` WHERE `email` = @uE AND `pass` = @uP";
                MySqlConnection connection = new MySqlConnection(connStr);
                MySqlCommand sqlCom = new MySqlCommand(sql, connection);
                sqlCom.Parameters.Add("@uE", MySqlDbType.VarChar).Value = userEmail;
                sqlCom.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPass;
                connection.Open();
                sqlCom.ExecuteNonQuery();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                var myData = dt.Select();

                for (int i = 0; i < myData.Length; i++)
                {
                    for (int j = 0; j < myData[i].ItemArray.Length; j++)
                    {
                        switch (j)
                        {
                            case 0: customer.Id = Convert.ToInt32(myData[i].ItemArray[j]); break;
                            case 1: customer.Email = myData[i].ItemArray[j].ToString(); break;
                            case 2: customer.Password = myData[i].ItemArray[j].ToString(); break;
                            case 3: customer.Name = myData[i].ItemArray[j].ToString(); break;
                            case 4: customer.Surname = myData[i].ItemArray[j].ToString(); break;
                            case 5: customer.Phone = myData[i].ItemArray[j].ToString(); break;
                            case 6: customer.Card = myData[i].ItemArray[j].ToString(); break;
                            case 7: customer.City = myData[i].ItemArray[j].ToString(); break;
                            case 8: customer.Street = myData[i].ItemArray[j].ToString(); break;
                        }
                    }
                }
                Random rnd = new Random();
                orderNumber = rnd.Next(10000,99999);
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Логин или пароль был введен неверно!");
            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistration rgForm = new FormRegistration();
            rgForm.Show();
        }

        private void RegisterLabel_MouseEnter(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.ForestGreen;
        }

        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.Black;
        }

        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (EmailField.Text == "Почта")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.Black;
            }
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (EmailField.Text == "")
            {
                EmailField.Text = "Почта";
                EmailField.ForeColor = Color.Gray;
            }
        }

        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Пароль")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.Black;
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.Text = "Пароль";
                PassField.ForeColor = Color.Gray;
            }
        }
    }
}
