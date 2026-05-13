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
            MessageBox.Show(pro.ProductName);
        }
    }
}
