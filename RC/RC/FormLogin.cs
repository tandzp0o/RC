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
            string username = txtUser.Text;
            string password = txtPassword.Text;

            bool isValid = await CheckLogin(username, password);
            if (isValid)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Chuyển hướng người dùng đến form chính hoặc thực hiện hành động tiếp theo
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<bool> CheckLogin(string username, string password)
        {
            var query = "MATCH (u:User {username: $username}) RETURN u.password AS Password";

            using (var session = _driver.AsyncSession())
            {
                var result = await session.RunAsync(query, new { username });
                var record = await result.SingleAsync();

                if (record != null)
                {
                    var retrievedPassword = record["Password"].As<string>();
                    return password == retrievedPassword;
                }
            }

            return false;
        }

        // giải phóng tài nguyên khi đóng form
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _driver?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
