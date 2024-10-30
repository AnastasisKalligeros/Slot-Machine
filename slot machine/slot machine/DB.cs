using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace slot_machine
{
    class DB
    {
        public SQLiteConnection myconn;
        public DB()
        {
            myconn = new SQLiteConnection("Data SOurce=db1.db");
        }

    }
}
