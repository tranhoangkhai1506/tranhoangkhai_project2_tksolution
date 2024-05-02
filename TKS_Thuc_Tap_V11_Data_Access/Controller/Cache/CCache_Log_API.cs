using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.DM;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Log;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Log;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Cache
{
    public class CCache_Log_API
    {
        private static List<CLog_API> Arr_Data = new List<CLog_API>();

        private static Dictionary<string, CLog_API> Dic_Data_Code = new Dictionary<string, CLog_API>();       
        private static Dictionary<long, CLog_API> Dic_Data_ID = new Dictionary<long, CLog_API>();
        public static void Load_Cache_Log_API()
        {
            Arr_Data.Clear();
            Dic_Data_ID.Clear();
            Dic_Data_Code.Clear();

            CLog_API_Controller v_objCtrData = new();
            List<CLog_API> v_arrTemp_Data = v_objCtrData.FQ_401_A_sp_sel_List_For_Cache(); //
            foreach (CLog_API v_objData in v_arrTemp_Data)
                Add_Data(v_objData);
        }

        public static void Add_Data(CLog_API p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            string v_strKey_Code = CUtility.Tao_Key(p_objData.Key_No, p_objData.API_Source_Name, p_objData.API_Function_Name);
            if (Dic_Data_Code.ContainsKey(v_strKey_Code) == false)
                Dic_Data_Code.Add(v_strKey_Code, p_objData);           
        }

        public static void Update_Data(CLog_API p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == false || p_objData.Auto_ID == 0)
                return;

            Delete_Data(p_objData.Auto_ID);
            Add_Data(p_objData);
        }

        public static void Delete_Data(long p_iAuto_ID)
        {
            if (Dic_Data_ID.ContainsKey(p_iAuto_ID) == false || p_iAuto_ID == 0)
                return;

            CLog_API v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);

            string v_strKey_Code = CUtility.Tao_Key(v_objData.Key_No, v_objData.API_Source_Name, v_objData.API_Function_Name);

            Dic_Data_Code.Remove(v_strKey_Code);
        }

        public static CLog_API Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static CLog_API Get_Data_By_Key(string p_strKey_No, string p_strAPI_Source_Name, string p_strAPI_Function_Name)
        {
            string v_strKey = CUtility.Tao_Key(p_strKey_No, p_strAPI_Source_Name, p_strAPI_Function_Name);

            if (Dic_Data_Code.ContainsKey(v_strKey) == true)
                return Dic_Data_Code[v_strKey];

            return null;
        }

        public static CLog_API Get_Data_By_Key(string p_strKey_All)
        {
            p_strKey_All = CUtility.Tao_Key(p_strKey_All);
			if (Dic_Data_Code.ContainsKey(p_strKey_All) == true)
                return Dic_Data_Code[p_strKey_All];

            return null;
        }

        public static List<CLog_API> List_Data()
        {
            return Arr_Data.ToList();
        }

    }
}
