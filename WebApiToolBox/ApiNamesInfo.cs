using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiToolBox
{
    public class ApiNamesInfo
    {
        public ApiNamesInfo()
        {
            ApiNames = new Dictionary<string, List<string>>();
        }
        public Dictionary<string, List<string>> ApiNames { get; set; } 
    }

}
