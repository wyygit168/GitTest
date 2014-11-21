$(function () {
    $("a").click(function () {
        var strType = $(this).attr("type");
        var dL = $("dl[type=" + strType + "]");
        if (dL.is(":visible")) { dL.hide(); }
        else { dL.show(); }
    });
    $(":input").click(function () {
        var position = $(this).position();
        var left = position.left;
        var top = position.top;
        var v_Ids = $(this).attr("id");
        var v_IdArray = v_Ids.split("_");
        var v_menuType = v_IdArray[0];
        var v_MenuID = v_IdArray[1];
        var v_RoleID = $("#txtRoleId").val();
        var permission = "0";
        var v_action = DataSet.awardmenu;
        var v_axd = "awardmenu_system.axd";
        if ($(this).is(":checked")) permission = "1";
        var v_pars = "action=" + v_action + "&extend1=" + v_MenuID + "&extend2=" + v_RoleID + "&extend3=" + v_menuType + "&extend4=" + permission + "&s=" + Math.random();
        ajaxfunc(v_axd, v_pars, errorfunc, function (data) {
            var v_Message = "<span style='color:green;font-weight:bold;'>恭喜，保存成功!</span>";
            if (data == "0") v_Message = "<span style='color:red;font-weight:bold;'>很遗憾，保存失败</span>";
            $("#showMessage").html(v_Message).css("left", left + 10).css("top", top + 20).fadeIn(3000, function () {
                $("#showMessage").css("display", "none");
            });
        });
    });
});
         