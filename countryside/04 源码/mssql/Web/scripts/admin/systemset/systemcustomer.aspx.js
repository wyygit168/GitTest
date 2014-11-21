//查询客户列表(分页)
function setpagination(pageindex) {
    var v_action = DataSet.systemcustomer;
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_realname = $("#txtUserName").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_purviewstatus = $("#drpPurviewStatus").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&extend1=" + v_realname + "&extend2=" + v_purviewstatus + "&status=" + v_status + "&pageindex=" + pageindex + "&s=" + Math.random();
    ajaxfuncbyloadmsg("customerlist_system.axd", pars, "#divContent", errorfunc, successListfunc);
}
//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.systemcustomerstatus;
    detailoperation("changestatuscustomer_system.axd", v_action, autoid, curstatus);
}

//删除单个客户
function deleteopertion(autoid) {
    var v_action = DataSet.singledeleteforcustomer;
    detailoperation("deletecustomer_system.axd", v_action, autoid, "");
}

//批量删除客户
function batchdeloperation(autoid) {
    var v_action = DataSet.batchdeleteforcustomer;
    detailoperation("batchdeletecustomer_system.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd,action,autoid,curstatus) {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_realname = $("#txtUserName").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_purviewstatus = $("#drpPurviewStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&extend1=" + v_realname + "&extend2=" + v_purviewstatus + "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&s=" + Math.random();
    if (autoid == "0") { //批量删除客户
        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    }
    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    }
}

function closePriview(autoID) {
    var pageIndex = $("#txtPageIndex").val();
    var title = $("#txtTitle").val().replace(/\s/g, "");
    var status = $("#ddlStatus").val().replace(/\s/g, "");
    var pars = "action=closePriview&AutoID=" + autoID + "&title=" + title + "&status=" + status + "&pageIndex=" + pageIndex + "&s=" + Math.random();
    ajaxOperation(pars, 'SystemCustomer.aspx', "0");
    ymPrompt.succeedInfo({ title: '温馨提示', message: '客户权限已关闭' });

}       
      