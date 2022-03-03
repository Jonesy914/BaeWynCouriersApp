using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BaeWynCouriersApp
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        private string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int AccessLevel { get; set; }
        public int LunchBlock { get; set; }

        public bool Login()
        {
            bool userCheck = false;

            try
            {
                SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB"));
                mySQLCon.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = mySQLCon;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * From Users Where Name = '" + Name + "' and Password = '" + Password + "'";               
                SqlDataReader SqlDr = command.ExecuteReader();

                if (!SqlDr.HasRows)
                {
                    userCheck = false;
                }
                else
                {
                    userCheck = true;

                    SqlDr.Read();
                    UserId = (int)SqlDr[0];
                    Name = SqlDr[1].ToString();
                    //Password = SqlDr[2].ToString();
                    PhoneNumber = SqlDr[3].ToString();
                    EmailAddress = SqlDr[4].ToString();
                    AccessLevel = (int)SqlDr[5];
                    LunchBlock = (int)SqlDr[6];
                }
                mySQLCon.Close();            
            
                return userCheck;
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }

        public List<MenuItem> GetMenuItemsByAccessLevel()
        {

            DataSet ds = new DataSet();
            List<MenuItem> lstMenuItems = new List<MenuItem>();

            try
            {
                using (SqlConnection mySQLCon = new SqlConnection(Helper.CnnVal("BaeWynDB")))
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = mySQLCon;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "Select * From MenuItems Where AccessLevel >= " + AccessLevel;
                    using (SqlDataAdapter SqlDa = new SqlDataAdapter(command))
                    {
                        SqlDa.Fill(ds);
                        if(ds != null)
                        {
                            lstMenuItems = ds.Tables[0].AsEnumerable().Select(
                                dataRow => new MenuItem
                                {
                                    MenuItemId = dataRow.Field<int>("MenuItemId"),
                                    Name = dataRow.Field<string>("Name"),
                                    AccessLevel = dataRow.Field<int>("AccessLevel")
                                }).ToList();
                        }
                    }
                }
                return lstMenuItems;
            }
            catch (Exception)
            {
                throw;  //Any errors are caught and thrown up the stack.
            }
        }
    }
}
