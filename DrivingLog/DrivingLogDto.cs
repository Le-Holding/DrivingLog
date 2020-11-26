using System;
using System.Collections.Generic;

namespace DrivingLog
{
  public class DrivingLogDto
  {
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public DateTime Date { get; set; }
    public string DriversTask { get; set; }
    public int Distance { get; set; }
  }
}