using NORTHWND.Business.Abstract;

namespace NORTHWND.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IProductService _productService;
        ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}