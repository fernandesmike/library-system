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

        void loadActive();

        void loadInactive();

        int count();

        int countByStatus(int status);

        int delete(string id);

        int updateStatus(string id, int status);

        void search(string searchQuery);

        void refreshDataGrid();
    }
}
