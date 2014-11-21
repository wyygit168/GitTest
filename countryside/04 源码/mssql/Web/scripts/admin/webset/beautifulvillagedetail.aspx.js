 //乡村概述保存验证
function btncheck() {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    if (v_title == "") {
        erroralert("很抱歉，标题不可以为空！");
        $("#txtTitle").select();
         return false;
     }

     var v_ddlVillageID = $("#ddlVillageID").val().replace(/\s/g, "");
     if (v_ddlVillageID == "") {
         erroralert("很抱歉，请选择所属乡村！");
         $("#ddlVillageID").select();
         return false;
     } 
}
function btnsaveimagecheck() {
    var v_txtautoid = $("#txtAutoID").val().replace(/\s/g, "");
    var v_txtimagetitle = $("#txtImageTitle").val().replace(/\s/g, ""); 
    var v_drpimgvillage = $("#drpImgVillage").val().replace(/\s/g, "");
    if (v_txtimagetitle == "") {
        //图片标题 
        $("#spanimagetitle").attr("class", "onerror").html("请输入标题！");
        return false;
    }
    else {
        $("#spanimagetitle").attr("class", "oncorrect").html("输入正确！");
    }
    if (v_txtautoid == "0" || v_txtautoid == "") {
        if ($("#FileImageNew").val() != "undefined") {
            var v_fileimagenew = $("#FileImageNew").val().replace(/\s/g, ""); 
            if (v_fileimagenew == "") {
                $("#spanFileImageNew").attr("class", "onerror").html("请上传图片！");
                return false;
            } else {
                $("#spanFileImageNew").attr("class", "oncorrect").html("输入正确！");
            }
        }
    }
     
    if (v_drpimgvillage == "") {
        $("#spandrpimgvillage").attr("class", "onerror").html("请选择乡村！");
        return false;
    } else {
        $("#spandrpimgvillage").attr("class", "oncorrect").html("输入正确！");
    }
}

$(function () {
    $("#btnSave").click(btncheck);
    $("#btnSaveImage").click(btnsaveimagecheck);
    $("#txtImageTitle").blur(btnsaveimagecheck);
    $("#FileImageNew").blur(btnsaveimagecheck);
    $("#drpImgVillage").click(btnsaveimagecheck);
});