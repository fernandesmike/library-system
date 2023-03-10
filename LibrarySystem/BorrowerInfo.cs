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
using System.Data.SqlClient;

namespace LibrarySystem
{
    public partial class BorrowerInfo : Form
    {
        private InfoUIHelper infoUI;
        private DataHelper data;
        private string connectionString;

        public BorrowerInfo()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            data = new DataHelper(connectionString);
            infoUI = new InfoUIHelper(this);
        }

        private void BorrowerInfo_Load(object sender, EventArgs e)
        {
            infoUI.loadData();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Dashboard returnToDashboard = new Dashboard();
            this.Close();
            returnToDashboard.Show();
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            // Disable account
            if(Dashboard.status.ToLower() == "active")
            {
                data.changeStatus(Dashboard.id, "inactive");
                infoUI.updateStatus("inactive");
                Dashboard.status = "inactive";
            }

            // Enable account
            else if (Dashboard.status.ToLower() == "inactive")
            {
                data.changeStatus(Dashboard.id, "active");
                infoUI.updateStatus("active");
                Dashboard.status = "active";
            }
        }
    }
}
