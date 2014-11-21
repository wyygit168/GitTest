//****************************************************************
// 获取URL根目录(不针对URL重写)
//****************************************************************
function getURL() {
    var curwwwPath = window.document.location.href;
    var pathName = window.document.location.pathname; //获取主机地址之后的目录，如： cis/website/meun.htm 
    var pos = curwwwPath.indexOf(pathName); //获取主机地址，如： http://localhost:8080 
    var localhostPath = curwwwPath.substring(0, pos); //获取带"/"的项目名，如：/cis 
    var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
    var rootPath = localhostPath + projectName + "/";
    
    return rootPath;

    
}

//****************************************************************
// 去除空格
// Description: sInputString 为输入字符串，iType为类型，分别为
// 0 - 去除前后空格; 1 - 去前导空格; 2 - 去尾部空格
//****************************************************************
function Trim(sInputString, iType) {
    var sTmpStr = ' '
    var i = -1
    if (iType == 0 || iType == 1) {
        while (sTmpStr == ' ') {
            ++i
            sTmpStr = sInputString.substr(i, 1)
        }
        sInputString = sInputString.substring(i)
    }

    if (iType == 0 || iType == 2) {
        sTmpStr = ' '
        i = sInputString.length
        while (sTmpStr == ' ') {
            --i
            sTmpStr = sInputString.substr(i, 1)
        }
        sInputString = sInputString.substring(0, i + 1)
    }
    return sInputString
}
//****************************************************************
// 字符串包含字符
// Description: str: 为输入字符串，  charset:包含的字符
//****************************************************************
function contain(str, charset)    //字符串包含测试函数
{
    var i;
    for (i = 0; i < charset.length; i++) {
        if (str.indexOf(charset.charAt(i)) >= 0)  return true;
    }
    return false;
}


//****************************************************************
// 整合ajax调用(包含等待加载)
//****************************************************************
 function ajaxfuncbyloadmsg(urlname, ajaxdata, parentid, errorfunc, successfunc) {
    var loadmsg = $("<div id=\"divTips\" style=\" border: 1px solid green; width: 280px; height: auto; margin: auto; padding: auto;  text-align: center; vertical-align:middle;  background-color: #ffff99;\"><div style=\"margin-top:15px;\"><img src=\"" + getURL() + "images/admin/loading_39x39.gif\"  /></div><div style=\"margin:10px 0 10px 15px;text-align:center; font-weight:bold;\">正在加载数据，请稍候......</div></div>");
    $.ajax({
        url: urlname,
        type: "POST",
        dataType: "html",
        cache: false,
        data: ajaxdata,
        beforeSend: function () {
             $(parentid).html(loadmsg);
        },
        error: function (data) {
            var callback = errorfunc(data);
            eval(callback || function () { });
        },
        success: function (data) {
            $(parentid).html("");
            var callback = successfunc(data);
            eval(callback || function () { });
        }
    });
}


//****************************************************************
// 整合ajax调用(不包含延迟加载)
//****************************************************************
function ajaxfunc(urlname, ajaxdata, errorfunc, successfunc) {
    $.ajax({
        url: urlname,
        type: "POST",
        dataType: "html",
        cache: false,
        data: ajaxdata,
        error: function (data) {
            var callback = errorfunc(data);
            eval(callback || function () { });
        },
        success: function (data) {
            var callback = successfunc(data);
            eval(callback || function () { });
        }
    });
}

//****************************************************************
// 整合ajax调用(不包含延迟加载) async: false,
//****************************************************************
function ajaxfuncbysync(urlname, ajaxdata, errorfunc, successfunc) {
    $.ajax({
        url: urlname,
        type: "POST",
        dataType: "html",
        cache: false,
        async: false,
        data: ajaxdata,
        error: function (data) {
            var callback = errorfunc(data);
            eval(callback || function () { });
        },
        success: function (data) {
            var callback = successfunc(data);
            eval(callback || function () { });
        }
    });
}
//ajax 失败提示
var errorfunc = function (data) { 
    ymPrompt.errorInfo({ title: '温馨提示', message: '服务器忙，请稍后在试' }); 

}
//****************************************************************
// 获得字符串长度
//****************************************************************
 function getStringLength(str) {
    var totalLength = 0;
    var list = str.split("");
    for (var i = 0; i < list.length; i++) {
        var s = list[i];
        if (s.match(/[\u0000-\u00ff]/g)) { //半角
            totalLength += 1;
        } else if (s.match(/[\u4e00-\u9fa5]/g)) { //中文  
            totalLength += 2;
        } else if (s.match(/[\uff00-\uffff]/g)) { //全角 
            totalLength += 3;
        }
    }
    return totalLength;
}

//****************************************************************
//判断字符串长度是否合法
//****************************************************************
function validateStrLng(str, lng) {
    return getStringLength(str) < lng;
}
//****************************************************************
//截取字符串，超出部分用...代替，中文算两个字符
//****************************************************************
function subPoints(str, sub_length) {
    var temp1 = str.replace(/[^\x00-\xff]/g, "**"); //精髓
    var temp2 = temp1.substring(0, sub_length);
    //找出有多少个*
    var x_length = temp2.split("\*").length - 1;
    var hanzi_num = x_length / 2;
    sub_length = sub_length - hanzi_num; //实际需要sub的长度是总长度-汉字长度
    var res = str.substring(0, sub_length);
    if (sub_length < str.length) {
        var end = res + "...";
    } else {
        var end = res;
    }
    return end;
}

//调转到登录页面
function redirectLogin() {
    ymPrompt.errorInfo({ title: '温馨提示', message: '回话过期，请重新登录！' });
     window.location.href = getURL() + "login.aspx";
 }


  
 /*ajax 获取地区列表
 * type:=1 城市 =2 县区  3乡镇
 * type=1 id：省id，type=2 id：城市id ，type=3 id：县区id ，
 */
 function ajaxgetarealist(type, id) {
     var v_action = "";
     var v_axd = "";
     switch (type) {
         case "1": v_action = DataSet.getcitybyprovince; v_axd = "getcitybyprovince_system.axd"; break;
         case "2": v_action = DataSet.getcountybycity; v_axd = "getcountybycity_system.axd"; break;
         case "3": v_action = DataSet.gettownbycounty; v_axd = "gettownbycounty_system.axd"; break;
         default: break;
     }
     
     var pars = "action=" + v_action + "&extend1=" + id + "&s=" + Math.random();
     ajaxfunc(v_axd, pars, errorfunc, successgetarealist);
 }
 function successgetarealist(data) {
     if (data == "returnLogion") {
         redirectLogin();
     }
     else {
         ajaxgetareastr(data);
     }
 }

 var erroralert = function (v_error) {
     ymPrompt.errorInfo({ title: '温馨提示', message: v_error });
 }

//获取随机数
 Math.rand = function (l, u) {
     return Math.floor((Math.random() * (u - l + 1)) + l);
 }

//验证日期格式 正确格式如:2013-08-08
 function checkdate(v_date) {
   
     var date = v_date;
     var result = date.match(/^(\d{1,4})(-|\/)(\d{1,2})\2(\d{1,2})$/); 
     if (result == null)
         return false;
     var d = new Date(result[1], result[3] - 1, result[4]);
     return (d.getFullYear() == result[1] && (d.getMonth() + 1) == result[3] && d.getDate() == result[4]);

 }

