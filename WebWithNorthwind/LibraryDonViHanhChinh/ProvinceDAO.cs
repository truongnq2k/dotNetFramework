using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LibraryDonViHanhChinh
{
    public class ProvinceDAO
    {
        public static DataTable GetAllProvince()
        {
            string sql = "SELECT * FROM province";
            return DAO.GetDataTable(sql);
        }
    }
}
