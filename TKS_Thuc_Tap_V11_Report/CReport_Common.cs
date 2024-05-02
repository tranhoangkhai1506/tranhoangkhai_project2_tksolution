using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Common;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Report
{
    [DataObject]
    public class CReport_Common
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public CThong_Tin_Cong_Ty rptReport_Header()
        {
            CThong_Tin_Cong_Ty v_objRes = new();
            v_objRes.Company_Name = CConfig.Company_Name;
            v_objRes.Company_Address = CConfig.Company_Address;
            v_objRes.Company_Email = CConfig.Company_Email;
            v_objRes.Company_Fax = CConfig.Company_Fax;
            v_objRes.Company_Ten_Ngan_Hang = CConfig.Company_Ten_Ngan_Hang;
            v_objRes.Company_So_Tai_Khoan = CConfig.Company_So_Tai_Khoan;

            v_objRes.Company_Tel = CConfig.Company_Tel;
            v_objRes.Report_Logo_Url = CConfig.Report_Logo_Url;

            return v_objRes;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public CThong_Tin_Cong_Ty rptReport_Header_TC(long p_intChu_hang_ID)
        {
            CDM_Chu_Hang v_obj_CH = CCache_Chu_Hang.Get_Data_By_ID(p_intChu_hang_ID);
            CThong_Tin_Cong_Ty v_objRes = new();
            if (v_obj_CH.Image_URL == "")
            {
                v_objRes.Company_Name = CConfig.Company_Name;
                v_objRes.Company_Address = CConfig.Company_Address;
                v_objRes.Company_Email = CConfig.Company_Email;
                v_objRes.Company_Fax = CConfig.Company_Fax;
                v_objRes.Company_Ten_Ngan_Hang = CConfig.Company_Ten_Ngan_Hang;
                v_objRes.Company_So_Tai_Khoan = CConfig.Company_So_Tai_Khoan;

                v_objRes.Company_Tel = CConfig.Company_Tel;
                v_objRes.Report_Logo_Url = CConfig.Report_Logo_Url;
            }
            else
            {
                v_objRes.Company_Name = v_obj_CH.Ten_Chu_Hang;
                v_objRes.Company_Address = v_obj_CH.Dia_Chi;
                v_objRes.Company_Email = v_obj_CH.Email;
                v_objRes.Company_Fax = "";
                v_objRes.Company_Ten_Ngan_Hang = "";
                v_objRes.Company_So_Tai_Khoan = "";

                v_objRes.Company_Tel = v_obj_CH.Dien_Thoai;
                v_objRes.Report_Logo_Url = "../" + "wwwroot/" + v_obj_CH.Image_URL;
            }
            

            return v_objRes;
        }
    }

   
}
