using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using BusinessEntity;

/// <summary>
///系统弹出页面父类
/// </summary>
public class SystemPopUpBasePage : SystemBasePage
{
    protected override void OnInit(EventArgs e)
    {
        if (Session["systemusers"] == null)
        {
            //ExecScript("parent.ymPrompt.close();parent.ymPrompt.errorInfo({ title: '温馨提示', message: '回话过期，请重新登录！' });");
            ClosePopPage();
        }
        string purviewvalue = GetPurviewForUrl(CurrentWebPath,Action);
        if (purviewvalue == "0")
        {
            ExecScript("parent.ymPrompt.close();parent.ymPrompt.errorInfo({ title: '温馨提示', message: '很抱歉，你没有权限访问该页面！' });");
        }
        PageStatus = "2";
        GenerateMeta("Content-Type", string.Empty, "text/html", "UTF-8", 0);
        GenerateMeta("X-UA-Compatible", string.Empty, "IE=EmulateIE7", string.Empty, 1);
        GenerateMeta(string.Empty, "robots", "noindex, nofollow", string.Empty, 2);
        GenerateMeta(string.Empty, "robots", "noindex, nofollow", string.Empty, 2);
        GenerateCss(CurrentDomainRootPath + @"scripts/ymPrompt/skin/black/ymPrompt.css?v=" + CommonMethod.Version, 5);
        GenerateCss(CurrentDomainRootPath + @"style/admin/one/validator.css?v=" + CommonMethod.Version, 5);
        GenerateCss(CurrentDomainRootPath + @"style/admin/one/pop-up.css?v=" + CommonMethod.Version, 3);
        GenerateCss(CurrentDomainRootPath + @"style/admin/one/common.css?v=" + CommonMethod.Version, 4);
        GenerateScript(CurrentDomainRootPath + @"scripts/jquery-1.7.2.min.js?v=" + CommonMethod.Version, 6);
        GenerateScript(CurrentDomainRootPath + @"scripts/ymPrompt/ymPrompt.js?v=" + CommonMethod.Version, 7);
        GenerateScript(CurrentDomainRootPath + @"scripts/common.js?v=" + CommonMethod.Version, 8);
        GenerateScript(CurrentDomainRootPath + @"scripts/admin/pop-up.js?v=" + CommonMethod.Version, 9);

    }

    /// <summary>
    /// Url 参数
    /// </summary>
    public string Action
    {
        get
        {
            string action = "";
            if (Request.QueryString["action"] != null)
            {
                action = Request.QueryString["action"].Trim().ToLower();
            }
            return action;
        }
    }


    //protected override void OnPreLoad(EventArgs e)
    //{
        
    //}

}