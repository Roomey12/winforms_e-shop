using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class UserControlBasket : UserControl
    {
        public UserControlBasket()
        {
            InitializeComponent();
        }

        public string Txt
        {
            get { return basket1Box.Text; }
            set { basket1Box.Text = value; }
        }
    }
}
