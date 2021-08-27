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
                    string SQLQuery = "INSERT INTO [POSSTheNeoMobile].[dbo].[TB.Category] (C_ID,C_Name,C_Description) VALUES ('"+ categoryid + "','"+ categoryname + "','"+ categorydescription + "');";
                    dBConnection.ExecuteQueries(SQLQuery);
                    dBConnection.CloseConnection();
                    ClearInputData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                const string message = "Insert Fail..! Please enter the data..";
                const string caption = "Data Insert Information..";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // If the no button was pressed ...
                if (result == DialogResult.OK)
                {

                }
            }
        }

        private void ClearInputData()
        {
            txt_CategoryID.Text = "";
            txt_CategoryName.Text = "";
            txt_CategoryDescription.Text = "";
        }
    }
}
