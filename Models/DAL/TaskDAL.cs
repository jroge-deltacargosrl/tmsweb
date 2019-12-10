using RestSharp;
using System.Collections.Generic;
using TMS_Web.Models.API;

namespace TMS_Web.Models.DAL
{
    public class TaskDAL
    {
        private static string urlRequest = "http://deltacargoapi.azurewebsites.net/api/v1/";

        public static List<TaskConfigurationModel> getAll()
        {
            var response = new RequestAPI()
                        .addClient(new RestClient(urlRequest))
                        .addRequest(new RestRequest("taskConfiguration/", Method.GET, DataFormat.Json))
                        .addHeader(new KeyValuePair<string, object>("Accept", "application/json"))
                        .buildRequest();
            return RequestAPI.deserilizeProject<List<TaskConfigurationModel>>(response);
        }

        public static List<TaskConfigurationModel> refreshTasks(TaskConfigurationModel taskToUpdate)
        {
            var response = new RequestAPI()
                        .addClient(new RestClient(urlRequest))
                        .addRequest(new RestRequest("taskConfiguration/updateAllowDocsAndDisplayClient", Method.PUT, DataFormat.Json))
                        .addHeader(new KeyValuePair<string, object>("Accept", "application/json"))
                        .addBodyData(taskToUpdate)
                        .buildRequest();
            TaskConfigurationModel userRefreshed = RequestAPI.deserilizeProject<TaskConfigurationModel>(response);
            return getAll();
        }
    }
}
