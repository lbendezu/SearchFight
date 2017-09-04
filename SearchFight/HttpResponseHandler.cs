using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace SearchFight
{
  public class HttpResponseHandler
  {
    public static T GetDeserializedObjectFromResponse<T>(HttpWebResponse response) where T : class
    {
      T deserializedObject = null;

      using (var streamReader = new StreamReader(response.GetResponseStream()))
      {
        string jsonRes = streamReader.ReadToEnd();
        deserializedObject = JsonConvert.DeserializeObject<T>(jsonRes);
      }

      return deserializedObject;
    }
  }
}