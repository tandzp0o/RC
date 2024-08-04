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
            panel1 = new Panel();
            label3 = new Label();
            PN3 = new Panel();
            btnBuy = new Button();
            soLuong = new Label();
            btnInc = new Button();
            btnDes = new Button();
            label1 = new Label();
            BrandSP = new Label();
            CategorySP = new Label();
            giaSP = new Label();
            nameSP = new Label();
            anhSP = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anhSP).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(PN3);
            panel1.Controls.Add(btnBuy);
            panel1.Controls.Add(soLuong);
            panel1.Controls.Add(btnInc);
            panel1.Controls.Add(btnDes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BrandSP);
            panel1.Controls.Add(CategorySP);
            panel1.Controls.Add(giaSP);
            panel1.Controls.Add(nameSP);
            panel1.Controls.Add(anhSP);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(922, 614);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 435);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 11;
            label3.Text = "Liên quan";
            // 
            // PN3
            // 
            PN3.Location = new Point(52, 462);
            PN3.Name = "PN3";
            PN3.Size = new Size(820, 123);
            PN3.TabIndex = 10;
            // 
            // btnBuy
            // 
            btnBuy.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(338, 377);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(261, 48);
            btnBuy.TabIndex = 9;
            btnBuy.Text = "Mua ngay";
            btnBuy.UseVisualStyleBackColor = true;
            // 
            // soLuong
            // 
            soLuong.AutoSize = true;
            soLuong.Font = new Font("Segoe UI", 12F);
            soLuong.Location = new Point(480, 307);
            soLuong.Name = "soLuong";
            soLuong.Size = new Size(19, 21);
            soLuong.TabIndex = 8;
            soLuong.Text = "1";
            // 
            // btnInc
            // 
            btnInc.Font = new Font("Segoe UI", 12F);
            btnInc.Location = new Point(512, 302);
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
            btnDes.Location = new Point(431, 302);
            btnDes.Name = "btnDes";
            btnDes.Size = new Size(36, 30);
            btnDes.TabIndex = 6;
            btnDes.Text = "-";
            btnDes.UseVisualStyleBackColor = true;
            btnDes.Click += btnDes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label1.Location = new Point(224, 17);
            label1.Name = "label1";
            label1.Size = new Size(22, 24);
            label1.TabIndex = 5;
            label1.Text = ">";
            // 
            // BrandSP
            // 
            BrandSP.AutoSize = true;
            BrandSP.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            BrandSP.ForeColor = SystemColors.Highlight;
            BrandSP.Location = new Point(272, 17);
            BrandSP.Name = "BrandSP";
            BrandSP.Size = new Size(64, 24);
            BrandSP.TabIndex = 4;
            BrandSP.Text = "brand";
            // 
            // CategorySP
            // 
            CategorySP.AutoSize = true;
            CategorySP.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            CategorySP.ForeColor = SystemColors.Highlight;
            CategorySP.Location = new Point(52, 17);
            CategorySP.Name = "CategorySP";
            CategorySP.Size = new Size(146, 24);
            CategorySP.TabIndex = 3;
            CategorySP.Text = "Loại sản phẩm";
            // 
            // giaSP
            // 
            giaSP.AutoSize = true;
            giaSP.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            giaSP.ForeColor = Color.Coral;
            giaSP.Location = new Point(431, 227);
            giaSP.Name = "giaSP";
            giaSP.Size = new Size(131, 25);
            giaSP.TabIndex = 2;
            giaSP.Text = "Giá sản phẩm";
            // 
            // nameSP
            // 
            nameSP.AutoSize = true;
            nameSP.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameSP.Location = new Point(431, 92);
            nameSP.Name = "nameSP";
            nameSP.Size = new Size(133, 25);
            nameSP.TabIndex = 1;
            nameSP.Text = "Tên sản phẩm";
            // 
            // anhSP
            // 
            anhSP.Location = new Point(52, 92);
            anhSP.Name = "anhSP";
            anhSP.Size = new Size(327, 240);
            anhSP.SizeMode = PictureBoxSizeMode.Zoom;
            anhSP.TabIndex = 0;
            anhSP.TabStop = false;
            // 
            // FormProductDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 638);
            Controls.Add(panel1);
            Name = "FormProductDetail";
            Text = "FormProductDetail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)anhSP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label BrandSP;
        private Label CategorySP;
        private Label giaSP;
        private Label nameSP;
        private PictureBox anhSP;
        private Label soLuong;
        private Button btnInc;
        private Button btnDes;
        private Button btnBuy;
        private Panel PN3;
        private Label label3;
    }
}