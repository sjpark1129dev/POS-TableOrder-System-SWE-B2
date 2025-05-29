using MaterialSkin.Controls;
namespace POS.Boundary
{
    public partial class TableViewBoundary : MaterialForm
    {
        public TableViewBoundary()
        {
            InitializeComponent();

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TableManagerButton2_Click(object sender, EventArgs e)
        {
            TableManagerBoundary tableManagerBoundary = new TableManagerBoundary();
            tableManagerBoundary.Show();
        }

        private void MenuManagerButton2_Click(object sender, EventArgs e)
        {
            MenuManagerBoundary menuManagerBoundary = new MenuManagerBoundary();
            menuManagerBoundary.Show();
        }

        private void SalesManagerButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
