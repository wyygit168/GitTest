//查询域名列表(分页)
function setpagination(pageindex) {
    var v_action = DataSet.systemdomain;
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title +  "&status=" + v_status + "&pageindex=" + pageindex + "&s=" + Math.random();
    ajaxfuncbyloadmsg("customerlist_system.axd", pars, "#divContent", errorfunc, successListfunc);
}
//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.systemdomainstatus;
    detailoperation("changestatuscustomer_system.axd", v_action, autoid, curstatus);
}

//删除单个域名
function deleteopertion(autoid) {
    var v_action = DataSet.singledeletefordomain;
    detailoperation("deletecustomer_system.axd", v_action, autoid, "");
}

//批量删除域名
function batchdeloperation(autoid) {
    var v_action = DataSet.batchdeletefordomain;
    detailoperation("batchdeletecustomer_system.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd,action,autoid,curstatus) {
    var v_title = $("#txtTitle").val().replace(/\s/g, ""); 
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title +  "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&s=" + Math.random();
    if (autoid == "0") { //批量删除客户
        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    }
    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    }
}

        
      