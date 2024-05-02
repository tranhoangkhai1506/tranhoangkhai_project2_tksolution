using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.API
{
    public class CAuth
    {
        private string m_strToken;  // 
        private string m_strMa_Dang_Nhap;
        private int m_intType_ID;  // 
        private int m_intPrototype_ID;  // 
        private string m_strDevice_ID;  // 
        private string m_strFunction_Name;

        public CAuth()
        {
            ResetData();
        }

        /// <summary>
        /// Reset Data to default value
        /// </summary>
        public void ResetData()
        {
            m_strToken = CConst.STR_VALUE_NULL;
            m_strMa_Dang_Nhap = CConst.STR_VALUE_NULL;
            m_intType_ID = CConst.INT_VALUE_NULL;
            m_intPrototype_ID = CConst.INT_VALUE_NULL;
            m_strFunction_Name = CConst.STR_VALUE_NULL;
            m_strDevice_ID = CConst.STR_VALUE_NULL;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Token
        {
            get { return m_strToken; }
            set
            {
                m_strToken = value.Trim();
            }
        }

        public string Ma_Dang_Nhap
        {
            get { return m_strMa_Dang_Nhap; }
            set
            {
                m_strMa_Dang_Nhap = value.Trim();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Type_ID
        {
            get { return m_intType_ID; }
            set
            {
                m_intType_ID = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Prototype_ID
        {
            get { return m_intPrototype_ID; }
            set
            {
                m_intPrototype_ID = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Device_ID
        {
            get { return m_strDevice_ID; }
            set
            {
                m_strDevice_ID = value.Trim();
            }
        }

        public string Function_Name
        {
            get { return m_strFunction_Name; }
            set
            {
                m_strFunction_Name = value;
            }
        }
    }
}
