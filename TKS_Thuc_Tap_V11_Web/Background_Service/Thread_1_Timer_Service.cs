using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Common;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Web.Background_Service
{
    public class Thread_1_Timer_Service : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            CThread_Common_Controller v_objCtrThread = new CThread_Common_Controller();

            int v_iSTT_Thread = (int)ESTT_Threath.Thread_1;

            while (!stoppingToken.IsCancellationRequested)
            {
                int v_iTimer = 3000;

                try
                {
                    List<CSys_Auto_Thread> v_arrThread = CCache_Auto_Thread.List_Data_By_STT_Thread(v_iSTT_Thread);
                    if (v_arrThread.Count > 0)
                        v_iTimer = v_arrThread[0].Delay_Second * 1000;

                    await v_objCtrThread.Call_Function(v_arrThread);
                }

                catch (Exception ex)
                {
                    CLogger.Error("Thread_Job_Timer_Service", "Call_Function", "Thread " + v_iSTT_Thread + ": " + ex.Message);
                }

                finally
                {
                    await Task.Delay(v_iTimer);
                }
            }
        }
    }
}
