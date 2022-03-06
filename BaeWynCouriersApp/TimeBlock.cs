using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    class TimeBlock
    {
        public int TimeBlockId { get; set; }
        public string BlockDetail { get; set; }
        public int LunchBlock { get; set; }

        TimeBlock()
        {
        }

        public DataSet GetTimeBlocks()
        {
            DataAccess db = new DataAccess();

            try
            {
                DataSet dsTimeBlocks = db.ImportDbRecords("TimeBlocks");
                return dsTimeBlocks;
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }
    }
}
