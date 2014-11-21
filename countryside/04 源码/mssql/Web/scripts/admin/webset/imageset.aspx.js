var v_opertype = "aindexlb"; //该页面操作类型
var v_action = DataSet.WebLbtImage;
var v_filetype = "2";
//查询图片列表
function setpagination(pageindex) {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, ""); 
    var pars = "action=" + v_action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&extend3=&status=" + v_status + "&pageindex=" + pageindex + "&extend4=" + v_opertype + "&extend8=" + v_filetype + "&s=" + Math.random();
    ajaxfuncbyloadmsg("imagesetlist_web.axd", pars, "#divContent", errorfunc, successListfunc);
}

//更改状态操作
function changestateoperation(autoid, curstatus, currentuserid) {
    var v_action = DataSet.webbeautifulvillageimagestatus;
    
    detailoperation("changeimagesetstatus_web.axd", v_action, autoid, curstatus);
}

//删除单个图片
function deleteopertion(autoid) {
    var v_action ="";
    switch (v_opertype) {
        case "aindexlb": v_opertype = "aindexlb"; v_action = DataSet.singledeleteforwebbeautifulimagevillage; break; //首页轮播图
         default: break;
    } 
    detailoperation("deleteimageset_web.axd", v_action, autoid, "");
}

//批量删除图片
function batchdeloperation(autoid) {
    var v_action ="";
    switch (v_opertype) {
        case "aindexlb": v_opertype = "aindexlb"; v_action = DataSet.batchdeleteforwebbeautifulimagevillage; break;
        default: break;
    }
    detailoperation("batchdeleteimageset_web.axd", v_action, "0", autoid);
}

//详细操作（封装）
function detailoperation(axd, action, autoid, curstatus) {
    var v_title = $("#txtTitle").val().replace(/\s/g, "");
    var v_status = $("#ddlStatus").val().replace(/\s/g, "");
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, ""); 
    var pars = "action=" + action + "&pagestatus=" + pagestaus + "&title=" + v_title + "&status=" + v_status + "&pageindex=" + v_pageindex + "&autoid=" + autoid + "&extend2=" + curstatus + "&extend3=&extend4=" + v_opertype + "&extend8=" + v_filetype + "&s=" + Math.random();
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
            case "aindexlb": newoperation("imagesetdetail.aspx?action=new", 490, 200, "【首页轮播图】：新增"); break; //首页轮播图

            default: break;
        }
    });


    //标签单击事件
    $(".tabs>a").click(function () {
        var v_aid = $(this).attr("id");
        $(this).attr("class", "selected");
        $(this).siblings().removeClass();
        switch (v_aid) {
            case "aindexlb": v_opertype = "aindexlb"; v_filetype = "2"; v_action = DataSet.WebLbtImage; break; //首页轮播图
            default: break;
        }
        setpagination(0);
    });
});