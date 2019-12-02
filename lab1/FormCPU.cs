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
    public partial class FormCPU : Form
    {
        public FormCPU()
        {
            InitializeComponent();
            ActiveControl = label1;
            Basket.StartForm(basketBox, basketTotalPriceBox);
        }

        ProductCategory cpu = new ProductCategory("Processor");
        Product cp1 = new Product() { Name = "Intel Core i3-8100 3.6GHz/6MB", Price = 180, Id = 691205 };
        Product cp2 = new Product() { Name = "Intel Core i5-8400 2.8GHz/9MB", Price = 240, Id = 615002 };
        Product cp3 = new Product() { Name = "Intel Core i7-5820K 3.3GHz/15MB", Price = 330, Id = 601285 };
        Product cp4 = new Product() { Name = "Intel Core i7-6850K 3.6GHz/15MB", Price = 350, Id = 671895 };
        Product cp5 = new Product() { Name = "AMD Ryzen 5 3600 3.6GHz/32MB", Price = 230, Id = 691878 };
        Product cp6 = new Product() { Name = "AMD Ryzen 5 1600 3.2GHz/16MB", Price = 260, Id = 691502 };
        Product cp7 = new Product() { Name = "AMD Ryzen 5 2600 3.4GHz/16MB", Price = 290, Id = 651001 };
        Product cp8 = new Product() { Name = "AMD Ryzen 7 3700X 3.6GHz/32MB", Price = 450, Id = 650502 };

        private void button1_Click(object sender, EventArgs e)
        {
            Basket cpp1 = new Basket() { Name = cp1.Name, Price = cp1.Price, Id = cp1.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cpp1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basket cpp2 = new Basket() { Name = cp2.Name, Price = cp2.Price, Id = cp2.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cpp2); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Basket cpp3 = new Basket() { Name = cp3.Name, Price = cp3.Price, Id = cp3.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cpp3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket cpp4 = new Basket() { Name = cp4.Name, Price = cp4.Price, Id = cp4.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cpp4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Basket cpp5 = new Basket() { Name = cp5.Name, Price = cp5.Price, Id = cp5.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cpp5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basket cpp6 = new Basket() { Name = cp6.Name, Price = cp6.Price, Id = cp6.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cpp6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Basket cpp7 = new Basket() { Name = cp7.Name, Price = cp7.Price, Id = cp7.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cpp7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Basket cpp8 = new Basket() { Name = cp8.Name, Price = cp8.Price, Id = cp8.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cpp8);
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

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main_page = new Form1();
            main_page.Show();
        }

        Point LastPoint;
        private void FormCPU_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void FormCPU_MouseDown(object sender, MouseEventArgs e)
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
                FormOrder fo3 = new FormOrder();
                fo3.Show();
            }
        }
    }
}
