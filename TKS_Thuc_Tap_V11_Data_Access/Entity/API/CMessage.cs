using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.API
{
	public class CMessage
	{
		private int m_intMessage_Code;  // 
		private string m_strMessage_Desc;  // 
		private string m_strFragment_Code;
		public CMessage()
		{
			ResetData();
		}
		/// <summary>
		/// Reset Data to default value
		/// </summary>
		public void ResetData()
		{
			m_intMessage_Code = CConst.INT_VALUE_NULL;
			m_strMessage_Desc = CConst.STR_VALUE_NULL;
			m_strFragment_Code = CConst.STR_VALUE_NULL;
		}

		/// <summary>
		/// 
		/// </summary>
		public int Message_Code
		{
			get { return m_intMessage_Code; }
			set
			{
				m_intMessage_Code = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string Message_Desc
		{
			get { return m_strMessage_Desc; }
			set
			{
				m_strMessage_Desc = value.Trim();
			}
		}

		public string Fragment_Code
		{
			get { return m_strFragment_Code; }
			set
			{
				m_strFragment_Code = value.Trim();
			}
		}
	}
}