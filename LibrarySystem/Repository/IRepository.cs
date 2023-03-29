using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Repository
{
    interface IRepository
    {
        // Include CRUD operations here that can be performed by both 
        // books and borrowers

        /*
         add
         delete
         updateStatus
         
         loadAll
         loadAvailable // status
         load

         search // all, availability
         count // all, status, date

         checkIfExist
        */

        void loadAll();

        int delete(string dataId);

        int updateStatus(string bookId, int status);

        void refreshDataGrid();
    }
}
