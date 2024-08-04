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
            label1.Location = new Point(25, 148);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 13;
            label1.Text = "Mật khẩu";
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(25, 93);
            User.Name = "User";
            User.Size = new Size(36, 15);
            User.TabIndex = 12;
            User.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(25, 166);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(284, 23);
            txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(286, 23);
            txtEmail.TabIndex = 10;
            // 
            // btnDangki
            // 
            btnDangki.Location = new Point(45, 297);
            btnDangki.Name = "btnDangki";
            btnDangki.Size = new Size(93, 40);
            btnDangki.TabIndex = 9;
            btnDangki.Text = "Đăng kí";
            btnDangki.UseVisualStyleBackColor = true;
            btnDangki.Click += btnDangki_Click;
            // 
            // btnvedangnhap
            // 
            btnvedangnhap.Location = new Point(174, 297);
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
            pictureBox1.Location = new Point(335, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(23, 221);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(284, 23);
            txtConfirmPassword.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 203);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
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
            panel1.Size = new Size(662, 355);
            panel1.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(286, 23);
            txtName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 38);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 19;
            label3.Text = "Họ Tên";
            // 
            // rNu
            // 
            rNu.AutoSize = true;
            rNu.Location = new Point(190, 265);
            rNu.Name = "rNu";
            rNu.Size = new Size(41, 19);
            rNu.TabIndex = 17;
            rNu.TabStop = true;
            rNu.Text = "Nữ";
            rNu.UseVisualStyleBackColor = true;
            // 
            // rNam
            // 
            rNam.AutoSize = true;
            rNam.Location = new Point(72, 265);
            rNam.Name = "rNam";
            rNam.Size = new Size(51, 19);
            rNam.TabIndex = 16;
            rNam.TabStop = true;
            rNam.Text = "Nam";
            rNam.UseVisualStyleBackColor = true;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 379);
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