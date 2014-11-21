//检查城市名称是否存在
function checknameexist() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_provinceid = $("#ddlProvinceID").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("城市名称不可以为空,请输入！"); return false;
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
    //else { $("#spanname").attr("class", "oncorrect").html("&nbsp;"); }
    var v_autoid = $("#txtAutoID").val().replace(/\s/g, "");
    
    var v_action = DataSet.checkcitynameexist;
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&extend1=" + v_provinceid + "&autoid=" + v_autoid + "&s=" + Math.random();
    ajaxfunc("checkcityname_system.axd", pars, errorfunc, successfuncForIsExist);
    if ($("#txtReturnValue").val() == "1")  return false; 
    else if ($("#txtReturnValue").val() == "0")  return true; 

}

var successfuncForIsExist = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        if (data == "Y") {
            $("#spanname").attr("class", "onerror").html("城市名称已存在,请重新输入！");
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
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("城市名称不可以为空,请输入！"); return false;
        return false;
    }
    if (v_province == "") {
        $("#spanprovincename").attr("class", "onerror").html("请选择所属省、直辖市！"); return false;
        return false;
    } 
    else {
        return true;
    }
}

$(function () {
    $("#txtTitle").blur(checknameexist);
    $("#ddlProvinceID").click(checknameexist);
    $("#btnSave").click(btncheck);
});