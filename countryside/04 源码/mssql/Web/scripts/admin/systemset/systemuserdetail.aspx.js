//检查用户名是否存在
function checkusernameexist() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("用户名不可以为空,请输入！"); return false;
    }
    var v_autoid = $("#txtAutoID").val().replace(/\s/g, "");
    var v_action = DataSet.checkusernameexist
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&autoid=" + v_autoid + "&s=" + Math.random();
    ajaxfunc("checkusername_system.axd", pars, errorfunc, successfuncForIsExist);
    if ($("#txtReturnValue").val() == "1") { return false; }
    else { return true; }
}

var successfuncForIsExist = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        if (data == "Y") {
            $("#spanname").attr("class", "onerror").html("用户名已存在,请重新输入！");
            $("#txtReturnValue").val("1");
        } else {
            $("#spanname").attr("class", "oncorrect").html("用户名输入正确！");
            $("#txtReturnValue").val("0");
        }
        if ($("#txtReturnValue").val() == "1") { return false; }
        else { return true; }
    }
}


//密码验证
function passwordcheck() {
    var txtLoginPassword = $("#txtUserPassword").val();
    if (Trim(txtLoginPassword, 0) == "") {
        $("#spanpassword").attr("class", "onerror").html("密码不可以为空,请输入！"); return false;
    } else {
        $("#spanpassword").attr("class", "oncorrect").html("密码填写正确！");
    }
    var txtLoginPasswordSure = $("#txbUserPasswordSure").val();
    if (Trim(txtLoginPasswordSure, 0) != "") {
        if (txtLoginPasswordSure != txtLoginPassword) {
            $("#spanpasswordsure").attr("class", "onerror").html("密码输入不一致,请重新输入！"); return false;
        }
        else { $("#spanpasswordsure").attr("class", "oncorrect").html("确认密码输入正确！"); }
    }
    return true;

}
//密码确认验证
function passwordsurecheck() {
    var txtLoginPasswordSure = $("#txbUserPasswordSure").val();
    if (Trim(txtLoginPasswordSure, 0) == "") {
        $("#spanpasswordsure").attr("class", "onerror").html("确认密码不可以为空,请输入！");
        return false;
    } else { $("#spanpasswordsure").attr("class", "oncorrect").html("确认密码输入正确！"); }
    var txtLoginPassword = $("#txtUserPassword").val();
    if (Trim(txtLoginPassword, 0) != "") {
        if (txtLoginPasswordSure != txtLoginPassword) {
            $("#spanpasswordsure").attr("class", "onerror").html("密码输入不一致,请重新输入！"); return false;
        } else { $("#spanpasswordsure").attr("class", "oncorrect").html("确认密码输入正确！"); }
    }
    return true;
}

//保存验证
function btncheck() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("用户名不可以为空,请输入！"); return false;
    }if (passwordcheck() && passwordsurecheck()) return true;
    else return false;
}

$(function () {
    $("#txtTitle").blur(checkusernameexist);
    $("#txtUserPassword").blur(passwordcheck)
    $("#txbUserPasswordSure").blur(passwordsurecheck)
    $("#btnSave").click(btncheck);
});