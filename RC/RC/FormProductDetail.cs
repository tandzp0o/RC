using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace RC
{
    public partial class FormProductDetail : Form
    {
        private FlowLayoutPanel _categoryPanel;
        int sl = 1;
        double gia = 0;
        private Neo4jConnection _connection;
        public FormProductDetail()
        {
            InitializeComponent();
            _connection = new Neo4jConnection("bolt://localhost:7687", "neo4j", "11111111");
            InitializeUI();
        }

        private void InitializeUI()
        {
            _categoryPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                AutoScroll = true
            };
            PN3.Controls.Add(_categoryPanel);

            Button refreshButton2 = new Button
            {
                Text = "Refresh Categorys",
                Dock = DockStyle.Top
            };
            refreshButton2.Click += async (sender, e) => await LoadCategorys();
            PN3.Controls.Add(refreshButton2);
        }

        private async Task LoadCategorys()
        {
            try
            {
                _categoryPanel.Controls.Clear();
                var categorys = await _connection.GetCategory();
                foreach (var cate in categorys)
                {
                    AddCategoryToPanel(cate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void AddCategoryToPanel(Category category)
        {
            PictureBox pictureBox = new PictureBox
            {
                Width = 100,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = LoadImage(category.Image, category) ?? null,
                Margin = new Padding(5)
            };
            pictureBox.Tag = category.Name;
            pictureBox.Click += PictureBox_Click;

            Label nameLabel = new Label
            {
                Text = category.Name,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 100
            };

            Panel categoryPanel = new Panel
            {
                Width = 110,
                Height = 130
            };
            categoryPanel.Controls.Add(pictureBox);
            categoryPanel.Controls.Add(nameLabel);
            nameLabel.Location = new System.Drawing.Point(0, 105);

            _categoryPanel.Controls.Add(categoryPanel);
        }

        private async void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string productName = pictureBox.Tag as string;
                if (!string.IsNullOrEmpty(productName))
                {
                    _connection.HandleProductClickAsync(productName);
                }
            }
        }

        private System.Drawing.Image LoadImage(string imagePath, object entity = null)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        System.Drawing.Image image = System.Drawing.Image.FromStream(stream);
                        if (entity != null)
                        {
                            if (entity is Product p)
                            {
                                image.Tag = p.Name;
                            }
                            else if (entity is Brand b)
                            {
                                image.Tag = b.Name;
                            }
                            else if (entity is Category c)
                            {
                                image.Tag = c.Name;
                            }
                        }
                        return image;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
            return null;
        }

        public string RemoveQuotes(string input)
        {
            return input.Replace("\"", "").Replace("'", "");
        }
        public FormProductDetail(Product productName)
        {
            InitializeComponent();
            string path = GetSiblingDirectory("SP") + "\\" + RemoveQuotes(productName.Image); // đường dẫn tới hình ảnh
            Bitmap bitmap = new Bitmap(path);
            anhSP.BackgroundImage = new Bitmap(bitmap);
            anhSP.BackgroundImageLayout = ImageLayout.Zoom;
            nameSP.Text = productName.Name;
            giaSP.Text = $"Giá: {productName.Price:C}";
            gia = (double)productName.Price;
        }

        private System.Drawing.Image LoadImage(string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        return System.Drawing.Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
            return null;
        }
        // lấy đường dẫn đến thư mục sản phẩm cách 2 (tôi chưa tối ưu cái phương thức này)
        public static string GetSiblingDirectory(string folderName)
        {
            string executingAssemblyPath = Assembly.GetExecutingAssembly().Location;
            string binDirectory = Path.GetDirectoryName(executingAssemblyPath);
            string projectDirectory = Directory.GetParent(binDirectory).FullName;
            string a = Directory.GetParent(projectDirectory).FullName;
            string b = Directory.GetParent(a).FullName;
            string siblingDirectory = Path.Combine(b, folderName);
            return siblingDirectory;
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            if (sl > 0)
            {
                sl -= 1;
            }
            else
            {
                sl = 0;
            }
            soLuong.Text = sl.ToString();
            giaSP.Text = (sl * gia).ToString();
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            sl += 1;
            soLuong.Text = sl.ToString();
            giaSP.Text = (sl * gia).ToString();
        }
    }

}
