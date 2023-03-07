using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ConfirmBorrow : Form
    {
        public ConfirmBorrow()
        {
            InitializeComponent();
        }

        private void ConfirmBorrow_Load(object sender, EventArgs e)
        {
            // Get the currently selected row
            lblBookTitle.Text = HomeScreen.title;
            lblAuthor.Text = "by " + HomeScreen.author;
        }

        private void BtnClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
