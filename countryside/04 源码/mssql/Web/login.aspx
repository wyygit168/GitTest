<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title><asp:Literal ID="litLoginTitle" runat="server"></asp:Literal></title>
    <link rel="shortcut icon"  href= "favicon.ico" />
    <asp:Literal ID="litCss" runat="server"></asp:Literal>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height:120px;"></div>
    <div id="loginTop" class="loginTop" ><div id="loginTopText"  class="loginTopText" runat="server" ></div></div>
    <div id="loginCenter" class="loginCenter">
    <table class="loginTable">
     <colgroup><col width="380px" /><col width="90px" /><col width="130px" /><col /></colgroup>
     <tr class="loginTROne"><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>
     <tr class="loginTRTwo"><td>&nbsp;</td><td style="text-align:right">登&nbsp;录&nbsp;名：</td><td><asp:TextBox ID="txtName"  CssClass="textbox" runat="server"  Width="98%"></asp:TextBox></td><td>&nbsp;</td></tr>
     <tr class="loginTRTwo"><td>&nbsp;</td><td style="text-align:right">登录密码：</td><td><asp:TextBox ID="txtPassword" runat="server" CssClass="textbox"  TextMode="Password" Width="98%"></asp:TextBox></td><td>&nbsp;</td></tr>
     <tr class="loginTRTwo">
     <td>&nbsp;</td>
     <td style="text-align:right">保存密码：</td>
     <td> 
            <asp:DropDownList ID="ddlCookSave" runat="server" Width="98%">
                           <asp:ListItem Value="0">不保存</asp:ListItem>
                           <asp:ListItem Value="1">保存一天</asp:ListItem>
                           <asp:ListItem Value="2">保存一周</asp:ListItem>
                           <asp:ListItem Value="3">保存一月</asp:ListItem>
            </asp:DropDownList>
     </td>
     <td>&nbsp;</td>
     </tr>
    </table>
    <table>
      <tr ><td  style="width:420px"></td><td>
      <asp:Button ID="btnLogin" runat="server"  CssClass="btnLogin" Text=" "  OnClientClick="return CheckLogin(); "   onclick="btnLogin_Click" /></td></tr>
    </table>
    </div>
    <div id="loginBottom" class="loginBottom"></div>
    <asp:Literal ID="litScript" runat="server"></asp:Literal>
    </form>
</body>
</html>