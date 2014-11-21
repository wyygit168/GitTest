//检查资讯标题不可以为空
function checkrolenameexist() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("资讯标题不可以为空,请输入！"); return false;
    }
}
function opertypeselect() {
    var v_type = $("#drpOpertype").val();
    if (v_type == "1") {
        $("#trVillageID").attr("style", "display:''");
    }
    else {
        $("#trVillageID").attr("style", "display:none");
    }
}

//保存验证
function btncheck() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        $("#spanname").attr("class", "onerror").html("资讯标题不可以为空,请输入！"); return false;
        return false;
    } else {
        return true;
    }
}

$(function () {
    $("#txtTitle").blur(checkrolenameexist);
    $("#btnSave").click(btncheck);
    $("#drpOpertype").click(opertypeselect);
    $("#ddlVillageID").click(function () {
        if ($(this).val() != "") {
            $("#spanvillageid").attr("style", "display:none;");
        }
        else {
            $("#spanvillageid").attr("style", "display:'';");
        }
    });
});