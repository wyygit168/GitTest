//检查县、区名称是否存在
function checknameexist() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_provinceid = $("#ddlProvinceID").val().replace(/\s/g, "");
    var v_cityid = $("#ddlCityID").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("县、区名称不可以为空,请输入！"); return false;
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

     var v_autoid = $("#txtAutoID").val().replace(/\s/g, ""); 
    var v_action = DataSet.checkcountynameexist;
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&extend1=" + v_provinceid + "&extend3=" + v_cityid + "&autoid=" + v_autoid + "&s=" + Math.random();
    ajaxfunc("checkcountyname_system.axd", pars, errorfunc, successfuncForIsExist);
    if ($("#txtReturnValue").val() == "1")  return false; 
    else if ($("#txtReturnValue").val() == "0")  return true; 

}

var successfuncForIsExist = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        if (data == "Y") {
            $("#spanname").attr("class", "onerror").html("县、区名称已存在,请重新输入！");
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
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("县、区名称不可以为空,请输入！"); return false;
        return false;
    }
    if (v_province == "") {
        $("#spanprovincename").attr("class", "onerror").html("请选择所属省、直辖市！"); return false;
        return false;
    }
    if (v_cityid == "") {
        $("#spancityname").attr("class", "onerror").html("请选择城市！"); return false;
    }
    else {
        return true;
    }
}


function ajaxgetareastr(data) {
    var dataarry = data.split("$&%$");
    if (dataarry.length > 0) {
        if (dataarry[1] == "1") {
            $("#ddlCityID").html(dataarry[0]);
            $("#ddlCityID").attr("style", "width:183px;height:25px;");
        }
    }
}

function getcitybyprovince() {
    var v_province = $("#ddlProvinceID").val();
     ajaxgetarealist("1", v_province);
}
 
$(function () {
    $("#txtTitle").blur(checknameexist);
    $("#ddlCityID").click(checknameexist);
    $("#btnSave").click(btncheck);
    $("#ddlProvinceID").change(getcitybyprovince).click(getcitybyprovince);
});