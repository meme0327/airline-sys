using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Sparkling_Skies.bl
{
    class details
    {
        public static SqlDataReader detshow()
        {
       
            return ado.getdata("show", "details");
            

        }
    }
}
