using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MrCy.BaseClass
{
    class DBConn
    {
        public static SqlConnection CyCon()
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=MrCy;User Id=ying;Password=newman123;");
            return conn;
        }
        
    }
}
