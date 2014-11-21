//常量设置
var DataSet = { 
    systemuser: "systemuser", //获取系统用户列表
    systemuserstatus: "systemuserstatus", //更新系统用户状态
    checkusernameexist: "checkusernameexist", //检查系统用户名称是否存在
    singledeleteforuser: "singledeleteforuser", //系统用户单个删除
    batchdeleteforuser: "batchdeleteforuser", //系统用户批量删除
    checkoriginalpwd: "checkoriginalpwd", //检查原始密码是否正确
    systemrole: "systemrole", //获取系统角色列表
    systemrolestatus: "systemrolestatus", //更新系统角色状态
    checkrolenameexist: "checkrolenameexist", //检查系统角色名称是否存在
    singledeleteforrole: "singledeleteforrole", //系统角色单个删除
    batchdeleteforrole: "batchdeleteforrole", //系统角色批量删除

    systemmenu: "systemmenu", //获取系统资源列表
    systemmenustatus: "systemmenustatus", //更新系统资源状态
    checkmenunameexist: "checkmenunameexist", //检查系统资源名称是否存在
    singledeleteformenu: "singledeleteformenu", //系统资源单个删除
    batchdeleteformenu: "batchdeleteformenu", //系统资源批量删除
    changetopmenu: "changetopmenu", //改变系统资源顶级菜单

    awardmenu: "awardmenu", //授予资源

    baseinfo_setlogintitle: "setlogintitle", //设置登陆系统标题
    baseinfo_selectlogintitle: "selectlogintitle", //查询登陆系统标题 

    baseinfo_setwebtitle: "setwebtitle", //设置网站名称
    baseinfo_selectwebtitle: "selectwebtitle", //查询网站名称 

    systemcustomer: "systemcustomer", //获取系统客户列表
    systemcustomerstatus: "systemcustomerstatus", //更新系统客户状态
    checkcustomernameexist: "checkcustomernameexist", //检查系统客户名称是否存在
    singledeleteforcustomer: "singledeleteforcustomer", //系统客户单个删除
    batchdeleteforcustomer: "batchdeleteforcustomer",  //系统客户批量删除

    systemdomain: "systemdomain", //获取系统域名列表
    systemdomainstatus: "systemdomainstatus", //更新系统域名状态
    checkdomainnameexist: "checkdomainnameexist", //检查系统域名名称是否存在
    singledeletefordomain: "singledeletefordomain", //系统域名单个删除
    batchdeletefordomain: "batchdeletefordomain",  //系统域名批量删除

    systemcustomdomain: "systemcustomdomain", //获取绑定客户域名列表
    //systemcustomerdomainstatus:"systemcustomerdomainstatus", //更新绑定客户域名状态
    singledeleteforcustomerdomain: "singledeleteforcustomerdomain", //绑定客户域名单个删除
    batchdeleteforcustomerdomain: "batchdeleteforcustomerdomain",  //绑定客户域名批量删除

    areaprovince: "areaprovince", // 获取省列表
    areaprovincestatus: "areaprovincestatus", // 更新省状态
    checkprovincenameexist: "checkprovincenameexist", // 检查省名称是否存在
    singledeleteforprovince: "singledeleteforprovince", // 省单个删除
    batchdeleteforprovince: "batchdeleteforprovince", //省批量删除

    areacity: "areacity", // 获取城市列表
    areacitystatus: "areacitystatus", // 更新城市状态
    checkcitynameexist: "checkcitynameexist", // 检查城市名称是否存在
    singledeleteforcity: "singledeleteforcity", // 城市单个删除
    batchdeleteforcity: "batchdeleteforcity", // 城市批量删除

    areacounty: "areacounty", // 获取县列表
    areacountystatus: "areacountystatus", // 更新县状态
    checkcountynameexist: "checkcountynameexist", // 检查县名称是否存在
    singledeleteforcounty: "singledeleteforcounty", // 县单个删除
    batchdeleteforcounty: "batchdeleteforcounty", // 县批量删除

    areatown: "areatown", // 获取乡镇列表
    areatownstatus: "areatownstatus", // 更新乡镇状态
    checktownnameexist: "checktownnameexist", // 检查乡镇名称是否存在
    singledeletefortown: "singledeletefortown", // 乡镇单个删除
    batchdeletefortown: "batchdeletefortown", // 乡镇批量删除


    areavillage: "areavillage", // 获取乡村列表
    areavillagestatus: "areavillagestatus", // 更新乡村状态
    checkvillagenameexist: "checkvillagenameexist", // 检查乡村名称是否存在
    singledeleteforvillage: "singledeleteforvillage", // 乡村单个删除
    batchdeleteforvillage: "batchdeleteforvillage",// 乡村批量删除

    getcitybyprovince: "getcitybyprovince", //根据省获取城市列表
    getcountybycity:"getcountybycity", //根据城市获取县、区列表
    gettownbycounty:"gettownbycounty" //根据省获取城市列表
}