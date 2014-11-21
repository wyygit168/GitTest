using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

/// <summary>
///操作文本文件（包括读写）
/// </summary>
public class OperateTxt
{

    private static object objLock = new object();

    #region 用户权限缓存txt文件

    #region 获取用户权限缓存datable的txt文件路径
    /// <summary>
    /// 获取用户权限缓存datable的txt文件路径
    /// </summary>
    /// <param name="customerid">客户id</param>
    /// <param name="id">获取用户权限缓存datable的txt文件路径</param>
    /// <param name="cachetype">缓存类型</param>
    /// <returns></returns>
    public static string GetPurviewFilePath(int customerid,int id,string cachetype)
    {
        string onefolder=CommonMethod.GetConfigValueByKey("Folder");
        HttpServerUtility hsu= HttpContext.Current.Server;
        string formatpath = string.Format("{0}cache/{2}/{1}/", onefolder, customerid,cachetype);
        string physicspath = hsu.MapPath("~" + formatpath); //物理路径
        DirectoryInfo di = new DirectoryInfo(physicspath);
        if (!di.Exists)
        {
            di.Create();
        }
        string physicsfilename = string.Format("{0}{1}.txt",physicspath,id);
        //lock (objLock)
        //{
        //    FileInfo f = new FileInfo(physicsfilename);
        //    if (!f.Exists)
        //    {
        //        f.Create();
        //    }
        //}
        return physicsfilename;
    }

 

    /// <summary>
    /// 删除权限缓存文件夹
    /// </summary>
    /// <param name="customerid">客户id</param>
    public static void DelPurviewFilePath(int customerid,string cachetype)
    {
        string onefolder = CommonMethod.GetConfigValueByKey("Folder");
        HttpServerUtility hsu = HttpContext.Current.Server;
        string formatpath = string.Format("{0}cache/{2}/{1}/", onefolder, customerid, cachetype);
        string physicspath = hsu.MapPath("~" + formatpath); //物理路径
        DirectoryInfo di = new DirectoryInfo(physicspath);
        if (di.Exists)
        {
            di.Delete(true);
        }
    }

    /// <summary>
    /// 删除权限缓存文件
    /// </summary>
    /// <param name="customerid">客户id</param>
    /// <param name="id">用户id，或者角色id</param>
    /// <param name="type">类型</param>
    public static void DelPurviewFile(int customerid, int id,string cachetype)
    {
        string onefolder = CommonMethod.GetConfigValueByKey("Folder");
        HttpServerUtility hsu = HttpContext.Current.Server;
        string formatpath = string.Format("{0}cache/{3}/{1}/{2}.txt", onefolder, customerid, id, cachetype);
        string physicspath = hsu.MapPath("~" + formatpath); //物理路径
        FileInfo fi = new FileInfo(physicspath);
        if (fi.Exists)
        {
            fi.Delete();
        }
    }
    #endregion

    #region 写入：用户权限缓存datable的txt文件

