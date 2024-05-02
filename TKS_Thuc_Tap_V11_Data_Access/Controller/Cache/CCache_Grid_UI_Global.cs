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
	public class CCache_Grid_UI_Global
	{
		private static List<CSys_Grid_UI_Global> Arr_Data = new();
		private static Dictionary<long, CSys_Grid_UI_Global> Dic_Data_ID = new();
		private static Dictionary<string, List<CSys_Grid_UI_Global>> Dic_Data_Code = new ();
        private static Dictionary<string, List<CSys_Grid_UI_Global>> Dic_Data_Ma_CN = new();
		private static Dictionary<string, CSys_Grid_UI_Global> Dic_Data_Key = new();

		public static void Load_Cache_Grid_UI_Global()
		{
			Arr_Data.Clear();
			Dic_Data_ID.Clear();
			Dic_Data_Code.Clear();
			Dic_Data_Ma_CN.Clear();
			Dic_Data_Key.Clear();

			CSys_Grid_UI_Global_Controller v_objCtrData = new ();
			List<CSys_Grid_UI_Global> v_arrTemp_Data = v_objCtrData.FQ_516_GUG_sp_sel_List_For_Cache(); //
			foreach (CSys_Grid_UI_Global v_objData in v_arrTemp_Data)
				Add_Data(v_objData);
		}

		public static void Add_Data(CSys_Grid_UI_Global p_objData)
		{
			if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
				return;

			Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
			Arr_Data.Add(p_objData);

			string v_strKey_Code = CUtility.Tao_Key(p_objData.Ma_Chuc_Nang, p_objData.Ten_Grid);

			if (Dic_Data_Code.ContainsKey(v_strKey_Code) == false)
				Dic_Data_Code.Add(v_strKey_Code, new List<CSys_Grid_UI_Global>());

            Dic_Data_Code[v_strKey_Code].Add(p_objData);

            string v_strMa_CN = CUtility.Tao_Key(p_objData.Ma_Chuc_Nang);

            if (Dic_Data_Ma_CN.ContainsKey(v_strMa_CN) == false)
                Dic_Data_Ma_CN.Add(v_strMa_CN, new List<CSys_Grid_UI_Global>());

            Dic_Data_Ma_CN[v_strMa_CN].Add(p_objData);

			string v_strKey = CUtility.Tao_Key(p_objData.Ma_Chuc_Nang, p_objData.Ten_Grid, p_objData.Field_Name);

			if (Dic_Data_Key.ContainsKey(v_strKey) == false)
				Dic_Data_Key.Add(v_strKey, p_objData);
		}

		public static void Update_Data(CSys_Grid_UI_Global p_objData)
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

			CSys_Grid_UI_Global v_objData = Dic_Data_ID[p_iAuto_ID];

			Arr_Data.Remove(v_objData);
			Dic_Data_ID.Remove(p_iAuto_ID);

			string v_strKey_Code = CUtility.Tao_Key(v_objData.Ma_Chuc_Nang, v_objData.Ten_Grid);
			Dic_Data_Code[v_strKey_Code].Remove(v_objData);

            string v_strMa_CN = CUtility.Tao_Key(v_objData.Ma_Chuc_Nang);
			Dic_Data_Ma_CN[v_strMa_CN].Remove(v_objData);

			string v_strKey = CUtility.Tao_Key(v_objData.Ma_Chuc_Nang, v_objData.Ten_Grid, v_objData.Field_Name);
			Dic_Data_Key.Remove(v_strKey);
		}

        public static void Delete_Data_By_Grid_Field_ID(long p_iGrid_Field_ID)
        {
            List<CSys_Grid_UI_Global> v_arrData = Arr_Data.Where(it => it.Grid_Field_ID == p_iGrid_Field_ID).ToList();
            foreach (CSys_Grid_UI_Global v_obj in v_arrData)
                Delete_Data(v_obj.Auto_ID);
        }
        public static CSys_Grid_UI_Global Get_Data_By_ID(long p_iID)
		{
			if (Dic_Data_ID.ContainsKey(p_iID) == true)
				return Dic_Data_ID[p_iID];

			return null;
		}

		public static CSys_Grid_UI_Global Get_Data_By_Key(string p_strMa_Chuc_Nang, string p_strTen_Grid, string p_strField_Name)
		{
			string v_strKey = CUtility.Tao_Key(p_strMa_Chuc_Nang, p_strTen_Grid, p_strField_Name);
			if (Dic_Data_Key.ContainsKey(v_strKey) == true)
				return Dic_Data_Key[v_strKey];

			return null;
		}

		public static List<CSys_Grid_UI_Global> List_Data_By_Code(string p_strMa_Chuc_Nang, string p_strTen_Grid)
		{
			string v_strKey = CUtility.Tao_Key(p_strMa_Chuc_Nang, p_strTen_Grid);

			if (Dic_Data_Code.ContainsKey(v_strKey) == true)
				return Dic_Data_Code[v_strKey].OrderBy(it=>it.Ten_Grid == p_strTen_Grid).ThenBy(it => it.Sort_Priority).ToList();

			return new List<CSys_Grid_UI_Global>();
		}

        public static List<CSys_Grid_UI_Global> List_Data_By_Ma_Chuc_Nang(string p_strMa_Chuc_Nang)
        {
            if (Dic_Data_Ma_CN.ContainsKey(p_strMa_Chuc_Nang) == true)
                return Dic_Data_Ma_CN[p_strMa_Chuc_Nang].OrderBy(it=>it.Sort_Priority).ToList();

            return new List<CSys_Grid_UI_Global>();
        }
        public static List<CSys_Grid_UI_Global> List_Data_All()
		{
			return Arr_Data.ToList();
		}
	}
}
