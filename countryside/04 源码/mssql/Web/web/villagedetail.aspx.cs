using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using PersistenceLayer;

public partial class web_villagedetail : WebBasePage
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
                villageId = Request.QueryString["vid"].Trim();
            }
            return villageId;
        }
    }
    #endregion

    #region 页面加载
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCssAndScript();
            nva0.HRef = CurrentDomainRootPath + "index/";
            nva1.HRef = CurrentDomainRootPath + "village/";
            imgvideo.Src = CurrentDomainRootPath + "images/web/villagedetail/dvideo.jpg";
            amoreimg.HRef =string.Format(CurrentDomainRootPath + "villageimg/{0}/{1}/",VillageId,UrlType);
            GetVillageNew();
            GetVillageDetailInfor();
            GetVillageImageANDVideo();
        }
    }
    #endregion

    #region 获取该村的资讯
    /// <summary>
    /// 获取该村的资讯
    /// </summary>
    public void GetVillageNew()
    {
        string strsql = string.Format(" select AutoID,Title from webfarmingnews where VillageID='{0}' and Opertype=1 order by OrderValue desc ", VillageId);
        DataTable dt = Query.ProcessSql(strsql, DataHelper.DataBase);
        StringBuilder sb = new StringBuilder("<li>更新中</li>");
        if (dt != null && dt.Rows.Count > 0)
        {
            sb = new StringBuilder();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.AppendFormat("<li><a href='{0}' >{1}</a></li>", CurrentDomainRootPath +"newsdetail/"+ dt.Rows[i]["AutoID"]+"/", dt.Rows[i]["Title"]);
            }

        }
        ulVliiageNews.InnerHtml = sb.ToString();
    }
    #endregion

    #region 
    /// <summary>
    /// 获取乡村详细信息
    /// </summary>
    public void GetVillageDetailInfor()
    {
        string strsql = string.Format(" select Title,Intro,Yield,Live,Environment,Humanism from webbeautifulvillage where autoid='{0}' ", UrlType);
        DataTable dt = Query.ProcessSql(strsql, DataHelper.DataBase);
        if (dt != null && dt.Rows.Count > 0)
        {
            this.spanVillagedetail.InnerHtml = dt.Rows[0]["title"].ToString(); //页面导航标题
            Head.Title = WebTitle +"-"+dt.Rows[0]["title"].ToString();
            this.divIntro.InnerHtml=dt.Rows[0]["Intro"].ToString();
            this.divYield.InnerHtml = dt.Rows[0]["Yield"].ToString();
            this.divLive.InnerHtml = dt.Rows[0]["Live"].ToString();
            this.divEnvironment.InnerHtml = dt.Rows[0]["Environment"].ToString();
            this.divHumanism.InnerHtml = dt.Rows[0]["Humanism"].ToString();
        }
    }

    #endregion

    /// <summary>
    /// 获取乡村图片和视频
    /// </summary>
    public void GetVillageImageANDVideo()
    {
        string strsql = string.Format("select AutoID,Title, FileSUrl,VillageID from webbeautifulvillageFile WHERE Status=1 AND FileType=0 ");
        DataTable dt = Query.ProcessSql(strsql, DataHelper.DataBase);
        StringBuilder sb=new StringBuilder ("更新中");
        if (dt != null && dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.AppendFormat("<li> <a target=\"_blank\" title=\"{0}\" href=\"###\"><img width=\"220\" height=\"155\" src=\"{1}\" /></a><div class=\"divimgtitle\">{0}</div></li>", dt.Rows[i]["Title"], CurrentDomainRootPath + dt.Rows[i]["FileSUrl"]);
            }
           
        }
        this.ulSlide.InnerHtml = sb.ToString();
    }

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
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/villagedetail.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/plugin/smallslider.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/jquery-1.7.2.min.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/jquery.smallslider.js?v=" + CommonMethod.Version);
        litTopCssAndScript.Text = sb.ToString();

        #endregion

        #region 底部加载

        sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/web/common.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/web/villagedetail.js?v=" + CommonMethod.Version);

        litBottomScript.Text = sb.ToString();

        #endregion
    }
    #endregion

}