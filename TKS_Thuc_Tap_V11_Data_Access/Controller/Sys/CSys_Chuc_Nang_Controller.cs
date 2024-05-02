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
    public class CSys_Chuc_Nang_Controller
    {

        public List<CSys_Chuc_Nang> FQ_507_CN_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_Chuc_Nang> v_arrRes = new List<CSys_Chuc_Nang>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_507_CN_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Chuc_Nang v_objRes = CUtility.Map_Row_To_Entity<CSys_Chuc_Nang>(v_row);
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

        public List<CSys_Chuc_Nang> FQ_507_CN_sp_sel_List_By_Nhom_Chuc_Nang_A_Parent_Func_ID(int p_iNhom_Chuc_Nang_ID, long p_iParent_Func_ID)
        {
            List<CSys_Chuc_Nang> v_arrRes = new List<CSys_Chuc_Nang>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_507_CN_sp_sel_List_By_Nhom_Chuc_Nang_A_Parent_Func_ID", p_iNhom_Chuc_Nang_ID, p_iParent_Func_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Chuc_Nang v_objRes = CUtility.Map_Row_To_Entity<CSys_Chuc_Nang>(v_row);
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
        public List<CSys_Chuc_Nang> FQ_507_CN_sp_sel_List_By_Nhom_CN_A_Parent_Func_A_Nhom_TV_ID(int p_iNhom_Chuc_Nang_ID, long p_iParent_Func_ID, long p_iNhom_Thanh_Vien_ID)
        {
            List<CSys_Chuc_Nang> v_arrRes = new List<CSys_Chuc_Nang>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_507_CN_sp_sel_List_By_Nhom_CN_A_Parent_Func_A_Nhom_TV_ID", p_iNhom_Chuc_Nang_ID,
                    p_iParent_Func_ID, p_iNhom_Thanh_Vien_ID);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Chuc_Nang v_objRes = CUtility.Map_Row_To_Entity<CSys_Chuc_Nang>(v_row);
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


        public List<CSys_Chuc_Nang> FQ_507_CN_sp_sel_List_For_Cache()
        {
            List<CSys_Chuc_Nang> v_arrRes = new List<CSys_Chuc_Nang>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_507_CN_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Chuc_Nang v_objRes = CUtility.Map_Row_To_Entity<CSys_Chuc_Nang>(v_row);
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

        public CSys_Chuc_Nang FQ_507_CN_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_Chuc_Nang v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_507_CN_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Chuc_Nang>(v_dt.Rows[0]);
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

        public long FQ_507_CN_sp_ins_Insert(CSys_Chuc_Nang p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_507_CN_sp_ins_Insert",
                    p_objData.Ma_Chuc_Nang, p_objData.Ten_Chuc_Nang, p_objData.Sort_Priority, p_objData.Chuc_Nang_Parent_ID, p_objData.Nhom_Chuc_Nang_ID,
                    p_objData.Func_URL, p_objData.Image_URL, p_objData.Is_View, p_objData.Is_New, p_objData.Is_Edit, p_objData.Is_Delete,
                    p_objData.Is_Export, p_objData.Khach_Hang_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        
        public long FQ_507_CN_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CSys_Chuc_Nang p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_507_CN_sp_ins_Insert",
                    p_objData.Ma_Chuc_Nang, p_objData.Ten_Chuc_Nang, p_objData.Sort_Priority, p_objData.Chuc_Nang_Parent_ID, p_objData.Nhom_Chuc_Nang_ID,
                    p_objData.Func_URL, p_objData.Image_URL, p_objData.Is_View, p_objData.Is_New, p_objData.Is_Edit, p_objData.Is_Delete,
                    p_objData.Is_Export, p_objData.Khach_Hang_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_507_CN_sp_upd_Update(CSys_Chuc_Nang p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_507_CN_sp_upd_Update", 
                    p_objData.Auto_ID, p_objData.Ma_Chuc_Nang, p_objData.Ten_Chuc_Nang, p_objData.Sort_Priority, p_objData.Chuc_Nang_Parent_ID, 
                    p_objData.Nhom_Chuc_Nang_ID, p_objData.Func_URL, p_objData.Image_URL, p_objData.Is_View, p_objData.Is_New, p_objData.Is_Edit, p_objData.Is_Delete,
                    p_objData.Is_Export, p_objData.Khach_Hang_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }
		

		public void FQ_507_CN_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CSys_Chuc_Nang p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_507_CN_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Ma_Chuc_Nang, p_objData.Ten_Chuc_Nang, p_objData.Sort_Priority, p_objData.Chuc_Nang_Parent_ID, p_objData.Nhom_Chuc_Nang_ID,
                    p_objData.Func_URL, p_objData.Image_URL, p_objData.Is_View, p_objData.Is_New, p_objData.Is_Edit, p_objData.Is_Delete,
                    p_objData.Is_Export, p_objData.Khach_Hang_ID, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }


        public void FQ_507_CN_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_507_CN_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }


        public void FDev_004_Truncate_Sys_Chuc_Nang_All()
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FDev_004_sp_Truncate_Sys_Chuc_Nang_All");
            }

            catch (Exception)
            {
                throw;
            }
        }

        public long FDev_004_sp_ins_Sys_Chuc_Nang_From_API(CSys_Chuc_Nang p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FDev_004_sp_ins_Sys_Chuc_Nang_From_API", p_objData.Auto_ID,
                    p_objData.Ma_Chuc_Nang, p_objData.Ten_Chuc_Nang, p_objData.Sort_Priority, p_objData.Chuc_Nang_Parent_ID, p_objData.Nhom_Chuc_Nang_ID, p_objData.Func_URL, p_objData.Image_URL, p_objData.Is_View, p_objData.Is_New, p_objData.Is_Edit, p_objData.Is_Delete, p_objData.Is_Export, p_objData.Ghi_Chu, p_objData.deleted, p_objData.Created, p_objData.Created_By, p_objData.Created_By_Function, p_objData.Last_Updated,
                    p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public List<CSys_Chuc_Nang> FAPI_1044_List_Sys_Chuc_Nang()
        {
            List<CSys_Chuc_Nang> v_arrRes = new List<CSys_Chuc_Nang>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FAPI_1044_sp_sel_List_Chuc_Nang");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Chuc_Nang v_objRes = CUtility.Map_Row_To_Entity<CSys_Chuc_Nang>(v_row);
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
