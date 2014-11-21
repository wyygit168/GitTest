using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using PersistenceLayer;
using System.Web.Routing;
using System.Web.UI.HtmlControls;

/// <summary>
///WebBasePage 的摘要说明
/// </summary>
public class WebBasePage : CommonPage
{
    #region 重写Page_OnInit方法
    protected override void OnInit(EventArgs e)
    {
        #region 判断是否需要删除缓存，如果是就删除
        if (Request.QueryString["iscache"]!=null)//RouteData.Values["iscache"] != null
        {
            string iscache = Request.QueryString["iscache"].Trim();
            if (iscache == "0")
            {
                #region 删除三农快讯缓存
                CacheHelper.Instance.Remove(FarmingNewsCacheName);
                string farmingnewscahce = CommonMethod.GetConfigValueByKey("FNC");
                OperateTxt.DelFarmingnewsFile(CustomerId, farmingnewscahce);
                #endregion
            }
        }
        #endregion
        if (this.Form.FindControl("divtop") != null)
        { 
            HtmlGenericControl divTop = this.Form.FindControl("divtop") as HtmlGenericControl;
            divTop.InnerHtml = GetTopHtmlString();
        }
        if (this.Header.FindControl("lnkico") != null)
        {
            HtmlLink lnkico = this.Header.FindControl("lnkico") as HtmlLink;
            lnkico.Href = TitleIcoUrl;
        }
    }
    #endregion

