using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using TKS_Thuc_Tap_V11_Data_Access.DataLayer;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Sys
{
    public class CSys_Grid_Field_Controller
    {
        public List<CSys_Grid_Field> FQ_514_GF_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_Grid_Field> v_arrRes = new List<CSys_Grid_Field>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_514_GF_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Grid_Field v_objRes = CUtility.Map_Row_To_Entity<CSys_Grid_Field>(v_row);
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

        public List<CSys_Grid_Field> FQ_514_GF_sp_sel_List_For_Cache()
        {
            List<CSys_Grid_Field> v_arrRes = new List<CSys_Grid_Field>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_514_GF_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Grid_Field v_objRes = CUtility.Map_Row_To_Entity<CSys_Grid_Field>(v_row);
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

        public List<CSys_Grid_Field> FQ_514_GF_sp_sel_List_By_Ma_Chuc_Nang(string p_strMa_Chuc_Nang)
        {
            List<CSys_Grid_Field> v_arrRes = new List<CSys_Grid_Field>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_514_GF_sp_sel_List_By_Ma_Chuc_Nang", p_strMa_Chuc_Nang);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Grid_Field v_objRes = CUtility.Map_Row_To_Entity<CSys_Grid_Field>(v_row);
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


        public List<CSys_Grid_Field> FQ_514_GF_sp_sel_List_By_Ma_CN_A_Ten_Grid(string p_strMa_Chuc_Nang, string p_strTen_Grid)
        {
            List<CSys_Grid_Field> v_arrRes = new List<CSys_Grid_Field>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_514_GF_sp_sel_List_By_Ma_CN_A_Ten_Grid", p_strMa_Chuc_Nang, p_strTen_Grid);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Grid_Field v_objRes = CUtility.Map_Row_To_Entity<CSys_Grid_Field>(v_row);
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

        public CSys_Grid_Field FQ_514_GF_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_Grid_Field v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_514_GF_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Grid_Field>(v_dt.Rows[0]);
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

        public long FQ_514_GF_sp_ins_Insert(CSys_Grid_Field p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_514_GF_sp_ins_Insert",
                    p_objData.Ten_Grid, p_objData.Ma_Chuc_Nang, p_objData.Field_Name, p_objData.Tieu_De_Column, p_objData.Column_Width,
                    p_objData.Field_Type_ID, p_objData.Field_Name_Parent, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

      

        public long FQ_514_GF_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CSys_Grid_Field p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_514_GF_sp_ins_Insert",
                    p_objData.Ten_Grid, p_objData.Ma_Chuc_Nang, p_objData.Field_Name, p_objData.Tieu_De_Column, p_objData.Column_Width,
                    p_objData.Field_Type_ID, p_objData.Field_Name_Parent, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_514_GF_sp_upd_Update(CSys_Grid_Field p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_514_GF_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Ten_Grid, p_objData.Ma_Chuc_Nang, p_objData.Field_Name, p_objData.Tieu_De_Column, p_objData.Column_Width,
                    p_objData.Field_Type_ID, p_objData.Field_Name_Parent, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_514_GF_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CSys_Grid_Field p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_514_GF_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Ten_Grid, p_objData.Ma_Chuc_Nang, p_objData.Field_Name, p_objData.Tieu_De_Column, p_objData.Column_Width,
                    p_objData.Field_Type_ID, p_objData.Field_Name_Parent, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_514_GF_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_514_GF_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }
        
        public void FDev_004_Truncate_Sys_Grid_Field_All()
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FDev_004_sp_Truncate_Sys_Grid_Field_All");
            }

            catch (Exception)
            {
                throw;
            }
        }        

        public long FDev_004_sp_ins_Cau_Hinh_Grid_Field_From_API(CSys_Grid_Field p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FDev_004_sp_ins_Cau_Hinh_Grid_Field_From_API", p_objData.Auto_ID,
                    p_objData.Ten_Grid, p_objData.Ma_Chuc_Nang, p_objData.Field_Name, p_objData.Tieu_De_Column, p_objData.Column_Width, p_objData.Field_Type_ID, p_objData.Field_Name_Parent,
					p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }
        public List<CSys_Grid_Field> FAPI_1044_List_Sys_Grid_Field()
		{
			List<CSys_Grid_Field> v_arrRes = new List<CSys_Grid_Field>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FAPI_1044_sp_sel_List_Sys_Grid_Field");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CSys_Grid_Field v_objRes = CUtility.Map_Row_To_Entity<CSys_Grid_Field>(v_row);
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
