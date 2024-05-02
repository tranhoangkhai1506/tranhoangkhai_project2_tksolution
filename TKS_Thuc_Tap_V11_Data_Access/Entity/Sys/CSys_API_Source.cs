using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
	public class CSys_API_Source
	{
		private long m_lngAuto_ID;
		private string m_strMa_API_Source;
		private string m_strTen_API_Source;
		private string m_strLink_API;
		private string m_strUser_Name;
		private string m_strPassword;
		private string m_strToken_1;
		private string m_strToken_2;
		private string m_strClient_ID_1;
		private string m_strClient_ID_2;
		private string m_strUrl_Folder_Download;
		private string m_strUrl_Folder_Upload;
		private string m_strUrl_Folder_Download_BAK;
		private string m_strUrl_Folder_Upload_BAK;
		private string m_strGhi_Chu;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;
		private List<CSys_API_Source_Function> m_arrSys_API_Source_Function;


        public CSys_API_Source()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_strMa_API_Source = CConst.STR_VALUE_NULL;
			m_strTen_API_Source = CConst.STR_VALUE_NULL;
			m_strLink_API = CConst.STR_VALUE_NULL;
			m_strUser_Name = CConst.STR_VALUE_NULL;
			m_strPassword = CConst.STR_VALUE_NULL;
			m_strToken_1 = CConst.STR_VALUE_NULL;
			m_strToken_2 = CConst.STR_VALUE_NULL;
			m_strClient_ID_1 = CConst.STR_VALUE_NULL;
			m_strClient_ID_2 = CConst.STR_VALUE_NULL;
			m_strUrl_Folder_Download = CConst.STR_VALUE_NULL;
			m_strUrl_Folder_Upload = CConst.STR_VALUE_NULL;
			m_strUrl_Folder_Download_BAK = CConst.STR_VALUE_NULL;
			m_strUrl_Folder_Upload_BAK = CConst.STR_VALUE_NULL;
			m_strGhi_Chu = CConst.STR_VALUE_NULL;
			m_intdeleted = CConst.INT_VALUE_NULL;
			m_dtmCreated = CConst.DTM_VALUE_NULL;
			m_strCreated_By = CConst.STR_VALUE_NULL;
			m_strCreated_By_Function = CConst.STR_VALUE_NULL;
			m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
			m_strLast_Updated_By = CConst.STR_VALUE_NULL;
			m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
			m_arrSys_API_Source_Function = new List<CSys_API_Source_Function>();

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

		public string Ma_API_Source
		{
			get
			{
				return m_strMa_API_Source;
			}
			set
			{
				m_strMa_API_Source = value.Trim();
			}
		}

		public string Ten_API_Source
		{
			get
			{
				return m_strTen_API_Source;
			}
			set
			{
				m_strTen_API_Source = value.Trim();
			}
		}

		public string Link_API
		{
			get
			{
				return m_strLink_API;
			}
			set
			{
				m_strLink_API = value.Trim();
			}
		}

		public string User_Name
		{
			get
			{
				return m_strUser_Name;
			}
			set
			{
				m_strUser_Name = value.Trim();
			}
		}

		public string Password
		{
			get
			{
				return m_strPassword;
			}
			set
			{
				m_strPassword = value.Trim();
			}
		}

		public string Token_1
		{
			get
			{
				return m_strToken_1;
			}
			set
			{
				m_strToken_1 = value.Trim();
			}
		}

		public string Token_2
		{
			get
			{
				return m_strToken_2;
			}
			set
			{
				m_strToken_2 = value.Trim();
			}
		}

		public string Client_ID_1
		{
			get
			{
				return m_strClient_ID_1;
			}
			set
			{
				m_strClient_ID_1 = value.Trim();
			}
		}

		public string Client_ID_2
		{
			get
			{
				return m_strClient_ID_2;
			}
			set
			{
				m_strClient_ID_2 = value.Trim();
			}
		}

		public string Url_Folder_Download
		{
			get
			{
				return m_strUrl_Folder_Download;
			}
			set
			{
				m_strUrl_Folder_Download = value.Trim();
			}
		}

		public string Url_Folder_Upload
		{
			get
			{
				return m_strUrl_Folder_Upload;
			}
			set
			{
				m_strUrl_Folder_Upload = value.Trim();
			}
		}

		public string Url_Folder_Download_BAK
		{
			get
			{
				return m_strUrl_Folder_Download_BAK;
			}
			set
			{
				m_strUrl_Folder_Download_BAK = value.Trim();
			}
		}

		public string Url_Folder_Upload_BAK
		{
			get
			{
				return m_strUrl_Folder_Upload_BAK;
			}
			set
			{
				m_strUrl_Folder_Upload_BAK = value.Trim();
			}
		}

		public string Ghi_Chu
		{
			get
			{
				return m_strGhi_Chu;
			}
			set
			{
				m_strGhi_Chu = value.Trim();
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

		public string Ten_API_Source_Combo
		{
			get
			{
				return Ten_API_Source + " (" + Ma_API_Source + ")";
			}
		}

        public List<CSys_API_Source_Function> Sys_API_Source_Function
        {
            get
            {
                return m_arrSys_API_Source_Function;
            }
            set
            {
                m_arrSys_API_Source_Function = value;
            }
        }
    }
}
