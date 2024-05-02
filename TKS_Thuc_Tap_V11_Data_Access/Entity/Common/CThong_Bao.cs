using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Common
{
    public class CThong_Bao
    {
        private long m_intMes_ID;
        private string m_strMes_No;
        private string m_strMessage_Desc;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        public CThong_Bao()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_intMes_ID = CConst.INT_VALUE_NULL;
            m_strMes_No = CConst.STR_VALUE_NULL;
            m_strMessage_Desc = CConst.STR_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
        }

        /// <summary>
        /// 
        /// </summary>
        public long Mes_ID
        {
            get
            {
                return m_intMes_ID;
            }
            set
            {
                m_intMes_ID = value;
            }
        }
        public string Mes_No
        {
            get
            {
                return m_strMes_No;
            }
            set
            {
                m_strMes_No = value.Trim();
            }
        }

        public string Message_Desc
        {
            get
            {
                return m_strMessage_Desc;
            }
            set
            {
                m_strMessage_Desc = value.Trim();
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
    }
}
