using System;
using System.Windows.Forms;

namespace TheNeo_POS_System
{
    public partial class Category_Page : UserControl
    {
        DBConnection dBConnection = new DBConnection();
        public Category_Page()
        {
            InitializeComponent();
            dBConnection.OpenConection();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string categoryid = txt_CategoryID.Text;
            string categoryname = txt_CategoryName.Text;
            string categorydescription = txt_CategoryDescription.Text;

            if (!categoryid.Equals("") && !categoryname.Equals("") || !categorydescription.Equals(""))
            {
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }
    }
}
