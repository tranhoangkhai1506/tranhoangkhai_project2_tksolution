using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
	public class CUtility_HTML_Status
	{
        public static string HTML_Common_Stataus(int p_iTrang_Thai_ID)
        {
            string v_strRes = "";

            switch (p_iTrang_Thai_ID)
            {
                case (int)ETrang_Thai_Common_ID.Available: v_strRes = "<span class=\"badge bg-success\">Hoạt động</span>"; break;
                case (int)ETrang_Thai_Common_ID.Closed: v_strRes = "<span class=\"badge bg-danger\">Đóng</span>"; break;
            }

            return v_strRes;
        }

        public static string HTML_API_Source_Chu_Hang(int p_iTrang_Thai_ID)
        {
            string v_strRes = "";

            switch (p_iTrang_Thai_ID)
            {
                case (int)ETrang_Thai_Common_ID.Available: v_strRes = "<span class=\"badge bg-success\">Hoạt động</span>"; break;
                case (int)ETrang_Thai_Common_ID.Closed: v_strRes = "<span class=\"badge bg-danger\">Đóng</span>"; break;
            }

            return v_strRes;
        }
    }
}
