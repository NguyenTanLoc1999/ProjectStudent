using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProjectStudent.Model
{
    public class ProjectManagement
    {
        public int P_ID { get; set; }
        public string P_title { get; set; }
        public string P_description { get; set; }
        public DateTime P_fromtime { get; set; }
        public DateTime P_totime { get; set; }

    }
}
