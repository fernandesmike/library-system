using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibrarySystem
{
    class BookDataHelper
    {
        private string connection;
        private DataGridView dataGrid;

        private SqlCommand cmd;
        private SqlDataReader reader;

        private int bookId;
        private string bookTitle;
        private string[] bookAuthors;


        public BookDataHelper(string connection, DataGridView dataGrid)
        {
            this.connection = connection;
            this.dataGrid = dataGrid;
        }

        public void loadAllBooks()
        {

        }

        public void loadAvailableBooks()
        {

        }

        public void loadBorrowedBooks()
        {

        }

        public void searchBooks()
        {

        }

        public int getBookId(string title, string[] authors)
        {
            return bookId;
        }

        public string getBookTitle(int bookId)
        {
            return bookTitle;
        }

        public string[] getBookAuthor(int bookId)
        {
            return bookAuthors;
        }


        /*
        
        DATA MANIPULATION QUERIES 

        */

        public void updateBookStatus(int bookId)
        {

        }

        public void increaseBookQuantity(int bookId)
        {

        }

        public void decreaseBookQuantity(int bookId)
        {

        }

    }
}
