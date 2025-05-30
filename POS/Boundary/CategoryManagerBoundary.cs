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
            LoadAllCategories();
            dataGridView_Initalize();
        }

        public void dataGridView_Initalize()
        {
            dataGridView1.AutoGenerateColumns = false;  // 수동 컬럼 설정

            // 예: 카테고리 ID
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",        // CategoryEntity의 속성명
                HeaderText = "ID",
                Name = "colId"
            });

            // 예: 카테고리 이름
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",      // CategoryEntity의 속성명
                HeaderText = "Category Name",
                Name = "colName"
            });

            // 예: 설명(옵션)
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Name = "colDescription"
            });

            // 그 외 스타일 설정 (선택)
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }


        private void categoryCreateButton_Click(object sender, EventArgs e)
        {
            categoryController.createCategory();
        }

        private void categoryRemoveButton_Click(object sender, EventArgs e)
        {
            categoryController.deleteCategory();
        }

        private void categoryUpdateButton_Click(object sender, EventArgs e)
        {
            categoryController.editCategory();
        }


        public void LoadAllCategories()
        {
            categoryList = categoryController.GetAllCategory();
        }
        

    }
}
