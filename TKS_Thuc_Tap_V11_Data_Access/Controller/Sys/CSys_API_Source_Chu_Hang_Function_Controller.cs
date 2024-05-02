using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.DataLayer;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Sys
{
	public class CSys_API_Source_Chu_Hang_Function_Controller
	{
        public List<CSys_API_Source_Chu_Hang_Function> FQ_503_ASCHF_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_API_Source_Chu_Hang_Function> v_arrRes = new List<CSys_API_Source_Chu_Hang_Function>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_503_ASCHF_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_API_Source_Chu_Hang_Function v_objRes = CUtility.Map_Row_To_Entity<CSys_API_Source_Chu_Hang_Function>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public List<CSys_API_Source_Chu_Hang_Function> FQ_503_ASCHF_sp_sel_List_By_API_Source_Chu_Hang_ID(long p_iAPI_Source_Chu_Hang_ID)
        {
            List<CSys_API_Source_Chu_Hang_Function> v_arrRes = new List<CSys_API_Source_Chu_Hang_Function>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_503_ASCHF_sp_sel_List_By_API_Source_Chu_Hang_ID", p_iAPI_Source_Chu_Hang_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_API_Source_Chu_Hang_Function v_objRes = CUtility.Map_Row_To_Entity<CSys_API_Source_Chu_Hang_Function>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public List<CSys_API_Source_Chu_Hang_Function> FQ_503_ASCHF_sp_sel_List_For_Cache()
        {
            List<CSys_API_Source_Chu_Hang_Function> v_arrRes = new List<CSys_API_Source_Chu_Hang_Function>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_503_ASCHF_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_API_Source_Chu_Hang_Function v_objRes = CUtility.Map_Row_To_Entity<CSys_API_Source_Chu_Hang_Function>(v_row);
                    v_arrRes.Add(v_objRes);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_arrRes;
        }

        public CSys_API_Source_Chu_Hang_Function FQ_503_ASCHF_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_API_Source_Chu_Hang_Function v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_503_ASCHF_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_API_Source_Chu_Hang_Function>(v_dt.Rows[0]);
                }
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                v_dt.Dispose();
            }

            return v_objRes;
        }

        public long FQ_503_ASCHF_sp_ins_Insert(CSys_API_Source_Chu_Hang_Function p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_503_ASCHF_sp_ins_Insert",
                    p_objData.API_Source_Chu_Hang_ID, p_objData.API_Source_Function_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_503_ASCHF_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CSys_API_Source_Chu_Hang_Function p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_503_ASCHF_sp_ins_Insert",
                    p_objData.API_Source_Chu_Hang_ID, p_objData.API_Source_Function_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        /// <summary>
        /// có check API_Source_ID có tồn tại trong view_Sys_API_Source_Function với API_Source_Function_ID
        /// </summary>
        /// <param name="p_conn"></param>
        /// <param name="p_trans"></param>
        /// <param name="p_objData"></param>
        /// <param name="p_iAPI_Source_ID"></param>
        /// <returns></returns>
        public long F1038_sp_ins_API_Source_Chu_Hang_Function(SqlConnection p_conn, SqlTransaction p_trans, CSys_API_Source_Chu_Hang_Function p_objData, long p_iAPI_Source_ID)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "F1038_sp_ins_API_Source_Chu_Hang_Function",
                    p_iAPI_Source_ID, p_objData.API_Source_Chu_Hang_ID, p_objData.API_Source_Function_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_503_ASCHF_sp_upd_Update(CSys_API_Source_Chu_Hang_Function p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_503_ASCHF_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.API_Source_Chu_Hang_ID, p_objData.API_Source_Function_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }


        public void FQ_503_ASCHF_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CSys_API_Source_Chu_Hang_Function p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_503_ASCHF_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.API_Source_Chu_Hang_ID, p_objData.API_Source_Function_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }



        /// <summary>
        /// có check API_Source_ID có tồn tại trong view_Sys_API_Source_Function với API_Source_Function_ID
        /// </summary>
        /// <param name="p_conn"></param>
        /// <param name="p_trans"></param>
        /// <param name="p_objData"></param>
        /// <param name="p_iAPI_Source_ID"></param>
        public void F1038_sp_upd_API_Source_Chu_Hang_Function(SqlConnection p_conn, SqlTransaction p_trans, CSys_API_Source_Chu_Hang_Function p_objData, long p_iAPI_Source_ID)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "F1038_sp_upd_API_Source_Chu_Hang_Function",
                    p_iAPI_Source_ID, p_objData.Auto_ID, p_objData.API_Source_Chu_Hang_ID, p_objData.API_Source_Function_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_503_ASCHF_sp_del_Delete_By_ID(SqlConnection p_conn, SqlTransaction p_trans, long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_503_ASCHF_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }       	   
    }
}
