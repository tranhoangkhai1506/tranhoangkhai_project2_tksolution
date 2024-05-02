using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Common
{
    public class CCol_Grid_Property
    {
        private string m_strField_Name;
        private string m_strTitle;
        private string m_strType_Name;
        private string m_strWidth_Col;
        private int m_intPos_Index;
        private PropertyInfo m_objProps_Info;
        private int m_intSL_Col_Band;

        public CCol_Grid_Property()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strField_Name = CConst.STR_VALUE_NULL;
            m_strTitle = CConst.STR_VALUE_NULL;
            m_strType_Name =    CConst.STR_VALUE_NULL;
            m_strWidth_Col = CConst.STR_VALUE_NULL;
            m_intPos_Index = CConst.INT_VALUE_NULL;
            m_intSL_Col_Band = CConst.INT_VALUE_NULL;
            m_objProps_Info = null;
        }

        public string Field_Name
        {
            get
            {
                return m_strField_Name;
            }
            set
            {
                m_strField_Name = value;
            }
        }

        public string Title
        {
            get
            {
                return m_strTitle;
            }
            set
            {
                m_strTitle = value;
            }
        }

        public string Type_Name
        {
            get
            {
                return m_strType_Name;
            }
            set
            {
                m_strType_Name = value;
            }
        }

        public string Width_Col
        {
            get
            {
                return m_strWidth_Col;
            }
            set
            {
                m_strWidth_Col = value;
            }
        }

        public int Pos_Index
        {
            get
            {
                return m_intPos_Index;
            }
            set
            {
                m_intPos_Index = value;
            }
        }

        public PropertyInfo Props_Info
        {
            get
            {
                return m_objProps_Info;
            }
            set
            {
                m_objProps_Info = value;
            }
        }

        public int SL_Col_Band
        {
            get
            {
                return m_intSL_Col_Band;
            }
            set
            {
                m_intSL_Col_Band = value;
            }
        }
    }
}
