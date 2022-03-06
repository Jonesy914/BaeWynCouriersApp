using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public string StatusCode { get; set; }

        public Delivery()
        {
        }

        public bool CheckDeliveryExistsAdd()
        {
            bool check = false;

            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * From Deliveries Where DeliveryDate = '" + DeliveryDate + "' and TimeBlockId = " + TimeBlockId + " and UserId = " + UserId;
                SqlDataReader SqlDr = command.ExecuteReader();

                if (SqlDr.HasRows)
                {
                    check = true;
                }

                mySQLCon.Close();

                return check;
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }

        public bool CheckDeliveryExistsUpdate() //Record needs to not check for itself to allow Client Id to be changed when other criteria stays the same.
        {
            bool check = false;

            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * From Deliveries Where DeliveryDate = '" + DeliveryDate + "' and TimeBlockId = " + TimeBlockId + " and UserId = " + UserId + " and DeliveryId <> " + DeliveryId;
                SqlDataReader SqlDr = command.ExecuteReader();

                if (SqlDr.HasRows)
                {
                    check = true;
                }

                mySQLCon.Close();

                return check;
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }

        public bool CheckUserLunch()
        {
            bool check = false;

            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * From TimeBlocks As T Inner Join Users As U On T.LunchBlock = U.LunchBlock Where T.TimeBlockId = " + TimeBlockId + " and U.UserId = " + UserId;
                SqlDataReader SqlDr = command.ExecuteReader();

                if (SqlDr.HasRows)
                {
                    check = true;
                }

                mySQLCon.Close();

                return check;
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }
    }
}
