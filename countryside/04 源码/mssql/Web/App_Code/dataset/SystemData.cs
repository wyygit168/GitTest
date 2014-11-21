using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// 数据设置类：系统设置数据
/// </summary>
public class SystemData
{
     #region 更新缓存
     /// <summary>
     /// 获取系统用户列表
     /// </summary>
    public const string UpdataCache = "updatacache";
     #endregion

     #region 系统用户

     #region 获取系统用户列表
    /// <summary>
     /// 获取系统用户列表
     /// </summary>
	 public  const string SystemUser="systemuser";
     #endregion

     #region 更新系统用户状态
     /// <summary>
     /// 更新系统用户状态
     /// </summary>
     public  const string SystemUserStatus = "systemuserstatus";
     #endregion

     #region 检查系统用户名称是否存在
     /// <summary>
     /// 检查系统用户名称是否存在
     /// </summary>
     public const string CheckUserNameExist = "checkusernameexist";
     #endregion 

     #region 系统用户单个删除
     /// <summary>
     /// 系统用户单个删除
     /// </summary>
     public const string SingleDeleteForUser = "singledeleteforuser";
     #endregion

     #region 系统用户批量删除
     /// <summary>
     /// 系统用户批量删除
     /// </summary>
     public const string BatchDeleteForUser = "batchdeleteforuser";
     #endregion

     #region 检查原密码是否正确
     /// <summary>
     /// 检查原密码是否正确
     /// </summary>
     public const string CheckOriginalPwd = "checkoriginalpwd";
     #endregion

     #region 系统用户详细页面路径
     
     /// <summary>
     /// 系统用户详细页面路径
     /// </summary>
     public const string DetailForUser = "admin/systemset/systemuserdetail.aspx";

     #endregion

     #endregion

     #region 系统角色

     #region 获取系统角色列表
     /// <summary>
     /// 获取系统角色列表
     /// </summary>
     public const string SystemRole = "systemrole";
     #endregion

     #region 更新系统角色状态
     /// <summary>
     /// 更新系统角色状态
     /// </summary>
     public const string SystemRoleStatus = "systemrolestatus";
     #endregion

     #region 检查系统角色名称是否存在
     /// <summary>
     /// 检查系统角色名称是否存在
     /// </summary>
     public const string CheckRoleNameExist = "checkrolenameexist";
     #endregion

     #region 系统角色单个删除
     /// <summary>
     /// 系统角色单个删除
     /// </summary>
     public const string SingleDeleteForRole = "singledeleteforrole";

     #endregion

     #region 系统角色批量删除
     /// <summary>
     /// 系统角色批量删除
     /// </summary>
     public const string BatchDeleteForRole = "batchdeleteforrole"; 
     #endregion

     #region 系统角色详细页面路径

     /// <summary>
     /// 系统角色详细页面路径
     /// </summary>
     public const string DetailForRole = "admin/systemset/systemroledetail.aspx";

     #endregion

     #endregion

     #region 系统资源

     #region 获取系统资源列表
     /// <summary>
     /// 获取系统资源列表
     /// </summary>
     public const string SystemMenu = "systemmenu";
     #endregion

     #region 更新系统资源状态
     /// <summary>
     /// 更新系统资源状态
     /// </summary>
     public const string SystemMenuStatus = "systemmenustatus";
     #endregion

     #region 检查系统资源名称是否存在
     /// <summary>
     /// 检查系统资源名称是否存在
     /// </summary>
     public const string CheckMenuNameExist = "checkmenunameexist";
     #endregion

     #region 系统资源单个删除
     /// <summary>
     /// 系统资源单个删除
     /// </summary>
     public const string SingleDeleteForMenu = "singledeleteformenu";

     #endregion

     #region 系统资源批量删除
     /// <summary>
     /// 系统资源批量删除
     /// </summary>
     public const string BatchDeleteForMenu = "batchdeleteformenu";
     #endregion

