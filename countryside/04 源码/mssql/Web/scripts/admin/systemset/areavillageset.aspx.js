//查询乡镇列表
function setpagination(pageindex) {
    var v_action = DataSet.areavillage;
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_province = $("#drpProvince").val().replace(/\s/g, "");
    var v_city = $("#drpCity").val().replace(/\s/g, "");
    var v_county = $("#ddlCountyID").val().replace(/\s/g, "");
    var v_town = $("#ddlTownID").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + pageindex + "&extend1=" + v_province + "&extend3=" + v_city + "&extend4=" + v_county +"&extend5=" + v_town+"&s=" + Math.random();
    ajaxfuncbyloadmsg("villagelist_system.axd", pars, "#divContent", errorfunc, successListfunc);
}

//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.arevillagestatus;
    detailoperation("changevillagestatus_system.axd", v_action, autoid, curstatus);

}

//删除单个乡镇
function deleteopertion(autoid) {
    var v_action = DataSet.singledeleteforvillage;
    detailoperation("deletevillage_system.axd", v_action, autoid, "");
}

//批量删除乡镇
function batchdeloperation(autoid) {
    var v_action = DataSet.batchdeletefortown;
    detailoperation("batchdeletevillage_system.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) { 
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var v_province = $("#drpProvince").val().replace(/\s/g, "");
    var v_city = $("#drpCity").val().replace(/\s/g, "");
    var v_county = $("#ddlCountyID").val().replace(/\s/g, "");
    var v_town = $("#ddlTownID").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&extend1=" + v_province + "&extend3=" + v_city + "&extend4=" + v_county +"&extend5=" +v_town+"&s=" + Math.random();
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
    else if (dataarry[1] == "3") {
        $("#ddlTownID").html(dataarry[0]).attr("style", "width:95%;");
   }
}

function getcitybyprovince() {
    var v_province = $("#drpProvince").val();
    $("#ddlCountyID ").html("<option value=''>请选择</option>").attr("style", "width:95%;");
    $("#ddlTownID ").html("<option value=''>请选择</option>").attr("style", "width:95%;"); 
    ajaxgetarealist("1", v_province);
}

function getcountybycity() {
    var v_areaid = $("#drpCity").val();
    $("#ddlTownID ").html("<option value=''>请选择</option>").attr("style", "width:95%;"); 
    ajaxgetarealist("2", v_areaid);
}

function gettownbycounty() {
    var v_areaid = $("#ddlCountyID").val();
    ajaxgetarealist("3", v_areaid);
}
 $(function () {
     $("#drpProvince").change(getcitybyprovince);
     $("#drpCity").click(getcountybycity);
     $("#ddlCountyID").click(gettownbycounty);
 });
