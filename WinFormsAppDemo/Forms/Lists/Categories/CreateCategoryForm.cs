using WinFormsAppDemo.Models;
using WinFormsAppDemo.Services;

namespace WinFormsAppDemo.Forms.Lists.Categories
{
    public partial class CreateCategoryForm : Form
    {
        public CreateCategoryForm()
        {
            InitializeComponent();
        }
        public CommandOptions ActionStatus;
        private readonly CategoryService categoryService = new CategoryService();
        private void CreateCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.Description = richTextBoxDesc.Text;
            category.IsActive = checkBoxIsActive.Checked;

            try
            {
                var Id = categoryService.CreateCategory(category);
                if (Id > 0)
                {
                    MessageBox.Show("Category created succeed");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                    MessageBox.Show("Creating failed");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
