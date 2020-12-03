using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog.Repository
{
  public class MySqlConnection
  {
    //https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection.connectionstring?view=dotnet-plat-ext-5.0
    private static void OpenSqlConnection()
    {
      string connectionString = GetConnectionString();

      using (SqlConnection connection = new SqlConnection())
      {
        connection.ConnectionString = connectionString;

        connection.Open();

        System.Diagnostics.Debug.WriteLine("State: {0}", connection.State);
        System.Diagnostics.Debug.WriteLine("ConnectionString: {0}", connection.ConnectionString);
      }
    }

    static private string GetConnectionString()
    {
      // To avoid storing the connection string in your code,
      // you can retrieve it from a configuration file.
      return "Data Source=MSSQL1;Initial Catalog=AdventureWorks;" + "Integrated Security=true;";
    }
  }
}
