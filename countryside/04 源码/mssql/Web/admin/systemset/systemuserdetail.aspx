<%@ Page Language="C#" AutoEventWireup="true" CodeFile="systemuserdetail.aspx.cs" Inherits="admin_systemset_systemuserdetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div > 
      <table style="margin: 5px 0 0 8px; width:98% " class="tblInfor"   >
                <colgroup>
                     <col width="85px" />
                     <col width="430px"/> 
                     <col width="80px" />
                     <col />
                 </colgroup> 
                <tr>
                    <td class="rhead"  >
                        用户名：
                    </td>
                    <td >
                        <asp:TextBox   ID="txtTitle" runat="server" Width="180px" MaxLength="50" CssClass="textbox"  ></asp:TextBox>
                        <span class="onshow" id="spanname" runat="server">必填项！</span>
                    </td>
                     <td  class="rhead"   >
                        性别：
                    </td>
                    <td >
                        <asp:DropDownList ID="ddlUserSex" runat="server" CssClass="textbox" Width="183px" Height="25">
                            <asp:ListItem Value="1">男</asp:ListItem>
                            <asp:ListItem Value="0">女</asp:ListItem>
                        </asp:DropDownList>
                        
                    </td>
                </tr>
                 <tr>
                    <td  class="rhead"    >
                        密码：
                    </td>
                    <td  >
                        <asp:TextBox ID="txtUserPassword" runat="server" Width="180px"  CssClass="textbox" MaxLength="32" class="textbox"  TextMode="Password"    ></asp:TextBox>
                        <span  class="onshow"  id="spanpassword" runat="server">必填项！</span>
                    </td>
                     <td  class="rhead">
                        电话：
                    </td>
                    <td >
                        <asp:TextBox ID="txtPhone" runat="server" Width="180px" MaxLength="32" CssClass="textbox"   ></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td  class="rhead">
                        密码确认：
                    </td>
                    <td  >
                    <asp:TextBox ID="txbUserPasswordSure" runat="server" Width="180px"  CssClass="textbox" MaxLength="20" class="textbox"  TextMode="Password"   ></asp:TextBox>
                    <span  class="onshow"  id="spanpasswordsure" runat="server">必填项！</span>
                    </td>
                     <td  class="rhead" >
                        手机：
                    </td>
                    <td >
                        <asp:TextBox ID="txtMobilePhone" runat="server" Width="180px" MaxLength="20" CssClass="textbox"    ></asp:TextBox>
                     </td>
                </tr>
                
                        <tr>
                    <td  class="rhead" >
                       真实姓名：
                    </td>
                    <td  >
                    <asp:TextBox ID="txtRealName" runat="server"   CssClass="textbox" MaxLength="50" class="textbox" Width="180px"   ></asp:TextBox>
                    </td>
                     <td  class="rhead" >
                       QQ：
                    </td>
                    <td >
                        <asp:TextBox ID="txtUserQQ" runat="server" Width="180px"  CssClass="textbox" MaxLength="50" class="textbox"    ></asp:TextBox>
                    </td>
                </tr>
                
                 <tr>
                    <td  class="rhead" >
                        邮箱： 
                    </td>
                    <td  >
                     <asp:TextBox ID="txtUserEmail" runat="server"   CssClass="textbox" MaxLength="50" class="textbox" Width="180px"   ></asp:TextBox>
                    </td>
                     <td  class="rhead" >
                        状态：
                    </td>
                    <td >
                               <asp:DropDownList ID="ddlStatus" CssClass="textbox" runat="server" Width="183px" Height="25">
                             <asp:ListItem Value="1">有效</asp:ListItem>
                            <asp:ListItem Value="0">无效</asp:ListItem>
                        </asp:DropDownList>
                     </td>
                </tr>
                
                
                   <tr>
                    <td  class="rhead" >
                         地址：
                    </td>
                    <td >
                       <asp:TextBox ID="txtAddress" runat="server" Width="180px" MaxLength="50" Text="" CssClass="textbox"  ></asp:TextBox>
                    </td>
                    <td  class="rhead" >
                         排序值：
                    </td>
                    <td   >
                       <asp:TextBox ID="txtOrderValue" runat="server" Width="180px" MaxLength="9" Text="0" CssClass="textbox"  onkeyup="this.value=this.value.replace(/\D/g,'');" onafterpaste="this.value=this.value.replace(/\D/g,'')"></asp:TextBox>
                    </td>
                      
                </tr>
                
                
                 <tr>
                  <td  class="rhead" >
                       备注：
                    </td>
                    <td colspan="3"  >
                        <asp:TextBox ID="txtUserRemark" runat="server" TextMode="MultiLine" MaxLength="4000" Height="100" Width="98%"></asp:TextBox>
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
    </div>
          <div style="display:none">
             <asp:TextBox ID="txtAutoID" runat="server"></asp:TextBox>
             <input type="text" value="" id="txtReturnValue" />
        </div>
         <asp:Literal ID="litScript" runat="server"></asp:Literal>
    </form>
</body>
</html>
