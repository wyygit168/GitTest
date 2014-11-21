//查询网站菜单列表
function setpagination(pageindex) {
    var v_action = DataSet.webmenu;
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_enable = $("#ddlEnable").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&extend1=" + v_enable + "&pageindex=" + pageindex + "&s=" + Math.random();
    ajaxfuncbyloadmsg("webmenulist_web.axd", pars, "#divContent", errorfunc, successListfunc);
}

//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.webmenustatus;
    detailoperation("webmenustatus_web.axd", v_action, autoid, curstatus);

}
//更改禁用、启用状态
function changeenablestate(autoid, curstatus, currentuserid) {
    ymPrompt.confirmInfo({ title: '更改状态', message: '确定更改吗？', handler: function (tp) {
        if (tp == 'ok') {
            var v_action = DataSet.webmenuenablestatus;
            detailoperation("webmenuenablestatus_web.axd", v_action, autoid, curstatus);

        }
    }
    });
}
//删除单个网站菜单
function deleteopertion(autoid) {
    var v_action = DataSet.singledeleteforwebmenu;
    detailoperation("singledeleteforwebmenu_web.axd", v_action, autoid, "");
}

//批量删除网站菜单
function batchdeloperation(autoid) {
    var v_action = DataSet.batchdeleteforwebmenu;
    detailoperation("batchdeleteforwebmenu_web.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_enable = $("#ddlEnable").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&extend1=" + v_enable + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&s=" + Math.random();
    if (autoid == "0") { //批量删除
        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    }
    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    }
}