using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using PersistenceLayer;

/// <summary>
///文件缓存操作类
/// </summary>
public class UtilityCacheFile
{

    #region 缓存datatable通过文件的方式

    /// <summary>
    /// 获取文件缓存datable的txt文件路径
    /// </summary>
    /// <param name="customerid">客户id</param>
    /// <returns></returns>
    public static string GetCacheFilePath(int customerid)
    {
        string onefolder = CommonMethod.GetConfigValueByKey("Folder");
        HttpServerUtility hsu = HttpContext.Current.Server;
        string formatpath = string.Format("{0}FileCache/DtCache/{1}/", onefolder, customerid);
        string physicspath = hsu.MapPath("~" + formatpath); //物理路径
        DirectoryInfo di = new DirectoryInfo(physicspath);
        if (!di.Exists)
        {
            di.Create();
        }
        string physicsfilename = string.Format("{0}.txt", physicspath);

        return physicsfilename;
    }


   
    /// <summary>
    /// 缓存datatable通过文件的方式
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="cacheFilePath"></param>
    /// <param name="cacheTime"></param>
    /// <param name="dataBase"></param>
    /// <returns></returns>
    public static DataTable CacheDataTableByFile(int customeid, string sql,  int cacheTime)
    {

        string physicsfilename = GetCacheFilePath(customeid);
        DataTable dt = new DataTable();
        Stream s = null;
        try
        {
            long len = 0;
            bool isNotcache = false;
            if (File.Exists(physicsfilename))
            {
                FileInfo FSize = new FileInfo(physicsfilename);
                len = FSize.Length;
            }
            if (len > 0)
            {
                DateTime date = File.GetLastWriteTime(physicsfilename);
                if (date.AddMinutes(cacheTime).CompareTo(DateTime.Now) == -1)//缓存过期
                {
                    isNotcache = true;
                }
                else
                {
                    s = File.Open(physicsfilename, FileMode.Open, FileAccess.Read);
                    BinaryFormatter b = new BinaryFormatter();
                    dt = (DataTable)b.Deserialize(s);
                    s.Close();
                }
            }
            else
            {
                isNotcache = true;
            }
            if (isNotcache)
            {
                dt = Query.ProcessSql(sql, DataHelper.DataBase);
                s = File.Open(physicsfilename, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, dt);
                s.Close();
            }
            return dt;
        }
        catch (Exception ex)
        {
            return null;
        }
        finally
        {
            if (s != null)
                s.Close();
        }
    }
    #endregion

}