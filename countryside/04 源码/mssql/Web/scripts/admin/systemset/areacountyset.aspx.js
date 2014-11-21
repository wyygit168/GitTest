//查询县、区列表
function setpagination(pageindex) {
    var v_action = DataSet.areacounty;
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_province = $("#drpProvince").val().replace(/\s/g, "");
    var v_city = $("#drpCity").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + pageindex + "&extend1=" + v_province + "&extend3=" + v_city + "&s=" + Math.random();
    ajaxfuncbyloadmsg("countylist_system.axd", pars, "#divContent", errorfunc, successListfunc);
}

//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.areacountystatus;
    detailoperation("changecountystatus_system.axd", v_action, autoid, curstatus);

}

//删除单个县、区
function deleteopertion(autoid) {
    var v_action = DataSet.singledeleteforcounty;
    detailoperation("deletecounty_system.axd", v_action, autoid, "");
}

//批量删除县、区
function batchdeloperation(autoid) {
    var v_action = DataSet.batchdeleteforcounty;
    detailoperation("batchdeletecounty_system.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) { 
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var v_province = $("#drpProvince").val().replace(/\s/g, "");
    var v_city = $("#drpCity").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&extend1=" + v_province + "&extend3=" + v_city + "&s=" + Math.random();
    if (autoid == "0") { //批量删除
        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    }
    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    }
}



function ajaxgetareastr(data) {
    var dataarry = data.split("$&%$");
    if (dataarry.length > 0) {
        if (dataarry[1] == "1") {
            $("#drpCity").html(dataarry[0]);
            $("#drpCity").attr("style", "width:95%;");
        } 
        
    }
 }
 function getcitybyprovince() {
     var v_province = $("#drpProvince").val();
     ajaxgetarealist("1", v_province);
 }

 $(function () {
     $("#drpProvince").change(getcitybyprovince);
 });
