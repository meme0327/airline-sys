using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sparkling_Skies.bl
{
    class login
    {
        public static DataTable tologin(int id,string name, string pw)
        {

            return ado.SelectData("newLogin",

               ado.CreateParameters("@id", SqlDbType.Int, id),
                ado.CreateParameters("@name", SqlDbType.NVarChar, name),
              ado.CreateParameters("@pass", SqlDbType.NVarChar, pw)

                );
        }

    }
}
