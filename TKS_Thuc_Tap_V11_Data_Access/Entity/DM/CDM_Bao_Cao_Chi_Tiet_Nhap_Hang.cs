using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.DM
{
	public class CDM_Bao_Cao_Chi_Tiet_Nhap_Hang
	{
		private string m_strSo_Phieu_Nhap_Kho;
		private long m_lngNCC_ID;
		private DateTime? m_dtmNgay_Nhap_Kho;
		private string m_strMa_San_Pham;
		private string m_strTen_San_Pham;
		private double m_dblSL_Nhap;
		private double m_dblDon_Gia_Nhap;
		private double m_dblTri_Gia;

		public CDM_Bao_Cao_Chi_Tiet_Nhap_Hang()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_strSo_Phieu_Nhap_Kho = CConst.STR_VALUE_NULL;
			m_lngNCC_ID = CConst.INT_VALUE_NULL;
			m_dtmNgay_Nhap_Kho = CConst.DTM_VALUE_NULL;
			m_strMa_San_Pham = CConst.STR_VALUE_NULL;
			m_strTen_San_Pham = CConst.STR_VALUE_NULL;
			m_dblSL_Nhap = CConst.FLT_VALUE_NULL;
			m_dblDon_Gia_Nhap = CConst.FLT_VALUE_NULL;
			m_dblTri_Gia = CConst.FLT_VALUE_NULL;
		}

		public string So_Phieu_Nhap_Kho
		{
			get
			{
				return m_strSo_Phieu_Nhap_Kho;
			}
			set
			{
				m_strSo_Phieu_Nhap_Kho = value.Trim();
			}
		}
		public long NCC_ID
		{
			get
			{
				return m_lngNCC_ID;
			}
			set
			{
				m_lngNCC_ID = value;
			}
		}
		public string Nha_Cung_Cap
		{
			get
			{
				var result = NCC_ID != 0 ? CCache_NCC.Get_Data_By_ID(NCC_ID).Ten_NCC : "UNKNONW";
				return result;
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
				m_strTen_San_Pham = value.Trim();
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
