﻿using System;
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

namespace LibrarySystem
{
    public partial class Login : Form
    {
        // Fetch the current user of the form
        public static string currentUser;
        public static int currentUserId;
        public static string firstName;
        public static string lastName;
        public static string username;

        private readonly string connection;

        public Login()
        {
            InitializeComponent();
            //TODO: Change the connection string
            connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=library_system_mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        string command = "SELECT borrower_id, " +
                                         "borrower_password, " +
                                         "borrower_fname, " +
                                         "borrower_lname, " +
                                         "borrower_username " +
                                         "FROM tbl_borrower " +
                                         "WHERE borrower_username = @username " +
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

                                // Get the stored hash of the corresponding user and the user itself
                                string storedHash = reader.GetString(1);
                                currentUserId = reader.GetInt32(0);
                                firstName = reader.GetString(2);
                                lastName = reader.GetString(3);
                                username = reader.GetString(4);

                                // If password is correct, proceed to login
                                if (PasswordHandler.ValidatePassword(txtPass.Text.Trim(), storedHash))
                                {
                                    // Used to contain the current user
                                    currentUser = txtUsername.Text;

                                    Borrower borrower = new Borrower();
                                    borrower.Show();
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
                catch(Exception err)
                {
                    MessageBox.Show(err.Message + "There was an error connecting to our server!");
                }
            }
        }

        private void BtnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            admin.Show();
            this.Hide();
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
