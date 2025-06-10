using MaterialSkin;
using MaterialSkin.Controls;
using POS.Controller;
using POS.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace POS.Boundary
{
    public partial class MenuManagerBoundary : MaterialForm
    {
        private MenuCreateController menuCreateController = new MenuCreateController();
        private MenuEditController menuEditController = new MenuEditController();
        private MenuLoadController menuLoadController = new MenuLoadController();
        private MenuRemoveController menuRemoveController = new MenuRemoveController();
        private CategoryController categoryController = new CategoryController();
        private List<MenuEntity> menuList;
        private List<CategoryEntity> categoryList;
        private int? selectedMenuId = null;
        private TableViewBoundary tableViewBoundary; // 테이블 뷰 바운더리 참조
        private byte[]? selectedImageBytes = null;

        public MenuManagerBoundary(TableViewBoundary tableViewBoundary)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            InitializeDataGridView();
            this.tableViewBoundary = tableViewBoundary; // 테이블 뷰 바운더리 참조 저장
        }

        private void InitializeDataGridView()
        {
            dataGridViewMenus.Columns.Clear(); // 기존 컬럼 제거
            dataGridViewMenus.AutoGenerateColumns = false;
            dataGridViewMenus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMenus.MultiSelect = false;
            dataGridViewMenus.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 메뉴 ID
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.HeaderText = "ID";
            idColumn.DataPropertyName = "Id";
            idColumn.Name = "Id";
            idColumn.Width = 50;
            dataGridViewMenus.Columns.Add(idColumn);

            // 메뉴명
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "메뉴명";
            nameColumn.DataPropertyName = "MenuName";
            nameColumn.Width = 150;
            dataGridViewMenus.Columns.Add(nameColumn);

            // 가격
            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.HeaderText = "가격";
            priceColumn.DataPropertyName = "MenuPrice";
            priceColumn.DefaultCellStyle.Format = "N0"; // 1000단위 쉼표, 소수점 없음
            priceColumn.Width = 100;
            dataGridViewMenus.Columns.Add(priceColumn);

            LoadAllMenus(); // 초기 로딩
        }

        private void LoadAllMenus()
        {
            menuList = menuLoadController.MenuLoad();
            LoadAllCategories();
            RefreshMenuList();
        }

        public void LoadAllCategories()
        {
            categoryList = categoryController.GetAllCategory();
            comboBoxCategory.DisplayMember = "CategoryName"; // 보여줄 속성
            comboBoxCategory.ValueMember = "Id";             // 내부 값으로 쓸 속성
            comboBoxCategory.DataSource = categoryList;      // CategoryEntity 리스트
        }

        private void RefreshMenuList()
        {
            dataGridViewMenus.DataSource = null;
            dataGridViewMenus.DataSource = menuList;
        }

        private void menuCreateButton_Click(object sender, EventArgs e)
        {
            string name = menuNameTextBox.Text.Trim();
            string priceText = menuPriceTextBox.Text.Trim();

            // 유효성 검사
            if (string.IsNullOrWhiteSpace(name) || !int.TryParse(priceText, out int price))
            {
                MessageBox.Show("올바른 메뉴명과 가격을 입력하세요.");
                return;
            }

            // 중복 검사
            if (menuCreateController.IsDuplicated(menuList, name))
            {
                MessageBox.Show("이미 존재하는 메뉴입니다.");
                return;
            }

            // 카테고리 선택 확인
            if (comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("카테고리를 선택하세요.");
                return;
            }

            int categoryId = (int)comboBoxCategory.SelectedValue;

            // DB에 저장 (카테고리 ID 포함)
            menuCreateController.MenuCreate(name, price, categoryId, selectedImageBytes);
            LoadAllMenus();
            MessageBox.Show("메뉴가 추가되었습니다.");
        }

        private void menuDeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 메뉴를 선택하세요.");
                return;
            }

            var value = dataGridViewMenus.SelectedRows[0].Cells["Id"].Value;

            if (value == null || !int.TryParse(value.ToString(), out int id))
            {
                MessageBox.Show("유효한 ID를 찾을 수 없습니다.");
                return;
            }

            var selectedMenu = menuList.FirstOrDefault(m => m.Id == id);
            if (selectedMenu == null)
            {
                MessageBox.Show("메뉴를 찾을 수 없습니다.");
                return;
            }

            try
            {
                menuRemoveController.MenuRemove(selectedMenu);
                MessageBox.Show("메뉴가 삭제되었습니다.");
                LoadAllMenus();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "삭제 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            selectedMenuId = null;
        }

        private void menuEditButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0)
            {
                MessageBox.Show("수정할 메뉴를 선택하세요.");
                return;
            }

            var value = dataGridViewMenus.SelectedRows[0].Cells["Id"].Value;
            if (value == null || !int.TryParse(value.ToString(), out int id))
            {
                MessageBox.Show("유효한 ID를 찾을 수 없습니다.");
                return;
            }

            var selectedMenu = menuList.FirstOrDefault(c => c.Id == id);
            if (selectedMenu == null)
            {
                MessageBox.Show("메뉴를 찾을 수 없습니다.");
                return;
            }

            // 새로운 입력값
            string newName = menuNameTextBox.Text.Trim();
            string newPriceText = menuPriceTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newName) || !int.TryParse(newPriceText, out int newPrice))
            {
                MessageBox.Show("올바른 메뉴명과 가격을 입력하세요.");
                return;
            }

            if (comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("카테고리를 선택하세요.");
                return;
            }

            int newCategoryId = (int)comboBoxCategory.SelectedValue;

            // 실제 변경 여부 확인
            bool isChanged =
                selectedMenu.MenuName != newName ||
                selectedMenu.MenuPrice != newPrice ||
                selectedMenu.CategoryId != newCategoryId ||
                selectedImageBytes != null;

            if (!isChanged)
            {
                MessageBox.Show("변경된 내용이 없습니다.");
                return;
            }

            // 중복 검사 (자기 자신은 제외)
            if (menuCreateController.IsDuplicated(menuList, newName, selectedMenu.Id))
            {
                MessageBox.Show("이미 존재하는 메뉴입니다.");
                return;
            }

            // 이미지 변경 시 반영
            if (selectedImageBytes != null)
            {
                selectedMenu.MenuImage = selectedImageBytes;
            }

            // 실제 수정
            selectedMenu.MenuName = newName;
            selectedMenu.MenuPrice = newPrice;
            selectedMenu.CategoryId = newCategoryId;

            // DB에 반영
            menuEditController.MenuEdit(selectedMenu);

            LoadAllMenus();
            MessageBox.Show("메뉴가 수정되었습니다.");

        }

        private void dataGridViewMenus_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0) return;

            var row = dataGridViewMenus.SelectedRows[0];
            selectedMenuId = (int)row.Cells["Id"].Value;
            menuIdTextBox.Text = selectedMenuId.ToString();

            var selectedMenu = menuList.FirstOrDefault(m => m.Id == selectedMenuId);
            if (selectedMenu != null)
            {
                menuNameTextBox.Text = selectedMenu.MenuName;
                menuPriceTextBox.Text = selectedMenu.MenuPrice.ToString();

                // ComboBox에서 해당 카테고리를 선택
                comboBoxCategory.SelectedValue = selectedMenu.CategoryId;
                comboBoxCategory.Refresh(); // UI 강제 갱신
            }

            if (selectedMenu.MenuImage != null)
            {
                using (var ms = new MemoryStream(selectedMenu.MenuImage))
                {
                    var newImage = Image.FromStream(ms);
                    pictureBoxPreview.Image = null; // 이전 이미지 클리어 (중복 방지)
                    pictureBoxPreview.Image = newImage;
                    pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxPreview.Refresh(); // 강제 다시 그리기
                }
            }
            else
            {
                pictureBoxPreview.Image = null;
                pictureBoxPreview.Refresh();
            }
        }

        private void CategoryManageButton_Click(object sender, EventArgs e)
        {
            MaterialForm categoryManagerForm = new CategoryManagerBoundary(this);
            categoryManagerForm.ShowDialog();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedValue != null)
            {
                int selectedCategoryId = (int)comboBoxCategory.SelectedValue;
                Console.WriteLine($"선택된 카테고리 ID: {selectedCategoryId}");
            }
        }
        private void menuResetButton_Click(object sender, EventArgs e)
        {
            menuIdTextBox.Text = string.Empty;
            menuNameTextBox.Text = string.Empty;
            menuPriceTextBox.Text = string.Empty;

            if (comboBoxCategory.Items.Count > 0)
            {
                comboBoxCategory.SelectedIndex = -1;
                comboBoxCategory.Refresh(); // UI 강제 갱신
            }

            pictureBoxPreview.Image = null;
            pictureBoxPreview.Refresh();

            dataGridViewMenus.ClearSelection();
            selectedMenuId = null;
        }

        private void MenuManagerBoundary_FormClosing(object sender, FormClosingEventArgs e)
        {
            tableViewBoundary.LoadTables(); // 테이블 뷰 바운더리의 테이블 목록 새로고침
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "이미지 선택";
                ofd.Filter = "이미지 파일|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    var original = Image.FromFile(filePath);

                    var resized = ResizeImage(original, 800, 800); // 최대 800x800
                    selectedImageBytes = ImageToByteArray(resized); // 여기가 DB에 들어갈 BLOB

                    pictureBoxPreview.Image = resized; // 미리보기
                }
            }
        }

        public static Image ResizeImage(Image original, int maxWidth, int maxHeight)
        {
            int width = original.Width;
            int height = original.Height;

            float scale = Math.Min((float)maxWidth / width, (float)maxHeight / height);

            int newWidth = (int)(width * scale);
            int newHeight = (int)(height * scale);

            var resized = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(resized))
            {
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                graphics.DrawImage(original, 0, 0, newWidth, newHeight);
            }

            return resized;
        }

        public static byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // PNG도 가능
                return ms.ToArray();
            }
        }
    }
}
