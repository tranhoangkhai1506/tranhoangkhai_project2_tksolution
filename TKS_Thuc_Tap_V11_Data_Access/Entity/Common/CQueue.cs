using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Common
{
	public class CQueue
	{
		private long m_lngAuto_ID;  // 
		private DateTime m_dtmBegin_Time;  // 
		private DateTime m_dtmEnd_Time;  // 
		private string m_strMa_Chuc_Nang;  // 
		private string m_strTen_Chuc_Nang;  // 
		private string m_strTen_Function;  // 

		public CQueue()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = 0;
			m_dtmBegin_Time = DateTime.Now;
			m_dtmEnd_Time = DateTime.Now;
			m_strMa_Chuc_Nang = CConst.STR_VALUE_NULL;
			m_strTen_Chuc_Nang = CConst.STR_VALUE_NULL;
			m_strTen_Function = CConst.STR_VALUE_NULL;
		}

		/// <summary>
		/// 
		/// </summary>
		public long Auto_ID
		{
			get { return m_lngAuto_ID; }
			set
			{
				m_lngAuto_ID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public DateTime Ngay_Gio_Bat_Dau
		{
			get { return m_dtmBegin_Time; }
			set
			{
				m_dtmBegin_Time = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public DateTime End_Time
		{
			get { return m_dtmEnd_Time; }
			set
			{
				m_dtmEnd_Time = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string Ma_Chuc_Nang
		{
			get { return m_strMa_Chuc_Nang; }
			set
			{
				m_strMa_Chuc_Nang = value.Trim();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string Ten_Chuc_Nang
		{
			get { return m_strTen_Chuc_Nang; }
			set
			{
				m_strTen_Chuc_Nang = value.Trim();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string Ten_Function
		{
			get { return m_strTen_Function; }
			set
			{
				m_strTen_Function = value.Trim();
			}
		}

		public double So_Giay_Delay
		{
			get
			{
				return (DateTime.Now - Ngay_Gio_Bat_Dau).TotalSeconds;
			}
		}
	}
}
