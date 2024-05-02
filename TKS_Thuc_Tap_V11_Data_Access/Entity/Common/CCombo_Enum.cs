using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Common
{
    public class CCombo_Enum
    {
        private int m_intValue;
        private string m_strText;
        private string m_strText_Value;

        public CCombo_Enum()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_intValue = CConst.INT_VALUE_NULL;
            m_strText = CConst.STR_VALUE_NULL;
            m_strText_Value = CConst.STR_VALUE_NULL;
        }

        public int Value
        {
            get
            {
                return m_intValue;
            }
            set
            {
                m_intValue = value;
            }
        }

        public string Text
        {
            get
            {
                return m_strText;
            }
            set
            {
                m_strText = value.Trim();
            }
        }

        public string Text_Value
        {
            get
            {
                return m_strText_Value;
            }
            set
            {
                m_strText_Value = value.Trim();
            }
        }
    }
}
