using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
	public class CSys_Phan_Quyen_Chuc_Nang
	{
		private long m_lngAuto_ID;
		private long m_lngNhom_Thanh_Vien_ID;
		private long m_lngChuc_Nang_ID;
		private bool m_blnIs_Have_View_Permission;
		private bool m_blnIs_Have_Add_Permission;
		private bool m_blnIs_Have_Edit_Permission;
		private bool m_blnIs_Have_Delete_Permission;
		private bool m_blnIs_Have_Export_Permission;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;

		public CSys_Phan_Quyen_Chuc_Nang()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_lngNhom_Thanh_Vien_ID = CConst.INT_VALUE_NULL;
			m_lngChuc_Nang_ID = CConst.INT_VALUE_NULL;
			m_blnIs_Have_View_Permission = CConst.BL_VALUE_NULL;
			m_blnIs_Have_Add_Permission = CConst.BL_VALUE_NULL;
			m_blnIs_Have_Edit_Permission = CConst.BL_VALUE_NULL;
			m_blnIs_Have_Delete_Permission = CConst.BL_VALUE_NULL;
			m_blnIs_Have_Export_Permission = CConst.BL_VALUE_NULL;
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

		public long Nhom_Thanh_Vien_ID
		{
			get
			{
				return m_lngNhom_Thanh_Vien_ID;
			}
			set
			{
				m_lngNhom_Thanh_Vien_ID = value;
			}
		}

		public long Chuc_Nang_ID
		{
			get
			{
				return m_lngChuc_Nang_ID;
			}
			set
			{
				m_lngChuc_Nang_ID = value;
			}
		}

		public bool Is_Have_View_Permission
		{
			get
			{
				return m_blnIs_Have_View_Permission;
			}
			set
			{
				m_blnIs_Have_View_Permission = value;
			}
		}

		public bool Is_Have_Add_Permission
		{
			get
			{
				return m_blnIs_Have_Add_Permission;
			}
			set
			{
				m_blnIs_Have_Add_Permission = value;
			}
		}

		public bool Is_Have_Edit_Permission
		{
			get
			{
				return m_blnIs_Have_Edit_Permission;
			}
			set
			{
				m_blnIs_Have_Edit_Permission = value;
			}
		}

		public bool Is_Have_Delete_Permission
		{
			get
			{
				return m_blnIs_Have_Delete_Permission;
			}
			set
			{
				m_blnIs_Have_Delete_Permission = value;
			}
		}

		public bool Is_Have_Export_Permission
		{
			get
			{
				return m_blnIs_Have_Export_Permission;
			}
			set
			{
				m_blnIs_Have_Export_Permission = value;
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
