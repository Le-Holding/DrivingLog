using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
//using System.serialization;

namespace DrivingLog
{
  public class EmployeeStamdataDto
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public List<DrivingLogDto> DrivingLogObj { get; set; }
    public int kilometerSum { get; set; }
    public string LicensePlate { get; set; }
    public EmployeeStamdataDto DeepCopy { get; set; }
  }
}
