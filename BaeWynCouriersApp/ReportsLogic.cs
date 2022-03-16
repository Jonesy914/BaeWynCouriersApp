using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    public class ReportsLogic
    {
        public int AllClientCount { get; set; }
        public int DelConCount { get; set; }
        public int DelNonCount { get; set; }


        public double ClientValue(int count)
        {
            return count * 50;
        }

        public double ContractDeliveryValue(int count)
        {
            return count * 2.5;
        }

        public double NonContractDeliveryValue(int count)
        {
            return count * 10;
        }

        public double TotalMonthValue(int clientCount, int contractCount, int nonContractCount)
        {
            return ClientValue(clientCount) + ContractDeliveryValue(contractCount) + NonContractDeliveryValue(nonContractCount);
        }
    }
}
