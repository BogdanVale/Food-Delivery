using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DeliveryFood.UcMyOrder;

namespace DeliveryFood
{
    public partial class UcDiscounts : UserControl
    {
        public UcMyOrder myorder;
        public UcDiscounts(UcMyOrder ucMyOrder)
        {
            myorder = ucMyOrder;
            InitializeComponent();
        }

        private void labelTitle1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddL_Click(object sender, EventArgs e)
        {
           
            if (radioButton10L.Checked)
            {
                Order order1 = new Order();
                order1.Name = "Prosciutto";
                order1.Quantity = "3";
                order1.Price = (int.Parse("3") * 5.0).ToString();
                order1.Discount = (double.Parse(order1.Price) * 10.0 / 100).ToString();
                myorder.listOrder.Add(order1);
                myorder.setOrder(myorder.listOrder);
                myorder.getTotalPrice(0, 0);
                AddOrderForm rform = new AddOrderForm();
                rform.Show();
            }
            else
            {
                Order order1 = new Order();
                order1.Name = "Prosciutto";
                order1.Quantity = "6";
                order1.Price = (int.Parse("6") * 5.0).ToString();
                order1.Discount = (double.Parse(order1.Price) * 20.0 / 100).ToString();
                myorder.listOrder.Add(order1);
                myorder.setOrder(myorder.listOrder);
                myorder.getTotalPrice(0, 0);
                AddOrderForm rform = new AddOrderForm();
                rform.Show();
            }
        }

        private void buttonAddR_Click(object sender, EventArgs e)
        {
            if (radioButton10L.Checked)
            {
                Order order1 = new Order();
                order1.Name = "Diavola";
                order1.Quantity = "3";
                order1.Price = (int.Parse("3") * 6.0).ToString();
                order1.Discount = (double.Parse(order1.Price) * 10.0 / 100).ToString();
                myorder.listOrder.Add(order1);
                myorder.setOrder(myorder.listOrder);
                myorder.getTotalPrice(0, 0);
                AddOrderForm rform = new AddOrderForm();
                rform.Show();
            }
            else
            {
                Order order1 = new Order();
                order1.Name = "Prosciutto";
                order1.Quantity = "6";
                order1.Price = (int.Parse("6") * 6.0).ToString();
                order1.Discount = (double.Parse(order1.Price) * 20.0 / 100).ToString();
                myorder.listOrder.Add(order1);
                myorder.setOrder(myorder.listOrder);
                myorder.getTotalPrice(0, 0);
                AddOrderForm rform = new AddOrderForm();
                rform.Show();
            }
        }
    }
}
