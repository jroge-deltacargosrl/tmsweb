using RestSharp;
using System;
using System.Collections.Generic;
using TMS_Web.Models.API;

namespace TMS_Web.Models.DAL
{
    public class UserDAL
    {
        private static string urlRequest = "http://deltacargoapi.azurewebsites.net/api/v1/";

        public static List<UsuarioModel> getAll()
        {
            var response = new RequestAPI()
                        .addClient(new RestClient(urlRequest))
                        .addRequest(new RestRequest("user/", Method.GET, DataFormat.Json))
                        .addHeader(new KeyValuePair<string, object>("Accept", "application/json"))
                        .buildRequest();
            return RequestAPI.deserilizeProject<List<UsuarioModel>>(response);
        }

        public static List<UsuarioModel> refreshUsers(UsuarioModel userToUpdate)
        {
            var response = new RequestAPI()
                        .addClient(new RestClient(urlRequest))
                        .addRequest(new RestRequest("user/updatePrivileges", Method.PUT, DataFormat.Json))
                        .addHeader(new KeyValuePair<string, object>("Accept", "application/json"))
                        .addBodyData(userToUpdate)
                        .buildRequest();
            UsuarioModel userRefreshed = RequestAPI.deserilizeProject<UsuarioModel>(response);
            return getAll();
        }

        public static List<UsuarioModel> sendPassword(int userId)
        {
            var response = new RequestAPI()
                        .addClient(new RestClient(urlRequest))
                        .addRequest(new RestRequest("user/firstPassword/{userId}", Method.PUT, DataFormat.Json))
                        .addHeader(new KeyValuePair<string, object>("Accept", "application/json"))
                        .addUrlSegmentParam(new KeyValuePair<string, object> ("userId",userId))
                        .buildRequest();
            UsuarioModel userRefreshed = RequestAPI.deserilizeProject<UsuarioModel>(response);
            return getAll();
        }
    }
}
