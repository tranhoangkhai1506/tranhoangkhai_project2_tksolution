using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TKS_Thuc_Tap_V11_Data_Access.Utility;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.DM
{
	public class CDM_San_Pham
	{
		private long m_lngAuto_ID;
		private string m_strMa_San_Pham;
		private string m_strTen_San_Pham;
		private long m_lngLoai_San_Pham_ID;
		private long m_lngDon_Vi_Tinh_ID;
		private string m_strGhi_Chu;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;

		public CDM_San_Pham()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_strMa_San_Pham = CConst.STR_VALUE_NULL;
			m_strTen_San_Pham = CConst.STR_VALUE_NULL;
			m_lngLoai_San_Pham_ID = CConst.INT_VALUE_NULL;
			m_lngDon_Vi_Tinh_ID = CConst.INT_VALUE_NULL;
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

		public string Ma_San_Pham
		{
			get
			{
				return m_strMa_San_Pham;
			}
			set
			{
				m_strMa_San_Pham = value.Trim();
			}
		}

		public string Ten_San_Pham
		{
			get
			{
				return m_strTen_San_Pham;
			}
			set
			{
				m_strTen_San_Pham = value.Trim();
			}
		}

		public long Loai_San_Pham_ID
		{
			get
			{
				return m_lngLoai_San_Pham_ID;
			}
			set
			{
				m_lngLoai_San_Pham_ID = value;
			}
		}
		public string Ten_Loai_San_Pham
		{
			get
			{
				var result = Loai_San_Pham_ID != 0 ? CCache_Loai_San_Pham.Get_Data_By_ID(Loai_San_Pham_ID).Ten_LSP : "UNKNONW";
				return result;
			}
		}
		public long Don_Vi_Tinh_ID
		{
			get
			{
				return m_lngDon_Vi_Tinh_ID;
			}
			set
			{
				m_lngDon_Vi_Tinh_ID = value;
			}
		}
		public string Ten_Don_Vi_Tinh
		{
			get
			{
				var result = Don_Vi_Tinh_ID != 0 ? CCache_Don_Vi_Tinh.Get_Data_By_ID(Don_Vi_Tinh_ID).Ten_Don_Vi_Tinh : "UNKNONW";
				return result;
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
