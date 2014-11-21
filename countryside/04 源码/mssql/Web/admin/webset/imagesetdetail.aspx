<%@ Page Language="C#" AutoEventWireup="true" CodeFile="imagesetdetail.aspx.cs" Inherits="admin_webset_imagesetdetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <%--首页轮播图设置--%>
      <div  id="divImage" runat="server" visible="false" > 
         <table  class="tblInfor" width="98%">
               <colgroup>
                     <col width="95px" /> 
                     <col width="200px" />  
                     <col />
                 </colgroup> 
                    <tr class="highlightRow">
                        <td colspan="3">
                            <strong class="highlight">*</strong>图片最大允许为500K,允许类型为:jpg,gif,bmp,png
                         </td>
                    </tr>
                    <tr>
                        <td class="rhead"> <strong class="highlight">*</strong>图片标题：</td>
                        <td class="brnull"> <asp:TextBox runat="server" ID="txtImageTitle" Width="200" MaxLength="20"  CssClass="textbox" ></asp:TextBox>
                        </td>
                        <td class="blnull">
                        <span class="onshow" id="spanimagetitle"  >必填项！</span>
                        </td>
                    </tr>
                    <tr >
                        <td class="rhead"  ><strong class="highlight">*</strong>选择图片：</td>
                        <td class="brnull" >
                            <input id="FileImageNew" type="file" runat="server" class="upfile" style="width:200px"  />
                            <input id="FileImageUpdate" type="file" runat="server" class="upfile" style="width:200px;"  visible="false" />
                          </td >
                        <td  class="blnull" >
                        <span class="onshow" id="spanFileImageNew" runat="server">必填项！</span>
                         </td> 
                         
                    </tr>
                   
                    <tr>
                        <td class="rhead">
                            选项：</td>
                        <td colspan="2">
                            有效:<input type="checkbox" id="chkImageStatus"  checked="checked" runat="server" />
                            &nbsp;&nbsp;排序值:<asp:TextBox runat="server" ID="txtImageOrderValue" MaxLength="9" Width="50" Text="0"  ></asp:TextBox>
                        </td>
                    </tr>
                     <tr runat="server" id="trImageView"  visible="false" >
                        <td class="rhead">
                            图片预览：</td>
                        <td colspan="2">
                            <a id="aimage" runat="server"><asp:Image ID="imgView" runat="server" Width="800" Height="120" /></a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" style="text-align: center">
                            <asp:Button runat="server" ID="btnSaveImage" Text=" 确 定 " CssClass="button"  onclick="btnSaveImage_Click"   />
                            <asp:Button runat="server" ID="btnCancleImage" Text=" 取 消 " CssClass="button" 
                                onclick="btnCancleImage_Click"  />
                        </td>
                     </tr>
                </table>


         <table style="margin: 2px 0 0 8px; width:98%; display:none;" class="tblInfor">
                <colgroup>
                     <col width="95px" /> 
                     <col width="300px" /> 
                     <col width="95px" /> 
                     <col />
                 </colgroup> 
                <tr>
                    <td class="rhead"  >图片标题： </td>
                    <td colspan="3">
                        <asp:TextBox ID="TextBox1" runat="server" Width="180px" MaxLength="50" CssClass="textbox"  ></asp:TextBox>
                        <span class="onshow" id="span1" runat="server">必填项！</span>
                    </td>
                </tr>
                
                 
                   <tr>
                  <td  class="rhead" > 链接地址： </td>
                    <td colspan="3"> 
                   <asp:TextBox ID="TextBox3" runat="server" Width="180px"  CssClass="textbox" MaxLength="20" Text="0" ></asp:TextBox>
                     </td>
                </tr>
                    <tr>
                   <td  class="rhead" > 状态： </td>
                    <td >  <asp:DropDownList ID="DropDownList2" CssClass="textbox" runat="server" Width="183px" Height="25">
                             <asp:ListItem Value="1">有效</asp:ListItem>
                            <asp:ListItem Value="0">无效</asp:ListItem>
                        </asp:DropDownList>
                     </td>
                
                    <td  class="rhead">排序值： </td>
                    <td  >
                    <asp:TextBox ID="TextBox2" runat="server" Width="180px"  CssClass="textbox" MaxLength="20" Text="0" ></asp:TextBox>
                    </td>
                </tr>
                 
              
               <tr>
                  <td  class="rhead" >备注： </td>
                    <td colspan="3"> 
                     <asp:TextBox ID="txtUserRemark" runat="server" TextMode="MultiLine" MaxLength="4000" Height="100" Width="98%"></asp:TextBox>
                    </td>
                </tr>
              
                <tr>
                    <td colspan="4" style="padding:5px 0;text-align:center;" >
                        <asp:Button runat="server" ID="Button1" class="button"  Text=" 保 存 " 
                            onclick="btnSave_Click"     />
                        <asp:Button runat="server" ID="Button2" class="button"  Text=" 取 消 " onclick="btnCancel_Click"     />
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
