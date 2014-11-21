//检查资源名称是否存在
function checkmenunameexist() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("资源名称不可以为空,请输入！"); return false;
    }
    //else { $("#spanname").attr("class", "oncorrect").html("资源名称输入正确！"); }
    var v_autoid = $("#txtAutoID").val().replace(/\s/g, "");
    var v_action = DataSet.checkmenunameexist;
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&autoid=" + v_autoid + "&s=" + Math.random();
    ajaxfunc("checkmenuname_system.axd", pars, errorfunc, successfuncForIsExist);
    if ($("#txtReturnValue").val() == "1") { return false; }
    else { return true; }
}

var successfuncForIsExist = function (data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        if (data == "Y") {
            $("#spanname").attr("class", "onerror").html("资源名称已存在,请重新输入！");
            $("#txtReturnValue").val("1");
        } else {
            $("#spanname").attr("class", "oncorrect").html("资源名称输入正确。");
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
        $("#spanname").attr("class", "onerror").html("资源名称不可以为空,请输入！"); return false;
    } else {
    return true;
    }
}

// 异步加载一级下拉菜单
function chanageTopMenu() {
    var v_title = $("#ddlTopMenuID").val();
    var v_action = DataSet.changetopmenu;
    var pars = 'action=' + v_action + "&pagestatus=" + pagestaus + '&title=' + v_title + '&s=' + Math.random();
    ajaxfunc("loadonemenu_system.axd", pars, errorfunc, successchanagetopmenu);
}
function successchanagetopmenu(data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        $("#ddlOneMenu").html(data);
        var topMenuId = $("#ddlTopMenuID").val();
        if (topMenuId != "") {
            $("#spanonemenu").css("display", "");
            //$("#ddlOneMenu").attr("disabled", "");
        } else {
            $("#spanonemenu").css("display", "none");
            //$("#ddlOneMenu").attr("disabled", "");
        }
    }
}

  

$(function () {
    $("#txtTitle").blur(checkmenunameexist);
    $("#btnSave").click(btncheck);
    $("#ddlTopMenuID").change(chanageTopMenu).click(chanageTopMenu);
});


