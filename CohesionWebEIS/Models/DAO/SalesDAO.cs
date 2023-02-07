using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CohesionWebEIS.Models.DTO;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace CohesionWebEIS.Models.DAO 
{
    public class SalesDAO : IDisposable
    {
        SqlConnection conn = default;
        public SalesDAO()
        {
            string connStr = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            conn = new SqlConnection(connStr);
        }

        public void Dispose()
        {
            if (conn != null || conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //public void GetAllSalesOrderList(int categoryID, int productID, string productName, int page, int pageSize, out int totCnt)
        //{

        //}
    }
}