using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Repository
{
    class BorrowerRepository : IRepository
    {
        private string connection;
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

        /*
         * changeUsername
         * changePassword
         * 
         * changeFirstName
         * changeLastName
        */
    }
}