     #region 改变系统资源顶级菜单
     /// <summary>
     ///  改变系统资源顶级菜单
     /// </summary>
     public const string ChangeTopMenu = "changetopmenu";
     #endregion

     #region 系统资源详细页面路径

     /// <summary>
     /// 系统资源详细页面路径
     /// </summary>
     public const string DetailForMenu = "admin/systemset/systemmenudetail.aspx";

     #endregion
     #endregion

     #region 授予资源
     /// <summary>
     /// 授予资源
     /// </summary>
     public const string SystemAwardMenu = "awardmenu";
     #endregion

     #region 授予资源页面路径
     /// <summary>
     /// 授予资源页面路径
     /// </summary>
     public const string DetailForAwardMenu = "admin/systemset/awardmenu.aspx";
     #endregion

     #region 授予角色页面路径
     /// <summary>
     /// 授予角色页面路径
     /// </summary>
     public const string DetailForAwardRole = "admin/systemset/awardrole.aspx";
     
     #endregion

     #region 基础数据设置

     #region 登陆系统标题
     /// <summary>
     /// 登陆系统标题
     /// </summary>
     public const string BaseInfo_LoginTitle = "logintitle"; 
     
     #endregion

     #region 设置登陆系统标题
     /// <summary>
     /// 设置登陆系统标题
     /// </summary>
     public const string BaseInfo_SetLoginTitle = "setlogintitle";
     #endregion

     #region 查询登陆系统标题
     /// <summary>
     /// 查询登陆系统标题
     /// </summary>
     public const string BaseInfo_SelectLoginTitle = "selectlogintitle";
     #endregion

     #region 网站名称
     /// <summary>
     /// 网站名称
     /// </summary>
     public const string BaseInfo_WebTitle = "WebTitle";
     #endregion

     #region 设置网站名称
     /// <summary>
     /// 设置网站名称
     /// </summary>
     public const string BaseInfo_SetWebTitle = "setwebtitle";
     #endregion

     #region 查询网站名称
     /// <summary>
     /// 查询网站名称
     /// </summary>
     public const string BaseInfo_SelectWebTitle = "selectwebtitle";
     #endregion

     #endregion

     #region 系统客户

     #region 获取系统客户列表
     /// <summary>
     /// 获取系统客户列表
     /// </summary>
     public const string SystemCustomer = "systemcustomer";
     #endregion

     #region 更新系统客户状态
     /// <summary>
     /// 更新系统客户状态
     /// </summary>
     public const string SystemCustomerStatus = "systemcustomerstatus";
     #endregion

     #region 检查系统客户名称是否存在
     /// <summary>
     /// 检查系统客户名称是否存在
     /// </summary>
     public const string CheckCustomerNameExist = "checkcustomernameexist";
     #endregion

     #region 系统客户单个删除
     /// <summary>
     /// 系统客户单个删除
     /// </summary>
     public const string SingleDeleteForCustomer = "singledeleteforcustomer";
     #endregion

     #region 系统客户批量删除
     /// <summary>
     /// 系统客户批量删除
     /// </summary>
     public const string BatchDeleteForCustomer = "batchdeleteforcustomer";
     #endregion

     

     #region 系统客户详细页面路径

     /// <summary>
     /// 系统客户详细页面路径
     /// </summary>
     public const string DetailForCustomer = "admin/systemset/systemcustomerdetail.aspx";

     #endregion

     #endregion

     #region 系统域名

     #region 获取系统域名列表
     /// <summary>
     /// 获取系统域名列表
     /// </summary>
     public const string SystemDomain = "systemdomain";
     #endregion

     #region 更新系统域名状态
     /// <summary>
     /// 更新系统域名状态
     /// </summary>
     public const string SystemDomainStatus = "systemdomainstatus";
     #endregion

     #region 检查系统域名名称是否存在
     /// <summary>
     /// 检查系统客户名称是否存在
     /// </summary>
     public const string CheckDomainNameExist = "checkdomainnameexist";
     #endregion

