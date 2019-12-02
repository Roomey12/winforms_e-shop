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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActiveControl = label1;
            Basket.StartForm(basketBox, basketTotalPriceBox, label3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGraphicCard graphic_card = new FormGraphicCard();
            graphic_card.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMotherBoard mother_board = new FormMotherBoard();
            mother_board.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHardDisk hard_disk = new FormHardDisk();;
            hard_disk.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormComputerCase computer_case = new FormComputerCase();
            computer_case.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPowerSupply power_supply = new FormPowerSupply();
            power_supply.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCPU CPU = new FormCPU();
            CPU.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCooler cooler = new FormCooler();
            cooler.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRAM RAM = new FormRAM();
            RAM.Show();
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
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
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
                FormOrder fo8 = new FormOrder();
                fo8.Show();
            }
        }
    }
}
