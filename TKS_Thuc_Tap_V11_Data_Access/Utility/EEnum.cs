using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
    public enum ENhom_Chuc_Nang_ID
    {
        Quan_Tri = 1,
        PDA_App = 4,
        API = 7,
        Supplier_Portal = 8
    }

    public enum EModal_Result
    {
        Close_Cancel = 1,
        Close_And_Reload_Data = 200,
        Close_And_Reload_Data_Bin = 2028_0,
        Close_And_Reload_Data_Dock = 2028_1,
        Close_And_Reload_Data_Storage_Location = 2028_2,
        Exception = 1067
    }

    public enum ELanguage_Type_ID
    {
        General = 1,
        PDA = 2
    }

    public enum EHien_An_Option_ID
    {
        Visible = 2,
        Hide = 1
    }

    public enum EThread_Type_ID
    {
        Lay_Du_Lieu_Tu_API_Source = 1,
        Send_Data_Webhook = 2,
        Chay_Luong_Threath_Job = 3,
        Clear_Table_Temp = 5,
        Auto_Chay_Cac_Rule_Khai_Bao = 6,
        Auto_Xoa_Log_File = 7,
        Auto_Chay_Daily_schedule_Joy = 8
    }

    public enum ESTT_Threath
    {
        Thread_1 = 1,
        Thread_2 = 2,
        Thread_3 = 3,
        Thread_4 = 4,
        Thread_5 = 5,
        Thread_6 = 6,
        Thread_7 = 7,
        Thread_8 = 8,
    }

    public enum EPDA_Type_ID
    {
        FPDA_1001_AutoLogin = 1001,
        FPDA_1002_Login = 1002,
        FPDA_1003_Trang_Chu = 1003,
        FPDA_1004_Tai_Khoan = 1004,
        FPDA_1005_Doi_Mat_Khau = 1005,
        FPDA_1006_Chon_Kho_Lam_Viec = 1006,
        FPDA_1007_Chon_Nhom_PDA = 1007
    }

    public enum EResponse_Status
    {
        OK = 200,
        Exception_Unknown = 201,
        Error = 202,
        Page_Login = 203,
        Continue = 204,
        Not_Exist = 404,
        Tai_Khoan_Hoac_Mat_Khau_Sai = 1001
    }

    public enum EPrototype_ID
    {
        List = 1,
        Add = 2,
        Update = 3,
        Delete = 4,
        Get = 5,
        CheckExits = 6,
        Search = 7
    }

    public enum EType_Cau_Hinh_Nhap_Lieu
    {
        Theo_Ngay = 1,
        Theo_Thang = 2
    }

    public enum EKhach_Hang_ID
    {
        TKS = 2001,
    }

    public enum ECommon_Status_ID
    {
        Available = 1,
        Completed = 5,
        Close = 1067,
        Not_Confirm = 37,
        Confirmed = 38,
        Is_Running = 105,
        Error = 106
    }

    public enum ESTT_Next_Type_ID
    {
        Nhap = 1,
    }
    
    public enum EReport_File_Type_ID
    {
        Export_Excel = 1,
    }

    public enum EGrid_Field_Type_ID
    {
        Data_Column = 1,
        Check_Box = 2,
        HTML = 3,
        Band_Column = 4
    }

    public enum EAPI_Datasource
    {
        TMS = 1
    }

    public enum EDaily_Schedule_Job
    {
        Send_Common_Warning_Email = 1
    }
}