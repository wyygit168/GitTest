//查询乡镇列表
function setpagination(pageindex) {
    var v_action = DataSet.areatown;
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_province = $("#drpProvince").val().replace(/\s/g, "");
    var v_city = $("#drpCity").val().replace(/\s/g, "");
    var v_county = $("#ddlCountyID").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + pageindex + "&extend1=" + v_province + "&extend3=" + v_city + "&extend4=" + v_county + "&s=" + Math.random();
    ajaxfuncbyloadmsg("townlist_system.axd", pars, "#divContent", errorfunc, successListfunc);
}

//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.areatownstatus;
    detailoperation("changetownstatus_system.axd", v_action, autoid, curstatus);

}

//删除单个乡镇
function deleteopertion(autoid) {
    var v_action = DataSet.singledeletefortown;
    detailoperation("deletetown_system.axd", v_action, autoid, "");
}

//批量删除乡镇
function batchdeloperation(autoid) {
    var v_action = DataSet.batchdeletefortown;
    detailoperation("batchdeletetown_system.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) { 
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var v_province = $("#drpProvince").val().replace(/\s/g, "");
    var v_city = $("#drpCity").val().replace(/\s/g, "");
    var v_county = $("#ddlCountyID").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&extend1=" + v_province + "&extend3=" + v_city + "&extend4=" + v_county + "&s=" + Math.random();
    if (autoid == "0") { //批量删除
        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    }
    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    }
}


function ajaxgetareastr(data) {
    var dataarry = data.split("$&%$");
    if (dataarry[1] == "1") {
        $("#drpCity").html(dataarry[0]).attr("style", "width:95%;");
    }
    else if (dataarry[1] == "2") {
        $("#ddlCountyID").html(dataarry[0]).attr("style", "width:95%;");
    }
}

function getcitybyprovince() {
    //$("#ddlCountyID ").get(0).selectedIndex = 0;
    $("#ddlCountyID ").html("<option value=''>请选择</option>").attr("style", "width:95%;");
    var v_province = $("#drpProvince").val();
    ajaxgetarealist("1", v_province);
}

function getcountybycity() {
    var v_areaid = $("#drpCity").val();
    ajaxgetarealist("2", v_areaid);
}

 $(function () {
     $("#drpProvince").change(getcitybyprovince);
     $("#drpCity").click(getcountybycity);
 });
