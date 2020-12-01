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
    public DateTime Date { get; set; }
    public List<DrivingLogDto> KilometersPrTrip { get; set; }
    public int kilometersAbsValue { get; set; }
    public string Name { get; set; }
    public string LicensePlate { get; set; }
    public EmployeeStamdataDto DeepCopy { get; set; }
  }
}
