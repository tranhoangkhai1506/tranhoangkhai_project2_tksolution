using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
	public class CSys_Auto_Thread
	{
		private long m_lngAuto_ID;
		private int m_intThread_Type_ID;
		private int m_intDelay_Second;
		private int m_intSTT_Thread_ID;
		private string m_strGhi_Chu;
		private string m_strMa_Su_Dung;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;

		public CSys_Auto_Thread()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_intThread_Type_ID = CConst.INT_VALUE_NULL;
			m_intDelay_Second = CConst.INT_VALUE_NULL;
			m_intSTT_Thread_ID = CConst.INT_VALUE_NULL;
			m_strGhi_Chu = CConst.STR_VALUE_NULL;
			m_strMa_Su_Dung = CConst.STR_VALUE_NULL;
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

		public int Thread_Type_ID
		{
			get
			{
				return m_intThread_Type_ID;
			}
			set
			{
				m_intThread_Type_ID = value;
			}
		}

		public int Delay_Second
		{
			get
			{
				return m_intDelay_Second;
			}
			set
			{
				m_intDelay_Second = value;
			}
		}

		public int STT_Thread_ID
		{
			get
			{
				return m_intSTT_Thread_ID;
			}
			set
			{
				m_intSTT_Thread_ID = value;
			}
		}

		public string Ma_Su_Dung
		{
			get
			{
				return m_strMa_Su_Dung;
			}
			set
			{
				m_strMa_Su_Dung = value.Trim();
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

		public string Thread_Type_Text
		{
			get
			{
				string v_strRes = "";
				switch(Thread_Type_ID)
				{
					case (int)EThread_Type_ID.Lay_Du_Lieu_Tu_API_Source:v_strRes= "1: Lấy dữ liệu từ API Source"; break;
					case (int)EThread_Type_ID.Send_Data_Webhook: v_strRes= "2: Send data webhook"; break;
					case (int)EThread_Type_ID.Chay_Luong_Threath_Job: v_strRes= "3: Chạy luồng thread job"; break;
					case (int)EThread_Type_ID.Clear_Table_Temp: v_strRes= "5: Clear table temp"; break;
					case (int)EThread_Type_ID.Auto_Chay_Cac_Rule_Khai_Bao: v_strRes= "6: Auto chạy các rule khai báo"; break;
					case (int)EThread_Type_ID.Auto_Xoa_Log_File: v_strRes= "7: Auto xóa log file"; break;
					case (int)EThread_Type_ID.Auto_Chay_Daily_schedule_Joy: v_strRes= "8: Auto chạy daily schedule job"; break;
				}

				return v_strRes;
			}
		}		

		public string STT_Thread_Text
		{
			get
			{
				string v_strRes = "";
				switch (STT_Thread_ID)
				{
					case (int)ESTT_Threath.Thread_1: v_strRes= "1: Thread 1"; break;
					case (int)ESTT_Threath.Thread_2: v_strRes= "2: Thread 2"; break;
					case (int)ESTT_Threath.Thread_3: v_strRes= "3: Thread 3"; break;
					case (int)ESTT_Threath.Thread_4: v_strRes= "4: Thread 4"; break;
					case (int)ESTT_Threath.Thread_5: v_strRes= "5: Thread 5"; break;
					case (int)ESTT_Threath.Thread_6: v_strRes= "6: Thread 6"; break;
					case (int)ESTT_Threath.Thread_7: v_strRes= "7: Thread 7"; break;
					case (int)ESTT_Threath.Thread_8: v_strRes= "8: Thread 8"; break;
				}

				return v_strRes;
			}
		}
	}
}
