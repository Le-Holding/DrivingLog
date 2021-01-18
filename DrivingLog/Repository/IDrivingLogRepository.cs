using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog.Repository
{
  public interface IDrivingLogRepository
  {
    IList<EmployeeStamdataDto> GetDrivinglog();
    EmployeeStamdataDto GetDrivinglogById(int? id);
    void InsertDrivinglog(EmployeeStamdataDto dto);
    void UpdateDrivinglog(EmployeeStamdataDto dto);
    void DeleteDrivinglog(int id);
  }
}
