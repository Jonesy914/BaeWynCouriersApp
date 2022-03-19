using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    public class Client
    {
        public int ClientId { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public bool Contracted { get; set; }

        public Client()
        {
        }

        /// <summary>
        /// Adds a client record in the database for the current client object.
        /// </summary>
        public void AddClient()
        {
            DataAccess db = new DataAccess();
            string str=  "Insert Into Clients (BusinessName, Address, PhoneNumber, Email, Notes, Contracted) Values ('" + BusinessName + "', '" + Address + "', '" + PhoneNumber + "', '" + Email + "', '" + Notes + "', '" + Contracted + "')";
            db.UpdateDbRecord(str);
        }

        /// <summary>
        /// Updates the client record in the database for the current client object.
        /// </summary>
        public void UpdateClient()
        {
            DataAccess db = new DataAccess();
            string str = "Update Clients Set BusinessName = '" + BusinessName + "', Address = '" + Address + "', PhoneNumber = '" + PhoneNumber + "', Email = '" + Email + "', Notes = '" + Notes + "', Contracted = '" + Contracted + "' Where ClientId = " + ClientId;
            db.UpdateDbRecord(str);
        }
    }
}
