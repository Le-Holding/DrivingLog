using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog
{
  public class Model
  {
    public Model()
    {
      
      //SetTestDataForPropertyFieltKilometerAbsValue(Persons);
    }

    //public List<EmployeeStamdataDto> GetPersons()
    //{
    //  return Persons;
    //}
    //Dummmy Data for test
    public List<EmployeeStamdataDto> GetPersons()
    {
      var dto = new List<EmployeeStamdataDto>()
      {
        new EmployeeStamdataDto { Id = 1, Name = "Steve", LicensePlate = "CP86028", Date = new DateTime(2020, 08, 1), KilometersPrTrip = new List<DrivingLogDto>() },
          new EmployeeStamdataDto { Id = 2, Name = "Daniel", LicensePlate = "AR86028", Date = new DateTime(2020, 01, 1), KilometersPrTrip = new List<DrivingLogDto>()},
          new EmployeeStamdataDto { Id = 3, Name = "Jesper", LicensePlate = "BK08022", Date = new DateTime(2019, 05, 25), KilometersPrTrip = new List<DrivingLogDto>()},
          new EmployeeStamdataDto { Id = 4, Name = "Sara", LicensePlate = "BA09455", Date = new DateTime(2015, 12, 30), KilometersPrTrip = new List<DrivingLogDto>()}
      };

      dto.ForEach(x => x.DeepCopy = x.SetDeepCopy());

    return dto;
    }

    public List<DrivingLogDto> EmployeeDrivingLog { get; set; } = new List<DrivingLogDto>()
    {
      new DrivingLogDto {Id = 1, EmployeeId = 1, Date = DateTime.UtcNow,   Distance = 10,   DriversTask = "TEC Hvidovre"},
      new DrivingLogDto {Id = 2, EmployeeId = 1, Date = DateTime.Now,      Distance = 300,  DriversTask = "AU Aarhus"},
      new DrivingLogDto {Id = 3, EmployeeId = 1, Date = DateTime.UtcNow,   Distance = 96,   DriversTask = "Tec Ballerup"},
      new DrivingLogDto {Id = 4, EmployeeId = 2, Date = DateTime.Now,      Distance = 10,   DriversTask = "DTU Lyngby"},
      new DrivingLogDto {Id = 5, EmployeeId = 2, Date = DateTime.UtcNow,   Distance = 200,  DriversTask = "DTU Aarhus"},
      new DrivingLogDto {Id = 6, EmployeeId = 2, Date = DateTime.Now,      Distance = 100,  DriversTask = "Tec Ballerup"},
      new DrivingLogDto {Id = 7, EmployeeId = 3, Date = DateTime.UtcNow,   Distance = 400,  DriversTask = "AAU AAlBorg"},
      new DrivingLogDto {Id = 8, EmployeeId = 3, Date = DateTime.Now,      Distance = 1398, DriversTask = "Gardasøen Italien"},
      new DrivingLogDto {Id = 9, EmployeeId = 3, Date = DateTime.UtcNow,   Distance = 1216, DriversTask = "Paris"},
      new DrivingLogDto {Id = 10, EmployeeId = 4, Date = DateTime.Now,     Distance = 1895, DriversTask = "Rom"},
      new DrivingLogDto {Id = 11, EmployeeId = 4, Date = DateTime.UtcNow,  Distance = 1895, DriversTask = "Tec Ballerup"},
      new DrivingLogDto {Id = 12, EmployeeId = 4, Date = DateTime.Now,     Distance = 3006, DriversTask = "Málaga"},
    };

    private void SetTestDataForPropertyFieltKilometerAbsValue(List<EmployeeStamdataDto> persons)
    {
      foreach (var person in persons)
      {
        int abs_value = 0;
        person.KilometersPrTrip.AddRange(EmployeeDrivingLog);


        //foreach (var Trip in p)
        //{
        //  abs_value += Trip.Distance;
        //}

        person.kilometersAbsValue = abs_value;
      }
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

    public void DeleteEmployee(int id) 
    { 
    
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
  }
}
