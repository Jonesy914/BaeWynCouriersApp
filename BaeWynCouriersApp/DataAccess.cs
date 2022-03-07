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

        public void UpdateDbRecord(string sqlstr)
        {
            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = sqlstr;
                command.ExecuteNonQuery();

                mySQLCon.Close();
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }

        public bool CheckDbRecord(string sqlstr)
        {
            bool check = false;

            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = sqlstr;
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

        public DataSet GetCourierDeliveries(int userId)
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB")))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = mySQLCon;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "Select * From Deliveries Where UserId = " + userId + " and StatusCode In ('A', 'U')";
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
    }
}
