<%@ Page Language="C#" AutoEventWireup="true" CodeFile="awardrole.aspx.cs" Inherits="admin_systemset_awardrole" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"> 
      <table style="margin: 20px 0 0 8px; width:98% " class="tblInfor">
                <colgroup>
                     <col width="200px" /> 
                     <col />
                 </colgroup> 
                <tr>
                    <td class="rhead"  >当前用户</td>
                    <td>
                        <asp:Label ID="lblUserAccount" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="rhead"  > 当前角色</td>
                    <td  >
                        <asp:DropDownList ID="ddlRole" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                 
                <tr>
                    <td colspan="4" style="padding:5px 0;text-align:center;" >
                        <asp:Button runat="server" ID="btnSave" class="button"  Text=" 保 存 " 
                            onclick="btnSave_Click"    />
                   </td>
                </tr>
            </table> 
    </form>
</body>
</html>
