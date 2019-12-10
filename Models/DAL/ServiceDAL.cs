using RestSharp;
using System;
using System.Collections.Generic;
using TMS_Web.Models.API;

namespace TMS_Web.Models.DAL
{
    public class ServiceDAL
    {
        private static string urlRequest = "http://deltacargoapi.azurewebsites.net/api/v1/";

        public static List<ServiceModel> getAll()
        {
            var response = new RequestAPI()
                        .addClient(new RestClient(urlRequest))
                        .addRequest(new RestRequest("service", Method.GET, DataFormat.Json))
                        .addHeader(new KeyValuePair<string, object>("Accept", "application/json"))
                        .buildRequest();
            return RequestAPI.deserilizeProject<List<ServiceModel>>(response);
        }

        public static List<ServiceViewModel> getByCompany()
        {
            List<ServiceViewModel> listCompanyService = new List<ServiceViewModel>();
            List<CompanyModel> companyList = CompanyDAL.getAll();
            foreach (CompanyModel company in companyList)
            {
                string nameCompany = company.company;
                var response = new RequestAPI()
                            .addClient(new RestClient(urlRequest))
                            .addRequest(new RestRequest("service/{nameCompany}", Method.GET, DataFormat.Json))
                            .addHeader(new KeyValuePair<string, object>("Accept", "application/json"))
                            .addBodyData(nameCompany)
                            .buildRequest();
                listCompanyService.Add(new ServiceViewModel()
                {
                    companyName = nameCompany,
                    serviceList = RequestAPI.deserilizeProject<List<ServiceModel>>(response)
                });
            }
            return listCompanyService;
        }
    }
}
