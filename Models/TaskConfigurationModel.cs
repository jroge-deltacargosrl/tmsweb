namespace TMS_Web.Models
{
    public class TaskConfigurationModel
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public int state { get; set; }
        public string description { get; set; }
        public int allowDocuments { get; set; }
    }
}
