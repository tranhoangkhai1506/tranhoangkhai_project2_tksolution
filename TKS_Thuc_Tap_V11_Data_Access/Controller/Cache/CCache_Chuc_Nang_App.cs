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
	public class CCache_Chuc_Nang_App
	{
		private static List<CSys_Chuc_Nang_App> Arr_Data = new();
		private static Dictionary<long, CSys_Chuc_Nang_App> Dic_Data_ID = new();
        private static Dictionary<string, CSys_Chuc_Nang_App> Dic_Data_Code = new();
        private static Dictionary<long, List<CSys_Chuc_Nang_App>> Dic_Data_Nhom_PDA = new();

		public static void Load_Cache_Chuc_Nang_App()
		{
			Arr_Data.Clear();
			Dic_Data_ID.Clear();
			Dic_Data_Code.Clear();
            Dic_Data_Nhom_PDA.Clear();

			CSys_Chuc_Nang_App_Controller v_objCtrData = new();
            //List<CSys_Chuc_Nang_App> v_arrTemp_Data = v_objCtrData.List_Sys_Chuc_Nang_App(); //
            List<CSys_Chuc_Nang_App> v_arrTemp_Data = v_objCtrData.FQ_508_CNA_sp_sel_List_For_Cache(); //
            foreach (CSys_Chuc_Nang_App v_objData in v_arrTemp_Data)
				Add_Data(v_objData);
		}

		public static void Add_Data(CSys_Chuc_Nang_App p_objData)
		{
			if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
				return;

			Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
			Arr_Data.Add(p_objData);

			string v_strKey_Code = CUtility.Tao_Key(p_objData.Nhom_PDA_ID);
            if (Dic_Data_Code.ContainsKey(v_strKey_Code) == false)
                Dic_Data_Code.Add(v_strKey_Code, p_objData);

            if (Dic_Data_Nhom_PDA.ContainsKey(p_objData.Nhom_PDA_ID) == false)
				Dic_Data_Nhom_PDA.Add(p_objData.Nhom_PDA_ID, new());

			Dic_Data_Nhom_PDA[p_objData.Nhom_PDA_ID].Add(p_objData);
		}

		public static void Update_Data(CSys_Chuc_Nang_App p_objData)
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

			CSys_Chuc_Nang_App v_objData = Dic_Data_ID[p_iAuto_ID];

			Arr_Data.Remove(v_objData);
			Dic_Data_ID.Remove(p_iAuto_ID);
			string v_strKey_Code = CUtility.Tao_Key(v_objData.Nhom_PDA_ID);
			Dic_Data_Code.Remove(v_strKey_Code);
			Dic_Data_Nhom_PDA[v_objData.Nhom_PDA_ID].Remove(v_objData);
		}

		public static CSys_Chuc_Nang_App Get_Data_By_ID(long p_iID)
		{
			if (Dic_Data_ID.ContainsKey(p_iID) == true)
				return Dic_Data_ID[p_iID];

			return null;
		}

		public static List<CSys_Chuc_Nang_App> List_Data_By_Nhom_PDA(long p_iNhom_PDA_ID)
		{
			if (Dic_Data_Nhom_PDA.ContainsKey(p_iNhom_PDA_ID) == true)
				return Dic_Data_Nhom_PDA[p_iNhom_PDA_ID].ToList();

			return new List<CSys_Chuc_Nang_App>();
		}

        public static CSys_Chuc_Nang_App Get_Data_By_Code(long p_iNhom_PDA_ID)
        {
            string v_strKey = CUtility.Tao_Key(p_iNhom_PDA_ID);
            if (Dic_Data_Code.ContainsKey(v_strKey) == true)
                return Dic_Data_Code[v_strKey];

            return null;
        }

		public static List<CSys_Chuc_Nang_App> List_Data_All()
		{
			return Arr_Data;
		}
	}
}
