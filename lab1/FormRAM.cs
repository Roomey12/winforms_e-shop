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
    public partial class FormRAM : Form
    {
        public FormRAM()
        {
            InitializeComponent();
            ActiveControl = label1;
            Basket.StartForm(basketBox, basketTotalPriceBox);
        }

        ProductCategory ram = new ProductCategory("RAM");
        Product r1 = new Product() { Name = "Kingston DDR3-1600 4096MB", Price = 170, Id = 810158 };
        Product r2 = new Product() { Name = "Kingston DDR4-2400 8192MB", Price = 240, Id = 859155 };
        Product r3 = new Product() { Name = "Kingston DDR3-1600 8192MB", Price = 225, Id = 801232 };
        Product r4 = new Product() { Name = "Kingston DDR3l-1600 8192MB", Price = 300, Id = 815700 };
        Product r5 = new Product() { Name = "HyperX DDR4-2400 4096MB", Price = 270, Id = 815187 };
        Product r6 = new Product() { Name = "HyperX DDR4-2400 8192MB", Price = 350, Id = 890155 };
        Product r7 = new Product() { Name = "HyperX DDR4-3200 16384MB", Price = 600, Id = 893201 };
        Product r8 = new Product() { Name = "HyperX DDR4-3000 16384MB", Price = 620, Id = 891887 };

        private void button1_Click(object sender, EventArgs e)
        {
            Basket rr1 = new Basket() { Name = r1.Name, Price = r1.Price, Id = r1.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, rr1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basket rr2 = new Basket() { Name = r2.Name, Price = r2.Price, Id = r2.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, rr2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Basket rr3 = new Basket() { Name = r3.Name, Price = r3.Price, Id = r3.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, rr3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket rr4 = new Basket() { Name = r4.Name, Price = r4.Price, Id = r4.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, rr4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Basket rr5 = new Basket() { Name = r5.Name, Price = r5.Price, Id = r5.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, rr5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basket rr6 = new Basket() { Name = r6.Name, Price = r6.Price, Id = r6.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, rr6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Basket rr7 = new Basket() { Name = r7.Name, Price = r7.Price, Id = r7.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, rr7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Basket rr8 = new Basket() { Name = r8.Name, Price = r8.Price, Id = r8.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, rr8);
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
        private void FormRAM_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void FormRAM_MouseDown(object sender, MouseEventArgs e)
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
                FormOrder fo7 = new FormOrder();
                fo7.Show();
            }
        }
    }
}
