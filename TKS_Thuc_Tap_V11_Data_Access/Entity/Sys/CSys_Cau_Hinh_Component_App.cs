using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
    public class CSys_Cau_Hinh_Component_App
    {
        private long m_lngAuto_ID;
        private long m_lngChu_Hang_ID;
        private int m_lngComponent_ID;
        private string m_strField_Name;
        private bool m_blnIs_View;
        private string m_strNotes;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;
        private string m_strTen_Viet_Tat;

        public CSys_Cau_Hinh_Component_App()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_lngChu_Hang_ID = CConst.INT_VALUE_NULL;
            m_lngComponent_ID = CConst.INT_VALUE_NULL;
            m_strField_Name = CConst.STR_VALUE_NULL;
            m_blnIs_View = CConst.BL_VALUE_NULL;
            m_strNotes = CConst.STR_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
            m_strTen_Viet_Tat = CConst.STR_VALUE_NULL;
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

        public int Component_ID
        {
            get
            {
                return m_lngComponent_ID;
            }
            set
            {
                m_lngComponent_ID = value;
            }
        }


		public string Component_Text
		{
			get
			{
                string v_strRes = "";

				return v_strRes;
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

        public bool Is_View
        {
            get
            {
                return m_blnIs_View;
            }
            set
            {
                m_blnIs_View = value;
            }
        }

        public string Notes
        {
            get
            {
                return m_strNotes;
            }
            set
            {
                m_strNotes = value.Trim();
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

        public string Ten_Viet_Tat
        {
            get
            {
                return m_strTen_Viet_Tat;
            }
            set
            {
                m_strTen_Viet_Tat = value.Trim();
            }
        }
    }
}
