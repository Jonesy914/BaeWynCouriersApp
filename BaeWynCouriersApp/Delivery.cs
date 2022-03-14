using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public int ClientId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int TimeBlockId { get; set; }
        public int UserId { get; set; }
        public string StatusCode { get; set; }

        public Delivery()
        {
        }

        public void AddDelivery()
        {
            DataAccess db = new DataAccess();
            string str = "Insert Into Deliveries (ClientId, DeliveryDate, TimeBlockId, UserId, StatusCode) Values (" + ClientId + ", '" + DeliveryDate.ToString("yyyy-MM-dd") + "', " + TimeBlockId + ", " + UserId + ", '" + StatusCode + "')";
            db.UpdateDbRecord(str);
        }

        public void UpdateDelivery()
        {
            DataAccess db = new DataAccess();
            string str = "Update Deliveries Set ClientId = " + ClientId + ", DeliveryDate = '" + DeliveryDate.ToString("yyyy-MM-dd") + "', TimeBlockId = " + TimeBlockId + ", UserId = " + UserId + " Where DeliveryId = " + DeliveryId;
            db.UpdateDbRecord(str);
        }

        public void UpdateDeliveryStatus()
        {
            DataAccess db = new DataAccess();
            string str = "Update Deliveries Set StatusCode = '" + StatusCode + "' Where DeliveryId = " + DeliveryId;
            db.UpdateDbRecord(str);
        }

        public  bool CheckDeliveryExists()
        {
            DataAccess db = new DataAccess();
            string str = "Select * From Deliveries Where DeliveryDate = '" + DeliveryDate.ToString("yyyy-MM-dd") + "' and TimeBlockId = " + TimeBlockId + " and UserId = " + UserId;
            bool check = db.CheckDbRecord(str);

            return check;
        }

        public bool CheckDeliveryExistsUpdate() //Record needs to not check for itself to allow Client Id to be changed when other criteria stays the same.
        {
            DataAccess db = new DataAccess();
            string str = "Select * From Deliveries Where DeliveryDate = '" + DeliveryDate.ToString("yyyy-MM-dd") + "' and TimeBlockId = " + TimeBlockId + " and UserId = " + UserId + " and DeliveryId <> " + DeliveryId;
            bool check = db.CheckDbRecord(str);

            return check;
        }

        public bool CheckUserLunch()
        {
            DataAccess db = new DataAccess();
            string str = "Select * From TimeBlocks As T Inner Join Users As U On T.LunchBlock = U.LunchBlock Where T.TimeBlockId = " + TimeBlockId + " and U.UserId = " + UserId;
            bool check = db.CheckDbRecord(str);

            return check;
        }
    }
}
