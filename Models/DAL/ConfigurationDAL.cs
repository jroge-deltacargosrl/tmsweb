using RestSharp;
using System;
using System.Collections.Generic;
using TMS_Web.Models.API;

namespace TMS_Web.Models.DAL
{
    public class ConfigurationDAL
    {
        private static string urlRequest = "http://deltacargoapi.azurewebsites.net/api/v1/";

        public static void sincronizeOdooContacts()
        {
            var response = new RequestAPI()
                        .addClient(new RestClient(urlRequest))
                        .addRequest(new RestRequest("contact/sync", Method.GET, DataFormat.Json))
                        .addHeader(new KeyValuePair<string, object>("Accept", "application/json"))
                        .buildRequest();
            //return RequestAPI.deserilizeProject<OdooResponse>(response);
        }
    }
}
