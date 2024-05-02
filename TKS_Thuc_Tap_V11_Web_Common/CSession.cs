using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Telerik.Blazor.Components;
using TKS_Thuc_Tap_V11_Data_Access.Utility;
using Newtonsoft.Json;

namespace TKS_Thuc_Tap_V11_Web_Common.Common
{
	public class CSession
	{
        public static async Task<object> Get_Session_Data(ProtectedLocalStorage p_objSession, string p_strKey)
        {
            try
            {
                var v_objRes = await p_objSession.GetAsync<object>(p_strKey);

                if (v_objRes.Success == true)
                    return v_objRes.Value;
            }

            catch (Exception) 
            {
            }

            return null;
        }

        public static async Task Set_Session_Data(ProtectedLocalStorage p_objSession, string p_strKey, object p_objData)
        {
            try
            {
                await p_objSession.SetAsync(p_strKey, p_objData);
            }

            catch (Exception) { }
        }

        public static async Task Set_Session_Full_Name(ProtectedLocalStorage p_objSession, string p_strKey, object p_objData)
        {
            await p_objSession.SetAsync(p_strKey, p_objData);
        }

        public static async Task Set_Active_User_Name(ProtectedLocalStorage p_objSession, string p_objData)
        {
            await Set_Session_Data(p_objSession, "Active_User_Name", p_objData);
        }

        public static async Task<string> Get_Active_User_Name(ProtectedLocalStorage p_objSession)
        {
            object v_objData = await Get_Session_Data(p_objSession, "Active_User_Name");
            return CUtility.Convert_To_String(v_objData);
        }

        public static async Task Set_Active_Full_Name(ProtectedLocalStorage p_objSession, string p_objData)
        {
            await Set_Session_Data(p_objSession, "Active_Full_Name", p_objData);
        }

        public static async Task<string> Get_Active_Full_Name(ProtectedLocalStorage p_objSession)
        {
            object v_objData = await Get_Session_Data(p_objSession, "Active_Full_Name");
            return CUtility.Convert_To_String(v_objData);
        }


        public static async Task Delete_Session(ProtectedLocalStorage p_objSession, string p_strKey)
        {
            await p_objSession.DeleteAsync(p_strKey);
        }
       
    }
}
