using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeo_POS_System
{
    public class DBConnection
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataSet ds;

        string URL = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=POSSTheNeoMobile;User ID=sa;Password=12345";
        

        public void OpenConection()
        {
            try
            {
                con = new SqlConnection(URL);
                con.Open();
                /*const string message = "Database Connection Successfuly Opened !";
                const string caption = "DatabaseConnection Infromation..";
                var result = MessageBox.Show(message, caption,MessageBoxButtons.OK,MessageBoxIcon.Information);

                // If the no button was pressed ...
                if (result == DialogResult.OK)
                {
                    //continue 
                }*/
            }
            catch (Exception ex)
            {
                const string message = "Can Not Open Database Connection.! Please Contact IT Team (+94 77 180 1521)";
                const string caption = "DatabaseConnection Infromation..";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // If the no button was pressed ...
                if (result == DialogResult.OK)
                {
                    System.Environment.Exit(1);
                }
            }
        }


        public void CloseConnection()
        {
            con.Close();
        }


        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();
        }


        public SqlDataReader DataReader(string Query_)
        {
            cmd = new SqlCommand(Query_, con);
            dr = cmd.ExecuteReader();
            return dr;
        }


        public object ShowDataInGridView(string Query_)
        {
            da = new SqlDataAdapter(Query_, URL);
            ds = new DataSet();
            da.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

    }
}
