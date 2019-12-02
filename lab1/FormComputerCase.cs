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
    public partial class FormComputerCase : Form
    {
        public FormComputerCase()
        {
            InitializeComponent();
            ActiveControl = label1;
            Basket.StartForm(basketBox, basketTotalPriceBox);
        }

        ProductCategory comp = new ProductCategory("ComputerCase");
        Product c1 = new Product() { Name = "AeroCool DS 230 Black", Price = 105, Id = 492861 };
        Product c2 = new Product() { Name = "AeroCool PGS Python Glass ARGB", Price = 100, Id = 491950 };
        Product c3 = new Product() { Name = "AeroCool PGS ARGB Glass Black", Price = 120, Id = 425168 };
        Product c4 = new Product() { Name = "AeroCool P7-C1 Glass Edition", Price = 138, Id = 490177 };
        Product c5 = new Product() { Name = "GameMax StarLight B-White", Price = 109, Id = 401952 };
        Product c6 = new Product() { Name = "GameMax Pardo White", Price = 119, Id = 477152 };
        Product c7 = new Product() { Name = "GameMax G56 1 White", Price = 125, Id = 491105 };
        Product c8 = new Product() { Name = "GameMax Aurora", Price = 139, Id = 458144 };

        private void button1_Click(object sender, EventArgs e)
        {
            Basket cc1 = new Basket() { Name = c1.Name, Price = c1.Price, Id = c1.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cc1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basket cc2 = new Basket() { Name = c2.Name, Price = c2.Price, Id = c2.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cc2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Basket cc3 = new Basket() { Name = c3.Name, Price = c3.Price, Id = c3.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cc3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket cc4 = new Basket() { Name = c4.Name, Price = c4.Price, Id = c4.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cc4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Basket cc5 = new Basket() { Name = c5.Name, Price = c5.Price, Id = c5.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cc5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basket cc6 = new Basket() { Name = c6.Name, Price = c6.Price, Id = c6.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cc6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Basket cc7 = new Basket() { Name = c7.Name, Price = c7.Price, Id = c7.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cc7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Basket cc8 = new Basket() { Name = c8.Name, Price = c8.Price, Id = c8.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cc8);
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

        Point LastPoint;
        private void FormComputerCase_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void FormComputerCase_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Basket.ClearBasket(basketBox, basketTotalPriceBox);
        }

        private void basketBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Basket.RemoveItem(basketBox, basketTotalPriceBox);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (Basket.sas.Count == 0)
            {
                MessageBox.Show("Сначала добавьте товар в корзину!");
            }
            else
            {
                Hide();
                FormOrder fo1 = new FormOrder();
                fo1.Show();
            }
        }
    }
}
