//设置系统登录标题
function setlogintitle() {
    var v_title = $("#txtlogintitle").val().replace(/\s/g, "");
    var v_action = DataSet.baseinfo_setlogintitle
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&s=" + Math.random();
    ajaxfunc("setlogintitle_system.axd", pars, errorfunc, successfuncSetlogintitle);
}

var successfuncSetlogintitle = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        var tishi = $("#btnlogintitle").parent().next("td").children();
        if (data == "Y") {
            tishi.children().eq(1).html("恭喜,保存成功!");
        } else if (data == "N") {
            tishi.children().eq(1).html("很遗憾，保存失败");
        }
        tishi.show();
    }
}

function txtchange() {
    $("#btnlogintitle").parent().next("td").children().hide();
}

//设置网站标题
function setwebtitle() {
    var v_title = $("#txtwebtitle").val().replace(/\s/g, "");
    var v_action = DataSet.baseinfo_setwebtitle
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&s=" + Math.random();
    ajaxfunc("setwebtitle_system.axd", pars, errorfunc, successfuncSetwebtitle);
}

var successfuncSetwebtitle = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        var tishi = $("#btnwebtitle").parent().next("td").children();
        if (data == "Y") {
            tishi.children().eq(1).html("恭喜,保存成功!");
        } else if (data == "N") {
            tishi.children().eq(1).html("很遗憾，保存失败");
        }
        tishi.show();
    }
}

function txtwebtitlechange() {
    $("#btnwebtitle").parent().next("td").children().hide();
}


$(function () {
    $("#btnlogintitle").click(setlogintitle);
    $("#txtlogintitle").focus(txtchange).blur(txtchange).change(txtchange);

    $("#btnwebtitle").click(setwebtitle);
    $("#txtwebtitle").focus(txtwebtitlechange).blur(txtwebtitlechange).change(txtwebtitlechange);
});