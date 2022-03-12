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
        public DataSet ImportDbRecords(string sqlstr)
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB")))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = mySQLCon;
                    command.CommandType = CommandType.Text;
                    command.CommandText = sqlstr;
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

        public int GetDbRecordCount(string sqlstr)
        {
            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = sqlstr;
                int recordCount = Convert.ToInt32(command.ExecuteScalar());

                mySQLCon.Close();

                return recordCount;
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }
    }
}
