using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
	public class CSys_Thanh_Vien
	{
		private long m_lngAuto_ID;
		private string m_strMa_Dang_Nhap;
		private string m_strMat_Khau;
		private string m_strHo_Ten;
		private string m_strEmail;
		private string m_strDien_Thoai;
		private string m_strHinh_Dai_Dien_URL;
		private int m_intTrang_Thai_ID;
		private string m_strTen_Nhom_Thanh_Vien_Text;
		private string m_strGhi_Chu;
		private int m_intdeleted;
		private DateTime? m_dtmCreated;
		private string m_strCreated_By;
		private string m_strCreated_By_Function;
		private DateTime? m_dtmLast_Updated;
		private string m_strLast_Updated_By;
		private string m_strLast_Updated_By_Function;

		private string m_strMat_Khau_Moi;  // 
		private string m_strMat_Khau_Moi_Nhap_Lai;  // 
		
		private string m_strUser_Name;
		private string m_strPassword;
		public CSys_Thanh_Vien()
		{
			ResetData();
		}

		public void ResetData()
		{
			m_lngAuto_ID = CConst.INT_VALUE_NULL;
			m_strMa_Dang_Nhap = CConst.STR_VALUE_NULL;
			m_strMat_Khau = CConst.STR_VALUE_NULL;
			m_strHo_Ten = CConst.STR_VALUE_NULL;
			m_strEmail = CConst.STR_VALUE_NULL;
			m_strDien_Thoai = CConst.STR_VALUE_NULL;
			m_strHinh_Dai_Dien_URL = CConst.STR_VALUE_NULL;
			m_intTrang_Thai_ID = CConst.INT_VALUE_NULL;
			m_strTen_Nhom_Thanh_Vien_Text = CConst.STR_VALUE_NULL;
			m_strGhi_Chu = CConst.STR_VALUE_NULL;
			m_intdeleted = CConst.INT_VALUE_NULL;
			m_dtmCreated = CConst.DTM_VALUE_NULL;
			m_strCreated_By = CConst.STR_VALUE_NULL;
			m_strCreated_By_Function = CConst.STR_VALUE_NULL;
			m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
			m_strLast_Updated_By = CConst.STR_VALUE_NULL;
			m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;

			m_strMat_Khau_Moi = CConst.STR_VALUE_NULL;
			m_strMat_Khau_Moi_Nhap_Lai = CConst.STR_VALUE_NULL;

			m_strUser_Name = CConst.STR_VALUE_NULL;
			m_strPassword = CConst.STR_VALUE_NULL;
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

		public string Ma_Dang_Nhap
		{
			get
			{
				return m_strMa_Dang_Nhap;
			}
			set
			{
				m_strMa_Dang_Nhap = value.Trim();
			}
		}

		public string Mat_Khau
		{
			get
			{
				return m_strMat_Khau;
			}
			set
			{
				m_strMat_Khau = value.Trim();
			}
		}

		public string Ho_Ten
		{
			get
			{
				return m_strHo_Ten;
			}
			set
			{
				m_strHo_Ten = value.Trim();
			}
		}

		public string Email
		{
			get
			{
				return m_strEmail;
			}
			set
			{
				m_strEmail = value.Trim();
			}
		}

		public string Dien_Thoai
		{
			get
			{
				return m_strDien_Thoai;
			}
			set
			{
				m_strDien_Thoai = value.Trim();
			}
		}

		public string Hinh_Dai_Dien_URL
		{
			get
			{
				return m_strHinh_Dai_Dien_URL;
			}
			set
			{
				m_strHinh_Dai_Dien_URL = value.Trim();
			}
		}

		public int Trang_Thai_ID
		{
			get
			{
				return m_intTrang_Thai_ID;
			}
			set
			{
				m_intTrang_Thai_ID = value;
			}
		}

		public string Ten_Nhom_Thanh_Vien_Text
		{
			get
			{
				return m_strTen_Nhom_Thanh_Vien_Text;
			}
			set
			{
				m_strTen_Nhom_Thanh_Vien_Text = value.Trim();
			}
		}

		public string Ghi_Chu
		{
			get
			{
				return m_strGhi_Chu;
			}
			set
			{
				m_strGhi_Chu = value.Trim();
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

		public string Trang_Thai_HTML
		{
			get
			{
				string v_strRes = "";

				switch (Trang_Thai_ID)
				{
					case (int)ETrang_Thai_Thanh_Vien_ID.Hoat_Dong: v_strRes = "<span class=\"badge bg-success\">Hoạt động</span>"; break;
					case (int)ETrang_Thai_Thanh_Vien_ID.Khoa: v_strRes = "<span class=\"badge bg-danger\">Khóa</span>"; break;
				}

				return v_strRes;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string Mat_Khau_Moi
		{
			get { return m_strMat_Khau_Moi; }
			set
			{
				m_strMat_Khau_Moi = value.Trim();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public string Mat_Khau_Moi_Nhap_Lai
		{
			get { return m_strMat_Khau_Moi_Nhap_Lai; }
			set
			{
				m_strMat_Khau_Moi_Nhap_Lai = value.Trim();
			}
		}

		public string User_Name
		{
			get { return m_strUser_Name; }
			set
			{
				m_strUser_Name = value.Trim();
			}
		}

		public string Password
		{
			get { return m_strPassword; }
			set
			{
				m_strPassword = value.Trim();
			}
		}

		public string Ma_Dang_Nhap_Combo
		{
			get
			{
				return CUtility.Tao_Combo_Text(Ma_Dang_Nhap, Ho_Ten);
			}
		}
	}
}
