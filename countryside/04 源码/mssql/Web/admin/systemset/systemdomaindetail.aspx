<%@ Page Language="C#" AutoEventWireup="true" CodeFile="systemdomaindetail.aspx.cs" Inherits="admin_systemset_systemdomaindetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div > 
       <table style="margin: 0 0 0 8px; width: 98%" class="tblInfor">
        <colgroup>
                     <col width="125px" /> 
                     <col width="187px" /> 
                     <col />
                 </colgroup> 
                <tr>
                    <td class="rhead"  >域名名称</td>
                    <td class="brnull">
                        <asp:TextBox ID="txtTitle" runat="server" Width="180px" MaxLength="20" CssClass="textbox"  ></asp:TextBox></td><td class="blnull">
                        <span class="onshow" id="spanname" runat="server">必填项！</span>
                    </td>
                     
                </tr>
                
                <%-- <tr>
                   <td  class="rhead" >状态</td>
                    <td colspan="2" >  <asp:DropDownList ID="ddlStatus" CssClass="textbox" runat="server" Width="183px" Height="25">
                             <asp:ListItem Value="1">有效</asp:ListItem>
                            <asp:ListItem Value="0">无效</asp:ListItem>
                        </asp:DropDownList>
                     </td> 
                </tr>--%>
      
                 <tr>
                    <td  class="rhead">排序值</td>
                    <td  colspan="2" >
                    <asp:TextBox ID="txtOrderValue" runat="server" Width="180px"  CssClass="textbox" MaxLength="20" Text="0" ></asp:TextBox>
                    </td>
                     
                </tr>
                  <tr>
                  <td  class="rhead" >备注</td>
                    <td colspan="2" >
                        <asp:TextBox ID="txtRemark" runat="server" TextMode="MultiLine" MaxLength="4000" Height="100" Width="98%"></asp:TextBox>
                    </td>
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
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <input type="text" value="" id="Text1" />
    </div>
    </div>
          <div style="display:none">
             <asp:TextBox ID="txtAutoID" runat="server"></asp:TextBox>
             <input type="text" value="" id="txtReturnValue" />
        </div>
         <asp:Literal ID="litScript" runat="server"></asp:Literal>
    </form>
</body>
</html>
