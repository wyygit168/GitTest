//查询城市列表
function setpagination(pageindex) {
    var v_action = DataSet.areacity;
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_province = $("#drpProvince").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + pageindex + "&extend1=" + v_province + "&s=" + Math.random();
    ajaxfuncbyloadmsg("citylist_system.axd", pars, "#divContent", errorfunc, successListfunc);
}

//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.areacitystatus;
    detailoperation("changecitystatus_system.axd", v_action, autoid, curstatus);

}

//删除单个城市
function deleteopertion(autoid) {
    var v_action = DataSet.singledeleteforcity;
    detailoperation("deletecity_system.axd", v_action, autoid, "");
}

//批量删除城市
function batchdeloperation(autoid) {
    var v_action = DataSet.batchdeleteforcity;
    detailoperation("batchdeletecity_system.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) { 
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var v_province = $("#drpProvince").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&extend1=" + v_province + "&s=" + Math.random();
    if (autoid == "0") { //批量删除
        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    }
    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    }
}