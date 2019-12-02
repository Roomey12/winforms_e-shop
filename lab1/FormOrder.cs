using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            ActiveControl = label1;
            label2.Text += FormLogin.orderNumber;
            Basket.StartForm(basketBox, basketTotalPriceBox);

            nameTextBox.Text = FormLogin.customer.Name;
            surnameTextBox.Text = FormLogin.customer.Surname;
            emailTextBox.Text = FormLogin.customer.Email;
            phoneTextBox.Text = FormLogin.customer.Phone;
            cityTextBox.Text = FormLogin.customer.City;
            streetTextBox.Text = FormLogin.customer.Street;
            cardTextBox.Text = FormLogin.customer.Card;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main_page = new Form1();
            main_page.Show();
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

        private void basketBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Basket.RemoveItem(basketBox, basketTotalPriceBox);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ оформлен. Ожидайте звонка курьера.");
            Application.Exit();
        }
    }
}
