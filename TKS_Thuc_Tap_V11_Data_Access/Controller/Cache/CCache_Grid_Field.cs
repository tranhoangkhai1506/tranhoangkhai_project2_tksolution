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
	public class CCache_Grid_Field
	{
		private static List<CSys_Grid_Field> Arr_Data = new List<CSys_Grid_Field>();

        private static Dictionary<string, List<CSys_Grid_Field>> Dic_Data_Code = new();
        private static Dictionary<long, CSys_Grid_Field> Dic_Data_ID = new Dictionary<long, CSys_Grid_Field>();
        private static Dictionary<string, CSys_Grid_Field> Dic_Data_Key = new Dictionary<string, CSys_Grid_Field>();
        public static void Load_Cache_Grid_Field()
		{
			Arr_Data.Clear();
			Dic_Data_ID.Clear();
            Dic_Data_Code.Clear();
			Dic_Data_Key.Clear();

            CSys_Grid_Field_Controller v_objCtrData = new CSys_Grid_Field_Controller();
			List<CSys_Grid_Field> v_arrTemp_Data = v_objCtrData.FQ_514_GF_sp_sel_List_For_Cache(); //
			foreach (CSys_Grid_Field v_objData in v_arrTemp_Data)
				Add_Data(v_objData);
		}

		public static void Add_Data(CSys_Grid_Field p_objData)
		{
			if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
				return;

			Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
			Arr_Data.Add(p_objData);

            string v_strKey = CUtility.Tao_Key(p_objData.Ma_Chuc_Nang, p_objData.Ten_Grid, p_objData.Field_Name);
			if (!Dic_Data_Key.ContainsKey(v_strKey))
				Dic_Data_Key.Add(v_strKey, p_objData);

            string v_strKey_Code = CUtility.Tao_Key(p_objData.Ma_Chuc_Nang, p_objData.Ten_Grid);
            if (Dic_Data_Code.ContainsKey(v_strKey_Code) == false)
                Dic_Data_Code.Add(v_strKey_Code, new List<CSys_Grid_Field>());

            Dic_Data_Code[v_strKey_Code].Add(p_objData);
        }

		public static void Update_Data(CSys_Grid_Field p_objData)
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

			CSys_Grid_Field v_objData = Dic_Data_ID[p_iAuto_ID];

			Arr_Data.Remove(v_objData);
			Dic_Data_ID.Remove(p_iAuto_ID);

            string v_strKey = CUtility.Tao_Key(v_objData.Ma_Chuc_Nang, v_objData.Ten_Grid, v_objData.Field_Name);
            Dic_Data_Key.Remove(v_strKey);

            string v_strKey_Code = CUtility.Tao_Key(v_objData.Ma_Chuc_Nang, v_objData.Ten_Grid);
            Dic_Data_Code[v_strKey_Code].Remove(v_objData);
        }

		public static CSys_Grid_Field Get_Data_By_ID(long p_iID)
		{
			if (Dic_Data_ID.ContainsKey(p_iID) == true)
				return Dic_Data_ID[p_iID];

			return null;
		}

        public static CSys_Grid_Field Get_Data_By_Key(string p_strMa_Chuc_Nang, string p_strTen_Grid, string Field_Name)
        {
            string v_strKey = CUtility.Tao_Key(p_strMa_Chuc_Nang, p_strTen_Grid, Field_Name);

            if (Dic_Data_Key.ContainsKey(v_strKey) == true)
                return Dic_Data_Key[v_strKey];

            return null;
        }

        public static List<CSys_Grid_Field> List_Data_By_Code(string p_strMa_Chuc_Nang, string p_strTen_Grid)
        {
            string v_strKey = CUtility.Tao_Key(p_strMa_Chuc_Nang, p_strTen_Grid);

            if (Dic_Data_Code.ContainsKey(v_strKey) == true)
                return Dic_Data_Code[v_strKey].OrderBy(it => it.Ten_Grid == p_strTen_Grid).ToList();

            return null;
        }

        public static List<CSys_Grid_Field> List_Data_All()
		{
			return Arr_Data.ToList();
		}
	}
}
