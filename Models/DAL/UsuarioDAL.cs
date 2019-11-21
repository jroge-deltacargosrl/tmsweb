using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMS_Web.Models.API;

namespace TMS_Web.Models.DAL
{
    public class UsuarioDAL
    {

        public static List<UsuarioModel> getAll()
        {
            string urlRequest = "http://deltacargoapi.azurewebsites.net/api/v1/";
            var response = new RequestAPI()
                        .addClient(new RestClient(urlRequest))
                        .addRequest(new RestRequest("user/", Method.GET, DataFormat.Json))
                        .addHeader(new KeyValuePair<string, object>("Accept", "application/json"))
                        .buildRequest();
            return RequestAPI.deserilizeProject<List<UsuarioModel>>(response);
        }




    }
}
