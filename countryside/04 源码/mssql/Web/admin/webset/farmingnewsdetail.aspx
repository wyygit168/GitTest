<%@ Page Language="C#" AutoEventWireup="true" CodeFile="farmingnewsdetail.aspx.cs" Inherits="admin_webset_farmingnewsdetail" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
       <table style="margin: 2px 0 0 8px; width:98% " class="tblInfor"   >
                <colgroup>
                     <col width="95px" /> 
                     <col width="300px" /> 
                     <col width="95px" /> 
                     <col />
                 </colgroup> 
                <tr>
                    <td class="rhead"  >资讯标题： </td>
                    <td colspan="3">
                        <asp:TextBox ID="txtTitle" runat="server" Width="250px" MaxLength="50" CssClass="textbox"  ></asp:TextBox>
                        <span class="onshow" id="spanname" runat="server">必填项！</span>
                    </td>
                </tr>
                <tr id="tropertype" style="display:none"  runat="server" >
                   <td  class="rhead" > 资讯类型： </td>
                    <td colspan="3" >  <asp:DropDownList ID="drpOpertype" CssClass="textbox" runat="server" Width="183px" Height="25">
                             <asp:ListItem Value="1" Selected="True">地方资讯</asp:ListItem>
                            <asp:ListItem Value="0">三农快报</asp:ListItem>
                        </asp:DropDownList>
                     </td>
                 </tr>
                 <tr id="trVillageID"   runat="server" >
                   <td  class="rhead" > 所属乡村： </td>
                    <td  colspan="3" ><asp:DropDownList ID="ddlVillageID" CssClass="textbox" runat="server" Width="183px" Height="25">
                         </asp:DropDownList>
                      <span class="onshow" id="spanvillageid"   runat="server">不选择为该乡镇资讯信息！</span></td>
                 </tr>

                    <tr>
                   <td  class="rhead" > 状态： </td>
                    <td >  <asp:DropDownList ID="ddlStatus" CssClass="textbox" runat="server" Width="183px" Height="25">
                             <asp:ListItem Value="1">有效</asp:ListItem>
                            <asp:ListItem Value="0">无效</asp:ListItem>
                        </asp:DropDownList>
                     </td>
                
                    <td  class="rhead">排序值： </td>
                    <td  >
                    <asp:TextBox ID="txtOrderValue" runat="server" Width="180px"  CssClass="textbox" MaxLength="20" Text="0" ></asp:TextBox>
                    </td>
                     
                </tr>

                <tr>
                  <td  class="rhead" > 内容： </td>
                    <td colspan="3"> <CKEditor:CKEditorControl ID="txtContent" Width="98%" Height="221" BasePath="~/ckeditor" runat="server">
                    </CKEditor:CKEditorControl>
                    
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
