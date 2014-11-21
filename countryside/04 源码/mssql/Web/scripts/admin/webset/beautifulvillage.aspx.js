var v_opertype = "aoverview"; //该页面操作类型
var v_action = DataSet.webbeautifulvillage;
var v_filetype = "";
//查询魅力乡村列表
function setpagination(pageindex) {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_villageid = $("#ddlVillageID").val().replace(/\s/g, "");
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&extend3=" + v_villageid + "&status=" + v_status + "&pageindex=" + pageindex + "&extend4=" + v_opertype + "&extend8=" + v_filetype + "&s=" + Math.random();
    ajaxfuncbyloadmsg("beautifulvillagelist_web.axd", pars, "#divContent", errorfunc, successListfunc);
}

//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = "";
    switch (v_opertype) {
        case "aoverview":  v_action = DataSet.webbeautifulvillagestatus; break;
        case "aimage":   v_action = DataSet.webbeautifulvillageimagestatus; break;
        case "avideo":  break;
        default: break;
    }
    detailoperation("changebeautifulvillagestatus_web.axd", v_action, autoid, curstatus);
}

//删除单个魅力乡村、乡村图片
function deleteopertion(autoid) {
    var v_action ="";
    switch (v_opertype) {
        case "aoverview": v_opertype = "aoverview"; v_filetype = ""; v_action = DataSet.singledeleteforwebbeautifulvillage; break;
        case "aimage": v_opertype = "aimage"; v_filetype = "0"; v_action = DataSet.singledeleteforwebbeautifulimagevillage; break;
        case "avideo": v_opertype = "avideo"; v_filetype = "1"; break;
         default: break;
    }

    detailoperation("deletebeautifulvillage_web.axd", v_action, autoid, "");
}

//批量删除魅力乡村
function batchdeloperation(autoid) {
    var v_action ="";
    switch (v_opertype) {
        case "aoverview": v_opertype = "aoverview"; v_filetype = ""; v_action = DataSet.batchdeleteforwebbeautifulvillage; break;
        case "aimage": v_opertype = "aimage"; v_filetype = "0"; v_action = DataSet.batchdeleteforwebbeautifulimagevillage; break;
        case "avideo": v_opertype = "avideo"; v_filetype = "1"; break;
         default: break;
    }
    detailoperation("batchdeletebeautifulvillage_web.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    var v_villageid = $("#ddlVillageID").val().replace(/\s/g, "");
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&extend3=" + v_villageid + "&extend4=" + v_opertype + "&extend8=" + v_filetype + "&s=" + Math.random();
    if (autoid == "0") { //批量删除
        ajaxfunc(axd, pars, errorfunc, successBatchDelListfunc);
    }
    else {
        ajaxfunc(axd, pars, errorfunc, successListfunc);
    }
}


$(function () {

    $("#btnAdd").click(function () {
        switch (v_opertype) {
            case "aoverview": newoperation("beautifulvillagedetail.aspx?action=new", 1000, 600, "【魅力乡村】：新增"); break;
            case "aimage": newoperation("beautifulvillagedetail.aspx?action=new&pagetype=0", 490, 280, "【魅力乡村-图片】：新增"); break;
            case "avideo": break;
             default: break;
        }
    });


    //标签单击事件
    $(".tabs>a").click(function () {
        var v_aid = $(this).attr("id");
        $(this).attr("class", "selected");
        $(this).siblings().removeClass();
        switch (v_aid) {
            case "aoverview": v_opertype = "aoverview"; v_filetype = ""; v_action = DataSet.webbeautifulvillage; break;
            case "aimage": v_opertype = "aimage"; v_filetype = "0";v_action = DataSet.webbeautifulvillageimage; break;
            case "avideo": v_opertype = "avideo";v_filetype="1"; break;
             default: break;
        }
        setpagination(0);
    });
});