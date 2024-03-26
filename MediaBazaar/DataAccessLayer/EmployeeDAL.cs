using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer;

namespace DataAccessLayer
{
    public class EmployeeDAL : Database
    {
        public EmployeeDAL() : base() { }

        public void AddEmployee(Employee employee)
        {
            using (SqlConnection connection = OpenConnection())
            {
                string sqlCmd = "INSERT INTO [";
            }
        }


    }
}
