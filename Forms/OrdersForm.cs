using ShoesStoreProject.Data;
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



    public partial class OrdersForm : Form
    {
        private UserModel CurUser;

        public OrdersForm(UserModel user)
        {
            InitializeComponent();

            CurUser = user;

            LoadOrders();

            if (CurUser.Role == "Менеджер")
            {
                AddBtn.Visible = false;
            }

            panel1.BackColor = ColorTranslator.FromHtml("#7FFF00");
            AddBtn.BackColor = ColorTranslator.FromHtml("#00FA9A");
        }


        private void LoadOrders()
        {

            FlowLayoutPanel.Controls.Clear();

            var db = new Database();
            var orders = db.GetOrders();

            foreach (var order in orders)
            {
                var item = new OrderUserControl(order, CurUser);
                FlowLayoutPanel.Controls.Add(item);
                item.OrderEdited += Item_OrderEdited;
            }

        }

        private void Item_OrderEdited(object? sender, EventArgs e)
        {
            LoadOrders();
        }

        private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new ProductsForm(CurUser);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var form = new AddEditOrderForm();
            form.ShowDialog();
            LoadOrders();
        }
    }
}
