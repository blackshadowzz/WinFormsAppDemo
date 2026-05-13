
using WinFormsAppDemo.Forms.Lists.Categories;
using WinFormsAppDemo.Forms.Lists.Products;

namespace WinFormsAppDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductListForm form = new ProductListForm();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }
    }
}
