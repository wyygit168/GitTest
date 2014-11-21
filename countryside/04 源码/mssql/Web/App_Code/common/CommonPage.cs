using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Data;

/// <summary>
///CommonPage 的摘要说明
/// </summary>
public class CommonPage : System.Web.UI.Page
{
    #region 根据url 获取客户登陆信息Datable，如果为Null，即无权限。如果不为Null，获取客户id，省 市 县等信息
    /// <summary>
    /// 根据url 获取客户登陆信息Datable，如果为Null，即无权限。如果不为Null，获取客户id，省 市 县等信息
    /// </summary>
    public DataTable GetDatablePriviewForUrl()
    {
        DataTable dt = null;
        string cachepath = CommonMethod.GetConfigValueByKey("DTWC");//权限路径
        string cachename = CurrentDomainNoHttp.Replace(".", "").Replace(":", "");//该权限的权限名称
         dt = CacheHelper.Instance.GetData(cachename) as DataTable;
        if (dt == null)
        {
            string dtJson = OperateTxt.ReadUrlFile(CurrentDomainNoHttp.Replace(":",""), cachepath);
            string decdtJson = "";
            if (dtJson.Length > 0)
            {
                decdtJson = DESEncrypt.Decrypt(dtJson);
            }
            DataSet ds = JsonHelper.Deserialize<DataSet>(decdtJson);
            if (ds != null && ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
                CacheHelper.Instance.Add(cachename, dt);
            }
            else
            {
                ds = UtilitySearch.GetLoginPriviewForUrl(CurrentDomainNoHttp);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    dtJson = JsonHelper.JsonFromDataTable(dt);
                    string enctJson = DESEncrypt.Encrypt(dtJson); //加密
                    OperateTxt.WriteUrlFile(enctJson, CurrentDomainNoHttp.Replace(":", ""), cachepath);
                    CacheHelper.Instance.Add(cachename, dt);
                }
            }
        }
        return dt;
    }
    #endregion

    

    #region Meta,Script,Css 标签

    #region 加载Meta
    /// <summary>
    /// 加载Meta
    /// </summary>
    protected void GenerateMeta(string httpequive, string name, string content, string charset, int index)
    {
        HtmlMeta meta = new HtmlMeta();
        if (httpequive.Length > 0)
            meta.HttpEquiv = httpequive;
        if (name.Length > 0)
            meta.Name = name;
        if (charset.Length > 0)
            meta.Attributes["charset"] = charset;
        meta.Content = content;
        Header.Controls.AddAt(index, meta);
    }
    #endregion

    #region 加载JS
    /// <summary>
    /// 加载JS
    /// </summary>
    /// <param name="src"></param>
    /// <param name="index"></param>
    protected void GenerateScript(string src, int index)
    {
        HtmlGenericControl script = new HtmlGenericControl("script");
        script.Attributes["type"] = "text/javascript";
        script.Attributes["language"] = "javascript";
        script.Attributes["src"] = src;
        Header.Controls.AddAt(index, script);
    }
    #endregion

    #region 加载css
    /// <summary>
    ///加载css 
    /// </summary>
    /// <param name="src"></param>
    /// <param name="index"></param>
    protected void GenerateCss(string src, int index)
    {
        HtmlLink css = new HtmlLink();
        css.Attributes["type"] = "text/css";
        css.Attributes["href"] = src;
        css.Attributes["rel"] = "stylesheet";
        Header.Controls.AddAt(index, css);
    }
    #endregion

    #endregion 

    #region 获取网站相关路径

    #region 获取根路径 例如：/Web/
    /// <summary>
    /// 获取根路径 例如：/Web/
    /// </summary>
    public string WebRootPath
    {
        get
        {
            string m_WebRootPath = System.Web.HttpContext.Current.Request.ApplicationPath;

            if (m_WebRootPath.Substring(0, 1) != "/")
                m_WebRootPath = "/" + m_WebRootPath;
            if (m_WebRootPath.Substring(m_WebRootPath.Length - 1, 1) != "/")
                m_WebRootPath += "/";

            return m_WebRootPath;
        }
    }
    #endregion

    #region 获取网站路径，去掉根目录路径 如： admin/Default
    /// <summary>
    /// 获取网站路径，去掉根目录路径 如： admin/Default
    /// </summary>
    public string CurrentWebPath
    {
        get
        {
            string strCurUrl = string.Empty;
            if (WebRootPath.Equals("/"))
            {
                strCurUrl = System.Web.HttpContext.Current.Request.Path.Trim(new char[] { '/' }).ToLower();
            }
            else
            {
                strCurUrl = System.Web.HttpContext.Current.Request.Path.Replace(WebRootPath, "").TrimEnd(new char[] { '/' }).ToLower();
            }
             return strCurUrl;
        }
    }
    #endregion

    #region 获取一级域名如：www.cntv.cn 没有Http://
    /// <summary>
    /// 获取一级域名 如：www.cntv.cn 没有Http://
    /// </summary>
    public string CurrentDomainNoHttp
    {
        get
        { 
            string domain = CommonMethod.GetConfigValueByKey("dmu");
            if (domain.Length == 0)
            {
                domain = System.Web.HttpContext.Current.Request.Url.Authority.ToString();
            }
            return domain;
        }
    }
    #endregion

    #region 获取一级域名如：http://www.cntv.cn
    /// <summary>
    /// 获取一级域名 如：http://www.cntv.cn
    /// </summary>
    public string CurrentDomain
    {
        get
        {
            string domain = CommonMethod.GetConfigValueByKey("dmu");
            if (domain.Length == 0)
            {
                domain= "http://" + System.Web.HttpContext.Current.Request.Url.Authority.ToString();
            }else
            {
                domain = "http://" + domain;
            }
            return domain;
        }
    }
    #endregion

    #region 获取域名+根路径，用于js css文件寻址
    /// <summary>
    /// 获取域名+根路径，用于js css文件寻址
    /// </summary>
    public string CurrentDomainRootPath
    {
        get
        {
            return CurrentDomain + WebRootPath;
        }
    }
    #endregion

    #region 获取当前Url
    /// <summary>
    /// 获取当前Url
    /// <summary> 
    public string CurrentUrl
    {
        get
        {
            return System.Web.HttpContext.Current.Request.Url.ToString();
        }
    }
    #endregion


    #endregion

    #region 客户端脚本助手
    /// <summary>
    /// 弹出提示框
    /// </summary>
    /// <param name="s">内容</param>
    public void Alert(string s)
    {
        ClientScript.RegisterClientScriptBlock(this.GetType(), Guid.NewGuid().ToString(), "<script type=\"text/javascript\">alert(\"" + s + "\");</script>");
    }
    /// <summary>
    /// 弹出错误信息
    /// </summary>
    /// <param name="s">错误信息说明</param>
    public void AlertError(string s)
    {
        ClientScript.RegisterClientScriptBlock(this.GetType(), Guid.NewGuid().ToString(), "<script type=\"text/javascript\">ymPrompt.errorInfo({ title: '温馨提示', message:\"" + s + "\"});</script>");
    }
    /// <summary>
    /// 弹出成功信息
    /// </summary>
    /// <param name="s">成功信息说明</param>
    public void AlertSucceed(string s)
    {
        ClientScript.RegisterClientScriptBlock(this.GetType(), Guid.NewGuid().ToString(), "<script type=\"text/javascript\">ymPrompt.succeedInfo({ title: '温馨提示', message:\"" + s + "\"});</script>");
    }

    /// <summary>
    /// 弹出提示框 并中止当前页面执行
    /// </summary>
    /// <param name="s">提示内容</param>
    /// <param name="isClear">是否把当前页面内容清空</param>
    public void AlertEnd(string s, bool isClear)
    {
        if (isClear)
        {
            Response.Clear();
        }
        Response.Write(string.Format("<script type=\"text/javascript\">alert('" + s + "');</script>", s));
        Response.End();
    }

    /// <summary>
    /// 关闭弹出页面（用于session 过期），弹出提示框 并中止当前页面执行
    /// </summary>
    public void ClosePopPage()
    {
        Response.Clear();
        Response.Write("<script type=\"text/javascript\">parent.ymPrompt.close();parent.ymPrompt.errorInfo({ title: '温馨提示', message: '回话过期，请重新登录！' });</script>");
        Response.End();
    }

    /// <summary>
    /// 选中一个客户端控件
    /// </summary>
    /// <param name="id">控件ID</param>
    public void Select(string id)
    {
        ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), "<script type=\"text/javascript\">try{document.getElementById('" + id + "').select()}catch(e){alert(e.description);}</script>");
    }

    /// <summary>
    /// 选中一个服务端控件
    /// </summary>
    /// <param name="c">控件ID</param>
    public void Select(System.Web.UI.Control c)
    {
        Select(c.ClientID);
    }


    /// <summary>
    /// 执行客户端脚本
    /// </summary>
    /// <param name="script"></param>
    public void ExecScript(string script)
    {
        ClientScript.RegisterClientScriptBlock(this.GetType(), Guid.NewGuid().ToString(), "<script type=\"text/javascript\">" + script + "</script>");
    }

    /// <summary>


    /// <summary>
    /// 执行客户端刷新
    /// </summary>
    public void Reload()
    {
        ExecScript("window.location = this.location");
    }

    /// <summary>
    /// 执行客户端启动脚本
    /// </summary>
    /// <param name="script"></param>
    public void ExecStartupScript(string script)
    {
        ClientScript.RegisterStartupScript(this.GetType(), Guid.NewGuid().ToString(), "<script type=\"text/javascript\">" + script + "</script>");
    }

    /// <summary>
    /// 输出Ajax内容
    /// </summary>
    /// <param name="Content"></param>
    public void ResponseAjaxContent(string Content)
    {
        this.Response.Clear();
        this.Response.ContentType = "text/xml";
        this.Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
        this.Response.Write(Content);
        this.Response.End();
    }
    #endregion
}