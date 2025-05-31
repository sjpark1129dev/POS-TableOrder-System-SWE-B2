using MaterialSkin;
using MaterialSkin.Controls;
namespace POS.Boundary
{
    public partial class TableViewBoundary : MaterialForm
    {
        public TableViewBoundary()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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
