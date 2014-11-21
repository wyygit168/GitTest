using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PersistenceLayer;

/// <summary>
///TestCache 的摘要说明
/// </summary>
public class TestCache
{
    

   public static DataTable testDataTable()
   {
       string strSql = "select * from areaprovince ";
       DataTable dt= Query.ProcessSql(strSql, "countryside");

       CacheHelper.Instance.Add("testtabke", dt);
       return dt;

   }
}