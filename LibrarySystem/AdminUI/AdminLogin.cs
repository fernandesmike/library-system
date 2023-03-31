using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibrarySystem.AdminUI;

namespace LibrarySystem.AdminUI
{
    public partial class AdminLogin : Form
    {
        // Fetch the current user of the form
        public static string currentUser;

        private readonly string connection;

        public AdminLogin()
        {
            InitializeComponent();
            //TODO: Change path
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
        }

        private void BtnBorrowerLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool valid = validateFields();

            if (valid)
            {
                // Validate the credentials here against the database
                try
                {
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        string command = "SELECT admin_password " +
                                         "FROM tbl_admin " +
                                         "WHERE admin_username = @username " +
                                         "COLLATE SQL_Latin1_General_CP1_CS_AS";
                        con.Open();

                        SqlCommand cmd = new SqlCommand(command, con);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // If account exists, check password
                            if (reader.Read())
                            {
                                lblErrorName.Visible = false;

                                // Get the stored hash of the corresponding user
                                string storedPassword = reader.GetString(0);

                                // If password is correct, proceed to login
                                if (txtPass.Text.Trim().Equals(storedPassword))
                                {
                                    // Used to contain the current user
                                    currentUser = txtUsername.Text;

                                    Dashboard home = new Dashboard();
                                    home.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    // If password is wrong, display the error to the UI
                                    txtPass.Clear();
                                    lblErrorName.Visible = true;
                                    lblErrorName.Text = "Please check your password";
                                }
                            }
                            // If account does not exist, return the error to the UI
                            else
                            {
                                txtPass.Clear();
                                lblErrorName.Visible = true;
                                lblErrorName.Text = "Sorry, we couldn't find this account.";
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "There was an error connecting to our server!");
                }
            }
        }

        private bool validateFields()
        {
            string username = txtUsername.Text.Trim();
            string pass = txtPass.Text.Trim();
            bool isValid = false;

            if (username == "" || pass == "")
            {
                lblErrorName.Text = "Please provide a username or password";
                lblErrorName.Visible = true;
                isValid = false;

                txtPass.Clear();
            }
            else if (username.Length < 6)
            {
                lblErrorName.Text = "Usernames should be at least 6 characters";
                lblErrorName.Visible = true;
                txtPass.Clear();
                isValid = false;
            }
            else
            {
                lblErrorName.Visible = false;
                isValid = true;
            }

            return isValid;
        }
    }
}
