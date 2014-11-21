using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using BLL.Service;
using BusinessEntity;
using System.Text;

namespace BLL.Ajax_System
{
    /// <summary>
    ///AjaxCall_System 的摘要说明
    /// </summary>
    public class AjaxCall_System : SystemBasePage, IHttpHandler, IRequiresSessionState
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
             if (Session["systemusers"] != null)// || cookie != null)
             {
                 //if (cookie != null && Session["systemusers"] == null)
                 //{
                 //    string userAccount = CommonMethod.ClearInputText(DESEncrypt.Decrypt(cookie[CN]));
                 //    string password = CommonMethod.ClearInputText(DESEncrypt.Decrypt(cookie[CW]));
                 //    userAccount = HttpUtility.UrlDecode(userAccount, Encoding.Default);
                 //    password = HttpUtility.UrlDecode(password, Encoding.Default);
                 //    systemuserEntity objEntity = UtilitySearch.GetSystemUserByUserNameAndPwd(userAccount, password);
                 //    if (objEntity != null)
                 //    {
                 //        objEntity.RoleID = cookie[CE].ToInt();
                 //        Session["systemusers"] = objEntity;
                 //    }
                 //}
                 SystemSet systemset = new SystemSet(ajaxHelper.PageStatus);
                 switch (ajaxHelper.Action.ToLower())
                 {
                     #region 更新缓存
                     case SystemData.UpdataCache:
                         strReturnData = systemset.UpdataCache(ajaxHelper);
                         break;
                     #endregion

                     #region  系统用户

                     case SystemData.SystemUser://系统用户查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.SystemUserStatus://改变系统用户状态并查询 
                         strReturnData = systemset.ChangeUserStatusAndSearchList(ajaxHelper);
                         break;
                     case SystemData.CheckUserNameExist://判断系统用户是否存在 
                         strReturnData = systemset.CheckUserNameExist(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForUser: //删除单个系统用户
                         strReturnData = systemset.SingleDeleteForUser(ajaxHelper);
                         break;
                     case SystemData.BatchDeleteForUser: //批量删除系统用户
                         strReturnData = systemset.BatchDeleteForUser(ajaxHelper);
                         break;
                     case SystemData.CheckOriginalPwd: //检查原始密码是否正确
                         strReturnData = systemset.CheckOriginalPwd(ajaxHelper);
                         break;

                     #endregion

                     #region 系统角色

                     case SystemData.SystemRole://系统角色查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.SystemRoleStatus://改变系统角色状态并查询 
                         strReturnData = systemset.ChangeRoleStatusAndSearchList(ajaxHelper);
                         break;
                     case SystemData.CheckRoleNameExist://判断系统角色名称是否存在 
                         strReturnData = systemset.CheckRoleNameExist(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForRole: //删除单个系统角色
                         strReturnData = systemset.SingleDeleteForRole(ajaxHelper);
                         break;
                     case SystemData.BatchDeleteForRole: //批量删除系统角色
                         strReturnData = systemset.BatchDeleteForRole(ajaxHelper);
                         break;
                     #endregion

                     #region 系统资源

                     case SystemData.SystemMenu://系统资源查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.SystemMenuStatus://改变系统资源状态并查询 
                         strReturnData = systemset.ChangeMenuStatusAndSearchList(ajaxHelper);
                         break;
                     case SystemData.CheckMenuNameExist://判断系统资源名称是否存在 
                         strReturnData = systemset.CheckMenuNameExist(ajaxHelper);
                         break;
                     case SystemData.ChangeTopMenu://改变系统资源顶级下拉菜单，获取系统资源的一级菜单 
                         strReturnData = systemset.ChangeTopMenu(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForMenu: //删除单个系统资源
                         strReturnData = systemset.SingleDeleteForMenu(ajaxHelper);
                         break;
                     case SystemData.BatchDeleteForMenu: //批量删除系统资源
                         strReturnData = systemset.BatchDeleteForMenu(ajaxHelper);
                         break;

                     #endregion

                     #region 授予资源
                     case SystemData.SystemAwardMenu: //授予资源
                         strReturnData = systemset.AwardMenu(ajaxHelper);
                         break;
                     #endregion

                     #region 基础信息设置

                     #region 设置登陆系统标题
                     case SystemData.BaseInfo_SetLoginTitle: //设置登陆系统标题
                         strReturnData = systemset.SetLoginTitle(ajaxHelper);
                         break;
                     #endregion

                     #region 设置登陆网站标题
                     case SystemData.BaseInfo_SetWebTitle: //设置登陆网站标题
                         strReturnData = systemset.SetWebTitle(ajaxHelper);
                         break;
                     #endregion

                     #endregion

                     #region  系统客户

                     case SystemData.SystemCustomer://系统客户查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.SystemCustomerStatus://改变系统客户状态并查询 
                         strReturnData = systemset.ChangeCustomerStatusAndSearchList(ajaxHelper);
                         break;
                     case SystemData.CheckCustomerNameExist://判断系统客户是否存在 
                         strReturnData = systemset.CheckCustomerNameExist(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForCustomer: //删除单个系统客户
                         strReturnData = systemset.SingleDeleteForCustomer(ajaxHelper);
                         break;
                     case SystemData.BatchDeleteForCustomer: //批量删除系统客户
                         strReturnData = systemset.BatchDeleteForCustomer(ajaxHelper);
                         break;

                     #endregion

                     #region  系统域名

                     case SystemData.SystemDomain://系统客户查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.SystemDomainStatus://改变系统客户状态并查询 
                         strReturnData = systemset.ChangeDomainStatusAndSearchList(ajaxHelper);
                         break;
                     case SystemData.CheckDomainNameExist://判断系统客户是否存在 
                         strReturnData = systemset.CheckDomainNameExist(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForDomain: //删除单个系统客户
                         strReturnData = systemset.SingleDeleteForDomain(ajaxHelper);
                         break;
                     case SystemData.BatchDeleteForDomain: //批量删除系统客户
                         strReturnData = systemset.BatchDeleteForCustomer(ajaxHelper);
                         break;

                     #endregion

                     #region  绑定客户域名

                     case SystemData.SystemCustomerDomain://绑定客户域名查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForCustomerDomain: //删除单个绑定客户域名
                         strReturnData = systemset.SingleDeleteForCustomerDomain(ajaxHelper);
                         break;
                     //case DataSetHelper.BatchDeleteForCustomerDomain: //批量删除绑定客户域名
                     //strReturnData = systemset.BatchDeleteForCustomerDomain(ajaxHelper);
                     //break;

                     #endregion

                     #region 省设置

                     case SystemData.AreaProvince://省查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.AreaProvinceStatus://改变省状态并查询 
                         strReturnData = systemset.ChangeProvinceStatusAndSearchList(ajaxHelper);
                         break;
                     case SystemData.CheckProvinceNameExist://判断省名称是否存在 
                         strReturnData = systemset.CheckProvinceNameExist(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForProvince://删除单个省
                         strReturnData = systemset.SingleDeleteForProvince(ajaxHelper);
                         break;
                     case SystemData.BatchDeleteForProvince://批量删除省
                         strReturnData = systemset.BatchDeleteForProvince(ajaxHelper);
                         break;
                     #endregion

                     #region 城市设置

                     case SystemData.AreaCity://城市查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.AreaCityStatus://改变城市状态并查询 
                         strReturnData = systemset.ChangeCityStatusAndSearchList(ajaxHelper);
                         break;
                     case SystemData.CheckCityNameExist://判断城市名称是否存在 
                         strReturnData = systemset.CheckCityNameExist(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForCity://删除单个城市
                         strReturnData = systemset.SingleDeleteForCity(ajaxHelper);
                         break;
                     case SystemData.BatchDeleteForCity://批量删除城市
                         strReturnData = systemset.BatchDeleteForCity(ajaxHelper);
                         break;
                     #endregion

                     #region 县、区设置

                     case SystemData.AreaCounty://县、区查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.AreaCountyStatus://改变县、区状态并查询 
                         strReturnData = systemset.ChangeCountyStatusAndSearchList(ajaxHelper);
                         break;
                     case SystemData.CheckCountyNameExist://判断县、区名称是否存在 
                         strReturnData = systemset.CheckCountyNameExist(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForCounty://删除单个县、区
                         strReturnData = systemset.SingleDeleteForCounty(ajaxHelper);
                         break;
                     case SystemData.BatchDeleteForCounty://批量删除县、区
                         strReturnData = systemset.BatchDeleteForCounty(ajaxHelper);
                         break;
                     #endregion

                     #region 乡镇设置

                     case SystemData.AreaTown://乡镇查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.AreaTownStatus://改变乡镇状态并查询 
                         strReturnData = systemset.ChangeTownStatusAndSearchList(ajaxHelper);
                         break;
                     case SystemData.CheckTownNameExist://判断乡镇名称是否存在 
                         strReturnData = systemset.CheckTownNameExist(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForTown://删除单个乡镇
                         strReturnData = systemset.SingleDeleteForTown(ajaxHelper);
                         break;
                     case SystemData.BatchDeleteForTown://批量删除乡镇
                         strReturnData = systemset.BatchDeleteForTown(ajaxHelper);
                         break;
                     #endregion

                     #region 乡村设置

                     case SystemData.AreaVillage://乡村查询
                         strReturnData = systemset.GetHtmlString(ajaxHelper);
                         break;
                     case SystemData.AreaVillageStatus://改变乡村状态并查询 
                         strReturnData = systemset.ChangeVillageStatusAndSearchList(ajaxHelper);
                         break;
                     case SystemData.CheckVillageNameExist://判断乡村名称是否存在 
                         strReturnData = systemset.CheckVillageNameExist(ajaxHelper);
                         break;
                     case SystemData.SingleDeleteForVillage://删除单个乡村
                         strReturnData = systemset.SingleDeleteForVillage(ajaxHelper);
                         break;
                     case SystemData.BatchDeleteForVillage://批量删除乡村
                         strReturnData = systemset.BatchDeleteForVillage(ajaxHelper);
                         break;
                     #endregion

                     #region 获取地区列表
                     case SystemData.GetCityByProvince://根据省获取城市列表
                     case SystemData.GetCountyByCity://根据城市获取县区列表
                     case SystemData.GetTownByCounty://根据县区获取乡镇列表
                         strReturnData = systemset.GetAreaList(ajaxHelper);
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