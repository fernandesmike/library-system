using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Repository
{
    class BorrowerRepository : IRepository
    {
        private readonly string connection;
        private DataGridView dataGrid;

        private int queryPerformed;

        public BorrowerRepository(string connection)
        {
            this.connection = connection;
        }

        public BorrowerRepository(string connection, DataGridView dataGrid)
        {
            this.connection = connection;
            this.dataGrid = dataGrid;
        }


        // DATA QUERY LANGUAGE

        public void loadAll()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT borrower_id AS [Borrower ID], " +
                                     "borrower_fname AS Firstname, " +
                                     "borrower_lname AS Lastname, " +
                                     "borrower_status AS Status, " +
                                     "date_registered AS [Registration date], " +
                                     "borrower_username AS Username " +
                                     "FROM tbl_borrower ";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    refreshDataGrid();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

        public void loadActive()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT borrower_id AS [Borrower ID], " +
                                     "borrower_fname AS Firstname, " +
                                     "borrower_lname AS Lastname, " +
                                     "borrower_status AS Status, " +
                                     "date_registered AS [Registration date], " +
                                     "borrower_username AS Username " +
                                     "FROM tbl_borrower " +
                                     "WHERE borrower_status = 1";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    refreshDataGrid();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "Error loading inactive borrowers");
            }
        }

        public void loadInactive()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT borrower_id AS [Borrower ID], " +
                                     "borrower_fname AS Firstname, " +
                                     "borrower_lname AS Lastname, " +
                                     "borrower_status AS Status, " +
                                     "date_registered AS [Registration date], " +
                                     "borrower_username AS Username " +
                                     "FROM tbl_borrower " +
                                     "WHERE borrower_status = 0";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    refreshDataGrid();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "Error loading inactive borrowers");
            }
        }

        public int count()
        {
            int count;

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT COUNT(*) FROM tbl_borrower";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
                return 0;
            }
        }

        public int countByStatus(int status)
        {
            int count;

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT COUNT(*) FROM tbl_borrower WHERE borrower_status = @status";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();

                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
                return 0;
            }

        }

        public void search(string searchQuery)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT borrower_id AS [Borrower ID], " +
                                     "borrower_fname AS Firstname, " +
                                     "borrower_lname AS Lastname, " +
                                     "borrower_status AS Status, " +
                                     "date_registered AS [Registration date], " +
                                     "borrower_username AS Username " +
                                     "FROM tbl_borrower " +
                                     "WHERE borrower_fname LIKE @search " +
                                     "OR borrower_lname LIKE @search " +
                                     "OR borrower_username LIKE @search";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    refreshDataGrid();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " Cannot perform the operation!");
            }

        }

        public bool checkIfExist(string username)
        {
            int result = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "SELECT COUNT(*) " +
                                     "FROM tbl_borrower " +
                                     "WHERE borrower_username = @username " +
                                     "COLLATE SQL_Latin1_General_CP1_CS_AS";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();

                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error connecting to our server!");
            }

            return result > 0 ? true : false; 
        }

        // DATA QUERY LANGUAGE

        public int add(string username, string firstname, string lastname, string registrationDate)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string hashedPass = PasswordHandler.HashPassword(username.Replace(" ", ""));
                    string command = "INSERT INTO tbl_borrower(borrower_id, borrower_fname, borrower_lname, date_registered, borrower_username, borrower_password) " +
                                     "VALUES (NEXT VALUE FOR seq_borrower_id, @fname, @lname, @date, @username, @hashedPass)";
                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@fname", firstname);
                    cmd.Parameters.AddWithValue("@lname", lastname);
                    cmd.Parameters.AddWithValue("@date", registrationDate);
                    cmd.Parameters.AddWithValue("@hashedPass", hashedPass);

                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error adding the borrower!");
                return 0;
            }
        }

        public int delete(string borrowerId)
        {
            int queryPerformed;

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "DELETE from tbl_borrower WHERE borrower_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@id", borrowerId);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error deleting the borrower");

                return 0;
            }
        }

        public int updateStatus(string borrowerId, int status)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "UPDATE tbl_borrower " +
                                     "SET borrower_status = @status " +
                                     "WHERE borrower_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", borrowerId);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + $"Error updating status of borrower {borrowerId}");
                return 0;
            }
        }

        
        /*
         * changeUsername
         * changePassword
         * 
         * changeFirstName
         * changeLastName
        */
        public void refreshDataGrid()
        {
            dataGrid.Visible = false;
            dataGrid.Visible = true;
        }
    }
}
