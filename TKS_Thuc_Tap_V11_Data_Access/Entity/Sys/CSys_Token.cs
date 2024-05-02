using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
    public class CSys_Token
    {
        private long m_lngAuto_ID;
        private string m_strToken_ID;
        private string m_strMa_Dang_Nhap;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;
        private string m_strTen_Kho;
        private long m_lngNhom_PDA_ID;
        private string m_strTen_Nhom_PDA;
        private string m_strHo_Ten;
        private string m_strEmail;
        private string m_strDien_Thoai;
        private long m_lngKho_ID;
        private long m_lngChu_Hang_ID;
        private string m_strTen_Chu_Hang;
        private int m_intKhach_Hang_ID;

        private DateTime? m_dtmToken_Expired;

		public CSys_Token()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_strToken_ID = CConst.STR_VALUE_NULL;
            m_strMa_Dang_Nhap = CConst.STR_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
            m_strTen_Kho = CConst.STR_VALUE_NULL;
            m_lngNhom_PDA_ID = CConst.FLT_VALUE_NULL;
            m_strTen_Nhom_PDA = CConst.STR_VALUE_NULL;
            m_strHo_Ten = CConst.STR_VALUE_NULL;
            m_strEmail = CConst.STR_VALUE_NULL;
            m_strDien_Thoai = CConst.STR_VALUE_NULL;
            m_lngKho_ID = CConst.FLT_VALUE_NULL;
            m_lngChu_Hang_ID = CConst.FLT_VALUE_NULL;
            m_strTen_Chu_Hang = CConst.STR_VALUE_NULL;
            m_intKhach_Hang_ID = CConst.INT_VALUE_NULL;
			m_dtmToken_Expired = CConst.DTM_VALUE_NULL;
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

        public string Token_ID
        {
            get
            {
                return m_strToken_ID;
            }
            set
            {
                m_strToken_ID = value.Trim();
            }
        }

        public string Ma_Dang_Nhap
        {
            get
            {
                return m_strMa_Dang_Nhap;
            }
            set
            {
                m_strMa_Dang_Nhap = value.Trim();
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

        public long Nhom_PDA_ID
        {
            get
            {
                return m_lngNhom_PDA_ID;
            }
            set
            {
                m_lngNhom_PDA_ID = value;
            }
        }

        public string Ten_Kho
        {
            get
            {
                return m_strTen_Kho;
            }
            set
            {
                m_strTen_Kho = value.Trim();
            }
        }

        public string Ten_Nhom_PDA
        {
            get
            {
                return m_strTen_Nhom_PDA;
            }
            set
            {
                m_strTen_Nhom_PDA = value.Trim();
            }
        }

        public string Ho_Ten
        {
            get
            {
                return m_strHo_Ten;
            }
            set
            {
                m_strHo_Ten = value.Trim();
            }
        }

        public string Email
        {
            get
            {
                return m_strEmail;
            }
            set
            {
                m_strEmail = value.Trim();
            }
        }

        public string Dien_Thoai
        {
            get
            {
                return m_strDien_Thoai;
            }
            set
            {
                m_strDien_Thoai = value.Trim();
            }
        }

        public long Kho_ID
        {
            get
            {
                return m_lngKho_ID;
            }
            set
            {
                m_lngKho_ID = value;
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

		public int Khach_Hang_ID
		{
			get
			{
				return m_intKhach_Hang_ID;
			}
			set
			{
				m_intKhach_Hang_ID = value;
			}
		}

		public DateTime? Token_Expired
		{
			get
			{
				return m_dtmToken_Expired;
			}
			set
			{
				m_dtmToken_Expired = value;
			}
		}
	}
}
