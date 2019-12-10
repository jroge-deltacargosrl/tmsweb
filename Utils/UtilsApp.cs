using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMS_Web.Utils
{
    public class UtilsApp
    {
        public static string URL_BASE { get; private set; }

        public static void initVarEnviroment(string environment)
        {
            switch (environment)
            {
                case "developing":
                    URL_BASE = "https://localhost:44333/api/v1/";
                    break;
                case "local production":
                    //URL_BASE = "http://deltacargoapi.azurewebsites.net/api/v1";
                    break;
                case "cloud production":
                    URL_BASE = "http://deltacargoapi.azurewebsites.net/api/v1";
                    break;
            }
        }

        public static bool isNull<T>(T obj) => obj == null;
    }
}
