using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Cache
{
    public class CCache_Language
    {
        public static List<CSys_Language> Arr_Data = new List<CSys_Language>();

        private static Dictionary<string, CSys_Language> Dic_Data_Code = new Dictionary<string, CSys_Language>();
        private static Dictionary<long, CSys_Language> Dic_Data_ID = new Dictionary<long, CSys_Language>();
        private static Dictionary<int, List<CSys_Language>> Dic_Data_By_Type_ID = new ();
        public static void Load_Cache_Language()
        {
			Arr_Data.Clear();
			Dic_Data_Code.Clear();
			Dic_Data_ID.Clear();
            Dic_Data_By_Type_ID.Clear();

            CSys_Language_Controller v_objCtrData = new CSys_Language_Controller();
            List<CSys_Language> v_arrTemp = v_objCtrData.FQ_521_L_sp_sel_List_For_Cache();

            foreach (CSys_Language v_objData in v_arrTemp)
                Add_Data(v_objData);
        }

        public static void Add_Data(CSys_Language p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            if (Dic_Data_Code.ContainsKey(p_objData.Field_Name.ToLower()) == false)
                Dic_Data_Code.Add(p_objData.Field_Name.ToLower(), p_objData);

            if (Dic_Data_By_Type_ID.ContainsKey(p_objData.Type_ID) == false)
                Dic_Data_By_Type_ID.Add(p_objData.Type_ID, new List<CSys_Language>());

            Dic_Data_By_Type_ID[p_objData.Type_ID].Add(p_objData);
        }

        public static void Update_Data(CSys_Language p_objData)
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

            CSys_Language v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);

            Dic_Data_Code.Remove(v_objData.Field_Name.ToLower());
            Dic_Data_By_Type_ID[v_objData.Type_ID].Remove(v_objData);
        }

        public static CSys_Language Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static CSys_Language Get_Data_By_Code(string p_strCode)
        {
            if (Dic_Data_Code.ContainsKey(p_strCode.ToLower()) == true)
                return Dic_Data_Code[p_strCode.ToLower()];

            return null;
        }

        public static string Get_String_Label_By_Field(string p_strCode, string p_strLanguage)
        {
            string v_strRes = p_strCode;

            CSys_Language v_objSys = Get_Data_By_Code(p_strCode);
            if (v_objSys != null)
            {
                if (p_strLanguage.ToLower() == "vi-vn" && v_objSys.Lang_1 != "")
                    v_strRes = v_objSys.Lang_1;

				if (p_strLanguage.ToLower() == "en-us" && v_objSys.Lang_2 != "")
					v_strRes = v_objSys.Lang_2;

				if (p_strLanguage.ToLower() == "jp-ja" && v_objSys.Lang_3 != "")
					v_strRes = v_objSys.Lang_3;

				if (p_strLanguage.ToLower() == "zh-cn" && v_objSys.Lang_4 != "")
					v_strRes = v_objSys.Lang_4;

				if (p_strLanguage.ToLower() == "ko-kr" && v_objSys.Lang_5 != "")
					v_strRes = v_objSys.Lang_5;
			}

			return v_strRes;
		}

        public static List<CSys_Language> List_Data_By_Type_ID(int p_iType_ID)
        {
            if (Dic_Data_By_Type_ID.ContainsKey(p_iType_ID) == true)
                return Dic_Data_By_Type_ID[p_iType_ID].ToList();

            return new List<CSys_Language>();
        }
    }
}
