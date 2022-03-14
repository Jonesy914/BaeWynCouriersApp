using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaeWynCouriersApp;
using Xunit;
using System.Data;
using System.Data.SqlClient;

namespace BaeWynCouriersApp.Tests
{
    public class HelperTest
    {
        [Fact]
        public static void Helper_GetConnString()
        {
            string expected = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\SoftwareEngineering\BaeWynCouriers\BaeWynDatabase\BaeWynDatabase\BaeWynDB.mdf;Integrated Security=True;Connect Timeout=30";

            string actual = Helper.CnnVal("BaeWynDB").Trim();
            
            Assert.Equal(expected, actual);
        }
    }
}
