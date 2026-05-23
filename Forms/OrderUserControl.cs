using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesStoreProject.Models;

namespace ShoesStoreProject.Forms
{
    public partial class OrderUserControl : UserControl
    {

        private UserModel CurUser;
        private Order CurOrder;
        

        public event EventHandler OrderEdited;

        public OrderUserControl(Order order, UserModel user)
        {
            InitializeComponent();

            ArticleLbl.Text = $"Артикул: {order.Article}";
            StatusLbl.Text = $"Статус: {order.Status}";
            AddressLbl.Text = $"Адрес ПВЗ: {order.Address}";
            OrderDateLbl.Text = $"Дата заказа: {order.OrderDate}";
            DeliveryDateLbl.Text = $"{order.DeliveryDate}";

            CurOrder = order;


            if (user.Role == "Администратор")
            {
                RegisterCllick(this);
            }

        }

        private void RegisterCllick(Control control)
        {

            control.Click += Control_Click;

            foreach (Control child in control.Controls)
            {
                RegisterCllick(child);
            }


        }

        private void Control_Click(object? sender, EventArgs e)
        {
            var form = new AddEditOrderForm(CurOrder);
            form.ShowDialog();
            OrderEdited?.Invoke(this, e);
        }
    }
}
