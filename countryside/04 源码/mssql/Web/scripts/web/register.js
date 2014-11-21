//单击获取验证码
function getcheckcode() {
    var v_url = getURL() + 'ccode/' + Math.rand(1, 5000);
    var aa = v_url.lastIndexOf("/");
    $("#imgVerify").attr("src", v_url);
}

function checkTxtTitle() {
    var isFlag = true;
    var v_td = $("#txtTitle").parent().next("td");
    var v_title = Trim($("#txtTitle").val(), 0);
    if (v_title == "") {
        v_td.children("span").attr("class", "onerror").html("请输入用户名");
        isFlag=false;
    }
    else if (v_title != null && v_title.length < 3) {
        v_td.children("span").attr("class", "onerror").html("很抱歉，用户名长度不正确，请重新输入");
        isFlag=false;
    }
    else { 
        var v_d = Trim($("#txtbk").val(), 0);
        var pars = "action=checknameexist&title=" + v_title + "&AutoID=" + v_d + "&s=" + Math.random();
        var axd = getURL() + "checknameexist_country.axd";
        ajaxfuncbysync(axd, pars, errorfunc, function (data) {
            if (data == "N") { 
                v_td.children("span").attr("class", "oncorrect").html("输入正确");
                v_Flag = true; 
            }
            else if (data == "Y") {
                v_td.children("span").attr("class", "onerror").html("很抱歉，用户名已存在，请重新输入");
                v_Flag = false;
            }
            return v_Flag
        });
    }
    return isFlag;
}

function checkUserPassword() {
    var v_td = $("#txtUserPassword").parent().next("td");
    var v_content = Trim($("#txtUserPassword").val(), 0);
    var v_pwdtrue = Trim($("#txtconfirmUserPassWord").val(), 0);
    var v_Flag = true;
    if (v_content == "") {
        v_td.children("span").attr("class", "onerror").html("请输入密码");
        v_Flag = false;
    }
    else if (v_content != null && v_content.length < 3) {
        v_td.children("span").attr("class", "onerror").html("很抱歉，密码不少于3位字符，请输入");
        v_Flag = false;
    }
    else if (v_pwdtrue != v_content && v_pwdtrue != "") {
        v_td.children("span").attr("class", "onerror").html("很抱歉，两次密码输入不一致");
        v_Flag = false;
    }
    else {
        v_td.children("span").attr("class", "oncorrect").html("输入正确");
        if (v_content == v_pwdtrue) {
            var_pwdtd = $("#txtconfirmUserPassWord").parent().next("td");
            var_pwdtd.children("span").attr("class", "oncorrect").html("输入正确");
        } 
    }
    return v_Flag;
}

function checkConfirmUserPassword() { 
    var v_td = $("#txtconfirmUserPassWord").parent().next("td");
    var v_content = Trim($("#txtconfirmUserPassWord").val(), 0);
    var v_pwdtrue = Trim($("#txtUserPassword").val(), 0); 
    var v_Flag = true;
    if (v_content == "") {
        v_td.children("span").attr("class", "onerror").html("请再次输入密码");
        v_Flag = false;
    }
    else if (v_content != null && v_content.length < 3) {
        v_td.children("span").attr("class", "onerror").html("很抱歉，密码不少于3位字符，请输入");
        v_Flag = false;
    }
    else if (v_pwdtrue != v_content) {
        v_td.children("span").attr("class", "onerror").html("很抱歉，两次密码输入不一致");
        v_Flag = false;
    }
    else {
        v_td.children("span").attr("class", "oncorrect").html("输入正确"); 
        if (v_content == v_pwdtrue) {
            var_pwdtd = $("#txtUserPassword").parent().next("td")
            var_pwdtd.children("span").attr("class", "oncorrect").html("输入正确");
        }
        return v_Flag;
    }
}

function checkRandcode() {
    var v_Flag = true;
    var v_title = Trim($("#randcode").val(), 0);
    if (v_title == "") {
        $("#spancheckcode").attr("class", "onerror")
        $("#acheckcode").html("请输入验证码");
        v_Flag = false;
    }
    else {
        var pars = "action=checkcode&table2=" + v_title + "&s=" + Math.random();
        var axd = getURL() + "checkcode_country.axd";
        ajaxfuncbysync(axd, pars, errorfunc, function (data) {
            if (data == "1") {
                $("#spancheckcode").attr("class", "oncorrect")
                $("#acheckcode").html("验证码输入正确");
                v_Flag = true; 
               
            }
            else if (data == "2") {
                $("#spancheckcode").attr("class", "onerror")
                $("#acheckcode").html("验证码输入不正确，请重新输入");
                v_Flag = false;
            }
            return v_Flag
        });
    }
    return v_Flag;
}

