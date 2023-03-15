﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Class
{
    interface IErrorController
    {
        void showErrorMessage();

        void hideErrorMessage();

        void showBorrowerExistMessage();

        void showBookExistMessage();
    }
}
