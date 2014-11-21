//检查省名称是否存在
function checknameexist() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("省名称不可以为空,请输入！"); return false;
    }
    //else { $("#spanname").attr("class", "oncorrect").html("&nbsp;"); }
    var v_autoid = $("#txtAutoID").val().replace(/\s/g, "");
    var v_action = DataSet.checkprovincenameexist;
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&autoid=" + v_autoid + "&s=" + Math.random();
    ajaxfunc("checkprovincename_system.axd", pars, errorfunc, successfuncForIsExist);
    if ($("#txtReturnValue").val() == "1")  return false; 
    else if ($("#txtReturnValue").val() == "0")  return true; 

}

var successfuncForIsExist = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        if (data == "Y") {
            $("#spanname").attr("class", "onerror").html("省名称已存在,请重新输入！");
            $("#txtReturnValue").val("1");
        } else {
            $("#spanname").attr("class", "oncorrect").html("省名称输入正确！");
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
        $("#spanname").attr("class", "onerror").html("省名称不可以为空,请输入！"); return false;
        return false;
    } else {
        return true;
    }
}

$(function () {
    $("#txtTitle").blur(checknameexist); 
    $("#btnSave").click(btncheck);
});