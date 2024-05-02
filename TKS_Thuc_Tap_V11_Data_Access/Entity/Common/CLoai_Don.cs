using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Common
{
	public class CLoai_Don
	{
		private long m_lngAuto_ID;
		private string m_strTen_Loai_Don;

		public CLoai_Don()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_strTen_Loai_Don = CConst.STR_VALUE_NULL;
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

		public string Ten_Loai_Don
		{
			get
			{
				return m_strTen_Loai_Don;
			}
			set
			{
				m_strTen_Loai_Don = value.Trim();
			}
		}
	}
}
