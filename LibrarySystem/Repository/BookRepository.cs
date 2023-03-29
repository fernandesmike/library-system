using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Repository
{
    class BookRepository : IRepository
    {
        private string connection;
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




        /*
        loadBorrowed
        getBookDetails
        getBookID

        updateBookDetails
        
        */

    }
}
