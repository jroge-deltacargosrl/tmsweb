using RestSharp;
using System.Collections.Generic;
using TMS_Web.Models.API;

namespace TMS_Web.Models.DAL
{
    public class CompanyDAL
    {
        private static string urlRequest = "http://deltacargoapi.azurewebsites.net/api/v1/";

        public static List<CompanyModel> getAll()
        {
            var response = new RequestAPI()
                        .addClient(new RestClient(urlRequest))
                        .addRequest(new RestRequest("membership", Method.GET, DataFormat.Json))
                        .addHeader(new KeyValuePair<string, object>("Accept", "application/json"))
                        .buildRequest();
            return RequestAPI.deserilizeProject<List<CompanyModel>>(response);
        }
    }
}
