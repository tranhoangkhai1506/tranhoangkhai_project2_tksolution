using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
    public class CSys_Language
    {
        private long m_lngAuto_ID;
        private string m_strField_Name;
        private string m_strLang_1;
        private string m_strLang_2;
        private string m_strLang_3;
        private string m_strLang_4;
        private string m_strLang_5;
        private int m_intType_ID;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        public CSys_Language()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_strField_Name = CConst.STR_VALUE_NULL;
            m_strLang_1 = CConst.STR_VALUE_NULL;
            m_strLang_2 = CConst.STR_VALUE_NULL;
            m_strLang_3 = CConst.STR_VALUE_NULL;
            m_strLang_4 = CConst.STR_VALUE_NULL;
            m_strLang_5 = CConst.STR_VALUE_NULL;
            m_intType_ID = CConst.INT_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
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

        public string Field_Name
        {
            get
            {
                return m_strField_Name;
            }
            set
            {
                m_strField_Name = value.Trim();
            }
        }

        public string Lang_1
        {
            get
            {
                return m_strLang_1;
            }
            set
            {
                m_strLang_1 = value.Trim();
            }
        }

        public string Lang_2
        {
            get
            {
                return m_strLang_2;
            }
            set
            {
                m_strLang_2 = value.Trim();
            }
        }

        public string Lang_3
        {
            get
            {
                return m_strLang_3;
            }
            set
            {
                m_strLang_3 = value.Trim();
            }
        }

        public string Lang_4
        {
            get
            {
                return m_strLang_4;
            }
            set
            {
                m_strLang_4 = value.Trim();
            }
        }

        public string Lang_5
        {
            get
            {
                return m_strLang_5;
            }
            set
            {
                m_strLang_5 = value.Trim();
            }
        }

        public int Type_ID
        {
            get
            {
                return m_intType_ID;
            }
            set
            {
                m_intType_ID = value;
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

        public string Type_Text
        {
            get
            {
                string v_strRes = "";

                switch (Type_ID)
                {
                    case (int)ELanguage_Type_ID.General: v_strRes = "Cơ bản"; break;
					case (int)ELanguage_Type_ID.PDA: v_strRes = "PDA"; break;
				}

                return v_strRes;
            }
        }
    }
}
