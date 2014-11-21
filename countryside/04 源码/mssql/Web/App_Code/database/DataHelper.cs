using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PersistenceLayer;
using System.Text;

/// <summary>
///DataHelper 的摘要说明
/// </summary>
public class DataHelper
{
    public static readonly string DataBase = CommonMethod.GetConfigValueByKey("DataBase");
 
    #region  单表查询分页
    /// <summary>
    /// 单表查询分页
    /// </summary>
    /// <param name="table">表名</param>
    /// <param name="column">返回列</param>
    /// <param name="where">查询条件</param>
    /// <param name="pageIndex">当前页的索引</param>
    /// <param name="pageSize">每页显示的个数</param>
    /// <param name="totleCount">总数</param>
    /// <returns></returns>
    public static DataTable SinglePaginationSearch(string table, string column, string where, int pageIndex, int pageSize, out int totleCount)
    {
        int nMinId = pageIndex * pageSize;	//分页最小ID
        int nMaxId = ((pageIndex + 1) * pageSize) + 1;  //分页最大ID
        string sql = string.Format(@"DECLARE @indextable table(tid int identity(1,1) PRIMARY KEY,nid nvarchar(38));
                        INSERT INTO @indextable(nid) SELECT AutoID from {2} WITH (nolock) Where 1=1 {3};
                        SELECT recrowcount=@@ROWCOUNT;
                        SELECT {4}  FROM @indextable as t0 INNER JOIN {2} as h WITH (nolock) 
                        ON (t0.nid = h.AutoID AND t0.tid > {0} AND t0.tid < {1})  ORDER BY t0.tid
                        ", nMinId, nMaxId, table, where, column);
        DataSet ds = Query.ProcessMultiSql(sql, DataBase);
        totleCount = (int)ds.Tables[0].Rows[0][0];
        return ds.Tables[1];
    }


    public static AjaxHelper SinglePaginationSearch(AjaxHelper ajaxHelper)
    {
        int nMinId = (ajaxHelper.PageIndex) * (ajaxHelper.PageSize);	//分页最小ID
        int nMaxId = ((ajaxHelper.PageIndex + 1) * (ajaxHelper.PageSize)) + 1;  //分页最大ID
        string sql = string.Format(@"DECLARE @indextable table(tid int identity(1,1) PRIMARY KEY,nid nvarchar(38));
                        INSERT INTO @indextable(nid) SELECT AutoID from {2} WITH (nolock) Where 1=1 {3} {4};
                        SELECT recrowcount=@@ROWCOUNT;
                        SELECT {5}  FROM @indextable as t0 INNER JOIN {2} as h WITH (nolock) 
                        ON (t0.nid = h.AutoID AND t0.tid > {0} AND t0.tid < {1})  ORDER BY t0.tid
                        ", nMinId, nMaxId, ajaxHelper.Table, ajaxHelper.StrWhere,ajaxHelper.StrOrderBy,ajaxHelper.Column);
        DataSet ds = Query.ProcessMultiSql(sql, DataBase);
        ajaxHelper.TotleCount = (int)ds.Tables[0].Rows[0][0];
        ajaxHelper.DTable = ds.Tables[1];
        return ajaxHelper;
    }

    #endregion

    #region  多表查询分页
    /// <summary>
    /// 多表查询分页
    /// </summary>
    /// <param name="table">表名（多表）</param>
    /// <param name="column">返回列</param>
    /// <param name="where">查询条件</param>
    /// <param name="pageIndex">当前页的索引</param>
    /// <param name="pageSize">每页显示的个数</param>
    /// <param name="totleCount">总数</param>
   /// <returns></returns>
    public static DataTable MultiPaginationSearch(string table,string table2, string column, string where, int pageIndex, int pageSize, out int totleCount)
    {
        int nMinId = pageIndex * pageSize;	//分页最小ID
        int nMaxId = ((pageIndex + 1) * pageSize) + 1;  //分页最大ID
        string sql = string.Format(@"DECLARE @indextable table(tid int identity(1,1) PRIMARY KEY,nid nvarchar(38));
                        INSERT INTO @indextable(nid) SELECT h.AutoID from {2} {5} {3};
                        SELECT recrowcount=@@ROWCOUNT;
                        SELECT {4}  FROM @indextable as t0 INNER JOIN {2}  
                        ON (t0.nid = h.AutoID) {5} AND t0.tid > {0} AND t0.tid < {1}   ORDER BY t0.tid
                        ", nMinId, nMaxId, table, where,column,table2);
        DataSet ds = Query.ProcessMultiSql(sql, DataBase);
        totleCount = (int)ds.Tables[0].Rows[0][0];
        return ds.Tables[1];
    }

    /// <summary>
    /// 多表查询分页
    /// </summary>
    /// <param name="table">表名（多表）</param>
    /// <param name="column">返回列</param>
    /// <param name="where">查询条件</param>
    /// <param name="pageIndex">当前页的索引</param>
    /// <param name="pageSize">每页显示的个数</param>
    /// <param name="totleCount">总数</param>
    /// <returns></returns>
    public static AjaxHelper MultiPaginationSearch(AjaxHelper ajaxHelper)
    {
        
        int nMinId = (ajaxHelper.PageIndex) * (ajaxHelper.PageSize);	//分页最小ID
        int nMaxId = ((ajaxHelper.PageIndex + 1) * (ajaxHelper.PageSize)) + 1;  //分页最大ID

        string sql = string.Format(@"DECLARE @indextable table(tid int identity(1,1) PRIMARY KEY,nid nvarchar(38));
                        INSERT INTO @indextable(nid) SELECT h.AutoID from {2} {6} {3} {5};
                        SELECT recrowcount=@@ROWCOUNT;
                        SELECT {4}  FROM @indextable as t0 INNER JOIN {2}  
                        ON (t0.nid = h.AutoID) {6}  AND t0.tid > {0} AND t0.tid < {1}   ORDER BY t0.tid
                        ", nMinId, nMaxId, ajaxHelper.Table,  ajaxHelper.StrWhere,ajaxHelper.Column,ajaxHelper.StrOrderBy,ajaxHelper.Table2);
        DataSet ds = Query.ProcessMultiSql(sql, DataBase);
        ajaxHelper.TotleCount = ds.Tables[0].Rows[0][0].ToInt(0);
        ajaxHelper.DTable = ds.Tables[1];
        return ajaxHelper;
    }

    
    #endregion

    #region 拼装分页

    /// <summary>
    ///  拼装分页 
    /// </summary>
    /// <param name="pageSize">每页的页数</param>
    /// <param name="recordCount">总记录</param>
    /// <param name="pageIndex">页索引</param>
    /// <returns></returns>
    public static string SetPagination(int pageSize, int recordCount, int pageIndex)
    {
        string firstPageText = "首页";
        string endPageText = "尾页";
        string cmdPreviousText = "上一页";
        string CmdNextText = "下一页";

        int showPageIndexCount = 11; //显示的分页个数

        int pageCount = (recordCount % pageSize == 0 ? (recordCount / pageSize) : (int)Math.Ceiling(recordCount * 1.0M / pageSize));
        if (showPageIndexCount < 5)
        {
            showPageIndexCount = 11; //显示的个数，默认是11个
        }
        else if (showPageIndexCount > 18)
        {
            showPageIndexCount = 11; //显示的个数，默认是11个
        }

        StringBuilder sbPageStr = new StringBuilder();

        int pageStart = 0;
        if (pageIndex > 5)
            pageStart = pageIndex - 5;
        int pageEnd = pageStart + showPageIndexCount;

        if (pageIndex > 0)
            sbPageStr.AppendFormat("<a href=\"###\" title=\"{0}\" onclick=\"setpagination(0);\">{0}</a> ", firstPageText, 0);

        if (pageIndex > 0)
            sbPageStr.AppendFormat("<a href=\"###\" title=\"{0}\" onclick=\"setpagination({1});\">{0}</a> ", cmdPreviousText, pageIndex - 1);

        if (pageStart > 0)
            sbPageStr.AppendFormat("<a href=\"###\" onclick=\"setpagination({0});\">...</a> ", pageStart - 1);

        for (int i = 0; i < pageCount; i++)
        {
            if (i >= pageStart && i < pageEnd)
            {
                if (pageIndex != i)
                    sbPageStr.AppendFormat("<a class=\"pagelistnormal\" href=\"###\" onclick=\"setpagination({1});\" title=\"转到第{0}页\">{0}</a> ", i + 1, i);
                else
                    sbPageStr.AppendFormat("<strong class=\"pagelistselected\">{0}</strong> ", i + 1);
            }
        }

        if (pageEnd < pageCount)
            sbPageStr.AppendFormat("<a href=\"###\" onclick=\"setpagination({0});\">...</a> ", pageEnd);

        if (pageIndex < pageCount - 1)
            sbPageStr.AppendFormat("<a href=\"###\" onclick=\"setpagination({1});\" title=\"{0}\">{0}</a> ", CmdNextText, pageIndex + 1);

        if (pageIndex < pageCount - 1)
            sbPageStr.AppendFormat("<a href=\"###\" onclick=\"setpagination({1});\" title=\"{0}\">{0}</a> ", endPageText, pageCount - 1);

        string result = "共" + pageCount.ToString() + "页&nbsp;" + recordCount.ToString() + "条记录";
        return sbPageStr.ToString() + result;
    }

    #endregion
}