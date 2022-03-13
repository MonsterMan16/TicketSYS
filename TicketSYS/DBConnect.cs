using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSYS
{
    class DBConnect
    {
        private static String oradb = "Data Source = 127.0.0.1:1521; User Id = C##T00213785; Password = 123123";

        public static String getOradb()
        {
            return oradb;
        }
    }
}
