namespace RC
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBox1 = new PictureBox();
            PN1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            PN2 = new Panel();
            PN3 = new Panel();
            panel1 = new Panel();
            PN4 = new Panel();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PN1
            // 
            PN1.Location = new Point(146, 543);
            PN1.Name = "PN1";
            PN1.Size = new Size(794, 145);
            PN1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(146, 175);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 4;
            label2.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(146, 3);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 6;
            label3.Text = "Category";
            // 
            // PN2
            // 
            PN2.Location = new Point(146, 199);
            PN2.Name = "PN2";
            PN2.Size = new Size(794, 145);
            PN2.TabIndex = 3;
            // 
            // PN3
            // 
            PN3.Location = new Point(146, 27);
            PN3.Name = "PN3";
            PN3.Size = new Size(794, 145);
            PN3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(PN4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(PN1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(PN3);
            panel1.Controls.Add(PN2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 690);
            panel1.TabIndex = 7;
            // 
            // PN4
            // 
            PN4.Location = new Point(146, 371);
            PN4.Name = "PN4";
            PN4.Size = new Size(794, 145);
            PN4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(146, 347);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 5;
            label5.Text = "Product";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(49, 587);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 714);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Panel PN1;
        private Label label2;
        private Label label3;
        private Panel PN2;
        private Panel PN3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel PN4;
        private Label label5;
    }
}
