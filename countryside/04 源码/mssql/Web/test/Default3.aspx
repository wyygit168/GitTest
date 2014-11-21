<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="test_Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../scripts/jquery-1.7.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        var v_setX = [];
        function ajaxfunc( ) {
            var v_url = "Default3.aspx";
            var v_ajaxdata = "action=chart";
            $.ajax({
                url: v_url,
                type: "POST",
                dataType: "json",
                cache: false,
                data: v_ajaxdata,
                error: function (data) {
                    //var callback = errorfunc(data);
                    //eval(callback || function () { });
                },
                success: function (data) {
                    //var callback = successfunc(data);
                    //eval(callback || function () { });
                    v_setX = [];
                    
                    $.each(data.table, function (i, msg) {

                        var xx = msg.dcData;
                        v_setX.push(xx);
                        
                    });
                    alert("****" + v_setX);
                }
            });
        }


        $(function () {
            $("#btn").click(function () {
                ajaxfunc() 
            });
        });
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin:50px 0 0 150px">
     <input type="button" id="btn" value="Ajax 异步获取" />
    </div>
    </form>
</body>
</html>
