//检查客户名称是否存在
function checkcustomernameexist() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("客户名称不可以为空,请输入！"); return false;
    }
    var v_autoid = $("#txtAutoID").val().replace(/\s/g, "");
    var v_action = DataSet.checkcustomernameexist
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&autoid=" + v_autoid + "&s=" + Math.random();
    ajaxfunc("checkcustomeername_system.axd", pars, errorfunc, successfuncForIsExist);
    if ($("#txtReturnValue").val() == "1") { return false; }
    else { return true; }
}

var successfuncForIsExist = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        if (data == "Y") {
            $("#spanname").attr("class", "onerror").html("客户名称已存在,请重新输入！");
            $("#txtReturnValue").val("1");
        } else {
            $("#spanname").attr("class", "oncorrect").html("客户名称输入正确！");
            $("#txtReturnValue").val("0");
        }
        if ($("#txtReturnValue").val() == "1") { return false; }
        else { return true; }
    }
}


//保存验证
function btncheck() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("客户名称不可以为空,请输入！"); return false;
    } else {
        return true;
    }
}

$(function () {
    $("#txtTitle").blur(checkcustomernameexist);
    $("#btnSave").click(btncheck);
    $("#ddlProvinceID").change(getcitybyprovince).click(getcitybyprovince);
    $("#ddlCityID").change(getcountybycity).click(getcountybycity);
    $("#ddlCountyID").change(gettownbycounty).click(gettownbycounty);
});


function ajaxgetareastr(data) {
    var dataarry = data.split("$&%$");
    if (dataarry[1] == "1") {
        $("#ddlCityID").html(dataarry[0]).attr("style", "width:165px;height:20px;");
    }
    else if (dataarry[1] == "2") {
        $("#ddlCountyID").html(dataarry[0]).attr("style", "width:165px;height:20px;");
    }
    else if (dataarry[1] == "3") {
        $("#ddlTownID").html(dataarry[0]).attr("style", "width:165px;height:20px;");
    }

}
function getcitybyprovince() {
    var v_province = $("#ddlProvinceID").val();
//    if (v_province == "") {
//        $("#spanprovincename").attr("class", "onerror").html("请选择所属省、直辖市！"); return false;
//    }
//    else {
//        $("#spanprovincename").attr("class", "oncorrect").html("&nbsp;");
//    }
    $("#ddlCountyID ").html("<option value=''>请选择所属县、区</option>").attr("style", "width:165px;height:20px;");
    $("#ddlTownID ").html("<option value=''>请选择所属乡镇</option>").attr("style", "width:165px;height:20px;");
    ajaxgetarealist("1", v_province);
}
function getcountybycity() {
    var v_areaid = $("#ddlCityID").val();
    $("#ddlTownID ").html("<option value=''>请选择所属乡镇</option>").attr("style", "width:165px;height:20px;");
//    if (v_areaid == "") {
//        $("#spancityname").attr("class", "onerror").html("请选择城市！"); return false;
//    }
//    else {
//        $("#spancityname").attr("class", "oncorrect").html("&nbsp;");
//    }
    ajaxgetarealist("2", v_areaid);
}
function gettownbycounty() {
    var v_areaid = $("#ddlCountyID").val();
//    if (v_areaid == "") {
//        $("#spancounty").attr("class", "onerror").html("请选择县、区！"); return false;
//    }
//    else {
//        $("#spancounty").attr("class", "oncorrect").html("&nbsp;");
//    }
    ajaxgetarealist("3", v_areaid);
}
