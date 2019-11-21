using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

namespace MrCy.BaseClass
{
    class DBConn
    {
        public static SQLiteConnection CyCon()
        {
            string fileName = "./DB/MrCy.db";
            SQLiteConnection conn = new SQLiteConnection("Data Source="+fileName);
            /*SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=MrCy;User Id=ying;Password=newman123;");*/
            return conn;
        }
        
    }
}
