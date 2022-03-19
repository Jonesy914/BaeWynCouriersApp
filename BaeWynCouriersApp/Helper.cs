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
        /// <summary>
        /// Retrieves the connection string of the chosen database using its App.config name.
        /// </summary>
        /// <param name="name">Name given to the data source's connection string.</param>
        /// <returns>String for the connection string.</returns>
        public static string CnnVal(string name)
        {
            string conStr = ConfigurationManager.ConnectionStrings[name].ConnectionString; //Referenced from https://www.youtube.com/watch?v=Et2khGnrIqc;
            return conStr;
        }
    }
}
