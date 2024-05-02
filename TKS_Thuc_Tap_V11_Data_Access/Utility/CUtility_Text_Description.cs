using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
    public class CUtility_Text_Description
    {
		public static string Grid_Field_Type_Text(int p_iField_Type_ID)
		{
			string v_strRes = "";

			switch (p_iField_Type_ID)
			{
				case (int)EGrid_Field_Type_ID.Data_Column: v_strRes = "Data Column"; break;
				case (int)EGrid_Field_Type_ID.Check_Box: v_strRes = "Check box"; break;
				case (int)EGrid_Field_Type_ID.HTML: v_strRes = "HTML"; break;
				case (int)EGrid_Field_Type_ID.Band_Column: v_strRes = "Band"; break;
			}

			return v_strRes;
		}

    }
}
