using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using BLL.Service;
using BusinessEntity;
using System.Text;

namespace BLL.Ajax_WebSet
{
    /// <summary>
    ///AjaxCall_System 的摘要说明
    /// </summary>
    public class AjaxCall_WebSet : SystemBasePage, IHttpHandler, IRequiresSessionState
    {
        /// <summary>
        /// 您将需要在您网站的 web.config 文件中配置此处理程序，
        /// 并向 IIS 注册此处理程序，然后才能进行使用。有关详细信息，
        /// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public new bool IsReusable
        {
            // 如果无法为其他请求重用托管处理程序，则返回 false。
            // 如果按请求保留某些状态信息，则通常这将为 false。
            get { return true; }
        }

        public override void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
            string strReturnData = string.Empty; 
            AjaxHelper ajaxHelper = AjaxHelper.GetRequestParamters(context.Request.Form.ToString());
            PageStatus = ajaxHelper.PageStatus; 
            HttpCookie cookie = context.Request.Cookies[CT];
             if (Session["systemusers"] != null)
             {
                
                 WebSet webset = new WebSet(ajaxHelper.PageStatus);
                 switch (ajaxHelper.Action.ToLower())
                 {
                    
                     #region 网站菜单

                     case WebData.WebMenu://网站菜单查询
                         strReturnData = webset.GetHtmlString(ajaxHelper);
                         break;
                     case WebData.WebMenuStatus://改变网站菜单状态并查询 
                         strReturnData = webset.ChangeWebMenuStatusAndSearchList(ajaxHelper);
                         break;
                     case WebData.CheckWebMenuNameExist://判断网站菜单名称是否存在 
                         strReturnData = webset.CheckWebMenuNameExist(ajaxHelper);
                         break;
                     case WebData.SingleDeleteForWebMenu: //删除单个网站菜单
                         strReturnData = webset.SingleDeleteForWebMenu(ajaxHelper);
                         break;
                     case WebData.BatchDeleteForWebMenu: //批量删除网站菜单
                         strReturnData = webset.BatchDeleteForWebMenu(ajaxHelper);
                         break;
                     case WebData.WebMenuEnableStatus: //更改网站菜单启用状态
                         strReturnData = webset.ChangeWebMenuEnableStatusAndSearchList(ajaxHelper);
                         break;
                         
                     #endregion

                     #region 资讯速递

                     case WebData.WebFarmingNews://获取资讯速递列表
                         strReturnData = webset.GetHtmlString(ajaxHelper);
                         break;
                     case WebData.WebFarmingNewsStatus://改变资讯速递状态并查询 
                         strReturnData = webset.ChangeWebFarmingNewsStatusAndSearchList(ajaxHelper);
                         break;                   
                     case WebData.SingleDeleteForWebFarmingNews: //删除单个资讯速递
                         strReturnData = webset.SingleDeleteForWebFarmingNews(ajaxHelper);
                         break;
                     case WebData.BatchDeleteForWebFarmingNews: //批量删除资讯速递
                         strReturnData = webset.BatchDeleteForWebFarmingNews(ajaxHelper);
                         break; 

                     #endregion

                     #region 魅力乡村-乡村概述

                     case WebData.WebBeautifulVillage://获取魅力乡村列表
                         strReturnData = webset.GetHtmlString(ajaxHelper);
                         break;
                     case WebData.WebBeautifulVillageStatus://改变魅力乡村状态并查询 
                         strReturnData = webset.ChangeWebBeautifulVillageStatusAndSearchList(ajaxHelper);
                         break;                   
                     case WebData.SingleDeleteForWebBeautifulVillage: //删除单个魅力乡村
                         strReturnData = webset.SingleDeleteForWebBeautifulVillage(ajaxHelper);
                         break;
                     case WebData.BatchDeleteForWebBeautifulVillage: //批量删除魅力乡村
                         strReturnData = webset.BatchDeleteForWebBeautifulVillage(ajaxHelper);
                         break;

                     #endregion

                     #region 魅力乡村-乡村图片

                     case WebData.WebBeautifulVillageImage://获取魅力乡村-图片列表
                     case WebData.WebLbtImage://获取图片设置-图片列表
                         strReturnData = webset.GetHtmlString(ajaxHelper);
                         break;
                     case WebData.WebBeautifulVillageImageStatus://改变魅力乡村-图片状态并查询 
                         strReturnData = webset.ChangeWebBeautifulVillageFileStatusAndSearchList(ajaxHelper);
                         break;
                     case WebData.SingleDeleteForWebBeautifulImageVillage: //删除单个魅力乡村-图片
                         strReturnData = webset.SingleDeleteForWebBeautifulVillageFile(ajaxHelper);
                         break;
                     case WebData.BatchDeleteForWebBeautifulImageVillage: //批量删除魅力乡村-图片
                         strReturnData = webset.BatchDeleteForWebBeautifulVillageFile(ajaxHelper);
                         break;

                     #endregion


                     default:
                         strReturnData = ""; //WanerDaoJSON.GetErrorJson("没有对应类型处理!");
                         break;
                 }
             }
             else
             {
                 strReturnData = "returnLogion";
             }

            CommonMethod.ResponseContent(strReturnData);

        }
        
        #endregion

    }
}