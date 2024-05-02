using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
	public class CSys_Hien_An_Column
	{
		private long m_lngAuto_ID;
		private long m_lngChu_Hang_ID;
		private string m_strField_Name;
		private int m_intOption_ID;
		private string m_strMa_Chuc_Nang;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;

		public CSys_Hien_An_Column()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_lngChu_Hang_ID = CConst.INT_VALUE_NULL;
			m_strField_Name = CConst.STR_VALUE_NULL;
			m_intOption_ID = CConst.INT_VALUE_NULL;
			m_strMa_Chuc_Nang = CConst.STR_VALUE_NULL;
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

		public string Field_Name
		{
			get
			{
				return m_strField_Name;
			}
			set
			{
				m_strField_Name = value.Trim();
			}
		}

		public int Option_ID
		{
			get
			{
				return m_intOption_ID;
			}
			set
			{
				m_intOption_ID = value;
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

		public string Option_Text
		{
			get
			{
				string v_strRes = "";

				switch (Option_ID)
				{
					case (int)EHien_An_Option_ID.Visible: v_strRes = "Hiện"; break;
					case (int)EHien_An_Option_ID.Hide: v_strRes = "Ẩn"; break;
				}

				return v_strRes;
			}
		}

		public string Ten_Viet_Tat
		{
			get
			{
				string v_strRes = "";

				//switch (Chu_Hang_ID)
				//{
				//	case -5: v_strRes = "Tất cả"; break;
				//}
				if(Chu_Hang_ID != -5)
				{
					CDM_Chu_Hang v_objData = CCache_Chu_Hang.Get_Data_By_ID(Chu_Hang_ID);
					if (v_objData != null)
					{
						v_strRes = v_objData.Ten_Viet_Tat;
					}
					else
						v_strRes = "NULL";
				}
				else
				{
					v_strRes = "Tất cả";
				}

				return v_strRes;
			}
		}
	}
}
