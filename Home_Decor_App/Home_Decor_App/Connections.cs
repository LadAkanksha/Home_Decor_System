using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Home_Decor_App
{
    class Connections
    {
        public static SqlConnection Con = new SqlConnection(@"Data Source=Akansha;Initial Catalog=Home_Decor_App_DB;Integrated Security=True");
        public static void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        public static void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
    }
    
}
