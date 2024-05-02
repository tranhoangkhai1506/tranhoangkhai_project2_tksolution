using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Common
{
	public class CImport_Excel
	{
        private string m_strPath_File;  // 
        private string m_strURL_File_Template;

        public CImport_Excel()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_strPath_File = CConst.STR_VALUE_NULL;
            m_strURL_File_Template = CConst.STR_VALUE_NULL;
        }
        

        /// <summary>
        /// 
        /// </summary>
        public string Path_File
        {
            get { return m_strPath_File; }
            set
            {
                m_strPath_File = value.Trim();
            }
        }

        public string URL_File_Template
        {
            get { return m_strURL_File_Template; }
            set
            {
                m_strURL_File_Template = value.Trim();
            }
        }
    }
}