    /// <summary>
    /// 写入：用户权限缓存datable的txt文件
    /// </summary>
    /// <param name="content">代写入内容</param>
    /// <param name="customerid">客户id</param>
    /// <param name="id">用户id，或者角色id</param>
    /// <param name="cachetype">缓存类型</param>
    public static void WritePurviewFile(string content, int customerid, int id, string cachetype)
    {
        if (content.Length == 0)
            return; 
        StreamWriter sw = null;
        lock (objLock)
        {
            try
            {
                string strfilename = GetPurviewFilePath(customerid, id, cachetype);
                FileInfo fi = new FileInfo(strfilename);
                if (fi.Exists)
                {
                    sw = new StreamWriter(strfilename, false, Encoding.UTF8);
                    sw.Write(content);
                }
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }

    #endregion

    #region 读取：用户权限缓存datable的txt文件内容

    /// <summary>
    /// 读取：用户权限缓存datable的txt文件内容
    /// </summary>
     /// <param name="customerid">客户id</param>
    /// <param name="id">用户id或者角色id</param>
    /// <param name="cachetype">缓存类型</param>
    public static string ReadPurviewFile( int customerid, int id,string cachetype)
    {
        string readstring="";
        StreamReader sr = null;
        FileStream fs = null;
        lock (objLock)
        {
            try
            {
                //string purviewcache = CommonMethod.GetConfigValueByKey("purviewcache");
                string strfilename = GetPurviewFilePath(customerid, id, cachetype);
                //sr = new StreamReader(strfilename, Encoding.UTF8, false);
                fs = new FileStream(strfilename, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
                sr = new StreamReader(fs, System.Text.Encoding.UTF8);
                readstring = sr.ReadToEnd();
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
        return readstring;
    }

    #endregion

    #endregion

    #region 根据Url一级域名获取客户信息的缓存txt文件：如客户id 所属省、市、县、镇

    #region 根据Url一级域名获取客户信息缓存datable的txt文件路径
    /// <summary>
    /// 根据Url一级域名获取客户信息缓存datable的txt文件路径
    /// </summary>
    /// <param name="url">一级域名</param>
    /// <param name="cachetype">缓存类型</param>
    /// <returns></returns>
    public static string GetUrlFilePath(string url, string cachetype)
    {
        string onefolder = CommonMethod.GetConfigValueByKey("Folder");
        HttpServerUtility hsu = HttpContext.Current.Server;
        string formatpath = string.Format("{0}cache/webcache/{1}/", onefolder, cachetype);
        string physicspath = hsu.MapPath("~" + formatpath); //物理路径
        DirectoryInfo di = new DirectoryInfo(physicspath);
        if (!di.Exists)
        {
            di.Create();
        }
        string physicsfilename = string.Format("{0}{1}.txt", physicspath, url);
      
        return physicsfilename;
    }



    /// <summary>
    /// 删除客户信息缓存文件夹
    /// </summary>
    /// <param name="url">url</param>
    public static void DelUrlFilePath(string url, string cachetype)
    {
        string onefolder = CommonMethod.GetConfigValueByKey("Folder");
        HttpServerUtility hsu = HttpContext.Current.Server;
        string formatpath = string.Format("{0}cache/webcache/{1}/", onefolder, cachetype);
        string physicspath = hsu.MapPath("~" + formatpath); //物理路径
        DirectoryInfo di = new DirectoryInfo(physicspath);
        if (di.Exists)
        {
            di.Delete(true);
        }
    }

    /// <summary>
    /// 删除客户信息缓存文件
    /// </summary>
    /// <param name="url">url</param>
    /// <param name="cachetype">类型</param>
    public static void DelUrlFile(string url, string cachetype)
    {
        string onefolder = CommonMethod.GetConfigValueByKey("Folder");
        HttpServerUtility hsu = HttpContext.Current.Server;
        string formatpath = string.Format("{0}cache/webcache/{1}/{2}.txt", onefolder, cachetype, url);
        string physicspath = hsu.MapPath("~" + formatpath); //物理路径
        FileInfo fi = new FileInfo(physicspath);
        if (fi.Exists)
        {
            fi.Delete();
        }
    }
    #endregion

    #region 写入：客户信息缓存datable的txt文件

    /// <summary>
    /// 写入：客户信息缓存datable的txt文件
    /// </summary>
    /// <param name="content">代写入内容</param>
    /// <param name="url">url</param>
    /// <param name="cachetype">缓存类型</param>
    public static void WriteUrlFile(string content, string url,string cachetype)
    {
        if (content.Length == 0)
            return;
        StreamWriter sw = null;
        lock (objLock)
        {
            try
            {
                string strfilename = GetUrlFilePath(url, cachetype);
                FileInfo fi = new FileInfo(strfilename);
                if (fi.Exists)
                {
                    sw = new StreamWriter(strfilename, false, Encoding.UTF8);
                    sw.Write(content);
                }
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }

    #endregion

    #region 读取：客户信息缓存datable的txt文件datable的txt文件内容

    /// <summary>
    /// 读取：客户信息缓存datable的txt文件内容
    /// </summary>
    /// <param name="url">url</param>
    /// <param name="cachetype">缓存类型</param>
    public static string ReadUrlFile(string url, string cachetype)
    {
        string readstring = "";
        StreamReader sr = null;
        FileStream fs = null;
        lock (objLock)
        {
            try
            {
                string strfilename = GetUrlFilePath(url, cachetype);
                fs = new FileStream(strfilename, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
                sr = new StreamReader(fs, System.Text.Encoding.UTF8);
                readstring = sr.ReadToEnd();
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
        return readstring;
    }

    #endregion

    #endregion

    #region FarmingNews缓存

    #region  FarmingNews缓存
    /// <summary>
    ///  FarmingNews缓存datable的txt文件路径
    /// </summary>
    /// <param name="cachetype">缓存类型</param>
    /// <returns></returns>
    public static string GetFarmingNewsFilePath(int customerid,string cachetype)
    {
        string onefolder = CommonMethod.GetConfigValueByKey("Folder");
        HttpServerUtility hsu = HttpContext.Current.Server;
        string formatpath = string.Format("{0}cache/webcache/{1}/", onefolder, cachetype);
        string physicspath = hsu.MapPath("~" + formatpath); //物理路径
        DirectoryInfo di = new DirectoryInfo(physicspath);
        if (!di.Exists)
        {
            di.Create();
        }
        string physicsfilename = string.Format("{0}{1}.txt", physicspath, customerid);

        return physicsfilename;
    }



    /// <summary>
    /// 删除客户信息缓存文件夹
    /// </summary>
    /// <param name="url">url</param>
    public static void DelFarmingnewsFilePath( string cachetype)
    {
        string onefolder = CommonMethod.GetConfigValueByKey("Folder");
        HttpServerUtility hsu = HttpContext.Current.Server;
        string formatpath = string.Format("{0}cache/webcache/{1}/", onefolder, cachetype);
        string physicspath = hsu.MapPath("~" + formatpath); //物理路径
        DirectoryInfo di = new DirectoryInfo(physicspath);
        if (di.Exists)
        {
            di.Delete(true);
        }
    }

    /// <summary>
    /// 删除客户信息缓存文件
    /// </summary>
    
    /// <param name="cachetype">类型</param>
    public static void DelFarmingnewsFile(int customerid, string cachetype)
    {
        string onefolder = CommonMethod.GetConfigValueByKey("Folder");
        HttpServerUtility hsu = HttpContext.Current.Server;
        string formatpath = string.Format("{0}cache/webcache/{2}/{1}.txt", onefolder, customerid, cachetype);
        string physicspath = hsu.MapPath("~" + formatpath); //物理路径
        FileInfo fi = new FileInfo(physicspath);
        if (fi.Exists)
        {
            fi.Delete();
        }
    }
    #endregion

    #region 写入：客户信息缓存datable的txt文件

    /// <summary>
    /// 写入：客户信息缓存datable的txt文件
    /// </summary>
    /// <param name="content">代写入内容</param>
    /// <param name="url">url</param>
    /// <param name="cachetype">缓存类型</param>
    public static void WriteFramingnewsFile(string content, int customerid, string cachetype)
    {
        if (content.Length == 0)
            return;
        StreamWriter sw = null;
        lock (objLock)
        {
            try
            {
                string strfilename = GetFarmingNewsFilePath(customerid, cachetype);
                FileInfo fi = new FileInfo(strfilename);
                if (fi.Exists)
                {
                    sw = new StreamWriter(strfilename, false, Encoding.UTF8);
                    sw.Write(content);
                }
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }
    }

    #endregion

    #region 读取：客户信息缓存datable的txt文件datable的txt文件内容

    /// <summary>
    /// 读取：客户信息缓存datable的txt文件内容
    /// </summary>
    /// <param name="url">url</param>
    /// <param name="cachetype">缓存类型</param>
    public static string ReadFarmingnewFile(int customerid, string cachetype)
    {
        string readstring = "";
        StreamReader sr = null;
        FileStream fs = null;
        lock (objLock)
        {
            try
            {
                string strfilename = GetFarmingNewsFilePath(customerid, cachetype);
                fs = new FileStream(strfilename, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
                sr = new StreamReader(fs, System.Text.Encoding.UTF8);
                readstring = sr.ReadToEnd();
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
        return readstring;
    }

    #endregion

    #endregion

}