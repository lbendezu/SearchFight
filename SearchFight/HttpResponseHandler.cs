using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace SearchFight
{
  public class HttpResponseHandler
  {
    public static T GetDeserializedObjectFromResponse<T>(HttpWebResponse response) where T : class
    {
      T dto = null;

      using (var streamReader = new StreamReader(response.GetResponseStream()))
      {
        string jsonRes = streamReader.ReadToEnd();
        dto = (T)JsonConvert.DeserializeObject(jsonRes);
      }

      return dto;
    }
  }
}