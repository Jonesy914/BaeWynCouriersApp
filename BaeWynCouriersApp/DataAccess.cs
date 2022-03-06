using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    class DataAccess
    {
        public DataSet ImportDbRecords(string TableName)
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB")))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = mySQLCon;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "Select * From " + TableName;
                    using (SqlDataAdapter SqlDa = new SqlDataAdapter(command))
                    {
                        SqlDa.Fill(ds);
                    }
                }
                return ds;
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }

        public void AddClient(Client newClient)
        {
            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = "Insert Into Clients (BusinessName, Address, PhoneNumber, Email, Notes, Contracted) Values ('" + newClient.BusinessName + "', '" + newClient.Address + "', '" + newClient.PhoneNumber + "', '" + newClient.Email + "', '" + newClient.Notes + "', '" + newClient.Contracted + "')";
                command.ExecuteNonQuery();
                
                mySQLCon.Close();
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }

        public void UpdateClient(Client currClient)
        {
            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = "Update Clients Set BusinessName = '" + currClient.BusinessName + "', Address = '" + currClient.Address + "', PhoneNumber = '" + currClient.PhoneNumber + "', Email = '" + currClient.Email + "', Notes = '" + currClient.Notes + "', Contracted = '" + currClient.Contracted + "' Where ClientId = " + currClient.ClientId;
                command.ExecuteNonQuery();

                mySQLCon.Close();
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }

        public DataSet GetAllCouriers()
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB")))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = mySQLCon;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "Select * From Users Where AccessLevel = 4";
                    using (SqlDataAdapter SqlDa = new SqlDataAdapter(command))
                    {
                        SqlDa.Fill(ds);
                    }
                }
                return ds;
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }

        public void AddDelivery(Delivery newDelivery)
        {
            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = "Insert Into Deliveries (ClientId, DeliveryDate, TimeBlockId, UserId, StatusCodeId) Values (" + newDelivery.ClientId + ", '" + newDelivery.DeliveryDate + "', " + newDelivery.TimeBlockId + ", " + newDelivery.UserId + ", '" + newDelivery.StatusCodeId + "')";
                command.ExecuteNonQuery();

                mySQLCon.Close();
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }
    }
}
