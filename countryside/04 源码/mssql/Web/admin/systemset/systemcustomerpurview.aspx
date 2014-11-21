<%@ Page Language="C#" AutoEventWireup="true" CodeFile="systemcustomerpurview.aspx.cs" Inherits="admin_systemset_systemcustomerpurview" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table style="margin: 20px 0 0 8px; width:98% " class="tblInfor"   >
                <colgroup>
                     <col width="85px" /> 
                     <col />
                 </colgroup> 
                <tr>
                    <td class="rhead"  >客户名称： </td>
                    <td >
                        <asp:Label ID="lblSupplierTitle" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="rhead"  >域名名称：</td>
                    <td >
                        <asp:Label ID="lblDomainTitle" runat="server" Text=""></asp:Label>
                        <asp:Button ID="btnDomain" runat="server" CssClass="button"  Text="绑定域名" OnClick="btnDomain_Click" />
                    </td>
                </tr>
                 <tr id="trPrview" runat="server">
                    <td class="rhead"><asp:Label ID="lblPurviewTitle" runat="server" Text="开通权限："></asp:Label></td>
                    <td >
                         <asp:Button ID="btnPriview" runat="server" CssClass="button"  Text="开通权限" OnClick="btnPriview_Click" />
                    </td>
                </tr>
            </table>
    </div>
    <div style="display:none">
             <asp:TextBox ID="txtAutoID" runat="server"></asp:TextBox>
             <input type="text" value="" id="txtReturnValue" />
    </div>
    </form>
</body>
</html>
