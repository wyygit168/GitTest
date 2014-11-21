<%@ Page Language="C#" AutoEventWireup="true" CodeFile="systemdomainbinddetail.aspx.cs" Inherits="admin_systemset_systemdomainbinddetail"  EnableEventValidation="false" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <table style="margin: 0 0 0 8px; width: 98%" class="tblInfor">
        <colgroup>
                     <col width="125px" /> 
                     <col width="187px" /> 
                     <col />
                 </colgroup> 
                <tr>
                    <td class="rhead"  >客户名称</td>
                    <td class="brnull"><asp:DropDownList ID="ddlCustomerID" CssClass="textbox" runat="server" Width="183px" Height="25">
                        </asp:DropDownList></td>
                     
                </tr>
                <tr>
                    <td class="rhead"  >域名名称</td>
                    <td  class="brnull"><asp:DropDownList ID="ddlDomainID" CssClass="textbox" runat="server" Width="183px" Height="25">
                        </asp:DropDownList> </td>
                </tr>
                <tr>
                    <td colspan="4" style="padding:5px 0;text-align:center;" >
                        <asp:Button runat="server" ID="btnSave" class="button"  Text=" 保 存 " 
                            onclick="btnSave_Click"     />
                        <asp:Button runat="server" ID="btnCancel" class="button"  Text=" 取 消 " onclick="btnCancel_Click"     />
                   </td>
                </tr>
            </table>
     
    <div style="display:none">
             <asp:TextBox ID="txtAutoID" runat="server"></asp:TextBox>
             <asp:TextBox ID="txtDomainAutoID" runat="server"></asp:TextBox>
             <input type="text" value="" id="txtReturnValue" />
    </div>
    </form>
</body>

</html>