function checkUserBirthday() {
    var v_td = $("#txtUserBirthday").parent().next("td");
    var v_content = Trim($("#txtUserBirthday").val(), 0);
    var v_Flag = true;
    if (v_content != "") {
        if (!checkdate(v_content)) { 
            v_td.children("span").attr("class", "onerror").html("很抱歉，你输入的日期格式不正确，请重新输入,正确格式如：1988-01-08");
            v_Flag = false;
        }
        else {
            v_td.children("span").attr("class", "oncorrect").html("输入正确");
        }
    }
    return v_Flag;
}

$(function () {
    $("#txtTitle").focus(function () {
        var v_td = $(this).parent().next("td");
        v_td.children("span").attr("class", "onshow").html("由字母、数字或“_”组成，长度不少于3位，不多于30位");
    });
    $("#txtTitle").blur(checkTxtTitle);

    $("#txtUserPassword").focus(function () {
        var v_td = $(this).parent().next("td");
        v_td.children("span").attr("class", "onshow").html("不少于3位字符");
    });
    $("#txtUserPassword").blur(checkUserPassword);

    $("#txtconfirmUserPassWord").focus(function () {
        var v_td = $(this).parent().next("td");
        v_td.children("span").attr("class", "onshow").html("请再次输入密码");
    });
    $("#txtconfirmUserPassWord").blur(checkConfirmUserPassword);

    $("#txtUserBirthday").focus(function () {
        var v_td = $(this).parent().next("td");
        v_td.children("span").attr("class", "onshow").html("格式如：1988-01-08");
    });
    $("#txtUserBirthday").blur(checkUserBirthday);

    $("#randcode").focus(function () {
        $("#spancheckcode").attr("class", "onshow")
        $("#acheckcode").html("看不清，换一张");
    });
    $("#randcode").blur(checkRandcode);

    //提交注册
    $("#submitLink").click(function () {
        var v_istxtTitle = checkTxtTitle();
        var v_ispwd = checkUserPassword();
        var v_ispwdconfirm = checkConfirmUserPassword();
        var v_Randcode = checkRandcode();
        var v_UserBirthday = checkUserBirthday();
        if (v_istxtTitle && v_ispwd && v_ispwdconfirm && v_Randcode && v_UserBirthday) {
            var v_title =Trim($('#txtTitle').val(), 0);
            var v_password =Trim($('#txtUserPassword').val(), 0);
            var v_sex = Trim($('input[name="rdoUserSex"]:checked').val(), 0);
            var v_realname =Trim($('#txtRealName').val(), 0);
            var v_UserBirthday =Trim($('#txtUserBirthday').val(), 0);
            var v_IdentityCard =Trim($('#txtIdentityCard').val(), 0);
            var v_UserEmail =Trim($('#txtUserEmail').val(), 0);
            var v_MobilePhone =Trim($('#txtMobilePhone').val(), 0);
            var v_Phone =Trim($('#txtPhone').val(), 0);
            var v_Address =Trim($('#txtAddress').val(), 0);
            var v_Randcode = Trim($('#randcode').val(), 0);
            var axd = getURL() + "register_country.axd"; 
            var pars = "action=webregister&title=" + v_title + "&extend8=" + v_sex + "&SAutoID=" + v_password + "&extend1=" + v_realname + "&extend2=" + v_UserBirthday + "&extend3=" + v_IdentityCard + "&extend4=" + v_UserEmail + "&extend5=" + v_MobilePhone + "&extend6=" + v_Phone + "&extend7=" + v_Address + "&table2=" + v_Randcode + "&s=" + Math.random();
            ajaxfunc(axd, pars, errorfunc, function (data) {
                if (data == "1") {
                    $("#submitLink").attr("style", "display:none");
                    ymPrompt.succeedInfo({ title: '温馨提示', message: '恭喜，注册成功' });
                }
                else if (data == "2") { 
                    $('#randcode').focus();
                    $("#spancheckcode").attr("class", "onerror")
                    $("#acheckcode").html("验证码输入不正确，请重新输入");
                }
                else {
                    ymPrompt.errorInfo({ title: '温馨提示', message: '很遗憾，注册失败，请重新注册' });
                }
            });
        }
    });

})