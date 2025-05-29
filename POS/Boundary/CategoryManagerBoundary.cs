using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Controller;
using POS.Domain;

namespace POS.Boundary
{
    public partial class CategoryManagerBoundary : Form
    {
        private List<CategoryEntity> categoryList;
        private CategoryController categoryController;

        public CategoryManagerBoundary()
        {
            InitializeComponent();
        }



        private void categoryCreateButton_Click(object sender, EventArgs e)
        {

        }

        private void categoryRemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void categoryUpdateButton_Click(object sender, EventArgs e)
        {

        }


        public void LoadAllCategories()
        {

        }
        

    }
}
