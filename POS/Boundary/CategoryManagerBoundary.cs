using MaterialSkin.Controls;
using POS.Controller;
using POS.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace POS.Boundary
{
    public partial class CategoryManagerBoundary : MaterialForm
    {
        private List<CategoryEntity> categoryList;
        private CategoryController categoryController;

        public CategoryManagerBoundary()
        {
            InitializeComponent();
            categoryController = new CategoryController(); // 누락 방지용
            LoadAllCategories();
            materialListView_Initialize();
        }

        public void materialListView_Initialize()
        {
            materialListView1.View = View.Details;
            materialListView1.FullRowSelect = true;
            materialListView1.GridLines = true;

            // 컬럼 추가
            materialListView1.Columns.Add("ID", 100);
            materialListView1.Columns.Add("CategoryName", 150);

            RefreshMaterialListView();
        }

        private void RefreshMaterialListView()
        {
            materialListView1.Items.Clear();

            foreach (var category in categoryList)
            {
                var item = new ListViewItem(category.Id.ToString());
                item.SubItems.Add(category.CategoryName);
                materialListView1.Items.Add(item);
            }
        }

        private void categoryCreateButton_Click(object sender, EventArgs e)
        {
            categoryController.createCategory(categoryNameTextBox.Text);
            LoadAllCategories();
            RefreshMaterialListView();
        }

        private void categoryRemoveButton_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }

            int selectedId = int.Parse(materialListView1.SelectedItems[0].SubItems[0].Text);  // ID 읽기
            var selectedCategory = categoryList.FirstOrDefault(c => c.Id == selectedId); // 💡 여기에 바로 넣음

            if (selectedCategory == null)
            {
                MessageBox.Show("해당 항목을 찾을 수 없습니다.");
                return;
            }

            categoryController.deleteCategory(selectedCategory);
            LoadAllCategories();
            RefreshMaterialListView();
        }

        private void categoryUpdateButton_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("수정할 항목을 선택하세요.");
                return;
            }

            int selectedId = int.Parse(materialListView1.SelectedItems[0].SubItems[0].Text);
            var selectedCategory = categoryList.FirstOrDefault(c => c.Id == selectedId);

            if (selectedCategory == null)
            {
                MessageBox.Show("해당 항목을 찾을 수 없습니다.");
                return;
            }

            selectedCategory.CategoryName = categoryNameTextBox.Text;

            categoryController.editCategory(selectedCategory);
            LoadAllCategories();
            RefreshMaterialListView();
        }

        public void LoadAllCategories()
        {
            categoryList = categoryController.GetAllCategory();
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                var selected = materialListView1.SelectedItems[0];
                categoryIDtxt.Text = selected.SubItems[0].Text;
                categoryNameTextBox.Text = selected.SubItems[1].Text;
            }
        }

        private void selectResetButton_Click(object sender, EventArgs e)
        {
            categoryIDtxt.Text = "";
            categoryNameTextBox.Text = "";
        }

        private void CategoryManagerBoundary_Load(object sender, EventArgs e)
        {

        }
    }
}
