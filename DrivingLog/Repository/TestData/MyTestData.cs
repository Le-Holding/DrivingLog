using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog.Repository.TestData
{
  public class MyTestData
  {
    private readonly TestDataHelperClass _bizz;
    public MyTestData()
    {
      _bizz = new TestDataHelperClass();
    }
    private List<EmployeeStamdataDto> Persons
    {
      get
      {
        //singleton Pattern
        if (_persons == null) 
          _persons = new List<EmployeeStamdataDto>()
          {
            new EmployeeStamdataDto { Id = 1, Name = "Jalina", LicensePlate = "CP86028", Date = new DateTime(2020, 08, 01) },
            new EmployeeStamdataDto { Id = 2, Name = "Melina", LicensePlate = "AR86028", Date = new DateTime(2020, 01, 01) },
            new EmployeeStamdataDto { Id = 3, Name = "Kalina", LicensePlate = "BK08022", Date = new DateTime(2019, 05, 25) },
            new EmployeeStamdataDto { Id = 4, Name = "Selina", LicensePlate = "BA09455", Date = new DateTime(2015, 12, 30) }
          };
        
        return _persons;
      }
      set => _persons = value;
    }

    public List<EmployeeStamdataDto> GetPersons()
    {
      foreach (var item in Persons)
      {
        item.DrivingLogObj = _bizz.GetSubsetOfAListById(EmployeeDrivingLog, item.Id);
        item.kilometerSum = _bizz.GetSumOfProduct(item.DrivingLogObj.Select(x => x.Distance).ToList());
        //item.kilometerSum = GetSumOfProduct(EmployeeDrivingLog.Where(x => x.EmployeeId == item.Id).Select(x => x.Distance).ToList());
      }

      Persons.ForEach(x => x.DeepCopy = x.SetDeepCopy());

      return Persons.OrderBy(x => x.Name).ToList();
    }

    private List<EmployeeStamdataDto> _persons;
    private List<DrivingLogDto> _employeeDrivingLog;

    public List<DrivingLogDto> EmployeeDrivingLog
    {
      get
      {
        //singleton Pattern
        if (_employeeDrivingLog == null) 
          _employeeDrivingLog = new List<DrivingLogDto>()
          {
            new DrivingLogDto {Id =  1, EmployeeId = 1, Date = DateTime.UtcNow,  Distance = 10,   DriversTask = "TEC Hvidovre"},
            new DrivingLogDto {Id =  2, EmployeeId = 1, Date = DateTime.Now,     Distance = 300,  DriversTask = "AU Aarhus"},
            new DrivingLogDto { Id = 3, EmployeeId = 1, Date = DateTime.UtcNow, Distance = 96, DriversTask = "Tec Ballerup" },
            new DrivingLogDto { Id = 4, EmployeeId = 2, Date = DateTime.Now, Distance = 10, DriversTask = "DTU Lyngby" },
            new DrivingLogDto { Id = 5, EmployeeId = 2, Date = DateTime.UtcNow, Distance = 200, DriversTask = "DTU Aarhus" },
            new DrivingLogDto { Id = 6, EmployeeId = 2, Date = DateTime.Now, Distance = 100, DriversTask = "Tec Ballerup" },
            new DrivingLogDto { Id = 7, EmployeeId = 3, Date = DateTime.UtcNow, Distance = 400, DriversTask = "AAU AAlBorg" },
            new DrivingLogDto { Id = 8, EmployeeId = 3, Date = DateTime.Now, Distance = 1398, DriversTask = "Gardasøen Italien" },
            new DrivingLogDto { Id = 9, EmployeeId = 3, Date = DateTime.UtcNow, Distance = 1216, DriversTask = "Paris" },
            new DrivingLogDto { Id = 10, EmployeeId = 4, Date = DateTime.Now, Distance = 1895, DriversTask = "Rom" },
            new DrivingLogDto { Id = 11, EmployeeId = 4, Date = DateTime.UtcNow, Distance = 1895, DriversTask = "Tec Ballerup" },
            new DrivingLogDto { Id = 12, EmployeeId = 4, Date = DateTime.Now, Distance = 3006, DriversTask = "Málaga" },
          };

        return _employeeDrivingLog;
      }
      set => _employeeDrivingLog = value;
    }
  }
}
