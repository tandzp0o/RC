using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RC
{
    public partial class FormManager : Form
    {
        public Neo4jConnection _connection;
        public string tagP;
        public string tagC;
        public string tagB;
        public FormManager()
        {
            InitializeComponent();
            _connection = new Neo4jConnection("bolt://localhost:7687", "neo4j", "11111111");
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            LoadComboBoxAsync();
            LoadProductsToDataGridView(dataGridView1, null);
        }
        // load 2 cbb
        private async Task LoadComboBoxAsync()
        {
            try
            {
                // Disable ComboBoxes while loading
                cbbCate.Enabled = false;
                cbbBrand.Enabled = false;

                // Load Categories
                var categories = await _connection.GetCategoryNamesAsync();
                cbbCate.DataSource = categories;

                // Load Brands
                var brands = await _connection.GetBrandNamesAsync();
                cbbBrand.DataSource = brands;

                // Re-enable ComboBoxes after loading
                cbbCate.Enabled = true;
                cbbBrand.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // sự kiện để chèn ảnh vào pic
        // cate
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.gif; *.jpeg; *.png; *.bmp;)|*.jpg; *.gif; *.jpeg; *.png; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.Image.Tag = Path.GetFileName(path);
                tagC = pictureBox1.Image.Tag.ToString();
            }
        }
        // pro
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.gif; *.jpeg; *.png; *.bmp;)|*.jpg; *.gif; *.jpeg; *.png; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                pictureBox2.Image = new Bitmap(open.FileName);
                pictureBox2.Image.Tag = Path.GetFileName(path);
                tagP = pictureBox2.Image.Tag.ToString();
            }
        }
        // brand
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.gif; *.jpeg; *.png; *.bmp;)|*.jpg; *.gif; *.jpeg; *.png; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string path = open.FileName;
                pictureBox3.Image = new Bitmap(open.FileName);
                pictureBox3.Image.Tag = Path.GetFileName(path);
                tagB = pictureBox3.Image.Tag.ToString();
            }
        }
        // sự kiện thêm brand
        private void btnAddB_Click(object sender, EventArgs e)
        {
            _connection.AddBrandAsync(txtBrand.Text,tagB);
            LoadComboBoxAsync();
            txtBrand.Clear();
            pictureBox3.Image.Dispose();
            pictureBox3.Image = null;

        }
        // sự kiện thêm Cate
        private void btnAddC_Click(object sender, EventArgs e)
        {
            _connection.AddCateAsync(txtCate.Text, tagC);
            LoadComboBoxAsync();
            txtCate.Clear();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
        }
        // sự kiện thêm Pro
        private void btnAddP_Click(object sender, EventArgs e)
        {
            _connection.AddProductAsync(txtPro.Text, tagP, txtPrice.Text, 
                txtAmount.Text, cbbCate.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
            LoadComboBoxAsync();
            txtPro.Clear();
            pictureBox2.Image.Dispose();
            pictureBox2.Image = null;
            txtAmount.Clear();
            txtPrice.Clear();
        }

        private void cbbCate_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public async Task LoadProductsToDataGridView(DataGridView dataGridView, string email = null)
        {
            try
            {
                // Lấy danh sách sản phẩm
                List<Product> products = await _connection.GetProductsAsync(email);

                // Xóa tất cả các dòng hiện có trong DataGridView
                dataGridView.Rows.Clear();

                // Đảm bảo DataGridView có đủ cột
                if (dataGridView.Columns.Count == 0)
                {
                    dataGridView.Columns.Add("Name", "Tên sản phẩm");
                    dataGridView.Columns.Add("Image", "Hình ảnh");
                }

                // Thêm sản phẩm vào DataGridView
                foreach (var product in products)
                {
                    dataGridView.Rows.Add(product.Name, product.Image);
                }

                // Tự động điều chỉnh kích thước cột
                dataGridView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi tải sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
