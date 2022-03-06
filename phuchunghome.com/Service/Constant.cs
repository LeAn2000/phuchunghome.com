using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace phuchunghome.com.Service
{
    public class Constant
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["DBphuchung"].ConnectionString;
    }
}