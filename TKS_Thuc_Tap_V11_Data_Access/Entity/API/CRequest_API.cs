using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.API
{
    public class CRequest_API
    {
        private string m_strToKen;
        private CAuth m_objAuth = null;
        private long m_lngKho_ID;
        private string m_strLang_ID;
        private object m_objData = null;
        private long m_lngChu_Hang_ID;
		private string m_strFunction_PDA;
		private bool? m_blKhong_Can_Check_Lai;//dùng làm xác nhận lần 2 khi bỏ qua thông báo
	
		public CRequest_API()
        {
            m_objAuth = new CAuth();
            m_lngKho_ID = CConst.FLT_VALUE_NULL;
            m_strLang_ID = CConst.STR_VALUE_NULL;
            m_lngChu_Hang_ID = CConst.FLT_VALUE_NULL;
			m_strFunction_PDA = CConst.STR_VALUE_NULL;
			m_objData = new object();
            m_strToKen = CConst.STR_VALUE_NULL;
			m_blKhong_Can_Check_Lai = CConst.BL_VALUE_NULL;
          

        }

        /// <summary>
        ///
        /// </summary>
        public CAuth Auth
        {
            get { return m_objAuth; }
            set
            {
                m_objAuth = value;
            }
        }

        public long Kho_ID
        {
            get { return m_lngKho_ID; }
            set
            {
                m_lngKho_ID = value;
            }
        }

		public long Chu_Hang_ID
		{
			get { return m_lngChu_Hang_ID; }
			set
			{
				m_lngChu_Hang_ID = value;
			}
		}

		public string Lang_ID
		{
			get { return m_strLang_ID; }
			set
			{
				m_strLang_ID = value;
			}
		}

		public string Function_PDA
		{
			get
			{
				return m_strFunction_PDA;
			}
			set
			{
				m_strFunction_PDA = value.Trim();
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

		/// <summary>
		/// 
		/// </summary>
		public string ToKen
		{
			get { return m_strToKen; }
			set
			{
				m_strToKen = value;
			}
		}

		public bool? Khong_Can_Check_Lai
		{
			get { return m_blKhong_Can_Check_Lai; }
			set
			{
				m_blKhong_Can_Check_Lai = value;
			}
		}
	

    }
}
