using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaeWynCouriersApp
{
    public class DataAccess
    {
        /// <summary>
        /// Retreives records as a dataset from the database using a given SQL query.
        /// </summary>
        /// <param name="sqlstr">SQL query as a string.</param>
        /// <returns>Database records as a DataSet.</returns>
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

        /// <summary>
        /// Generic execute command used to Insert or Update a single record in the database.
        /// </summary>
        /// <param name="sqlstr">SQL query as a string.</param>
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

        /// <summary>
        /// Generic call to the database to check if a record exists with the given SQL query.
        /// </summary>
        /// <param name="sqlstr">SQL query as a string.</param>
        /// <returns>Bool to confirm if the record exists.</returns>
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

        /// <summary>
        /// Counts the number of records in the database for the given SQL query.
        /// </summary>
        /// <param name="sqlstr">SQL query as a string.</param>
        /// <returns>Integer for the number of records.</returns>
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
