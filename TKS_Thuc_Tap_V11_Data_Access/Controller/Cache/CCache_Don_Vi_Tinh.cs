using System;
using TKS_Thuc_Tap_V11_Data_Access.Utility;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.DM;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Cache
{
	public class CCache_Don_Vi_Tinh
	{
		private static List<CDM_Don_Vi_Tinh> Arr_Data = new List<CDM_Don_Vi_Tinh>();
		private static Dictionary<long, CDM_Don_Vi_Tinh> Dic_Data_ID = new Dictionary<long, CDM_Don_Vi_Tinh>();
		private static Dictionary<string, CDM_Don_Vi_Tinh> Dic_Data_Code = new Dictionary<string, CDM_Don_Vi_Tinh>();

		public static void Load_Cache_DM_Don_Vi_Tinh()
		{
			Arr_Data.Clear();
			Dic_Data_ID.Clear();
			Dic_Data_Code.Clear();

			CDM_Don_Vi_Tinh_Controller v_objCtrData = new CDM_Don_Vi_Tinh_Controller();
			List<CDM_Don_Vi_Tinh> v_arrTemp_Data = v_objCtrData.FQ_110_DVT_sp_sel_List_For_Cache();

			foreach (CDM_Don_Vi_Tinh v_objData in v_arrTemp_Data)
				Add_Data(v_objData);
		}

		public static void Add_Data(CDM_Don_Vi_Tinh p_objData)
		{
			if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
				return;

			Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
			Arr_Data.Add(p_objData);

			string v_strKey_Code = CUtility.Tao_Key(p_objData.Auto_ID);
			if (Dic_Data_Code.ContainsKey(v_strKey_Code) == false)
				Dic_Data_Code.Add(v_strKey_Code, p_objData);
		}

		public static void Update_Data(CDM_Don_Vi_Tinh p_objData)
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

			CDM_Don_Vi_Tinh v_objData = Dic_Data_ID[p_iAuto_ID];

			Arr_Data.Remove(v_objData);
			Dic_Data_ID.Remove(p_iAuto_ID);

			string v_strKey_Code = CUtility.Tao_Key(v_objData.Auto_ID);

			Dic_Data_Code.Remove(v_strKey_Code);
		}

		public static CDM_Don_Vi_Tinh Get_Data_By_ID(long p_iID)
		{
			if (Dic_Data_ID.ContainsKey(p_iID) == true)
				return Dic_Data_ID[p_iID];

			return null;
		}

		public static CDM_Don_Vi_Tinh Get_Data_By_Code(string p_strCode)
		{
			string v_strKey = CUtility.Tao_Key(p_strCode);

			if (Dic_Data_Code.ContainsKey(v_strKey) == true)
				return Dic_Data_Code[v_strKey];

			return null;
		}
        public static List<CDM_Don_Vi_Tinh> List_Data()
        {
            return Arr_Data.OrderBy(item => item.Ten_Don_Vi_Tinh).ToList();
        }
    }
}
