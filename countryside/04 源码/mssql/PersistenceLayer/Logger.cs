using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Web;

namespace PersistenceLayer
{
    public static class Logger
    {
        private static bool bSwitch = false;
        private static object objLock = new object();
        public static void Write(string LogContent)
        {

            if (!bSwitch || LogContent.Length==0)
                return;

            HttpServerUtility hsu = HttpContext.Current.Server;
            string strPath = hsu.MapPath("~/Uploads/SqlLog/");
            
            StreamWriter sw = null;
            lock (objLock)
            {
                try
                {
                    string strFileName = strPath + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                    sw = new StreamWriter(strFileName, true, Encoding.UTF8);
                    if (LogContent == System.Environment.NewLine)
                        sw.WriteLine(System.Environment.NewLine);
                    else
                        sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\r\n-------------------\r\n" + LogContent);
                    sw.Write("\r\n");
                    sw.Close();
                }                 
                finally
                {
                    if (sw != null)
                        sw.Close();
                }
            }

        }

        public static void Write(string logPath, string LogContent)
        {

            if (!bSwitch || LogContent.Length == 0)
                return;
            StreamWriter sw = null;
            lock (objLock)
            {
                try
                {
                    string strFileName = logPath + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                    sw = new StreamWriter(strFileName, true, Encoding.UTF8);
                    if (LogContent == System.Environment.NewLine)
                        sw.WriteLine(System.Environment.NewLine);
                    else
                        sw.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\r\n-------------------\r\n" + LogContent);
                    sw.Write("\r\n");
                    sw.Close();
                } 
                finally
                {
                    if (sw != null)
                        sw.Close();
                }
            }

        }
        /// <summary>
        /// ��д��־����
        /// </summary>
        public static void OpenWriteLog()
        {
            bSwitch = true;
        }

        /// <summary>
        /// �ر�д��־����
        /// </summary>
        public static void CloseWriteLog()
        {
            bSwitch = false;
        }
    }
}
