using Microsoft.VisualBasic.ApplicationServices;
using ShoesStoreProject.Data;
using ShoesStoreProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreProject.Forms
{
    public partial class ProductsForm : Form
    {

        private string CurSearch;
        private string CurFilter;
        private string CurSort;
        private UserModel CurUser;

        public ProductsForm(UserModel user)
        {
            try
            {
                InitializeComponent();
                UserNameLbl.Text = user.FullName;

                CurSearch = "";
                CurFilter = "Все поставщики";
                CurSort = "ASC";
                CurUser = user;

                SortCB.Text = "По возрастанию";
                FilterCB.Text = "Все поставщики";

                if (CurUser.Role == "Авторизированный клиент" || CurUser.Role == "Гость")
                {
                    AdminMngrPanel.Visible = false;
                    OrdersBtn.Visible = false;
                }

                if (CurUser.Role == "Администратор")
                {
                    AddBtn.Visible = true;
                }


                LoadProducts();

                panel3.BackColor = ColorTranslator.FromHtml("#7FFF00");
                AddBtn.BackColor = ColorTranslator.FromHtml("#00FA9A");
                OrdersBtn.BackColor = ColorTranslator.FromHtml("#00FA9A");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка: {ex.Message}");
                return;
            }
        }


        private void LoadProducts()
        {

            try
            {
                FlowLayoutPanel.Controls.Clear();

                var db = new Database();
                var products = db.GetProducts(CurSearch, CurSort, CurFilter);

                foreach (var product in products)
                {
                    var item = new ProductUserControl(product, CurUser);
                    FlowLayoutPanel.Controls.Add(item);

                    item.ProductEdited += Item_ProductEdited;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка: {ex.Message}");
                return;
            }
        }

        private void Item_ProductEdited(object? sender, EventArgs e)
        {
            try
            {
                LoadProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка: {ex.Message}");
                return;
            }
        }

        private void UserNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var form = new LogForm();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка: {ex.Message}");
                return;
            }
        }

        private void SearchTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurSearch = SearchTB.Text;
                LoadProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка: {ex.Message}");
                return;
            }
        }

        private void FilterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CurFilter = FilterCB.Text;
                LoadProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка: {ex.Message}");
                return;
            }
        }

        private void SortCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (SortCB.Text == "По возрастанию")
                {
                    CurSort = "ASC";
                }
                if (SortCB.Text == "По убыванию")
                {
                    CurSort = "DESC";
                }
                LoadProducts();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка: {ex.Message}");
                return;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var form = new AddEditProductForm();
            form.ShowDialog();
            LoadProducts();
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            var form = new OrdersForm(CurUser);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
