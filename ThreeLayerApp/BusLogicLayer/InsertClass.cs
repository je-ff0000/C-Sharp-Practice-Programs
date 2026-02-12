using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BusLogicLayer
{
    public class InsertClass
    {
        ConnectionClass objdal = new ConnectionClass();
        public int InsertDB(string na, int ag, string addr, string ph, string una, string pw)
        {
            string ins = "insert into TwoLayer values('" + na + "'," + ag + ",'" + addr + "','" + ph + "','" + una + "','" + pw + "')";
            int i = objdal.Fn_NonQuery(ins);
            return i;
        }
    }
}
