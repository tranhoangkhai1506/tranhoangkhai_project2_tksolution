using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TKS_Thuc_Tap_V11_Data_Access.DataLayer;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Sys
{
    public class CSys_Help_Guide_Controller
    {
        public List<CSys_Help_Guide> FQ_518_HG_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_Help_Guide> v_arrRes = new List<CSys_Help_Guide>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_518_HG_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Help_Guide v_objRes = CUtility.Map_Row_To_Entity<CSys_Help_Guide>(v_row);
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

        public List<CSys_Help_Guide> FQ_518_HG_sp_sel_List_For_Cache()
        {
            List<CSys_Help_Guide> v_arrRes = new List<CSys_Help_Guide>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_518_HG_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Help_Guide v_objRes = CUtility.Map_Row_To_Entity<CSys_Help_Guide>(v_row);
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

        public CSys_Help_Guide FQ_518_HG_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_Help_Guide v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_518_HG_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Help_Guide>(v_dt.Rows[0]);
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

        public CSys_Help_Guide FQ_518_HG_sp_sel_Get_By_Data(string p_strMa_Chuc_Nang, int p_iKhach_Hang_ID, string p_strNgon_Ngu)
        {
            CSys_Help_Guide v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_518_HG_sp_sel_Get_By_Data", p_strMa_Chuc_Nang, p_iKhach_Hang_ID, p_strNgon_Ngu);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Help_Guide>(v_dt.Rows[0]);
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

        public long FQ_518_HG_sp_ins_Insert(CSys_Help_Guide p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_518_HG_sp_ins_Insert",
                    p_objData.Khach_Hang_ID, p_objData.Ma_Chuc_Nang, p_objData.Ngon_Ngu, p_objData.Noi_Dung, p_objData.Last_Updated_By,
                    p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_518_HG_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CSys_Help_Guide p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_518_HG_sp_ins_Insert",
                    p_objData.Khach_Hang_ID, p_objData.Ma_Chuc_Nang, p_objData.Ngon_Ngu, p_objData.Noi_Dung, p_objData.Last_Updated_By,
                    p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_518_HG_sp_upd_Update(CSys_Help_Guide p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_518_HG_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Khach_Hang_ID, p_objData.Ma_Chuc_Nang, p_objData.Ngon_Ngu, p_objData.Noi_Dung, p_objData.Last_Updated_By,
                    p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_518_HG_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CSys_Help_Guide p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_518_HG_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Khach_Hang_ID, p_objData.Ma_Chuc_Nang, p_objData.Ngon_Ngu, p_objData.Noi_Dung, p_objData.Last_Updated_By,
                    p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_518_HG_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_518_HG_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

	}
}
