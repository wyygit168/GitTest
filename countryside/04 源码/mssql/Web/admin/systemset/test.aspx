<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="admin_systemset_test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../scripts/jquery-1.7.2.min.js" type="text/javascript"></script>
     <script type="text/javascript">
         $(function () {
             $("#testAjax").click(function () {
                 var ajaxdata = "action=xx&&tt=yy";
                 alert(ajaxdata); 
                 $.ajax({
                     url: "ajaxcallforsystemset.aspx",
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
         });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="button" id="testAjax" value="testAjax" />
    </div>
    </form>
</body>
</html>
