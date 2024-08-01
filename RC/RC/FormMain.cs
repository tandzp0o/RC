using Neo4j.Driver;
using System.Reflection;

namespace RC
{
    public partial class FormMain : Form
    {
        public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName; // đường dẫn đến mục sản phẩm
        private FlowLayoutPanel _productPanel;
        private FlowLayoutPanel _categoryPanel;
        private FlowLayoutPanel _brandPanel;
        private string maSP;
        private Neo4jConnection _connection;
        public FormMain()
        {
            InitializeComponent();
            _connection = new Neo4jConnection("bolt://localhost:7687", "neo4j", "11111111");
            InitializeUI();
        }
        private void InitializeUI()
        {
            _productPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                AutoScroll = true
            };
            PN1.Controls.Add(_productPanel);

            _categoryPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor= Color.White,
                AutoScroll = true
            };
            PN3.Controls.Add(_categoryPanel);

            _brandPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                AutoScroll = true
            };
            PN2.Controls.Add(_brandPanel);

            Button refreshButton = new Button
            {
                Text = "Refresh Products",
                Dock = DockStyle.Top
            };
            refreshButton.Click += async (sender, e) => await LoadProducts();
            PN1.Controls.Add(refreshButton);

            Button refreshButton1 = new Button
            {
                Text = "Refresh Categorys",
                Dock = DockStyle.Top
            };
            refreshButton.Click += async (sender, e) => await LoadCategorys();
            PN3.Controls.Add(refreshButton1);

            Button refreshButton2 = new Button
            {
                Text = "Refresh Categorys",
                Dock = DockStyle.Top
            };
            refreshButton.Click += async (sender, e) => await LoadCategorys();
            PN2.Controls.Add(refreshButton2);
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadProducts();
            await LoadCategorys();
            await LoadBrands();
        }

        private async Task LoadProducts()
        {
            try
            {
                _productPanel.Controls.Clear();
                var products = await _connection.GetProductsAsync();
                foreach (var product in products)
                {
                    AddProductToPanel(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        ///////////////////////////////////////////////////// cate
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

        private async Task LoadBrands()
        {
            try
            {
                _brandPanel.Controls.Clear();
                var brands = await _connection.GetBrand();
                foreach (var brand in brands)
                {
                    AddBrandToPanel(brand);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void AddBrandToPanel(Brand brand)
        {
            PictureBox pictureBox = new PictureBox
            {
                Width = 100,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = LoadImage(brand.Image) ?? null,
                Margin = new Padding(5)
            };

            Label nameLabel = new Label
            {
                Text = brand.Name,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 100
            };

            Panel brandPanel = new Panel
            {
                Width = 110,
                Height = 130
            };
            brandPanel.Controls.Add(pictureBox);
            brandPanel.Controls.Add(nameLabel);
            nameLabel.Location = new System.Drawing.Point(0, 105);

            _brandPanel.Controls.Add(brandPanel);
        }

        private void AddCategoryToPanel(Category category)
        {
            PictureBox pictureBox = new PictureBox
            {
                Width = 100,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = LoadImage(category.Image) ?? null,
                Margin = new Padding(5)
            };

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
        /////////////////////////////

        private void AddProductToPanel(Product product)
        {
            PictureBox pictureBox = new PictureBox
            {
                Width = 100,
                Height = 100,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = LoadImage(product.Image) ?? null,
                Margin = new Padding(5)
            };

            Label nameLabel = new Label
            {
                Text = product.Name,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 100
            };

            Panel productPanel = new Panel
            {
                Width = 110,
                Height = 130
            };
            productPanel.Controls.Add(pictureBox);
            productPanel.Controls.Add(nameLabel);
            nameLabel.Location = new System.Drawing.Point(0, 105);

            _productPanel.Controls.Add(productPanel);
        }

        private Image LoadImage(string imagePath)
        {
            try
            {
                if (File.Exists(imagePath))
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
            return null;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _connection.Dispose();
        }
    }

    public class Neo4jConnection : IDisposable
    {
        private readonly IDriver _driver;

        public Neo4jConnection(string uri, string user, string password)
        {
            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
        }

        // lấy toàn bộ sp
        public async Task<List<Product>> GetProductsAsync()
        {
            await using var session = _driver.AsyncSession();
            return await session.ReadTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync("MATCH (p:Product) RETURN p.name AS name, p.image AS image");
                var products = new List<Product>();
                await foreach (var record in result)
                {
                    string name = record["name"].As<string>();
                    string image = record["image"].As<string>();
                    products.Add(new Product(name, image));
                }
                return products;
            });
        }
        //lấy toàn bộ category
        public async Task<List<Category>> GetCategory()
        {
            await using var session = _driver.AsyncSession();
            return await session.ReadTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync("MATCH (c:Category) RETURN c.name AS name, c.image AS image");
                var categorys = new List<Category>();
                await foreach (var record in result)
                {
                    string name = record["name"].As<string>();
                    string image = record["image"].As<string>();
                    categorys.Add(new Category(name, image));
                }
                return categorys;
            });
        }
        //lấy toàn bộ brand
        public async Task<List<Brand>> GetBrand()
        {
            await using var session = _driver.AsyncSession();
            return await session.ReadTransactionAsync(async tx =>
            {
                var result = await tx.RunAsync("MATCH (b:Brand) RETURN b.name AS name, b.image AS image");
                var brands = new List<Brand>();
                await foreach (var record in result)
                {
                    string name = record["name"].As<string>();
                    string image = record["image"].As<string>();
                    brands.Add(new Brand(name, image));
                }
                return brands;
            });
        }
        public void Dispose()
        {
            _driver?.Dispose();
        }
    }

    public class Product
    {
        //public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName; // đường dẫn đến mục sản phẩm cách 1 (lấy từ thư mục bin)
        public string projectDirectory = GetSiblingDirectory("SP"); // đường dẫn đến mục sản phẩm (lấy từ chính thư mục SP trong project)
        public string Name { get; }
        public string Image { get; }
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

        // xoá dấu nháy
        public string RemoveQuotes(string input)
        {
            return input.Replace("\"", "").Replace("'", "");
        }
        public Product(string name, string image)
        {
            Name = name;
            //Image = projectDirectory + "\\SP\\"+ RemoveQuotes(image); //cách 1
            Image = projectDirectory+"\\"+RemoveQuotes(image); // cách 2
        }
    }

    public class Category
    {
        public string Name { get; }
        public string Image { get; }
        public string projectDirectory = GetSiblingDirectory("ImageApp");
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

        public string RemoveQuotes(string input)
        {
            return input.Replace("\"", "").Replace("'", "");
        }

        public Category(string name, string image)
        {
            Name = name;
            Image = projectDirectory + "\\" + RemoveQuotes(image);
        }
    }

    public class Brand
    {
        public string Name { get; }
        public string Image { get; }
        public string projectDirectory = GetSiblingDirectory("ImageApp");
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

        public string RemoveQuotes(string input)
        {
            return input.Replace("\"", "").Replace("'", "");
        }

        public Brand(string name, string image)
        {
            Name = name;
            Image = projectDirectory + "\\" + RemoveQuotes(image);
        }
    }
}
