using POS.Repostiory;
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
using POS.Entity;

namespace POS
{
    public partial class TableManagerBoundary : Form
    {
        private TableController tableController = new TableController();
        private List<TableEntity> tableList;
        private int? selectedTableId = null;  // 선택된 테이블 ID 보관 (nullable int)
        public TableManagerBoundary()
        {
            InitializeComponent();
            tableList = tableController.GetAllTables();
        }

        private void LoadTablesToPanel()
        {
            //tableLayoutPanel1.Controls.Clear(); // 기존 버튼들 제거

            //var tableList = tableController.GetAllTables(); // 테이블 목록 조회

            //foreach (var table in tableList)
            //{
            //    var btn = new Button();
            //    btn.Text = $"테이블 {table.Id}";
            //    btn.Tag = table.Id; // ID 저장
            //    btn.Width = 100;
            //    btn.Height = 60;
            //    btn.Margin = new Padding(10);
            //    btn.BackColor = SystemColors.Control;
            //    btn.Click += TableButton_Click;

            //    tableLayoutPanel1.Controls.Add(btn);
            //}
        }

        private void tableCreateButton_Click(object sender, EventArgs e)
        {
            TableEntity newTable = tableController.CreateTable();
            tableList.Add(newTable); // 새 테이블 추가
        }

        private void tableDeleteButton_Click(object sender, EventArgs e)
        {
            // 테이블 ID 받아오는 로직 추가 필요
            // tableController.DeleteTable(selectedTableId.Value);
        }

        private void tableSaveButton_Click(object sender, EventArgs e)
        {
            // 테이블 전체 저장 로직 필요
            // 테이블 엔티디에 상태 정보 저장 필요
            tableController.SaveAllTables(tableList); // 지시만 함
            MessageBox.Show("저장 완료");
        }
    }
}
