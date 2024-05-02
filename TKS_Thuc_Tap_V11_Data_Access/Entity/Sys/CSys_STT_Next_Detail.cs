﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.Sys
{
    public class CSys_STT_Next_Detail
    {
        private long m_lngAuto_ID;
        private long m_lngSTT_ID;
        private DateTime? m_dtmNgay_Giao_Dich;
        private int m_intSTT_Current;
        private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        private long m_lngChu_Hang_ID;
        private int m_intType_ID;
        private string m_strQuy_Tac_Phieu;
        private string m_strMa_Kho;
        private string m_strMa_Chu_Hang;

        public CSys_STT_Next_Detail()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_lngSTT_ID = CConst.INT_VALUE_NULL;
            m_dtmNgay_Giao_Dich = CConst.DTM_VALUE_NULL;
            m_intSTT_Current = CConst.INT_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;

            m_lngChu_Hang_ID = CConst.INT_VALUE_NULL;
            m_intType_ID = CConst.INT_VALUE_NULL;
            m_strQuy_Tac_Phieu = CConst.STR_VALUE_NULL;
            m_strMa_Kho = CConst.STR_VALUE_NULL;
            m_strMa_Chu_Hang = CConst.STR_VALUE_NULL;
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

        public long STT_ID
        {
            get
            {
                return m_lngSTT_ID;
            }
            set
            {
                m_lngSTT_ID = value;
            }
        }

        public DateTime? Ngay_Giao_Dich
        {
            get
            {
                return m_dtmNgay_Giao_Dich;
            }
            set
            {
                m_dtmNgay_Giao_Dich = value;
            }
        }

        public int STT_Current
        {
            get
            {
                return m_intSTT_Current;
            }
            set
            {
                m_intSTT_Current = value;
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

        public long Chu_Hang_ID
        {
            get
            {
                return m_lngChu_Hang_ID;
            }
            set
            {
                m_lngChu_Hang_ID = value;
            }
        }

        public int Type_ID
        {
            get
            {
                return m_intType_ID;
            }
            set
            {
                m_intType_ID = value;
            }
        }

        public string Quy_Tac_Phieu
        {
            get
            {
                return m_strQuy_Tac_Phieu;
            }
            set
            {
                m_strQuy_Tac_Phieu = value.Trim();
            }
        }

        public string Ma_Kho
        {
            get
            {
                return m_strMa_Kho;
            }
            set
            {
                m_strMa_Kho = value.Trim();
            }
        }


        public string Ma_Chu_Hang
        {
            get
            {
                return m_strMa_Chu_Hang;
            }
            set
            {
                m_strMa_Chu_Hang = value.Trim();
            }
        }
        public string Type_Text
        {
            get
            {
                string v_strRes = "";

                switch (Type_ID)
                {
                    case (int)ESTT_Next_Type_ID.Nhap: v_strRes = "Nhập"; break;
                }

                return v_strRes;
            }
        }
    }
}
