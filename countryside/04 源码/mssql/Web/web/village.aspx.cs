using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using PersistenceLayer;
public partial class web_village : WebBasePage
{
    #region 页面加载
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
             LoadCssAndScript();
             nva0.HRef = CurrentDomainRootPath + "index/";
             GetVillageList();
        }
    }
    #endregion

    #region 获取乡村列表
    /// <summary>
    /// 获取乡村列表
    /// </summary>
    public void GetVillageList()
    {
        string strSql = string.Format(@" select AutoID,title,intro,villageId,(select top 1 FileSUrl from  webbeautifulvillageFile wvf where  wvf.VillageID=wv.VillageID and wvf.status=1  and wvf.CustomerID={0} and wvf.TownID={1}  ) FileSUrl  from   webbeautifulvillage wv  where wv.status=1 
                                         and CustomerID={0} and TownID={1} ",CustomerId,TownID);
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        StringBuilder sb = new StringBuilder();
        if (dt != null && dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
			{
               string intro=CommonMethod.RemoveHtmlTags(dt.Rows[i]["intro"].ToString());
               string detailUrl = CurrentDomainRootPath + "villagedetail/" + dt.Rows[i]["AutoID"].ToString() + "/" + dt.Rows[i]["villageId"].ToString() + "/";
               string imageUrl = string.IsNullOrEmpty(dt.Rows[i]["FileSUrl"].ToString()) ? CurrentDomainRootPath +"images/default.jpg" : CurrentDomainRootPath + dt.Rows[i]["FileSUrl"].ToString();
                sb.Append("<div class=\"villagedetail\">");
                sb.AppendFormat(" <a title=\"{0}\"   href=\"{2}\"><img width=\"170\" height=\"110\" bolder=\"0\" src=\"{1}\"></a><br>", intro, imageUrl, detailUrl);
               sb.AppendFormat(" <p ><a title=\"{0}\"   href=\"{2}\">{1}</a> </p>", intro, dt.Rows[i]["title"], detailUrl);
               sb.Append("</div>"); 
			}
        }
        divVillageList.InnerHtml = sb.ToString();
    }
    #endregion

    #region 加载CSS Js文件
    /// <summary>
    ///  加载CSS Js文件
    /// </summary>
    private void LoadCssAndScript()
    {
        #region 顶部加载
        Head.Title = WebTitle + "-魅力乡村"; 
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/common.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/common_top.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link  type=\"text/css\"  rel=\"stylesheet\"  href=\"{0}\"   />", CurrentDomainRootPath + "style/web/One/village.css?v=" + CommonMethod.Version);
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