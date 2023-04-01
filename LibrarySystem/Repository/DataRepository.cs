using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Repository
{
    class DataRepository
    {
        protected string connection { get; set; }

        protected DataGridView dataGrid { get; set; }

        public DataRepository(string connection)
        {
            this.connection = connection;
        }

        public DataRepository(string connection, DataGridView dataGrid)
        {
            this.connection = connection;
            this.dataGrid = dataGrid;
        }
    }
}
