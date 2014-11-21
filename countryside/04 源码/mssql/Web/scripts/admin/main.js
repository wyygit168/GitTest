var pagestaus = "1";
//****************************************************************
//  显示、隐藏左边栏
//****************************************************************
function ShowArrow() {
    var LeftArrowSrc = "../../images/admin/arrowLeft.gif";
    var RightArrowSrc = "../../images/admin/arrowRight.gif";

    if (document.getElementById("TdLeftWard").style.display == "") {
        document.getElementById("LeftCloseArrow").src = RightArrowSrc;
        document.getElementById("LeftCloseArrow").title = "显示侧边"
        document.getElementById("TdLeftWard").style.display = "none";
    }
    else {
        document.getElementById("LeftCloseArrow").src = LeftArrowSrc;
        document.getElementById("LeftCloseArrow").title = "隐藏侧边";
        document.getElementById("TdLeftWard").style.display = "";
    }
}

//****************************************************************
// Table Row鼠标的放上 移出事件 
//****************************************************************
var tbList = function(a) { return document.getElementById(a) }
function rowOutAndOver(c) {
    if (tbList(c)) {
        tbList(c).onmouseover = function() {
            var tr1 = this.rows;
            for (var i = 1; i < tr1.length; i++) {
                tr1[i].onmouseover = function() { this.style.background = "#B0E1FF"; }
                tr1[i].onmouseout = function() { this.style.background = "#ffffff"; }
            }
        }
    }
}
 

//****************************************************************
// 系统注销
//****************************************************************
function LogOut() {
    ymPrompt.confirmInfo({ title: '温馨提示', message: '您确定要注销系统吗？', handler: function(tp) {
        if (tp == "ok") { location.replace("../../Login.aspx"); }
    }
    })

}


//****************************************************************
// 系统关闭
//****************************************************************
function systemExit() {
    ymPrompt.confirmInfo({ title: '温馨提示', message: '您确定要关闭系统吗？', handler: function(tp) {
        if (tp == "ok") { window.opener = null; window.close(); }
    }
    })

}

//查询加载数据
function successListfunc(data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        var strArray = data.split('$$$$');
        if (strArray.length == 4) {
            $('#divContent').html(strArray[0]);
            $('#divPageBar').html(strArray[1]);
            $('#txtPageIndex').val(strArray[2]);
        }
    }
}
//批量删除后 查询加载数据
function successBatchDelListfunc(data) {
    if (data == "returnLogion") {
        redirectLogin();
    }
    else {
        var strArray = data.split('$$$$');
        if (strArray.length == 4) {
            $('#divContent').html(strArray[0]);
            $('#divPageBar').html(strArray[1]);
            $('#txtPageIndex').val(strArray[2]);
            var v_message = "恭喜,批量删除成功，共删除" + strArray[3] + "条"
            ymPrompt.succeedInfo({ title: '温馨提示', message: '' + v_message + '' });
        }
    }
}

// 新增
function newoperation(page, width, height, title) {
    ymPrompt.win({
        message: page,
        width: width,
        height: height,
        title: title,
        handler: succeed,
        closeBtn: true,
        iframe: true
    });
}
//****************************************************************
// 修改
//****************************************************************
function editoperation(page, width, height, title) {
    ymPrompt.win({
        message: page,
        width: width,
        height: height,
        title: title,
        handler: null,
        closeBtn: true,
        iframe: true
    });
}

function awardOperation(page, width, height, title) {
    ymPrompt.win({
        message: page,
        width: width,
        height: height,
        title: title,
        handler: succeedPageRefresh,
        closeBtn: true,
        iframe: true
    });
}


//****************************************************************
// 单选
//****************************************************************
function ckbclick() {
    var ckbCount = 0;
    var ckbAll = document.getElementById("ckbAll");
    var ckbAllList = document.getElementsByName("ckbAllList");
    for (var i = 0; i < ckbAllList.length; i++) {
        if (ckbAllList[i].checked) { ckbCount++; }
        else { break; }
    }
    if (ckbCount == ckbAllList.length) { ckbAll.checked = true; }
    else { ckbAll.checked = false; }
}

//****************************************************************
// 全选
//****************************************************************
function allckbclick(obj) {
    var ckbAllList = document.getElementsByName("ckbAllList");
    for (var i = 0; i < ckbAllList.length; i++) {
        if (obj.checked) {
            ckbAllList[i].checked = true;
        } else {
            ckbAllList[i].checked = false;
        }
    }
}

