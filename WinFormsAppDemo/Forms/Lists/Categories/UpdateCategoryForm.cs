using System.ComponentModel;
using WinFormsAppDemo.Models;
using WinFormsAppDemo.Services;

namespace WinFormsAppDemo.Forms.Lists.Categories
{
    public partial class UpdateCategoryForm : Form
    {
        public UpdateCategoryForm()
        {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { get; set; }
        public CommandOptions ActionStatus;
        private Category category = new();
        private readonly CategoryService categoryService = new CategoryService();
        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                category = categoryService.GetCategory(Id);
                txtCategoryName.Text = category.CategoryName;
                richTextBoxDesc.Text = category.Description;
                checkBoxIsActive.Checked = category.IsActive;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            category.CategoryName = txtCategoryName.Text;
            category.Description = richTextBoxDesc.Text;
            category.IsActive = checkBoxIsActive.Checked;

            try
            {
                var result = categoryService.UpdateCategory(category);
                if (result)
                {
                    MessageBox.Show("Category updated succeed");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
                else
                    MessageBox.Show("Updating failed");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
