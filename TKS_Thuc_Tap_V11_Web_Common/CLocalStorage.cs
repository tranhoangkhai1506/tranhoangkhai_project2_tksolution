using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Newtonsoft.Json;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Web_Common.Common
{
    public class CLocalStorage
    {

        public static async Task<object> Get_Local_Data(ProtectedLocalStorage p_objSession, string p_strKey)
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

        public static async Task Set_Local_Data(ProtectedLocalStorage p_objSession, string p_strKey, object p_objData)
        {
            try
            {
                await p_objSession.SetAsync(p_strKey, p_objData);
            }

            catch (Exception) { }
        }

        public static async Task Delete_Session(ProtectedLocalStorage p_objSession, string p_strKey)
        {
            await p_objSession.DeleteAsync(p_strKey);
        }

        public static async Task Set_State_Grid(ProtectedLocalStorage p_objSession, string p_strKey, object p_objData)
        {
            await Set_Local_Data(p_objSession, p_strKey, JsonConvert.SerializeObject(p_objData));
        }

        public static async Task<string> Get_State_Grid(ProtectedLocalStorage p_objSession, string p_strKey)
        {
            var v_objData = CUtility.Convert_To_String(await Get_Local_Data(p_objSession, p_strKey));
            return v_objData;
        }
    }
}
