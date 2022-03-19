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

        /// <summary>
        /// Adds a delivery record in the database for the current delivery object.
        /// </summary>
        public void AddDelivery()
        {
            DataAccess db = new DataAccess();
            string str = "Insert Into Deliveries (ClientId, DeliveryDate, TimeBlockId, UserId, StatusCode) Values (" + ClientId + ", '" + DeliveryDate.ToString("yyyy-MM-dd") + "', " + TimeBlockId + ", " + UserId + ", '" + StatusCode + "')";
            db.UpdateDbRecord(str);
        }

        /// <summary>
        /// Update the delivery record in the database for the current delivery object.
        /// </summary>
        public void UpdateDelivery()
        {
            DataAccess db = new DataAccess();
            string str = "Update Deliveries Set ClientId = " + ClientId + ", DeliveryDate = '" + DeliveryDate.ToString("yyyy-MM-dd") + "', TimeBlockId = " + TimeBlockId + ", UserId = " + UserId + " Where DeliveryId = " + DeliveryId;
            db.UpdateDbRecord(str);
        }

        /// <summary>
        /// Specifically updates the StatusCode for a Delivery record.
        /// </summary>
        public void UpdateDeliveryStatus()
        {
            DataAccess db = new DataAccess();
            string str = "Update Deliveries Set StatusCode = '" + StatusCode + "' Where DeliveryId = " + DeliveryId;
            db.UpdateDbRecord(str);
        }

        /// <summary>
        /// Checks database table Deliveries to see if a record exists with inputted details. Current record excluded from query if isUpdate set as true.
        /// </summary>
        /// <param name="isUpdate">Determines which SQL query to use.</param>
        /// <returns>Bool depending on delivery record existing.</returns>
        public  bool CheckDeliveryExists(bool isUpdate)  
        {
            DataAccess db = new DataAccess();
            string str;

            if (isUpdate)
            {
                //Check if active delivery record exists for chosen date, time slot and user.
                str = "Select * From Deliveries Where DeliveryDate = '" + DeliveryDate.ToString("yyyy-MM-dd") + "' and TimeBlockId = " + TimeBlockId + " and UserId = " + UserId + " and StatusCode Not In ('C', 'X') and DeliveryId <> " + DeliveryId;
            }
            else
            {
                //Simliar to CheckDeliveryEXists but excludes current DeliveryId to allow ClientId to be changed when other criteria stays the same.
                str = "Select * From Deliveries Where DeliveryDate = '" + DeliveryDate.ToString("yyyy-MM-dd") + "' and TimeBlockId = " + TimeBlockId + " and UserId = " + UserId + " and StatusCode Not In ('C', 'X')";
            }
            bool check = db.CheckDbRecord(str);

            return check;
        }

        /// <summary>
        /// Joins TimeBlocks and Users tables to check if the LunchBlock field is the same for the chosen criteria
        /// </summary>
        /// <returns>Bool confirming if record exists.</returns>
        public bool CheckUserLunch()
        {
            DataAccess db = new DataAccess();
            string str = "Select * From TimeBlocks As T Inner Join Users As U On T.LunchBlock = U.LunchBlock Where T.TimeBlockId = " + TimeBlockId + " and U.UserId = " + UserId;
            bool check = db.CheckDbRecord(str);

            return check;
        }
    }
}
