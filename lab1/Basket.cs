using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public class Basket : Product
    {
        public static int TotalPrice;
        public static List<Basket> sas = new List<Basket>();
        public static int ProductCount = 0;

        public static void CountTotalPrice()
        {
            TotalPrice = 0;
            foreach(var e in sas)
            {
                TotalPrice += e.Price;
            }
        }

        public static void ClearBasket(ListBox basketBox, TextBox basketTotalPriceBox)
        {
            basketBox.Items.Clear();
            sas.Clear();
            TotalPrice = 0;
            basketTotalPriceBox.Text = "";
            ProductCount = 0;
        }

        public static void RemoveItem(ListBox basketBox, TextBox basketTotalPriceBox)
        {
            for (int i = 0; i < basketBox.SelectedItems.Count; i++)
            {
                string str1 = basketBox.SelectedItems[i].ToString().Substring(9);
                basketBox.Items.Remove(basketBox.SelectedItems[i]);
                foreach (var j in sas.ToArray())
                {
                    if (str1 == j.Name)
                    {
                        sas.Remove(j);
                        TotalPrice -= j.Price;
                        break;
                    }
                }
                CountTotalPrice();
                basketTotalPriceBox.Text = TotalPrice.ToString() + "$";
                ProductCount--;
                if (TotalPrice == 0)
                {
                    basketTotalPriceBox.Text = "";
                }
            }
        }

        public static void AddToBasket(ListBox basketBox, TextBox basketTotalPriceBox, Basket elem)
        {
            basketBox.Items.Insert(ProductCount, elem.Price + "$  |  " + elem.Name);
            ProductCount++;
            sas.Add(elem);
            CountTotalPrice();
            basketTotalPriceBox.Text = TotalPrice.ToString() + "$";
        }

        public static void StartForm(ListBox basketBox, TextBox basketTotalPriceBox)
        {
            var i = 0;
            foreach (var e in sas)
            {
                basketBox.Items.Insert(i, e.Price + "$  |  " + e.Name);
                i++;
            }

            if (TotalPrice == 0)
            {
                basketTotalPriceBox.Text = "";
            }
            else
            {
                basketTotalPriceBox.Text = TotalPrice.ToString() + "$";
            }
        }

        public static void StartForm(ListBox basketBox, TextBox basketTotalPriceBox, Label label3)
        {
            label3.Text += FormLogin.customer.Name + "!";
            var i = 0;
            foreach (var e in sas)
            {
                basketBox.Items.Insert(i, e.Price + "$  |  " + e.Name);
                i++;
            }

            if (TotalPrice == 0)
            {
                basketTotalPriceBox.Text = "";
            }
            else
            {
                basketTotalPriceBox.Text = TotalPrice.ToString() + "$";
            }
        }
    }
}
