using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DAL
{
    public class DataConn
    {
        public SqlConnection GetConn()
        {
         return new SqlConnection(@"Data Source=DESKTOP-A5IM9JU\SQLEXPRESS;Initial Catalog=sellnotes;Integrated Security=True;");
       //return new SqlConnection(@"Data Source=WIN-TPT54T88F78\SQLEXPRESS;Initial Catalog=sellnotes;User ID=sa;Password=admin@123;");
        }
    }
}
