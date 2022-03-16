using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    public class Helper
    {       
        public static string CnnVal(string name)
        {
            string conStr = ConfigurationManager.ConnectionStrings[name].ConnectionString; //Referenced from https://www.youtube.com/watch?v=Et2khGnrIqc;
            return conStr;
        }
    }
}