     #region 系统域名单个删除
     /// <summary>
     /// 系统域名单个删除
     /// </summary>
     public const string SingleDeleteForDomain = "singledeletefordomain";
     #endregion

     #region 系统域名批量删除
     /// <summary>
     /// 系统域名批量删除
     /// </summary>
     public const string BatchDeleteForDomain = "batchdeletefordomain";
     #endregion 

     #region 系统域名详细页面路径

     /// <summary>
     /// 系统域名详细页面路径
     /// </summary>
     public const string DetailForDomain = "admin/systemset/systemdomaindetail.aspx";

     #endregion
    
     #endregion

     #region 客户域名绑定
     #region 获取客户域名绑定列表
     /// <summary>
     /// 获取客户域名绑定列表
     /// </summary>
     public const string SystemCustomerDomain = "systemcustomdomain";
     #endregion

     #region 更新绑定客户域名状态
     /// <summary>
     /// 更新绑定客户域名状态
     /// </summary>
     public const string SystemCustomerDomainStatus = "systemcustomerdomainstatus";
     #endregion

     #region 绑定客户域名单个删除
     /// <summary>
     /// 绑定客户域名单个删除
     /// </summary>
     public const string SingleDeleteForCustomerDomain = "singledeleteforcustomerdomain";
     #endregion

     #region 绑定客户域名批量删除
     /// <summary>
     /// 绑定客户域名批量删除
     /// </summary>
     public const string BatchDeleteForCustomerDomain = "batchdeleteforcustomerdomain";
     #endregion

     #region 绑定客户域名详细页面路径

     /// <summary>
     /// 绑定客户域名详细页面路径
     /// </summary>
     public const string DetailForCustomerDomain = "admin/systemset/systemdomainbinddetail.aspx";

     #endregion

    #endregion

     #region 省设置

     #region 获取省列表
     /// <summary>
     /// 获取省列表
     /// </summary>
     public const string AreaProvince = "areaprovince";
     #endregion

     #region 更新省状态
     /// <summary>
     /// 更新省状态
     /// </summary>
     public const string AreaProvinceStatus = "areaprovincestatus";
     #endregion

     #region 检查省名称是否存在
     /// <summary>
     /// 检查省名称是否存在
     /// </summary>
     public const string CheckProvinceNameExist = "checkprovincenameexist";
     #endregion

     #region 省单个删除
     /// <summary>
     /// 省单个删除
     /// </summary>
     public const string SingleDeleteForProvince = "singledeleteforprovince";

     #endregion

     #region 省批量删除
     /// <summary>
     /// 省批量删除
     /// </summary>
     public const string BatchDeleteForProvince = "batchdeleteforprovince";
     #endregion

     #region 省详细页面路径

     /// <summary>
     /// 省详细页面路径
     /// </summary>
     public const string DetailForProvince = "admin/systemset/areaprovincesetdetail.aspx";

     #endregion

    #endregion

     #region 城市设置

     #region 获取城市列表
     /// <summary>
     /// 获取城市列表
     /// </summary>
     public const string AreaCity = "areacity";
     #endregion

     #region 更新城市状态
     /// <summary>
     /// 更新城市状态
     /// </summary>
     public const string AreaCityStatus = "areacitystatus";
     #endregion

     #region 检查城市名称是否存在
     /// <summary>
     /// 检查城市名称是否存在
     /// </summary>
     public const string CheckCityNameExist = "checkcitynameexist";
     #endregion

     #region 城市单个删除
     /// <summary>
     /// 城市单个删除
     /// </summary>
     public const string SingleDeleteForCity = "singledeleteforcity";

     #endregion

     #region 城市批量删除
     /// <summary>
     /// 城市批量删除
     /// </summary>
     public const string BatchDeleteForCity = "batchdeleteforcity";
     #endregion

     #region 城市详细页面路径

     /// <summary>
     /// 城市详细页面路径
     /// </summary>
     public const string DetailForCity = "admin/systemset/areacitysetdetail.aspx";

     #endregion

