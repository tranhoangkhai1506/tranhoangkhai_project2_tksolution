using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.DataLayer;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.DM
{
	public class CXNK_Xuat_Kho_Raw_Data_Controller
	{
		public List<CXNK_Xuat_Kho_Raw_Data> FQ_734_XKRD_sp_sel_List_By_Created(DateTime? p_dtmFrom, DateTime? p_dtmTo)
		{
			List<CXNK_Xuat_Kho_Raw_Data> v_arrRes = new List<CXNK_Xuat_Kho_Raw_Data>();
			DataTable v_dt = new DataTable();

			try
			{
				p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
				p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

				CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_734_XKRD_sp_sel_List_By_Created", p_dtmFrom, p_dtmTo);

				foreach (DataRow v_row in v_dt.Rows)
				{
					CXNK_Xuat_Kho_Raw_Data v_objRes = CUtility.Map_Row_To_Entity<CXNK_Xuat_Kho_Raw_Data>(v_row);
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

		public List<CXNK_Xuat_Kho_Raw_Data> F2015_XKRD_sp_sel_List_Bao_Cao_Hang_Xuat(DateTime? p_dtmFrom, DateTime? p_dtmTo)
		{
			List<CXNK_Xuat_Kho_Raw_Data> v_arrRes = new List<CXNK_Xuat_Kho_Raw_Data>();
			DataTable v_dt = new DataTable();

			try
			{
				p_dtmFrom = CUtility_Date.Convert_To_Dau_Ngay(p_dtmFrom);
				p_dtmTo = CUtility_Date.Convert_To_Cuoi_Ngay(p_dtmTo);

				CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "F2015_XKRD_sp_sel_List_Bao_Cao_Hang_Xuat", p_dtmFrom, p_dtmTo);

				foreach (DataRow v_row in v_dt.Rows)
				{
					CXNK_Xuat_Kho_Raw_Data v_objRes = CUtility.Map_Row_To_Entity<CXNK_Xuat_Kho_Raw_Data>(v_row);
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
		public List<CXNK_Xuat_Kho_Raw_Data> F2013_XKRD_sp_sel_List_By_PhieuXuatID(long p_lngPhieuXuatID)
		{
			List<CXNK_Xuat_Kho_Raw_Data> v_arrRes = new List<CXNK_Xuat_Kho_Raw_Data>();
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "F2013_XKRD_sp_sel_List_By_PhieuXuatID", p_lngPhieuXuatID);

				foreach (DataRow v_row in v_dt.Rows)
				{
					CXNK_Xuat_Kho_Raw_Data v_objRes = CUtility.Map_Row_To_Entity<CXNK_Xuat_Kho_Raw_Data>(v_row);
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

		public CXNK_Xuat_Kho_Raw_Data FQ_734_XKRD_sp_sel_Get_By_ID(long p_iID)
		{
			CXNK_Xuat_Kho_Raw_Data v_objRes = null;
			DataTable v_dt = new DataTable();

			try
			{
				CSqlHelper.FillDataTable(CConfig.TKS_Thuc_Tap_V11_Conn_String, v_dt, "FQ_734_XKRD_sp_sel_Get_By_ID", p_iID);

				if (v_dt.Rows.Count > 0)
				{
					v_objRes = CUtility.Map_Row_To_Entity<CXNK_Xuat_Kho_Raw_Data>(v_dt.Rows[0]);
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

		public long FQ_734_XKRD_sp_ins_Insert(CXNK_Xuat_Kho_Raw_Data p_objData)
		{
			long v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_734_XKRD_sp_ins_Insert",
					p_objData.Xuat_Kho_ID, p_objData.San_Pham_ID, p_objData.SL_Xuat, p_objData.Don_Gia_Xuat, p_objData.Last_Updated_By,
					p_objData.Last_Updated_By_Function));
			}

			catch (Exception)
			{
				throw;
			}

			return v_iRes;
		}

		public long FQ_734_XKRD_sp_ins_Insert(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Xuat_Kho_Raw_Data p_objData)
		{
			long v_iRes = CConst.INT_VALUE_NULL;

			try
			{
				v_iRes = Convert.ToInt64(CSqlHelper.ExecuteScalar(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_734_XKRD_sp_ins_Insert",
					p_objData.Xuat_Kho_ID, p_objData.San_Pham_ID, p_objData.SL_Xuat, p_objData.Don_Gia_Xuat, p_objData.Last_Updated_By,
					p_objData.Last_Updated_By_Function));
			}

			catch (Exception)
			{
				throw;
			}

			return v_iRes;
		}

		public void FQ_734_XKRD_sp_upd_Update(CXNK_Xuat_Kho_Raw_Data p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_734_XKRD_sp_upd_Update", p_objData.Auto_ID,
					p_objData.Xuat_Kho_ID, p_objData.San_Pham_ID, p_objData.SL_Xuat, p_objData.Don_Gia_Xuat, p_objData.Last_Updated_By,
					p_objData.Last_Updated_By_Function);
			}

			catch (Exception)
			{
				throw;
			}
		}

		public void FQ_734_XKRD_sp_upd_Update(SqlConnection p_conn, SqlTransaction p_trans, CXNK_Xuat_Kho_Raw_Data p_objData)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(p_conn, p_trans, CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_734_XKRD_sp_upd_Update", p_objData.Auto_ID,
					p_objData.Xuat_Kho_ID, p_objData.San_Pham_ID, p_objData.SL_Xuat, p_objData.Don_Gia_Xuat, p_objData.Last_Updated_By,
					p_objData.Last_Updated_By_Function);
			}

			catch (Exception)
			{
				throw;
			}
		}

		public void FQ_734_XKRD_sp_del_Delete_By_ID(long p_iAuto_ID, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
		{
			try
			{
				CSqlHelper.ExecuteNonquery(CConfig.TKS_Thuc_Tap_V11_Conn_String, "FQ_734_XKRD_sp_del_Delete_By_ID", p_iAuto_ID, p_strLast_Updated_By, p_strLast_Updated_By_Function);
			}

			catch (Exception)
			{
				throw;
			}
		}

		// List thêm Raw Data tạm
		static List<CXNK_Xuat_Kho_Raw_Data> m_arrRawDataTemp = new List<CXNK_Xuat_Kho_Raw_Data>();

		public void Insert_Chi_Tiet_Xuat_Kho_Local(CXNK_Xuat_Kho_Raw_Data temp)
		{
			m_arrRawDataTemp.Add(temp);
		}

		public void Update_Chi_Tiet_Xuat_Kho_Local(CXNK_Xuat_Kho_Raw_Data temp)
		{
			CXNK_Xuat_Kho_Raw_Data existDetail = m_arrRawDataTemp.FirstOrDefault(p => p.Auto_ID == temp.Auto_ID);
			if (existDetail is not null)
			{
				existDetail.SL_Xuat = temp.SL_Xuat;
				existDetail.Don_Gia_Xuat = temp.Don_Gia_Xuat;
			}
		}

		public List<CXNK_Xuat_Kho_Raw_Data> Get_List_Chi_Tiet_Xuat_Kho_Local()
		{
			return m_arrRawDataTemp;
		}

		public void Clear_Chi_Tiet_Xuat_Kho_Local()
		{
			m_arrRawDataTemp.Clear();
		}

		public void Delete_By_ID_Chi_Tiet_Xuat_Kho_Local(long p_iID)
		{
			CXNK_Xuat_Kho_Raw_Data existDetail = m_arrRawDataTemp.FirstOrDefault(p => p.Auto_ID == p_iID);
			if (existDetail is not null)
			{
				m_arrRawDataTemp.Remove(existDetail);
			}
		}

		public CXNK_Xuat_Kho_Raw_Data Get_By_ID_Local(long p_iID)
		{
			return m_arrRawDataTemp.FirstOrDefault(p => p.Auto_ID == p_iID);
		}
	}
}
