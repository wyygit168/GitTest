//查询绑定客户域名列表(分页)
function setpagination(pageindex) {
    var v_action = DataSet.systemcustomdomain;
    var v_title = $("#txtCustomerTitle").val().replace(/\s/g, "");
    var v_realname = $("#txtDomainTitle").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&extend1=" + v_realname + "&pageindex=" + pageindex + "&s=" + Math.random();
    ajaxfuncbyloadmsg("customerdomainlist_system.axd", pars, "#divContent", errorfunc, successListfunc);
}


//删除单个绑定客户域名
function deleteopertion(autoid) {
    var v_action = DataSet.singledeleteforcustomerdomain;
    detailoperation("deletecustomerdomain_system.axd", v_action, autoid, "");
}

//批量删除绑定客户域名
//function batchdeloperation(autoid) {
//    var v_action = DataSet.batchdeleteforcustomerdomain;
//    detailoperation("batchdeletecustomerdomain_system.axd", v_action, "0", autoid);
//}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) {
    var v_title = $("#txtCustomerTitle").val().replace(/\s/g, ""); 
    var v_realname = $("#txtDomainTitle").val().replace(/\s/g, ""); 
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&s=" + Math.random();
    //    if (autoid == "0") { //批量删除 
    //        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    //    }
    //    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    //}
}

        
      






function closepriview(autoID) {
    var pageIndex = $("#txtPageIndex").val();
    var title = $("#txtTitle").val().replace(/\s/g, "");
    var status = $("#ddlStatus").val().replace(/\s/g, "");
    var pars = "action=closePriview&AutoID=" + autoID + "&title=" + title + "&status=" + status + "&pageIndex=" + pageIndex + "&s=" + Math.random();
    ajaxOperation(pars, 'SystemCustomer.aspx', "0");
    ymPrompt.succeedInfo({ title: '温馨提示', message: '客户权限已关闭' });

}       
      