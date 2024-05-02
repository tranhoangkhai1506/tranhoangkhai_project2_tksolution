using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Common
{
    public class CThread_Common_Controller
    {
        public CThread_Common_Controller()
        {

        }

        public async Task Call_Function(List<CSys_Auto_Thread> p_arrThread)
        {
            await Task.Delay(1);

            // Duyệt từng luồng chạy ngầm. Call đúng hàm tương ứng
            foreach (CSys_Auto_Thread v_objThread in p_arrThread)
            {
                if (v_objThread.Thread_Type_ID == (int)EThread_Type_ID.Lay_Du_Lieu_Tu_API_Source)
                    await Get_Data_From_API(v_objThread);

                if (v_objThread.Thread_Type_ID == (int)EThread_Type_ID.Auto_Chay_Cac_Rule_Khai_Bao)
                    await Run_Cac_Rule_Khai_Bao();
            }
        }

        private async Task Get_Data_From_API(CSys_Auto_Thread p_objThread)
        {
            await Task.Delay(1);
        }

        private async Task Run_Cac_Rule_Khai_Bao()
        {
            await Task.Delay(1);
		}
    }
}
