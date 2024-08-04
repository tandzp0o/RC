namespace RC
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            label1 = new Label();
            User = new Label();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            btnDangki = new Button();
            btnvedangnhap = new Button();
            pictureBox1 = new PictureBox();
            txtConfirmPassword = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 67);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 13;
            label1.Text = "Password:";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(10, 27);
            User.Name = "User";
            User.Size = new Size(33, 15);
            User.TabIndex = 12;
            User.Text = "User:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(124, 67);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(172, 23);
            txtPassword.TabIndex = 11;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(124, 19);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(172, 23);
            txtUser.TabIndex = 10;
            // 
            // btnDangki
            // 
            btnDangki.Location = new Point(46, 146);
            btnDangki.Name = "btnDangki";
            btnDangki.Size = new Size(93, 40);
            btnDangki.TabIndex = 9;
            btnDangki.Text = "Đăng kí";
            btnDangki.UseVisualStyleBackColor = true;
            btnDangki.Click += btnDangki_Click;
            // 
            // btnvedangnhap
            // 
            btnvedangnhap.Location = new Point(192, 146);
            btnvedangnhap.Name = "btnvedangnhap";
            btnvedangnhap.Size = new Size(93, 40);
            btnvedangnhap.TabIndex = 8;
            btnvedangnhap.Text = "Về Đăng Nhập";
            btnvedangnhap.UseVisualStyleBackColor = true;
            btnvedangnhap.Click += btnvedangnhap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(124, 107);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(172, 23);
            txtConfirmPassword.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 15;
            label2.Text = "ConFirm Password:";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 192);
            Controls.Add(label2);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label1);
            Controls.Add(User);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(btnDangki);
            Controls.Add(btnvedangnhap);
            Controls.Add(pictureBox1);
            Name = "FormRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label User;
        private TextBox txtPassword;
        private TextBox txtUser;
        private Button btnDangki;
        private Button btnvedangnhap;
        private PictureBox pictureBox1;
        private TextBox txtConfirmPassword;
        private Label label2;
    }
}