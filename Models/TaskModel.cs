using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMS_Web.Models
{
    public class TaskModel
    {
        public int id { get; set; }
        public string kanbanState { get; set; }
        public string name { get; set; }
        public DateTime date_start { get; set; }
        public int projectId { get; set; }
        public int stageId { get; set; }
        public bool canUpload { get; set; }
        public bool uploaded { get; set; }
        public string format { get; set; }
    }
}
