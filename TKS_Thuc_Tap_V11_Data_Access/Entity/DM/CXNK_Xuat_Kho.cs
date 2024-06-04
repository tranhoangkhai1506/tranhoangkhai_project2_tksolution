using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Controller.DM;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.DM
{
	public class CXNK_Xuat_Kho
	{
		private long m_lngAuto_ID;
		private string m_strSo_Phieu_Xuat_Kho;
		private long m_lngKho_ID;
		private string m_strTen_Kho;
		private DateTime? m_dtmNgay_Xuat_Kho;
		private string m_strGhi_Chu;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;
		public CXNK_Xuat_Kho()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_strSo_Phieu_Xuat_Kho = CConst.STR_VALUE_NULL;
			m_lngKho_ID = CConst.INT_VALUE_NULL;
			m_strTen_Kho = CConst.STR_VALUE_NULL;
			m_dtmNgay_Xuat_Kho = CConst.DTM_VALUE_NULL;
			m_strGhi_Chu = CConst.STR_VALUE_NULL;
			m_intdeleted = CConst.INT_VALUE_NULL;
			m_dtmCreated = CConst.DTM_VALUE_NULL;
			m_strCreated_By = CConst.STR_VALUE_NULL;
			m_strCreated_By_Function = CConst.STR_VALUE_NULL;
			m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
			m_strLast_Updated_By = CConst.STR_VALUE_NULL;
			m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
		}

		public long Auto_ID
		{
			get
			{
				return m_lngAuto_ID;
			}
			set
			{
				m_lngAuto_ID = value;
			}
		}

		public string So_Phieu_Xuat_Kho
		{
			get
			{
				return m_strSo_Phieu_Xuat_Kho;
			}
			set
			{
				m_strSo_Phieu_Xuat_Kho = value.Trim();
			}
		}

		public long Kho_ID
		{
			get
			{
				return m_lngKho_ID;
			}
			set
			{
				m_lngKho_ID = value;
			}
		}

		public string Ten_Kho
		{
			get
			{
				return m_strTen_Kho;
			}
			set
			{
				m_strTen_Kho = value.Trim();
			}
		}

		public DateTime? Ngay_Xuat_Kho
		{
			get
			{
				return m_dtmNgay_Xuat_Kho;
			}
			set
			{
				m_dtmNgay_Xuat_Kho = value;
			}
		}

		public string Ghi_Chu
		{
			get
			{
				return m_strGhi_Chu;
			}
			set
			{
				m_strGhi_Chu = value.Trim();
			}
		}

		public int deleted
		{
			get
			{
				return m_intdeleted;
			}
			set
			{
				m_intdeleted = value;
			}
		}

		public DateTime? Created
		{
			get
			{
				return m_dtmCreated;
			}
			set
			{
				m_dtmCreated = value;
			}
		}

		public string Created_By
		{
			get
			{
				return m_strCreated_By;
			}
			set
			{
				m_strCreated_By = value.Trim();
			}
		}

		public string Created_By_Function
		{
			get
			{
				return m_strCreated_By_Function;
			}
			set
			{
				m_strCreated_By_Function = value.Trim();
			}
		}

		public DateTime? Last_Updated
		{
			get
			{
				return m_dtmLast_Updated;
			}
			set
			{
				m_dtmLast_Updated = value;
			}
		}

		public string Last_Updated_By
		{
			get
			{
				return m_strLast_Updated_By;
			}
			set
			{
				m_strLast_Updated_By = value.Trim();
			}
		}

		public string Last_Updated_By_Function
		{
			get
			{
				return m_strLast_Updated_By_Function;
			}
			set
			{
				m_strLast_Updated_By_Function = value.Trim();
			}
		}
	}
}