     #endregion

     #region 县设置

     #region 获取县列表
     /// <summary>
     /// 获取县列表
     /// </summary>
     public const string AreaCounty = "areacounty";
     #endregion

     #region 更新县状态
     /// <summary>
     /// 更新县状态
     /// </summary>
     public const string AreaCountyStatus = "areacountystatus";
     #endregion

     #region 检查县名称是否存在
     /// <summary>
     /// 检查县名称是否存在
     /// </summary>
     public const string CheckCountyNameExist = "checkcountynameexist";
     #endregion

     #region 县单个删除
     /// <summary>
     /// 县单个删除
     /// </summary>
     public const string SingleDeleteForCounty = "singledeleteforcounty";

     #endregion

     #region 县批量删除
     /// <summary>
     /// 县批量删除
     /// </summary>
     public const string BatchDeleteForCounty = "batchdeleteforcounty";
     #endregion

     #region 县详细页面路径

     /// <summary>
     /// 县详细页面路径
     /// </summary>
     public const string DetailForCounty = "admin/systemset/areacountysetdetail.aspx";

     #endregion

     #endregion
    
     #region 乡镇设置

     #region 获取乡镇列表
     /// <summary>
     /// 获取乡镇列表
     /// </summary>
     public const string AreaTown = "areatown";
     #endregion

     #region 更新乡镇状态
     /// <summary>
     /// 更新乡镇状态
     /// </summary>
     public const string AreaTownStatus = "areatownstatus";
     #endregion

     #region 检查乡镇名称是否存在
     /// <summary>
     /// 检查乡镇名称是否存在
     /// </summary>
     public const string CheckTownNameExist = "checktownnameexist";
     #endregion

     #region 乡镇单个删除
     /// <summary>
     /// 乡镇单个删除
     /// </summary>
     public const string SingleDeleteForTown = "singledeletefortown";

     #endregion

     #region 乡镇批量删除
     /// <summary>
     /// 乡镇批量删除
     /// </summary>
     public const string BatchDeleteForTown = "batchdeletefortown";
     #endregion

     #region 乡镇详细页面路径

     /// <summary>
     /// 乡镇详细页面路径
     /// </summary>
     public const string DetailForTown = "admin/systemset/areatownsetdetail.aspx";

     #endregion

     #endregion

     #region 乡村设置

     #region 获取乡村列表
     /// <summary>
     /// 获取乡村列表
     /// </summary>
     public const string AreaVillage = "areavillage";
     #endregion

     #region 更新乡村状态
     /// <summary>
     /// 更新乡村状态
     /// </summary>
     public const string AreaVillageStatus = "areavillagestatus";
     #endregion

     #region 检查乡村名称是否存在
     /// <summary>
     /// 检查乡村名称是否存在
     /// </summary>
     public const string CheckVillageNameExist = "checkvillagenameexist";
     #endregion

     #region 乡村单个删除
     /// <summary>
     /// 乡村单个删除
     /// </summary>
     public const string SingleDeleteForVillage = "singledeleteforvillage";

     #endregion

     #region 乡村批量删除
     /// <summary>
     /// 乡村批量删除
     /// </summary>
     public const string BatchDeleteForVillage = "batchdeleteforvillage";
     #endregion

     #region 乡村详细页面路径

     /// <summary>
     /// 乡村详细页面路径
     /// </summary>
     public const string DetailForVillage = "admin/systemset/areavillagesetdetail.aspx";

     #endregion

     #endregion

     #region 根据省获取城市
     /// <summary>
     /// 根据省获取城市
     /// </summary>
     public const string GetCityByProvince = "getcitybyprovince";
     #endregion

     #region 根据城市获取县、区列表
     public const string   GetCountyByCity="getcountybycity"; //根据城市获取县、区列表
     #endregion

     #region 根据县、区获取乡镇列表
     public const string   GetTownByCounty="gettownbycounty"; //根据县、区获取乡镇列表
     #endregion
}
     
 
    
