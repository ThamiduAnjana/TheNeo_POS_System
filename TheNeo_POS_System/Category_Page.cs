using System;
using System.Windows.Forms;

namespace TheNeo_POS_System
{
    public partial class Category_Page : UserControl
    {
        DBConnection dBConnection = new DBConnection();
        string LastCategoryID;
        public Category_Page()
        {
            InitializeComponent();
            dBConnection.OpenConection();
            GetLastCategoryIDAndCal();
            CategoryDataGridViewDisplay();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string categoryid = txt_CategoryID.Text;
            string categoryname = txt_CategoryName.Text;
            string categorydescription = txt_CategoryDescription.Text;

            if (!categoryid.Equals("") && !categoryname.Equals("") || !categorydescription.Equals(""))
            {
                if (!categoryid.Equals(CheckCategoryID(categoryid)))
                {
                    //dBConnection.CloseDataReader();
                    try
                    {
                        string SQLQuery = "INSERT INTO [POSSTheNeoMobile].[dbo].[TB.Category] (C_ID,C_Name,C_Description) VALUES ('" + categoryid + "','" + categoryname + "','" + categorydescription + "');";
                        dBConnection.ExecuteQueries(SQLQuery);

                        const string message = "Insert Successfull..!";
                        const string caption = "Data Insert Information..";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // If the no button was pressed ...
                        if (result == DialogResult.OK)
                        {

                        }
                        ClearInputData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    const string message = "Category ID : [ {0} ] is exist in the database.! Please change the Category ID..!";
                    const string caption = "Data Insert Information..";
                    var result = MessageBox.Show(string.Format(message, categoryid), caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // If the no button was pressed ...
                    if (result == DialogResult.OK)
                    {

                    }
                    ClearInputData();
                }
            }
            else
            {
                const string message = "Insert Fail..! Please enter the valid data..";
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
            dBConnection.CloseDataReader();
            GetLastCategoryIDAndCal();
            CategoryDataGridViewDisplay();
            txt_CategoryName.Text = "";
            txt_CategoryDescription.Text = "";
        }

        private void GetLastCategoryIDAndCal()
        {
            try
            {
                string SQLQuery = "SELECT * FROM [POSSTheNeoMobile].[dbo].[TB.Category] ORDER BY C_ID DESC";
                if (dBConnection.DataReader(SQLQuery).Read())
                {
                    string ID = dBConnection.dr["C_ID"].ToString();
                    char[] seperator = {'_' };
                    string[] strarr = null;
                    strarr = ID.Split(seperator);

                    int index = int.Parse(strarr[1]);
                    int val = index + 1;
                    txt_CategoryID.Text = ("C_" + val.ToString());
                    dBConnection.CloseDataReader();
                }
                else
                {
                    txt_CategoryID.Text = "C_1"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string CheckCategoryID(string categoryid)
        {
            try
            {
                string SQLQuery = "SELECT * FROM [POSSTheNeoMobile].[dbo].[TB.Category] WHERE C_ID = '"+ categoryid+"';";
                if (dBConnection.DataReader(SQLQuery).Read())
                {
                    LastCategoryID = dBConnection.dr["C_ID"].ToString();
                    dBConnection.CloseDataReader();
                }
                else
                {
                    LastCategoryID = "C_1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return LastCategoryID;
        }

        private void CategoryDataGridViewDisplay()
        {
            try
            {
                string SQLQuery = "SELECT * FROM [POSSTheNeoMobile].[dbo].[TB.Category]";
                dgv_Category.AutoGenerateColumns = false;
                dgv_Category.DataSource = dBConnection.ShowDataInGridView(SQLQuery);
                dBConnection.CloseDataReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CategoryID.Text = dgv_Category.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_CategoryName.Text = dgv_Category.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_CategoryDescription.Text = dgv_Category.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearInputData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string categoryid = txt_CategoryID.Text;
            string categoryname = txt_CategoryName.Text;
            string categorydescription = txt_CategoryDescription.Text;

            if (!categoryid.Equals("") && !categoryname.Equals("") || !categorydescription.Equals(""))
            {
                if (categoryid.Equals(CheckCategoryID(categoryid)))
                {
                    try
                    {
                        string SQLQuery = "UPDATE [POSSTheNeoMobile].[dbo].[TB.Category] SET C_Name = '" + categoryname + "',C_Description = '" + categorydescription + "' WHERE C_ID = '" + categoryid + "';";
                        dBConnection.ExecuteQueries(SQLQuery);

                        const string message = "Update Successfull..!";
                        const string caption = "Data Update Information..";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // If the no button was pressed ...
                        if (result == DialogResult.OK)
                        {

                        }

                        ClearInputData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    const string message = "Category ID : [ {0} ] is not exist in the database.! Please check the Category ID..!";
                    const string caption = "Data Insert Information..";
                    var result = MessageBox.Show(string.Format(message, categoryid), caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // If the no button was pressed ...
                    if (result == DialogResult.OK)
                    {

                    }
                    ClearInputData();
                }
            }
            else
            {
                const string message = "Update Fail..! Please check your data..";
                const string caption = "Data Update Information..";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // If the no button was pressed ...
                if (result == DialogResult.OK)
                {

                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string categoryid = txt_CategoryID.Text;
            string categoryname = txt_CategoryName.Text;
            string categorydescription = txt_CategoryDescription.Text;

            if (!categoryid.Equals("") && !categoryname.Equals("") || !categorydescription.Equals(""))
            {
                if (categoryid.Equals(CheckCategoryID(categoryid)))
                {
                    try
                    {
                        string SQLQuery = "DELETE FROM [POSSTheNeoMobile].[dbo].[TB.Category] WHERE C_ID = '" + categoryid + "';";
                        dBConnection.ExecuteQueries(SQLQuery);

                        const string message = "Delete Successfull..!";
                        const string caption = "Data Delete Information..";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // If the no button was pressed ...
                        if (result == DialogResult.OK)
                        {

                        }

                        ClearInputData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    const string message = "Category ID : [ {0} ] is not exist in the database.! Please check the Category ID..!";
                    const string caption = "Data Insert Information..";
                    var result = MessageBox.Show(string.Format(message, categoryid), caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // If the no button was pressed ...
                    if (result == DialogResult.OK)
                    {

                    }
                    ClearInputData();
                }
                
            }
            else
            {
                const string message = "Delete Fail..! Please check 'Category ID..'";
                const string caption = "Data Delete Information..";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // If the no button was pressed ...
                if (result == DialogResult.OK)
                {

                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchCategory();
        }

        private void txt_CategoryNameSearch_TextChanged(object sender, EventArgs e)
        {
            SearchCategory();
        }

        private void SearchCategory()
        {
            string SearchCategoryName = txt_CategoryNameSearch.Text;
            try
            {
                string SQLQuery = "SELECT * FROM [POSSTheNeoMobile].[dbo].[TB.Category] WHERE C_Name LIKE '" + SearchCategoryName + "%'";
                dgv_Category.AutoGenerateColumns = false;
                dgv_Category.DataSource = dBConnection.ShowDataInGridView(SQLQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
