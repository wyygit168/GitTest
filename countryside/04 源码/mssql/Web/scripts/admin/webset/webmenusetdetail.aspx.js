//检查菜单名称是否存在
function checkrolenameexist() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("菜单名称不可以为空,请输入！"); return false;
    }
    var v_autoid = $("#txtAutoID").val().replace(/\s/g, "");
    var v_action = DataSet.checkwebmenunameexist;
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&autoid=" + v_autoid + "&s=" + Math.random();
    ajaxfunc("checkwebmenunameexist_web.axd", pars, errorfunc, successfuncForIsExist);
    if ($("#txtReturnValue").val() == "1")  return false; 
    else if ($("#txtReturnValue").val() == "0")  return true; 

}

var successfuncForIsExist = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        if (data == "Y") {
            $("#spanname").attr("class", "onerror").html("菜单名称已存在,请重新输入！");
            $("#txtReturnValue").val("1");
        } else {
            $("#spanname").attr("class", "oncorrect").html("菜单名称输入正确！");
            $("#txtReturnValue").val("0");
        }
        if ($("#txtReturnValue").val() == "1") { return false; }
        else if ($("#txtReturnValue").val() == "0") { return true; }
    }
}
 

//保存验证
function btncheck() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("菜单名称不可以为空,请输入！"); return false;
        return false;
    } else {
        return true;
    }
}

$(function () {
    $("#txtTitle").blur(checkrolenameexist); 
    $("#btnSave").click(btncheck);
});