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
    public partial class AddEditOrderForm : Form
    {

        private Order CurOrder;
        private bool IsAdd;

        public AddEditOrderForm()
        {
            InitializeComponent();

            this.Text = "Добавление заказа";
            TitleLbl.Text = "Добавление заказа";
            IsAdd = true;

            LoadAddresses();
            LoadStatuses();

        }


        public AddEditOrderForm(Order order)
        {
            InitializeComponent();

            this.Text = "Редактирование заказа";
            TitleLbl.Text = "Редактирование заказа";
            CurOrder = order;
            IsAdd = false;

            LoadAddresses();
            LoadStatuses();


            ArticleLbl.Text = CurOrder.Article;
            AddressesCB.Text = CurOrder.Address;
            StatusCB.Text = CurOrder.Status;
            OrderDatePicker.Value = CurOrder.OrderDate.ToDateTime(TimeOnly.MinValue)  ;
            DeliveryDatePicker.Value = CurOrder.DeliveryDate.ToDateTime(TimeOnly.MinValue);

        }

        private void LoadAddresses()
        {
            try
            {
                var db = new Database();
                var addresses = db.GetAddresses();

                AddressesCB.DataSource = addresses;
                AddressesCB.DisplayMember = "Name";
                AddressesCB.ValueMember = "Id";
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void LoadStatuses()
        {
            try
            {
                var db = new Database();
                var statuses = db.GetStatuses();

                StatusCB.DataSource = statuses;
                StatusCB.DisplayMember = "Name";
                StatusCB.ValueMember = "Id";
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void SveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var newOrder = new Order
                {
                    Article = ArticleLbl.Text,
                    AddressId = (int)AddressesCB.SelectedValue,
                    StatusId = (int)StatusCB.SelectedValue,
                    OrderDate = DateOnly.FromDateTime(OrderDatePicker.Value.Date),
                    DeliveryDate = DateOnly.FromDateTime(DeliveryDatePicker.Value.Date)
                };



                if (IsAdd)
                {
                    var db = new Database();
                    var success = db.AddOrder(newOrder);

                    if (success == -1)
                    {
                        MessageBox.Show("При добавлении заказа произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Заказ добвален успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {

                    newOrder.Id = CurOrder.Id;

                    var db = new Database();
                    var success = db.UpdateOrder(newOrder);

                    if (success == -1)
                    {
                        MessageBox.Show("При редактировании заказа произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Заказ отредактирован успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
