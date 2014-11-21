using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Web.UI.HtmlControls;
using BusinessEntity;
using System.IO;
/// <summary>
///系统主页面父类
/// </summary>
public class SystemMainBasePage : SystemBasePage
{
    #region 重写Page_OnInit方法
    protected override void OnInit(EventArgs e)
    {
        #region
        //HttpCookie cookie = Request.Cookies["systemuser"];
        //if (null != cookie)
        //{
        //    if (CurrentUser == null)
        //    {
        //        string userAccount = HttpUtility.UrlDecode(cookie["userAccount"].Trim(), System.Text.Encoding.Default);
        //        string password = HttpUtility.UrlDecode(cookie["password"].Trim());
        //        string domainName = Request.Url.Authority;
        //        systemuserEntity objEntity = UtilitySearch.GetSystemUserByUserNameAndPwd(userAccount, password);
        //        if (objEntity != null) { CurrentUser = objEntity; }
        //        else { Response.Redirect("~/Login.aspx?backurl=" + CurrentWebPath); }
        //    }
        //}
        //else
        //{
        //    if (CurrentUser == null)
        //    {
        //        Response.Redirect("~/Login.aspx?backurl=" + CurrentWebPath);
        //    }

        //}
        #endregion
       
        if (Session["systemusers"] == null)
        {
            Response.Redirect("~/Login.aspx?backurl=" + CurrentWebPath);
            //ExecScript("parent.ymPrompt.errorInfo({ title: '温馨提示', message: '回话过期，请重新登录！' });window.location.href=getURL() + 'login.aspx';");
        }
        if (CacheUrl.Length > 0)
        {
            if (CacheUrl == "0")
            {
                CacheHelper.Instance.Remove(CacheDTName);
                string purviewcahce = CommonMethod.GetConfigValueByKey("DTC");
                OperateTxt.DelPurviewFile(CurrentCustomerID, CurrentRoleID, purviewcahce);
            }
            else if (CacheUrl == "2")//删除全部缓存
            {
                 string cachetype = CommonMethod.GetConfigValueByKey("DTWC");
                 string prefix=CurrentDomainNoHttp.Replace(".","").Replace(":","");
                 string cachename = cachetype + prefix;
                 CacheHelper.Instance.Remove(cachename); //删除地区缓存
                 CacheHelper.Instance.Remove(CacheDTName); //删除权限缓存
                  
                 string onefolder = CommonMethod.GetConfigValueByKey("Folder");
                 HttpServerUtility hsu = HttpContext.Current.Server; 
                 string physicspath = hsu.MapPath("~" + onefolder); //物理路径
                 if (Directory.Exists(physicspath))
                 {
                     Directory.Delete(physicspath,true);//删除缓存文件夹
                 }
                 Response.Redirect("~/Login.aspx?backurl=" + CurrentWebPath);
                
            }
        }
        string purviewvalue = GetPurviewForUrl(CurrentWebPath, "");
        if (purviewvalue == "0")
        {
            Response.Redirect("~/Login.aspx?backurl=" + CurrentWebPath);
        }
        Header.Title = LoginTitle; 
        PageStatus = "1";
        GenerateMeta("Content-Type", string.Empty, "text/html", "UTF-8", 0);
        //GenerateMeta("X-UA-Compatible", string.Empty, "IE=EmulateIE7", string.Empty, 1);
        GenerateMeta(string.Empty, "robots", "noindex, nofollow", string.Empty, 2);
        GenerateCss(CurrentDomainRootPath + @"style/admin/one/main.css?v=" + CommonMethod.Version, 3);
        GenerateCss(CurrentDomainRootPath + @"style/admin/one/common.css?v=" + CommonMethod.Version, 4);
        GenerateCss(CurrentDomainRootPath + @"scripts/ymPrompt/skin/black/ymPrompt.css?v=" + CommonMethod.Version, 5);
        GenerateScript(CurrentDomainRootPath + @"scripts/jquery-1.7.2.min.js?v=" + CommonMethod.Version, 6);
        GenerateScript(CurrentDomainRootPath + @"scripts/ymPrompt/ymPrompt.js?v=" + CommonMethod.Version, 7);    
        GenerateScript(CurrentDomainRootPath + @"scripts/dataset.js?v=" + CommonMethod.Version, 8);
        GenerateScript(CurrentDomainRootPath + @"scripts/jquery-1.7.2.min.js?v=" + CommonMethod.Version, 9);
        GenerateScript(CurrentDomainRootPath + @"scripts/common.js?v=" + CommonMethod.Version, 10);
        GenerateScript(CurrentDomainRootPath + @"scripts/admin/main.js?v=" + CommonMethod.Version,11);
        
        #region 页面控件布局
        HtmlTableCell TdHeader = this.Form.FindControl("TdHeader") as HtmlTableCell;
        HtmlTableCell TdLeftWard = this.Form.FindControl("TdLeftWard") as HtmlTableCell;
        HtmlTableCell TdFooter = this.Form.FindControl("TdFooter") as HtmlTableCell;
        HtmlTableCell TdVerticalLine = this.Form.FindControl("TdVerticalLine") as HtmlTableCell;
        if (TdHeader != null && TdLeftWard != null && TdFooter != null && TdVerticalLine != null)
        {
            string strTopAndLeftWard = CreateHeaderAndLeftWard();
            string[] arrTopAndLeftWard = strTopAndLeftWard.Split(new string[] { "====" }, StringSplitOptions.None);
            string strTop = string.Empty;
            string strLeftWard = string.Empty;
            if (arrTopAndLeftWard != null && arrTopAndLeftWard.Length > 0)
            {
                TdHeader.InnerHtml = arrTopAndLeftWard[0];
                TdLeftWard.InnerHtml = arrTopAndLeftWard[1];
            }

            TdFooter.InnerHtml = CreateFooter();
            TdVerticalLine.InnerHtml = CreateVerticalLine();
        }
        #endregion
    }
    #endregion

