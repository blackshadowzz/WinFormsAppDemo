
using WinFormsAppDemo.Forms.Lists.Categories;

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
    }
}
