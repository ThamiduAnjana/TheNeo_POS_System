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
    public partial class Invoice_Page : UserControl
    {
        public Invoice_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Please understand.you can't access this fuction or window. /n please contact your development team.(+9477 180 1521)", "Access Error : Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MassegeForTeamInfor_Page window1 = new MassegeForTeamInfor_Page();
            window1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MassegeForTeamInfor_Page window1 = new MassegeForTeamInfor_Page();
            window1.Show();
        }

        private void Invoice_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
