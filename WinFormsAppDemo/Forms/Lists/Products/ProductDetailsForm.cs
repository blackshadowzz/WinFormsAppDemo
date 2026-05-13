using System.ComponentModel;
using WinFormsAppDemo.Services;

namespace WinFormsAppDemo.Forms.Lists.Products
{
    public partial class ProductDetailsForm : Form
    {
        private readonly ProductService _productService = new ProductService();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ProductId { get; set; }
        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        private void GetProduct()
        {
            var pro = _productService.GetProduct(ProductId);
            txtProductName.Text = pro.ProductName;
            txtDescription.Text = pro.Description;
            numericUpDownPrice.Value = pro.Price ?? 0;
            numericUpDownQty.Value = pro.StockQty ?? 0;
            if (string.IsNullOrEmpty(pro.ImageUrl) || !File.Exists(pro.ImageUrl))
            {
                pictureBoxProduct.Image = null;
            }
            else
                pictureBoxProduct.Image = Image.FromFile(pro.ImageUrl!);
            checkBoxIsActive.Checked = pro.IsActive;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            GetProduct();
        }
    }
}
