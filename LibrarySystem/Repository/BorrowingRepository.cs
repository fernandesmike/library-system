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
    class BorrowingRepository
    {
        private readonly string connection;
        private readonly DataGridView dataGrid;

        private int queryPerformed;

        public BorrowingRepository(string connection)
        {
            this.connection = connection;
        }

        public BorrowingRepository(string connection, DataGridView dataGrid)
        {
            this.connection = connection;
            this.dataGrid = dataGrid;
        }

        public int borrowBook(int bookId, int borrowerId, string dateBorrowed, string dateDeadline, int quantities)
        {
            int queryPerformed;

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string command = "INSERT INTO tbl_borrow_book(borrow_id, borrower_id, book_id, date_borrowed, date_deadline, quantities_borrowed) " +
                                     "VALUES (NEXT VALUE FOR seq_borrow_id, @borrowerId, @bookId, @dateBorrowed, @dateDeadline, @quantities)";

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@bookId", bookId);
                    cmd.Parameters.AddWithValue("@borrowerId", borrowerId);
                    cmd.Parameters.AddWithValue("@dateBorrowed", dateBorrowed);
                    cmd.Parameters.AddWithValue("@dateDeadline", dateDeadline);
                    cmd.Parameters.AddWithValue("@quantities", quantities);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error borrowing the book!");
                return 0;
            }
        }

        public int returnBook(int bookId, int borrowerId, string dateReturned)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string command = "UPDATE tbl_borrow_book " +
                                     "SET date_returned = @dateReturned " +
                                     "WHERE book_id = @bookId " +
                                     "AND borrower_id = @borrowerId";

                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@bookId", bookId);
                    cmd.Parameters.AddWithValue("@borrowerId", borrowerId);
                    cmd.Parameters.AddWithValue("@dateReturned", dateReturned);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + " There was an error returning the book!");
                return 0;
            }
        }

        public void refreshDataGrid()
        {
            dataGrid.Visible = false;
            dataGrid.Visible = true;
        }
    }
}
