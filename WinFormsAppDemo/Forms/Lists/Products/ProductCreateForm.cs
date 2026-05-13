using WinFormsAppDemo.Models;
using WinFormsAppDemo.Services;

namespace WinFormsAppDemo.Forms.Lists.Products
{
    public partial class ProductCreateForm : Form
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        public ProductCreateForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();
        }

        private void ProductCreateForm_Load(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Clear();
            comboBoxCategory.DataSource = _categoryService.GetCategories();
            comboBoxCategory.ValueMember = "Id";
            comboBoxCategory.DisplayMember = "CategoryName";
        }
        void ClearData()
        {
            txtDescription.Clear();
            numericUpDownPrice.Value = 0;
            numericUpDownQty.Value = 0;
            txtProductName.Clear();
            comboBoxCategory.SelectedItem = null;
            txtProductName.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.ProductName = txtProductName.Text;
            product.CategoryId = (int)comboBoxCategory.SelectedValue!;
            product.Price = numericUpDownPrice.Value;
            product.StockQty = (int)numericUpDownQty.Value;
            product.Description = txtDescription.Text;
            product.IsActive = checkBoxIsActive.Checked;
            product.CreatedDate = DateTime.Now;
            product.ModifiedDate = DateTime.Now;

            if (string.IsNullOrEmpty(product.ProductName) && string.IsNullOrEmpty(product.CategoryId.ToString()))
            {
                MessageBox.Show("Product Name & Category are required");
                return;
            }
            try
            {
                var rowId = _productService.CreateProduct(product);
                if (rowId > 0)
                {
                    MessageBox.Show("Product created succeed!");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }
    }
}
