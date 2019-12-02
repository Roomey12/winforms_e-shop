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
    public partial class FormHardDisk : Form
    {
        public FormHardDisk()
        {
            InitializeComponent();
            ActiveControl = label1;
            Basket.StartForm(basketBox, basketTotalPriceBox);
        }

        ProductCategory hrd = new ProductCategory("HardDisk");
        Product h1 = new Product() { Name = "HDD Western Digital Blue 1TB", Price = 180, Id = 315919 };
        Product h2 = new Product() { Name = "HDD Seagate BarraCuda 2TB", Price = 220, Id = 310094 };
        Product h3 = new Product() { Name = "HDD Western Digital Purple 2TB", Price = 260, Id = 352511 };
        Product h4 = new Product() { Name = "HDD Toshiba P300 1TB", Price = 300, Id = 310951 };
        Product h5 = new Product() { Name = "SSD Kingston A400 240GB", Price = 280, Id = 386861 };
        Product h6 = new Product() { Name = "SSD Kingston HyperX Fury 240GB", Price = 320, Id = 319581 };
        Product h7 = new Product() { Name = "SSD Western Digital Green 120GB", Price = 350, Id = 351776 };
        Product h8 = new Product() { Name = "SSD Western Digital Blue 500GB", Price = 400, Id = 399254 };

        private void button1_Click(object sender, EventArgs e)
        {
            Basket hh1 = new Basket() { Name = h1.Name, Price = h1.Price, Id = h1.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, hh1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basket hh2 = new Basket() { Name = h2.Name, Price = h2.Price, Id = h2.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, hh2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Basket hh3 = new Basket() { Name = h3.Name, Price = h3.Price, Id = h3.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, hh3); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket hh4 = new Basket() { Name = h4.Name, Price = h4.Price, Id = h4.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, hh4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Basket hh5 = new Basket() { Name = h5.Name, Price = h5.Price, Id = h5.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, hh5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basket hh6 = new Basket() { Name = h6.Name, Price = h6.Price, Id = h6.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, hh6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Basket hh7 = new Basket() { Name = h7.Name, Price = h7.Price, Id = h7.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, hh7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Basket hh8 = new Basket() { Name = h8.Name, Price = h8.Price, Id = h8.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, hh8);
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
        private void FormHardDisk_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void FormHardDisk_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
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
