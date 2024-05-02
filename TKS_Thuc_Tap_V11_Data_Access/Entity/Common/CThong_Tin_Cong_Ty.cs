using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Common
{
    public class CThong_Tin_Cong_Ty
    {
        private string m_strCompany_Name;
        private string m_strCompany_Address;
        private string m_strCompany_Tel;
        private string m_strCompany_Fax;
        private string m_strCompany_Email;
        private string m_strCompany_Ten_Ngan_Hang;
        private string m_strCompany_So_Tai_Khoan;
        private string m_strReport_Logo_Url;

        public CThong_Tin_Cong_Ty()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strCompany_Name = CConst.STR_VALUE_NULL;
            m_strCompany_Address = CConst.STR_VALUE_NULL;
            m_strCompany_Tel = CConst.STR_VALUE_NULL;
            m_strCompany_Fax = CConst.STR_VALUE_NULL;
            m_strCompany_Email = CConst.STR_VALUE_NULL;
            m_strCompany_Ten_Ngan_Hang = CConst.STR_VALUE_NULL;
            m_strCompany_So_Tai_Khoan = CConst.STR_VALUE_NULL;
            m_strReport_Logo_Url =  CConst.STR_VALUE_NULL;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Company_Name
        {
            get
            {
                return m_strCompany_Name;
            }
            set
            {
                m_strCompany_Name = value.Trim();
            }
        }

        public string Company_Address
        {
            get
            {
                return m_strCompany_Address;
            }
            set
            {
                m_strCompany_Address = value.Trim();
            }
        }

        public string Company_Tel
        {
            get
            {
                return m_strCompany_Tel;
            }
            set
            {
                m_strCompany_Tel = value.Trim();
            }
        }

        public string Company_Fax
        {
            get
            {
                return m_strCompany_Fax;
            }
            set
            {
                m_strCompany_Fax = value.Trim();
            }
        }

        public string Company_Email
        {
            get
            {
                return m_strCompany_Email;
            }
            set
            {
                m_strCompany_Email = value.Trim();
            }
        }

        public string Company_Ten_Ngan_Hang
        {
            get
            {
                return m_strCompany_Ten_Ngan_Hang;
            }
            set
            {
                m_strCompany_Ten_Ngan_Hang = value.Trim();
            }
        }

        public string Company_So_Tai_Khoan
        {
            get
            {
                return m_strCompany_So_Tai_Khoan;
            }
            set
            {
                m_strCompany_So_Tai_Khoan = value.Trim();
            }
        }

        public string Report_Logo_Url
        {
            get
            {
                return m_strReport_Logo_Url;
            }
            set
            {
                m_strReport_Logo_Url = value.Trim();
            }
        }
    }
}
