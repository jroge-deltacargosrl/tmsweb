using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using static TMS_Web.Utils.UtilsApp;

namespace TMS_Web.Utils
{
    public static class SessionExtensions
    {
        public static void setObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T getObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return isNull(value) ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
