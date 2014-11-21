//检查县、区名称是否存在
function checknameexist() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_provinceid = $("#ddlProvinceID").val().replace(/\s/g, "");
    var v_cityid = $("#ddlCityID").val().replace(/\s/g, "");
    var v_countyid=$("#ddlCountyID").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("乡镇名称不可以为空,请输入！"); return false;
    }
    else {
        $("#spanname").attr("class", "oncorrect").html("&nbsp;"); 
    }
    if (v_provinceid == "") {
        $("#spanprovincename").attr("class", "onerror").html("请选择所属省、直辖市！"); return false;
    }
    else {
        $("#spanprovincename").attr("class", "oncorrect").html("&nbsp;");
    }
    if (v_cityid == "") {
        $("#spancityname").attr("class", "onerror").html("请选择城市！"); return false;
    }
    else {
        $("#spancityname").attr("class", "oncorrect").html("&nbsp;");
    } 
    if (v_countyid == "") {
        $("#spancounty").attr("class", "onerror").html("请选择县、区！"); return false;
    }
    else {
        $("#spancounty").attr("class", "oncorrect").html("&nbsp;");
    } 

     var v_autoid = $("#txtAutoID").val().replace(/\s/g, ""); 
    var v_action = DataSet.checktownnameexist;
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&extend1=" + v_provinceid + "&extend3=" + v_cityid + "&extend4=" + v_countyid + "&autoid=" + v_autoid + "&s=" + Math.random();
    ajaxfunc("checktownname_system.axd", pars, errorfunc, successfuncForIsExist);
    if ($("#txtReturnValue").val() == "1")  return false; 
    else if ($("#txtReturnValue").val() == "0")  return true; 

}

var successfuncForIsExist = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        if (data == "Y") {
            $("#spanname").attr("class", "onerror").html("乡镇名称已存在,请重新输入！");
            $("#txtReturnValue").val("1");
        } else {
            $("#spanname").attr("class", "oncorrect").html("&nbsp;");
            $("#txtReturnValue").val("0");
        }
        if ($("#txtReturnValue").val() == "1") { return false; }
        else if ($("#txtReturnValue").val() == "0") { return true; }
    }
}
 

//保存验证
function btncheck() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_province = $("#ddlProvinceID").val().replace(/\s/g, "");
    var v_cityid = $("#ddlCityID").val().replace(/\s/g, "");
    var v_countyid = $("#ddlCountyID").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("乡镇名称不可以为空,请输入！"); return false;
        return false;
    }
    if (v_province == "") {
        $("#spanprovincename").attr("class", "onerror").html("请选择所属省、直辖市！"); return false;
        return false;
    }
    if (v_cityid == "") {
        $("#spancityname").attr("class", "onerror").html("请选择城市！"); return false;
    }
    if (v_countyid == "") {
        $("#spancounty").attr("class", "onerror").html("请选择县、区！"); return false;
    }
    else {
        return true;
    }
}


//function ajaxgetcitystr(data) {
//    $("#ddlCityID").html(data);
//    $("#ddlCityID").attr("style", "width:183px;height:25px;");
//}
//function getcitybyprovince() {
//    var v_province = $("#ddlProvinceID").val();
//    ajaxgetcitybyprovince(v_province);
//}

function ajaxgetareastr(data) {
    var dataarry = data.split("$&%$");
    if (dataarry[1] == "1") {
        $("#ddlCityID").html(dataarry[0]);
        $("#ddlCityID").attr("style", "width:183px;height:25px;");
    }
    else if (dataarry[1] == "2") {
        $("#ddlCountyID").html(dataarry[0]);
        $("#ddlCountyID").attr("style", "width:183px;height:25px;");
    }
}

function getcitybyprovince() {
    var v_province = $("#ddlProvinceID").val();
    if (v_province == "") {
        $("#spanprovincename").attr("class", "onerror").html("请选择所属省、直辖市！"); return false;
    }
    else {
        $("#spanprovincename").attr("class", "oncorrect").html("&nbsp;");
    }
    ajaxgetarealist("1", v_province);
}

function getcountybycity() {
    var v_areaid = $("#ddlCityID").val();
    ajaxgetarealist("2", v_areaid);
}

$(function () {
    $("#txtTitle").blur(checknameexist);
    $("#ddlCountyID").click(checknameexist);
    $("#btnSave").click(btncheck);
    $("#ddlProvinceID").change(getcitybyprovince).click(getcitybyprovince);
    $("#ddlCityID").change(getcountybycity).click(getcountybycity);
});