using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Common;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
	public class CUtility_Queue_DB
	{
		private static Dictionary<long, CQueue> Dic_Queue = new Dictionary<long, CQueue>();
		public static List<CQueue> Arr_Queue = new List<CQueue>();
		private static long Current_Queued = 1;

		private static bool v_bIs_Current_Used = false;

		public static long Add_Queue(string p_strMa_Chuc_Nang, string p_strTen_Chuc_Nang, string p_strFunction_Name)
		{
			while (v_bIs_Current_Used == true)
			{ }

			v_bIs_Current_Used = true;

            long v_iRes = Current_Queued;
			Current_Queued++;
			
			try
			{
				CQueue v_objQueue = new CQueue()
				{
					Auto_ID = v_iRes,
					Ngay_Gio_Bat_Dau = DateTime.Now,
					Ma_Chuc_Nang = p_strMa_Chuc_Nang,
					Ten_Chuc_Nang = p_strTen_Chuc_Nang,
					Ten_Function = p_strFunction_Name
				};

				if (Dic_Queue.ContainsKey(v_iRes) == false)
				{
					Dic_Queue.Add(v_iRes, v_objQueue);
					Arr_Queue.Add(v_objQueue);
				}
			}
			catch (Exception ex)
			{
				CLogger.Error("Queue_DB", "Add_Queue", "[" + p_strFunction_Name + "], Current Queued [" + v_iRes.ToString() + "]:" + ex.Message);
			}

            v_bIs_Current_Used = false;

            return v_iRes;

		}

		public static void Remove_Queue(long p_iQueue_ID)
		{
            while (v_bIs_Current_Used == true)
            { }

            v_bIs_Current_Used = true;

            try
			{
				if (Dic_Queue.ContainsKey(p_iQueue_ID) == false)
				{
                    v_bIs_Current_Used = false;
                    return;
				}

				CQueue v_objQueue = Dic_Queue[p_iQueue_ID];
				Arr_Queue.Remove(v_objQueue);
				Dic_Queue.Remove(p_iQueue_ID);
			}

			catch (Exception ex)
			{
				CLogger.Error("Queue_DB", "Remove_Queue", "[" + p_iQueue_ID.ToString() + "]:" + ex.Message);
			}

            v_bIs_Current_Used = false;

        }
	}
}
