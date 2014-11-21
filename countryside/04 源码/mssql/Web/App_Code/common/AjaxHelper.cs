using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Data;

/// <summary>
///AjaxHelper 的摘要说明
/// </summary>
public class AjaxHelper
{
	
    #region 属性

    private string action = "";

    /// <summary>
    /// ajax动作标识
    /// </summary>
    public string Action
    {
        get { return action; }
        set { action = value; }
    }
    private int pageindex = 0;

    /// <summary>
    /// 分页索引
    /// </summary>
    public int PageIndex
    {
        get { return pageindex; }
        set { pageindex = value; }
    }
    
    

    private int pageSize = 15;
    /// <summary>
    /// 分页，每页个数
    /// </summary>
    public int PageSize
    {
        get { return pageSize; }
        set { pageSize = value; }
    }
     
    private string table = "";
    /// <summary>
    /// 表名
    /// </summary>
    public string Table
    {
        get { return table; }
        set { table = value; }
    }
    
    private string table2 = "";
    /// <summary>
    /// 表名2（多表查询）
    /// </summary>
    public string Table2
    {
        get { return table2; }
        set { table2 = value; }
    }
    private string column = "";
    /// <summary>
    /// 查询获取列
    /// </summary>
    public string Column
    {
        get { return column; }
        set { column = value; }
    }

    private int totleCount = 0;
    /// <summary>
    /// 查询总记录
    /// </summary>
    public int TotleCount
    {
        get { return totleCount; }
        set { totleCount = value; }
    }

    private DataTable dtable;
    /// <summary>
    /// 查询DataTable
    /// </summary>
    public DataTable DTable
    {
        get { return dtable; }
        set { dtable = value; }
    }

    private string strWhere;
    /// <summary>
    /// 查询条件
    /// </summary>
    public string StrWhere
    {
        get { return strWhere; }
        set { strWhere = value; }
    }
    public string strOrderBy = " order by OrderValue desc,AutoID asc ";
    /// <summary>
    /// 排序值
    /// </summary>
    public string StrOrderBy
    {
        get { return strOrderBy; }
        set { strOrderBy = value; }
    }

    private string status = "";
    /// <summary>
    /// 状态
    /// </summary>
    public string Status
    {
        get { return status; }
        set { status = value; }
    }
    private string title = "";
    /// <summary>
    /// 标题
    /// </summary>
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    private string pagestatus = "";
    /// <summary>
    /// 页面状态： PageStatus="1" 主页面， PageStatus="2" 分页面
    /// </summary>
    public string PageStatus
    {
        get { return pagestatus; }
        set { pagestatus = value; }
    }

    private string extend1 = "";
    /// <summary>
    /// 扩展1
    /// </summary>
    public string Extend1
    {
        get { return extend1; }
        set { extend1 = value; }
    }

    private string extend2 = "";
    /// <summary>
    /// 扩展2
    /// </summary>
    public string Extend2
    {
        get { return extend2; }
        set { extend2 = value; }
    }
    private string extend3 = "";
    /// <summary>
    /// 扩展3
    /// </summary>
    public string Extend3
    {
        get { return extend3; }
        set { extend3 = value; }
    }

    private string extend4 = "";
    /// <summary>
    /// 扩展4
    /// </summary>
    public string Extend4
    {
        get { return extend4; }
        set { extend4 = value; }
    }

    private string extend5 = "";
    /// <summary>
    /// 扩展5
    /// </summary>
    public string Extend5
    {
        get { return extend5; }
        set { extend5 = value; }
    }
    private string extend6 = "";
    /// <summary>
    /// 扩展6
    /// </summary>
    public string Extend6
    {
        get { return extend6; }
        set { extend6 = value; }
    }
    private string extend7 = "";
    /// <summary>
    /// 扩展7
    /// </summary>
    public string Extend7
    {
        get { return extend7; }
        set { extend7 = value; }
    }
    private string extend8 = "";
    /// <summary>
    /// 扩展8
    /// </summary>
    public string Extend8
    {
        get { return extend8; }
        set { extend8 = value; }
    }
    private int autoid = 0;
    /// <summary>
    /// ID,如自增长ID
    /// </summary>
    public int AutoID
    {
        get { return autoid; }
        set { autoid = value; }
    }

