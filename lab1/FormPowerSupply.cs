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
    public partial class FormPowerSupply : Form
    {
        public FormPowerSupply()
        {
            InitializeComponent();
            ActiveControl = label1;
            Basket.StartForm(basketBox, basketTotalPriceBox);
        }

        ProductCategory pwr = new ProductCategory("PowerSupply");
        Product p1 = new Product() { Name = "Aerocool VX Plus 500 500W", Price = 110, Id = 559195 };
        Product p2 = new Product() { Name = "Aerocool KCAS-800 Plus 800W", Price = 150, Id = 500977 };
        Product p3 = new Product() { Name = "Aerocool VS-800 800W", Price = 140, Id = 517991 };
        Product p4 = new Product() { Name = "Aerocool KCAS-700 700W", Price = 130, Id = 501852 };
        Product p5 = new Product() { Name = "Chieftec GPS-700A8 700W", Price = 190, Id = 515816 };
        Product p6 = new Product() { Name = "Chieftec GPS-600A8 600W", Price = 160, Id = 567911 };
        Product p7 = new Product() { Name = "Chieftec Proton BDF-750C 750W", Price = 210, Id = 576167 };
        Product p8 = new Product() { Name = "Chieftec GPS-1450C 1450W", Price = 345, Id = 510701 };

        private void button1_Click(object sender, EventArgs e)
        {
            Basket pp1 = new Basket() { Name = p1.Name, Price = p1.Price, Id = p1.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, pp1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basket pp2 = new Basket() { Name = p2.Name, Price = p2.Price, Id = p2.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, pp2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Basket pp3 = new Basket() { Name = p3.Name, Price = p3.Price, Id = p3.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, pp3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket pp4 = new Basket() { Name = p4.Name, Price = p4.Price, Id = p4.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, pp4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Basket pp5 = new Basket() { Name = p5.Name, Price = p5.Price, Id = p5.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, pp5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basket pp6 = new Basket() { Name = p6.Name, Price = p6.Price, Id = p6.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, pp6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Basket pp7 = new Basket() { Name = p7.Name, Price = p7.Price, Id = p7.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, pp7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Basket pp8 = new Basket() { Name = p8.Name, Price = p8.Price, Id = p8.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, pp8);
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
        private void FormPowerSupply_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void FormPowerSupply_MouseDown(object sender, MouseEventArgs e)
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
                FormOrder fo6 = new FormOrder();
                fo6.Show();
            }
        }
    }
}
