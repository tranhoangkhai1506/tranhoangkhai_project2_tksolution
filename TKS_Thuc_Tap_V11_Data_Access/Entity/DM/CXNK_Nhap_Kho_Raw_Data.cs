using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Controller.DM;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.DM
{
	public class CXNK_Nhap_Kho_Raw_Data
	{
		private long m_lngAuto_ID;
		private long m_lngNhap_Kho_ID;
		private long m_lngSan_Pham_ID;
		private double m_dblSL_Nhap;
		private double m_dblDon_Gia_Nhap;
		private double m_dblTri_Gia;
		private string m_strTen_NCC;
		private DateTime? m_dtmNgay_Nhap_Kho;
		private string m_strMa_San_Pham;
		private string m_strSo_Phieu_Nhap_Kho;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;
		private string m_strTen_San_Pham;
		public CXNK_Nhap_Kho_Raw_Data()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_lngNhap_Kho_ID = CConst.INT_VALUE_NULL;
			m_lngSan_Pham_ID = CConst.INT_VALUE_NULL;
			m_dblSL_Nhap = CConst.FLT_VALUE_NULL;
			m_dblDon_Gia_Nhap = CConst.FLT_VALUE_NULL;
			m_dblTri_Gia = CConst.FLT_VALUE_NULL;
			m_strTen_NCC = CConst.STR_VALUE_NULL;
			m_strMa_San_Pham = CConst.STR_VALUE_NULL;
			m_strSo_Phieu_Nhap_Kho = CConst.STR_VALUE_NULL;
			m_dtmNgay_Nhap_Kho = CConst.DTM_VALUE_NULL;
			m_intdeleted = CConst.INT_VALUE_NULL;
			m_dtmCreated = CConst.DTM_VALUE_NULL;
			m_strCreated_By = CConst.STR_VALUE_NULL;
			m_strCreated_By_Function = CConst.STR_VALUE_NULL;
			m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
			m_strLast_Updated_By = CConst.STR_VALUE_NULL;
			m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
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

		public long Nhap_Kho_ID
		{
			get
			{
				return m_lngNhap_Kho_ID;
			}
			set
			{
				m_lngNhap_Kho_ID = value;
			}
		}

		public string So_Phieu_Nhap_Kho
		{
			get
			{
				return m_strSo_Phieu_Nhap_Kho;
			}
			set
			{
				m_strSo_Phieu_Nhap_Kho = value;
			}
		}

		public long San_Pham_ID
		{
			get
			{
				return m_lngSan_Pham_ID;
			}
			set
			{
				m_lngSan_Pham_ID = value;
			}
		}

		public string Ma_San_Pham
		{
			get
			{
				return m_strMa_San_Pham;
			}
			set
			{
				m_strMa_San_Pham = value.Trim();
			}
		}

		public string Ten_San_Pham
		{
			get
			{
				return m_strTen_San_Pham;
			}
			set
			{
				m_strTen_San_Pham = value;
			}
		}


		public DateTime? Ngay_Nhap_Kho
		{
			get
			{
				return m_dtmNgay_Nhap_Kho;
			}
			set
			{
				m_dtmNgay_Nhap_Kho = value;
			}
		}

		public double SL_Nhap
		{
			get
			{
				return m_dblSL_Nhap;
			}
			set
			{
				m_dblSL_Nhap = value;
			}
		}

		public string Ten_NCC
		{
			get
			{
				return m_strTen_NCC;
			}
			set
			{
				m_strTen_NCC = value.Trim();
			}
		}

		public double Don_Gia_Nhap
		{
			get
			{
				return m_dblDon_Gia_Nhap;
			}
			set
			{
				m_dblDon_Gia_Nhap = value;
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

		public double Tri_Gia
		{
			get
			{
				return SL_Nhap * Don_Gia_Nhap;
			}
			set
			{
				m_dblTri_Gia = value;
			}
		}
	}
}
