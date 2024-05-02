using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Cache
{
    public class CCache_Common_Controller
    {
        // Biến này thiết kế để cho project PDA chạy, với Project PDA thì không có đủ data để load cache nên ko sử dụng load cache
        // Trong file program.cs thì set = true, do vậy khi PDA chạy thì mặc định bằng false.
        public static bool Is_Used_Cache = false;
        public static bool Is_Completed_Load_Cache = false;

        public static bool Is_Use_Cache_Transaction()
        {
            return false;
        }
    }
}
