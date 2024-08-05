namespace RC
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBox1 = new PictureBox();
            btnDangnhap = new Button();
            btnDangki = new Button();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            User = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(342, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangnhap.Location = new Point(38, 175);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(114, 40);
            btnDangnhap.TabIndex = 1;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnDangki
            // 
            btnDangki.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangki.Location = new Point(186, 175);
            btnDangki.Name = "btnDangki";
            btnDangki.Size = new Size(114, 40);
            btnDangki.TabIndex = 2;
            btnDangki.Text = "Đăng kí";
            btnDangki.UseVisualStyleBackColor = true;
            btnDangki.Click += btnDangki_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(38, 50);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(262, 23);
            txtUser.TabIndex = 3;
            txtUser.Text = "name@gmail.com";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(38, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "123";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            User.Location = new Point(38, 26);
            User.Name = "User";
            User.Size = new Size(53, 21);
            User.TabIndex = 5;
            User.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(38, 94);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 6;
            label1.Text = "Mật khẩu";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnDangki);
            panel1.Controls.Add(User);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnDangnhap);
            panel1.Controls.Add(txtUser);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(589, 245);
            panel1.TabIndex = 7;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 268);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnDangnhap;
        private Button btnDangki;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label User;
        private Label label1;
        private Panel panel1;
    }
}