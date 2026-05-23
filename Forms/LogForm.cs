using ShoesStoreProject.Data;
using ShoesStoreProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ShoesStoreProject.Forms
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            LogBtn.BackColor = ColorTranslator.FromHtml("#00FA9A");
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            var login = LogTB.Text;
            var pass = PasTB.Text;

            var db = new Database();
            var user = db.GetUser(login, pass);

            if (user.Role == "Гость")
            {
                MessageBox.Show("Пользователь не найден. Проверьте логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new ProductsForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();

            

        }

        private void GuestBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var user = new UserModel
            {
                Role = "Гость",
                Name = "Гость"
            };

            var form = new ProductsForm(user);
            this.Hide();
            form.ShowDialog();
            this.Close();

        }
    }
}
