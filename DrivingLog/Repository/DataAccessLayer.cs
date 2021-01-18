using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLog.Repository
{
  public class DataAccessLayer
  {
    MySqlConnection _data;
    public DataAccessLayer()
    {
      _data = new MySqlConnection();
    }

    public DrivingLogDto SaveDrivingRecord(DrivingLogDto dto)
    {
      var id = _data.InsertDrivingRevord(dto);
      dto.Id = id;
      return dto;
    }
  }
}
