//查询资讯速递列表
function setpagination(pageindex) {
    var v_action = DataSet.webfarmingnews;
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_opertype = $("#ddlOpertype").val().replace(/\s/g, "");
    var v_village = $("#ddlVillage").val().replace(/\s/g, ""); 
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&extend1=" + v_opertype + "&extend3=" + v_village + "&pageindex=" + pageindex + "&s=" + Math.random();
    ajaxfuncbyloadmsg("farmingnewslist_web.axd", pars, "#divContent", errorfunc, successListfunc);
}

//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.webfarmingnewsstatus;
    detailoperation("changefarmingnewsstatus_web.axd", v_action, autoid, curstatus);

}

//删除单个资讯速递
function deleteopertion(autoid) {
    var v_action = DataSet.singledeleteforwebfarmingnews;
    detailoperation("deletefarmingnews_web.axd", v_action, autoid, "");
}

//批量删除资讯速递
function batchdeloperation(autoid) {
    var v_action = DataSet.batchdeleteforwebfarmingnews;
    detailoperation("batchdeletefarmingnews_web.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var v_opertype = $("#ddlOpertype").val().replace(/\s/g, "");
    var v_village = $("#ddlVillage").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend1=" + v_opertype + "&extend2=" + curstatus + "&extend3=" + v_village + "&s=" + Math.random();
    if (autoid == "0") { //批量删除
        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    }
    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    }
}