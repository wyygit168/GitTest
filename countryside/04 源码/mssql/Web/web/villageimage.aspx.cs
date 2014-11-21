using PersistenceLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class web_villageimage : WebBasePage
{
    #region 属性
    /// <summary>
    /// 乡村ID
    /// </summary>
    public string VillageId
    {
        get
        {
            string villageId = "";
            if (Request.QueryString["vid"] != null)
            {
                villageId = Request.QueryString["vid"].Trim().ToInt(0)>0?Request.QueryString["vid"].Trim():"";
            }
            return villageId;
        }
    }
     
/// <summary>
    /// 乡村明细列表Id
    /// </summary>
    public string VdId
    {
        get
        {
            string vdid = "";
            if (Request.QueryString["vdid"] != null)
            {
                vdid = Request.QueryString["vdid"].Trim().ToInt(0) > 0 ? Request.QueryString["vdid"].Trim() : "";
            }
            return vdid;
        }
    }
    #endregion 

    #region 初始化
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCssAndScript();
            GetVillageList();
        }
    }

    #endregion

    #region 获取乡村图片列表
    /// <summary>
    /// 获取乡村图片列表
    /// </summary>
    public void GetVillageList()
    {
        string strSqlVillage = "";
        DataTable dt = null;
        if (VillageId.Length > 0)
        {
            strSqlVillage = string.Format("VillageID='{0}'", VillageId);
            htitle.InnerHtml = "组图：魅力" + UtilitySearch.GetVillageNameByID(VillageId.ToInt(0)) + "-图片";
            string strsql = string.Format(" select Title,Intro,Yield,Live,Environment,Humanism from webbeautifulvillage where autoid='{0}' ", VdId);
            dt = Query.ProcessSql(strsql, DataHelper.DataBase);
            string strVillageTitle = "";
            if (dt != null && dt.Rows.Count > 0)
            {
                strVillageTitle = dt.Rows[0]["title"].ToString(); //页面导航标题 
            }
            nav.InnerHtml = string.Format(" <a  href=\"{0}\">首页</a><em>&gt;&gt;</em><a  href=\"{2}\">魅力乡村</a><em>&gt;&gt;</em><a  href=\"{3}\">{4}</a><em>&gt;&gt;</em>{1}", CurrentDomainRootPath + "index/", htitle.InnerHtml, CurrentDomainRootPath + "village/", CurrentDomainRootPath + "villagedetail/" + VdId + "/" + VillageId + "/", strVillageTitle);
        }
        else
        {
            htitle.InnerHtml = "组图：魅力" + UtilitySearch.GetTownNameByID(TownID) + "-图片";
            nav.InnerHtml = string.Format(" <a  href=\"{0}\">首页</a> <em>&gt;&gt;</em>{1}", CurrentDomainRootPath + "index/", htitle.InnerHtml);
        }
        string strSql = string.Format(@" select AutoID,Title,CustomerID,TownID,FileUrl,FileSUrl,LinkUrl,FileRmark from webbeautifulvillageFile 
                                         where FileType=0 and CustomerID={0} and TownID={1} ", CustomerId, TownID);
        dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        StringBuilder sb = new StringBuilder();
        if (dt != null && dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                string imgsrc = CurrentDomainRootPath + dt.Rows[i]["FileUrl"].ToString();
                string imgtsrc = CurrentDomainRootPath + dt.Rows[i]["FileSUrl"].ToString();
                string title = dt.Rows[i]["Title"].ToString();
                sb.AppendFormat("<li> <a href=\"{0}\"> <img width=\"90\" height=\"60\" src=\"{1}\"  title=\"{2}\" alt=\"\"  > </a> </li>", imgsrc, imgtsrc, title);
            }
        }
        adullist.InnerHtml = sb.ToString();
    }
    #endregion

    #region 加载CSS Js文件
    /// <summary>
    ///  加载CSS Js文件
    /// </summary>
    private void LoadCssAndScript()
    {
        #region 顶部加载

        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/common.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/common_top.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/villageimage.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/plugin/jquery.ad-gallery/jquery.ad-gallery.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/plugin/smallslider.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/jquery-1.7.2.min.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/web/plugin/jquery.ad-gallery/jquery.ad-gallery.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/jquery.smallslider.js?v=" + CommonMethod.Version);
        litTopCssAndScript.Text = sb.ToString();

        #endregion

        #region 底部加载

        sb = new StringBuilder();

        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/common.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/web/common.js?v=" + CommonMethod.Version); 
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/web/villageimage.js?v=" + CommonMethod.Version);
        
        
        litBottomScript.Text = sb.ToString();

        #endregion
    }
    #endregion
}