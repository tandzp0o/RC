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

        private async Task<bool> isRegistered(string hoTen, string email, string pass, string gender)
        {
            var query = "Create (u:Customer {name:'" + hoTen + "',name:'" + email + "',name:'" + pass + "',name:'" + gender + "'})";

            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync(query, new { email });
                var record = await result.SingleAsync();

                if (record != null)
                {
                    //var retrievedPassword = record["Pass"].As<string>();
                    //return pass == retrievedPassword;
                    return true;
                }
            }

            return false;
        }

        private async void btnDangki_Click(object sender, EventArgs e)
        {
            string hoTen = txtName.Text;
            string email = txtEmail.Text;
            string pass = txtPassword.Text;
            string rePass = txtConfirmPassword.Text;
            string gender="";
            if (rNam.Checked)
                gender = "Nam";
            if (rNu.Checked)
                gender = "Nữ";

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(rePass) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (pass != rePass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }
            
            // kiểm tra đã đăng ký

            if (await isRegistered(hoTen, email, pass, gender))
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
