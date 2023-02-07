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
    public class CommonDAO : IDisposable
    {
        SqlConnection conn = default;
        public CommonDAO()
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

        public UserDTO LoginCheck(string userID, string pwd)
        {
            try
            {
                UserDTO userInfo = default;
                string sql = @" SELECT  USER_ID
                                	  , USER_NAME
                                	  , USER_DEPARTMENT
                                	  , USER_GROUP_CODE
                                 FROM USER_MST
                                 WHERE USER_ID = @USER_ID AND USER_PASSWORD = @USER_PASSWORD";

                using (SqlCommand cmd = new SqlCommand(sql,conn))
                {
                    cmd.Parameters.AddWithValue("@USER_ID", userID);
                    cmd.Parameters.AddWithValue("@USER_PASSWORD", pwd);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        userInfo = new UserDTO
                        {
                            USER_ID = reader["USER_ID"].ToString(),
                            USER_NAME = reader["USER_NAME"].ToString(),
                            USER_DEPARTMENT = reader["USER_DEPARTMENT"].ToString(),
                            USER_GROUP_CODE = reader["USER_GROUP_CODE"].ToString()
                        };
                    }
                }
                return userInfo;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}