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
    public partial class FormMotherBoard : Form
    {
        public FormMotherBoard()
        {
            InitializeComponent();
            ActiveControl = label1;
            Basket.StartForm(basketBox, basketTotalPriceBox);
        }

        ProductCategory mthr = new ProductCategory("MotherBoard");
        Product m1 = new Product() { Name = "MSI B450 Tomahawk Max", Price = 230, Id = 284811 };
        Product m2 = new Product() { Name = "MSI MAG Z390 Tomahawk", Price = 290, Id = 205515 };
        Product m3 = new Product() { Name = "MSI Z390-A Pro", Price = 345, Id = 297515 };
        Product m4 = new Product() { Name = "MSI B360M Pro-VD", Price = 399, Id = 201585 };
        Product m5 = new Product() { Name = "Gigabyte GA-A320M-S 2H V2", Price = 190, Id = 291459 };
        Product m6 = new Product() { Name = "Gigabyte B450 Aorus", Price = 245, Id = 215537 };
        Product m7 = new Product() { Name = "Gigabyte B450M DS3H", Price = 280, Id = 249004 };
        Product m8 = new Product() { Name = "Gigabyte B450 Aorus M", Price = 325, Id = 259190 };

        private void button1_Click(object sender, EventArgs e)
        {
            Basket mm1 = new Basket() { Name = m1.Name, Price = m1.Price, Id = m1.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, mm1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basket mm2 = new Basket() { Name = m2.Name, Price = m2.Price, Id = m2.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, mm2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Basket mm3 = new Basket() { Name = m3.Name, Price = m3.Price, Id = m3.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, mm3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket mm4 = new Basket() { Name = m4.Name, Price = m4.Price, Id = m4.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, mm4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Basket mm5 = new Basket() { Name = m5.Name, Price = m5.Price, Id = m5.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, mm5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basket mm6 = new Basket() { Name = m6.Name, Price = m6.Price, Id = m6.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, mm6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Basket mm7 = new Basket() { Name = m7.Name, Price = m7.Price, Id = m7.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, mm7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Basket mm8 = new Basket() { Name = m8.Name, Price = m8.Price, Id = m8.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, mm8);
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
        private void FormMotherBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void FormMotherBoard_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
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
                FormOrder fo5 = new FormOrder();
                fo5.Show();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Basket.ClearBasket(basketBox, basketTotalPriceBox);
        }

        private void basketBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Basket.RemoveItem(basketBox, basketTotalPriceBox);
        }
    }
}
