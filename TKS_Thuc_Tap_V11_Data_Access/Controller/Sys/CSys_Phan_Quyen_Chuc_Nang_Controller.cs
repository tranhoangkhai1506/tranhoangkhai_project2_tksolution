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
	public class CSys_Phan_Quyen_Chuc_Nang_Controller
	{
        public List<CSys_Phan_Quyen_Chuc_Nang> FQ_527_PQCN_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_Phan_Quyen_Chuc_Nang> v_arrRes = new List<CSys_Phan_Quyen_Chuc_Nang>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_527_PQCN_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Phan_Quyen_Chuc_Nang v_objRes = CUtility.Map_Row_To_Entity<CSys_Phan_Quyen_Chuc_Nang>(v_row);
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

        public List<CSys_Phan_Quyen_Chuc_Nang> FQ_527_PQCN_sp_sel_List_For_Cache()
        {
            List<CSys_Phan_Quyen_Chuc_Nang> v_arrRes = new List<CSys_Phan_Quyen_Chuc_Nang>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_527_PQCN_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Phan_Quyen_Chuc_Nang v_objRes = CUtility.Map_Row_To_Entity<CSys_Phan_Quyen_Chuc_Nang>(v_row);
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

        public CSys_Phan_Quyen_Chuc_Nang FQ_527_PQCN_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_Phan_Quyen_Chuc_Nang v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_527_PQCN_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Phan_Quyen_Chuc_Nang>(v_dt.Rows[0]);
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

        public long FQ_527_PQCN_sp_ins_Insert(CSys_Phan_Quyen_Chuc_Nang p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_527_PQCN_sp_ins_Insert",
                    p_objData.Nhom_Thanh_Vien_ID, p_objData.Chuc_Nang_ID, p_objData.Is_Have_View_Permission, p_objData.Is_Have_Add_Permission, p_objData.Is_Have_Edit_Permission,
                    p_objData.Is_Have_Delete_Permission, p_objData.Is_Have_Export_Permission, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_527_PQCN_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CSys_Phan_Quyen_Chuc_Nang p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_527_PQCN_sp_ins_Insert",
                    p_objData.Nhom_Thanh_Vien_ID, p_objData.Chuc_Nang_ID, p_objData.Is_Have_View_Permission, p_objData.Is_Have_Add_Permission, p_objData.Is_Have_Edit_Permission,
                    p_objData.Is_Have_Delete_Permission, p_objData.Is_Have_Export_Permission, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_527_PQCN_sp_upd_Update(CSys_Phan_Quyen_Chuc_Nang p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_527_PQCN_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Nhom_Thanh_Vien_ID, p_objData.Chuc_Nang_ID, p_objData.Is_Have_View_Permission, p_objData.Is_Have_Add_Permission, p_objData.Is_Have_Edit_Permission,
                    p_objData.Is_Have_Delete_Permission, p_objData.Is_Have_Export_Permission, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_527_PQCN_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CSys_Phan_Quyen_Chuc_Nang p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_527_PQCN_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Nhom_Thanh_Vien_ID, p_objData.Chuc_Nang_ID, p_objData.Is_Have_View_Permission, p_objData.Is_Have_Add_Permission, p_objData.Is_Have_Edit_Permission,
                    p_objData.Is_Have_Delete_Permission, p_objData.Is_Have_Export_Permission, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_527_PQCN_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_527_PQCN_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

  

		public void F1005_sp_upd_Phan_Quyen_Chuc_Nang_View(CSys_Phan_Quyen_Chuc_Nang p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "F1005_sp_upd_Phan_Quyen_Chuc_Nang_View",
					p_objData.Nhom_Thanh_Vien_ID, p_objData.Chuc_Nang_ID, p_objData.Is_Have_View_Permission, 
					p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
			}

			catch (Exception)
			{
				throw;
			}
		}

		public void F1005_sp_upd_Phan_Quyen_Chuc_Nang_Add(CSys_Phan_Quyen_Chuc_Nang p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "F1005_sp_upd_Phan_Quyen_Chuc_Nang_Add",
					p_objData.Nhom_Thanh_Vien_ID, p_objData.Chuc_Nang_ID, p_objData.Is_Have_Add_Permission,
					p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
			}

			catch (Exception)
			{
				throw;
			}
		}

		public void F1005_sp_upd_Phan_Quyen_Chuc_Nang_Edit(CSys_Phan_Quyen_Chuc_Nang p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "F1005_sp_upd_Phan_Quyen_Chuc_Nang_Edit",
					p_objData.Nhom_Thanh_Vien_ID, p_objData.Chuc_Nang_ID, p_objData.Is_Have_Edit_Permission,
					p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
			}

			catch (Exception)
			{
				throw;
			}
		}

		public void F1005_sp_upd_Phan_Quyen_Chuc_Nang_Delete(CSys_Phan_Quyen_Chuc_Nang p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "F1005_sp_upd_Phan_Quyen_Chuc_Nang_Delete",
					p_objData.Nhom_Thanh_Vien_ID, p_objData.Chuc_Nang_ID, p_objData.Is_Have_Delete_Permission,
					p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
			}

			catch (Exception)
			{
				throw;
			}
		}

		public void F1005_sp_upd_Phan_Quyen_Chuc_Nang_Export(CSys_Phan_Quyen_Chuc_Nang p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "F1005_sp_upd_Phan_Quyen_Chuc_Nang_Export",
					p_objData.Nhom_Thanh_Vien_ID, p_objData.Chuc_Nang_ID, p_objData.Is_Have_Export_Permission,
					p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
			}

			catch (Exception)
			{
				throw;
			}
		}

		
	}
}
