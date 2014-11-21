using System;
using System.Web;
using System.Web.SessionState;
 
using System.Collections;
using System.Collections.Generic;
 
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
 
using System.Linq;
using System.Text.RegularExpressions; 

namespace BLL_Web.Ajax
{
    public class AjaxCall : WebBasePage, IHttpHandler, IRequiresSessionState
    {
        /// <summary>
        /// 您将需要在您网站的 web.config 文件中配置此处理程序，
        /// 并向 IIS 注册此处理程序，然后才能进行使用。有关详细信息，
        /// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        
        #region IHttpHandler Members

        public bool IsReusable
        {
            // 如果无法为其他请求重用托管处理程序，则返回 false。
            // 如果按请求保留某些状态信息，则通常这将为 false。
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
            string json = string.Empty;
            AjaxHelper ajaxHelper = AjaxHelper.GetRequestParamters(context.Request.Form.ToString());
            OperationMethod om=new OperationMethod ();
            switch (ajaxHelper.Action.ToLower())
            {

                case "farmingnews":
                    json = om.GetFarmingNewForAjax(ajaxHelper);
                    break;

                case "webregister": //注册
                    json = om.WebUserRegister(ajaxHelper);
                    break;
                case "checkcode": //检查验证码
                    json = om.RegisterCheckCode(ajaxHelper);
                    break;
                case "checknameexist": //检查姓名是否存在
                    json = om.RegisterNameExist(ajaxHelper);
                    break;
                case "wuserlogin": //网站用户登录
                    json = om.WebUserLgin(ajaxHelper);
                    break;
                 case "wuserexit": //网站用户退出
                    json = om.WebUserExit();
                    break;
                default:
                    json = ""; //WanerDaoJSON.GetErrorJson("没有对应类型处理!");
                    break;
            }

             CommonMethod.ResponseContent(json); 
        }

       

        #endregion 

    }
}
