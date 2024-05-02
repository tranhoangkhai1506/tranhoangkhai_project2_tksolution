using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Cache
{
    public class CCache_Daily_Schedule_Job
    {
        private static List<CSys_Daily_Schedule_Job> Arr_Data = new List<CSys_Daily_Schedule_Job>();

        private static Dictionary<long, CSys_Daily_Schedule_Job> Dic_Data_ID = new Dictionary<long, CSys_Daily_Schedule_Job>();

        public static void Load_Cache_Daily_Schedule_Job()
        {
            Arr_Data.Clear();
            Dic_Data_ID.Clear();

            CSys_Daily_Schedule_Job_Controller v_objCtrData = new CSys_Daily_Schedule_Job_Controller();
            List<CSys_Daily_Schedule_Job> v_arrTemp_Data = v_objCtrData.FQ_510_DSJ_sp_sel_List_For_Cache(); //

            foreach (CSys_Daily_Schedule_Job v_objData in v_arrTemp_Data)
                Add_Data(v_objData);
        }

		public static void Add_Data(CSys_Daily_Schedule_Job p_objData)
		{
			if (Dic_Data_ID.ContainsKey(p_objData.Auto_ID) == true || p_objData.Auto_ID == 0)
				return;

			Dic_Data_ID.Add(p_objData.Auto_ID, p_objData);
			Arr_Data.Add(p_objData);			
		}

		public static void Update_Data(CSys_Daily_Schedule_Job p_objData)
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

			CSys_Daily_Schedule_Job v_objData = Dic_Data_ID[p_iAuto_ID];

			Arr_Data.Remove(v_objData);
			Dic_Data_ID.Remove(p_iAuto_ID);

		}

		public static CSys_Daily_Schedule_Job Get_Data_By_ID(long p_iID)
		{
			if (Dic_Data_ID.ContainsKey(p_iID) == true)
				return Dic_Data_ID[p_iID];

			return null;
		}
	}
}
