using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
    public class CSys_Grid_Field
    {
        private long m_lngAuto_ID;
        private string m_strTen_Grid;
        private string m_strMa_Chuc_Nang;
        private string m_strField_Name;
        private string m_strTieu_De_Column;
        private int m_intColumn_Width;
        private int m_intField_Type_ID;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;
        private string m_strTen_Chuc_Nang;
		private string m_strField_Name_Parent;
        private int m_intSort_Priority;

        public CSys_Grid_Field()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_strTen_Grid = CConst.STR_VALUE_NULL;
            m_strMa_Chuc_Nang = CConst.STR_VALUE_NULL;
            m_strField_Name = CConst.STR_VALUE_NULL;
            m_strTieu_De_Column = CConst.STR_VALUE_NULL;
            m_intColumn_Width = CConst.INT_VALUE_NULL;
            m_intField_Type_ID = CConst.INT_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
            m_strTen_Chuc_Nang = CConst.STR_VALUE_NULL;
			m_strField_Name_Parent = CConst.STR_VALUE_NULL;
            m_intSort_Priority = CConst.INT_VALUE_NULL;
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

        public string Ten_Grid
        {
            get
            {
                return m_strTen_Grid;
            }
            set
            {
                m_strTen_Grid = value.Trim();
            }
        }

        public string Ma_Chuc_Nang
        {
            get
            {
                return m_strMa_Chuc_Nang;
            }
            set
            {
                m_strMa_Chuc_Nang = value.Trim();
            }
        }

        public string Ten_Chuc_Nang
        {
            get
            {
                return m_strTen_Chuc_Nang;
            }
            set
            {
                m_strTen_Chuc_Nang = value.Trim();
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

        public string Tieu_De_Column
        {
            get
            {
                return m_strTieu_De_Column;
            }
            set
            {
                m_strTieu_De_Column = value.Trim();
            }
        }

        public int Column_Width
        {
            get
            {
                return m_intColumn_Width;
            }
            set
            {
                m_intColumn_Width = value;
            }
        }

        public int Field_Type_ID
        {
            get
            {
                return m_intField_Type_ID;
            }
            set
            {
                m_intField_Type_ID = value;
            }
        }

		public string Field_Type_Text
		{
			get
			{
				return CUtility_Text_Description.Grid_Field_Type_Text(Field_Type_ID);
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
		public string Field_Name_Parent
		{
			get
			{
				return m_strField_Name_Parent;
			}
			set
			{
				m_strField_Name_Parent = value.Trim();
			}
		}

        public int Sort_Priority
        {
            get
            {
                return m_intSort_Priority;
            }
            set
            {
                m_intSort_Priority = value;
            }
        }

    }
}
