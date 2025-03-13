using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Home_Decor_App
{
    class SharedContent
    {
        public static int status = 0;
        public static string Login_User = "";
        public static int User_Id = 0;
        public static string User_Role = "";

        public static int ProductId = 0;
        public static int ProductStock = 0;
        public static string ProductName = "";
        public static double ProductPrice = 0.0;

        public static int Flag = 0;

        public static int CId = 0;                  /// This Id is Used for Single Customer Bill

        public static void Generate_Id()
        {
            Connections.Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select User_Id from Login_Details where Username = @unm";
            cmd.Connection = Connections.Con;

            cmd.Parameters.Add("unm", SqlDbType.NVarChar).Value = SharedContent.Login_User;

            User_Id = Convert.ToInt32(cmd.ExecuteScalar());

            Connections.Con_Close();
        }

        public static int Auto_Increment(string tblnm , string colnm , int spt)
        {
            int Cnt;
            Connections.Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "select count(*) from " + tblnm;
            Cmd.Connection = Connections.Con;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(Cnt > 0)
            {
                Cmd.CommandText = "select max(" + colnm + ") from " + tblnm;
                Cmd.Connection = Connections.Con;

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar())+1;
            }
            else
            {
                Cnt = spt;
            }
            return Cnt;
        }
        public static void Only_Numeric(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        public static void Only_Text(KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        public static void Only_AlphaNumeric(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        public static void Bind_ComboBox(string colnm , ComboBox cmbobj , string Query)
        {
            Connections.Con_Open();
            SqlCommand cmd = new SqlCommand(Query, Connections.Con);
            SqlDataReader SDR = cmd.ExecuteReader();

            cmbobj.Items.Clear();

            while (SDR.Read())
            {
                cmbobj.Items.Add(SDR.GetString(SDR.GetOrdinal(colnm)));
            }
            Connections.Con_Close();
        }

        public static void Bind_Grid(DataGridView dgv, string query)
        {
            Connections.Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter(query, Connections.Con);
            DataTable DT = new DataTable();
            SDA.Fill(DT);
            dgv.DataSource = DT;
            Connections.Con_Close();
        }
    }
}
