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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(318, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(42, 139);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(93, 40);
            btnDangnhap.TabIndex = 1;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // btnDangki
            // 
            btnDangki.Location = new Point(190, 139);
            btnDangki.Name = "btnDangki";
            btnDangki.Size = new Size(93, 40);
            btnDangki.TabIndex = 2;
            btnDangki.Text = "Đăng kí";
            btnDangki.UseVisualStyleBackColor = true;
            btnDangki.Click += btnDangki_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(77, 12);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(196, 23);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(77, 57);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(196, 23);
            txtPassword.TabIndex = 4;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(14, 20);
            User.Name = "User";
            User.Size = new Size(30, 15);
            User.TabIndex = 5;
            User.Text = "User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 60);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Password";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 181);
            Controls.Add(label1);
            Controls.Add(User);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(btnDangki);
            Controls.Add(btnDangnhap);
            Controls.Add(pictureBox1);
            Name = "FormLogin";
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnDangnhap;
        private Button btnDangki;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label User;
        private Label label1;
    }
}