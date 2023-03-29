using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Repository
{
    class BorrowerRepository
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

        public void loadAll()
        {

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