    #region 页面布局

    #region 页面顶部布局

    /// <summary>
    /// 页面顶部布局
    /// </summary>
    /// <returns>返回顶部布局和左边布局字符串</returns>
    public string CreateHeaderAndLeftWard()
    {
        string strLeftWard = string.Empty;
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat(@" <div  class='Header' runat='server'>
                                <div class='HeaderLogo'>
                                             <div   class='HeadLogoTitle'>{0} </div>
                                             <div   class='HeadLogoEdition'>管理平台&nbsp;v1.0</div>
                                 </div>", LoginTitle);
        sb.Append("<div class=\"HeaderMenu\"> <div class=\"Command\"><a href=\"###\" id=\"aindex\" >网站首页</a>&nbsp;|&nbsp;<a href=\"###\" id=\"anocacle\">更新缓存</a>&nbsp;|&nbsp;<a href=\"###\"  onclick=\"LogOut(); \">注销</a>&nbsp;|&nbsp;<a href=\"###\" onclick=\"systemExit()\">退出</a> </div> <div class=\"MenuItem\">");

        if (LayOutTable != null && LayOutTable.Rows.Count > 0)
        {
            DataRow[] drArray = LayOutTable.Select("IsTopMenu='1' and IsPurview='1'  "); // and IsShowMenu=1 
            bool isSelected = true;
            foreach (DataRow dr in drArray)
            {
                string ResourceUrl = ""; ;
                string ResourceName = dr["Title"].ToString();
                string description = dr["Alt"].ToString();
                string className = "Linked";
                string strAutoId = dr["AutoID"].ToString();
                string strTopMenu = GetTopMenuID(strAutoId, out ResourceUrl);
                if (isSelected)
                { 
                    if (strAutoId.Equals(strTopMenu))
                    {
                        className = "Selected"; strLeftWard = CreateLeftWard(strTopMenu);
                        isSelected = false;
                    }
                }
                sb.AppendFormat(" <div class='{3}'><a href='{1}'  title='{2}'>{0}</a></div>", ResourceName, WebRootPath + ResourceUrl, description, className);
            }
        }

        sb.Append(@"</div>
                     </div>
                </div>
                <div class='HorizontalLine'></div>");

        return sb.ToString() + "====" + strLeftWard; ; ;
    }

    /// <summary>
    /// 获取顶部菜单的ID
    /// </summary>
    /// <returns></returns>
    private string GetTopMenuID(string TopMenu, out string ResourceUrl)
    {
        string topMenu = ""; ResourceUrl = "";
        if (LayOutTable != null && LayOutTable.Rows.Count > 0)
        {
            DataRow[] dr = LayOutTable.Select("ParentId>0 and IsTopMenu='0'  and IsShowMenu='1' and IsPurview='1' and   TopMenuID='" + TopMenu+"'");
            if (dr != null && dr.Length > 0) ResourceUrl = dr[0]["MenuUrl"].ToString().ToLower();
            for (int i = 0; i < LayOutTable.Rows.Count; i++)
            {
                if (LayOutTable.Rows[i]["MenuUrl"].ToString().ToLower().Equals(CurrentWebPath.ToLower()))
                {
                    topMenu = LayOutTable.Rows[i]["TopMenuID"].ToString(); break;
                }
            }
        }
        return topMenu;
    }
    #endregion

    #region 页面底部布局

    /// <summary>
    /// 页面底部布局
    /// </summary>
    /// <returns></returns>
    public string CreateFooter()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendFormat(@"<div class='HorizontalLine' ></div>
                  <div class='Footer' >
                      Copyright 2006-{0}
                      <asp:Label runat='server' ID='BeianNo'></asp:Label>
                        技术支持：<a href='http://www.cctv.com' target='_blank'>YYWeb</a>
                  </div>", DateTime.Now.AddYears(1).Year.ToString());
        return sb.ToString();
    }
    #endregion

    #region 页面左边布局
    /// <summary>
    /// 页面左边布局
    /// </summary>
    /// <returns></returns>
    public string CreateLeftWard(string TopMenu)
    {
        StringBuilder sb = new StringBuilder();

        if (LayOutTable != null && LayOutTable.Rows.Count > 0)
        {

            sb.Append(@"<div class='LeftWard'>");
            sb.AppendFormat(@"<div class='AccountItem'><div class='ItemTitle'>我的账户</div><div class='Arrow' ><img src='{0}images/admin/expand.gif' title='折叠' /></div></div> ", WebRootPath);
            sb.Append("<ul style='display:none'>");
            sb.AppendFormat("<li class=\"label\">登录名：<span id=\"SideBar1_lblAccount\">{0}</span></li>",CurrentUser.Title);
            sb.AppendFormat("<li class=\"label\">姓名：<span id=\"SideBar1_lblName\">{0}</span></li>",CurrentUser.RealName);
            sb.AppendFormat("<li class=\"label\">电话：<span id=\"SideBar1_lblPhone\">{0}</span></li>",CurrentUser.Phone);
            sb.AppendFormat("<li class=\"label\">手机号：<span id=\"SideBar1_lblMobile\">{0}</span></li>", CurrentUser.MobilePhone);
            sb.AppendFormat("<li class=\"label\">E-mail：<span style=\"word-break: break-all\"  id=\"SideBar1_lblEmail\" title=\"{1}\" alt=\"{1}\" >{0}</span></li>", CommonMethod.GetSubString(CurrentUser.UserEmail,13,".."),CurrentUser.UserEmail);
            sb.AppendFormat("<li class=\"label\">QQ：<span id=\"SideBar1_lblQQ\">{0}</span></li>", CurrentUser.UserQQ);
            sb.Append("</ul>");
            DataRow[] drArray = LayOutTable.Select("ParentId='0' and IsTopMenu='0' and IsPurview='1' and TopMenuID='" + TopMenu+"'");//and IsShowMenu=1
            foreach (DataRow dr in drArray)
            {
                sb.AppendFormat(@"<div class='TopItem'><div class='ItemTitle'>{0}</div><div class='Arrow' ><img src='{1}images/admin/collapse.gif' title='折叠' /></div></div> ", dr["Title"], WebRootPath);
                DataRow[] drMenuArray = LayOutTable.Select("  IsPurview='1' and IsShowMenu='1'  and MenuType='0'  and ParentId='" + dr["AutoId"].ToString()+"'");
                if (drMenuArray != null && drMenuArray.Length > 0)
                {
                    sb.AppendFormat(@" <ul>");
                    foreach (DataRow drLeftMenu in drMenuArray)
                    {
                        string ResourceUrl = drLeftMenu["MenuUrl"].ToString().ToLower();
                        string ResourceName = drLeftMenu["Title"].ToString();
                        string description = drLeftMenu["Alt"].ToString();
                        string className = "";
                        if (ResourceUrl.Equals(CurrentWebPath.ToLower())) className = "class='Selected'";
                        sb.AppendFormat(@"<li {3}><a href='{1}'title='{2}'>{0}</a></li>", ResourceName, WebRootPath + ResourceUrl, description, className);
                    }
                    sb.Append("</ul>");
                }
            }
            sb.Append(@"</div>");
        }
        return sb.ToString();
    }
    #endregion

    #region 页面左边隐藏箭头布局
    /// <summary>
    /// 页面左边隐藏箭头布局
    /// </summary>
    /// <returns></returns>
    public string CreateVerticalLine()
    {
        string LeftArrowSrc = WebRootPath + "images/admin/arrowLeft.gif";
        return "<img src = '" + LeftArrowSrc + "' title='隐藏侧边' id = 'LeftCloseArrow' />";
    }
    #endregion

    #endregion

    #region  判断该页面功能中 是否有新增 删除权限
    /// <summary>
    /// 判断该页面功能中 是否有新增 删除权限
    /// </summary>
    /// <param name="url"></param>
    /// <param name="newbtn"></param>
    /// <param name="delbtn"></param>
    public void GetNewAndDelPurview(string url, HtmlInputButton newbtn, HtmlInputButton delbtn)
    {
        string purviewvalue = "";
        if (newbtn != null)
        {
            purviewvalue = GetPurviewForUrl(url,"new");
            if (purviewvalue == "0") { newbtn.Style.Value = "display:none"; }
        }

        if (delbtn != null)
        {
            purviewvalue = GetPurviewForUrl(url,"delete");
            if (purviewvalue == "0") { delbtn.Style.Value = "display:none"; }
        }
    }
    #endregion



}