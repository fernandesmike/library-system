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
        private readonly string connection;
        private readonly DateTime date;

        public Register()
        {
            InitializeComponent();
            //TODO: Change connection string
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            date = DateTime.Today;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtPassword.Enabled = false;
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
                lblErrorUsername.Visible = true;
                lblErrorUsername.Text = "Username should be at least 6 characters";

                // Textfields & Buttons
                txtPassword.Enabled = false;
                btnRegister.Enabled = false;

                // Textfields
                txtPassword.Clear();
                lblErrorPass.Visible = false;
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        string command = "SELECT * " +
                                         "FROM tbl_borrower " +
                                         "WHERE borrower_username = @username";
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
                                lblErrorUsername.Visible = true;
                                lblErrorUsername.Text = "This username is already taken";

                                // Textfields & Buttons
                                txtPassword.Enabled = false;
                                btnRegister.Enabled = false;

                                // Textfield contents
                                txtPassword.Clear();
                            }
                            // If the username is available, proceed with passwords
                            else
                            {
                                // Errors
                                lblErrorPass.Visible = false;
                                lblErrorUsername.Visible = false;

                                // Textfields & Buttons
                                txtPassword.Enabled = true;
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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            bool valid = validateFields();

            if (valid)
            {
                btnRegister.Enabled = true;

                try
                {
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        con.Open();

                        // Create a hashed password before storing it to DB
                        string hashedPass = PasswordHandler.HashPassword(txtPassword.Text.Trim());
                        string command = "INSERT INTO tbl_borrower(borrower_id, borrower_fname, borrower_lname, date_registered, borrower_username, borrower_password) " +
                                         "VALUES (NEXT VALUE FOR seq_borrower_id, @fname, @lname, @date, @username, @pass)";

                        SqlCommand cmd = new SqlCommand(command, con);
                        cmd.Parameters.AddWithValue("@fname", txtFirstname.Text.Trim());
                        cmd.Parameters.AddWithValue("@lname", txtLastname.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-d"));
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", hashedPass);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("ACCOUNT CREATED!");

                    }

                    Login.currentUser = txtUsername.Text.Trim();
                    Borrower borrow = new Borrower();
                    this.Close();
                    borrow.Show();

                    txtUsername.Clear();
                    txtFirstname.Clear();
                    txtPassword.Clear();
                    txtLastname.Clear();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err + " There was an error creating your account!");
                }
            }
        }

        private bool validateFields()
        {
            bool isValid = false;

            if (string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtLastname.Text))
            {
                isValid = false;

                lblNameError.Visible = true;
                lblNameError.Text = "Please provide your firstname and lastname";

                lblErrorPass.Visible = false;
            }
            else
            {
                lblNameError.Visible = false;
                isValid = true;
            }

            return isValid;
        }
    }
}
