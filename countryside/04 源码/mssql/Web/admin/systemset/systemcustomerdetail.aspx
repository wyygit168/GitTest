<%@ Page Language="C#" AutoEventWireup="true" CodeFile="systemcustomerdetail.aspx.cs" Inherits="admin_systemset_systemcustomerdetail"   EnableEventValidation="false" %>

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
                        客户名称：
                    </td>
                    <td >
                        <asp:TextBox   ID="txtTitle" runat="server" Width="180px" MaxLength="50" CssClass="textbox"  ></asp:TextBox>
                        <span class="onshow" id="spanname" runat="server">必填项！</span>
                    </td>
                     <td  class="rhead" >
                       联系人：
                    </td>
                    <td  >
                    <asp:TextBox ID="txtLinkMan" runat="server"   CssClass="textbox" MaxLength="50" class="textbox" Width="180px"   ></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td class="rhead"  >
                        所属地区：
                    </td>
                    <td colspan="3">
                    <div style="font-size:12px; font-weight:normal;">
                    <div id="divprovinceid" style="float:left;margin-right:10px"> 
                         <asp:DropDownList ID="ddlProvinceID"  runat="server" Width="165px" Height="20" CssClass="dropdownlist" >
                        </asp:DropDownList></div>
                        <div id="div1" style="float:left;margin-right:10px">
                         <asp:DropDownList ID="ddlCityID" runat="server" Width="165px" Height="20">
                         <asp:ListItem Value="">请选择所属城市</asp:ListItem>
                        </asp:DropDownList></div>
                         <div id="div2" style="float:left;margin-right:10px"> 
                         <asp:DropDownList ID="ddlCountyID"   runat="server" Width="165px" Height="20">
                         <asp:ListItem Value="">请选择所属县、区</asp:ListItem>
                        </asp:DropDownList></div>
                         <div id="div3" style="float:left;margin-right:10px">
                         <asp:DropDownList ID="ddlTownID"   runat="server" Width="165px" Height="20">
                         <asp:ListItem Value="">请选择所属乡镇</asp:ListItem>
                        </asp:DropDownList></div>
                        <div style="clear:both; height:0px;width:0px; display:none"></div>
                        </div>
                    </td>
                     
                </tr>


                 <tr>
                   
                     <td  class="rhead">
                        电话：
                    </td>
                    <td >
                        <asp:TextBox ID="txtPhone" runat="server" Width="180px" MaxLength="32" CssClass="textbox"   ></asp:TextBox>
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
                       传真：
                    </td>
                    <td >
                        <asp:TextBox ID="txtFax" runat="server" Width="180px"  CssClass="textbox" MaxLength="50" class="textbox"    ></asp:TextBox>
                    </td>
                     <td  class="rhead" >
                       QQ：
                    </td>
                    <td >
                        <asp:TextBox ID="txtQQ" runat="server" Width="180px"  CssClass="textbox" MaxLength="50" class="textbox"    ></asp:TextBox>
                    </td>
                </tr>
                
                 <tr>
                    <td  class="rhead" >
                        邮箱： 
                    </td>
                    <td  >
                     <asp:TextBox ID="txtEmail" runat="server"   CssClass="textbox" MaxLength="50" class="textbox" Width="180px"   ></asp:TextBox>
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
    </div>
          <div style="display:none">
             <asp:TextBox ID="txtAutoID" runat="server" Text="-1" ></asp:TextBox>
             <input type="text" value="" id="txtReturnValue" />
        </div>
         <asp:Literal ID="litScript" runat="server"></asp:Literal>
    </form>
</body>
</html>
