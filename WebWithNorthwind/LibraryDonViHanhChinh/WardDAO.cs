using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryDonViHanhChinh
{
    public class WardDAO
    {
        public static DataTable GetWardByDisctrictID(int did)
        {
            SqlCommand sql = new SqlCommand(@"select * from ward where district_id = @did");
            sql.Parameters.AddWithValue("@did", did);
            return DAO.GetDataTable(sql);
        }
    }
}