    private string sautoid ="";
    /// <summary>
    /// ID,如自增长ID
    /// </summary>
    public string  SAutoID
    {
        get { return sautoid; }
        set { sautoid = value; }
    }
    #endregion

    #region 常量
    public struct Consts
    {
        /// <summary>
        /// 自增长ID
        /// </summary>
        public const string AutoID = "autoid";

        /// <summary>
        /// 自增长ID
        /// </summary>
        public const string SAutoID = "sautoid";

        /// <summary>
        /// ajax动作标识
        /// </summary>
        public const string Action = "action";

        /// <summary>
        ///  分页索引
        /// </summary>
        public const string PageIndex = "pageindex";
        /// <summary>
        /// 分页，每页个数
        /// </summary>
        public const string PageSize = "pagesize";
        /// <summary>
        /// 表名
        /// </summary>
        public const string Table = "table";
        /// <summary>
        /// 表名2
        /// </summary>
        public const string Table2 = "table2";
        /// <summary>
        /// 查询条件
        /// </summary>
        public const string StrWhere = "strwhere";
        /// <summary>
        /// 查询记录数
        /// </summary>
        public const string TotleCount = "totlecount";
        /// <summary>
        /// 查询DataTable
        /// </summary>
        public const string DTable = "dtable";
        /// <summary>
        /// 状态
        /// </summary>
        public const string Status = "status";
        /// <summary>
        ///  查询列
        /// </summary>
        public const string Column = "column";
        /// <summary>
        /// 标题
        /// </summary>
        public const string Title = "title";
        /// <summary>
        /// 页面状态
        /// </summary>
        public const string PageStatus = "pagestatus";
        /// <summary>
        /// 扩展1
        /// </summary>
        public const string Extend1 = "extend1";

        /// <summary>
        /// 扩展2
        /// </summary>
        public const string Extend2 = "extend2";
        /// <summary>
        /// 扩展3
        /// </summary>
        public const string Extend3 = "extend3";
        /// <summary>
        /// 扩展4
        /// </summary>
        public const string Extend4 = "extend4";
        /// <summary>
        /// 扩展5
        /// </summary>
        public const string Extend5 = "extend5";
        /// <summary>
        /// 扩展6
        /// </summary>
        public const string Extend6 = "extend6";
        /// <summary>
        /// 扩展7
        /// </summary>
        public const string Extend7 = "extend7";
        /// <summary>
        /// 扩展8
        /// </summary>
        public const string Extend8 = "extend8";
    }
    #endregion


    /// <summary>
    /// 获取请求参数
    /// </summary>
    /// <param name="parameters">Request 请求参数字符串</param>
    /// <returns></returns>
    public static AjaxHelper GetRequestParamters(string parameters)
    {
        string jsondata = UrlOperation.UrlDecode(parameters);
        AjaxHelper entity = GetAjaxEntityForUrlPars(jsondata);
        return entity;
    }
    public static AjaxHelper GetAjaxEntityForUrlPars(string json)
    {
        AjaxHelper entity = new AjaxHelper();
        if (UrlOperation.DecideUrlParam(json))
        {
            entity = GetAjaxEntityForUrl(json);
        }
        else
            entity = GetAjaxEntityForJson(json);
        return entity;
    }


