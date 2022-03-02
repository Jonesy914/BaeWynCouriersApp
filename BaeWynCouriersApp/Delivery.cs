using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    class Delivery
    {
        public int DeliveryId { get; set; }
        public int ClientId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int TimeBlockId { get; set; }
        public int UserId { get; set; }
        public int StatusCodeId { get; set; }

        Delivery()
        {
        }
    }
}
