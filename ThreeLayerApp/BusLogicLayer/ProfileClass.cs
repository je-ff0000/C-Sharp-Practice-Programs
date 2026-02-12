using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;

namespace BusLogicLayer
{
    public class ProfileClass
    {
        ConnectionClass objdal = new ConnectionClass();
        public SqlDataReader fn_GetData(int id)
        {
            string str = "select Name, Age, Address, Photo from TwoLayer where Id = " + id;
            SqlDataReader dr = objdal.Fn_SqlReader(str);
            return dr;
        }

        public DataSet fn_GetDataSet(int id)
        {
            string str = "select Name, Age, Address, Photo from TwoLayer where Id = " + id;
            DataSet ds = objdal.Fn_exeAdapter(str);
            return ds;
        }

        public DataTable fn_GetDataTable(int id)
        {
            string str = "select Name, Age, Address, Photo from TwoLayer where Id = " + id;
            DataTable dt = objdal.Fn_Exedatatable(str);
            return dt;
        }

    }
}
