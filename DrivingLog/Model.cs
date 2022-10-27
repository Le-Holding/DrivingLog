using DrivingLog.Repository.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog
{
  public class Model
  {
    private readonly RepositoryForTestData _data;
    public Model() 
    {
      _data = new RepositoryForTestData();
    }

    public List<EmployeeStamdataDto> GetPersons()
    {
      return _data.GetPersons();
    }


    public int CreatePersons(EmployeeStamdataDto dto)
    {
      int id = -1;
      return id;
    }

    public int EditPersons(EmployeeStamdataDto dto)
    {
      int id = -1;
      return id;
    }

    public void DeleteEmployee(int id, List<EmployeeStamdataDto> dtos)
    {
      dtos.Remove(dtos.First(x => x.Id == id));
    }

    public int AddDrivingLog(DrivingLogDto dto)
    {
      int id = -1;
      return id;
    }

    public void DeleteCurrentDrivingLog(int id)
    {

    }

    public void DeleteAllDriverLogsForCurrentEmployee(int employeeId)
    {

    }

    internal void CreateNewDrivingLog(DrivingLogDto dto)
    {
      dto.Id = _data.CreateNewDrivingLogShortHanded(dto);
    }
  }
}
