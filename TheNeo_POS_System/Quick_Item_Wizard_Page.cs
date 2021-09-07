using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeo_POS_System
{
    public partial class Quick_Item_Wizard_Page : UserControl
    {
        DBConnection dBConnection = new DBConnection();
        public Quick_Item_Wizard_Page()
        {
            InitializeComponent();
            dBConnection.OpenConection();
            getCategoryData();
        }

        public void getCategoryData()
        {
            string SQLQuery = "SELECT * FROM [POSSTheNeoMobile].[dbo].[TB.Category]";
            SqlCommand cmd = new SqlCommand(SQLQuery, dBConnection.con);
            SqlDataReader dr;
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_category.Items.Add(dr.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
