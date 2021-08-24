using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNeo_POS_System
{
    public partial class DashBoard_Page : UserControl
    {
        public DashBoard_Page()
        {
            InitializeComponent();
        }

        private void DashBoard_Page_Load(object sender, EventArgs e)
        {
            //Date & Time (Dashboard Bottom Panel)
            Txt_Date.Text = DateTime.Now.ToLongDateString();
            Live_Time_Timer.Start();
            Txt_Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void Live_Time_Timer_Tick(object sender, EventArgs e)
        {
            Txt_Time.Text = DateTime.Now.ToLongTimeString();
            Live_Time_Timer.Start();
        }

        private void btn_invoice_q_Click(object sender, EventArgs e)
        {
            Invoice_Page userwindow = new Invoice_Page();
            userwindow.Visible = true;
            this.Visible = false;
        }

        private void btn_service_q_Click(object sender, EventArgs e)
        {
            Service_Page userwindow = new Service_Page();
            userwindow.Visible = true;
            this.Visible = false;
        }

    }
}
