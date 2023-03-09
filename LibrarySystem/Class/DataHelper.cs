﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LibrarySystem
{
    class DataHelper
    {
        private string conString;
        private DataGridView dataGrid;

        public DataHelper(string con, DataGridView dataGrid)
        {
            this.conString = con;
            this.dataGrid = dataGrid;
        }

        // Quantity, Genre, 

        // Books - DQL
        public void loadAllBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    // Retrieve only the available books
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

        public void loadAvailableBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    // Retrieve only the available books
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books WHERE available = 1";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

        public void loadBorrowedBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    // Retrieve only the available books
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books WHERE available = 0";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

        public void searchBooks(String searchQuery)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books WHERE title LIKE @search";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " Cannot perform the operation!");
            }
        }

        public void searchBooks(String searchQuery, String availability)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT book_id AS ID, title AS [Book title], author AS Author FROM tbl_books WHERE title LIKE @search AND  available = @available";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
                    cmd.Parameters.AddWithValue("@available", "%" + availability + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " Cannot perform the operation!");
            }
        }

        // Books - DML
        public void updateBook(string book_id, string availability)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "UPDATE tbl_books SET available = @availability WHERE id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@availability", availability);
                    cmd.Parameters.AddWithValue("@id", book_id);
                    cmd.ExecuteNonQuery();

                    applyGridStyling();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error inserting the book!");
            }
        }

        // Borrowers - DQL
        public void loadBorrowers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT borrower_id AS 'Borrower ID', username AS Username, firstname AS Firstname, lastname AS Lastname  FROM tbl_borrower";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

        public void loadBorrowers(String status)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT borrower_id AS 'Borrower ID', username AS Username, firstname AS Firstname, lastname AS Lastname  FROM tbl_borrower WHERE status = @status";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }

                    applyGridStyling();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "We can't load data from our server.");
            }
        }

        public int countBorrowers()
        {
            int count;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
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

        // Count borrowers by specified condition
        public int countBorrowers(String status)
        {
            int count;

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string command = "SELECT COUNT(*) FROM tbl_borrower WHERE status = @status";
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
        // UI Styling
        private void applyGridStyling()
        {
            // UI styling of data grid
            // Prevent dataGrid from rolling back to default header sizing when searching
            dataGrid.Columns[0].Width = 60;
            dataGrid.Columns[2].Width = 140;
            dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Refresh the grid
            dataGrid.Visible = false;
            dataGrid.Visible = true;
        }
    }
}
