using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Mail;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
    public class CUtility_Date
    {
        public static DateTime? Convert_To_Dau_Ngay(DateTime? p_dtmDate)
        {
            DateTime? v_dtmRes = p_dtmDate;

            if (p_dtmDate == null)
                return null;

            v_dtmRes = CUtility.Convert_String_To_Datetime(p_dtmDate.Value.ToString("dd/MM/yyyy") + " 00:00:00", "dd/MM/yyyy HH:mm:ss");
            return v_dtmRes;
        }

        public static DateTime Convert_To_Dau_Ngay(DateTime p_dtmDate)
        {
            DateTime v_dtmRes = p_dtmDate;
            v_dtmRes = CUtility.Convert_String_To_Datetime(p_dtmDate.ToString("dd/MM/yyyy") + " 00:00:00", "dd/MM/yyyy HH:mm:ss").Value;
            return v_dtmRes;
        }

        public static DateTime? Convert_To_Cuoi_Ngay(DateTime? p_dtmDate)
        {
            DateTime? v_dtmRes = p_dtmDate;

            if (p_dtmDate == null)
                return null;

            v_dtmRes = CUtility.Convert_String_To_Datetime(p_dtmDate.Value.ToString("dd/MM/yyyy") + " 23:59:59", "dd/MM/yyyy HH:mm:ss");
            return v_dtmRes;
        }

        public static DateTime? Convert_To_Dau_Thang(DateTime? p_dtmData)
        {
            if (p_dtmData == null)
                return null;

            return CUtility.Convert_String_To_Datetime("01/" + p_dtmData.Value.Month.ToString("00") + "/"
                + p_dtmData.Value.Year.ToString() + " 00:00:00", "dd/MM/yyyy HH:mm:ss");
        }

        public static DateTime? Convert_To_Cuoi_Thang(DateTime? p_dtmData)
        {
            if (p_dtmData == null)
                return null;

            return Convert_To_Cuoi_Ngay(Convert_To_Dau_Thang(p_dtmData.Value.AddMonths(1)).Value.AddDays(-1));
        }

        public static DateTime? Convert_To_Dau_Tuan(DateTime? p_dtmData)
        {
            DateTime? v_dtmRes = p_dtmData;

            if (p_dtmData == null)
                return null;

            while (v_dtmRes.Value.DayOfWeek != DayOfWeek.Monday)
                v_dtmRes = v_dtmRes.Value.AddDays(-1);

            return Convert_To_Dau_Ngay(v_dtmRes);
        }

        public static DateTime? Convert_To_Cuoi_Tuan(DateTime? p_dtmData)
        {
            DateTime? v_dtmRes = p_dtmData;

            if (p_dtmData == null)
                return null;

            while (v_dtmRes.Value.DayOfWeek != DayOfWeek.Sunday)
                v_dtmRes = v_dtmRes.Value.AddDays(1);

            return Convert_To_Cuoi_Ngay(v_dtmRes);
        }

        public static DateTime? Convert_To_Dau_Nam(DateTime? p_dtmData)
        {
            if (p_dtmData == null)
                return null;

            return CUtility.Convert_String_To_Datetime("01/01/" + p_dtmData.Value.Year.ToString() + " 00:00:00", "dd/MM/yyyy HH:mm:ss");
        }

        public static DateTime? Convert_To_Cuoi_Nam(DateTime? p_dtmData)
        {
            if (p_dtmData == null)
                return null;

            return CUtility.Convert_String_To_Datetime("31/12/" + p_dtmData.Value.Year.ToString() + " 23:59:59", "dd/MM/yyyy HH:mm:ss");
        }

        public static DateTime? Add_Day_Ngoai_Tru_Chu_Nhat(DateTime? p_dtmNow, int p_iDay)
        {
            if (p_dtmNow == null)
                return null;

            int v_iCount = 0;
            int v_iSub = 1;
            if (p_iDay < 0)
                v_iSub = -1;
            DateTime? v_dtRes = p_dtmNow;

            while (v_iCount < Math.Abs(p_iDay))
            {
                v_iCount++;
                v_dtRes = v_dtRes.Value.AddDays(v_iSub);

                while (v_dtRes.Value.DayOfWeek == DayOfWeek.Sunday)
                    v_dtRes = v_dtRes.Value.AddDays(v_iSub);
            }

            return v_dtRes;
        }

        public static string Get_Mo_Ta_Thoi_Gian(DateTime? p_dtmData)
        {
            if (p_dtmData == null)
                return "";

            TimeSpan v_ts = DateTime.Now - p_dtmData.Value;
            if (v_ts.TotalSeconds < 60)
                return Math.Round(v_ts.TotalSeconds, 0).ToString("######") + " giây trước";

            if (v_ts.TotalMinutes < 60)
                return Math.Round(v_ts.TotalMinutes, 0).ToString("######") + " phút trước";

            if (v_ts.TotalHours < 24)
                return Math.Round(v_ts.TotalHours, 0).ToString("######") + " giờ trước";

            return Math.Round(v_ts.TotalDays, 0).ToString("######") + " ngày trước";
        }

        public static DateTime? Add_Day_Include_Saturday(DateTime? p_dtmNow, int p_iDay)
        {
            if (p_dtmNow == null)
                return null;

            int v_iCount = 0;
            int v_iSub = 1;
            if (p_iDay < 0)
                v_iSub = -1;
            DateTime? v_dtRes = p_dtmNow;

            while (v_iCount < Math.Abs(p_iDay))
            {
                v_iCount++;
                v_dtRes = v_dtRes.Value.AddDays(v_iSub);

                while (v_dtRes.Value.DayOfWeek == DayOfWeek.Sunday)
                    v_dtRes = v_dtRes.Value.AddDays(v_iSub);
            }

            return v_dtRes;
        }

        public static DateTime? Lay_Ngay_Dau_Tuan(DateTime? p_dtmData)
        {
            if (p_dtmData == null)
                return null;

            DateTime? v_dtmRes = p_dtmData;

            while (v_dtmRes.Value.DayOfWeek != DayOfWeek.Monday)
                v_dtmRes = v_dtmRes.Value.AddDays(-1);

            return v_dtmRes;
        }

        public static DateTime? Lay_Ngay_Dau_Thang(DateTime? p_dtmData)
        {
            if (p_dtmData == null)
                return null;

            return CUtility.Convert_String_To_Datetime("01/" + p_dtmData.Value.Month.ToString("00")
                + "/" + p_dtmData.Value.Year.ToString() + " 00:00:00", "dd/MM/yyyy HH:mm:ss");
        }

        public static DateTime? Lay_Ngay_Cuoi_Thang(DateTime? p_dtmData)
        {
            if (p_dtmData == null)
                return null;

            return Convert_To_Cuoi_Ngay(Lay_Ngay_Dau_Thang(p_dtmData.Value.AddMonths(1)).Value.AddDays(-1));
        }

        public static DateTime? Lay_Ngay_Dau_Nam(DateTime? p_dtmData)
        {
            if (p_dtmData == null)
                return null;

            DateTime? v_dtmRes = p_dtmData;

            while (v_dtmRes.Value.DayOfYear != 1)
                v_dtmRes = v_dtmRes.Value.AddDays(-1);

            return v_dtmRes;
        }
        
        public static DateTime? Get_Vietnam_Datetime_From_String(string p_strDate)
        {
            try
            {
                int v_iLength = p_strDate.Length;

                if (v_iLength != 0)
                {

                    if (v_iLength != 10 && v_iLength != 16 && v_iLength != 19 && v_iLength != 6)
                        throw new Exception("Ngày không đúng định dạng.");

                    if (v_iLength == 10)
                        return CUtility.Convert_String_To_Datetime(p_strDate, "dd/MM/yyyy");

                    if (v_iLength == 16)
                        return CUtility.Convert_String_To_Datetime(p_strDate, "dd/MM/yyyy HH:mm");

                    if (v_iLength == 19)
                        return CUtility.Convert_String_To_Datetime(p_strDate, "dd/MM/yyyy HH:mm:ss");

                    if (v_iLength == 6) // Format ddMMyy
                    {
                        string v_strDay = p_strDate.Substring(0, 2);
                        string v_strMonth = p_strDate.Substring(2, 2);

                        string v_strYear_Prefix = "20";
                        if (p_strDate == "010150")
                            v_strYear_Prefix = "19";

                        string v_strYear = v_strYear_Prefix + p_strDate.Substring(4, 2);

                        return CUtility.Convert_String_To_Datetime(v_strDay + "/" + v_strMonth + "/" + v_strYear, "dd/MM/yyyy");
                    }
                }
            }

            catch (Exception)
            {
                throw new Exception("Ngày không đúng định dạng.");
            }

            return CConst.DTM_VALUE_NULL;
        }

        public static DateTime? Get_Vietnam_Datetime_From_String(string p_strField_Name, string p_strDate)
        {
            try
            {
                int v_iLength = p_strDate.Length;

                if (v_iLength != 0)
                {

                    if (v_iLength != 10 && v_iLength != 16 && v_iLength != 19 && v_iLength != 6)
                        throw new Exception(p_strField_Name + ": không đúng định dạng [ddMMyy].");

                    if (v_iLength == 10)
                        return CUtility.Convert_String_To_Datetime(p_strDate, "dd/MM/yyyy");

                    if (v_iLength == 16)
                        return CUtility.Convert_String_To_Datetime(p_strDate, "dd/MM/yyyy HH:mm");

                    if (v_iLength == 19)
                        return CUtility.Convert_String_To_Datetime(p_strDate, "dd/MM/yyyy HH:mm:ss");

                    if (v_iLength == 6) // Format ddMMyy
                    {
                        string v_strDay = p_strDate.Substring(0, 2);
                        string v_strMonth = p_strDate.Substring(2, 2);

                        string v_strYear_Prefix = "20";
                        if (p_strDate == "010150")
                            v_strYear_Prefix = "19";

                        string v_strYear = v_strYear_Prefix + p_strDate.Substring(4, 2);

                        return CUtility.Convert_String_To_Datetime(v_strDay + "/" + v_strMonth + "/" + v_strYear, "dd/MM/yyyy");
                    }
                }
            }

            catch (Exception)
            {
                throw new Exception(p_strField_Name + ": không đúng định dạng [ddMMyy].");
            }

            return CConst.DTM_VALUE_NULL;
        }

        public static DateTime? Read_DateTime_From_Excel(string p_dtmString_Value)
        {
            DateTime temp;

            if (DateTime.TryParse(p_dtmString_Value, out temp))
                return temp;
            else
                return DateTime.FromOADate(CUtility.Convert_To_Double(p_dtmString_Value));
        }
    }
}
