using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Net.Mail;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;
using System.Data;
using System.Reflection;
using Microsoft.Extensions.Primitives;
using TKS_Thuc_Tap_V11_Data_Access.Entity.DM;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
    public class CUtility
    {
        public static Random rand = new Random();

        public static DateTime? Get_Null_Date()
        {
            return Convert_String_To_Datetime("01/01/1900", "dd/MM/yyyy");
        }

        public static int Convert_To_Int32(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (CUtility.Convert_To_String(p_objData) != ""))
                return Convert.ToInt32(p_objData);
            else
                return CConst.INT_VALUE_NULL;
        }

        public static long Convert_To_Int64(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (CUtility.Convert_To_String(p_objData) != ""))
                return Convert.ToInt64(p_objData);
            else
                return CConst.INT_VALUE_NULL;
        }

        public static double Convert_To_Double(object p_objData)
        {
            if ((p_objData != System.DBNull.Value) && (CUtility.Convert_To_String(p_objData) != ""))
                return Convert.ToDouble(p_objData);
            else
                return CConst.FLT_VALUE_NULL;
        }

        public static bool Convert_To_Bool(object p_objData)
        {
            if (p_objData != System.DBNull.Value)
                return Convert.ToBoolean(p_objData);
            else
                return CConst.BL_VALUE_NULL;
        }

        public static DateTime? Convert_To_DateTime(object p_objData)
        {
            if (p_objData != System.DBNull.Value && p_objData != null)
                return Convert.ToDateTime(p_objData);
            else
                return CConst.DTM_VALUE_NULL;
        }

        public static DateTime? Convert_String_To_Datetime(string p_strDate)
        {
            if (p_strDate == "")
                return CConst.DTM_VALUE_NULL;

            CultureInfo provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(p_strDate, CConfig.Date_Format_String, provider);
        }

        public static DateTime? Convert_String_To_Datetime(string p_strDate, string p_strFormat)
        {
            if (p_strDate == "")
                return CConst.DTM_VALUE_NULL;

            CultureInfo provider = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(p_strDate, p_strFormat, provider);
        }

        public static string Convert_To_String(object p_objData)
        {
            return Convert.ToString(p_objData);
        }

        public static string MD5_Encrypt(string p_strSource)
        {
            System.Text.UTF8Encoding utf8encoding = new System.Text.UTF8Encoding();
            byte[] Data = utf8encoding.GetBytes(p_strSource);

#pragma warning disable SYSLIB0021 // Type or member is obsolete
            System.Security.Cryptography.MD5CryptoServiceProvider md5Encrypt = new System.Security.Cryptography.MD5CryptoServiceProvider();
#pragma warning restore SYSLIB0021 // Type or member is obsolete
            byte[] hashData = md5Encrypt.ComputeHash(Data);

            string result = "";

            for (int i = 0; i < hashData.Length; i++)
                result += Convert.ToString(hashData[i], 16).PadLeft(2, 'j');

            return result.PadLeft(32, 'n');
        }

        public static double Min(double p_dbl1, double p_dbl2)
        {
            double v_dblRes = p_dbl1;
            if (v_dblRes > p_dbl2)
                v_dblRes = p_dbl2;
            return v_dblRes;
        }

        public static string Is_Valid_Password_Format(string p_strPass)
        {
            StringBuilder v_sb = new StringBuilder();

            if (p_strPass.Length < 8)
                v_sb.Append("Mật khẩu phải dài ít nhất 8 ký tự.<br/>");

            if (!Is_Contain_Character_Char(p_strPass))
                v_sb.Append("Mật khẩu phải có ít nhất một ký tự chữ.<br/>");

            if (!Is_Contain_Number_Char(p_strPass))
                v_sb.Append("Mật khẩu phải có ít nhất một ký tự số.<br/>");

            if (!Is_Contain_Special_Char(p_strPass))
                v_sb.Append("Mật khẩu phải có ít nhất một ký tự đặc biệt. Ký tự đặt biệt là các ký tự: +-(){}[]!?@#$%^&* <>:;.,=_~`.<br/>");

            return v_sb.ToString();
        }

        public static bool Is_Valid_Phone(string p_strPhone)
        {
            bool v_bRes = true;
            string v_strValid = @"0123456789 .-(){}[]+";
            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strPhone)
            {
                if (!v_strValid.Contains(v_c.ToString()))
                {
                    v_bRes = false;
                    break;
                }
            }

            return v_bRes;
        }

        public static bool Is_Valid_Dang_Nhap(string p_strDang_Nhap)
        {
            bool v_bRes = true;
            string v_strValid = @"+(){}[]?/\!@#$%^&* <>:;,=~`";
            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strDang_Nhap)
            {
                if (v_strValid.Contains(v_c.ToString()))
                {
                    v_bRes = false;
                    break;
                }
            }

            return v_bRes;
        }

        public static bool Is_Valid_Number(string p_strPhone)
        {
            bool v_bRes = true;
            string v_strValid = @"0123456789.";
            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strPhone)
            {
                if (!v_strValid.Contains(v_c.ToString()))
                {
                    v_bRes = false;
                    break;
                }
            }

            return v_bRes;
        }

        public static bool SendMailUseSMTP(string p_strFrom, string p_strTo, string p_strSubject,
                                            string p_strMessage, string p_strHost, bool p_bUseDefaultCredentials, int p_iPort,
                                            string p_strUser, string p_strPass, bool p_bEnableSsl, string p_strAttach)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            bool result = regex.IsMatch(p_strFrom);
            if (result == false)
            {
                throw new Exception("Email không hợp lệ!!!");
            }
            else
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                SmtpClient smtp = new SmtpClient(p_strHost);

                mail.From = new MailAddress(p_strFrom);

                p_strTo = p_strTo.Replace(",", ";");
                string[] v_arrMail_To = p_strTo.Split(';');

                foreach (string v_strTemp in v_arrMail_To)
                {
                    if (v_strTemp.Trim() != "")
                        mail.To.Add(v_strTemp.Trim());
                }

                mail.Subject = p_strSubject;
                mail.Body = p_strMessage;
                mail.IsBodyHtml = true;

                smtp.UseDefaultCredentials = p_bUseDefaultCredentials;
                smtp.Port = p_iPort;
                smtp.Credentials = new System.Net.NetworkCredential(p_strUser, p_strPass);
                smtp.EnableSsl = p_bEnableSsl;
                smtp.TargetName = "STARTTLS/smtp.office365.com"; //080822 NgocHB bổ sung tạm do chuyển sang dùng office365

                if (p_strAttach != "")
                    mail.Attachments.Add(new Attachment(p_strAttach));

                smtp.Send(mail);
                return true;
            }
        }

        public static bool SendMailUseSMTP(string p_strTo, string p_strSubject, string p_strMessage, string p_strAttach)
        {
            return SendMailUseSMTP(CConfig.Email_From, p_strTo, p_strSubject, p_strMessage, CConfig.Smtp_Host, CConfig.Smtp_UseDefaultCredentials, CConfig.Smtp_Port,
                CConfig.Email_From, CConfig.Smtp_Pass, CConfig.Smtp_EnableSsl, p_strAttach);
        }

        private static bool Is_Contain_Character_Char(string p_strData)
        {
            bool v_bRes = false;

            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strData)
            {
                if ((v_c >= 'A' && v_c <= 'Z') || (v_c >= 'a' && v_c <= 'z'))
                {
                    v_bRes = true;
                    break;
                }
            }

            return v_bRes;
        }

        private static bool Is_Contain_Special_Char(string p_strData)
        {
            bool v_bRes = false;
            string v_strValid = @"+-(){}[]?/\!@#$%^&* <>:;.,=_~`";

            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strData)
            {
                if (v_strValid.Contains(v_c.ToString()))
                {
                    v_bRes = true;
                    break;
                }
            }

            return v_bRes;
        }

        private static bool Is_Contain_Number_Char(string p_strData)
        {
            bool v_bRes = false;

            //Kiểm tra tính hợp lệ,nếu không Contains(chứa) một trong các điều kiện trên là sai
            foreach (char v_c in p_strData)
            {
                if (v_c >= 48 && v_c <= 57)
                {
                    v_bRes = true;
                    break;
                }
            }

            return v_bRes;
        }

        public static string Create_Random_String(int p_iLen)
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder v_strRes = new StringBuilder();

            for (int i = 0; i < p_iLen; i++)
            {
                // Lấy kí tự ngẫu nhiên từ mảng chars
                string str = chars[rand.Next(chars.Length)].ToString();
                v_strRes.Append(str);
            }

            return v_strRes.ToString();
        }

        public static string Create_Random_Number_String(int p_iLen)
        {
            const string chars = "0123456789";
            StringBuilder v_strRes = new StringBuilder();

            for (int i = 0; i < p_iLen; i++)
            {
                // Lấy kí tự ngẫu nhiên từ mảng chars
                string str = chars[rand.Next(chars.Length)].ToString();
                v_strRes.Append(str);
            }

            return v_strRes.ToString();
        }

		public static long Create_Random_Number(int p_iLen)
		{
			const string chars = "123456789";
			StringBuilder v_strRes = new StringBuilder();

			for (int i = 0; i < p_iLen; i++)
			{
				// Lấy kí tự ngẫu nhiên từ mảng chars
				string str = chars[rand.Next(chars.Length)].ToString();
				v_strRes.Append(str);
			}

            return Convert_To_Int64(v_strRes.ToString());
		}

        public static String Hash_SHA256(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                #pragma warning disable SYSLIB0021 // Type or member is obsolete
                SHA256Managed sha = new SHA256Managed();
                
                #pragma warning restore SYSLIB0021 // Type or member is obsolete
                byte[] hash = sha.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        public static string Html_To_Plain_Text(string html)
        {
            const string tagWhiteSpace = @"(>|$)(\W|\n|\r)+<";//matches one or more (white space or line breaks) between '>' and '<'
            const string stripFormatting = @"<[^>]*(>|$)";//match any character between '<' and '>', even when end tag is missing
            const string lineBreak = @"<(br|BR)\s{0,1}\/{0,1}>";//matches: <br>,<br/>,<br />,<BR>,<BR/>,<BR />
            var lineBreakRegex = new Regex(lineBreak, RegexOptions.Multiline);
            var stripFormattingRegex = new Regex(stripFormatting, RegexOptions.Multiline);
            var tagWhiteSpaceRegex = new Regex(tagWhiteSpace, RegexOptions.Multiline);

            var text = html;
            //Decode html specific characters
            text = System.Net.WebUtility.HtmlDecode(text);
            //Remove tag whitespace/line breaks
            text = tagWhiteSpaceRegex.Replace(text, "><");
            //Replace <br /> with line breaks
            text = lineBreakRegex.Replace(text, Environment.NewLine);
            //Strip formatting
            text = stripFormattingRegex.Replace(text, string.Empty);

            return text;
        }

        public static string Convert_Tieng_Viet_Co_Dau_To_Khong_Dau_Rewrite_Code(string text)
        {
            //Ky tu dac biet
            for (int i = 32; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), "-");
            }
            text = text.Replace(".", "-");
            text = text.Replace(" ", "-");
            text = text.Replace(",", "-");
            text = text.Replace(";", "-");
            text = text.Replace(":", "-");
            text = text.Replace(">", "-");
            text = text.Replace("<", "-");
            text = text.Replace("(", "-");
            text = text.Replace(")", "-");
            text = text.Replace("?", "-");
            text = text.Replace("$", "-");
            text = text.Replace("&", "-");
            text = text.Replace("/", "-");

            //'Dấu Ngang
            text = text.Replace("A", "A");
            text = text.Replace("a", "a");
            text = text.Replace("Ă", "A");
            text = text.Replace("ă", "a");
            text = text.Replace("Â", "A");
            text = text.Replace("â", "a");
            text = text.Replace("E", "E");
            text = text.Replace("e", "e");
            text = text.Replace("Ê", "E");
            text = text.Replace("ê", "e");
            text = text.Replace("I", "I");
            text = text.Replace("i", "i");
            text = text.Replace("O", "O");
            text = text.Replace("o", "o");
            text = text.Replace("Ô", "O");
            text = text.Replace("ô", "o");
            text = text.Replace("Ơ", "O");
            text = text.Replace("ơ", "o");
            text = text.Replace("U", "U");
            text = text.Replace("u", "u");
            text = text.Replace("Ư", "U");
            text = text.Replace("ư", "u");
            text = text.Replace("Y", "Y");
            text = text.Replace("y", "y");

            //'Dấu Huyền
            text = text.Replace("À", "A");
            text = text.Replace("à", "a");
            text = text.Replace("Ằ", "A");
            text = text.Replace("ằ", "a");
            text = text.Replace("Ầ", "A");
            text = text.Replace("ầ", "a");
            text = text.Replace("È", "E");
            text = text.Replace("è", "e");
            text = text.Replace("Ề", "E");
            text = text.Replace("ề", "e");
            text = text.Replace("Ì", "I");
            text = text.Replace("ì", "i");
            text = text.Replace("Ò", "O");
            text = text.Replace("ò", "o");
            text = text.Replace("Ồ", "O");
            text = text.Replace("ồ", "o");
            text = text.Replace("Ờ", "O");
            text = text.Replace("ờ", "o");
            text = text.Replace("Ù", "U");
            text = text.Replace("ù", "u");
            text = text.Replace("Ừ", "U");
            text = text.Replace("ừ", "u");
            text = text.Replace("Ỳ", "Y");
            text = text.Replace("ỳ", "y");

            //'Dấu Sắc
            text = text.Replace("Á", "A");
            text = text.Replace("á", "a");
            text = text.Replace("Ắ", "A");
            text = text.Replace("ắ", "a");
            text = text.Replace("Ấ", "A");
            text = text.Replace("ấ", "a");
            text = text.Replace("É", "E");
            text = text.Replace("é", "e");
            text = text.Replace("Ế", "E");
            text = text.Replace("ế", "e");
            text = text.Replace("Í", "I");
            text = text.Replace("í", "i");
            text = text.Replace("Ó", "O");
            text = text.Replace("ó", "o");
            text = text.Replace("Ố", "O");
            text = text.Replace("ố", "o");
            text = text.Replace("Ớ", "O");
            text = text.Replace("ớ", "o");
            text = text.Replace("Ú", "U");
            text = text.Replace("ú", "u");
            text = text.Replace("Ứ", "U");
            text = text.Replace("ứ", "u");
            text = text.Replace("Ý", "Y");
            text = text.Replace("ý", "y");

            //'Dấu Hỏi
            text = text.Replace("Ả", "A");
            text = text.Replace("ả", "a");
            text = text.Replace("Ẳ", "A");
            text = text.Replace("ẳ", "a");
            text = text.Replace("Ẩ", "A");
            text = text.Replace("ẩ", "a");
            text = text.Replace("Ẻ", "E");
            text = text.Replace("ẻ", "e");
            text = text.Replace("Ể", "E");
            text = text.Replace("ể", "e");
            text = text.Replace("Ỉ", "I");
            text = text.Replace("ỉ", "i");
            text = text.Replace("Ỏ", "O");
            text = text.Replace("ỏ", "o");
            text = text.Replace("Ổ", "O");
            text = text.Replace("ổ", "o");
            text = text.Replace("Ở", "O");
            text = text.Replace("ở", "o");
            text = text.Replace("Ủ", "U");
            text = text.Replace("ủ", "u");
            text = text.Replace("Ử", "U");
            text = text.Replace("ử", "u");
            text = text.Replace("Ỷ", "Y");
            text = text.Replace("ỷ", "y");

            //'Dấu Ngã
            text = text.Replace("Ã", "A");
            text = text.Replace("ã", "a");
            text = text.Replace("Ẵ", "A");
            text = text.Replace("ẵ", "a");
            text = text.Replace("Ẫ", "A");
            text = text.Replace("ẫ", "a");
            text = text.Replace("Ẽ", "E");
            text = text.Replace("ẽ", "e");
            text = text.Replace("Ễ", "E");
            text = text.Replace("ễ", "e");
            text = text.Replace("Ĩ", "I");
            text = text.Replace("ĩ", "i");
            text = text.Replace("Õ", "O");
            text = text.Replace("õ", "o");
            text = text.Replace("Ỗ", "O");
            text = text.Replace("ỗ", "o");
            text = text.Replace("Ỡ", "O");
            text = text.Replace("ỡ", "o");
            text = text.Replace("Ũ", "U");
            text = text.Replace("ũ", "u");
            text = text.Replace("Ữ", "U");
            text = text.Replace("ữ", "u");
            text = text.Replace("Ỹ", "Y");
            text = text.Replace("ỹ", "y");

            //'Dẫu Nặng
            text = text.Replace("Ạ", "A");
            text = text.Replace("ạ", "a");
            text = text.Replace("Ặ", "A");
            text = text.Replace("ặ", "a");
            text = text.Replace("Ậ", "A");
            text = text.Replace("ậ", "a");
            text = text.Replace("Ẹ", "E");
            text = text.Replace("ẹ", "e");
            text = text.Replace("Ệ", "E");
            text = text.Replace("ệ", "e");
            text = text.Replace("Ị", "I");
            text = text.Replace("ị", "i");
            text = text.Replace("Ọ", "O");
            text = text.Replace("ọ", "o");
            text = text.Replace("Ộ", "O");
            text = text.Replace("ộ", "o");
            text = text.Replace("Ợ", "O");
            text = text.Replace("ợ", "o");
            text = text.Replace("Ụ", "U");
            text = text.Replace("ụ", "u");
            text = text.Replace("Ự", "U");
            text = text.Replace("ự", "u");
            text = text.Replace("Ỵ", "Y");
            text = text.Replace("ỵ", "y");
            text = text.Replace("Đ", "D");
            text = text.Replace("đ", "d");

            foreach (char v_c in text)
            {
                if (!Is_Number_Char(v_c) && !Is_Character_Char(v_c))
                    text = text.Replace(v_c, '-');
            }

            string v_strRes = text.Replace("--", "-");

            return v_strRes;
        }

        private static bool Is_Number_Char(char v_c)
        {
            bool v_bRes = false;

            if (v_c >= 48 && v_c <= 57)
                v_bRes = true;

            return v_bRes;
        }

        private static bool Is_Character_Char(char v_c)
        {
            bool v_bRes = false;

            if (v_c >= 'A' && v_c <= 'Z')
                v_bRes = true;

            if (v_c >= 'a' && v_c <= 'z')
                v_bRes = true;

            return v_bRes;
        }

        public static string MD5_Encrypt_Default_Microsoft(string p_strText)
        {
#pragma warning disable SYSLIB0021 // Type or member is obsolete
            MD5 md5 = new MD5CryptoServiceProvider();
#pragma warning restore SYSLIB0021 // Type or member is obsolete

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(p_strText));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder v_strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                v_strBuilder.Append(result[i].ToString("x2"));
            }

            return v_strBuilder.ToString();
        }

        public static bool Check_Dau_Tieng_Viet(string p_strText)
        {
            bool v_blRes = true;
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};

            for (int i = 0; i < arr1.Length; i++)
            {
                if (p_strText.ToUpper().Contains(arr1[i].ToUpper()))
                    return false;
            }

            return v_blRes;
        }

        public static T Map_Row_To_Entity<T>(DataRow p_Row) where T : new()
        {
            // create a new object
            T v_objItem = new T();

            foreach (DataColumn v_colValue in p_Row.Table.Columns)
            {
                // find the property for the column
                PropertyInfo v_objItem_Info = v_objItem.GetType().GetProperty(v_colValue.ColumnName);
               
                // if exists, set the value
                if (v_objItem_Info != null && p_Row[v_colValue] != DBNull.Value)
                {
                    //an sửa ngày 16/02/2022
                    MethodInfo v_objMethodInfo = v_objItem_Info.SetMethod;
                    if (v_objMethodInfo != null)
                    {
                        string v_strTypedata = v_colValue.DataType.Name;
                        switch (v_strTypedata)
                        {
                            case "String": v_objItem_Info.SetValue(v_objItem, CUtility.Convert_To_String(p_Row[v_colValue])); break;
                            case "Int16": v_objItem_Info.SetValue(v_objItem, CUtility.Convert_To_Int32(p_Row[v_colValue])); break;
                            case "Int32": v_objItem_Info.SetValue(v_objItem, CUtility.Convert_To_Int32(p_Row[v_colValue])); break;
                            case "Int64": v_objItem_Info.SetValue(v_objItem, CUtility.Convert_To_Int64(p_Row[v_colValue])); break;
                            case "DateTime": v_objItem_Info.SetValue(v_objItem, CUtility.Convert_To_DateTime(p_Row[v_colValue])); break;
                            case "DateTime?": v_objItem_Info.SetValue(v_objItem, CUtility.Convert_To_DateTime(p_Row[v_colValue])); break;
                            case "Double": v_objItem_Info.SetValue(v_objItem, CUtility.Convert_To_Double(p_Row[v_colValue]), null); break;
                            case "Decimal": v_objItem_Info.SetValue(v_objItem, CUtility.Convert_To_Double(p_Row[v_colValue]), null); break;
                            case "Boolean": v_objItem_Info.SetValue(v_objItem, CUtility.Convert_To_Bool(p_Row[v_colValue]), null); break;
                        }
                    }
                }
            }

            // return 
            return v_objItem;
        }

        public static void Clone_Entity(object p_objSource, object p_objTarget)
        {
            Type T1 = p_objSource.GetType();
            Type T2 = p_objTarget.GetType();

            PropertyInfo[] v_objSourceProprties = T1.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            PropertyInfo[] v_objTargetProprties = T2.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            for (int v_i = 0; v_i < v_objSourceProprties.Length; v_i++)
            {
                var v_objSourceProp = v_objSourceProprties[v_i];
                var v_objTargetProp = v_objTargetProprties[v_i];

                if (v_objSourceProp.CanWrite == true)
                {
                    object v_objSourceVal = v_objSourceProp.GetValue(p_objSource, null);

                    string v_strTypedata = v_objTargetProp.PropertyType.Name;
                    if (v_objTargetProp.PropertyType.GenericTypeArguments.Length > 0)
                        v_strTypedata = v_objTargetProp.PropertyType.GenericTypeArguments[0].Name;

                    switch (v_strTypedata)
                    {
                        case "String": v_objTargetProp.SetValue(p_objTarget, CUtility.Convert_To_String(v_objSourceVal)); break;
                        case "Int16": v_objTargetProp.SetValue(p_objTarget, CUtility.Convert_To_Int32(v_objSourceVal), null); break;
                        case "Int32": v_objTargetProp.SetValue(p_objTarget, CUtility.Convert_To_Int32(v_objSourceVal), null); break;
                        case "Int64": v_objTargetProp.SetValue(p_objTarget, CUtility.Convert_To_Int64(v_objSourceVal), null); break;
                        case "DateTime": v_objTargetProp.SetValue(p_objTarget, CUtility.Convert_To_DateTime(v_objSourceVal), null); break;
                        case "DateTime?": v_objTargetProp.SetValue(p_objTarget, CUtility.Convert_To_DateTime(v_objSourceVal), null); break;
                        case "Double": v_objTargetProp.SetValue(p_objTarget, CUtility.Convert_To_Double(v_objSourceVal), null); break;
                        case "Decimal": v_objTargetProp.SetValue(p_objTarget, CUtility.Convert_To_Double(v_objSourceVal), null); break;
                        case "Boolean": v_objTargetProp.SetValue(p_objTarget, CUtility.Convert_To_Bool(v_objSourceVal), null); break;
                       
                    }
                }
            }
        }

        public static string Compare_Entity(object p_objSource, object p_objTarget)
        {
            string v_strRes = "";

            Type T1 = p_objSource.GetType();
            Type T2 = p_objTarget.GetType();

            PropertyInfo[] v_objSourceProprties = T1.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            PropertyInfo[] v_objTargetProprties = T2.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            for (int v_i = 0; v_i < v_objSourceProprties.Length; v_i++)
            {
                string v_strField_Name = v_objSourceProprties[v_i].Name;
                if (v_strField_Name != "" && v_strField_Name.ToLower() != "auto_id" && v_strField_Name.ToLower() != "deleted"
                    && v_strField_Name.ToLower() != "created" && v_strField_Name.ToLower() != "created_by" && v_strField_Name.ToLower() != "created_by_function"
                    && v_strField_Name.ToLower() != "last_updated" && v_strField_Name.ToLower() != "last_updated_by" 
                    && v_strField_Name.ToLower() != "last_updated_by_function")
                {
                    var v_objSourceProp = v_objSourceProprties[v_i];
                    var v_objTargetProp = v_objTargetProprties[v_i];

                    object v_objSourceVal = v_objSourceProp.GetValue(p_objSource, null);
                    object v_objTargetVal = v_objSourceProp.GetValue(p_objTarget, null);

                    if (CUtility.Convert_To_String(v_objSourceVal).ToLower() != CUtility.Convert_To_String(v_objTargetVal).ToLower())
                        v_strRes += ", " + v_strField_Name + ": " + CUtility.Convert_To_String(v_objSourceVal) + " --> " + CUtility.Convert_To_String(v_objTargetVal);
				}
            }

            if (v_strRes.Length > 0)
                v_strRes = v_strRes.Remove(0, 2);

            return v_strRes;
        }

        public static string[] Split_And_Trim(string p_strData, char p_chSplit)
        {
            string[] v_arrRes = p_strData.Split(p_chSplit);
            for (int v_i = 0; v_i < v_arrRes.Length; v_i++)
                v_arrRes[v_i] = v_arrRes[v_i].Trim();

            return v_arrRes;
        }

        public static string Trim_Group_ID(string p_strData, char p_chSplit)
        {
            string[] v_arrRes = Split_And_Trim(p_strData, p_chSplit);

            string v_strRes = "";
            for (int v_i = 0; v_i < v_arrRes.Length; v_i++)
                v_strRes += p_chSplit + v_arrRes[v_i];

            if (v_strRes.Length >= 1)
                v_strRes = v_strRes.Remove(0, 1);

            return v_strRes;
        }

        public static bool Is_Child_String_In_Parent(string p_strChild, string p_strParent, char p_cSplit)
        {
            p_strParent = p_strParent.Replace(" " + p_cSplit, p_cSplit.ToString());
            p_strParent = p_strParent.Replace(p_cSplit + " ", p_cSplit.ToString());

            p_strParent = (p_cSplit + p_strParent + p_cSplit).ToLower();

            string[] v_arrChild = Split_And_Trim(p_strChild, p_cSplit);
            foreach (string v_strTemp in v_arrChild)
            {
                if (p_strParent.Contains(p_cSplit + v_strTemp.ToLower() + p_cSplit) == false)
                    return false;
            }

            return true;
        }

        public static string Get_Date_Text(DateTime? p_dtmDate, string p_strFormat)
        {
            string v_strRes = "";

            if (p_dtmDate != null && p_dtmDate != CConst.DTM_VALUE_NULL)
                v_strRes = p_dtmDate.Value.ToString(p_strFormat);

            return v_strRes;
        }

        public static string Get_DateTime_Text(DateTime? p_dtmDate)
        {
            return Get_Date_Text(p_dtmDate, "dd/MM/yyyy HH:mm");
        }

        public static string Get_Date_Text(DateTime? p_dtmDate)
        {
            return Get_Date_Text(p_dtmDate, CConfig.Date_Format_String);
        }

		public static string Get_Date_PDA_Text(DateTime? p_dtmDate)
		{
            if (p_dtmDate != null)
                return Get_Date_Text(p_dtmDate, "ddMMyyyy");
            else
                return "";
		}

        public static string Get_Date_PDA_Text(DateTime? p_dtmDate, string p_strFormat)
        {
            if (p_dtmDate != null)
                return Get_Date_Text(p_dtmDate, p_strFormat);
            else
                return "";
        }

        public static string Get_Label_Text(object p_objData, bool p_bOnly_String)
        {
            if (p_objData == null)
                return "-";

            string v_strType = p_objData.GetType().Name.ToLower();
            string v_strRes = "";

            if (p_bOnly_String == false)
            {
                switch (v_strType.ToLower())
                {
                    case "string": v_strRes = Convert_To_String(p_objData); break;
                    case "int32": v_strRes = CUtility.Convert_To_Int32(p_objData).ToString(CConfig.Number_Format_String); break;
                    case "int64": v_strRes = CUtility.Convert_To_Int64(p_objData).ToString(CConfig.Number_Format_String); break;
                    case "double": v_strRes = CUtility.Convert_To_Double(p_objData).ToString("###,###0.#####;-###,###0.#####;-"); break;
                    case "float": v_strRes = CUtility.Convert_To_Double(p_objData).ToString("###,###0.#####;-###,###0.#####;-"); break;
                    case "datetime":
                        v_strRes = CUtility.Get_DateTime_Text(CUtility.Convert_To_DateTime(p_objData));
                        if (v_strRes.EndsWith(" 00:00") == true || v_strRes.EndsWith(" 00:00:00") == true)
                            v_strRes = CUtility.Get_Date_Text(CUtility.Convert_To_DateTime(p_objData));
                        break;
					case "bool":
                        if (CUtility.Convert_To_Bool(p_objData) == true)
                        v_strRes = "checked"; 
                        break;
				}
            }
            else
            {
                v_strRes = CUtility.Convert_To_String(p_objData);
            }

            if (v_strRes == "")
                v_strRes = "-";

            return v_strRes;
        }

        public static bool Is_Valid_Email(string p_strEmail, string p_strSep = ";")
        {
            bool v_blnRes = true;

            Regex validateEmailRegex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            string[] v_arrEmail = p_strEmail.Split(p_strSep);

            for (int i = 0; i < v_arrEmail.Length; i++)
            {
                if (!validateEmailRegex.IsMatch(v_arrEmail[i].Trim()) && v_arrEmail[i].Trim() != "")
                    return false;
            }

            return v_blnRes;
        }

        public static string Fix_Handler_File_Name(string p_strInput)
        {
            string v_strRes = "";
            p_strInput = p_strInput.Replace("  ", " ");
            p_strInput = p_strInput.Replace(' ', '_');
            p_strInput = p_strInput.Replace('-', '_');
            v_strRes = p_strInput;
            return v_strRes;
        }

        public static bool Check_File_Type_Accept_Upload(string p_strCheck)
        {
            if (CConfig.Allowed_Extensions_Upload.Contains(p_strCheck) == true)
                return true;

            return false;
        }

        private static string Get_String_For_Tao_Key(object p_objData)
        {
            if (p_objData == null)
                return "";

            string v_strType = p_objData.GetType().Name.ToLower();
            string v_strRes = "";

            switch (v_strType.ToLower())
            {
                case "string": v_strRes = Convert_To_String(p_objData); break;
                case "int32": v_strRes = CUtility.Convert_To_Int32(p_objData).ToString("###0"); break;
                case "int64": v_strRes = CUtility.Convert_To_Int64(p_objData).ToString("###0"); break;
                case "double": v_strRes = CUtility.Convert_To_Double(p_objData).ToString("###0.#####;-###0.#####;0").Replace(",", "."); break;
                case "float": v_strRes = CUtility.Convert_To_Double(p_objData).ToString("###0.#####;-###0.#####;0").Replace(",", "."); break;
                case "datetime": 
                    v_strRes = CUtility.Get_Date_Text(CUtility.Convert_To_DateTime(p_objData), "dd-MM-yyyy");
                    break;
                case "bool":
                    if (CUtility.Convert_To_Bool(p_objData) == true)
                        v_strRes = "1";
                    else
                        v_strRes = "0";
                    break;
            }

            if (v_strRes == "")
                v_strRes = "";

            return v_strRes;
        }

        public static string Tao_Key(params object[] p_arrValue)
        {
            string v_strKey = "";
            if (p_arrValue == null)
                return "";

            for (int i = 0, j = p_arrValue.Length; i < j; i++)
            {
                string v_strValue = Get_String_For_Tao_Key(p_arrValue[i]);

                if (v_strKey == "")
                    v_strKey = v_strValue;
                else
                {
                    v_strKey += "|" + v_strValue;
                }
            }

			return v_strKey.ToUpper();
        }

        public static string Tao_Key_Lo_Hang(long p_iNhap_Kho_ID,long p_iSan_Pham_ID, string p_strSo_PO, string p_strSo_Batch, string p_strSo_Lot,
            string p_strSo_Serial, DateTime? p_dtmNgay_San_Xuat, DateTime? p_dtmNgay_Het_Han, string p_strLine_Item, DateTime? p_dtmNgay_Nhap_Kho_Root)
        {
			string v_strRes = Tao_Key(p_iNhap_Kho_ID, p_iSan_Pham_ID, p_strSo_PO, p_strSo_Batch, p_strSo_Lot, p_strSo_Serial,
                p_dtmNgay_San_Xuat, p_dtmNgay_Het_Han, p_strLine_Item, p_dtmNgay_Nhap_Kho_Root);

            return v_strRes;
        }

        private static string Get_String_For_Tao_Combo(object p_objData)
        {
            if (p_objData == null)
                return "";

            string v_strType = p_objData.GetType().Name.ToLower();
            string v_strRes = "";

            switch (v_strType.ToLower())
            {
                case "string": v_strRes = Convert_To_String(p_objData); break;
                case "int32": v_strRes = CUtility.Convert_To_Int32(p_objData).ToString("###0"); break;
                case "int64": v_strRes = CUtility.Convert_To_Int64(p_objData).ToString("###0"); break;
                case "double": v_strRes = CUtility.Convert_To_Double(p_objData).ToString("###0.#####;-###0.#####;0").Replace(",", "."); break;
                case "float": v_strRes = CUtility.Convert_To_Double(p_objData).ToString("###0.#####;-###0.#####;0").Replace(",", "."); break;
                case "datetime":
                    v_strRes = CUtility.Get_Date_Text(CUtility.Convert_To_DateTime(p_objData), "dd-MM-yyyy");
                    break;
                case "bool":
                    if (CUtility.Convert_To_Bool(p_objData) == true)
                        v_strRes = "1";
                    else
                        v_strRes = "0";
                    break;
            }

            if (v_strRes == "")
                v_strRes = "";

            return v_strRes;
        }

        public static string Tao_Combo_Text(params object[] p_arrValue)
        {
            string v_strKey = "";
            if (p_arrValue == null)
                return "";

            for (int i = 0, j = p_arrValue.Length; i < j; i++)
            {
                string v_strValue = Get_String_For_Tao_Combo(p_arrValue[i]);

                if (v_strKey == "")
                    v_strKey = v_strValue;
                else
                {

                    if (v_strValue != "")
                        v_strKey += " (" + v_strValue + ")";
                }
            }

            return v_strKey;
        }

		public static string Get_Excel_ColumnName(int p_icolumn)
		{
			string v_strcolumnString = "";
			decimal v_icolumnNumber = p_icolumn;
			while (v_icolumnNumber > 0)
			{
				decimal currentLetterNumber = (v_icolumnNumber) % 26;
				char currentLetter = (char)(currentLetterNumber + 65);
				v_strcolumnString = currentLetter + v_strcolumnString;
				v_icolumnNumber = (v_icolumnNumber - (currentLetterNumber + 1)) / 26;
			}
			return v_strcolumnString;
		}
        
        public static string Create_GUID_By_String(string p_strInput)
        {
            Guid v_guidResult;
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(p_strInput));
                v_guidResult = new Guid(hash);
            }
            return v_guidResult.ToString();
        }
        
        public static string[] Read_File_TXT(string p_strFile)
        {
            return System.IO.File.ReadAllLines(p_strFile);
        }
        
        public static void Write_File_TXT(string p_strFile, string p_strData)
        {
            System.IO.File.WriteAllText(p_strFile, p_strData);
        }
        
        public static DateTime? Get_Date_From_Day_In_Year(int p_iYear, int p_iDay)
        {

            DateTime? v_dtmDate = new DateTime(p_iYear, 1, 1).AddDays(p_iDay - 1);
            return v_dtmDate;

        }

        public static string Format_Number_With_Dot(long v_lngnumber)
        {
            // Chuyển đổi số thành chuỗi
            string v_strnumberString = v_lngnumber.ToString();

            // Kiểm tra số chữ số của số
            int v_ilength = v_strnumberString.Length;

            // Thêm dấu chấm nếu số chữ số là 4 hoặc nhiều hơn
            if (v_ilength >= 4)
            {
                int dotIndex = v_ilength % 3;

                if (dotIndex == 0)
                    dotIndex = 3;

                while (dotIndex < v_ilength)
                {
                    v_strnumberString = v_strnumberString.Insert(dotIndex, ".");
                    dotIndex += 4;
                    v_ilength++;
                }
            }

            //trả về chuỗi số dấu chấm.
            //ví dụ 200000000 sẽ là 200.000.000
            return v_strnumberString;
        }
    }
}
