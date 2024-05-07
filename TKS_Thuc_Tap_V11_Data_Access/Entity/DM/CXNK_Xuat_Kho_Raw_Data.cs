using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.DM
{
	public class CXNK_Xuat_Kho_Raw_Data
	{
		private long m_lngAuto_ID;
		private long m_lngXuat_Kho_ID;
		private long m_lngSan_Pham_ID;
		private double m_dblSL_Xuat;
		private double m_dblDon_Gia_Xuat;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;

		public CXNK_Xuat_Kho_Raw_Data()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_lngXuat_Kho_ID = CConst.INT_VALUE_NULL;
			m_lngSan_Pham_ID = CConst.INT_VALUE_NULL;
			m_dblSL_Xuat = CConst.FLT_VALUE_NULL;
			m_dblDon_Gia_Xuat = CConst.FLT_VALUE_NULL;
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

		public long Xuat_Kho_ID
		{
			get
			{
				return m_lngXuat_Kho_ID;
			}
			set
			{
				m_lngXuat_Kho_ID = value;
			}
		}

		public long San_Pham_ID
		{
			get
			{
				return m_lngSan_Pham_ID;
			}
			set
			{
				m_lngSan_Pham_ID = value;
			}
		}
		public string Ten_San_Pham
		{
			get
			{
				var result = San_Pham_ID != 0 ? CCache_San_Pham.Get_Data_By_ID(San_Pham_ID).Ten_San_Pham : "UNKNONW";
				return result;
			}
		}
		public double SL_Xuat
		{
			get
			{
				return m_dblSL_Xuat;
			}
			set
			{
				m_dblSL_Xuat = value;
			}
		}

		public double Don_Gia_Xuat
		{
			get
			{
				return m_dblDon_Gia_Xuat;
			}
			set
			{
				m_dblDon_Gia_Xuat = value;
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