    #region  拼装顶部登录
    /// <summary>
    ///  拼装顶部登录Html
    /// </summary>
    /// <returns></returns>
    public string GetTopHtmlString()
    {
        StringBuilder sb = new StringBuilder();
        string strSql = string.Format(@" select h.Title,h.AutoID,h.OrderValue,h.url,h.Status from webmenu h 
              left join web_customer_menu wcm on h.AutoID=wcm.MenuID  
              where h.status=1 and  wcm.status =1  and wcm.CustomerID='{0}' 
              order by  wcm.OrderValue desc, h.ordervalue desc,h.AutoID asc ", CustomerId);
        DataTable dtMenu = Query.ProcessSql(strSql, DataHelper.DataBase); 
        sb.Append("<div id=\"topLogin\">");
        sb.Append("<div id=\"inside_top\"  class=\"inside_top\">");
        HttpCookie cookies = System.Web.HttpContext.Current.Request.Cookies[WULC]; 
        if (cookies == null)
        { 
            sb.Append("<div id=\"login_bar\">");
            sb.AppendFormat("<span class=\"top_hello \">您好，欢迎光临{0}！</span>",WebTitle);
            sb.Append("<div class=\"sign_in_box\" id=\"loginBox\">");
            sb.AppendFormat("<div class=\"set_float\" id=\"loginText\"><a href=\"javascript:void(0)\" >登录</a><span class=\"sign_in_down\" id=\"loginTextArrow\"><img src=\"{0}images/page/top/cn_common_new24.png\"  alt=\"\" title=\"\" /></span></div>", CurrentDomainRootPath);
            sb.Append("<div  id=\"sign_in_form_box\" class=\"none\" >");
            sb.Append("<div class=\"sign_fm\" id=\"sign_in_form_box_inner\">");
            sb.AppendFormat("<span class=\"sign_close\" id=\"cancel_img\"><img alt=\"关闭\" title=\"关闭\" src=\"{0}images/page/top/cn_common_new24.png\"  /></span>", CurrentDomainRootPath);
            sb.Append("<p class=\"sign_tip\" style=\"visibility: hidden;\" id=\"login_tip\">用户名或密码错误，请重新输入。</p>");
            sb.Append("<div class=\"item\">");
            sb.Append("<label for=\"account\">帐号：</label><input type=\"text\" value=\"\" maxlength=\"30\" name=\"name\" id=\"txtaccount\" />");
            sb.Append("</div>");
            sb.Append("<div class=\"item\">");
            sb.Append("<label for=\"actpwd\">密码：</label><input type=\"password\" value=\"\" maxlength=\"30\" id=\"txtactpwd\" />&nbsp;<a rel=\"nofollow\" href=\"###\" class=\"sign_lostfound\">忘记密码？</a>");
            sb.Append("</div>");
            sb.Append("<div class=\"item\"><input type=\"checkbox\" name=\"remIt\" value=\"7\" id=\"rem_it_1w\" ><label for=\"rem_it_1w\" class=\"ri1_label\">记住密码（一周）</label></input></div>");
            sb.Append("<div class=\"item si_set_float_wrap\">");
            sb.Append("<input type=\"button\"  title=\"登 录\" class=\"btn_sign_in\"   id=\"btnlogin\"  />");
            //sb.AppendFormat("<span class=\"wait4sign none\" id=\"logining\" style=\"display: none;\"><img src=\"{0}images/page/top/wait.gif\" title=\"\" alt=\"\" />登录中…</span>", CurrentDomainRootPath);
            sb.Append("<a href=\"javascript:void(0)\" class=\"cancel_sign\" id=\"sign_in_cancel\">取消</a>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.AppendFormat("<a rel=\"nofollow\" href=\"{0}\" class=\"sgin_up\">注册</a>", CurrentDomainRootPath + "reg/");
            sb.Append("</div>");
            sb.Append("</div>"); 
        }
        else
        {
            string strUsername = cookies[WULCN]; 
            sb.AppendFormat(" <div id=\"login_bar\"><span class=\"top_hello \">您好， {0}！<a href=\"###\"  title=\"点击收藏\" id=\"afavorite\" >欢迎光临{1}！</a>&nbsp;&nbsp;<a href=\"###\" id=\"aexit\">[退出登录]</a></span> </div>", strUsername,WebTitle);
        }
        sb.Append("</div>");
        sb.Append("<div class=\"clear_float\"></div>");
        sb.Append("<div id=\"divLogo\" style=\"width:100%; text-align:center;margin:30px 0 0;\">");

        string lbImage = GetLBImage();
        if (lbImage.Length == 0) sb.AppendFormat("<img src=\"{0}testImage/banner41.jpg\" alt=\"\" title=\"\" width=960 height=180 />", CurrentDomainRootPath);
        else sb.Append(lbImage); 
        sb.Append("</div>");

        sb.Append("<div class=\"topNavigation\">");
        sb.Append("<div class=\"mainmenu\">");
        sb.Append("<div class=\"mainmenuLeft\">");
        sb.Append("<ul>");
        if (dtMenu != null && dtMenu.Rows.Count > 0)
        {
            for (int i = 0; i < dtMenu.Rows.Count; i++)
            {
                //string routeurl = GetRouteUrl(Routename, null).ToLower();
                string dUrl=dtMenu.Rows[i]["url"].ToString(); 
                string url=dUrl.Substring(0,dUrl.IndexOf('/'));
                string fullurl = (CurrentDomainRootPath + dUrl).ToLower();
                string classname = "";
                if (CurrentUrl.Contains(url)) classname = "menuSel";
                sb.AppendFormat("<li class=\"menuSign\"></li><a target=\"_self\" alt=\"{1}\" title=\"{1}\" href=\"{2}\"><li  id=\"mainmenu_{0}\" class=\"{3}\">{1}</li></a>", i, dtMenu.Rows[i]["Title"], fullurl, classname);
            }

        }
        sb.Append("</ul><div class=\"clear_float\"></div>");
        sb.Append("</div>");
        sb.Append("</div>");
        //sb.Append("<div class=\"submenu\"></div>");
        sb.Append("</div>"); 
        return sb.ToString();
    }
    #endregion

    #region 客户ID
    /// <summary>
    ///  客户ID
    /// </summary>
    public int CustomerId
    {
        get
        {
            int customerid = -1;
            DataTable dtUrl = GetDatablePriviewForUrl();
            if (dtUrl != null && dtUrl.Rows.Count > 0)
            {
                customerid = dtUrl.Rows[0]["CustomerID"].ToInt(-1);
            }
            return customerid;
        }
    }

    #endregion

    #region 获取资讯快递缓存名称
    /// <summary>
    /// 获取资讯快递缓存名称 
    /// </summary>
    public string FarmingNewsCacheName
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("FNC") + "_" + CustomerId;
            return ct;
        }
    }
    #endregion

    #region 客户所属省ID

    /// <summary>
    ///  客户所属省ID
    /// </summary>
    public int ProvinceId
    {
        get
        {
            int provinceid = 0;
            DataTable dtUrl = GetDatablePriviewForUrl();
            if (dtUrl != null && dtUrl.Rows.Count > 0)
            {
                provinceid = dtUrl.Rows[0]["ProvinceID"].ToInt(0);
            }
            return provinceid;
        }
    }

    #endregion

    #region 客户所属城市ID
    /// <summary>
    ///  客户所属城市ID
    /// </summary>
    public int CityID
    {
        get
        {
            int cityid = 0;
            DataTable dtUrl = GetDatablePriviewForUrl();
            if (dtUrl != null && dtUrl.Rows.Count > 0)
            {
                cityid = dtUrl.Rows[0]["CityID"].ToInt(0);
            }
            return cityid;
        }
    }
    #endregion

    #region 客户所属县、区ID
    /// <summary>
    /// 客户所属县ID
    /// </summary>
    public int CountyID
    {
        get
        {
            int countyid = 0;
            DataTable dtUrl = GetDatablePriviewForUrl();
            if (dtUrl != null && dtUrl.Rows.Count > 0)
            {
                countyid = dtUrl.Rows[0]["CountyID"].ToInt(-1);
            }
            return countyid;
        }
    }
    #endregion

    #region 客户所属乡、镇ID
    /// <summary>
    ///  客户所属乡、镇ID
    /// </summary>
    public int TownID
    {
        get
        {
            int townid = 0;
            DataTable dtUrl = GetDatablePriviewForUrl();
            if (dtUrl != null && dtUrl.Rows.Count > 0)
            {
                townid = dtUrl.Rows[0]["TownID"].ToInt(0);
            }
            return townid;
        }
    }
    #endregion

    #region  获取、设置url静态的路由名称 
    //private string routename = "";
    ///// <summary>
    /////  获取、设置url静态的路由名称
    ///// </summary>
    //public string Routename
    //{
    //    get { return routename; }
    //    set { routename = value; }
    //}
    #endregion  

    #region 资讯（三农快递，最新公告，各村资讯）缓存

   

    #region 获取三农资讯，最新公告，各村资讯的打他table数据，先读取缓存
    /// <summary>
    /// 获取三农资讯，最新公告，各村资讯的打他table数据，选读取缓存，
    /// </summary>
    /// <returns></returns>
    public DataTable DTFarmingNews
    {
        get
        {
            DataTable dt = CacheHelper.Instance.GetData(FarmingNewsCacheName) as DataTable;
            if (dt == null)
            {
                string farminewscahce = CommonMethod.GetConfigValueByKey("FNC");
                string dtJson = OperateTxt.ReadFarmingnewFile(CustomerId, farminewscahce);
                string decdtJson = "";
                if (dtJson.Length > 0)
                {
                    decdtJson = DESEncrypt.Decrypt(dtJson);
                }
                DataSet ds = JsonHelper.Deserialize<DataSet>(decdtJson);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    CacheHelper.Instance.Add(FarmingNewsCacheName, dt);
                }
                else
                {
                    string strSql = string.Format("select AutoID,Title,Opertype,TownID,VillageID from webfarmingnews where (TownID='{0}' and customerid='{1}') or Opertype=0 order by ordervalue desc,ModifyDate desc ", TownID, CustomerId);
                    ds = Query.ProcessMultiSql(strSql, DataHelper.DataBase);
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        dt = ds.Tables[0];
                        dtJson = JsonHelper.JsonFromDataTable(dt);
                        string enctJson = DESEncrypt.Encrypt(dtJson); //加密  
                        OperateTxt.WriteFramingnewsFile(enctJson, CustomerId, farminewscahce);
                        CacheHelper.Instance.Add(FarmingNewsCacheName, dt);
                    }
                }
            }
            return dt;
        }
    }
    #endregion

    #endregion

    #region 页面url传递字符串type

    /// <summary>
    /// 页面url传递字符串type
    /// </summary>
    public string UrlType
    {
        get
        {
            string urltype = "";
            if (Request.QueryString["type"] != null)
            {
                urltype = Request.QueryString["type"].Trim();
            }
            return urltype;
        }
    }

    #endregion

    #region 网站登录Cookie属性
    /// <summary>
    /// 网站登录Cookie名称
    /// </summary>
    public string WULC
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("WULC");
            return ct;
        }
    }

    /// <summary>
    /// 网站登录CookieName
    /// </summary>
    public string WULCN
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("WULCN");
            return ct;
        }
    }

    /// <summary>
    /// 网站登录Cookiepwd
    /// </summary>
    public string WULCD
    {
        get
        {
            string ct = "";
            ct = CommonMethod.GetConfigValueByKey("WULCD");
            return ct;
        }
    }

    #endregion

    #region 获取网站名称
    /// <summary>
    /// 获取网站名称
    /// </summary>
    public string WebTitle
    {
        get
        {
            AjaxHelper ajaxEntity = new AjaxHelper(); 
            ajaxEntity.Action = SystemData.BaseInfo_SelectWebTitle; 
            OperateXml xml = new OperateXml();
            string returnvalue = xml.SelectbaseconfigFile(CustomerId.ToString(), SystemData.BaseInfo_WebTitle);
            return returnvalue;
        }
    }

    #endregion

    #region 设置网站标题栏图片ICO地址

    public string TitleIcoUrl
    {
        get
        {
            return CurrentDomainRootPath + "favicon.ico";
        }
    }


    #endregion

    #region 查询首页轮播图
    /// <summary>
    ///  获取首页轮播图
    /// </summary>
    /// <returns></returns>
    public  string GetLBImage()
    {
        StringBuilder sb=new StringBuilder ();
        DataTable dt= UtilitySearch.GetLBImageDataTable(TownID,CustomerId);
        if (dt != null && dt.Rows.Count > 0)
        {
            sb.Append("<div id=\"flashbox\" class=\"smallslider\" style=\"margin:0 auto;width:960px; height:120px;\"><ul>");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.AppendFormat("<li><a href=\"{0}\" target=\"_blank\"><img src=\"{0}\" width=\"960\" height=\"120\" title=\"{1}\" alt=\"{1}\" /></a></li>", CurrentDomainRootPath + dt.Rows[i]["FileUrl"], dt.Rows[i]["Title"]);
            }
            sb.Append("</ul></div>");
        }
        return sb.ToString();
    }
    #endregion
}