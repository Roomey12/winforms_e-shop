using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            this.ActiveControl = TopPanel;
            NameField.Text = "Имя";
            NameField.ForeColor = Color.Gray;
            SurnameField.Text = "Фамилия";
            SurnameField.ForeColor = Color.Gray;
            PhoneField.Text = "Номер телефона";
            PhoneField.ForeColor = Color.Gray;
            CardField.Text = "Номер карты";
            CardField.ForeColor = Color.Gray;
            CityField.Text = "Город";
            CityField.ForeColor = Color.Gray;
            StreetField.Text = "Улица";
            StreetField.ForeColor = Color.Gray;
            EmailField.Text = "Почта";
            EmailField.ForeColor = Color.Gray;
            PassField.Text = "Пароль";
            PassField.ForeColor = Color.Gray;

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 38);
        }


        private void LoginLabel_MouseEnter(object sender, EventArgs e)
        {
            LoginLabel.ForeColor = Color.ForestGreen;
        }

        private void LoginLabel_MouseLeave(object sender, EventArgs e)
        {
            LoginLabel.ForeColor = Color.Black;
        }

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
            if (e.Button == MouseButtons.Left)
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

        private void NameField_Enter(object sender, EventArgs e)
        {
            if(NameField.Text == "Имя")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Имя";
                NameField.ForeColor = Color.Gray;
            }
            RegularCheck(NameField);
        }

        private void SurnameField_Enter(object sender, EventArgs e)
        {
            if (SurnameField.Text == "Фамилия")
            {
                SurnameField.Text = "";
                SurnameField.ForeColor = Color.Black;
            }
        }

        private void SurnameField_Leave(object sender, EventArgs e)
        {
            if (SurnameField.Text == "")
            {
                SurnameField.Text = "Фамилия";
                SurnameField.ForeColor = Color.Gray;
            }
            RegularCheck(SurnameField);
        }

        private void PhoneField_Enter(object sender, EventArgs e)
        {
            if (PhoneField.Text == "Номер телефона")
            {
                PhoneField.Text = "";
                PhoneField.ForeColor = Color.Black;
            }
        }

        private void PhoneField_Leave(object sender, EventArgs e)
        {
            if (PhoneField.Text == "")
            {
                PhoneField.Text = "Номер телефона";
                PhoneField.ForeColor = Color.Gray;
            }

            Regex regex = new Regex(@"^\d[\d\(\)\ -]{8,14}\d$");
            Match match = regex.Match(PhoneField.Text);
            if (!match.Success)
            {
                MessageBox.Show("Значение должно состоять только из чисел и иметь длину от 8 до 14 символов!");
                PhoneField.Text = "";
            }
        }

        private void CardField_Enter(object sender, EventArgs e)
        {
            if (CardField.Text == "Номер карты")
            {
                CardField.Text = "";
                CardField.ForeColor = Color.Black;
            }
        }

        private void CardField_Leave(object sender, EventArgs e)
        {
            if (CardField.Text == "")
            {
                CardField.Text = "Номер карты";
                CardField.ForeColor = Color.Gray;
            }

            if(CardField.Text.Length > 0)
            {
                try
                {
                    long ab = Convert.ToInt64(CardField.Text);
                }
                catch (FormatException)
                {

                     MessageBox.Show("Значение должно состоять из цифр и иметь длину 16 символов.");
                }
            }

            /*Regex regex = new Regex(@"^\d[\d\(\)\ -]\d$");
            Match match = regex.Match(CardField.Text);
            if (!match.Success)
            {
                MessageBox.Show("Значение должно состоять только из чисел и состоять из 16 символов!");
                Ca*/
        }

        private void CityField_Enter(object sender, EventArgs e)
        {
            if (CityField.Text == "Город")
            {
                CityField.Text = "";
                CityField.ForeColor = Color.Black;
            }
        }

        private void CityField_Leave(object sender, EventArgs e)
        {
            if (CityField.Text == "")
            {
                CityField.Text = "Город";
                CityField.ForeColor = Color.Gray;
            }
            RegularCheck(CityField);
        }

        private void StreetField_Enter(object sender, EventArgs e)
        {
            if (StreetField.Text == "Улица")
            {
                StreetField.Text = "";
                StreetField.ForeColor = Color.Black;
            }
        }

        private void StreetField_Leave(object sender, EventArgs e)
        {
            if (StreetField.Text == "")
            {
                StreetField.Text = "Улица";
                StreetField.ForeColor = Color.Gray;
            }
            RegularCheck(StreetField);
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
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            //Переменная pattern задает регулярное выражение для проверки адреса электронной почты. 
            //Данное выражение предлагает нам Microsoft на страницах msdn.
            if (Regex.IsMatch(EmailField.Text, pattern, RegexOptions.IgnoreCase) == false)
            {
                MessageBox.Show("Введен некоректный email. Попробуйте снова!");
                EmailField.Text = "";
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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string prmAlert = "Введите: \n";
            if (NameField.Text == "Имя")
            {
                prmAlert += "\tимя, \n";
            }
            if (SurnameField.Text == "Фамилия")
            {
                prmAlert += "\tфамилию, \n";
            }
            if (PhoneField.Text == "Номер телефона")
            {
                prmAlert += "\tномер телефона, \n";
            }
            if (CardField.Text == "Номер карты")
            {
                prmAlert += "\tномер карты, \n";
            }
            if (CityField.Text == "Город")
            {
                prmAlert += "\tгород, \n";
            }
            if (StreetField.Text == "Улица")
            {
                prmAlert += "\tулицу, \n";
            }
            if (EmailField.Text == "Почта")
            {
                prmAlert += "\tпочту, \n";
            }
            if (PassField.Text == "Пароль")
            {
                prmAlert += "\tпароль. \n";
                MessageBox.Show(prmAlert);
                return;
            }

            if (isUserExists()) { return; }

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`email`, `pass`, `name`, `surname`, `phone`, `card`, `city`, `street`) " +
                "VALUES (@email, @pass, @name, @surname, @phone, @card, @city, @street)", db.getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = EmailField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SurnameField.Text;
            command.Parameters.Add("@phone", MySqlDbType.Int64).Value = PhoneField.Text;
            command.Parameters.Add("@card", MySqlDbType.Int64).Value = CardField.Text;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = CityField.Text;
            command.Parameters.Add("@street", MySqlDbType.VarChar).Value = StreetField.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                FormLogin lgForm = new FormLogin();
                lgForm.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан.");
            }

            db.closeConnection();
        }

        public bool isUserExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @uE", db.getConnection());
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = EmailField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт с такой почтой уже зарегистрирован.");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogin lgForm = new FormLogin();
            lgForm.Show();
        }

        public int tryIntHelper = 0;
        private void TryCatchInt(TextBox Field)
        {
            if(Field.Text.Length > 0)
            {
                try
                {
                    long ab = Convert.ToInt64(Field.Text);
                }
                catch (FormatException)
                {
                    if (tryIntHelper > 1)
                    {
                        MessageBox.Show("Значение должно состоять из цифр.");
                    }
                    tryIntHelper++;
                }
            }
        }

        private void RegularCheck(TextBox Field)
        {
            Regex regex = new Regex(@"^[А-ЯЁ][а-яё]+$");
            Match match = regex.Match(Field.Text);
            if (!match.Success)
            {
                MessageBox.Show("Значение должно начинаться с большой буквы и состоять только из букв русского алфавита!");
                Field.Text = "";
            }
        }

    }
}
