using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TKS_Thuc_Tap_V11_Data_Access.DataLayer;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Sys
{
	public class CSys_Nhom_Thanh_Vien_User_Controller
	{
        public List<CSys_Nhom_Thanh_Vien_User> FQ_526_NTVU_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_Nhom_Thanh_Vien_User> v_arrRes = new List<CSys_Nhom_Thanh_Vien_User>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_526_NTVU_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Nhom_Thanh_Vien_User v_objRes = CUtility.Map_Row_To_Entity<CSys_Nhom_Thanh_Vien_User>(v_row);
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

        public List<CSys_Nhom_Thanh_Vien_User> FQ_526_NTVU_sp_sel_List_For_Cache()
        {
            List<CSys_Nhom_Thanh_Vien_User> v_arrRes = new List<CSys_Nhom_Thanh_Vien_User>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_526_NTVU_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Nhom_Thanh_Vien_User v_objRes = CUtility.Map_Row_To_Entity<CSys_Nhom_Thanh_Vien_User>(v_row);
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

        public CSys_Nhom_Thanh_Vien_User FQ_526_NTVU_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_Nhom_Thanh_Vien_User v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_526_NTVU_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Nhom_Thanh_Vien_User>(v_dt.Rows[0]);
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

        public long FQ_526_NTVU_sp_ins_Insert(CSys_Nhom_Thanh_Vien_User p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_526_NTVU_sp_ins_Insert",
                    p_objData.Nhom_Thanh_Vien_ID, p_objData.Ma_Dang_Nhap, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_526_NTVU_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CSys_Nhom_Thanh_Vien_User p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_526_NTVU_sp_ins_Insert",
                    p_objData.Nhom_Thanh_Vien_ID, p_objData.Ma_Dang_Nhap, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_526_NTVU_sp_upd_Update(CSys_Nhom_Thanh_Vien_User p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_526_NTVU_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Nhom_Thanh_Vien_ID, p_objData.Ma_Dang_Nhap, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_526_NTVU_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CSys_Nhom_Thanh_Vien_User p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_526_NTVU_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Nhom_Thanh_Vien_ID, p_objData.Ma_Dang_Nhap, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_526_NTVU_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_526_NTVU_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

       

    

       


        public List<CSys_Nhom_Thanh_Vien_User> FQ_526_NTVU_sp_sel_List_By_Nhom_TV_ID(long p_iNhom_TV_ID)
        {
            List<CSys_Nhom_Thanh_Vien_User> v_arrRes = new List<CSys_Nhom_Thanh_Vien_User>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_526_NTVU_sp_sel_List_By_Nhom_TV_ID", p_iNhom_TV_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Nhom_Thanh_Vien_User v_objRes = CUtility.Map_Row_To_Entity<CSys_Nhom_Thanh_Vien_User>(v_row);
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

	}
}
