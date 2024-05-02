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
	public class CSys_Chuc_Nang_App_Controller
	{
       
        public List<CSys_Chuc_Nang_App> FQ_508_CNA_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
        {
            List<CSys_Chuc_Nang_App> v_arrRes = new List<CSys_Chuc_Nang_App>();
            DataTable v_dt = new DataTable();

            try
            {
                p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
                p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_508_CNA_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Chuc_Nang_App v_objRes = CUtility.Map_Row_To_Entity<CSys_Chuc_Nang_App>(v_row);
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

        public List<CSys_Chuc_Nang_App> FQ_508_CNA_sp_sel_List_For_Cache()
        {
            List<CSys_Chuc_Nang_App> v_arrRes = new List<CSys_Chuc_Nang_App>();
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_508_CNA_sp_sel_List_For_Cache");

                foreach (DataRow v_row in v_dt.Rows)
                {
                    CSys_Chuc_Nang_App v_objRes = CUtility.Map_Row_To_Entity<CSys_Chuc_Nang_App>(v_row);
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

        public CSys_Chuc_Nang_App FQ_508_CNA_sp_sel_Get_By_ID(long p_iID)
        {
            CSys_Chuc_Nang_App v_objRes = null;
            DataTable v_dt = new DataTable();

            try
            {
                CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_508_CNA_sp_sel_Get_By_ID", p_iID);

                if (v_dt.Rows.Count > 0)
                {
                    v_objRes = CUtility.Map_Row_To_Entity<CSys_Chuc_Nang_App>(v_dt.Rows[0]);
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

        public long FQ_508_CNA_sp_ins_Insert(CSys_Chuc_Nang_App p_objData)
        {
            long v_iRes = CConst.INT_VALUE_NULL;

            try
            {
                v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_508_CNA_sp_ins_Insert",
                    p_objData.Nhom_PDA_ID, p_objData.FApp_M01_ID, p_objData.FApp_M01_Label, p_objData.FApp_M02_ID, p_objData.FApp_M02_Label, p_objData.FApp_M03_ID,
                    p_objData.FApp_M03_Label, p_objData.FApp_M04_ID, p_objData.FApp_M04_Label, p_objData.FApp_M05_ID, p_objData.FApp_M05_Label, p_objData.FApp_M06_ID,
                    p_objData.FApp_M06_Label, p_objData.FApp_M07_ID, p_objData.FApp_M07_Label, p_objData.FApp_M08_ID, p_objData.FApp_M08_Label, p_objData.FApp_M09_ID,
                    p_objData.FApp_M09_Label, p_objData.FApp_M10_ID, p_objData.FApp_M10_Label, p_objData.FApp_M11_ID, p_objData.FApp_M11_Label, p_objData.FApp_M12_ID,
                    p_objData.FApp_M12_Label, p_objData.FApp_M13_ID, p_objData.FApp_M13_Label, p_objData.FApp_M14_ID, p_objData.FApp_M14_Label, p_objData.FApp_M15_ID,
                    p_objData.FApp_M15_Label, p_objData.FApp_M16_ID, p_objData.FApp_M16_Label, p_objData.FApp_M17_ID, p_objData.FApp_M17_Label, p_objData.FApp_M18_ID,
                    p_objData.FApp_M18_Label, p_objData.FApp_M19_ID, p_objData.FApp_M19_Label, p_objData.FApp_M20_ID, p_objData.FApp_M20_Label, p_objData.FApp_M21_ID,
                    p_objData.FApp_M21_Label, p_objData.FApp_M22_ID, p_objData.FApp_M22_Label, p_objData.FApp_M23_ID, p_objData.FApp_M23_Label, p_objData.FApp_M24_ID,
                    p_objData.FApp_M24_Label, p_objData.FApp_M25_ID, p_objData.FApp_M25_Label, p_objData.FApp_M26_ID, p_objData.FApp_M26_Label, p_objData.FApp_M27_ID,
                    p_objData.FApp_M27_Label, p_objData.FApp_M28_ID, p_objData.FApp_M28_Label, p_objData.FApp_M29_ID, p_objData.FApp_M29_Label, p_objData.FApp_M30_ID,
                    p_objData.FApp_M30_Label, p_objData.FApp_M31_ID, p_objData.FApp_M31_Label, p_objData.FApp_M32_ID, p_objData.FApp_M32_Label, p_objData.FApp_M33_ID,
                    p_objData.FApp_M33_Label, p_objData.FApp_M34_ID, p_objData.FApp_M34_Label, p_objData.FApp_M35_ID, p_objData.FApp_M35_Label, p_objData.FApp_M36_ID,
                    p_objData.FApp_M36_Label, p_objData.FApp_M37_ID, p_objData.FApp_M37_Label, p_objData.FApp_M38_ID, p_objData.FApp_M38_Label, p_objData.FApp_M39_ID,
                    p_objData.FApp_M39_Label, p_objData.FApp_M40_ID, p_objData.FApp_M40_Label, p_objData.FApp_M41_ID, p_objData.FApp_M41_Label, p_objData.FApp_M42_ID,
                    p_objData.FApp_M42_Label, p_objData.FApp_M43_ID, p_objData.FApp_M43_Label, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function));
            }

            catch (Exception)
            {
                throw;
            }

            return v_iRes;
        }     

       
		public void FQ_508_CNA_sp_upd_Update(CSys_Chuc_Nang_App p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_508_CNA_sp_upd_Update",
					p_objData.Auto_ID, p_objData.Nhom_PDA_ID, p_objData.FApp_M01_ID, p_objData.FApp_M01_Label, p_objData.FApp_M02_ID, p_objData.FApp_M02_Label,
					p_objData.FApp_M03_ID, p_objData.FApp_M03_Label, p_objData.FApp_M04_ID, p_objData.FApp_M04_Label, p_objData.FApp_M05_ID, p_objData.FApp_M05_Label,
					p_objData.FApp_M06_ID, p_objData.FApp_M06_Label, p_objData.FApp_M07_ID, p_objData.FApp_M07_Label, p_objData.FApp_M08_ID, p_objData.FApp_M08_Label,
					p_objData.FApp_M09_ID, p_objData.FApp_M09_Label, p_objData.FApp_M10_ID, p_objData.FApp_M10_Label, p_objData.FApp_M11_ID, p_objData.FApp_M11_Label,
					p_objData.FApp_M12_ID, p_objData.FApp_M12_Label, p_objData.FApp_M13_ID, p_objData.FApp_M13_Label, p_objData.FApp_M14_ID, p_objData.FApp_M14_Label,
					p_objData.FApp_M15_ID, p_objData.FApp_M15_Label, p_objData.FApp_M16_ID, p_objData.FApp_M16_Label, p_objData.FApp_M17_ID, p_objData.FApp_M17_Label,
					p_objData.FApp_M18_ID, p_objData.FApp_M18_Label, p_objData.FApp_M19_ID, p_objData.FApp_M19_Label, p_objData.FApp_M20_ID, p_objData.FApp_M20_Label,
					p_objData.FApp_M21_ID, p_objData.FApp_M21_Label, p_objData.FApp_M22_ID, p_objData.FApp_M22_Label, p_objData.FApp_M23_ID, p_objData.FApp_M23_Label,
					p_objData.FApp_M24_ID, p_objData.FApp_M24_Label, p_objData.FApp_M25_ID, p_objData.FApp_M25_Label, p_objData.FApp_M26_ID, p_objData.FApp_M26_Label,
					p_objData.FApp_M27_ID, p_objData.FApp_M27_Label, p_objData.FApp_M28_ID, p_objData.FApp_M28_Label, p_objData.FApp_M29_ID, p_objData.FApp_M29_Label,
					p_objData.FApp_M30_ID, p_objData.FApp_M30_Label, p_objData.FApp_M31_ID, p_objData.FApp_M31_Label, p_objData.FApp_M32_ID, p_objData.FApp_M32_Label,
					p_objData.FApp_M33_ID, p_objData.FApp_M33_Label, p_objData.FApp_M34_ID, p_objData.FApp_M34_Label, p_objData.FApp_M35_ID, p_objData.FApp_M35_Label,
					p_objData.FApp_M36_ID, p_objData.FApp_M36_Label, p_objData.FApp_M37_ID, p_objData.FApp_M37_Label, p_objData.FApp_M38_ID, p_objData.FApp_M38_Label,
					p_objData.FApp_M39_ID, p_objData.FApp_M39_Label, p_objData.FApp_M40_ID, p_objData.FApp_M40_Label, p_objData.FApp_M41_ID, p_objData.FApp_M41_Label,
					p_objData.FApp_M42_ID, p_objData.FApp_M42_Label, p_objData.FApp_M43_ID, p_objData.FApp_M43_Label, p_objData.Last_Updated_By, p_objData.Last_Updated_By_Function);
			}

			catch (Exception)
			{
				throw;
			}
		}		

        public void FQ_508_CNA_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            try
            {
                CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_508_CNA_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
            }

            catch (Exception)
            {
                throw;
            }
        }

  
		/// <summary>
		/// lấy danh sách chức năng PDA
		/// </summary>
		/// <returns></returns>
		public List<CSys_Chuc_Nang_App> F1023_sp_sel_List_FApp_Func()
		{
			List<CSys_Chuc_Nang_App> v_arrRes = new List<CSys_Chuc_Nang_App>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "F1023_sp_sel_List_FApp_Func");

				foreach (DataRow v_row in v_dt.Rows)
				{
					CSys_Chuc_Nang_App v_objRes = CUtility.Map_Row_To_Entity<CSys_Chuc_Nang_App>(v_row);
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
