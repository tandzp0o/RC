using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }
        // sự kiện thêm Cate
        private void btnAddC_Click(object sender, EventArgs e)
        {
            _connection.AddCateAsync(txtCate.Text, tagC);
            LoadComboBoxAsync();
        }
        // sự kiện thêm Pro
        private void btnAddP_Click(object sender, EventArgs e)
        {
            _connection.AddProductAsync(txtPro.Text, tagP, txtPrice.Text, 
                txtAmount.Text, cbbCate.SelectedText, cbbBrand.SelectedText);
            LoadComboBoxAsync();
        }

        private void cbbCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
