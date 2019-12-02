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
    public partial class FormGraphicCard : Form
    {
        public FormGraphicCard()  
        {
            InitializeComponent();
            ActiveControl = label1;
            Basket.StartForm(basketBox, basketTotalPriceBox);
        }

        Product g1 = new Product() { Name = "Nvidia Geforce GTX 1050 Ti", Price = 500, Id = 198511 };
        Product g2 = new Product() { Name = "Nvidia Geforce GTX 1060 Ti", Price = 640, Id = 187515 };
        Product g3 = new Product() { Name = "Nvidia Geforce RTX 2060", Price = 710, Id = 125921 };
        Product g4 = new Product() { Name = "Nvidia Geforce RTX 2070", Price = 999, Id = 110818 };
        Product g5 = new Product() { Name = "AMD RX 470", Price = 300, Id = 158105 };
        Product g6 = new Product() { Name = "AMD RX 580", Price = 450, Id = 199182 };
        Product g7 = new Product() { Name = "AMD Radeon HD7450", Price = 840, Id = 178781 };
        Product g8 = new Product() { Name = "AMD Radeon HD7850", Price = 920, Id = 158299 };

        

        public void button1_Click(object sender, EventArgs e)
        {
            Basket gg1 = new Basket() { Name = g1.Name, Price = g1.Price, Id = g1.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, gg1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basket gg2 = new Basket() { Name = g2.Name, Price = g2.Price, Id = g2.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, gg2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Basket gg3 = new Basket() { Name = g3.Name, Price = g3.Price, Id = g3.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, gg3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket gg4 = new Basket() { Name = g4.Name, Price = g4.Price, Id = g4.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, gg4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Basket gg5 = new Basket() { Name = g5.Name, Price = g5.Price, Id = g5.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, gg5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basket gg6 = new Basket() { Name = g6.Name, Price = g6.Price, Id = g6.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, gg6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Basket gg7 = new Basket() { Name = g7.Name, Price = g7.Price, Id = g7.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, gg7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Basket gg8 = new Basket() { Name = g8.Name, Price = g8.Price, Id = g8.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, gg8);
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
        private void FormGraphicCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void FormGraphicCard_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
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
                FormOrder fo = new FormOrder();
                fo.Show();
            }
        }
    }
}
