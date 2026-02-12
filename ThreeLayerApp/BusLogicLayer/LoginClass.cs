using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BusLogicLayer
{
    public class LoginClass
    {
        ConnectionClass objdal = new ConnectionClass();

        public string GetCountId(string una, string pw)
        {
            string str = "select count(Id) from TwoLayer where Username='" + una + "' and Password='" + pw + "'";
            string cid = objdal.Fn_Scalar(str);
            return cid;
        }

        public string GetId(string una, string pw)
        {
            string s = "select Id from TwoLayer where Username='" + una + "' and Password='" + pw + "'";
            string id = objdal.Fn_Scalar(s);
            return id;
        }
    }
}
