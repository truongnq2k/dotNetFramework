using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DemoDataAccess
{
    class Shipper
    {
        public string ShipperID { get; set; }
        public string ShipperName { get; set; }

        public Shipper(string ShipperID, string ShipperName)
        {
            this.ShipperID = ShipperID;
            this.ShipperName = ShipperName;
        }

    }

    class ShipperList
    {
        public static List<Shipper> GetAllShipper()
        {
            List<Shipper> Shippers = new List<Shipper>();
            DataTable dt = DAO.GetAllShipper();
            foreach (DataRow dr in dt.Rows)
            {
                Shipper c = new Shipper(
                    dr["ShipperID"].ToString(),
                    dr["CompanyName"].ToString()
                    );
                Shippers.Add(c);
            }
            return Shippers;
        }

    }
}
