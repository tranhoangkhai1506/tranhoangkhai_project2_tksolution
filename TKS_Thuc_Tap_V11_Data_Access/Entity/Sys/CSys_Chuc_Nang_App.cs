using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
	public class CSys_Chuc_Nang_App
	{
		private long m_lngAuto_ID;
		private long m_lngNhom_PDA_ID;

		private int m_intFApp_M01_ID;
		private string m_strFApp_M01_Label;

		private int m_intFApp_ID;
		private string m_strFApp_Label;

		private int m_intFApp_M02_ID;
		private string m_strFApp_M02_Label;
		private int m_intFApp_M03_ID;
		private string m_strFApp_M03_Label;
		private int m_intFApp_M04_ID;
		private string m_strFApp_M04_Label;
		private int m_intFApp_M05_ID;
		private string m_strFApp_M05_Label;
		private int m_intFApp_M06_ID;
		private string m_strFApp_M06_Label;
		private int m_intFApp_M07_ID;
		private string m_strFApp_M07_Label;
		private int m_intFApp_M08_ID;
		private string m_strFApp_M08_Label;
		private int m_intFApp_M09_ID;
		private string m_strFApp_M09_Label;
		private int m_intFApp_M10_ID;
		private string m_strFApp_M10_Label;
		private int m_intFApp_M11_ID;
		private string m_strFApp_M11_Label;
		private int m_intFApp_M12_ID;
		private string m_strFApp_M12_Label;
		private int m_intFApp_M13_ID;
		private string m_strFApp_M13_Label;
		private int m_intFApp_M14_ID;
		private string m_strFApp_M14_Label;
		private int m_intFApp_M15_ID;
		private string m_strFApp_M15_Label;
		private int m_intFApp_M16_ID;
		private string m_strFApp_M16_Label;
		private int m_intFApp_M17_ID;
		private string m_strFApp_M17_Label;
		private int m_intFApp_M18_ID;
		private string m_strFApp_M18_Label;
		private int m_intFApp_M19_ID;
		private string m_strFApp_M19_Label;
		private int m_intFApp_M20_ID;
		private string m_strFApp_M20_Label;
		private int m_intFApp_M21_ID;
		private string m_strFApp_M21_Label;
		private int m_intFApp_M22_ID;
		private string m_strFApp_M22_Label;
		private int m_intFApp_M23_ID;
		private string m_strFApp_M23_Label;
		private int m_intFApp_M24_ID;
		private string m_strFApp_M24_Label;
		private int m_intFApp_M25_ID;
		private string m_strFApp_M25_Label;
		private int m_intFApp_M26_ID;
		private string m_strFApp_M26_Label;
		private int m_intFApp_M27_ID;
		private string m_strFApp_M27_Label;
		private int m_intFApp_M28_ID;
		private string m_strFApp_M28_Label;
		private int m_intFApp_M29_ID;
		private string m_strFApp_M29_Label;
		private int m_intFApp_M30_ID;
		private string m_strFApp_M30_Label;
		private int m_intFApp_M31_ID;
		private string m_strFApp_M31_Label;
		private int m_intFApp_M32_ID;
		private string m_strFApp_M32_Label;
		private int m_intFApp_M33_ID;
		private string m_strFApp_M33_Label;
		private int m_intFApp_M34_ID;
		private string m_strFApp_M34_Label;
		private int m_intFApp_M35_ID;
		private string m_strFApp_M35_Label;
		private int m_intFApp_M36_ID;
		private string m_strFApp_M36_Label;
		private int m_intFApp_M37_ID;
		private string m_strFApp_M37_Label;
		private int m_intFApp_M38_ID;
		private string m_strFApp_M38_Label;
		private int m_intFApp_M39_ID;
		private string m_strFApp_M39_Label;
		private int m_intFApp_M40_ID;
		private string m_strFApp_M40_Label;
		private int m_intFApp_M41_ID;
		private string m_strFApp_M41_Label;
		private int m_intFApp_M42_ID;
		private string m_strFApp_M42_Label;
		private int m_intFApp_M43_ID;
		private string m_strFApp_M43_Label;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;
		private string m_strTen_Nhom_PDA;

		public CSys_Chuc_Nang_App()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_lngNhom_PDA_ID = CConst.INT_VALUE_NULL;

			m_intFApp_ID = CConst.INT_VALUE_NULL;
			m_strFApp_Label = CConst.STR_VALUE_NULL;

			m_intFApp_M01_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M01_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M02_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M02_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M03_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M03_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M04_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M04_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M05_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M05_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M06_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M06_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M07_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M07_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M08_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M08_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M09_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M09_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M10_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M10_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M11_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M11_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M12_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M12_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M13_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M13_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M14_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M14_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M15_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M15_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M16_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M16_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M17_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M17_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M18_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M18_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M19_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M19_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M20_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M20_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M21_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M21_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M22_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M22_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M23_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M23_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M24_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M24_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M25_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M25_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M26_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M26_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M27_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M27_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M28_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M28_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M29_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M29_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M30_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M30_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M31_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M31_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M32_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M32_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M33_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M33_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M34_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M34_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M35_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M35_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M36_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M36_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M37_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M37_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M38_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M38_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M39_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M39_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M40_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M40_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M41_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M41_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M42_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M42_Label = CConst.STR_VALUE_NULL;
			m_intFApp_M43_ID = CConst.INT_VALUE_NULL;
			m_strFApp_M43_Label = CConst.STR_VALUE_NULL;
			m_intdeleted = CConst.INT_VALUE_NULL;
			m_dtmCreated = CConst.DTM_VALUE_NULL;
			m_strCreated_By = CConst.STR_VALUE_NULL;
			m_strCreated_By_Function = CConst.STR_VALUE_NULL;
			m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
			m_strLast_Updated_By = CConst.STR_VALUE_NULL;
			m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
			m_strTen_Nhom_PDA = CConst.STR_VALUE_NULL;
		}

		public long Auto_ID
		{
			get
			{
				return m_lngAuto_ID;
			}
			set
			{
				m_lngAuto_ID = value;
			}
		}

		public long Nhom_PDA_ID
		{
			get
			{
				return m_lngNhom_PDA_ID;
			}
			set
			{
				m_lngNhom_PDA_ID = value;
			}
		}

		public int FApp_ID
		{
			get
			{
				return m_intFApp_ID;
			}
			set
			{
				m_intFApp_ID = value;
			}
		}

		public string FApp_Label
		{
			get
			{
				return m_strFApp_Label;
			}
			set
			{
				m_strFApp_Label = value.Trim();
			}
		}

		public int FApp_M01_ID
		{
			get
			{
				return m_intFApp_M01_ID;
			}
			set
			{
				m_intFApp_M01_ID = value;
			}
		}

		public string FApp_M01_Label
		{
			get
			{
				return m_strFApp_M01_Label;
			}
			set
			{
				m_strFApp_M01_Label = value.Trim();
			}
		}

		public int FApp_M02_ID
		{
			get
			{
				return m_intFApp_M02_ID;
			}
			set
			{
				m_intFApp_M02_ID = value;
			}
		}

		public string FApp_M02_Label
		{
			get
			{
				return m_strFApp_M02_Label;
			}
			set
			{
				m_strFApp_M02_Label = value.Trim();
			}
		}

		public int FApp_M03_ID
		{
			get
			{
				return m_intFApp_M03_ID;
			}
			set
			{
				m_intFApp_M03_ID = value;
			}
		}

		public string FApp_M03_Label
		{
			get
			{
				return m_strFApp_M03_Label;
			}
			set
			{
				m_strFApp_M03_Label = value.Trim();
			}
		}

		public int FApp_M04_ID
		{
			get
			{
				return m_intFApp_M04_ID;
			}
			set
			{
				m_intFApp_M04_ID = value;
			}
		}

		public string FApp_M04_Label
		{
			get
			{
				return m_strFApp_M04_Label;
			}
			set
			{
				m_strFApp_M04_Label = value.Trim();
			}
		}

		public int FApp_M05_ID
		{
			get
			{
				return m_intFApp_M05_ID;
			}
			set
			{
				m_intFApp_M05_ID = value;
			}
		}

		public string FApp_M05_Label
		{
			get
			{
				return m_strFApp_M05_Label;
			}
			set
			{
				m_strFApp_M05_Label = value.Trim();
			}
		}

		public int FApp_M06_ID
		{
			get
			{
				return m_intFApp_M06_ID;
			}
			set
			{
				m_intFApp_M06_ID = value;
			}
		}

		public string FApp_M06_Label
		{
			get
			{
				return m_strFApp_M06_Label;
			}
			set
			{
				m_strFApp_M06_Label = value.Trim();
			}
		}

		public int FApp_M07_ID
		{
			get
			{
				return m_intFApp_M07_ID;
			}
			set
			{
				m_intFApp_M07_ID = value;
			}
		}

		public string FApp_M07_Label
		{
			get
			{
				return m_strFApp_M07_Label;
			}
			set
			{
				m_strFApp_M07_Label = value.Trim();
			}
		}

		public int FApp_M08_ID
		{
			get
			{
				return m_intFApp_M08_ID;
			}
			set
			{
				m_intFApp_M08_ID = value;
			}
		}

		public string FApp_M08_Label
		{
			get
			{
				return m_strFApp_M08_Label;
			}
			set
			{
				m_strFApp_M08_Label = value.Trim();
			}
		}

		public int FApp_M09_ID
		{
			get
			{
				return m_intFApp_M09_ID;
			}
			set
			{
				m_intFApp_M09_ID = value;
			}
		}

		public string FApp_M09_Label
		{
			get
			{
				return m_strFApp_M09_Label;
			}
			set
			{
				m_strFApp_M09_Label = value.Trim();
			}
		}

		public int FApp_M10_ID
		{
			get
			{
				return m_intFApp_M10_ID;
			}
			set
			{
				m_intFApp_M10_ID = value;
			}
		}

		public string FApp_M10_Label
		{
			get
			{
				return m_strFApp_M10_Label;
			}
			set
			{
				m_strFApp_M10_Label = value.Trim();
			}
		}

		public int FApp_M11_ID
		{
			get
			{
				return m_intFApp_M11_ID;
			}
			set
			{
				m_intFApp_M11_ID = value;
			}
		}

		public string FApp_M11_Label
		{
			get
			{
				return m_strFApp_M11_Label;
			}
			set
			{
				m_strFApp_M11_Label = value.Trim();
			}
		}

		public int FApp_M12_ID
		{
			get
			{
				return m_intFApp_M12_ID;
			}
			set
			{
				m_intFApp_M12_ID = value;
			}
		}

		public string FApp_M12_Label
		{
			get
			{
				return m_strFApp_M12_Label;
			}
			set
			{
				m_strFApp_M12_Label = value.Trim();
			}
		}

		public int FApp_M13_ID
		{
			get
			{
				return m_intFApp_M13_ID;
			}
			set
			{
				m_intFApp_M13_ID = value;
			}
		}

		public string FApp_M13_Label
		{
			get
			{
				return m_strFApp_M13_Label;
			}
			set
			{
				m_strFApp_M13_Label = value.Trim();
			}
		}

		public int FApp_M14_ID
		{
			get
			{
				return m_intFApp_M14_ID;
			}
			set
			{
				m_intFApp_M14_ID = value;
			}
		}

		public string FApp_M14_Label
		{
			get
			{
				return m_strFApp_M14_Label;
			}
			set
			{
				m_strFApp_M14_Label = value.Trim();
			}
		}

		public int FApp_M15_ID
		{
			get
			{
				return m_intFApp_M15_ID;
			}
			set
			{
				m_intFApp_M15_ID = value;
			}
		}

		public string FApp_M15_Label
		{
			get
			{
				return m_strFApp_M15_Label;
			}
			set
			{
				m_strFApp_M15_Label = value.Trim();
			}
		}

		public int FApp_M16_ID
		{
			get
			{
				return m_intFApp_M16_ID;
			}
			set
			{
				m_intFApp_M16_ID = value;
			}
		}

		public string FApp_M16_Label
		{
			get
			{
				return m_strFApp_M16_Label;
			}
			set
			{
				m_strFApp_M16_Label = value.Trim();
			}
		}

		public int FApp_M17_ID
		{
			get
			{
				return m_intFApp_M17_ID;
			}
			set
			{
				m_intFApp_M17_ID = value;
			}
		}

		public string FApp_M17_Label
		{
			get
			{
				return m_strFApp_M17_Label;
			}
			set
			{
				m_strFApp_M17_Label = value.Trim();
			}
		}

		public int FApp_M18_ID
		{
			get
			{
				return m_intFApp_M18_ID;
			}
			set
			{
				m_intFApp_M18_ID = value;
			}
		}

		public string FApp_M18_Label
		{
			get
			{
				return m_strFApp_M18_Label;
			}
			set
			{
				m_strFApp_M18_Label = value.Trim();
			}
		}

		public int FApp_M19_ID
		{
			get
			{
				return m_intFApp_M19_ID;
			}
			set
			{
				m_intFApp_M19_ID = value;
			}
		}

		public string FApp_M19_Label
		{
			get
			{
				return m_strFApp_M19_Label;
			}
			set
			{
				m_strFApp_M19_Label = value.Trim();
			}
		}

		public int FApp_M20_ID
		{
			get
			{
				return m_intFApp_M20_ID;
			}
			set
			{
				m_intFApp_M20_ID = value;
			}
		}

		public string FApp_M20_Label
		{
			get
			{
				return m_strFApp_M20_Label;
			}
			set
			{
				m_strFApp_M20_Label = value.Trim();
			}
		}

		public int FApp_M21_ID
		{
			get
			{
				return m_intFApp_M21_ID;
			}
			set
			{
				m_intFApp_M21_ID = value;
			}
		}

		public string FApp_M21_Label
		{
			get
			{
				return m_strFApp_M21_Label;
			}
			set
			{
				m_strFApp_M21_Label = value.Trim();
			}
		}

		public int FApp_M22_ID
		{
			get
			{
				return m_intFApp_M22_ID;
			}
			set
			{
				m_intFApp_M22_ID = value;
			}
		}

		public string FApp_M22_Label
		{
			get
			{
				return m_strFApp_M22_Label;
			}
			set
			{
				m_strFApp_M22_Label = value.Trim();
			}
		}

		public int FApp_M23_ID
		{
			get
			{
				return m_intFApp_M23_ID;
			}
			set
			{
				m_intFApp_M23_ID = value;
			}
		}

		public string FApp_M23_Label
		{
			get
			{
				return m_strFApp_M23_Label;
			}
			set
			{
				m_strFApp_M23_Label = value.Trim();
			}
		}

		public int FApp_M24_ID
		{
			get
			{
				return m_intFApp_M24_ID;
			}
			set
			{
				m_intFApp_M24_ID = value;
			}
		}

		public string FApp_M24_Label
		{
			get
			{
				return m_strFApp_M24_Label;
			}
			set
			{
				m_strFApp_M24_Label = value.Trim();
			}
		}

		public int FApp_M25_ID
		{
			get
			{
				return m_intFApp_M25_ID;
			}
			set
			{
				m_intFApp_M25_ID = value;
			}
		}

		public string FApp_M25_Label
		{
			get
			{
				return m_strFApp_M25_Label;
			}
			set
			{
				m_strFApp_M25_Label = value.Trim();
			}
		}

		public int FApp_M26_ID
		{
			get
			{
				return m_intFApp_M26_ID;
			}
			set
			{
				m_intFApp_M26_ID = value;
			}
		}

		public string FApp_M26_Label
		{
			get
			{
				return m_strFApp_M26_Label;
			}
			set
			{
				m_strFApp_M26_Label = value.Trim();
			}
		}

		public int FApp_M27_ID
		{
			get
			{
				return m_intFApp_M27_ID;
			}
			set
			{
				m_intFApp_M27_ID = value;
			}
		}

		public string FApp_M27_Label
		{
			get
			{
				return m_strFApp_M27_Label;
			}
			set
			{
				m_strFApp_M27_Label = value.Trim();
			}
		}

		public int FApp_M28_ID
		{
			get
			{
				return m_intFApp_M28_ID;
			}
			set
			{
				m_intFApp_M28_ID = value;
			}
		}

		public string FApp_M28_Label
		{
			get
			{
				return m_strFApp_M28_Label;
			}
			set
			{
				m_strFApp_M28_Label = value.Trim();
			}
		}

		public int FApp_M29_ID
		{
			get
			{
				return m_intFApp_M29_ID;
			}
			set
			{
				m_intFApp_M29_ID = value;
			}
		}

		public string FApp_M29_Label
		{
			get
			{
				return m_strFApp_M29_Label;
			}
			set
			{
				m_strFApp_M29_Label = value.Trim();
			}
		}

		public int FApp_M30_ID
		{
			get
			{
				return m_intFApp_M30_ID;
			}
			set
			{
				m_intFApp_M30_ID = value;
			}
		}

		public string FApp_M30_Label
		{
			get
			{
				return m_strFApp_M30_Label;
			}
			set
			{
				m_strFApp_M30_Label = value.Trim();
			}
		}

		public int FApp_M31_ID
		{
			get
			{
				return m_intFApp_M31_ID;
			}
			set
			{
				m_intFApp_M31_ID = value;
			}
		}

		public string FApp_M31_Label
		{
			get
			{
				return m_strFApp_M31_Label;
			}
			set
			{
				m_strFApp_M31_Label = value.Trim();
			}
		}

		public int FApp_M32_ID
		{
			get
			{
				return m_intFApp_M32_ID;
			}
			set
			{
				m_intFApp_M32_ID = value;
			}
		}

		public string FApp_M32_Label
		{
			get
			{
				return m_strFApp_M32_Label;
			}
			set
			{
				m_strFApp_M32_Label = value.Trim();
			}
		}

		public int FApp_M33_ID
		{
			get
			{
				return m_intFApp_M33_ID;
			}
			set
			{
				m_intFApp_M33_ID = value;
			}
		}

		public string FApp_M33_Label
		{
			get
			{
				return m_strFApp_M33_Label;
			}
			set
			{
				m_strFApp_M33_Label = value.Trim();
			}
		}

		public int FApp_M34_ID
		{
			get
			{
				return m_intFApp_M34_ID;
			}
			set
			{
				m_intFApp_M34_ID = value;
			}
		}

		public string FApp_M34_Label
		{
			get
			{
				return m_strFApp_M34_Label;
			}
			set
			{
				m_strFApp_M34_Label = value.Trim();
			}
		}

		public int FApp_M35_ID
		{
			get
			{
				return m_intFApp_M35_ID;
			}
			set
			{
				m_intFApp_M35_ID = value;
			}
		}

		public string FApp_M35_Label
		{
			get
			{
				return m_strFApp_M35_Label;
			}
			set
			{
				m_strFApp_M35_Label = value.Trim();
			}
		}

		public int FApp_M36_ID
		{
			get
			{
				return m_intFApp_M36_ID;
			}
			set
			{
				m_intFApp_M36_ID = value;
			}
		}

		public string FApp_M36_Label
		{
			get
			{
				return m_strFApp_M36_Label;
			}
			set
			{
				m_strFApp_M36_Label = value.Trim();
			}
		}

		public int FApp_M37_ID
		{
			get
			{
				return m_intFApp_M37_ID;
			}
			set
			{
				m_intFApp_M37_ID = value;
			}
		}

		public string FApp_M37_Label
		{
			get
			{
				return m_strFApp_M37_Label;
			}
			set
			{
				m_strFApp_M37_Label = value.Trim();
			}
		}

		public int FApp_M38_ID
		{
			get
			{
				return m_intFApp_M38_ID;
			}
			set
			{
				m_intFApp_M38_ID = value;
			}
		}

		public string FApp_M38_Label
		{
			get
			{
				return m_strFApp_M38_Label;
			}
			set
			{
				m_strFApp_M38_Label = value.Trim();
			}
		}

		public int FApp_M39_ID
		{
			get
			{
				return m_intFApp_M39_ID;
			}
			set
			{
				m_intFApp_M39_ID = value;
			}
		}

		public string FApp_M39_Label
		{
			get
			{
				return m_strFApp_M39_Label;
			}
			set
			{
				m_strFApp_M39_Label = value.Trim();
			}
		}

		public int FApp_M40_ID
		{
			get
			{
				return m_intFApp_M40_ID;
			}
			set
			{
				m_intFApp_M40_ID = value;
			}
		}

		public string FApp_M40_Label
		{
			get
			{
				return m_strFApp_M40_Label;
			}
			set
			{
				m_strFApp_M40_Label = value.Trim();
			}
		}

		public int FApp_M41_ID
		{
			get
			{
				return m_intFApp_M41_ID;
			}
			set
			{
				m_intFApp_M41_ID = value;
			}
		}

		public string FApp_M41_Label
		{
			get
			{
				return m_strFApp_M41_Label;
			}
			set
			{
				m_strFApp_M41_Label = value.Trim();
			}
		}

		public int FApp_M42_ID
		{
			get
			{
				return m_intFApp_M42_ID;
			}
			set
			{
				m_intFApp_M42_ID = value;
			}
		}

		public string FApp_M42_Label
		{
			get
			{
				return m_strFApp_M42_Label;
			}
			set
			{
				m_strFApp_M42_Label = value.Trim();
			}
		}

		public int FApp_M43_ID
		{
			get
			{
				return m_intFApp_M43_ID;
			}
			set
			{
				m_intFApp_M43_ID = value;
			}
		}

		public string FApp_M43_Label
		{
			get
			{
				return m_strFApp_M43_Label;
			}
			set
			{
				m_strFApp_M43_Label = value.Trim();
			}
		}

		public int deleted
		{
			get
			{
				return m_intdeleted;
			}
			set
			{
				m_intdeleted = value;
			}
		}

		public DateTime? Created
		{
			get
			{
				return m_dtmCreated;
			}
			set
			{
				m_dtmCreated = value;
			}
		}

		public string Created_By
		{
			get
			{
				return m_strCreated_By;
			}
			set
			{
				m_strCreated_By = value.Trim();
			}
		}

		public string Created_By_Function
		{
			get
			{
				return m_strCreated_By_Function;
			}
			set
			{
				m_strCreated_By_Function = value.Trim();
			}
		}

		public DateTime? Last_Updated
		{
			get
			{
				return m_dtmLast_Updated;
			}
			set
			{
				m_dtmLast_Updated = value;
			}
		}

		public string Last_Updated_By
		{
			get
			{
				return m_strLast_Updated_By;
			}
			set
			{
				m_strLast_Updated_By = value.Trim();
			}
		}

		public string Last_Updated_By_Function
		{
			get
			{
				return m_strLast_Updated_By_Function;
			}
			set
			{
				m_strLast_Updated_By_Function = value.Trim();
			}
		}

		public string Ten_Nhom_PDA
		{
			get
			{
				return m_strTen_Nhom_PDA;
			}
			set
			{
				m_strTen_Nhom_PDA = value.Trim();
			}
		}

		public string FApp_M01_Text
		{
			get
			{
				return Get_Label_ID(FApp_M01_ID);
			}
		}

		public string FApp_M02_Text
		{
			get
			{
				return Get_Label_ID(FApp_M02_ID);
			}
		}

		public string FApp_M03_Text
		{
			get
			{
				return Get_Label_ID(FApp_M03_ID);
			}
		}

		public string FApp_M04_Text
		{
			get
			{
				return Get_Label_ID(FApp_M04_ID);
			}
		}

		public string FApp_M05_Text
		{
			get
			{
				return Get_Label_ID(FApp_M05_ID);
			}
		}

		public string FApp_M06_Text
		{
			get
			{
				return Get_Label_ID(FApp_M06_ID);
			}
		}

		public string FApp_M07_Text
		{
			get
			{
				return Get_Label_ID(FApp_M07_ID);
			}
		}

		public string FApp_M08_Text
		{
			get
			{
				return Get_Label_ID(FApp_M08_ID);
			}
		}

		public string FApp_M09_Text
		{
			get
			{
				return Get_Label_ID(FApp_M09_ID);
			}
		}

		public string FApp_M10_Text
		{
			get
			{
				return Get_Label_ID(FApp_M10_ID);
			}
		}


		public string FApp_M11_Text
		{
			get
			{
				return Get_Label_ID(FApp_M11_ID);
			}
		}

		public string FApp_M12_Text
		{
			get
			{
				return Get_Label_ID(FApp_M12_ID);
			}
		}

		public string FApp_M13_Text
		{
			get
			{
				return Get_Label_ID(FApp_M13_ID);
			}
		}

		public string FApp_M14_Text
		{
			get
			{
				return Get_Label_ID(FApp_M14_ID);
			}
		}

		public string FApp_M15_Text
		{
			get
			{
				return Get_Label_ID(FApp_M15_ID);
			}
		}

		public string FApp_M16_Text
		{
			get
			{
				return Get_Label_ID(FApp_M16_ID);
			}
		}

		public string FApp_M17_Text
		{
			get
			{
				return Get_Label_ID(FApp_M17_ID);
			}
		}

		public string FApp_M18_Text
		{
			get
			{
				return Get_Label_ID(FApp_M18_ID);
			}
		}

		public string FApp_M19_Text
		{
			get
			{
				return Get_Label_ID(FApp_M19_ID);
			}
		}

		public string FApp_M20_Text
		{
			get
			{
				return Get_Label_ID(FApp_M20_ID);
			}
		}


		public string FApp_M21_Text
		{
			get
			{
				return Get_Label_ID(FApp_M21_ID);
			}
		}

		public string FApp_M22_Text
		{
			get
			{
				return Get_Label_ID(FApp_M22_ID);
			}
		}

		public string FApp_M23_Text
		{
			get
			{
				return Get_Label_ID(FApp_M23_ID);
			}
		}

		public string FApp_M24_Text
		{
			get
			{
				return Get_Label_ID(FApp_M24_ID);
			}
		}

		public string FApp_M25_Text
		{
			get
			{
				return Get_Label_ID(FApp_M25_ID);
			}
		}
		public string FApp_M26_Text
		{
			get
			{
				return Get_Label_ID(FApp_M26_ID);
			}
		}
		public string FApp_M27_Text
		{
			get
			{
				return Get_Label_ID(FApp_M27_ID);
			}
		}

		public string FApp_M28_Text
		{
			get
			{
				return Get_Label_ID(FApp_M28_ID);
			}
		}

		public string FApp_M29_Text
		{
			get
			{
				return Get_Label_ID(FApp_M29_ID);
			}
		}

		public string FApp_M30_Text
		{
			get
			{
				return Get_Label_ID(FApp_M30_ID);
			}
		}

		public string FApp_M31_Text
		{
			get
			{
				return Get_Label_ID(FApp_M31_ID);
			}
		}
		public string FApp_M32_Text
		{
			get
			{
				return Get_Label_ID(FApp_M32_ID);
			}
		}
		public string FApp_M33_Text
		{
			get
			{
				return Get_Label_ID(FApp_M33_ID);
			}
		}
		public string FApp_M34_Text
		{
			get
			{
				return Get_Label_ID(FApp_M34_ID);
			}
		}
		public string FApp_M35_Text
		{
			get
			{
				return Get_Label_ID(FApp_M35_ID);
			}
		}
		public string FApp_M36_Text
		{
			get
			{
				return Get_Label_ID(FApp_M36_ID);
			}
		}
		public string FApp_M37_Text
		{
			get
			{
				return Get_Label_ID(FApp_M37_ID);
			}
		}
		public string FApp_M38_Text
		{
			get
			{
				return Get_Label_ID(FApp_M38_ID);
			}
		}
		public string FApp_M39_Text
		{
			get
			{
				return Get_Label_ID(FApp_M39_ID);
			}
		}
		public string FApp_M40_Text
		{
			get
			{
				return Get_Label_ID(FApp_M40_ID);
			}
		}

		public string FApp_M41_Text
		{
			get
			{
				return Get_Label_ID(FApp_M41_ID);
			}
		}

		public string FApp_M42_Text
		{
			get
			{
				return Get_Label_ID(FApp_M42_ID);
			}
		}

		public string FApp_M43_Text
		{
			get
			{
				return Get_Label_ID(FApp_M43_ID);
			}
		}
		private static string Get_Label_ID(int p_iID)
		{
			string v_strRes = "";
			if (p_iID == 0)
				return "";

			switch (p_iID)
			{
                case (int)EPDA_Type_ID.FPDA_1003_Trang_Chu: v_strRes = "Trang Chủ"; break;
            }

			return v_strRes;

		}
			 
	}
}
