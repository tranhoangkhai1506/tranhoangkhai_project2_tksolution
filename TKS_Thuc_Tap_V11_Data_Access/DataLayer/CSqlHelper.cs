using System;
using System.Collections;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.DataLayer
{
    public sealed class CSqlHelper
    {
        //public static int m_iQueue_Sleep = 10;

		#region public function
		public static SqlConnection CreateConnection(string p_strConnStr)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = p_strConnStr;
            return conn;
        }

        public static int ExecuteNonquery(string p_strConnStr, string p_strSPname, params object[] p_arrValue)
        {
            //long v_iSTT = CUtility_Queue_DB.Add_Queue(p_strSPname);
            //long v_iCurrent_Queue = CUtility_Queue_DB.Get_Current_Queue(p_strSPname);

            //if (CConfig.Khach_Hang_ID != (int)EKhach_Hang_ID.AD)
            //{
            //    Thread.Sleep(m_iQueue_Sleep);

            //    while (v_iCurrent_Queue != v_iSTT)
            //    {
            //        Thread.Sleep(m_iQueue_Sleep);
            //        v_iCurrent_Queue = CUtility_Queue_DB.Get_Current_Queue(p_strSPname);
            //    }
            //}

            try
            {
                if ((p_arrValue != null) && (p_arrValue.Length > 0))
                {
                    // Tạo danh sách SqlParameter
                    SqlParameter[] arrSQLParameter = CSqlHelperParameterCache.GetSpParameterSet(
                        p_strConnStr, p_strSPname);

                    // Gán dữ liệu từ các mãng value vô mảng command parameter
                    AssignParameterValues(arrSQLParameter, p_arrValue, p_strSPname);

                    // gọi hàm overload
                    return ExecuteNonQuery(p_strConnStr, p_strSPname, arrSQLParameter);
                }

                else
                {
                    return ExecuteNonQuery(p_strConnStr, p_strSPname, null);
                }
            }

            catch (Exception)
            {
                throw;
            }

   //         finally
   //         {
   //             CUtility_Queue_DB.Remove_Queue(p_strSPname, v_iSTT);
			//}
        }

        public static int ExecuteNonquery(SqlConnection p_objConn, SqlTransaction p_objTrans, string p_strConnString,
            string p_strSPname, params object[] p_arrValue)
        {
			try
            {
                if ((p_arrValue != null) && (p_arrValue.Length > 0))
                {
                    // Tạo danh sách SqlParameter
                    SqlParameter[] arrSQLParameter = CSqlHelperParameterCache.GetSpParameterSet(
                        p_strConnString, p_strSPname);

                    // Gán dữ liệu từ các mãng value vô mảng command parameter
                    AssignParameterValues(arrSQLParameter, p_arrValue, p_strSPname);

                    // gọi hàm overload
                    return ExecuteNonQuery(p_objConn, p_objTrans, p_strSPname, arrSQLParameter);
                }

                else
                {
                    return ExecuteNonQuery(p_objConn, p_objTrans, p_strSPname, null);
                }
            }

			catch (Exception)
			{
				throw;
			}
		}

        public static object ExecuteScalar(string p_strConnStr, string p_strSPname, params object[] p_arrValue)
        {
			try
            {
                if ((p_arrValue != null) && (p_arrValue.Length > 0))
                {
                    // Tạo danh sách SqlParameter
                    SqlParameter[] arrSQLParameter = CSqlHelperParameterCache.GetSpParameterSet(
                        p_strConnStr, p_strSPname);

                    // Gán dữ liệu từ các mãng value vô mảng command parameter
                    AssignParameterValues(arrSQLParameter, p_arrValue, p_strSPname);

                    // gọi hàm overload
                    return ExecuteScalar(p_strConnStr, p_strSPname, arrSQLParameter);
                }

                else
                {
                    return ExecuteScalar(p_strConnStr, p_strSPname, null);
                }
            }

			catch (Exception)
			{
				throw;
			}
		}

        public static object ExecuteScalar(SqlConnection p_conn, SqlTransaction p_trans, string p_strConnStr, string p_strSPname,
            params object[] p_arrValue)
        {
			try
            {
                if ((p_arrValue != null) && (p_arrValue.Length > 0))
                {
                    // Tạo danh sách SqlParameter
                    SqlParameter[] arrSQLParameter = CSqlHelperParameterCache.GetSpParameterSet(
                        p_strConnStr, p_strSPname);

                    // Gán dữ liệu từ các mãng value vô mảng command parameter
                    AssignParameterValues(arrSQLParameter, p_arrValue, p_strSPname);

                    // gọi hàm overload
                    return ExecuteScalar(p_conn, p_trans, p_strSPname, arrSQLParameter);
                }

                else
                {
                    return ExecuteScalar(p_conn, p_trans, p_strConnStr, p_strSPname, null);
                }
            }

			catch (Exception)
			{
				throw;
			}
		}

        public static void FillDataTable(string p_strConnStr, DataTable p_dtData, string p_strSPname, params object[] p_arrValue)
        {
            if ((p_arrValue != null) && (p_arrValue.Length > 0))
            {
                // Tạo danh sách SqlParameter
                SqlParameter[] arrSQLParameter = CSqlHelperParameterCache.GetSpParameterSet(
                    p_strConnStr, p_strSPname);

                // Gán dữ liệu từ các mãng value vô mảng command parameter
                AssignParameterValues(arrSQLParameter, p_arrValue, p_strSPname);

                // gọi hàm overload
                FillDataTable(p_strConnStr, p_dtData, p_strSPname, arrSQLParameter);
            }

            else
            {
                FillDataTable(p_strConnStr, p_dtData, p_strSPname, null);
            }
        }

        public static void FillDataTable(SqlConnection p_conn, SqlTransaction p_trans, string p_strConnStr, DataTable p_dtData,
            string p_strSPname, params object[] p_arrValue)
        {
            if ((p_arrValue != null) && (p_arrValue.Length > 0))
            {
                // Tạo danh sách SqlParameter
                SqlParameter[] arrSQLParameter = CSqlHelperParameterCache.GetSpParameterSet(
                    p_strConnStr, p_strSPname);

                // Gán dữ liệu từ các mãng value vô mảng command parameter
                AssignParameterValues(arrSQLParameter, p_arrValue, p_strSPname);

                // gọi hàm overload
                FillDataTable(p_conn, p_trans, p_dtData, p_strSPname, arrSQLParameter);
            }

            else
            {
                FillDataTable(p_conn, p_trans, p_strConnStr, p_dtData, p_strSPname, null);
            }
        }

		public static void FillDataTable_Cmd(string p_strConnStr, DataTable p_dtData, string p_strCmd)
		{
			SqlConnection conn = new SqlConnection(p_strConnStr);
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da = new SqlDataAdapter(cmd);

			try
			{
				//associate the connection with the command
				cmd.Connection = conn;

				//set the command text (stored procedure name or SQL statement)
				cmd.CommandText = p_strCmd;

				//set the command type
				cmd.CommandType = CommandType.Text;
				cmd.CommandTimeout = 300;
				da.Fill(p_dtData);
			}

			catch (Exception)
			{
				throw;
			}

			finally
			{
				if (conn.State == ConnectionState.Open)
					conn.Close();
				cmd.Dispose();
				da.Dispose();
			}
		}

		public static void ExecuteNonquery_Cmd(string p_strConnStr, string p_strCmd)
		{
			SqlConnection conn = new SqlConnection(p_strConnStr);
			SqlCommand cmd = new SqlCommand();

			try
			{
				conn.Open();

				//associate the connection with the command
				cmd.Connection = conn;

				//set the command text (stored procedure name or SQL statement)
				cmd.CommandText = p_strCmd;

				//set the command type
				cmd.CommandType = CommandType.Text;
				cmd.CommandTimeout = 300;

				cmd.ExecuteNonQuery();
			}

			catch (Exception)
			{
				throw;
			}

			finally
			{
				if (conn.State == ConnectionState.Open)
					conn.Close();
				cmd.Dispose();
			}
		}

		#endregion

		#region private function
		private static void AssignParameterValues(SqlParameter[] p_arrSQLParameter, object[] p_arrValue, string p_strSPName)
        {
            if ((p_arrSQLParameter == null) || (p_arrValue == null))
            {
                return;
            }

            if (p_arrSQLParameter.Length != p_arrValue.Length)
            {
                throw new Exception($"{p_strSPName}. Parameter count does not match Parameter Value count.");
            }

            for (int i = 0, j = p_arrSQLParameter.Length; i < j; i++)
            {
                if (p_arrValue[i] == null)
                    p_arrSQLParameter[i].Value = DBNull.Value;
                else
                    p_arrSQLParameter[i].Value = p_arrValue[i];
            }
        }

        private static void AttachParameters(SqlCommand p_cmd, SqlParameter[] p_arrSQLParameter)
        {
            foreach (SqlParameter p in p_arrSQLParameter)
            {
                if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
                {
                    p.Value = DBNull.Value;
                }

                p_cmd.Parameters.Add(p);
            }
        }

        private static int ExecuteNonQuery(string p_strConnStr, string p_strStoreName,
            params SqlParameter[] p_arrSQLParameter)
        {
            DateTime? v_dtStart = DateTime.Now;

            SqlConnection conn = new SqlConnection(p_strConnStr);
            SqlCommand cmd = new SqlCommand();
            int result = -5;

            try
            {
                PrepareCommand(cmd, conn, (SqlTransaction)null, p_strStoreName, p_arrSQLParameter);

                // Execute Sql Command
                result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                cmd.Dispose();
            }

            DateTime? v_dtEnd = DateTime.Now;
            TimeSpan v_ts = v_dtEnd.Value - v_dtStart.Value;
            if (v_ts.TotalMilliseconds >= 1000)
                CLogger.Trace("CSqlHelper", "ExecuteNonQuery", "Store: " + p_strStoreName + " execute " + v_ts.TotalSeconds.ToString("###,###0.######"));

            return result;
        }

        private static int ExecuteNonQuery(SqlConnection p_objConn, SqlTransaction p_objTrans,
            string p_strStoreName, params SqlParameter[] p_arrSQLParameter)
        {
            DateTime? v_dtStart = DateTime.Now;

            SqlCommand cmd = new SqlCommand();
            int result = -5;

            try
            {
                PrepareCommand(cmd, p_objConn, p_objTrans, p_strStoreName, p_arrSQLParameter);

                // Execute Sql Command
                result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                cmd.Dispose();
            }

            DateTime? v_dtEnd = DateTime.Now;
            TimeSpan v_ts = v_dtEnd.Value - v_dtStart.Value;
            if (v_ts.TotalMilliseconds >= 1000)
                CLogger.Trace("CSqlHelper", "ExecuteNonQuery", "Store: " + p_strStoreName + " execute " + v_ts.TotalSeconds.ToString("###,###0.######"));

            return result;
        }

        private static object ExecuteScalar(string p_strConnStr, string p_strStoreName, params SqlParameter[] p_arrSQLParameter)
        {
            DateTime v_dtStart = DateTime.Now;

            SqlConnection conn = new SqlConnection(p_strConnStr);
            SqlCommand cmd = new SqlCommand();
            object result = null;

            try
            {
                PrepareCommand(cmd, conn, (SqlTransaction)null, p_strStoreName, p_arrSQLParameter);
                // Execute Sql Command
                result = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                cmd.Dispose();
            }

            DateTime v_dtEnd = DateTime.Now;
            TimeSpan v_ts = v_dtEnd - v_dtStart;
            if (v_ts.TotalMilliseconds >= 1000)
                CLogger.Trace("CSqlHelper", "ExecuteScalar", "Store: " + p_strStoreName + " execute " + v_ts.TotalSeconds.ToString("###,###0.######"));

            return result;
        }

        private static object ExecuteScalar(SqlConnection p_conn, SqlTransaction p_trans, string p_strStoreName,
            params SqlParameter[] p_arrSQLParameter)
        {
            DateTime v_dtStart = DateTime.Now;

            SqlCommand cmd = new SqlCommand();
            object result = null;

            try
            {
                PrepareCommand(cmd, p_conn, p_trans, p_strStoreName, p_arrSQLParameter);
                // Execute Sql Command
                result = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                cmd.Dispose();
            }

            DateTime v_dtEnd = DateTime.Now;
            TimeSpan v_ts = v_dtEnd - v_dtStart;
            if (v_ts.TotalMilliseconds >= 1000)
                CLogger.Trace("CSqlHelper", "ExecuteScalar", "Store: " + p_strStoreName + " execute " + v_ts.TotalSeconds.ToString("###,###0.######"));

            return result;
        }

        private static void FillDataTable(string p_strConnStr, DataTable p_dtData, string p_strStoreName, params SqlParameter[] p_arrSQLParameter)
        {
            DateTime v_dtStart = DateTime.Now;

            SqlConnection conn = new SqlConnection(p_strConnStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                PrepareCommand(cmd, conn, (SqlTransaction)null, p_strStoreName, p_arrSQLParameter);
                da.Fill(p_dtData);
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                cmd.Dispose();
                da.Dispose();
            }

            DateTime v_dtEnd = DateTime.Now;
            TimeSpan v_ts = v_dtEnd - v_dtStart;
            if (v_ts.TotalMilliseconds >= 1000)
                CLogger.Trace("CSqlHelper", "FillDataTable", "Store: " + p_strStoreName + " execute " + v_ts.TotalSeconds.ToString("###,###0.######"));
        }

        private static void FillDataTable(SqlConnection p_conn, SqlTransaction p_trans,
            DataTable p_dtData, string p_strStoreName, params SqlParameter[] p_arrSQLParameter)
        {
            DateTime v_dtStart = DateTime.Now;

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                PrepareCommand(cmd, p_conn, p_trans, p_strStoreName, p_arrSQLParameter);
                da.Fill(p_dtData);
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                cmd.Dispose();
                da.Dispose();
            }

            DateTime v_dtEnd = DateTime.Now;
            TimeSpan v_ts = v_dtEnd - v_dtStart;
            if (v_ts.TotalMilliseconds >= 1000)
                CLogger.Trace("CSqlHelper", "FillDataTable", "Store: " + p_strStoreName + " execute " + v_ts.TotalSeconds.ToString(CConfig.Number_Format_String));
        }

        private static void PrepareCommand(SqlCommand p_cmd, SqlConnection p_conn,
            SqlTransaction p_trans, string p_strSPName, SqlParameter[] p_arrSQLParameter)
        {
            //if the provided connection is not open, we will open it
            if (p_conn.State != ConnectionState.Open)
            {
                p_conn.Open();
            }

            //associate the connection with the command
            p_cmd.Connection = p_conn;

            //set the command text (stored procedure name or SQL statement)
            p_cmd.CommandText = p_strSPName;

            //if we were provided a transaction, assign it.
            if (p_trans != null)
            {
                p_cmd.Transaction = p_trans;
            }

            //set the command type
            p_cmd.CommandType = CommandType.StoredProcedure;

            //attach the command parameters if they are provided
            if (p_arrSQLParameter != null)
            {
                AttachParameters(p_cmd, p_arrSQLParameter);
            }
        }

        #endregion

    }
}
