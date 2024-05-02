using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.DM;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Cache
{
    public class CCache_Chu_Hang
    {
        private static List<CDM_Chu_Hang> Arr_Data = new List<CDM_Chu_Hang>();

        private static Dictionary<string, CDM_Chu_Hang> Dic_Data_Code = new Dictionary<string, CDM_Chu_Hang>();
        private static Dictionary<string, CDM_Chu_Hang> Dic_Data_Ten_Viet_Tat = new Dictionary<string, CDM_Chu_Hang>();
        private static Dictionary<long, CDM_Chu_Hang> Dic_Data_ID = new Dictionary<long, CDM_Chu_Hang>();

		public static void Load_Cache_Chu_Hang()
		{
			Arr_Data.Clear();
			Dic_Data_ID.Clear();
			Dic_Data_Code.Clear();
			Dic_Data_Ten_Viet_Tat.Clear();
			CDM_Chu_Hang_Controller v_objCtrl = new();
			List<CDM_Chu_Hang> v_arrTemp_Data = v_objCtrl.FQ_104_CH_sp_sel_List_For_Cache();  

			foreach (CDM_Chu_Hang v_objData in v_arrTemp_Data)
				Add_Data(v_objData);
		}

		public static void Add_Data(CDM_Chu_Hang p_objData)
		{
			if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
				return;

			Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
			Arr_Data.Add(p_objData);

			if (Dic_Data_Code.ContainsKey(p_objData.Ma_Chu_Hang.ToLower()) == false)
				Dic_Data_Code.Add(p_objData.Ma_Chu_Hang.ToLower(), p_objData);

			if (Dic_Data_Ten_Viet_Tat.ContainsKey(p_objData.Ten_Viet_Tat.ToLower()) == false)
				Dic_Data_Ten_Viet_Tat.Add(p_objData.Ten_Viet_Tat.ToLower(), p_objData);
		}

		public static void Update_Data(CDM_Chu_Hang p_objData)
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

			CDM_Chu_Hang v_objData = Dic_Data_ID[p_iAuto_ID];

			Arr_Data.Remove(v_objData);
			Dic_Data_ID.Remove(p_iAuto_ID);

			Dic_Data_Code.Remove(v_objData.Ma_Chu_Hang.ToLower());
			Dic_Data_Ten_Viet_Tat.Remove(v_objData.Ten_Viet_Tat.ToLower());
		}

		public static CDM_Chu_Hang Get_Data_By_ID(long p_iID)
		{
			if (Dic_Data_ID.ContainsKey(p_iID) == true)
				return Dic_Data_ID[p_iID];

			return null;
		}

		public static CDM_Chu_Hang Get_Data_By_Ma_Chu_Hang(string p_strCode)
		{
			if (Dic_Data_Code.ContainsKey(p_strCode.ToLower()) == true)
				return Dic_Data_Code[p_strCode.ToLower()];

			return null;
		}

		public static CDM_Chu_Hang Get_Data_By_Ten_Viet_Tat(string p_strTen_Viet_Tat)
		{
			if (Dic_Data_Ten_Viet_Tat.ContainsKey(p_strTen_Viet_Tat.ToLower()) == true)
				return Dic_Data_Ten_Viet_Tat[p_strTen_Viet_Tat.ToLower()];

			return null;
		}

		public static List<CDM_Chu_Hang> List_Data()
		{
			return Arr_Data.OrderBy(it => it.Ten_Viet_Tat).ToList();
		}
	}
}
