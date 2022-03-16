using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
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

        //[Fact]
        //public void Calc_Test()
        //{
        //    double expected = 5;

        //    User testUser = new User();
        //    double actual = testUser.calc(2, 3);

        //    Assert.Equal(expected, actual);
        //}

        [Fact]
        public void CheckDbRecord_True()
        {
            string sqlstr = "Select * From Deliveries Where DeliveryId = 1";
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<DataAccess>()
                    .Setup(x => x.CheckDbRecord(sqlstr))
                    .Returns(true);

                var cls = mock.Create<DataAccess>();

                var expected = true;
                var actual = cls.CheckDbRecord(sqlstr);

                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void LoadMenuItems_ValidCall()
        {
            //using(var mock = AutoMock.GetLoose())
            //{
            //    mock.Mock<DataAccess>()
            //        .Setup(x => x.CheckDbRecord(str))
            //        .Returns(true);
            //}
            List<MenuItem> expected = GetMenuItemsTest();

            User testUser = new User();
            List<MenuItem> actual = testUser.GetMenuItemsByAccessLevel();

            Assert.Equal(expected, actual);
        }

        public List<MenuItem> GetMenuItemsTest()
        {
            List<MenuItem> output = new List<MenuItem>
            {
                new MenuItem
                {
                    MenuItemId = 1,
                    Name = "Clients",
                    AccessLevel = 2
                },
                new MenuItem
                {
                    MenuItemId = 2,
                    Name = "Deliveries",
                    AccessLevel = 4
                },
                new MenuItem
                {
                    MenuItemId = 3,
                    Name = "Reports",
                    AccessLevel = 3
                }
            };
            return output;
        }
    }
}
