//查询省列表
function setpagination(pageindex) {
    var v_action = DataSet.areaprovince;
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + pageindex + "&s=" + Math.random();
    ajaxfuncbyloadmsg("provincelist_system.axd", pars, "#divContent", errorfunc, successListfunc);
}

//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.areaprovincestatus;
    detailoperation("changeprovincestatus_system.axd", v_action, autoid, curstatus);

}

//删除单个省
function deleteopertion(autoid) {
    var v_action = DataSet.singledeleteforprovince;
    detailoperation("deleteprovince_system.axd", v_action, autoid, "");
}

//批量删除角色
function batchdeloperation(autoid) {
    var v_action = DataSet.batchdeleteforprovince;
    detailoperation("batchdeleteprovince_system.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) { 
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&s=" + Math.random();
    if (autoid == "0") { //批量删除
        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    }
    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    }
}