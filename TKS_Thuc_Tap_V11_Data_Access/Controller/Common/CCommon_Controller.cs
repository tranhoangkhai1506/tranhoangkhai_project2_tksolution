using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Sys;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Log;
using TKS_Thuc_Tap_V11_Data_Access.Entity.Log;
using TKS_Thuc_Tap_V11_Data_Access.DataLayer;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;
using TKS_Thuc_Tap_V11_Data_Access.Utility;
using Microsoft.Data.SqlClient;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using System.Net;
using System.Data;

namespace TKS_Thuc_Tap_V11_Data_Access.Controller.Common
{
    public class CCommon_Controller
    {
        public static void FCommon_Insert_Action_History(long p_iRef_ID, string p_strHanh_Dong, string p_strMoi_Truong, string p_strCreated_By,
            string p_strChuc_Nang, string p_strTen_Chuc_Nang, string p_strNoi_Dung_Action)
        {
            CLog_Record_Action_History_Controller v_objCtrAH = new CLog_Record_Action_History_Controller();

            try
            {
                CLog_Record_Action_History v_objAH = new CLog_Record_Action_History()
                {
                    Ref_ID = p_iRef_ID,
                    Ten_Hanh_Dong = p_strHanh_Dong,
                    Ten_Moi_Truong = p_strMoi_Truong,
                    Ma_Chuc_Nang = p_strChuc_Nang,
                    Ten_Chuc_Nang = p_strTen_Chuc_Nang,
                    Noi_Dung_Action = p_strNoi_Dung_Action,
                    Created_By = p_strCreated_By
                };

                v_objCtrAH.FQ_425_RAH_sp_ins_Insert(v_objAH);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public static void FCommon_Insert_Action_History(SqlConnection p_Conn, SqlTransaction p_Tran, long p_iRef_ID, string p_strHanh_Dong, string p_strMoi_Truong, string p_strCreated_By,
            string p_strChuc_Nang, string p_strTen_Chuc_Nang, string p_strNoi_Dung_Action)
        {
            CLog_Record_Action_History_Controller v_objCtrAH = new CLog_Record_Action_History_Controller();

            try
            {
                CLog_Record_Action_History v_objAH = new CLog_Record_Action_History()
                {
                    Ref_ID = p_iRef_ID,
                    Ten_Hanh_Dong = p_strHanh_Dong,
                    Ten_Moi_Truong = p_strMoi_Truong,
                    Ma_Chuc_Nang = p_strChuc_Nang,
                    Ten_Chuc_Nang = p_strTen_Chuc_Nang,
                    Noi_Dung_Action = p_strNoi_Dung_Action,
                    Created_By = p_strCreated_By
                };

                v_objCtrAH.FQ_425_RAH_sp_ins_Insert(p_Conn, p_Tran, v_objAH);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public static void FCommon_Insert_Log(string p_strKey_No, string p_strAPI_Source_Name, string p_strFunction_Name, string p_strDescription,
            string p_strLog_Detail, int p_iTrang_Thai_ID, string p_strLast_Updated_By)
        {
            CLog_API_Controller v_objCtrAPI_Log = new();

            //string v_strFile_Name = p_strKey_No + "_" + p_strFunction_Name.Replace(" ", "_") + ".txt";
            string v_strFile_Name = p_strKey_No.Replace("\\", "_").Replace("/", "_").Replace("|", "_") + "_" + p_strFunction_Name.Replace(" ", "_") + ".txt";

            string v_strLink_URL = CConfig.API_Log_Virtual_URL + DateTime.Now.ToString("yyyyMMdd") + "/" + v_strFile_Name;

            CLog_API v_objAPI_Log = new()
            {
                API_Function_Name = p_strFunction_Name,
                API_Source_Name = p_strAPI_Source_Name,
                Description = p_strDescription,
                Key_No = p_strKey_No,
                Last_Updated = DateTime.Now,
                Last_Updated_By = p_strLast_Updated_By,
                Last_Updated_By_Function = p_strFunction_Name,
                Trang_Thai_ID = p_iTrang_Thai_ID,
                Link_URL = v_strLink_URL
            };

            // Lưu file log
            string v_strDir_Path = CConfig.API_Log_Physical_URL + DateTime.Now.ToString("yyyyMMdd");
            if (Directory.Exists(v_strDir_Path) == false)
                Directory.CreateDirectory(v_strDir_Path);

            string v_strFile_Path = v_strDir_Path + "\\" + v_strFile_Name;
            File.WriteAllText(v_strFile_Path, p_strLog_Detail);

            //nếu là update thì lấy Auto_ID = 0 từ DB
            long v_iLog_ID = v_objCtrAPI_Log.FCommon_Insert_Log_API(v_objAPI_Log);
            if (v_iLog_ID == 0)
            {
                CLog_API v_objEXits = CCache_Log_API.Get_Data_By_Key(v_objAPI_Log.Key_All);
                if (v_objEXits != null)
                {
                    v_objAPI_Log.Auto_ID = v_objEXits.Auto_ID;
                    CCache_Log_API.Update_Data(v_objAPI_Log);
                }
            }
            if (v_iLog_ID > 0)
            {
                v_objAPI_Log.Auto_ID = v_iLog_ID;
                CCache_Log_API.Add_Data(v_objAPI_Log);
            }
        }

        private static string Replace_Quy_Tac_Phieu(long p_iChu_Hang_ID, string p_strQuy_Tac_Phieu, int p_iSTT, DateTime? p_dtmNgay_Giao_Dich, int p_intDigits)
        {

            string v_strRes = p_strQuy_Tac_Phieu;

            v_strRes = v_strRes.Replace("[ddMMyyyy]", CUtility.Get_Date_Text(p_dtmNgay_Giao_Dich, "ddMMyyyy"));
            v_strRes = v_strRes.Replace("[MMddyyyy]", CUtility.Get_Date_Text(p_dtmNgay_Giao_Dich, "MMddyyyy"));
            v_strRes = v_strRes.Replace("[MMyy]", CUtility.Get_Date_Text(p_dtmNgay_Giao_Dich, "MMyy"));
            v_strRes = v_strRes.Replace("[yyMM]", CUtility.Get_Date_Text(p_dtmNgay_Giao_Dich, "yyMM"));
            v_strRes = v_strRes.Replace("[ddMMyy]", CUtility.Get_Date_Text(p_dtmNgay_Giao_Dich, "ddMMyy"));
            v_strRes = v_strRes.Replace("[yy]", CUtility.Get_Date_Text(p_dtmNgay_Giao_Dich, "yy"));
			v_strRes = v_strRes.Replace("[yyMMdd]", CUtility.Get_Date_Text(p_dtmNgay_Giao_Dich, "yyMMdd"));
			v_strRes = v_strRes.Replace("[MMyyyy]", CUtility.Get_Date_Text(p_dtmNgay_Giao_Dich, "MMyyyy"));
			v_strRes = v_strRes.Replace("[yyyyMM]", CUtility.Get_Date_Text(p_dtmNgay_Giao_Dich, "yyyyMM"));

			//Có thể tùy chỉnh thêm quy tắc nếu muốn 
			v_strRes = v_strRes.ToUpper();

            #region Cấu hình chủ hàng
            CDM_Chu_Hang v_objChu_Hang = CCache_Chu_Hang.Get_Data_By_ID(p_iChu_Hang_ID);

            if (v_strRes.Contains("[MA_CHU_HANG]"))
            {
                if (v_objChu_Hang != null)
                    v_strRes = v_strRes.Replace("[MA_CHU_HANG]", v_objChu_Hang.Ma_Chu_Hang);
                else
                    v_strRes = v_strRes.Replace("[MA_CHU_HANG]", "");
            }

            if (v_strRes.Contains("[TEN_VIET_TAT]"))
            {
                if (v_objChu_Hang != null)
                    v_strRes = v_strRes.Replace("[TEN_VIET_TAT]", v_objChu_Hang.Ten_Viet_Tat);
                else
                    v_strRes = v_strRes.Replace("[TEN_VIET_TAT]", "");
            }

            if (v_strRes.Contains("[TEN_CHU_HANG]"))
            {
                if (v_objChu_Hang != null)
                    v_strRes = v_strRes.Replace("[TEN_CHU_HANG]", v_objChu_Hang.Ten_Chu_Hang);
                else
                    v_strRes = v_strRes.Replace("[TEN_CHU_HANG]", "");
            }

            v_objChu_Hang = null;
            #endregion

            //trong trường hợp KH muốn đặt STT ở đâu thì replace còn không thì mặc định thêm vào cuối để tạo không bị trùng
            if (v_strRes.Contains("[STT]"))
                v_strRes = v_strRes.Replace("[STT]", p_iSTT.ToString("d" + p_intDigits));
            else
                v_strRes += "-" + p_iSTT.ToString("d" + p_intDigits);


            return v_strRes.ToUpper();
        }

        private static string Tao_Quy_Tac_Phieu_Mac_Dinh(int p_iType_ID)
        {
            string v_strRes = "";

            switch (p_iType_ID)
            {
                case (int)ESTT_Next_Type_ID.Nhap: v_strRes = "N"; break;
                
                default: v_strRes = "DOC"; break;
            }

            v_strRes += "-[ddMMyy]-[STT]";

            return v_strRes;
        }

        public static string Tao_So_Phieu_Tu_Quy_Tac_Phieu(SqlConnection p_conn, SqlTransaction p_trans, long p_iChu_Hang_ID, int p_iType_ID, DateTime? p_dtmNgay_Giao_Dich, string p_strLast_Updated_By, string p_strLast_Updated_By_Function)
        {
            CSys_STT_Next_Detail_Controller v_objCtrlSTT_Next_Detail = new();

            if (p_dtmNgay_Giao_Dich == null)
                p_dtmNgay_Giao_Dich = DateTime.Now;

            string v_strRes = "";
            CSys_STT_Next v_objSTT_Next = CCache_STT_Next.Get_Data_By_Code(p_iChu_Hang_ID, p_iType_ID);

            if (v_objSTT_Next == null)
            {

                CSys_STT_Next_Controller v_objCtrlSST_Next = new();
                v_objSTT_Next = new();

                v_objSTT_Next.Chu_Hang_ID = p_iChu_Hang_ID;
                v_objSTT_Next.Type_ID = p_iType_ID;
                v_objSTT_Next.Last_Updated_By = p_strLast_Updated_By;
                v_objSTT_Next.Last_Updated_By_Function = p_strLast_Updated_By_Function;

                v_objSTT_Next.Quy_Tac_Phieu = Tao_Quy_Tac_Phieu_Mac_Dinh(p_iType_ID);

                v_objSTT_Next.Auto_ID = v_objCtrlSST_Next.FQ_529_SN_sp_ins_Insert(p_conn, p_trans, v_objSTT_Next);

                CCache_STT_Next.Add_Data(v_objSTT_Next);
            }

            CSys_STT_Next_Detail v_objSTT_Next_Detail = CCache_STT_Next_Detail.Get_Data_By_Code(v_objSTT_Next.Auto_ID, 
                v_objSTT_Next.Quy_Tac_Phieu, v_objSTT_Next.Type_ID);

            if (v_objSTT_Next_Detail == null)
            {
                v_objSTT_Next_Detail = new();
                v_objSTT_Next_Detail.STT_ID = v_objSTT_Next.Auto_ID;
                v_objSTT_Next_Detail.Ngay_Giao_Dich = p_dtmNgay_Giao_Dich;
                v_objSTT_Next_Detail.STT_Current = 1;
                v_objSTT_Next_Detail.Last_Updated_By = p_strLast_Updated_By;
                v_objSTT_Next_Detail.Last_Updated_By_Function = p_strLast_Updated_By_Function;

                v_objSTT_Next_Detail.Auto_ID = v_objCtrlSTT_Next_Detail.FQ_530_SND_sp_ins_Insert(p_conn, p_trans, v_objSTT_Next_Detail);
                v_objSTT_Next_Detail = v_objCtrlSTT_Next_Detail.FQ_530_SND_sp_sel_Get_By_ID(p_conn, p_trans, v_objSTT_Next_Detail.Auto_ID);


                CCache_STT_Next_Detail.Add_Data(v_objSTT_Next_Detail);
            }
            else
            {
                //dựa vào qui tắc số phiếu để reset STT về 1 và update ngay giao dich
                Reset_STT_Next(v_objSTT_Next_Detail);

                v_objSTT_Next_Detail.STT_Current += 1;
                // v_objSTT_Next_Detail.Ngay_Giao_Dich = p_dtmNgay_Giao_Dich;
                v_objSTT_Next_Detail.Last_Updated_By = p_strLast_Updated_By;
                v_objSTT_Next_Detail.Last_Updated_By_Function = p_strLast_Updated_By_Function;

                v_objCtrlSTT_Next_Detail.FQ_530_SND_sp_upd_Update(p_conn, p_trans, v_objSTT_Next_Detail);
                CCache_STT_Next_Detail.Update_Data(v_objSTT_Next_Detail);
            }

            string v_strQuy_Tac_Phieu = v_objSTT_Next.Quy_Tac_Phieu;

            v_strRes = Replace_Quy_Tac_Phieu(p_iChu_Hang_ID, v_strQuy_Tac_Phieu, 
                v_objSTT_Next_Detail.STT_Current, p_dtmNgay_Giao_Dich, v_objSTT_Next.Digits);

            return v_strRes;
        }

        private static void Reset_STT_Next(CSys_STT_Next_Detail p_objData)
        {
            //reset STT theo ngày
            if (p_objData.Quy_Tac_Phieu.Contains("[yyMMdd]") || p_objData.Quy_Tac_Phieu.Contains("[ddMMyy]") 
                || p_objData.Quy_Tac_Phieu.Contains("[ddMMyyyy]") || p_objData.Quy_Tac_Phieu.Contains("[MMddyyyy]"))
            {
                if (p_objData.Ngay_Giao_Dich.Value.ToString("yyyyMMdd") != DateTime.Now.ToString("yyyyMMdd"))
                {
                    p_objData.STT_Current = 0;
                    p_objData.Ngay_Giao_Dich = DateTime.Now;
                }
            }

            //reset theo tháng
            if (p_objData.Quy_Tac_Phieu.Contains("[yyMM]") || p_objData.Quy_Tac_Phieu.Contains("[MMyy]")
                || p_objData.Quy_Tac_Phieu.Contains("[MMyyyy]") || p_objData.Quy_Tac_Phieu.Contains("[yyyyMM]"))
            {
                if (p_objData.Ngay_Giao_Dich.Value.ToString("MMyyyy") != DateTime.Now.ToString("MMyyyy"))
                {
                    p_objData.STT_Current = 0;
                    p_objData.Ngay_Giao_Dich = DateTime.Now;
                }
            }

            //reset theo năm
            if (p_objData.Quy_Tac_Phieu.Contains("[yy]") || p_objData.Quy_Tac_Phieu.Contains("[yyyy]"))
            {
                if (p_objData.Ngay_Giao_Dich.Value.ToString("yyyy") != DateTime.Now.ToString("yyyy"))
                {
                    p_objData.STT_Current = 0;
                    p_objData.Ngay_Giao_Dich = DateTime.Now;
                }
            }

        }
    }
}
