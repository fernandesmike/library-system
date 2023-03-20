using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class BorrowerUIHelper
    {
        Borrower borrower;

        public BorrowerUIHelper(Borrower borrower)
        {
            this.borrower = borrower;
        }

        public void loadHomeUI()
        {
            borrower.flpTop.Visible = true;
        }

        public void loadProfileUI()
        {
            
        }
    }
}
