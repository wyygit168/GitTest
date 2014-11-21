//打开登录下拉
function logintextclick() {
    var vClassName = $("#loginText").attr("class");
    if (vClassName == "set_float_on") {
        $(this).attr("class", "set_float")
        $(this).next("div").attr("class", "none");
        $("#loginText :nth-child(2)").attr("class", "sign_in_down");
    }
    else {
        $(this).attr("class", "set_float_on")
        $(this).next("div").removeAttr("class");
        $("#loginText :nth-child(2)").attr("class", "sign_in_up");
    }
}
//关闭登录下拉
function closeLoginBox() {
    $("#loginText").attr("class", "set_float")
    $("#loginText").next("div").attr("class", "none");
    $("#loginText :nth-child(2)").attr("class", "sign_in_down");
}

$(function () {
    //$("#loginText").click(logintextclick);
    $(".mainmenuLeft ul li[class='']").hover(function () {
        $(this).attr("class", "menuSel");
    }, function () {
        $(this).attr("class", "");
    });

    //$("#cancel_img").click(closeLoginBox);
    //$("#sign_in_cancel").click(closeLoginBox);
    $("#loginText").live("click", logintextclick);
    $("#cancel_img").live("click", closeLoginBox);
    $("#sign_in_cancel").live("click", closeLoginBox);

    //网站用户登录
    $("#btnlogin").live("click", function () {
        var v_title = Trim($('#txtaccount').val(), 0);
        var v_password = Trim($('#txtactpwd').val(), 0);
        if (v_title == "" || v_password == "") {
            $("#login_tip").html("请输入用户名或密码").attr("style", "visibility:visible;");
        }
        else {
            $("#login_tip").attr("style", "visibility:hidden;");

        }
        var axd = getURL() + "wuserlogin_country.axd";
        var pars = "action=wuserlogin&title=" + v_title + "&SAutoID=" + v_password + "&s=" + Math.random();
        ajaxfunc(axd, pars, errorfunc, function (data) {
            if (data == "-1") {
                $("#login_tip").html("请输入用户名或密码").attr("style", "visibility:visible;");
            }
            else if (data == "0") {
                $("#login_tip").html("很抱歉，用户名密码不正确").attr("style", "visibility:visible;");
            }
            else {
                $("#inside_top").html(data);
            }
        });
    });

    //网站用户退出登录
    $("#aexit").live("click", function () {
        var axd = getURL() + "wuserexit_country.axd";
        var pars = "action=wuserexit&s=" + Math.random();
        ajaxfunc(axd, pars, errorfunc, function (data) {
            if (data != 0) {
                $("#inside_top").html(data);
            }
        });
    });


    $('#flashbox').smallslider({
        switchEffect: 'ease',
        switchMode: 'click',
        showText: false
    });
});