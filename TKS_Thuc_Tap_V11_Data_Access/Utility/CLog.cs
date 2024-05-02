using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace TKS_Thuc_Tap_V11_Data_Access.Utility
{
    public class CLog
    {
        private string m_strUser;
        private string m_strMode;
        private string m_strObjectName;
        private string m_strFunctionName;
        private string m_strContent;
        private string m_strDate;
        private string m_strTime;

        /// <summary>
        /// Constructor
        /// </summary>
        public CLog()
        {
            m_strUser = "";
            m_strMode = "";
            m_strObjectName = "";
            m_strFunctionName = "";
            m_strContent = "";
            m_strDate = "";
            m_strTime = "";
        }

        /// <summary>
        /// UserName
        /// </summary>
        public string User
        {
            get { return m_strUser; }
            set { m_strUser = value.Trim(); }
        }

        /// <summary>
        /// Log mode: Trace; debug; error; warning; debug
        /// </summary>
        public string Mode
        {
            get { return m_strMode; }
            set { m_strMode = value.Trim(); }
        }

        /// <summary>
        /// Object Name
        /// </summary>
        public string ObjectName
        {
            get { return m_strObjectName; }
            set { m_strObjectName = value.Trim(); }
        }

        /// <summary>
        /// Function Name
        /// </summary>
        public string FunctionName
        {
            get { return m_strFunctionName; }
            set { m_strFunctionName = value.Trim(); }
        }

        /// <summary>
        /// Log Content
        /// </summary>
        public string Content
        {
            get { return m_strContent; }
            set { m_strContent = value.Trim(); }
        }

        /// <summary>
        /// Date
        /// </summary>
        public string Date
        {
            get { return m_strDate; }
            set { m_strDate = value.Trim(); }
        }

        /// <summary>
        /// Time
        /// </summary>
        public string Time
        {
            get { return m_strTime; }
            set { m_strTime = value.Trim(); }
        }

        /// <summary>
        /// Write object to file as Text Format
        /// </summary>
        /// <param name="tw">StreamWriter</param>
        public void WriteTextFile(TextWriter tw)
        {
            string strLog = "";

            strLog = User + "|" + Mode + "|" + ObjectName + "|" + FunctionName + "|" + Date
                + "|" + Time + "|" + Content;

            tw.WriteLine(strLog);
        }

        /// <summary>
        /// Write object to file as format XML
        /// </summary>
        /// <param name="tw">StreamWriter</param>
        public void WriteXmlFile(TextWriter tw)
        {
            XmlSerializer xml = new XmlSerializer(this.GetType());
            xml.Serialize(tw, this);
        }
    }
}
