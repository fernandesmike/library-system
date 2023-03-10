using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BorrowerInfo : Form
    {
        public BorrowerInfo()
        {
            InitializeComponent();
        }

        private void BorrowerInfo_Load(object sender, EventArgs e)
        {
            lblUser.Text = Dashboard.fullName;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Dashboard returnToDashboard = new Dashboard();
            this.Close();
            returnToDashboard.Show();
        }
    }
}
