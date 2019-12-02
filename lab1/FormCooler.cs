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
    public partial class FormCooler : Form
    {
        public FormCooler()
        {
            InitializeComponent();
            ActiveControl = label1;
            Basket.StartForm(basketBox, basketTotalPriceBox);
        }

        ProductCategory clr = new ProductCategory("Cooler");
        Product cl1 = new Product() { Name = "Cooler Master Silent Fan 120", Price = 105, Id = 781293 };
        Product cl2 = new Product() { Name = "Cooler Master MasterLiquid Lite 240", Price = 170, Id = 701285 };
        Product cl3 = new Product() { Name = "Cooler Master Hyper 212 EVO", Price = 109, Id = 741833 };
        Product cl4 = new Product() { Name = "Cooler Master SickleFlow 120", Price = 115, Id = 781273 };
        Product cl5 = new Product() { Name = "Thermaltake Pure 7 ARGB Radiator", Price = 119, Id = 792171 };
        Product cl6 = new Product() { Name = "Thermaltake Water 3.0 120 ARGB", Price = 225, Id = 781257 };
        Product cl7 = new Product() { Name = "Thermaltake Riing 14 RGB Radiator", Price = 115, Id = 791100 };
        Product cl8 = new Product() { Name = "Thermaltake Floe Riing RGB 360", Price = 110, Id = 733452 };

        private void button1_Click(object sender, EventArgs e)
        {
            Basket cll1 = new Basket() { Name = cl1.Name, Price = cl1.Price, Id = cl1.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cll1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Basket cll2 = new Basket() { Name = cl2.Name, Price = cl2.Price, Id = cl2.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cll2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Basket cll3 = new Basket() { Name = cl3.Name, Price = cl3.Price, Id = cl3.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cll3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Basket cll4 = new Basket() { Name = cl4.Name, Price = cl4.Price, Id = cl4.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cll4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Basket cll5 = new Basket() { Name = cl5.Name, Price = cl5.Price, Id = cl5.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cll5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Basket cll6 = new Basket() { Name = cl6.Name, Price = cl6.Price, Id = cl6.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cll6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Basket cll7 = new Basket() { Name = cl7.Name, Price = cl7.Price, Id = cl7.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cll7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Basket cll8 = new Basket() { Name = cl8.Name, Price = cl8.Price, Id = cl8.Id };
            Basket.AddToBasket(basketBox, basketTotalPriceBox, cll8);
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
        private void FormCooler_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void FormCooler_MouseDown(object sender, MouseEventArgs e)
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
                FormOrder fo2 = new FormOrder();
                fo2.Show();
            }
        }
    }
}
