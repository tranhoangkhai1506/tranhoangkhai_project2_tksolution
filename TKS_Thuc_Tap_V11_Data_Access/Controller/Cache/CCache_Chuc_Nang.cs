using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Sys;
using Azure.Core;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Cache
{
	public class CCache_Chuc_Nang
	{
		public static List<CSys_Chuc_Nang> Arr_Data = new List<CSys_Chuc_Nang>();

		private static Dictionary<string, CSys_Chuc_Nang> Dic_Data_Code = new Dictionary<string, CSys_Chuc_Nang>();
        private static Dictionary<string, CSys_Chuc_Nang> Dic_Data_Func_URL = new Dictionary<string, CSys_Chuc_Nang>();
        private static Dictionary<long, CSys_Chuc_Nang> Dic_Data_ID= new Dictionary<long, CSys_Chuc_Nang>();
		private static Dictionary<int, List<CSys_Chuc_Nang>> Dic_Data_Nhom_CN = new Dictionary<int, List<CSys_Chuc_Nang>>();

		public static void Load_Cache_Chuc_Nang()
		{
			Arr_Data.Clear();
			Dic_Data_Code.Clear();
			Dic_Data_Func_URL.Clear();
			Dic_Data_ID.Clear();
			Dic_Data_Nhom_CN.Clear();

			CSys_Chuc_Nang_Controller v_objCtrData = new CSys_Chuc_Nang_Controller();
            //List<CSys_Chuc_Nang> v_arrTemp = v_objCtrData.FCombo_sp_sel_List_Sys_Chuc_Nang();
            List<CSys_Chuc_Nang> v_arrTemp = v_objCtrData.FQ_507_CN_sp_sel_List_For_Cache();

            foreach (CSys_Chuc_Nang v_objData in v_arrTemp)
				Add_Data(v_objData);
        }

		public static void Add_Data(CSys_Chuc_Nang p_objData)
		{
			if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
				return;

			Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);

			Arr_Data.Add(p_objData);

			if (Dic_Data_Code.ContainsKey(p_objData.Ma_Chuc_Nang.ToLower()) == false)
				Dic_Data_Code.Add(p_objData.Ma_Chuc_Nang.ToLower(), p_objData);

			if (Dic_Data_Func_URL.ContainsKey(p_objData.Func_URL.ToLower()) == false && p_objData.Func_URL != "")
				Dic_Data_Func_URL.Add(p_objData.Func_URL.ToLower(), p_objData);

			if (Dic_Data_Nhom_CN.ContainsKey(p_objData.Nhom_Chuc_Nang_ID) == false)
				Dic_Data_Nhom_CN.Add(p_objData.Nhom_Chuc_Nang_ID, new List<CSys_Chuc_Nang>());

			Dic_Data_Nhom_CN[p_objData.Nhom_Chuc_Nang_ID].Add(p_objData);
		}

		public static void Update_Data(CSys_Chuc_Nang p_objData)
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

			CSys_Chuc_Nang v_objData = Dic_Data_ID[p_iAuto_ID];

			Arr_Data.Remove(v_objData);
			Dic_Data_ID.Remove(p_iAuto_ID);

			Dic_Data_Code.Remove(v_objData.Ma_Chuc_Nang.ToLower());
            Dic_Data_Func_URL.Remove(v_objData.Func_URL.ToLower());
			Dic_Data_Nhom_CN[v_objData.Nhom_Chuc_Nang_ID].Remove(v_objData);
        }

		public static void Delete_Data(CSys_Chuc_Nang p_objData)
		{

		}

		public static CSys_Chuc_Nang Get_Data_By_ID(long p_iID)
		{
			if (Dic_Data_ID.ContainsKey(p_iID) == true)
				return Dic_Data_ID[p_iID];

			return null;
		}

		public static CSys_Chuc_Nang Get_Data_By_Code(string p_strCode)
		{
			if (Dic_Data_Code.ContainsKey(p_strCode.ToLower()) == true)
				return Dic_Data_Code[p_strCode.ToLower()];

			return null;
		}

        public static CSys_Chuc_Nang Get_Data_By_Func_URL(string p_strFunc_URL)
        {
            if (Dic_Data_Func_URL.ContainsKey(p_strFunc_URL.ToLower()) == true)
                return Dic_Data_Func_URL[p_strFunc_URL.ToLower()];

            return null;
        }

		public static List<CSys_Chuc_Nang> List_Data_By_Nhom_Chuc_Nang_ID(int p_iNhom_Chuc_Nang_ID)
		{
			if (Dic_Data_Nhom_CN.ContainsKey(p_iNhom_Chuc_Nang_ID) == true)
				return Dic_Data_Nhom_CN[p_iNhom_Chuc_Nang_ID].ToList();

            return new List<CSys_Chuc_Nang>();
		}

        public static List<CSys_Chuc_Nang> Clone_Data_By_Nhom_Chuc_Nang_ID(int p_iNhom_Chuc_Nang_ID)
        {
			List<CSys_Chuc_Nang> v_arrRes = new List<CSys_Chuc_Nang>();

			List<CSys_Chuc_Nang> v_arrTemp = new List<CSys_Chuc_Nang>();
            if (Dic_Data_Nhom_CN.ContainsKey(p_iNhom_Chuc_Nang_ID) == true)
                v_arrTemp = Dic_Data_Nhom_CN[p_iNhom_Chuc_Nang_ID];

			foreach (CSys_Chuc_Nang v_objTemp in v_arrTemp)
			{
				CSys_Chuc_Nang v_objData = new CSys_Chuc_Nang();

				CUtility.Clone_Entity(v_objTemp, v_objData);
				v_arrRes.Add(v_objData);
            }

			return v_arrRes;
        }
    }
}
