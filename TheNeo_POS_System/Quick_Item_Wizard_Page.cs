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
            GetCategoryData();
            GetLastItemIDAndCal();
        }

        public void GetCategoryData()
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
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetLastItemIDAndCal()
        {
            try
            {
                //dBConnection.CloseDataReader();
                string SQLQuery = "SELECT * FROM [POSSTheNeoMobile].[dbo].[TB.ProductInfor] ORDER BY P_ID DESC";
                if (dBConnection.DataReader(SQLQuery).Read())
                {
                    string ID = dBConnection.dr["P_ID"].ToString();
                    char[] seperator = { '_' };
                    string[] strarr = null;
                    strarr = ID.Split(seperator);

                    int index = int.Parse(strarr[1]);
                    int val = index + 1;
                    txt_ItemCode.Text = ("P_" + val.ToString());
                    dBConnection.CloseDataReader();
                }
                else
                {
                    txt_ItemCode.Text = "P_1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
