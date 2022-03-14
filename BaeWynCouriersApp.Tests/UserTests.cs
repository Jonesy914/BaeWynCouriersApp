using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaeWynCouriersApp;
using Xunit;

namespace BaeWynCouriersApp.Tests
{
    public class UserTests
    {
        [Fact]
        public void Login_ValidUser()
        {
            bool expected = true;

            User testUser = new User();
            testUser.Name = "John Smith";
            testUser.Password = "password123";

            bool actual = testUser.Login();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Calc_Test()
        {
            double expected = 5;

            User testUser = new User();
            double actual = testUser.calc(2, 3);

            Assert.Equal(expected, actual);
        }

    }
}
