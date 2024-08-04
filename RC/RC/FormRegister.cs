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
            _driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "11111111"));
        }

        private async Task<bool> isRegistered(string hoTen, string email, string pass, string gender)
        {
            try
            {
                using (var session = _driver.AsyncSession())
                {
                    var result = await session.WriteTransactionAsync(async tx =>
                    {
                        var checkExistingQuery = "MATCH (u:Customer {email: $email}) RETURN u";
                        var existingUser = await tx.RunAsync(checkExistingQuery, new { email });

                        if (await existingUser.FetchAsync())
                        {
                            return false; // Email đã tồn tại
                        }

                        var createQuery = @"CREATE (u:Customer {name: $hoTen,email: $email,pass: $pass,gender: $gender})RETURN u";

                        var parameters = new
                        {
                            hoTen,
                            email,
                            pass,
                            gender
                        };

                        var createResult = await tx.RunAsync(createQuery, parameters);
                        return await createResult.FetchAsync();
                    });

                    return result;
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Lỗi khi đăng ký khách hàng: {ex.Message}");
                return false;
            }
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

            //if (!email.IsValid(email))
            //{
            //    throw new ArgumentException("Email không hợp lệ.");
            //}

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
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email đã được đăng ký!");
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
