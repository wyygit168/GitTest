<%@ Page Language="C#" AutoEventWireup="true" CodeFile="awardmenu.aspx.cs" Inherits="admin_systemset_awardmenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table style="width:98%"  class="tblInfor">
    <tr><td class="rhead" >角色名称：</td><td> <asp:Label ID="lblRoleName" runat="server" Text=""></asp:Label>  </td></tr>
     <tr><td class="rhead" >资源列表：<br /><span style="color:Red;">(单击复选框，<br />及完成保存操作)</span></td><td> <asp:Literal ID="ltResourceList" runat="server"></asp:Literal>  </td></tr>
    </table>
     <div style="display:none"> <asp:TextBox ID="txtRoleId" runat="server"></asp:TextBox></div>
     <div style="position:absolute;display:none" id="showMessage" ></div> 
      <asp:Literal ID="litScript" runat="server"></asp:Literal>
    </form>
</body>
</html>
