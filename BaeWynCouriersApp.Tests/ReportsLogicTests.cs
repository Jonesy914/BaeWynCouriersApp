using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BaeWynCouriersApp.Tests
{
    public class ReportsLogicTests
    {
        [Fact]
        public void ClientValue_ForTwoClients()
        {
            double expected = 100;

            ReportsLogic testReport = new ReportsLogic();
            double actual = testReport.ClientValue(2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ContractDeliveryValue_ForTenContractDeliveries()
        {
            double expected = 25;

            ReportsLogic testReport = new ReportsLogic();
            double actual = testReport.ContractDeliveryValue(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NonContractDeliveryValue_ForFourNonContractDeliveries()
        {
            double expected = 40;

            ReportsLogic testReport = new ReportsLogic();
            double actual = testReport.NonContractDeliveryValue(4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TotalMonthValue_ForTotalWorthOf165()
        {
            double expected = 165;

            ReportsLogic testReport = new ReportsLogic();
            double actual = testReport.TotalMonthValue(2, 10, 4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ClientValue_IncorrectValue()
        {
            double expected = 50;

            ReportsLogic testReport = new ReportsLogic();
            double actual = testReport.ClientValue(2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ContractDeliveryValue_IncorrectValue()
        {
            double expected = 5;

            ReportsLogic testReport = new ReportsLogic();
            double actual = testReport.ContractDeliveryValue(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NonContractDeliveryValue_IncorrectValue()
        {
            double expected = 30;

            ReportsLogic testReport = new ReportsLogic();
            double actual = testReport.NonContractDeliveryValue(4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TotalMonthValue_IncorrectValue()
        {
            double expected = 25;

            ReportsLogic testReport = new ReportsLogic();
            double actual = testReport.TotalMonthValue(2, 1, 0);

            Assert.Equal(expected, actual);
        }
    }
}
