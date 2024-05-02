using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
	public class CSys_Import_Excel_Template_Config
	{
		private long m_lngAuto_ID;
		private long m_lngChu_Hang_ID;
		
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;
		
		private string m_strMa_Chu_Hang;
		private string m_strTen_Viet_Tat;
		private string m_strTen_Chu_Hang;

        public CSys_Import_Excel_Template_Config()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_lngChu_Hang_ID = CConst.INT_VALUE_NULL;
			
			m_intdeleted = CConst.INT_VALUE_NULL;
			m_dtmCreated = CConst.DTM_VALUE_NULL;
			m_strCreated_By = CConst.STR_VALUE_NULL;
			m_strCreated_By_Function = CConst.STR_VALUE_NULL;
			m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
			m_strLast_Updated_By = CConst.STR_VALUE_NULL;
			m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
			m_strMa_Chu_Hang = CConst.STR_VALUE_NULL;
			m_strTen_Viet_Tat = CConst.STR_VALUE_NULL;
			m_strTen_Chu_Hang = CConst.STR_VALUE_NULL;
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

		public long Chu_Hang_ID
		{
			get
			{
				return m_lngChu_Hang_ID;
			}
			set
			{
				m_lngChu_Hang_ID = value;
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

		public string Ma_Chu_Hang
		{
			get
			{
				return m_strMa_Chu_Hang;
			}
			set
			{
				m_strMa_Chu_Hang = value.Trim();
			}
		}

		public string Ten_Viet_Tat
		{
			get
			{
				return m_strTen_Viet_Tat;
			}
			set
			{
				m_strTen_Viet_Tat = value.Trim();
			}
		}

		public string Ten_Chu_Hang
		{
			get
			{
				return m_strTen_Chu_Hang;
			}
			set
			{
				m_strTen_Chu_Hang = value.Trim();
			}
		}
    }
}
