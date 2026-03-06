using WinFormsAppDemo.Models;
using WinFormsAppDemo.Services;

namespace WinFormsAppDemo.Forms.Lists.Categories
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryService categoryService = new CategoryService();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GetCategories();
        }
        protected void GetCategories()
        {
            var cates = categoryService.GetCategories();
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

            var product = (Category)dataGridView1.CurrentRow.DataBoundItem!;
            MessageBox.Show("Id: " + product.Id);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
