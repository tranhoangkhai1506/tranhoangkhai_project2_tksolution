using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
    public class CConfig
    {
        /// <summary>
        /// Câu kết nối vào database
        /// </summary>
        public static string TKS_Thuc_Tap_V11_Conn_String = "";

        public static string Default_Url = "";
        public static string Default_Lang_ID = "";
        public static int Is_Trace = 1;

        // Thông tin header báo cáo
        public static string Company_Name = "";
        public static string Company_Address = "";
        public static string Company_Tel = "";
        public static string Company_Fax = "";
        public static string Company_Email = "";
        public static string Company_Ten_Ngan_Hang = "";
        public static string Company_So_Tai_Khoan = "";
        public static string Report_Logo_Url = "";
        public static int Khach_Hang_ID = 0;
        public static int API_DataSource = 0;
        public static string Khach_Hang_Name = "";
        public static string Product_Title = "";

        public static int Page_Size = 50;
        public static string Date_Format_String = "dd/MM/yyyy";
        public static string DateTime_Format_String = "dd/MM/yyyy HH:mm";
        public static string Full_DateTime_Format_String = "dd/MM/yyyy HH:mm:ss";

		public static string Time_Format_String = "";
        public static string FullTime_Format_String = "";
		public static string Number_Format_String = "###,###0.###;-###,###0.###;-";
        public static string Footer_Number_Format_String = "";

        public static string Import_Excel_URL = "C:\\Temp\\Import_Excel\\";
        public static string Template_URL = "\\FileManagement\\Template\\";
        public static string Export_Excel_URL = "\\FileManagement\\Export_Excel\\";
        public static string Upload_URL = "\\FileManagement\\Upload_File\\";
        public static string Upload_URL_App = "/FileManagement/Upload_File/";
        public static string Report_File = "/FileManagement/Report/";
        public static string Log_File_Path = "/FileManagement/Log/";

        public static string Smtp_Host = "";
        public static bool Smtp_UseDefaultCredentials = false;
        public static int Smtp_Port = 0;
        public static string Smtp_User = "";
        public static string Smtp_Pass = "";
        public static bool Smtp_EnableSsl = false;
        public static string Email_From = "";
        public static string Email_Warning_HoanThanh = "";

        public static string Key_FirebaseCloud = "";
        public static string Sender_FirebaseCloud = "";

        public static string Token_Cookie_Name = "TKS_Thuc_Tap_V11_hstsvew";

        public static List<string> Allowed_Extensions_Upload { get; set; } = new List<string>() { ".pdf", ".docs", ".png", ".jpge", ".jpg" };

        #region PDA
        public static string PDA_Device_ID = "";
        public static string PDA_Key_Token = "TKS_Thuc_Tap_V11_PDA_Key_Token";
        public static string PDA_Key_API = "TKS_Thuc_Tap_V11_PDA_Key_API";
        public static string PDA_Key_Kho_Default_ID = "TKS_Thuc_Tap_V11_PDA_Kho_Default_ID";

        public static string PDA_Domain_API = "";
        public static string PDA_Domain_API_Goc = "";
        public static bool Is_Run_Doc_Giong_Noi = false;
        public static int Timeout_Server = 15000;
        public static int Timeout_Server_FBO = 15000;
        public static int Timeout_Server_SAP = 180000;
        #endregion PDA

        #region service
        public static string API_Log_Virtual_URL = "/FileManagement/Log_API/";
        public static string API_Log_Physical_URL = "";
        public static string API_Grid_Field_URL = "";
        #endregion service
	}
}
