using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog.Repository.TestData
{
  public class TestDataHelperClass
  {
    internal List<DrivingLogDto> GetSubsetOfAListById(List<DrivingLogDto> value, int id)
    {
      var t = value.Where(x => x.EmployeeId == id).Select(x => x);
      return t.ToList();
    }
      
    internal int GetSumOfProduct(List<int> collection)
    {
      var result = 0;
      foreach (var item in collection)
      {
        result += item;
      }
      return result;
    }
    // Sætter summen for den samlede distancen
    internal void FindeAndSetTotalDrivedDistance(List<DrivingLogDto> EmployeeDrivingLog, List<EmployeeStamdataDto> dto)
    {
      EmployeeDrivingLog.ForEach(y => dto
        .Where(x => x.Id == y.EmployeeId)             //For hver medarbejder gruppere deres kørselslogs i en list. 
        .ToList()
        .ForEach(x => x.kilometerSum += y.Distance)); //For hver medarbejder/EmployeeStamdataDto.kilometerSum summer de kørte Distance 
    }

    internal int GetNewId(List<int> lists)
    {
      return lists.Max() + 1;
    }
  }
}
