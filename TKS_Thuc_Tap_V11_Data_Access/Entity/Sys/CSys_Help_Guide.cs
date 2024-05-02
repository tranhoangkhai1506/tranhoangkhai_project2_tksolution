using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
	public class CSys_Help_Guide
	{
		private long m_lngAuto_ID;
		private int m_lngKhach_Hang_ID;
		private string m_strMa_Chuc_Nang;
		private string m_strNgon_Ngu;
		private string m_strNoi_Dung;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;

		public CSys_Help_Guide()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_lngKhach_Hang_ID = CConst.INT_VALUE_NULL;
			m_strMa_Chuc_Nang = CConst.STR_VALUE_NULL;
			m_strNgon_Ngu = CConst.STR_VALUE_NULL;
			m_strNoi_Dung = CConst.STR_VALUE_NULL;
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

		public int Khach_Hang_ID
		{
			get
			{
				return m_lngKhach_Hang_ID;
			}
			set
			{
				m_lngKhach_Hang_ID = value;
			}
		}

		public string Ma_Chuc_Nang
		{
			get
			{
				return m_strMa_Chuc_Nang;
			}
			set
			{
				m_strMa_Chuc_Nang = value.Trim();
			}
		}

		public string Ngon_Ngu
		{
			get
			{
				return m_strNgon_Ngu;
			}
			set
			{
				m_strNgon_Ngu = value.Trim();
			}
		}

		public string Noi_Dung
		{
			get
			{
				return m_strNoi_Dung;
			}
			set
			{
				m_strNoi_Dung = value.Trim();
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

		public string Khach_Hang_Text
		{
			get
			{
				string v_strRes = "";
				if (Khach_Hang_ID == 1)
					v_strRes = "TKS";

				return v_strRes;
			}
		}
	}
}
