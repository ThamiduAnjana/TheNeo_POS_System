using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeo_POS_System
{
    public partial class Login_Page : Form
    {
        DBConnection dBConnection = new DBConnection();
        public Login_Page()
        {
            InitializeComponent();
            dBConnection.OpenConection();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparm, int lparam);

        //Form Shadow
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DropShadow;
                return cp;
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //DBConnection dBConnection = new DBConnection();
            //dBConnection.OpenConection();

            string username = txt_username.Text;
            string password = txt_password.Text;

            if (!username.Equals("") && !password.Equals(""))
            {
                string SQLQuery = "SELECT * FROM [POSSTheNeoMobile].[dbo].[TB.Users] WHERE U_Name = '" + username + "' and U_Password = '" + password + "';";

                if (dBConnection.DataReader(SQLQuery).Read())
                {
                    HomePage window = new HomePage(username);
                    window.Show();
                    this.Hide();
                }
                else
                {
                    const string message = "Login Fail..! Please check username & password..";
                    const string caption = "Application Information..";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // If the no button was pressed ...
                    if (result == DialogResult.OK)
                    {

                    }
                }
            }
            else
            {
                const string message = "Login Fail..! Empty username & password..";
                const string caption = "Application Information..";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                // If the no button was pressed ...
                if (result == DialogResult.OK)
                {

                }
            }
        }
    }
}
