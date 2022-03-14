using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    public class TimeBlock
    {
        public int TimeBlockId { get; set; }
        public string BlockDetail { get; set; }
        public int LunchBlock { get; set; }

        TimeBlock()
        {
        }
    }
}
