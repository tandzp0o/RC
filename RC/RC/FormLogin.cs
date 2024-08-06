using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4j.Driver;
using System.Reflection;
using Neo4jClient.Cypher;
namespace RC
{
    public partial class FormLogin : Form
    {
        private readonly IDriver _driver;
        public FormLogin()
        {
            InitializeComponent();
            _driver = GraphDatabase.Driver("bolt://localhost:7687", AuthTokens.Basic("neo4j", "11111111"));
            InitializeUI();
        }
        private void InitializeUI()
        {
            // Thực hiện các thao tác khởi tạo giao diện người dùng tùy chỉnh
            this.Text = "Login Form";

        }
        private async void btnDangnhap_Click(object sender, EventArgs e)
        {
            string email = txtUser.Text;
            string pass = txtPassword.Text;

            bool isValid = await CheckLogin(email, pass);
            if (isValid)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bool isAdmin = await IsCustomerAdmin(email);
                if (isAdmin)
                {
                    FormManager formManager = new FormManager();
                    formManager.ShowDialog();
                }
                else
                {
                    // Chuyển hướng người dùng đến form chính hoặc thực hiện hành động tiếp theo
                    FormMain formMain = new FormMain(txtUser.Text);
                    formMain.Show();
                    this.Hide();
                } 
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> CheckLogin(string email, string pass)
        {
            var query = @" MATCH (u:Customer {email: $email}) RETURN u.pass AS Pass";

            using (var session = _driver.AsyncSession())
            {
                try
                {
                    var result = await session.ReadTransactionAsync(async tx =>
                    {
                        var cursor = await tx.RunAsync(query, new { email });
                        return await cursor.ToListAsync();
                    });

                    if (result.Count == 0)
                    {

                        return false;
                    }
                    var retrievedPassword = result[0]["Pass"].As<string>();
                    if (pass == retrievedPassword)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public async Task<bool> IsCustomerAdmin(string email)
        {
            await using var session = _driver.AsyncSession();
            return await session.ReadTransactionAsync(async tx =>
            {
                var query = "MATCH (a:Customer {email: '"+email+"'}) RETURN a.ad IS NOT NULL AND a.ad = '1' AS isAdmin";

                var result = await tx.RunAsync(query);
                var record = await result.SingleAsync();
                return record["isAdmin"].As<bool>();
            });
        }

        // giải phóng tài nguyên khi đóng form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _driver?.Dispose();
            base.OnFormClosed(e);
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            // Mở form đăng ký
            FormRegister formRegister = new FormRegister();
            formRegister.Show();

            // Ẩn form đăng nhập hiện tại
            this.Hide();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (r == DialogResult.No)
            //    e.Cancel = true;
        }
    }
}
