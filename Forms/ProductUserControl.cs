using Microsoft.VisualBasic.ApplicationServices;
using ShoesStoreProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreProject.Forms
{
    public partial class ProductUserControl : UserControl
    {


        public event EventHandler ProductEdited;

        private Product CurProduct;

        public ProductUserControl(Product product, UserModel user)
        {
            InitializeComponent();

            CurProduct = product;

            FullNameLbl.Text = product.FullName;
            DescLbl.Text = $"Описание: {product.Description}";
            ProdLbl.Text = $"Производитель: {product.Producer}";
            SupLbl.Text = $"Поставщик: {product.Supplier}";
            PriceLbl.Text = $"{product.Price}";
            UnitLbl.Text = $"Единица измерения: {product.Unit}";
            CntLbl.Text = $"Количество на складе: {product.InStock}";
            DiscLbl.Text = $"{product.Discount} %";
            PictureBox.Image = product.GetImage();

            HighDiscount();
            ShowDiscount();
            ZeroInStock();

            if (user.Role == "Администратор")
            {
                RegisterClick(this);
            }
            
        }


        private void RegisterClick(Control control)
        {
            control.Click += Control_Click;
            foreach (Control child in control.Controls)
            {
                RegisterClick(child);
            }
        }

        private void Control_Click(object? sender, EventArgs e)
        {
            var form = new AddEditProductForm(CurProduct);
            form.ShowDialog();
            ProductEdited?.Invoke(this, e);
        }



        private void HighDiscount()
        {

            if (CurProduct.Discount > 15)
            {
                this.BackColor = ColorTranslator.FromHtml("#2E8B57");
            }
        }


        private void ShowDiscount()
        {

            if (CurProduct.Discount > 0)
            {
                
                var font = new Font(label2.Font, FontStyle.Strikeout);
                PriceLbl.Font = font;
                PriceLbl.ForeColor = Color.Red;

                NewPriceLbl.Visible = true;
                NewPriceLbl.Text = $"{CurProduct.NewPrice()}";

            }
        }

        private void ZeroInStock()
        {

            if (CurProduct.InStock == 0)
            {
                this.BackColor = Color.LightBlue;
            }
        }
    }
}
