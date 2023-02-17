using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog.Repository.TestData
{
  internal class RepositoryForTestData : MyTestData
  {
    public RepositoryForTestData()
    {
      _bizz = new TestDataHelperClass();
    }

    private readonly TestDataHelperClass _bizz;
    
    internal int CreateNewDrivingLogShortHanded(DrivingLogDto dto)
    {
      var drivinglogDtos = Persons
        //.Where(person => person.Id == dto.EmployeeId)
        .SelectMany(person => person.DrivingLogObj)
        .ToList();

      dto.Id = _bizz.GetNewId(drivinglogDtos.Select(x => x.Id).ToList());

      drivinglogDtos.Add(dto);

      return dto.Id;
      //throw new NotImplementedException();
    }

    internal int CreateNewDrivingLogWithForeach(DrivingLogDto dto)
    {
      var drivinglogDtos = new List<DrivingLogDto>();

      foreach (var person in Persons)
      {
        if (person.Id != dto.EmployeeId) continue;

        foreach (var log in person.DrivingLogObj)
        {
          drivinglogDtos.Add(log);
        }
      }

      dto.EmployeeId = _bizz.GetNewId(drivinglogDtos.Select(x => x.EmployeeId).ToList());

      drivinglogDtos.Add(dto);

      return dto.EmployeeId;
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
  }
}
