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
    public class CCache_Hien_An_Column
    {
        public static List<CSys_Hien_An_Column> Arr_Data = new List<CSys_Hien_An_Column>();

        private static Dictionary<string, CSys_Hien_An_Column> Dic_Data_Code = new Dictionary<string, CSys_Hien_An_Column>();
        private static Dictionary<long, CSys_Hien_An_Column> Dic_Data_ID = new Dictionary<long, CSys_Hien_An_Column>();

        public static void Load_Cache_Hien_An_Column()
        {
			Arr_Data.Clear();
			Dic_Data_Code.Clear();
			Dic_Data_ID.Clear();

			CSys_Hien_An_Column_Controller v_objCtrData = new CSys_Hien_An_Column_Controller();
            List<CSys_Hien_An_Column> v_arrTemp = v_objCtrData.FQ_519_HAC_sp_sel_List_For_Cache();

            foreach (CSys_Hien_An_Column v_objData in v_arrTemp)
                Add_Data(v_objData);
        }

        public static void Add_Data(CSys_Hien_An_Column p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            string v_strKey = p_objData.Chu_Hang_ID.ToString() + "|" + p_objData.Field_Name.ToLower() + "|" + p_objData.Ma_Chuc_Nang.ToLower();
            if (Dic_Data_Code.ContainsKey(v_strKey) == false)
                Dic_Data_Code.Add(v_strKey, p_objData);
        }

        public static void Update_Data(CSys_Hien_An_Column p_objData)
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

            CSys_Hien_An_Column v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);

            string v_strKey = v_objData.Chu_Hang_ID.ToString() + "|" + v_objData.Field_Name.ToLower() + "|" + v_objData.Ma_Chuc_Nang.ToLower();
            Dic_Data_Code.Remove(v_strKey.ToLower());
        }

        public static CSys_Hien_An_Column Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static CSys_Hien_An_Column Get_Data_By_Code(long p_iChu_Hang_ID, string p_strField_Name, string p_strMa_Chuc_Nang)
        {
            string v_strKey = p_iChu_Hang_ID.ToString() + "|" + p_strField_Name.ToLower() + "|" + p_strMa_Chuc_Nang.ToLower();

            if (Dic_Data_Code.ContainsKey(v_strKey) == true)
                return Dic_Data_Code[v_strKey];

            return null;
        }
    }
}
