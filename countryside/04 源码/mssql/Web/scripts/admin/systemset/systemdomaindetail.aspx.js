//检查域名名称是否存在
function checkdomainnameexist() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("域名名称不可以为空,请输入！"); return false;
    }
    var v_autoid = $("#txtAutoID").val().replace(/\s/g, "");
    var v_action = DataSet.checkdomainnameexist
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&autoid=" + v_autoid + "&s=" + Math.random();
    ajaxfunc("checkdomainname_system.axd", pars, errorfunc, successfuncForIsExist);
    if ($("#txtReturnValue").val() == "1") { return false; }
    else { return true; }
}

var successfuncForIsExist = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        if (data == "Y") {
            $("#spanname").attr("class", "onerror").html("域名名称已存在,请重新输入！");
            $("#txtReturnValue").val("1");
        } else {
            $("#spanname").attr("class", "oncorrect").html("域名名称输入正确！");
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
        $("#spanname").attr("class", "onerror").html("域名名称不可以为空,请输入！"); return false;
    } else {
        return true;
    }
}

$(function () {
    $("#txtTitle").blur(checkdomainnameexist);
    $("#btnSave").click(btncheck);
});