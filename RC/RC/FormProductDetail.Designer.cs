namespace RC
{
    partial class FormProductDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductDetail));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            PN3 = new Panel();
            btnBuy = new Button();
            soLuong = new Label();
            btnInc = new Button();
            btnDes = new Button();
            giaSP = new Label();
            nameSP = new Label();
            anhSP = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)anhSP).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PN3);
            panel1.Controls.Add(btnBuy);
            panel1.Controls.Add(soLuong);
            panel1.Controls.Add(btnInc);
            panel1.Controls.Add(btnDes);
            panel1.Controls.Add(giaSP);
            panel1.Controls.Add(nameSP);
            panel1.Controls.Add(anhSP);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 727);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 405);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 2;
            label1.Text = "Liên quan";
            // 
            // PN3
            // 
            PN3.Location = new Point(52, 443);
            PN3.Name = "PN3";
            PN3.Size = new Size(820, 262);
            PN3.TabIndex = 10;
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(526, 339);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(261, 48);
            btnBuy.TabIndex = 9;
            btnBuy.Text = "Mua ngay";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // soLuong
            // 
            soLuong.AutoSize = true;
            soLuong.Font = new Font("Segoe UI", 12F);
            soLuong.Location = new Point(575, 289);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(19, 21);
            soLuong.TabIndex = 8;
            soLuong.Text = "1";
            // 
            // btnInc
            // 
            btnInc.Font = new Font("Segoe UI", 12F);
            btnInc.Location = new Point(607, 284);
            btnInc.Name = "btnInc";
            btnInc.Size = new Size(36, 30);
            btnInc.TabIndex = 7;
            btnInc.Text = "+";
            btnInc.UseVisualStyleBackColor = true;
            btnInc.Click += btnInc_Click;
            // 
            // btnDes
            // 
            btnDes.Font = new Font("Segoe UI", 12F);
            btnDes.Location = new Point(526, 284);
            btnDes.Name = "btnDes";
            btnDes.Size = new Size(36, 30);
            btnDes.TabIndex = 6;
            btnDes.Text = "-";
            btnDes.UseVisualStyleBackColor = true;
            btnDes.Click += btnDes_Click;
            // 
            // giaSP
            // 
            giaSP.AutoSize = true;
            giaSP.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            giaSP.ForeColor = Color.Coral;
            giaSP.Location = new Point(522, 226);
            giaSP.Name = "giaSP";
            giaSP.Size = new Size(131, 25);
            giaSP.TabIndex = 2;
            giaSP.Text = "Giá sản phẩm";
            // 
            // nameSP
            // 
            nameSP.AutoSize = true;
            nameSP.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameSP.Location = new Point(522, 72);
            nameSP.Name = "nameSP";
            nameSP.Size = new Size(133, 25);
            nameSP.TabIndex = 1;
            nameSP.Text = "Tên sản phẩm";
            // 
            // anhSP
            // 
            anhSP.Location = new Point(52, 72);
            anhSP.Name = "anhSP";
            anhSP.Size = new Size(386, 315);
            anhSP.SizeMode = PictureBoxSizeMode.Zoom;
            anhSP.TabIndex = 0;
            anhSP.TabStop = false;
            // 
            // FormProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 751);
            Controls.Add(panel1);
            Name = "FormProductDetail";
            Text = "FormProductDetail";
            FormClosing += FormProductDetail_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)anhSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label giaSP;
        private Label nameSP;
        private PictureBox anhSP;
        private Label soLuong;
        private Button btnInc;
        private Button btnDes;
        private Button btnBuy;
        private Panel PN3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}