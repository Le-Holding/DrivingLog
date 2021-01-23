using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog.Repository
{
  public class MySqlConnection : IEmployeeRepository, IDrivingLogRepository
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

    public int InsertDrivingRevord(DrivingLogDto dto)
    {
      using (SqlConnection con = new SqlConnection())
      {
        con.ConnectionString = GetConnectionString();

        con.Open();

        using (var cmd = new SqlCommand("", con))
        {
          cmd.CommandText = $"INSERT INTO driving_record " +
                            $"(employee_id, kilometer_traveled, drived_date, driving_record_created, driving_record_corrected) " +
                            $"VALUES (@Employee_id, @Kilometer_traveled, @Drived_date, @Driving_record_created, @Driving_record_corrected) " +
                            $"SELECT ____SCOPE_IDENTITY()____"; //https://stackoverflow.com/questions/18373461/execute-insert-command-and-return-inserted-id-in-sql


          cmd.Parameters.AddWithValue("@Employee_id", dto.EmployeeId);
          cmd.Parameters.AddWithValue("@Kilometer_traveled", dto.Distance);
          cmd.Parameters.AddWithValue("@Drived_date", dto.Date);
          cmd.Parameters.AddWithValue("@Driving_record_created", DateTime.Now);
          cmd.Parameters.AddWithValue("@Driving_record_corrected", null);

          //int affectedRows = cmd.ExecuteNonQuery();
          int modifiedId = (int)cmd.ExecuteScalar();
          

          if (con.State == System.Data.ConnectionState.Open)
            con.Close();

          return modifiedId;
        }
      }
    }

    public IList<EmployeeStamdataDto> GetEmployees()
    {
      throw new NotImplementedException();
    }

    public EmployeeStamdataDto GetEmployeeById(int? id)
    {
      throw new NotImplementedException();
    }

    public void InsertNewEmployee(EmployeeStamdataDto dto)
    {
      throw new NotImplementedException();
    }

    public void UpdateEmployee(EmployeeStamdataDto dto)
    {
      throw new NotImplementedException();
    }

    public void DeleteEmployee(int id)
    {
      throw new NotImplementedException();
    }

    public IList<EmployeeStamdataDto> GetDrivinglog()
    {
      throw new NotImplementedException();
    }

    public EmployeeStamdataDto GetDrivinglogById(int? id)
    {
      throw new NotImplementedException();
    }

    public void InsertDrivinglog(EmployeeStamdataDto dto)
    {
      throw new NotImplementedException();
    }

    public void UpdateDrivinglog(EmployeeStamdataDto dto)
    {
      throw new NotImplementedException();
    }

    public void DeleteDrivinglog(int id)
    {
      throw new NotImplementedException();
    }
  }
}
