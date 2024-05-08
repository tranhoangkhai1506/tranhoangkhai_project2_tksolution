using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.DM
{
	public class CDM_Bao_Cao_Chi_Tiet_Xuat_Hang
	{
		private string m_strSo_Phieu_Xuat_Kho;
		private DateTime? m_dtmNgay_Xuat_Kho;
		private string m_strMa_San_Pham;
		private string m_strTen_San_Pham;
		private double m_dblSL_Xuat;
		private double m_dblDon_Gia_Xuat;
		private double m_dblTri_Gia;

		public CDM_Bao_Cao_Chi_Tiet_Xuat_Hang()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_strSo_Phieu_Xuat_Kho = CConst.STR_VALUE_NULL;
			m_dtmNgay_Xuat_Kho = CConst.DTM_VALUE_NULL;
			m_strMa_San_Pham = CConst.STR_VALUE_NULL;
			m_strTen_San_Pham = CConst.STR_VALUE_NULL;
			m_dblSL_Xuat = CConst.FLT_VALUE_NULL;
			m_dblDon_Gia_Xuat = CConst.FLT_VALUE_NULL;
			m_dblTri_Gia = CConst.FLT_VALUE_NULL;
		}

		public string So_Phieu_Xuat_Kho
		{
			get
			{
				return m_strSo_Phieu_Xuat_Kho;
			}
			set
			{
				m_strSo_Phieu_Xuat_Kho = value.Trim();
			}
		}
		public DateTime? Ngay_Xuat_Kho
		{
			get
			{
				return m_dtmNgay_Xuat_Kho;
			}
			set
			{
				m_dtmNgay_Xuat_Kho = value;
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

		public double SL_Xuat
		{
			get
			{
				return m_dblSL_Xuat;
			}
			set
			{
				m_dblSL_Xuat = value;
			}
		}

		public double Don_Gia_Xuat
		{
			get
			{
				return m_dblDon_Gia_Xuat;
			}
			set
			{
				m_dblDon_Gia_Xuat = value;
			}
		}

		public double Tri_Gia
		{
			get
			{
				return SL_Xuat * Don_Gia_Xuat;
			}
			set
			{
				m_dblTri_Gia = value;
			}
		}
	}
}