//****************************************************************
// 批量删除
//****************************************************************
function batchDel() {
    var ckbCount = 0;
    var v_autoid = "";
    var ckbAllList = document.getElementsByName("ckbAllList");
    for (var i = 0; i < ckbAllList.length; i++) {
        if (ckbAllList[i].checked) {
            ckbCount++;
            v_autoid += ckbAllList[i].value + "_";
        }
    }
    v_autoid = v_autoid.substr(0, (v_autoid.length - 1));    
    if (ckbCount <= 0) {
        ymPrompt.errorInfo({ title: '温馨提示', message: '请选择你要删除的账号' }); return false;
    }
    ymPrompt.confirmInfo({ title: '删除操作', message: '确定批量删除吗？', handler: function (tp) {
        if (tp == 'ok') {
            batchdeloperation(v_autoid);
        }
    }
    });
}
// 删除单个记录
function deletesinglerecord(id) {
    ymPrompt.confirmInfo({ title: '删除操作', message: '确定删除吗？', handler: function (tp) {
        if (tp == 'ok') {
            $("#txtAutoID").val(id);
            deleteopertion(id);
            ymPrompt.succeedInfo({ title: '温馨提示', message: '恭喜，删除成功！' });
        }
    }
    })

}


//更改状态
function changestate(autoid, curstatus, currentuserid) {
    ymPrompt.confirmInfo({ title: '更改状态', message: '确定更改吗？', handler: function (tp) {
        if (tp == 'ok') {
            changestateoperation(autoid, curstatus, currentuserid)
        }
    }
    });
} 

// 刷新 
function succeed() {
    var v_pageindex = $("#txtPageIndex").val().replace(/\s/g, "");
    setpagination(v_pageindex);
}




//****************************************************************
// 保存成功后刷新
//****************************************************************
function returnfunction() {
    ymPrompt.succeedInfo({ title: '温馨提示', message: '恭喜，保存成功！', handler: succeed });
}

//无权限操作页面提示
function priviewPage() {
    ymPrompt.errorInfo({ title: '温馨提示', message: '很抱歉，你没有权限打开该页面，有问题请和管理员联系！' });
}
function returnopenpriview(){
    ymPrompt.succeedInfo({ title: '温馨提示', message: '恭喜，客户权限开通成功！', handler: succeed });
}

function openurl(url) {
    window.location.href = url;  //"SystemDomain.aspx";
}
//****************************************************************


function InPreviewImage(img, imgsrc,pxleft,pxtop,realwidth,realheight) {
    var divLeft = document.documentElement.clientWidth / 2 - pxleft;
    var divTop = document.documentElement.scrollTop + pxtop;
    var imgdiv = document.getElementById("previewArea");
    imgdiv.style.left = divLeft + "px";
    imgdiv.style.top = divTop + "px";
    var realImg = document.getElementById("realImg");
    realImg.src = imgsrc;
    realImg.width = realwidth;
    realImg.height = realheight;
    imgdiv.style.display = "";
}

function OutPreviewImage() {
    var imgdiv = document.getElementById("previewArea");
    imgdiv.style.display = "none";
}

//****************************************************************
jQuery(document).ready(function () {

    //  左边栏展开、折叠模块
    jQuery(".TopItem,.AccountItem").click(function () {
        jQueryobjUL = jQuery(this).next("ul");
        var objImg = jQuery(this)[0];
        var img = objImg.getElementsByTagName("img");
        if (jQueryobjUL.is(":visible")) {
            img[img.length - 1].title = "展开";
            img[img.length - 1].src = "../../images/admin/expand.gif"
            jQueryobjUL.hide();
        }
        else {
            img[img.length - 1].title = "折叠";
            img[img.length - 1].src = "../../images/admin/collapse.gif";
            jQueryobjUL.show();
        }
    });
    //链接网站首页
    jQuery("#aindex").click(function () {
        var url = getURL() + "index/";
        $(this).attr("href", url).attr("target", "_blank");
    });

    //更新缓存
    jQuery("#anocacle").click(function () {
        var v_action = CommonDataSet.updatacache
        var pars = "action=updatacache&pagestatus=" + pagestaus + "&s=" + Math.random();
        ajaxfunc("main_system.axd", pars, errorfunc, function () {
            ymPrompt.succeedInfo({ title: '温馨提示', message: '恭喜，缓存更新成功！'}); 
        });
    });

    //计算trCenter的高度
    var v_winheight = $(window).height(); 
    var v_trCenterHeight = v_winheight - 69 - 50;
    var v_attrValue="height:"+v_trCenterHeight+"px";
    $("#trCenter").attr("style", v_attrValue);
    $("#trCenter>td").attr("style", v_attrValue);
});
