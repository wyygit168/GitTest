using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using PersistenceLayer;

public partial class web_newsdetail : WebBasePage
{


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCssAndScript();
            OperationMethod om = new OperationMethod();
            ula1.InnerHtml = om.GetNewAffiche();
            ula0.InnerHtml = om.GetFarmingNew();
            ula2.InnerHtml = om.GetVillageNew();
            nva1.HRef=amore1.HRef = CurrentDomainRootPath + "news/2/";
            amore0.HRef = CurrentDomainRootPath + "news/1/";
            amore2.HRef = CurrentDomainRootPath + "news/0/";
            nva0.HRef = CurrentDomainRootPath + "index/"; 
            GetNewDetail();
        }
    }

    public void GetNewDetail()
    {
        string strSql = string.Format("SELECT AutoID ,Title,  Content, CreateDate  FROM webfarmingnews where AutoID='{0}'", UrlType);
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        StringBuilder sb=new StringBuilder ();
        if (dt != null && dt.Rows.Count > 0)
        {
            sb.Append("<div id=\"articleHead\" class=\"head\">");
            sb.Append("<h1 style=\"word-break: break-all;\">");
            sb.AppendFormat("{0}",dt.Rows[0]["Title"]);
            sb.Append("</h1>");
            sb.Append("<h2>");
            sb.AppendFormat("创建时间：{0}", dt.Rows[0]["CreateDate"]);
            sb.Append("</h2>");
            sb.Append("</div>");
            sb.Append("<hr style=\"width: 100%; color: #E1E1E1; border-style: solid;\" />");
            sb.Append("<div style=\"word-break: break-all;\" id=\"articleBody\" class=\"body\">");
            sb.AppendFormat("{0}", dt.Rows[0]["Content"]);
            sb.Append("</div>");
            sb.Append("<div id=\"articleFoot\" class=\"mt10\"><a href=\"javascript:history.go(-1);\">返回</a></div>");
        }
        article.InnerHtml = sb.ToString();
    }


    #region 加载CSS Js文件
    /// <summary>
    ///  加载CSS Js文件
    /// </summary>
    private void LoadCssAndScript()
    {
        #region 顶部加载
        Head.Title = WebTitle + "-资讯速递详情";
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/common.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/common_top.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/sidebar.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/article.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/plugin/smallslider.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/jquery-1.7.2.min.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/jquery.smallslider.js?v=" + CommonMethod.Version);
        litTopCssAndScript.Text = sb.ToString();

        #endregion

        #region 底部加载

        sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/common.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/web/common.js?v=" + CommonMethod.Version);
        litBottomScript.Text = sb.ToString();

        #endregion
    }
    #endregion 
}