    /// <summary>
    /// 通过param 字符串 获取Ajax Entity
    /// </summary>
    /// <param name="UrlPars"></param>
    /// <returns></returns>
    public static AjaxHelper GetAjaxEntityForUrl(string UrlPars)
    {
        AjaxHelper entity = new AjaxHelper();
        string[] arrs = StringExtension.ParseArray(UrlPars, '&');
        foreach (string str in arrs)
        {
            string[] arr = StringExtension.ParseArray(str, '=');
            string aName = arr[0].ToLower();
            string aValue = arr[1];
            switch (aName)
            {
                case AjaxHelper.Consts.Action: entity.Action = aValue; break;
                case AjaxHelper.Consts.AutoID: entity.AutoID = aValue.ToInt(0); break;
                case AjaxHelper.Consts.SAutoID: entity.SAutoID = aValue; break;
                case AjaxHelper.Consts.Title: entity.Title = aValue; break;
                case AjaxHelper.Consts.Table: entity.Table = aValue; break;
                case AjaxHelper.Consts.Table2: entity.Table2 = aValue; break;
                case AjaxHelper.Consts.PageIndex: entity.PageIndex = aValue.ToInt(0); break;
                case AjaxHelper.Consts.Status: entity.Status = aValue; break;
                case AjaxHelper.Consts.PageStatus: entity.PageStatus = aValue; break;
                case AjaxHelper.Consts.Extend1: entity.Extend1 = aValue; break;
                case AjaxHelper.Consts.Extend2: entity.Extend2 = aValue; break;
                case AjaxHelper.Consts.Extend3: entity.Extend3 = aValue; break;
                case AjaxHelper.Consts.Extend4: entity.Extend4 = aValue; break;
                case AjaxHelper.Consts.Extend5: entity.Extend5 = aValue; break;
                case AjaxHelper.Consts.Extend6: entity.Extend6 = aValue; break;
                case AjaxHelper.Consts.Extend7: entity.Extend7 = aValue; break;
                case AjaxHelper.Consts.Extend8: entity.Extend8 = aValue; break;
                default: break;
            }

        }
        return entity;
    }

    /// <summary>
    /// 通过json获取Ajax Entity
    /// </summary>
    /// <param name="UrlPars"></param>
    /// <returns></returns>
    public static AjaxHelper GetAjaxEntityForJson(string UrlPars)
    {
        AjaxHelper entity = new AjaxHelper();
        IEnumerable<JProperty> propers = JsonHelper.GetJPropertyForJsonStr(UrlPars);
        string opertype = string.Empty;
        if (propers != null)
        {
            foreach (JProperty proper in propers)
            {
                string proName = proper.Name.ToLower();
                string proValue = StringExtension.RemoveQuotation(proper.Value.ToString());
                switch (proName)
                {
                    case AjaxHelper.Consts.Action: entity.Action = proValue; break;
                    case AjaxHelper.Consts.AutoID: entity.AutoID = proValue.ToInt(0); break;
                    case AjaxHelper.Consts.SAutoID: entity.SAutoID = proValue; break;
                    case AjaxHelper.Consts.Title: entity.Title = proValue; break;
                    case AjaxHelper.Consts.Table: entity.Table = proValue; break;
                    case AjaxHelper.Consts.Table2: entity.Table2 = proValue; break;
                    case AjaxHelper.Consts.PageIndex: entity.PageIndex = proValue.ToInt(0); break;
                    case AjaxHelper.Consts.PageStatus: entity.PageStatus = proValue; break;
                    case AjaxHelper.Consts.Status: entity.Status = proValue; break;
                    case AjaxHelper.Consts.Extend1: entity.Extend1 = proValue; break;
                    case AjaxHelper.Consts.Extend2: entity.Extend2 = proValue; break;
                    case AjaxHelper.Consts.Extend3: entity.Extend3 = proValue; break;
                    case AjaxHelper.Consts.Extend4: entity.Extend4 = proValue; break;
                    case AjaxHelper.Consts.Extend5: entity.Extend5 = proValue; break;
                    case AjaxHelper.Consts.Extend6: entity.Extend6 = proValue; break;
                    case AjaxHelper.Consts.Extend7: entity.Extend7 = proValue; break;
                    case AjaxHelper.Consts.Extend8: entity.Extend8 = proValue; break;
                    default: break;
                }
            }
        }
        return entity;
    }
}