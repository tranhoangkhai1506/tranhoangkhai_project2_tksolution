using System.Runtime.InteropServices;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Common;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Web.Background_Service
{
    public class Cache_Timer_Service : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Delay(1);

            try
            {
                CCache_Column_Width.Load_Cache_Column_Width();
                CCache_Drill_Down.Load_Cache_Drill_Down();
                CCache_Filter_Date_Default.Load_Cache_Filter_Date_Default();
                CCache_Hien_An_Column.Load_Cache_Hien_An_Column();
                CCache_Language.Load_Cache_Language();
                CCache_Mau_Column.Load_Cache_Mau_Column();
                CCache_Frozen_Column.Load_Cache_Frozen_Column();
                CCache_Auto_Thread.Load_Cache_Auto_Thread();
                CCache_API_Source.Load_Cache_API_Source();
                CCache_API_Source_Function.Load_Cache_API_Source_Function();
                CCache_API_Source_Chu_Hang.Load_Cache_API_Source_Chu_Hang();
                CCache_API_Source_Chu_Hang_Function.Load_Cache_API_Source_Chu_Hang_Function();
                CCache_Nhom_PDA.Load_Cache_Nhom_PDA();
                CCache_Nhom_PDA_User.Load_Cache_Nhom_PDA_User();
                CCache_Webhook.Load_Cache_Webhook();
                CCache_Cau_Hinh_Component_App.Load_Cache_Cau_Hinh_Component_App();
                CCache_Log_API.Load_Cache_Log_API();
                
                CCache_Report_Template_Config.Load_Cache_Report_Template_Config();
                CCache_Import_Excel_Template_Config.Load_Cache_Import_Excel_Template_Config();
                CCache_Chuc_Nang_App.Load_Cache_Chuc_Nang_App();
                CCache_STT_Next.Load_Cache_STT_Next();
                CCache_STT_Next_Detail.Load_Cache_STT_Next_Detail();

				CCache_Grid_Field.Load_Cache_Grid_Field();
				CCache_Grid_UI_Global.Load_Cache_Grid_UI_Global();
                CCache_Don_Vi_Tinh.Load_Cache_DM_Don_Vi_Tinh();
                CCache_Loai_San_Pham.Load_Cache_DM_Loai_San_Pham();

				CCache_Common_Controller.Is_Completed_Load_Cache = true;
            }

            catch (Exception ex)
            {
                CLogger.Error("Cache_Timer_Service", "Load_Cache", ex.Message);
            }
        }
    }
}
