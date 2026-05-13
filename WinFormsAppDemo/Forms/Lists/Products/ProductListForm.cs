using WinFormsAppDemo.Models;
using WinFormsAppDemo.Services;

namespace WinFormsAppDemo.Forms.Lists.Products
{
    public partial class ProductListForm : Form
    {
        private readonly ProductService _productService;
        public ProductListForm()
        {
            _productService = new ProductService();
            InitializeComponent();
        }

        private void GetProducts(string? filter = "")
        {
            var products = _productService.GetProducts(filter);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "imageUrlDataGridViewTextBoxColumn"; // Give it a unique name
            imageColumn.HeaderText = "Image";
            imageColumn.DataPropertyName = "ImageUrl"; // This binds to your Product.ImageUrl property
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Adjust image to fit cell
            imageColumn.Width = 100; // Set a desired width for the image column
            if (!dataGridViewProducts.Columns.Contains(imageColumn))
            {
                dataGridViewProducts.Columns.Add(imageColumn);
            }

            dataGridViewProducts.DataSource = products;
            dataGridViewProducts.AutoGenerateColumns = true;
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            GetProducts();
        }

        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            ProductCreateForm form = new ProductCreateForm();
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.WindowsDefaultLocation;
            //form.ac = CommandOptions.Create;
            if (form.ShowDialog() == DialogResult.OK)
            {
                GetProducts();
            }
        }
        private int ProductId { get; set; }
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null) return;

            var result = (Product)dataGridViewProducts.CurrentRow.DataBoundItem!;
            var pro = _productService.GetProduct(result.ProductId);
            ProductId = pro.ProductId;
            //MessageBox.Show(pro.ProductName);
        }

        private void toolStripButtonDetails_Click(object sender, EventArgs e)
        {
            ProductDetailsForm form = new ProductDetailsForm();
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.WindowsDefaultLocation;
            form.ProductId = ProductId;
            if (form.ShowDialog() == DialogResult.OK)
            {
                GetProducts();
            }
        }

        private void dataGridViewProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewProducts.Columns[e.ColumnIndex].Name == "imageUrlDataGridViewTextBoxColumn" && e.Value != null)
            {
                string imagePath = e.Value.ToString()!;
                if (!string.IsNullOrEmpty(imagePath))
                {
                    try
                    {
                        Image img = Image.FromFile(imagePath);
                        e.Value = img; // Assign the loaded image to the cell
                        e.FormattingApplied = true; // Indicate that we've handled the formatting
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error loading image from {imagePath}: {ex.Message}");
                        e.Value = null; // Clear the cell or set a placeholder image
                        e.FormattingApplied = true;
                    }
                }
                else
                {
                    e.Value = null;
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
