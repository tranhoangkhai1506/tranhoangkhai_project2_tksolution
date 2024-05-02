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
    public class CCache_Thanh_Vien
    {
        public static List<CSys_Thanh_Vien> Arr_Data = new List<CSys_Thanh_Vien>();

        private static Dictionary<string, CSys_Thanh_Vien> Dic_Data_Code = new Dictionary<string, CSys_Thanh_Vien>();
        private static Dictionary<long, CSys_Thanh_Vien> Dic_Data_ID = new Dictionary<long, CSys_Thanh_Vien>();

        public static void Load_Cache_Thanh_Vien()
        {
			Arr_Data.Clear();
			Dic_Data_Code.Clear();
			Dic_Data_ID.Clear();

			CSys_Thanh_Vien_Controller v_objCtrData = new CSys_Thanh_Vien_Controller();
            List<CSys_Thanh_Vien> v_arrTemp_Data = v_objCtrData.FQ_531_TV_sp_sel_List_For_Cache();

            foreach (CSys_Thanh_Vien v_objData in v_arrTemp_Data)
                Add_Data(v_objData);
        }

        public static void Add_Data(CSys_Thanh_Vien p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            if (Dic_Data_Code.ContainsKey(p_objData.Ma_Dang_Nhap.ToLower()) == false)
                Dic_Data_Code.Add(p_objData.Ma_Dang_Nhap.ToLower(), p_objData);
        }

        public static void Update_Data(CSys_Thanh_Vien p_objData)
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

            CSys_Thanh_Vien v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);

            Dic_Data_Code.Remove(v_objData.Ma_Dang_Nhap.ToLower());
        }

        public static CSys_Thanh_Vien Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static CSys_Thanh_Vien Get_Data_By_Ma_Dang_Nhap(string p_strCode)
        {
            if (Dic_Data_Code.ContainsKey(p_strCode.ToLower()) == true)
                return Dic_Data_Code[p_strCode.ToLower()];

            return null;
        }

		public static List<CSys_Thanh_Vien> List_Data()
        {
            return Arr_Data;
        }

	}
}
