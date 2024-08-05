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
            txtEmail = new TextBox();
            btnDangki = new Button();
            btnvedangnhap = new Button();
            pictureBox1 = new PictureBox();
            txtConfirmPassword = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            txtName = new TextBox();
            label3 = new Label();
            rNu = new RadioButton();
            rNam = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(354, 141);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 13;
            label1.Text = "Mật khẩu";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            User.Location = new Point(354, 78);
            User.Name = "User";
            User.Size = new Size(53, 21);
            User.TabIndex = 12;
            User.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(354, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(284, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(354, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(286, 23);
            txtEmail.TabIndex = 2;
            // 
            // btnDangki
            // 
            btnDangki.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangki.Location = new Point(354, 308);
            btnDangki.Name = "btnDangki";
            btnDangki.Size = new Size(129, 40);
            btnDangki.TabIndex = 7;
            btnDangki.Text = "Đăng kí";
            btnDangki.UseVisualStyleBackColor = true;
            btnDangki.Click += btnDangki_Click;
            // 
            // btnvedangnhap
            // 
            btnvedangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnvedangnhap.Location = new Point(509, 308);
            btnvedangnhap.Name = "btnvedangnhap";
            btnvedangnhap.Size = new Size(129, 40);
            btnvedangnhap.TabIndex = 8;
            btnvedangnhap.Text = "Về Đăng Nhập";
            btnvedangnhap.UseVisualStyleBackColor = true;
            btnvedangnhap.Click += btnvedangnhap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 381);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(354, 228);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(284, 23);
            txtConfirmPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(354, 204);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 15;
            label2.Text = "Nhập lại mật khẩu";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rNu);
            panel1.Controls.Add(rNam);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnvedangnhap);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(btnDangki);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(User);
            panel1.Controls.Add(txtPassword);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 381);
            panel1.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Location = new Point(354, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 23);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(354, 15);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 19;
            label3.Text = "Họ Tên";
            // 
            // rNu
            // 
            rNu.AutoSize = true;
            rNu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rNu.Location = new Point(523, 258);
            rNu.Name = "rNu";
            rNu.Size = new Size(52, 25);
            rNu.TabIndex = 6;
            rNu.TabStop = true;
            rNu.Text = "Nữ";
            rNu.UseVisualStyleBackColor = true;
            // 
            // rNam
            // 
            rNam.AutoSize = true;
            rNam.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rNam.Location = new Point(405, 258);
            rNam.Name = "rNam";
            rNam.Size = new Size(65, 25);
            rNam.TabIndex = 5;
            rNam.TabStop = true;
            rNam.Text = "Nam";
            rNam.UseVisualStyleBackColor = true;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 405);
            Controls.Add(panel1);
            Name = "FormRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label User;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnDangki;
        private Button btnvedangnhap;
        private PictureBox pictureBox1;
        private TextBox txtConfirmPassword;
        private Label label2;
        private Panel panel1;
        private RadioButton rNu;
        private RadioButton rNam;
        private TextBox txtName;
        private Label label3;
    }
}