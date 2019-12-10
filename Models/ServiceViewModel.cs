using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMS_Web.Models
{
    public class ServiceViewModel
    {
        public string companyName { get; set; }
        public List<ServiceModel> serviceList { get; set; }
    }
}
