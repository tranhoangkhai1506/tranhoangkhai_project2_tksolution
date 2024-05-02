using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.DM;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Cache
{
    public class CCache_Cau_Hinh_Component_App
    {
        private static List<CSys_Cau_Hinh_Component_App> Arr_Data = new();
        private static Dictionary<long, CSys_Cau_Hinh_Component_App> Dic_Data_ID = new Dictionary<long, CSys_Cau_Hinh_Component_App>();
        private static Dictionary<long, List<CSys_Cau_Hinh_Component_App>> Dic_Data_Chu_Hang = new ();

        public static void Load_Cache_Cau_Hinh_Component_App()
        {
            Arr_Data.Clear();
            Dic_Data_Chu_Hang.Clear();

            CSys_Cau_Hinh_Component_App_Controller v_objCtrData = new ();
            //List<CSys_Cau_Hinh_Component_App> v_arrTemp_Data = v_objCtrData.FCombo_List_Sys_Cau_Hinh_Component_App(); //
            List<CSys_Cau_Hinh_Component_App> v_arrTemp_Data = v_objCtrData.FQ_506_CHCA_sp_sel_List_For_Cache(); //
            foreach (CSys_Cau_Hinh_Component_App v_objData in v_arrTemp_Data)
                Add_Data(v_objData);
        }

        public static void Add_Data(CSys_Cau_Hinh_Component_App p_objData)
        {
            if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
                return;

            Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
            Arr_Data.Add(p_objData);

            if (Dic_Data_Chu_Hang.ContainsKey(p_objData.Chu_Hang_ID) == false)
                Dic_Data_Chu_Hang.Add(p_objData.Chu_Hang_ID, new List<CSys_Cau_Hinh_Component_App>());

            Dic_Data_Chu_Hang[p_objData.Chu_Hang_ID].Add(p_objData);
        }

        public static void Update_Data(CSys_Cau_Hinh_Component_App p_objData)
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

            CSys_Cau_Hinh_Component_App v_objData = Dic_Data_ID[p_iAuto_ID];

            Arr_Data.Remove(v_objData);
            Dic_Data_ID.Remove(p_iAuto_ID);
            Dic_Data_Chu_Hang[v_objData.Chu_Hang_ID].Remove(v_objData);
        }

        public static CSys_Cau_Hinh_Component_App Get_Data_By_ID(long p_iID)
        {
            if (Dic_Data_ID.ContainsKey(p_iID) == true)
                return Dic_Data_ID[p_iID];

            return null;
        }

        public static List<CSys_Cau_Hinh_Component_App> List_Data_By_Chu_Hang_ID(long p_iChu_Hang_ID)
        {
            if (Dic_Data_Chu_Hang.ContainsKey(p_iChu_Hang_ID) == true)
                return Dic_Data_Chu_Hang[p_iChu_Hang_ID].ToList();

            return new List<CSys_Cau_Hinh_Component_App>();
        }

    }
}
