using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem.Repository
{
    class ReportRepository
    {
        private string connection;
        private DataGridView dataGrid;

        private int queryPerformed;

        public void loadAll()
        {

        }

        public void refreshDataGrid()
        {
            dataGrid.Visible = false;
            dataGrid.Visible = true;
        }
    }

}
