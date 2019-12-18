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
            string fileName = "./DB/MrCy.db;";
            SQLiteConnection conn = new SQLiteConnection("Data Source="+fileName);
            return conn;
        }
        
    }
}


