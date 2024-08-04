using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4j.Driver;
namespace RC
{
    public partial class FormRegister : Form
    {
        private IDriver _driver;
        public FormRegister()
        {
            InitializeComponent();
            _driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("username", "password"));

        }

        private async void btnDangki_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }

            bool isRegistered = await _userService.RegisterUserAsync(username, password);

            if (isRegistered)
            {
                MessageBox.Show("Đăng ký thành công!");
                // Có thể thực hiện các hành động khác như chuyển hướng hoặc đóng form
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi đăng ký. Vui lòng thử lại.");
            }
        }

        private void btnvedangnhap_Click(object sender, EventArgs e)
        {
            // Mở lại form đăng nhập
            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            // Ẩn form đăng ký hiện tại
            this.Hide();
        }
    }
}
