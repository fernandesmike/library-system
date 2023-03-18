using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibrarySystem
{/*
    ==========================================================================================================
    DataView class is used to create views from an SQL Database. This is exclusively used for 
    Borrower UI
    ==========================================================================================================
    */

    class DataViews
    {
        private string conString;
        private DataGridView dataGrid;

        public DataViews(string con, DataGridView dataGrid)
        {
            this.conString = con;
            this.dataGrid = dataGrid;
        }

        // Create views here
        public void displayBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    // Retrieve only the available books
                    string command = "SELECT * FROM Available_Books";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "There was an error fetching data from the server");
            }
        }

        public void displayBorrowedBooks()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    // Retrieve only the available books
                    string command = "SELECT * FROM Borrow_Book";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.ExecuteNonQuery();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable books = new DataTable();
                        adapter.Fill(books);
                        dataGrid.DataSource = books;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "There was an error fetching data from the server");
            }
        }

    }
}
