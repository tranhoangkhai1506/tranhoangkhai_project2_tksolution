using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
    public class CNumberToEnglish
    {
        private static string[] m_arr_onesMapping =
            new string[] {
            "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
            "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };
        private static string[] m_arr_tensMapping =
            new string[] {
            "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };
        private static string[] m_arr_groupMapping =
            new string[] {
            "Hundred", "Thousand", "Million", "Billion", "Trillion"
        };

        public string EnglishFromNumber(string p_strNumber)
        {
            return EnglishFromNumber(long.Parse(p_strNumber));
        }

        //sử dụng hàm này để convert từ number sang chữ số:
        public string EnglishFromNumber(long number)
        {
            if (number == 0)
            {
                return m_arr_onesMapping[number];
            }

            string sign = "";
            if (number < 0)
            {
                sign = "Negative";
                number = Math.Abs(number);
            }

            string retVal = null;
            int group = 0;
            while (number > 0)
            {
                int numberToProcess = (int)(number % 1000);
                number = number / 1000;

                string groupDescription = ProcessGroup(numberToProcess);
                if (groupDescription != null)
                {
                    if (group > 0)
                    {
                        retVal = m_arr_groupMapping[group] + " " + retVal;
                    }
                    retVal = groupDescription + " " + retVal;
                }

                group++;
            }

            return sign + " " + retVal;
        }

        private static string ProcessGroup(int number)
        {
            int tens = number % 100;
            int hundreds = number / 100;

            string retVal = null;
            if (hundreds > 0)
            {
                retVal = m_arr_onesMapping[hundreds] + " " + m_arr_groupMapping[0];
            }
            if (tens > 0)
            {
                if (tens < 20)
                {
                    retVal += ((retVal != null) ? " " : "") + m_arr_onesMapping[tens];
                }
                else
                {
                    int ones = tens % 10;
                    tens = (tens / 10) - 2; // 20's offset

                    retVal += ((retVal != null) ? " " : "") + m_arr_tensMapping[tens];

                    if (ones > 0)
                    {
                        retVal += ((retVal != null) ? " " : "") + m_arr_onesMapping[ones];
                    }
                }
            }

            return retVal;
        }
    }
}
