using System.ComponentModel;
using WinFormsAppDemo.Models;
using WinFormsAppDemo.Services;

namespace WinFormsAppDemo.Forms.Lists.Categories
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryService categoryService = new CategoryService();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Id { get; set; }
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GetCategories();
        }
        protected void GetCategories(string? q = "")
        {
            var cates = categoryService.GetCategories(q);
            dataGridView1.DataSource = cates;

            dataGridView1.AutoGenerateColumns = true;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CreateCategoryForm form = new CreateCategoryForm();
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.WindowsDefaultLocation;
            form.ActionStatus = CommandOptions.Create;
            if (form.ShowDialog() == DialogResult.OK)
            {
                GetCategories();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            var category = (Category)dataGridView1.CurrentRow.DataBoundItem!;
            var cate = categoryService.GetCategory(category.Id);
            Id = cate.Id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            UpdateCategoryForm form = new UpdateCategoryForm();
            form.WindowState = FormWindowState.Normal;
            form.StartPosition = FormStartPosition.WindowsDefaultLocation;
            form.Id = Id;
            form.ActionStatus = CommandOptions.Update;
            if (form.ShowDialog() == DialogResult.OK)
            {
                GetCategories();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var delete = MessageBox.Show(
                "Delete category?",
                "Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes;
            try
            {
                if (delete)
                {
                    var result = categoryService.DeleteCategory(Id);
                    if (result)
                    {
                        GetCategories();
                        MessageBox.Show("Category deleted succeed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var filter = txtSearch.Text;
            GetCategories(filter);
        }
    }
}
