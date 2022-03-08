using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryFood
{
    public partial class UcDelivery : UserControl
    {
        public UcDelivery()
        {
            InitializeComponent();
            pictureBoxAccepted.Visible= false;
            
            if(UcMyOrder.comand==true)
            {
                pictureBoxAccepted.Visible = true;
                labelStatus.Text = "Comada a fost plasata";
                labelPrice.Text = "Total Price: " + UcMyOrder.price + " $";
                DateTime myDateTime = DateTime.Now;
                DateTime x30MinsLater = myDateTime.AddMinutes(30);
                labelTime.Text = "Time estimated: " + x30MinsLater;
            }
        }
       
        private void UcDelivery_Load(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
