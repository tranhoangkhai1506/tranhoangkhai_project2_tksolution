using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
	public enum ETrang_Thai_Thanh_Vien_ID
	{
		Hoat_Dong = 1,
		Khoa = 13
	}

	public enum ETrang_Thai_Import_Excel_ID
	{
		Thanh_Cong = 5,
		Thanh_Cong_1_Phan = 13,
		That_Bai = 1067
	}

	public enum EAPI_Source_Chu_Hang
	{
		Dang_Hoat_Dong = 1,
		Dong = 1067
	}
	
	public enum ETrang_Thai_API_Source
	{
		Hoat_Dong = 1,
		Khong_Co_Trang_Thai = 2,
		Khong_Hoat_Dong = 1067
	}

    public enum ETrang_Thai_Common_ID
    {
        Available = 1,
        Closed = 1067
    }
}
