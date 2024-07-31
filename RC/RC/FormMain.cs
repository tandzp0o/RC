using Neo4j.Driver;

namespace RC
{
    public partial class FormMain : Form
    {
        public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName; // đường dẫn đến mục sản phẩm
        private FlowLayoutPanel _productPanel;
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
                AutoScroll = true
            };
            this.Controls.Add(_productPanel);

            Button refreshButton = new Button
            {
                Text = "Refresh Products",
                Dock = DockStyle.Top
            };
            refreshButton.Click += async (sender, e) => await LoadProducts();
            this.Controls.Add(refreshButton);
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadProducts();
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
                MessageBox.Show("lấy được sản phẩm");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

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

        public void Dispose()
        {
            _driver?.Dispose();
        }
    }

    public class Product
    {
        public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName; // đường dẫn đến mục sản phẩm
        public string Name { get; }
        public String Image { get; }

        public Product(string name, string image)
        {
            Name = name;
            Image = projectDirectory + "\\SP\\"+image;
        }
    }
}
