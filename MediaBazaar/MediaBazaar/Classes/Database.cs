using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MediaBazaar.Classes
{
    internal class Database
    {

        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi523343_mediabz;User Id=dbi523343_mediabz;Password=sem2group;";


        protected SqlConnection CreateConnection()
        {

        }

        public void addEmployeeToDatabase()
        {
            // some logic
        }

        public void updateEmployeeInDatabase()
        {
            // some logic
        }

        public void deleteEmployeeFromDatabase()
        {
            // some logic
        }

        public List<Employee> retrieveEmployeeFromDatabase()
        {
            // some logic
            return new List<Employee>();
        }
    }
}

