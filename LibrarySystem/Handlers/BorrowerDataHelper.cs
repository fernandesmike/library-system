using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    class BorrowerDataHelper
    {
        private string connection;
        private DataGridView dataGrid;

        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlConnection con;

        public BorrowerDataHelper(string connection)
        {
            this.connection = connection;
        }

        public BorrowerDataHelper(string connection, DataGridView dataGrid)
        {
            this.connection = connection;
            this.dataGrid = dataGrid;
        }

        /*
        DQL - SELECT, COUNT, CHECKERS
        */

        public int checkIfBorrowerExist(string firstname, string lastname)
        {
            int result;

            try
            {
                using (con = new SqlConnection(connection))
                {
                    string command = "SELECT COUNT(*) " +
                                     "FROM tbl_borrower " +
                                     "WHERE LOWER(borrower_fname) = LOWER(@firstname) " +
                                     "AND LOWER(borrower_lname) = LOWER(@lastname)";
                    con.Open();

                    cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.ExecuteNonQuery();

                    result = Convert.ToInt32(cmd.ExecuteScalar());

                    return result;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + "There was an error connecting to our servers!");
                return 0;
            }
        }

        /*
        DML - INSERT, UPDATE, DELETE
        */

        public int addBorrower(string firstName, string lastName)
        {
            int queryPerformed;

            try
            {
                using (con = new SqlConnection(connection))
                {
                    con.Open();
                    string command = "INSERT INTO tbl_borrower(borrower_id, borrower_fname, borrower_lname) " +
                                     "VALUES (NEXT VALUE FOR seq_borrower_id, @fName, @lName)";

                    cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@fName", firstName);
                    cmd.Parameters.AddWithValue("@lName", lastName);
                    queryPerformed = cmd.ExecuteNonQuery();

                    return queryPerformed;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err + $"There was an error adding {firstName}");
                return 0;
            }
        }
    }
}
