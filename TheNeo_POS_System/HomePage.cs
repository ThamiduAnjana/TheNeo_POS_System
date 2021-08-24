using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeo_POS_System
{
    public partial class HomePage : Form
    {
        public HomePage(string data_username)
        {
            InitializeComponent();
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_Dashboard.Top;
            Btn_Dashboard.BackColor = Color.FromArgb(234, 237, 237);
            //Btn_Dashboard.BackColor = Color.FromArgb(251, 252, 252);
            dashBoard_Page1.BringToFront();
            Txt_UserName.Text = data_username;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparm,int lparam);

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

        private void HomePage_Load(object sender, EventArgs e)
        {
            //Date & Time (Bottom Panel)
            Txt_Date.Text = DateTime.Now.ToLongDateString();
            timer_for_Time.Start();
            Txt_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer_for_Time_Tick(object sender, EventArgs e)
        {
            Txt_Time.Text = DateTime.Now.ToLongTimeString();
            timer_for_Time.Start();
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void Top_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void Bottom_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Left_Menu_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public override bool Equals(object obj)
        {
            return obj is HomePage page &&
                   EqualityComparer<CreateParams>.Default.Equals(CreateParams, page.CreateParams);
        }

        public override int GetHashCode()
        {
            return -459409677 + EqualityComparer<CreateParams>.Default.GetHashCode(CreateParams);
        }


        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_Dashboard.Top;

            //active bg color
            Btn_Dashboard.BackColor = Color.FromArgb(234, 237, 237);
            //normal bg color
            Btn_About.BackColor = Color.FromArgb(251, 252, 252);
            Btn_QItemWizard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Invoice.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Setting.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Category.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Service.BackColor = Color.FromArgb(251, 252, 252);
            Btn_NewItem.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Store.BackColor = Color.FromArgb(251, 252, 252);
            Btn_PriceUpdate.BackColor = Color.FromArgb(251, 252, 252);

            dashBoard_Page1.BringToFront();
            dashBoard_Page1.Visible = true;
        }

        private void Btn_Invoice_Click(object sender, EventArgs e)
        {
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_Invoice.Top;

            //active bg color
            Btn_Invoice.BackColor = Color.FromArgb(234, 237, 237);
            //normal bg color
            Btn_About.BackColor = Color.FromArgb(251, 252, 252);
            Btn_QItemWizard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Dashboard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Setting.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Category.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Service.BackColor = Color.FromArgb(251, 252, 252);
            Btn_NewItem.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Store.BackColor = Color.FromArgb(251, 252, 252);
            Btn_PriceUpdate.BackColor = Color.FromArgb(251, 252, 252);

            invoice_Page1.BringToFront();
            invoice_Page1.Visible = true;
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_About.Top;

            //active bg color
            Btn_About.BackColor = Color.FromArgb(234, 237, 237);
            //normal bg color
            Btn_Dashboard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_QItemWizard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Invoice.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Setting.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Category.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Service.BackColor = Color.FromArgb(251, 252, 252);
            Btn_NewItem.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Store.BackColor = Color.FromArgb(251, 252, 252);
            Btn_PriceUpdate.BackColor = Color.FromArgb(251, 252, 252);

            about_Page1.BringToFront();
            about_Page1.Visible = true;
        }

        private void Btn_QItemWizard_Click(object sender, EventArgs e)
        {
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_QItemWizard.Top;

            //active bg color
            Btn_QItemWizard.BackColor = Color.FromArgb(234, 237, 237);
            //normal bg color
            Btn_Dashboard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_About.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Invoice.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Setting.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Category.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Service.BackColor = Color.FromArgb(251, 252, 252);
            Btn_NewItem.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Store.BackColor = Color.FromArgb(251, 252, 252);
            Btn_PriceUpdate.BackColor = Color.FromArgb(251, 252, 252);

            quick_Item_Wizard_Page1.BringToFront();
            quick_Item_Wizard_Page1.Visible = true;
        }

        private void invoice_Page1_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Setting_Click(object sender, EventArgs e)
        {
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_Setting.Top;

            //active bg color
            Btn_Setting.BackColor = Color.FromArgb(234, 237, 237);
            //normal bg color
            Btn_Dashboard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_About.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Invoice.BackColor = Color.FromArgb(251, 252, 252);
            Btn_QItemWizard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Category.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Service.BackColor = Color.FromArgb(251, 252, 252);
            Btn_NewItem.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Store.BackColor = Color.FromArgb(251, 252, 252);
            Btn_PriceUpdate.BackColor = Color.FromArgb(251, 252, 252);

            setting_Page1.BringToFront();
            setting_Page1.Visible = true;
        }

        private void Btn_Category_Click(object sender, EventArgs e)
        {
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_Category.Top;

            //active bg color
            Btn_Category.BackColor = Color.FromArgb(234, 237, 237);
            //normal bg color
            Btn_Dashboard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_About.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Invoice.BackColor = Color.FromArgb(251, 252, 252);
            Btn_QItemWizard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Setting.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Service.BackColor = Color.FromArgb(251, 252, 252);
            Btn_NewItem.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Store.BackColor = Color.FromArgb(251, 252, 252);
            Btn_PriceUpdate.BackColor = Color.FromArgb(251, 252, 252);

            category_Page1.BringToFront();
            category_Page1.Visible = true;
        }

        private void Btn_Service_Click(object sender, EventArgs e)
        {
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_Service.Top;

            //active bg color
            Btn_Service.BackColor = Color.FromArgb(234, 237, 237);
            //normal bg color
            Btn_Dashboard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_About.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Invoice.BackColor = Color.FromArgb(251, 252, 252);
            Btn_QItemWizard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Setting.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Category.BackColor = Color.FromArgb(251, 252, 252);
            Btn_NewItem.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Store.BackColor = Color.FromArgb(251, 252, 252);
            Btn_PriceUpdate.BackColor = Color.FromArgb(251, 252, 252);

            service_Page1.BringToFront();
            service_Page1.Visible = true;
        }

        private void Btn_NewItem_Click(object sender, EventArgs e)
        {
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_NewItem.Top;

            //active bg color
            Btn_NewItem.BackColor = Color.FromArgb(234, 237, 237);
            //normal bg color
            Btn_Dashboard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_About.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Invoice.BackColor = Color.FromArgb(251, 252, 252);
            Btn_QItemWizard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Setting.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Category.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Service.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Store.BackColor = Color.FromArgb(251, 252, 252);
            Btn_PriceUpdate.BackColor = Color.FromArgb(251, 252, 252);

            grN_New_Item_Page1.BringToFront();
            grN_New_Item_Page1.Visible = true;
        }

        private void Btn_Store_Click(object sender, EventArgs e)
        {
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_Store.Top;

            //active bg color
            Btn_Store.BackColor = Color.FromArgb(234, 237, 237);
            //normal bg color
            Btn_Dashboard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_About.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Invoice.BackColor = Color.FromArgb(251, 252, 252);
            Btn_QItemWizard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Setting.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Category.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Service.BackColor = Color.FromArgb(251, 252, 252);
            Btn_NewItem.BackColor = Color.FromArgb(251, 252, 252);
            Btn_PriceUpdate.BackColor = Color.FromArgb(251, 252, 252);

            store_Page1.BringToFront();
            store_Page1.Visible = true;
        }

        private void Btn_PriceUpdate_Click(object sender, EventArgs e)
        {
            Btn_SidePanel.Height = Btn_Dashboard.Height;
            Btn_SidePanel.Top = Btn_PriceUpdate.Top;

            //active bg color
            Btn_PriceUpdate.BackColor = Color.FromArgb(234, 237, 237);
            //normal bg color
            Btn_Dashboard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_About.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Invoice.BackColor = Color.FromArgb(251, 252, 252);
            Btn_QItemWizard.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Setting.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Category.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Service.BackColor = Color.FromArgb(251, 252, 252);
            Btn_NewItem.BackColor = Color.FromArgb(251, 252, 252);
            Btn_Store.BackColor = Color.FromArgb(251, 252, 252);

            price_Update_Page1.BringToFront();
            price_Update_Page1.Visible = true;
        }
    }
}
