using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryDonViHanhChinh
{
    public class DistrictDAO
    {
        public static DataTable GetDisctrictByProvinceID(int pid)
        {
            SqlCommand sql = new SqlCommand(@"select * from district where province_id = @pid");
            sql.Parameters.AddWithValue("@pid", pid);
            return DAO.GetDataTable(sql);
        }
    }
}
