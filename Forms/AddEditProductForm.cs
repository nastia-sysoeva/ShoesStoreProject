using ShoesStoreProject.Data;
using ShoesStoreProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreProject.Forms
{
    public partial class AddEditProductForm : Form
    {

        private bool IsAdd;
        private string SelectedImagePath;
        private string SelectedImageName;
        private string DefaultImagePath = Path.Combine(Application.StartupPath, "Pictures", "picture.png");

        private Product EditingProduct;

        public AddEditProductForm()
        {
            InitializeComponent();

            IsAdd = true;
            SelectedImagePath = DefaultImagePath;

            this.Text = "Добавление товара";
            TitleLbl.Text = "Добавление товара";

            CatCB.SelectedIndex = 1;
            ProdCB.SelectedIndex = 1;
            SupCB.SelectedIndex = 1;
            CntTB.Text = "0";
            DiscountTB.Text = "0";
            UnitTB.Text = "шт.";

            PictureBox.Image = new Bitmap(DefaultImagePath);

        }


        public AddEditProductForm(Product selectedProduct)
        {
            InitializeComponent();

            IsAdd = false;
            SelectedImagePath = Path.Combine(Application.StartupPath, "Pictures", selectedProduct.PhotoName);
            EditingProduct = selectedProduct;

            this.Text = "Редактирование товара";
            TitleLbl.Text = "Редактирование товара";

            IdPanel.Visible = true;
            DeleteBtn.Visible = true;

            IdTB.Text = $"{selectedProduct.Id}";
            NameTB.Text = selectedProduct.Name;
            DescTB.Text = selectedProduct.Description;
            CatCB.Text = selectedProduct.Category;
            ProdCB.Text = selectedProduct.Producer;
            SupCB.Text = selectedProduct.Supplier;
            CntTB.Text = $"{selectedProduct.InStock}";
            DiscountTB.Text = $"{selectedProduct.Discount}";
            UnitTB.Text = $"{selectedProduct.Unit}";
            PriceTB.Text = $"{selectedProduct.Price}";

            PictureBox.Image = new Bitmap(SelectedImagePath);

        }



        // Сохранение добавления / изменений
        private void SaveBtn_Click(object sender, EventArgs e)
        {


                // Проверки заполненности полей

                if (String.IsNullOrWhiteSpace(NameTB.Text) || String.IsNullOrWhiteSpace(DescTB.Text) || String.IsNullOrWhiteSpace(PriceTB.Text)
        || String.IsNullOrWhiteSpace(CntTB.Text) || String.IsNullOrWhiteSpace(UnitTB.Text) || String.IsNullOrWhiteSpace(DiscountTB.Text))
                {
                    MessageBox.Show("Заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Decimal.TryParse(PriceTB.Text, out decimal resultDec) || resultDec < 0)
                {
                    MessageBox.Show("Введите корректную цену.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(CntTB.Text, out int resultInt) || resultInt < 0)
                {
                    MessageBox.Show("Введите корректное количество на складе.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Сохранение изображения
                if (SelectedImagePath != DefaultImagePath)
                {
                    var destFileName = Path.Combine(Application.StartupPath, "Pictures", $"{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.png");
                    File.Copy(SelectedImagePath, destFileName);
                    SelectedImageName = Path.GetFileName(destFileName);
                }
                else
                {
                    SelectedImageName = Path.GetFileName(DefaultImagePath);
                }

            try
            {

                // Создание нового объекта
                var newProduct = new Product
                {
                    Name = NameTB.Text,
                    Price = Decimal.Parse(PriceTB.Text),
                    Supplier = SupCB.Text,
                    Producer = ProdCB.Text,
                    Category = CatCB.Text,
                    Discount = int.Parse(DiscountTB.Text),
                    InStock = int.Parse(CntTB.Text),
                    Description = DescTB.Text,
                    Unit = UnitTB.Text,
                    PhotoName = SelectedImageName
                };


                if (IsAdd == true)
                {
                    var db = new Database();
                    var success = db.AddProduct(newProduct);

                    if (success == -1)
                    {
                        MessageBox.Show("При добавлении товара произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Товар добавлен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

                if (IsAdd == false)
                {

                    newProduct.Id = EditingProduct.Id;

                    var db = new Database();
                    var success = db.UpdateProduct(newProduct);

                    if (success == -1)
                    {
                        MessageBox.Show("При редактировании товара произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Товар отредактирован успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
                return;
            }


        }


        // Добавление фотографии
        private void AddPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                using var fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = false;
                fileDialog.Filter = "Изображения| *.jpg; *.jpeg; *.png";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {

                    var selectedFilePath = fileDialog.FileName;
                    var selectedImage = new Bitmap(selectedFilePath);

                    // Проверка размера фото 300 х 200
                    if (selectedImage.Width > 3000 || selectedImage.Height > 2000)
                    {
                        MessageBox.Show("Изображение слишком большое. Выберите фото с разрешением меньшим, чем 300х200.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    PictureBox.Image = selectedImage;
                    SelectedImagePath = selectedFilePath;
                }
            }
            catch
            {
                MessageBox.Show("При добавлении изображения произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void DeletePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SelectedImagePath = DefaultImagePath;
                PictureBox.Image = new Bitmap(SelectedImagePath);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить этот товар?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var db = new Database();
                    var success = db.DeleteProduct(EditingProduct);

                    if (success == -1)
                    {
                        MessageBox.Show("При удалении товара произошла ошибка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Товар удалён успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
