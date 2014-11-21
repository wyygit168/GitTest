//查询资源列表
function setpagination(pageindex) {
    var v_action = DataSet.systemmenu;
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_menuurl = $("#txtMenuUrl").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_topmenu = $("#ddlTopMenuID").val().replace(/\s/g, "");
    var v_onemenu = $("#ddlOneMenu").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus="+pagestaus+"&title=" + v_title + "&extend1=" + v_menuurl + "&extend4=" + v_topmenu + "&extend3=" + v_onemenu + "&status=" + v_status + "&pageindex=" + pageindex + "&s=" + Math.random();
    ajaxfuncbyloadmsg("menulist_system.axd", pars, "#divContent", errorfunc, successListfunc);
}

//改变资源状态
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.systemmenustatus;
    detailoperation("changestatusformenu_system.axd", v_action, autoid, curstatus);

}

//删除单个资源
function deleteopertion(autoid) {
    var v_action = DataSet.singledeleteformenu;
    detailoperation("deletemenu_system.axd", v_action, autoid, "");
}

//批量删除资源
function batchdeloperation(autoid) {
    var v_action = DataSet.batchdeleteformenu;
    detailoperation("batchdeletemenu_system.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_menuurl = $("#txtMenuUrl").val().replace(/\s/g, "");
    var v_topmenu = $("#ddlTopMenuID").val().replace(/\s/g, "");
    var v_onemenu = $("#ddlOneMenu").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&extend1=" + v_menuurl + "&extend4=" + v_topmenu + "&extend3=" + v_onemenu + "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&s=" + Math.random();
    if (autoid == "0") { //批量删除
        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    }
    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    }
} 

// 异步加载一级下拉菜单
function chanageTopMenu() {
    var v_title = $("#ddlTopMenuID").val();
    var v_action = DataSet.changetopmenu;
    var pars = 'action=' + v_action + "&pagestatus=" + pagestaus + '&title=' + v_title + '&s=' + Math.random();
    ajaxfunc("loadonemenu_system.axd", pars, errorfunc, successchanagetopmenu);
}
function successchanagetopmenu(data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        $("#ddlOneMenu").html(data);
        $("#ddlOneMenu").attr("style","width:95%;")
    }
 }

$(function () {
    $("#ddlTopMenuID").change(chanageTopMenu).click(chanageTopMenu); 
});  