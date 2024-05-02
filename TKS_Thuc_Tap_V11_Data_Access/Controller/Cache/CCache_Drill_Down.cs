using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Cache
{
    public class CCache_Drill_Down
    {
        public static List<CSys_Drill_Down> Arr_Data = new List<CSys_Drill_Down>();

        private static Dictionary<string, CSys_Drill_Down> Dic_Data_Code = new Dictionary<string, CSys_Drill_Down>();
        private static Dictionary<long, CSys_Drill_Down> Dic_Data_ID = new Dictionary<long, CSys_Drill_Down>();

        public static void Load_Cache_Drill_Down()
        {
			Arr_Data.Clear();
			Dic_Data_Code.Clear();
			Dic_Data_ID.Clear();

			CSys_Drill_Down_Controller v_objCtrData = new CSys_Drill_Down_Controller();
            List<CSys_Drill_Down> v_arrTemp = v_objCtrData.FQ_511_DD_sp_sel_List_For_Cache();

            foreach (CSys_Drill_Down v_objData in v_arrTemp)
                Add_Data(v_objData);
        }

        public static void Add_Data(CSys_Drill_Down p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            if (Dic_Data_Code.ContainsKey(p_objData.Field_Name.ToLower()) == false)
                Dic_Data_Code.Add(p_objData.Field_Name.ToLower(), p_objData);
        }

        public static void Update_Data(CSys_Drill_Down p_objData)
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

            CSys_Drill_Down v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);

            Dic_Data_Code.Remove(v_objData.Field_Name.ToLower());
        }

        public static CSys_Drill_Down Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static CSys_Drill_Down Get_Data_By_Code(string p_strCode)
        {
            if (Dic_Data_Code.ContainsKey(p_strCode.ToLower()) == true)
                return Dic_Data_Code[p_strCode.ToLower()];

            return null;
        }
    }
}
