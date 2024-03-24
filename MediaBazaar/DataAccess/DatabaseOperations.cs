using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class DatabaseOperations
	{
		private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi523343_mediabz;User Id=dbi523343_mediabz;Password=sem2group;";

		protected SqlConnection CreateConnection()
		{
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			return connection;
		}
	}
}
