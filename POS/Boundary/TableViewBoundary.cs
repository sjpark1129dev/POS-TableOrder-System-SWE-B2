using POS.Boundary;

namespace POS
{
    public partial class TableViewBoundary : Form
    {
        public TableViewBoundary()
        {
            InitializeComponent();
        }

        private void TableManagerButton_Click(object sender, EventArgs e)
        {
            TableManagerBoundary tableManagerBoundary = new TableManagerBoundary();
            tableManagerBoundary.Show();
        }

        private void MenuManagerButton_Click(object sender, EventArgs e)
        {
            MenuManagerBoundary menuManagerBoundary = new MenuManagerBoundary();
            menuManagerBoundary.Show();
        }
    }
}
