using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SondosGlasses
{
    /*Help Doc:
        conniction sql:
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        
    */
    
    public static class Globals
    {
        //User Info:
        public static string User = "";
        public static int UType ;

        //Customer Info:
        public static string CID;
        public static string CN;
        public static string CA;
        public static string CP;

    }
}
