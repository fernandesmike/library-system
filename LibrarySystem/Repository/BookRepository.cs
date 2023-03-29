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
    class BookRepository : IRepository
    {
        private readonly string connection;
        private DataGridView dataGrid;

        private int queryPerformed;

        public BookRepository(string connection)
        {
            this.connection = connection;
        }

        public BookRepository(string connection, DataGridView dataGrid)
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
                    string command = "SELECT book_id AS ID, " +
                                     "book_title AS [Book title], " +
                                     "book_author AS Author, " +
                                     "book_quantities AS [Total copies]" +
                                     "date_added AS [Added last], " +
                                     "book_status AS Status " +
                                     "FROM tbl_book";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.ExecuteNonQuery();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        using (DataTable books = new DataTable())
                        {
                            adapter.Fill(books);
                            dataGrid.DataSource = books;
                        }
                    }

                    refreshDataGrid();
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + "There was a problem loading books");
            }
        }

        public void loadBorrowed()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    //TODO: Load the book_id, title, author, borrower, and borrow_date 
                    string command = "";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.ExecuteNonQuery();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        using (DataTable books = new DataTable())
                        {
                            adapter.Fill(books);
                            dataGrid.DataSource = books;
                        }
                    }

                    refreshDataGrid();
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + "There was a problem loading books");
            }
        }



        // DATA MANIPULATION LANGUAGE

        public int delete(string id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "DELETE from tbl_book WHERE book_id = @id";
                    con.Open();

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + "There was an error deleting the book");
                return 0;
            }
        }

        public int updateStatus(string bookId, int status)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "UPDATE tbl_book " +
                                     "SET book_status = @status " +
                                     "WHERE book_id = @id";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", bookId);
                        queryPerformed = cmd.ExecuteNonQuery();
                    }

                    refreshDataGrid();

                    return queryPerformed;
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error updating the book status");
                return 0;
            }
        }

        public int updateQuantities(int quantity)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    string command = "UPDATE tbl_book " +
                                     "SET book_quantities = @quantity ";
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        queryPerformed = cmd.ExecuteNonQuery();
                    }

                    refreshDataGrid();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error updating the book status");
                return 0;
            }

        }




        // MISC

        public void refreshDataGrid()
        {
            dataGrid.Visible = false;
            dataGrid.Visible = true;
        }

    }
}


/*
loadBorrowed
getBookDetails
getBookID

updateBookDetails

*/
