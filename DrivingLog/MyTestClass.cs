using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DrivingLog
{
  public static class MyTestClass
  {
    public static T DeepCopy<T>(T obj)
    {
      if (!typeof(T).IsSerializable)
      {
        throw new Exception("The source object must be serializable");
      }

      if (Object.ReferenceEquals(obj, null))
      {
        throw new Exception("The source object must not be null");
      }

      T result = default(T);

      using (var memoryStream = new MemoryStream())
      {
        var formatter = new BinaryFormatter();
        formatter.Serialize(memoryStream, obj);
        memoryStream.Seek(0, SeekOrigin.Begin);
        result = (T)formatter.Deserialize(memoryStream);
        memoryStream.Close();
      }
      return result;
    }

    public static T SetDeepCopy<T>(this T dto)
    {
      var json = new JavaScriptSerializer().Serialize(dto);
      //DeepCopy = JsonConvert.DeserializeObject<EmployeeStamdataDto>(dto.toJson());

      var temp = JsonConvert.DeserializeObject<T>(json);

      return temp;
      System.Diagnostics.Debug.WriteLine(json);
      System.Diagnostics.Debug.WriteLine(temp);
    }

    public static void MyJoinSelect()
    {
    //var myguery
    //https://docs.microsoft.com/en-us/dotnet/api/system.web.script.serialization.javascriptserializer?redirectedfrom=MSDN&view=netframework-4.8
    }
  }
}
