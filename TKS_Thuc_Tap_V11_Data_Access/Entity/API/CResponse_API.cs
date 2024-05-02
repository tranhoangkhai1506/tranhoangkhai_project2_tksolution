using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.API
{
	public class CResponse_API
	{
		private CMessage m_objMessage = null;
		private object m_objData = null;

		public CResponse_API()
		{
			m_objMessage = new CMessage();
			m_objData = new object();
		}

		/// <summary>
		///asasdasd
		/// </summary>
		public CMessage Message
		{
			get { return m_objMessage; }
			set
			{
				m_objMessage = value;
			}
		}

		/// <summary>
		///
		/// </summary>
		public object Data
		{
			get { return m_objData; }
			set
			{
				m_objData = value;
			}
		}
		
	}
}