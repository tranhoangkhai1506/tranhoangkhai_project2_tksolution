/*----------------------------------------------------------*
 * Create Date  : 08/04/2006
 * Author       : Phạm Văn Tiên
 * Group        : K6Planet
 * ---------------------------------------------------------*/

using System;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
    /// <summary>
    /// Number Class
    /// </summary>
    public class CNumber
    {
        private string[] m_arrHundredOf = new string[10]{"không","một","hai","ba","bốn","năm","sáu",
                                                            "bảy","tám","chín"};
        private string[] m_arrTensOf = new string[10]{"lẻ","mười","hai mươi","ba mươi","bốn mươi","năm mươi",
                                                         "sáu mươi", "bảy mươi","tám mươi","chín mươi"};

        private string[] m_arrUnit = new string[10] {"","mốt","hai","ba","bốn","lăm","sáu",
                                                        "bảy","tám","chín"};

        private string[] m_arrUnitName = new string[4] { "đơn vị", "nghìn", "triệu", "tỷ" };

        /// <summary>
        /// Lấy tên của 1 số
        /// </summary>
        /// <param name="num">ký tự Số</param>
        /// <param name="pos">vị trí (3: trăm, 2: chục, 1: đơn vị</param>
        /// <param name="specify">cho biết đây có phải là dạng đọc đặc biệt không</param>
        /// <returns></returns>
        private string GetNumberName(char num, int pos, bool specify)
        {
            string strResult = "";
            switch (pos)
            {
                case 3: strResult = m_arrHundredOf[num - 48] + " trăm"; break;
                case 2: strResult = m_arrTensOf[num - 48]; break;
                case 1:
                    strResult = m_arrUnit[num - 48];
                    if (num == '5')
                    {
                        if (specify)
                            strResult = "năm";
                    }

                    if (num == '1')
                    {
                        if (specify)
                            strResult = "một";
                    }
                    break;

            }
            return strResult;
        }

        /// <summary>
        /// Đọc từng phần của chuỗi
        /// </summary>
        /// <param name="p_strNum">chuỗi số (tối đa 3 số)</param>
        /// <param name="specify">Cho biết là có đọc dạng đặc biệt ko</param>
        /// <returns>string</returns>
        private string ReadPart(string p_strNum, bool specify)
        {
            if ((p_strNum == "") || (int.Parse(p_strNum) == 0))
                return "";
            return GetNumberName(p_strNum[0], p_strNum.Length, specify) + " " + ReadPart(p_strNum.Remove(0, 1), specify);
        }

        /// <summary>
        /// Đọc 1 số nguyên
        /// </summary>
        /// <param name="p_strNumber">Số cần đọc</param>
        /// <param name="p_strUnitName">Đơn vị</param>
        /// <returns>string</returns>
        public string ReadInt(string p_strNumber, string p_strUnitName)
        {
            // Check strNum
            for (int i = 0; i < p_strNumber.Length; i++)
                if (p_strNumber[i] < 48 || p_strNumber[i] > 57)
                    return "Chuỗi số không hợp lệ.";
            //
            m_arrUnitName[0] = p_strUnitName;
            string strTemp, strResult = "", strPartNum = "";
            bool specify = false;
            int count = -1, l = 0;

            // Delete '0' as 0 position
            while (p_strNumber.Length > 0 && p_strNumber[0] == '0')
                p_strNumber = p_strNumber.Remove(0, 1);

            // if (strNum is "") then return "khong strUnitName
            if (p_strNumber == "")
                return "Không " + m_arrUnitName[0];

            // Read
            while (p_strNumber.Length > 0)
            {
                // if strSource then get from right to left 3 char else get from to left l char
                l = p_strNumber.Length;
                if (l >= 3)
                    l = 3;
                // increment unitname
                count++;
                // Get l char rom right to left and read it
                strPartNum = p_strNumber.Substring(p_strNumber.Length - l, l);
                if ((strPartNum == "5") || (strPartNum == "1"))
                    specify = true;

                if ((l >= 2) && (strPartNum[l - 1] == '1') && ((strPartNum[l - 2] == '1') || (strPartNum[l - 2] == '0')))
                    specify = true;

                if ((l >= 2) && (strPartNum[l - 1] == '5') && (strPartNum[l - 2] == '0'))
                    specify = true;

                strTemp = ReadPart(strPartNum, specify);

                // Add unit name to read string
                if (strTemp != "" || count == 0)
                {
                    if (count != 0 && count % 3 == 0)
                        strTemp = strTemp + m_arrUnitName[count % 3 + 3] + " ";
                    else
                        strTemp = strTemp + m_arrUnitName[count % 3] + " ";
                }

                else
                {
                    if (count % 3 == 0)
                        strTemp = strTemp + m_arrUnitName[count % 3 + 3] + " ";
                }
                //
                strResult = strTemp + strResult;

                p_strNumber = p_strNumber.Remove(p_strNumber.Length - l, l);
                specify = false;
            }

            char c = char.ToUpper(strResult[0]);
            strResult = c + strResult.Remove(0, 1);
            return strResult;
        }

        /// <summary>
        /// Check is a string is unsigned integer
        /// </summary>
        /// <param name="p_strNumber">Number</param>
        /// <returns>bool</returns>
        public bool IsUnsignedInt(string p_strNumber)
        {
            bool blnResult = true;

            p_strNumber = p_strNumber.Trim();
            for (int i = 0; i < p_strNumber.Length; i++)
                if ((p_strNumber[i] < '0') || (p_strNumber[i] > '9'))
                {
                    blnResult = false;
                    break;
                }
            
            return blnResult;
        }
    }
}
