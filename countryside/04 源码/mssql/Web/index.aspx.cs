using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using PersistenceLayer;

public partial class index : WebBasePage
{
    #region 初始化

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCssAndScript(); 
            OperationMethod om=new OperationMethod ();
            ulnewaffiche.InnerHtml =om.GetNewAffiche(); 
            ulSN.InnerHtml =om.GetFarmingNew();
            ulNewInfor.InnerHtml = om.GetVillageNew(); 
            GetSlideImage();//获取幻灯图片
            amore1.HRef = CurrentDomainRootPath + "news/1/";
            amore2.HRef = CurrentDomainRootPath + "news/0/";
        }
    }

    #endregion

    #region 拼装幻灯图片
    /// <summary>
    /// 拼装幻灯图片
    /// </summary>
    public void GetSlideImage()
    {
        StringBuilder sb = new StringBuilder();
        string strSql = string.Format("select top 5 AutoID,Title,FileUrl  from webbeautifulvillageFile where CustomerID='{0}' and TownID='{1}' order by OrderValue desc,AutoID desc ", CustomerId, TownID);
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        if (dt != null && dt.Rows.Count> 0)
        {
            string strUrl = string.Format("{0}villageimg/0/0/", CurrentDomainRootPath);
             sb.AppendFormat("<script src=\"{0}scripts/web/lanternslide.js\" type=\"text/javascript\"></script>",CurrentDomainRootPath);
             sb.Append("<div class=\"FocusImg\">");
             sb.Append("<div id=\"BigPic\" class=\"BigPic\">");
             sb.Append("<a target=\"_blank\" href=\"###\">");
             sb.AppendFormat("<img alt=\"{0}\" title=\"{0}\" galleryimg=\"no\" style=\"FILTER: revealTrans(duration=1,transition=23);\"  src=\"{1}\">",dt.Rows[0]["Title"], CurrentDomainRootPath+dt.Rows[0]["FileUrl"]);
             sb.Append("</a>");
             sb.Append("</div>"); 
             sb.Append("<div class=\"TitleBg\"></div>");
             sb.AppendFormat("<div id=\"TitleBox\" class=\"TitleBox\"> <a target=\"_blank\" href=\"###\">{0}</a></div>",dt.Rows[0]["Title"]);
             sb.Append("<div id=\"SmallPics\" class=\"SmallPics\">");
             sb.Append("<span class=\"selected\"><div class=\"imgItem\"> <a target=\"_blank\" href=\"\"> <img alt=\"\" onmouseover=\"FocusPic.childs[0].select(0)\" src=\"\"></a></div> </span>");
             sb.Append("<span class=\"\"><div class=\"imgItem\"><a target=\"_blank\" href=\"\"><img alt=\"\" onmouseover=\"FocusPic.childs[0].select(1)\" src=\"\"></a></div></span>");
             sb.Append("<span class=\"\"><div class=\"imgItem\"><a target=\"_blank\" href=\"\"><img alt=\"\" onmouseover=\"FocusPic.childs[0].select(2)\" src=\"\"></a></div></span>");
             sb.Append("<span class=\"\"><div class=\"imgItem\"><a target=\"_blank\" href=\"\"> <img alt=\"\" onmouseover=\"FocusPic.childs[0].select(3)\" src=\"\"></a></div></span>");
             sb.Append("<span class=\"\"><div class=\"imgItem\"><a target=\"_blank\" href=\"\"> <img alt=\"\" onmouseover=\"FocusPic.childs[0].select(4)\" src=\"\"></a></div></span>");
             sb.Append("</div>");
             sb.Append("</div>");
             sb.Append("<script type=\"text/javascript\">");
            sb.Append("var FocusPic_1 = new FocusPic('BigPic', 'SmallPics', 'TitleBox', 1);"); 
            for (int i=0; i<dt.Rows.Count;i++)
            {
                sb.AppendFormat("FocusPic_1.Add('{0}','{0}','{2}','{1}');", CurrentDomainRootPath + dt.Rows[i]["FileUrl"], dt.Rows[i]["Title"],strUrl);
            }
            sb.Append("FocusPic_1.begin();");
            sb.Append("</script>");
        }
        C_SlideImg.InnerHtml = sb.ToString();
    }
    #endregion

    #region 加载CSS Js文件
    /// <summary>
    ///  加载CSS Js文件
    /// </summary>
    private void LoadCssAndScript()
    {
        #region 顶部加载
        Head.Title = WebTitle+"—首页"; 
        StringBuilder sb = new StringBuilder();
        sb.Append("<link rel=\"shortcut icon\"  href=\"favicon.ico\" />");
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/common.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/common_top.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/index.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/plugin/smallslider.css?v=" + CommonMethod.Version);

        
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/jquery-1.7.2.min.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/jquery.smallslider.js?v=" + CommonMethod.Version);

        litTopCssAndScript.Text = sb.ToString();
        
        #endregion

        #region 底部加载
       
        sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/common.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/web/common.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/web/index.js?v=" + CommonMethod.Version);
        litBottomScript.Text = sb.ToString();

        #endregion
    }
    #endregion 

}