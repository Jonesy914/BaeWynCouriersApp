using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    public class ReportsLogic
    {
        /// <summary>
        /// Business logic to calculate monthly value of individual client contracts.
        /// </summary>
        /// <param name="count">Number of client contracts.</param>
        /// <returns>Double for the value of current client contracts.</returns>
        public double ClientValue(int count)
        {
            return count * 50;
        }

        /// <summary>
        /// Business logic to calculate the value of contracted deliveries.
        /// </summary>
        /// <param name="count">Number of contracted deliveries.</param>
        /// <returns>Double for the value of contracted deliveries.</returns>
        public double ContractDeliveryValue(int count)
        {
            return count * 2.5;
        }

        /// <summary>
        /// Business logic to calculate the value of non-contracted deliveries.
        /// </summary>
        /// <param name="count">Number of non-contracted deliveries.</param>
        /// <returns>Double for the value of non-contracted deliveries.</returns>
        public double NonContractDeliveryValue(int count)
        {
            return count * 10;
        }

        /// <summary>
        /// Calculates sum of all Month's Client Value figures.
        /// </summary>
        /// <param name="clientCount">Value of current client contracts.</param>
        /// <param name="contractCount">Value of contracted deliveries.</param>
        /// <param name="nonContractCount">Value of non-contracted deliveries.</param>
        /// <returns>Double for the sum of all inputted figures</returns>
        public double TotalMonthValue(int clientCount, int contractCount, int nonContractCount)
        {
            return ClientValue(clientCount) + ContractDeliveryValue(contractCount) + NonContractDeliveryValue(nonContractCount);
        }
    }
}
