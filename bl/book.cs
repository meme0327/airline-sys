using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparkling_Skies.bl
{
    class book
    {
        public static void tobook(string from, string to, string classdetails, string trip_type, int no_of_pass)
        {

            ado.ExecuteNonQuery("Login",

             ado.CreateParameters("@from", System.Data.SqlDbType.NVarChar, from),
             ado.CreateParameters("@to", System.Data.SqlDbType.NVarChar, to),
             ado.CreateParameters("@classdetails", System.Data.SqlDbType.NVarChar, classdetails),
             ado.CreateParameters("@trip_type", System.Data.SqlDbType.NVarChar, trip_type),
             ado.CreateParameters("@no_of_pass", System.Data.SqlDbType.Int, no_of_pass)

                );

        }

    }
}
