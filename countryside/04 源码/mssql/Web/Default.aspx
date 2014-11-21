<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    h1 {
       font-size: 72px;
       background: -webkit-gradient(linear, left top, left bottom, from(#eee), to(#333));
       -webkit-background-clip: text;
       -webkit-text-fill-color: transparent;
     }
    
     .round{
     -moz-border-radius: 10px;
     -webkit-border-radius: 10px;
     border-radius: 10px; /* future proofing */
     -khtml-border-radius: 10px; /* for old Konqueror browsers */
 }
 
  p { text-shadow: 1px 1px 1px #000; }
  
  .container {
     min-height: 10em;
     display: table-cell;
     vertical-align: middle;
 }
  
    </style>
    <script src="scripts/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">  

        $(function () {
            $("#btnTest").click(function () {
                $("#testdiv").show(1000).hide(3000);
            });
            $("#btnTestfadein").click(function () {
                var objA = $(this);
                var strWidth = objA.width();
                var position = $(this).position();
                var left = position.left;
                var top = position.top;
                strMessage = "<span style='color:green;font-size:14px; font-weight:bold;'>恭喜，保存成功!</span>";
                $("#showMessage").html(strMessage).css("left", left + strWidth + strWidth)
                 .css("top", top + 5).fadeIn(2000).fadeOut(2000);

            });
        });


        function test() {
            alert(arguments instanceof Array);
            if (arguments.length == 0) {
               // alert("no arguments");
            }
            else if (arguments.length == 1) {
            //alert(arguments[0].toString());
        }
    }

    //test();
    //test("test");


    $("#testAjax").click(function () {
        var ajaxdata = "action=xx&&tt=yy";
        $.ajax({
            url: "_system.axd",
            type: "POST",
            dataType: "html",
            cache: false,
            data: ajaxdata,
            error: function (data) {
                alert(data);
            },
            success: function (data) {
                alert(data);
            }
        });
    });
    </script>
</head>
<body runat="server">
    <form id="form1" runat="server">
    <div>

    <input id="testAjax" type="button" value="testAjax" />
    <input id="btnTest" value="TEST" type="button" /><br /><br />
    <input id="btnTestfadein" value="testfadein" type="button" />
    </div>

    <div id="testdiv" style="width:200px; height:200px; display:none;  border:2px solid #000;" >
    </div>
    <div style="position:absolute;display:none" id="showMessage" ></div> 
    <input type="button" id="btnJquery" value="test jquery" />
    <div id="helloDiv" style="width:400px; height:100px; border:1px solid #000;" ></div>

    <input type="button" id="testajax" onclick="testajax1()" value="testAjax" /> 
    <div id="divajax" style="width:200px; height:200px">
    </div>
    <h1> 是梯形</h1>
    <div class="round container" style="border:2px solid #000;width:200px;height:200px">
     我要测试圆角
    </div>
   
    <p>亲，这个阴影效果如何。</p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
          <br />  <br />  <br />
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </p>

    <CKEditor:CKEditorControl ID="CKEditor1" Width="600" BasePath="~/ckeditor" runat="server">
 </CKEditor:CKEditorControl>
    </form>

    <p>
        &nbsp;</p>
</body>
<script type="text/javascript">
        //alert(document.documentElement);
    //alert(document.documentElement.firstChild);

    var thisPage = {
        initialize: function () {
            //加载时候执行
            this.$btnJqery = "";
            this.$divHello = "";
            this.initializeDom();
            this.initializeEvent();
        },
        initializeDom: function () { 
            //初始化DOM
             $btnJqery = $("#btnJquery");
             $divHello = $("#helloDiv");
           
        },
        initializeEvent: function () {
            //事件绑定             
              $btnJqery.bind("click", function () {
                  $divHello.toggle(300);
            });
        }

    };

//     $(function () {
//         thisPage.initialize();
//     });

      $(thisPage.initialize());


      function testajax() {
          
          // var par = "action=displayleavemessage&txy=1234&ett=444";
          var par = "{action:'test',pageindex:'1'}";
          $.ajax({
              url: "test_ajaxcall.axd",
              type: "POST",
              dataType:"html",// "json",
              cache: false,
              data:par,//"{opertype:'displayleavemessage'}",
              error: function (data) { alert("d"); },
              success: function (data) {
                  alert(data);
              }
          });
      }

      function testajax1() {

          var par = "{action:'test',pageindex:'1'}";
          ajaxfuncbyloadmsg("test_ajaxcall.axd", par, "divajax", errorFunc, successFunc);
      }
      function errorFunc(data) {
      }
      function successFunc(data) {
          alert(data);
      }



      //整合ajax调用
      function ajaxfuncbyloadmsg(urlname, ajaxdata, parentid, errorfunc, successfunc) {
          var loadmsg = $("<div id=\"divTips\" style=\"display: none; border: 1px solid green; left: 450px; top: 350px; z-index: 9999; width: 280px; height: auto; margin: auto; padding: auto; position: absolute; text-align: left; background-color: #ffff99;\"><img src=\"/images/admin/loading_39x39.gif\" alt=\"正在加载数据，请稍候。。。\" />正在加载数据，请稍候。。。。</div>");
          $.ajax({
              url: urlname,
              type: "POST",
              dataType: "html",
              cache: false,
              data: ajaxdata,
              beforeSend: function () {
                  $(parentid).prepend(loadmsg); //.empty()
              },
              error: function (data) {
                  var callback = errorfunc(data);
                  eval(callback || function () { });
              },
              success: function (data) {
                  $(loadmsg).remove();
                  var callback = successfunc(data);
                  eval(callback || function () { });
              }
          });
      }


</script>
</html> 
