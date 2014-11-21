using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class web_news : WebBasePage
{

    #region Page_Load
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            nva0.HRef = CurrentDomainRootPath + "index/"; 
            LoadCssAndScript(); 
            InitData();           
        }
    }
    #endregion 

    #region 初始化数据
    /// <summary>
    /// 初始化数据
    /// </summary>
    public void InitData()
    {
        AjaxHelper ajaxEntity = new AjaxHelper();
        if (UrlType == "0") //各村资讯
        {
            ajaxEntity.Extend1 = "village";
            ajaxEntity.Extend2 = "farming"; 
        }
        else if(UrlType=="1"){       //三农快报
            ajaxEntity.Extend1 = "farming";
            ajaxEntity.Extend2 = "village";
            span0.InnerHtml = "各村资讯";
            lblTitle.InnerHtml = "三农快报";
        }
        else if (UrlType == "2") //最新公告
        {
            ajaxEntity.Extend1 = "newaffice";
            ajaxEntity.Extend2 = "village"; 
            span1.InnerHtml = "各村资讯";
            lblTitle.InnerHtml = "最新公告";

        }
        ajaxEntity.Action = "farmingnews";
        OperationMethod om = new OperationMethod();
        string json = om.GetFarmingNewForAjax(ajaxEntity);
        string[] arryjson = json.Split(new string[] { "!@#$%%$#@!" }, StringSplitOptions.None);
        if (arryjson != null && arryjson.Length > 0)
        {
            ula0.InnerHtml = arryjson[0];
            string[] arryjson1 = arryjson[1].Split(new string[] { "$$$$" }, StringSplitOptions.None);
            if (arryjson != null && arryjson.Length > 0)
            {
                StringBuilder s_tr = new StringBuilder(arryjson1[0]);
                s_tr.Append("<tr><td colspan=\"2\" style=\"text-align: right;\"><div class=\"pageBar\" id=\"divPageBar\">");
                s_tr.Append(arryjson1[1]);
                s_tr.Append("</div> </td> </tr>");
                tbContent.InnerHtml = s_tr.ToString();
            }
        }
        string jsonHtml = "";
        if (UrlType =="2") jsonHtml = om.GetFarmingNew();
        else  jsonHtml = om.GetNewAffiche();
        ula1.InnerHtml = jsonHtml;
    }
    #endregion

    #region 加载CSS Js文件
    /// <summary>
    ///  加载CSS Js文件
    /// </summary>
    private void LoadCssAndScript()
    {
        #region 顶部加载
        Head.Title = WebTitle + "-资讯速递"; 
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
         sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/web/news.js?v=" + CommonMethod.Version);
         litBottomScript.Text = sb.ToString();

        #endregion
    }
    #endregion 
}