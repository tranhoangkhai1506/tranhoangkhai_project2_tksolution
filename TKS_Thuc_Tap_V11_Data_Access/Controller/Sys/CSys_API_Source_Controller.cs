﻿using Microsoft.Data.SqlClient;
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
	public class CSys_API_Source_Controller
	{
        public List<CSys_API_Source> FQ_501_AS_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_API_Source> v_arrRes = new List<CSys_API_Source>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_501_AS_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_API_Source v_objRes = CUtility.Map_Row_To_Entity<CSys_API_Source>(v_row);
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

        public List<CSys_API_Source> FQ_501_AS_sp_sel_List_For_Cache()
        {
            List<CSys_API_Source> v_arrRes = new List<CSys_API_Source>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_501_AS_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_API_Source v_objRes = CUtility.Map_Row_To_Entity<CSys_API_Source>(v_row);
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
        public List<CSys_API_Source> FQ_501_AS_sp_sel_List()
        {
            List<CSys_API_Source> v_arrRes = new List<CSys_API_Source>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_501_AS_sp_sel_List");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_API_Source v_objRes = CUtility.Map_Row_To_Entity<CSys_API_Source>(v_row);
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


        public CSys_API_Source FQ_501_AS_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_API_Source v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_501_AS_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_API_Source>(v_dt.Rows[0]);
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

        public long FQ_501_AS_sp_ins_Insert(CSys_API_Source p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_501_AS_sp_ins_Insert",
                    p_objData.Ma_API_Source, p_objData.Ten_API_Source, p_objData.Link_API, p_objData.User_Name, p_objData.Password,
                    p_objData.Token_1, p_objData.Token_2, p_objData.Client_ID_1, p_objData.Client_ID_2, p_objData.Url_Folder_Download, p_objData.Url_Folder_Upload,
                    p_objData.Url_Folder_Download_BAK, p_objData.Url_Folder_Upload_BAK, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public long FQ_501_AS_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CSys_API_Source p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_501_AS_sp_ins_Insert",
                    p_objData.Ma_API_Source, p_objData.Ten_API_Source, p_objData.Link_API, p_objData.User_Name, p_objData.Password,
                    p_objData.Token_1, p_objData.Token_2, p_objData.Client_ID_1, p_objData.Client_ID_2, p_objData.Url_Folder_Download, p_objData.Url_Folder_Upload,
                    p_objData.Url_Folder_Download_BAK, p_objData.Url_Folder_Upload_BAK, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }

        public void FQ_501_AS_sp_upd_Update(CSys_API_Source p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_501_AS_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Ma_API_Source, p_objData.Ten_API_Source, p_objData.Link_API, p_objData.User_Name, p_objData.Password,
                    p_objData.Token_1, p_objData.Token_2, p_objData.Client_ID_1, p_objData.Client_ID_2, p_objData.Url_Folder_Download, p_objData.Url_Folder_Upload,
                    p_objData.Url_Folder_Download_BAK, p_objData.Url_Folder_Upload_BAK, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_501_AS_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CSys_API_Source p_objData)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_501_AS_sp_upd_Update", p_objData.Auto_ID,
                    p_objData.Ma_API_Source, p_objData.Ten_API_Source, p_objData.Link_API, p_objData.User_Name, p_objData.Password,
                    p_objData.Token_1, p_objData.Token_2, p_objData.Client_ID_1, p_objData.Client_ID_2, p_objData.Url_Folder_Download, p_objData.Url_Folder_Upload,
                    p_objData.Url_Folder_Download_BAK, p_objData.Url_Folder_Upload_BAK, p_objData.Ghi_Chu, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public void FQ_501_AS_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_501_AS_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

 
		/// <summary>
		/// vì hàm truyền Data về AD chỉ có 1 link API duy nhất, chỉ dùng cho AD
		/// </summary>
		/// <param name="p_iID"></param>
		/// <returns></returns>
		public CSys_API_Source FAD_Common_Get_Sys_API_Source_AD_Top_1()
		{
			CSys_API_Source v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FAD_Common_sp_sel_Get_Sys_API_Source_Top_1");

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = CUtility.Map_Row_To_Entity<CSys_API_Source>(v_dt.Rows[0]);
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

        public CSys_API_Source FQ_501_AS_sp_sel_Get_By_By_Ma_API_Source(string p_strMa_API_Source)
        {
            CSys_API_Source v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_501_AS_sp_sel_Get_By_Ma_API_Source", p_strMa_API_Source);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_API_Source>(v_dt.Rows[0]);
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

	}
}