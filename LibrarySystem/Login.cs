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

namespace LibrarySystem
{
    public partial class Login : Form
    {
        // Fetch the current user of the form
        public static string currentUser;

        string connectionString;

        public Login()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void LnkToReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool valid = validateFields();

            if (valid)
            {
                // Validate the credentials here against the database
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string command = "SELECT password, user_type FROM tbl_user WHERE username = @username";
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
                                string storedHash = reader.GetString(0);

                                // Get the user type
                                string userLvl = reader.GetString(1);

                                // If password is correct, proceed to login
                                if (PasswordHandler.ValidatePassword(txtPass.Text.Trim(), storedHash))
                                {
                                    // Used to contain the current user
                                    currentUser = txtUsername.Text;

                                    // If the login credential is an ADMIN account
                                    // Display Admin dashboard
                                    if (userLvl == "ADMIN")
                                    {
                                        Home home = new Home();
                                        home.Show();
                                        this.Hide();
                                    }
                                    // But if the credentials is a BASIC account
                                    // Display Home screen
                                    else
                                    {
                                        HomeScreen userScreen = new HomeScreen();
                                        userScreen.Show();
                                        this.Hide();
                                    }
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
                catch(Exception err)
                {
                    MessageBox.Show(err + " There was an error connecting to our server!");
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
