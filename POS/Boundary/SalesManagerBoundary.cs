using POS.Entity;

namespace SalesManagement
{
    public partial class SalesManagerBoundary : Form
    {
        private List<SalesEntity> salesList;
        public SalesManagerBoundary()
        {
            InitializeComponent();
        }
        private void salesSearchButton_Click(object sender, EventArgs e)
        {
            LoadSalesToGridView();
        }

        private void LoadSalesToGridView()
        {
            
        }
    }
}
