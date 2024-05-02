using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Common
{
    public class CFilter
    {
        private DateTime? m_dtmDate_From;  // 
        private DateTime? m_dtmDate_To;  // 
        private string m_strKey_1;  // 
        private string m_strKey_2;  // 
        private string m_strKey_3;  // 
        private string m_strKey_4;  // 
        private string m_strKey_5;  // 
        private long m_iId_1;  // 
        private long m_iId_2;  // 

		private bool m_blStatus_Filter_1;
        private bool m_blStatus_Filter_2;
        private bool m_blStatus_Filter_3;
        private bool m_blStatus_Filter_4;
        private bool m_blStatus_Filter_5;
        private bool m_blStatus_Filter_6;

        private double m_dblNumber_1;
        private double m_dblNumber_2;
        private double m_dblNumber_3;
        private double m_dblNumber_4;

        private DateTime? m_dtmDate_Filter_1; 

        public CFilter()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_dtmDate_From = DateTime.Now.AddYears(-30);
            m_dtmDate_To = DateTime.Now.AddDays(1);
            m_strKey_1 = CConst.STR_VALUE_NULL;
            m_strKey_2 = CConst.STR_VALUE_NULL;
            m_strKey_3 = CConst.STR_VALUE_NULL;
            m_strKey_4 = CConst.STR_VALUE_NULL;
            m_strKey_5 = CConst.STR_VALUE_NULL;
            m_iId_1 = CConst.INT_VALUE_NULL;
            m_iId_2 = CConst.INT_VALUE_NULL;
			m_blStatus_Filter_1 = CConst.BL_VALUE_NULL;
            m_blStatus_Filter_2 = CConst.BL_VALUE_NULL;
            m_blStatus_Filter_3 = CConst.BL_VALUE_NULL;
            m_blStatus_Filter_4 = CConst.BL_VALUE_NULL;
            m_blStatus_Filter_5 = CConst.BL_VALUE_NULL;
            m_blStatus_Filter_6 = CConst.BL_VALUE_NULL;
            m_dblNumber_1 = CConst.DB_VALUE_NULL;
            m_dblNumber_2 = CConst.DB_VALUE_NULL;
            m_dblNumber_3 = CConst.DB_VALUE_NULL;
            m_dblNumber_4 = CConst.DB_VALUE_NULL;
            m_dtmDate_Filter_1 = CConst.DTM_VALUE_NULL;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date_From
        {
            get
            {
                return m_dtmDate_From;
            }
            set
            {
                m_dtmDate_From = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? Date_To
        {
            get
            {
                return m_dtmDate_To;
            }
            set
            {
                m_dtmDate_To = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Key_1
        {
            get { return m_strKey_1; }
            set
            {
                m_strKey_1 = value.Trim();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Key_2
        {
            get { return m_strKey_2; }
            set
            {
                m_strKey_2 = value.Trim();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Key_3
        {
            get { return m_strKey_3; }
            set
            {
                m_strKey_3 = value.Trim();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Key_4
        {
            get { return m_strKey_4; }
            set
            {
                m_strKey_4 = value.Trim();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Key_5
        {
            get { return m_strKey_5; }
            set
            {
                m_strKey_5 = value.Trim();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public long Id_1
        {
            get { return m_iId_1; }
            set
            {
                m_iId_1 = value;
            }
        }
        public long Id_2
        {
            get { return m_iId_2; }
            set
            {
                m_iId_2 = value;
            }
        }

		public bool Status_Filter_1
        {
            get { return m_blStatus_Filter_1; }
            set
            {
                m_blStatus_Filter_1 = value;
            }
        }

        public bool Status_Filter_2
        {
            get { return m_blStatus_Filter_2; }
            set
            {
                m_blStatus_Filter_2 = value;
            }
        }

        public bool Status_Filter_3
        {
            get { return m_blStatus_Filter_3; }
            set
            {
                m_blStatus_Filter_3 = value;
            }
        }

        public bool Status_Filter_4
        {
            get { return m_blStatus_Filter_4; }
            set
            {
                m_blStatus_Filter_4 = value;
            }
        }

        public bool Status_Filter_5
        {
            get { return m_blStatus_Filter_5; }
            set
            {
                m_blStatus_Filter_5 = value;
            }
        }

        public bool Status_Filter_6
        {
            get { return m_blStatus_Filter_6; }
            set
            {
                m_blStatus_Filter_6 = value;
            }
        }

        public double Number_1 { get => m_dblNumber_1; set => m_dblNumber_1 = value; }
        public double Number_2 { get => m_dblNumber_2; set => m_dblNumber_2 = value; }
        public double Number_3 { get => m_dblNumber_3; set => m_dblNumber_3 = value; }
        public double Number_4 { get => m_dblNumber_4; set => m_dblNumber_4 = value; }

        public DateTime? Date_Filter_1
        {
            get
            {
                return m_dtmDate_Filter_1;
            }
            set
            {
                m_dtmDate_Filter_1 = value;
            }
        }
    }
}
