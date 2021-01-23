using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog.Repository
{
  public interface IEmployeeRepository
  {
    IList<EmployeeStamdataDto> GetEmployees();
    EmployeeStamdataDto GetEmployeeById(int? id);
    void InsertNewEmployee(EmployeeStamdataDto dto);
    void UpdateEmployee(EmployeeStamdataDto dto);
    void DeleteEmployee(int id);
  }
}
