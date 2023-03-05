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
    public partial class Register : Form
    {
        String connectionString;

        public Register()
        {
            InitializeComponent();
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtPass.Enabled = false;
            txtConfirmPass.Enabled = false;
            btnRegister.Enabled = false;
        }

        private void LnkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            // UI Validation
            if (txtUsername.Text.Length < 6)
            {
                // Errors
                lblErrorPass.Visible = false;
                lblErrorName.Visible = true;
                lblErrorName.Text = "Username should be at least 6 characters";

                // Textfields & Buttons
                txtPass.Enabled = false;
                txtConfirmPass.Enabled = false;
                btnRegister.Enabled = false;

                // Textfields
                txtPass.Clear();
                txtConfirmPass.Clear();
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string command = "SELECT * FROM tbl_user WHERE username = @username";
                        con.Open();

                        SqlCommand cmd = new SqlCommand(command, con);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // If a similar username is found, prevent user from creating the account
                            if (reader.HasRows)
                            {
                                // Errors
                                lblErrorPass.Visible = false;
                                lblErrorName.Visible = true;
                                lblErrorName.Text = "This username is already taken";

                                // Textfields & Buttons
                                txtPass.Enabled = false;
                                txtConfirmPass.Enabled = false;
                                btnRegister.Enabled = false;

                                // Textfield contents
                                txtPass.Clear();
                                txtConfirmPass.Clear();
                            }
                            // If the username is available, proceed with passwords
                            else
                            {
                                // Errors
                                lblErrorPass.Visible = false;
                                lblErrorName.Visible = false;

                                // Textfields & Buttons
                                txtPass.Enabled = true;
                                txtConfirmPass.Enabled = true;
                                btnRegister.Enabled = true;
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err + " There was an error creating your account.");
                }
            }
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            validatePass();
        }

        private void TxtConfirmPass_TextChanged(object sender, EventArgs e)
        {
           validatePass();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            bool valid = validatePass();

            if (valid)
            {
                btnRegister.Enabled = true;

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Create a hashed password before storing it to DB
                        string hashedPass = PasswordHandler.HashPassword(txtConfirmPass.Text.Trim());
                        string command = "INSERT INTO tbl_user(Id, username, password) VALUES (NEXT VALUE FOR sequence_id, @username, @pass)";

                        SqlCommand cmd = new SqlCommand(command, con);
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", hashedPass);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("ACCOUNT CREATED!");

                    }

                    Login.currentUser = txtUsername.Text.Trim();
                    Home home = new Home();
                    this.Close();
                    home.Show();

                    txtUsername.Clear();
                    txtPass.Clear();
                    txtConfirmPass.Clear();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err + " There was an error creating your account!");
                }
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }
        private bool validatePass()
        {
            bool isValid = false;

            if (txtPass.Text.Trim() == "" || txtConfirmPass.Text.Trim() == "")
            {
                isValid = false;
                lblErrorPass.Visible = true;
                lblErrorPass.Text = "Please provide a password";
                btnRegister.Enabled = false;

            }
            else if (txtPass.Text.Trim() == txtConfirmPass.Text.Trim())
            {
                // Errors
                lblErrorPass.Visible = false;

                // Buttons
                btnRegister.Enabled = true;

                isValid = true;
            }
            else
            {
                // Errors
                lblErrorPass.Visible = true;
                lblErrorPass.Text = "Passwords do not match";

                // Buttons
                btnRegister.Enabled = false;

                isValid = false;
            }

            return isValid;
        }

    }
}
