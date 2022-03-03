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
        public void AddClient(string businessName, string address, string phoneNumber, string email, string notes, bool contracted)
        {
            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = "Insert Into Client (BusinessName, Address, PhoneNumber, Email, Notes, Contracted) Values ('" + businessName + "', '" + address + "', '" + phoneNumber + "', '" + email + "', '" + notes + "', " + contracted + ")";
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
