using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Common
{
    public class CPDA_Tham_So
    {
        private long m_intMaster_DO_ID;
        private string m_strSo_Master_DO;
        private long m_intNhap_Kho_ID;
        private long m_intXuat_Kho_ID;
        private long m_intXuat_Kho_Pick_List_ID;
        private long m_intASN_ID;
        private string m_strSo_LPN;
		private string m_strSo_Tote;
		private string m_strSo_Serial;
        private string m_strMa_So_Vi_Tri;
        private string m_strMa_So_Vi_Tri_Dich;
        private string m_strMa_So_Vi_Tri_Nguon;
        private string m_strBarcode_ID;
        private long m_intNhap_Kho_Raw_ID;
        private long m_intLoad_Order_ID;
		private string m_strThong_Bao;
        private int m_intSan_Pham_Type_ID;
        private long m_intKiem_Kho_ID;
		private long m_intSan_Pham_ID;
		private double m_dblSo_Kien_KH;
		private double m_dblSL_Chan_KH;
		private double m_dblSL_Le_KH;
		private double m_dblSo_Kien_Xu_Ly;
        private double m_dblSL_Xu_Ly_Chan;
		private double m_dblSL_Xu_Ly_Le;
        private string m_strSo_Box_Pick;
        private long m_intXuat_Kho_Ship_Task_ID;
        private long m_intKiem_Kho_Chi_Tiet_ID;
        private string m_strLPN_Nguon;
        private string m_strLPN_Dich;
        private long m_intLine_ID;
        private long m_iLoading_Manifest_ID;
        private bool m_blIs_Kiem_Ton_Sau_Pick; //dùng để check xem phiếu xuất có kiểm tồn sau pick không
        private bool m_blIs_Kiem_Ton_Khong_Scan; //option kiểm tồn sau pick bằng cách đếm ngoại quan & xác nhận sl tồn
        private string m_strMa_San_Pham;
        private string m_strTen_San_Pham;
        private string m_strMa_NXD;
        private long m_intTon_Kho_Serial_ID;
        private long m_intTon_Kho_ID;
        private string m_strMa_Man_Hinh;
        private long m_intKho_ID;
        private DateTime? m_dtmNgay_San_Xuat;
        private DateTime? m_dtmNgay_Het_Han;
        private string m_strSo_PO;
        private string m_strSo_Batch;
        private string m_strSo_Lot;
        private double m_dblTi_Le_Hu_Hong;
        
        public long m_intCross_Dock_Store_ID;
        public long m_intCross_Dock_Sorted_ID;
        public long m_intChu_Hang_ID;
        private double m_dblSL_Cai_1_Thung;
        private string m_strSo_Phieu_Xuat;
		private string m_strSo_AWB;
        private string m_strCase_No;
        private long m_lngXK_Raw_ID;

        public CPDA_Tham_So()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_intMaster_DO_ID = CConst.INT_VALUE_NULL;
            m_strSo_Master_DO = CConst.STR_VALUE_NULL;
            m_intNhap_Kho_ID = CConst.FLT_VALUE_NULL;
            m_intXuat_Kho_ID = CConst.INT_VALUE_NULL;
            m_intXuat_Kho_Pick_List_ID = CConst.INT_VALUE_NULL;
            m_intASN_ID = CConst.FLT_VALUE_NULL;
            m_strSo_LPN = CConst.STR_VALUE_NULL;
            m_strSo_Tote = CConst.STR_VALUE_NULL;
			m_strSo_Serial = CConst.STR_VALUE_NULL;
            m_strBarcode_ID = CConst.STR_VALUE_NULL;
            m_intNhap_Kho_Raw_ID = CConst.FLT_VALUE_NULL;
			m_intLoad_Order_ID = CConst.FLT_VALUE_NULL;
			m_strThong_Bao = CConst.STR_VALUE_NULL;
            m_strMa_So_Vi_Tri = CConst.STR_VALUE_NULL;
            m_strMa_So_Vi_Tri_Dich = CConst.STR_VALUE_NULL;
            m_strMa_So_Vi_Tri_Nguon = CConst.STR_VALUE_NULL;
            m_intSan_Pham_Type_ID = CConst.INT_VALUE_NULL;
			m_intSan_Pham_ID = CConst.INT_VALUE_NULL;
			m_intKiem_Kho_ID = CConst.INT_VALUE_NULL;
            m_dblSo_Kien_KH = CConst.FLT_VALUE_NULL;
            m_dblSL_Chan_KH = CConst.FLT_VALUE_NULL;
            m_dblSL_Le_KH = CConst.FLT_VALUE_NULL;
			m_dblSo_Kien_Xu_Ly = CConst.FLT_VALUE_NULL;
            m_dblSL_Xu_Ly_Chan = CConst.FLT_VALUE_NULL;
			m_dblSL_Xu_Ly_Le = CConst.FLT_VALUE_NULL;
            m_strSo_Box_Pick = CConst.STR_VALUE_NULL;
			m_intXuat_Kho_Ship_Task_ID = CConst.INT_VALUE_NULL;
            m_intKiem_Kho_Chi_Tiet_ID = CConst.INT_VALUE_NULL;
            m_strLPN_Nguon = CConst.STR_VALUE_NULL;
            m_strLPN_Dich = CConst.STR_VALUE_NULL;
            m_intLine_ID = CConst.INT_VALUE_NULL;
            m_iLoading_Manifest_ID = CConst.INT_VALUE_NULL;
            m_blIs_Kiem_Ton_Sau_Pick = CConst.BL_VALUE_NULL;
            m_blIs_Kiem_Ton_Khong_Scan = CConst.BL_VALUE_NULL;
            m_strMa_San_Pham = CConst.STR_VALUE_NULL;
            m_strTen_San_Pham = CConst.STR_VALUE_NULL;
            m_strMa_NXD = CConst.STR_VALUE_NULL;
			m_intTon_Kho_Serial_ID = CConst.INT_VALUE_NULL;
			m_intTon_Kho_ID = CConst.INT_VALUE_NULL;
			m_strMa_Man_Hinh = CConst.STR_VALUE_NULL;
            m_intKho_ID = CConst.INT_VALUE_NULL;
            m_dtmNgay_Het_Han = CConst.DTM_VALUE_NULL;
            m_dtmNgay_San_Xuat = CConst.DTM_VALUE_NULL;
            m_strSo_PO = CConst.STR_VALUE_NULL;
            m_strSo_Batch = CConst.STR_VALUE_NULL;
            m_strSo_Lot = CConst.STR_VALUE_NULL;
			m_dblTi_Le_Hu_Hong = CConst.FLT_VALUE_NULL;
			
            m_intCross_Dock_Store_ID = CConst.INT_VALUE_NULL;
            m_intCross_Dock_Sorted_ID = CConst.INT_VALUE_NULL;
            m_intChu_Hang_ID = CConst.INT_VALUE_NULL;
			m_dblSL_Cai_1_Thung = CConst.FLT_VALUE_NULL;
            m_strSo_Phieu_Xuat = CConst.STR_VALUE_NULL;
            m_strSo_AWB = CConst.STR_VALUE_NULL;
            m_strCase_No = CConst.STR_VALUE_NULL;
            m_lngXK_Raw_ID = CConst.INT_VALUE_NULL;
        }


        public long Master_DO_ID
        {
            get
            {
                return m_intMaster_DO_ID;
            }
            set
            {
                m_intMaster_DO_ID = value;
            }
        }

        public string So_Master_DO
        {
            get
            {
                return m_strSo_Master_DO;
            }
            set
            {
                m_strSo_Master_DO = value.Trim();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public long Nhap_Kho_ID
        {
            get
            {
                return m_intNhap_Kho_ID;
            }
            set
            {
                m_intNhap_Kho_ID = value;
            }
        }

        public long Xuat_Kho_ID
        {
            get
            {
                return m_intXuat_Kho_ID;
            }
            set
            {
                m_intXuat_Kho_ID = value;
            }
        }

        public long Xuat_Kho_Pick_List_ID
        {
            get
            {
                return m_intXuat_Kho_Pick_List_ID;
            }
            set
            {
                m_intXuat_Kho_Pick_List_ID = value;
            }
        }

        public long ASN_ID
        {
            get
            {
                return m_intASN_ID;
            }
            set
            {
                m_intASN_ID = value;
            }
        }

        public string So_LPN
        {
            get
            {
                return m_strSo_LPN;
            }
            set
            {
                m_strSo_LPN = value.Trim();
            }
        }

        public string So_Tote
        {
            get
            {
                return m_strSo_Tote;

			}
            set
            {
				m_strSo_Tote = value.Trim();

			}
        }

        public string So_Serial
        {
            get
            {
                return m_strSo_Serial;
            }
            set
            {
                m_strSo_Serial = value.Trim();
            }
        }

        public string Barcode_ID
        {
            get
            {
                return m_strBarcode_ID;
            }
            set
            {
                m_strBarcode_ID = value.Trim();
            }
        }

        public long Nhap_Kho_Raw_ID
        {
            get
            {
                return m_intNhap_Kho_Raw_ID;
            }
            set
            {
                m_intNhap_Kho_Raw_ID = value;
            }
        }

		public long Load_Order_ID
		{
			get
			{
				return m_intLoad_Order_ID;
			}
			set
			{
				m_intLoad_Order_ID = value;
			}
		}
		public string Thong_Bao
        {
            get
            {
                return m_strThong_Bao;
            }
            set
            {
                m_strThong_Bao = value.Trim();
            }
        }

        public string Ma_So_Vi_Tri
        {
            get
            {
                return m_strMa_So_Vi_Tri;
            }
            set
            {
                m_strMa_So_Vi_Tri = value.Trim();
            }
        }

        public string Ma_So_Vi_Tri_Dich
        {
            get
            {
                return m_strMa_So_Vi_Tri_Dich;
            }
            set
            {
                m_strMa_So_Vi_Tri_Dich = value.Trim();
            }

        }

        public string Ma_So_Vi_Tri_Nguon
        {
            get
            {
                return m_strMa_So_Vi_Tri_Nguon;
            }
            set
            {
                m_strMa_So_Vi_Tri_Nguon = value.Trim();
            }

        }

        public int San_Pham_Type_ID
        {
            get
            {
                return m_intSan_Pham_Type_ID;
            }
            set
            {
                m_intSan_Pham_Type_ID = value;
            }
        }
        public long Kiem_Kho_ID
        {
            get
            {
                return m_intKiem_Kho_ID;
            }
            set
            {
                m_intKiem_Kho_ID = value;

			}
        }

		public long San_Pham_ID
		{
			get
			{
				return m_intSan_Pham_ID;
			}
			set
			{
				m_intSan_Pham_ID = value;
			}
		}
		public double So_Kien_Xu_Ly
		{
			get
			{
				return m_dblSo_Kien_Xu_Ly;
			}
			set
			{
				m_dblSo_Kien_Xu_Ly = value;
			}
		}

        public double So_Kien_KH
        {
            get
            {
                return m_dblSo_Kien_KH;
            }
            set
            {
                m_dblSo_Kien_KH = value;
            }
        }

        public double SL_Chan_KH
        {
            get
            {
                return m_dblSL_Chan_KH;
            }
            set
            {
                m_dblSL_Chan_KH = value;
            }
        }

        public double SL_Le_KH
        {
            get
            {
                return m_dblSL_Le_KH;
            }
            set
            {
                m_dblSL_Le_KH = value;
            }
        }

        public double SL_Xu_Ly_Chan
		{
			get
			{
				return m_dblSL_Xu_Ly_Chan;
			}
			set
			{
				m_dblSL_Xu_Ly_Chan = value;
			}
		}

		public double SL_Xu_Ly_Le
		{
			get
			{
				return m_dblSL_Xu_Ly_Le;
			}
			set
			{
				m_dblSL_Xu_Ly_Le = value;
			}
		}
        public string So_Box_Pick
        {
            get
            {
                return m_strSo_Box_Pick;
            }
            set
            {
                m_strSo_Box_Pick = value.Trim() ;
            }
        }

        public long Xuat_Kho_Ship_Task_ID
        {
            get
            {
                return m_intXuat_Kho_Ship_Task_ID;
			}
            set
            {
                m_intXuat_Kho_Ship_Task_ID = value;
			}
        }

        public long Kiem_Kho_Chi_Tiet_ID
        {
            get
            {
                return m_intKiem_Kho_Chi_Tiet_ID;
            }
            set
            {
                m_intKiem_Kho_Chi_Tiet_ID = value;

            }
        }

        public string LPN_Nguon
        {
            get
            {
                return m_strLPN_Nguon;
            }
            set
            {
                m_strLPN_Nguon = value.Trim();
            }
        }

        public string LPN_Dich
        {
            get
            {
                return m_strLPN_Dich;
            }
            set
            {
                m_strLPN_Dich = value.Trim();
            }
        }

        public long Line_ID
        {
			get
			{
				return m_intLine_ID;
			}
			set
			{
				m_intLine_ID = value;
			}
		}
        public long Loading_Manifest_ID
        {
            get
            {
                return m_iLoading_Manifest_ID;
            }
            set
            {
                m_iLoading_Manifest_ID = value;
            }
        }

        public bool Is_Kiem_Ton_Sau_Pick
        {
            get
            {
                return m_blIs_Kiem_Ton_Sau_Pick;
            }
            set
            {
                m_blIs_Kiem_Ton_Sau_Pick = value;
            }
        }

        public bool Is_Kiem_Ton_Khong_Scan
        {
            get
            {
                return m_blIs_Kiem_Ton_Khong_Scan;
            }
            set
            {
                m_blIs_Kiem_Ton_Khong_Scan = value;
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

        public string Ma_NXD
        {
            get
            {
                return m_strMa_NXD;
            }
            set
            {
                m_strMa_NXD = value.Trim();
            }
        }

        public long Ton_Kho_Serial_ID
        {
			get
			{
				return m_intTon_Kho_Serial_ID;
			}
			set
			{
				m_intTon_Kho_Serial_ID = value;
			}
		}

		public long Ton_Kho_ID
		{
			get
			{
				return m_intTon_Kho_ID;
			}
			set
			{
				m_intTon_Kho_ID = value;
			}
		}

        public string Ma_Man_Hinh
        {
			get
			{
				return m_strMa_Man_Hinh;
			}
			set
			{
				m_strMa_Man_Hinh = value;
			}
		}

        public long Kho_ID
        {
            get
            {
                return m_intKho_ID;
            }
            set
            {
                m_intKho_ID = value;
            }
        }

        public DateTime? Ngay_San_Xuat
        {
            get
            {
                return m_dtmNgay_San_Xuat;
            }
            set
            {
                m_dtmNgay_San_Xuat = value;
            }
        }

        public DateTime? Ngay_Het_Han
        {
            get
            {
                return m_dtmNgay_Het_Han;
            }
            set
            {
                m_dtmNgay_Het_Han = value;
            }
        }

        public string So_PO
        {
            get
            {
                return m_strSo_PO;
            }
            set
            {
                m_strSo_PO = value.Trim();
            }
        }

        public string So_Batch
        {
            get
            {
                return m_strSo_Batch;
            }
            set
            {
                m_strSo_Batch = value.Trim();
            }
        }

        public string So_Lot
        {
            get
            {
                return m_strSo_Lot;
            }
            set
            {
                m_strSo_Lot = value.Trim();
            }
        }
        public double Ti_Le_Hu_Hong
        {
            get
            {
                return m_dblTi_Le_Hu_Hong;
			}
            set
            {
                m_dblTi_Le_Hu_Hong = value;
			}
        }
        
        public long Cross_Dock_Store_ID
        {
            get
            {
                return m_intCross_Dock_Store_ID;
			}
            set
            {
                m_intCross_Dock_Store_ID = value;

			}
        }
        public long Cross_Dock_Sorted_ID
        {
            get
            {
                return m_intCross_Dock_Sorted_ID;
            }
            set
            {
                m_intCross_Dock_Sorted_ID = value;

            }
        }
        public long Chu_Hang_ID
		{
			get
			{
				return m_intChu_Hang_ID;
			}
			set
			{
				m_intChu_Hang_ID = value;

			}
		}

		public double SL_Cai_1_Thung
		{
			get
			{
				return m_dblSL_Cai_1_Thung;
			}
			set
			{
				m_dblSL_Cai_1_Thung = value;

			}
        }

        public string So_Phieu_Xuat
        {
            get
            {
                return m_strSo_Phieu_Xuat;
            }
            set
            {
                m_strSo_Phieu_Xuat = value.Trim();
            }
        }

		public string So_AWB
		{
			get
			{
				return m_strSo_AWB;
			}
			set
			{
				m_strSo_AWB = value.Trim();
			}
        }

        public string Case_No
        {
            get
            {
                return m_strCase_No;
            }
            set
            {
                m_strCase_No = value.Trim();
            }
        }

        public long XK_Raw_ID
        {
            get
            {
                return m_lngXK_Raw_ID;
            }
            set
            {
                m_lngXK_Raw_ID = value;
            }
        }
    }
}
