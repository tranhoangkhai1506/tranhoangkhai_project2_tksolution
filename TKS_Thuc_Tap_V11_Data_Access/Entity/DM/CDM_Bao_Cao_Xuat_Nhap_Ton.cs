using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.DM
{
	public class CDM_Bao_Cao_Xuat_Nhap_Ton
	{
		private string m_strMa_San_Pham;
		private string m_strTen_San_Pham;
		private double m_dblSL_Dau_Ky;
		private double m_dblSL_Nhap;
		private double m_dblSL_Xuat;
		private double m_dblSL_Cuoi_Ky;

		public CDM_Bao_Cao_Xuat_Nhap_Ton()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_strMa_San_Pham = CConst.STR_VALUE_NULL;
			m_strTen_San_Pham = CConst.STR_VALUE_NULL;
			m_dblSL_Dau_Ky = CConst.FLT_VALUE_NULL;
			m_dblSL_Nhap = CConst.FLT_VALUE_NULL;
			m_dblSL_Xuat = CConst.FLT_VALUE_NULL;
			m_dblSL_Cuoi_Ky = CConst.FLT_VALUE_NULL;
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
		public double SL_Dau_Ky
		{
			get
			{
				return m_dblSL_Dau_Ky;
			}
			set
			{
				m_dblSL_Dau_Ky = value;
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

		public double SL_Cuoi_Ky
		{
			get
			{
				return m_dblSL_Cuoi_Ky;
			}
			set
			{
				m_dblSL_Cuoi_Ky = value;
			}
		}
	}
}
