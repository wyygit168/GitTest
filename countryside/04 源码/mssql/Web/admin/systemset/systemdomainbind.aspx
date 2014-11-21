<%@ Page Language="C#" AutoEventWireup="true" CodeFile="systemdomainbind.aspx.cs" Inherits="admin_systemset_systemdomainbind" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
    <table id="PageTable" class="PageTable" cellpadding="0" cellspacing="0">
        <tr id="trHeader">
            <td id="TdHeader"  runat="server" class="PageTableTd" >
            </td>
        </tr>
        <tr id="trCenter">
            <td class="PageTableTd" >
                <table id="CenterTable" class="CenterTable" cellpadding="0" cellspacing="0">
                <tr>
                    <td id="TdLeftWard"  class="TdLeftWard" runat="server"></td>
                    <td id="TdVerticalLine" class="TdVerticalLine" onclick="ShowArrow(0)"  runat="server"></td>
                    <td class="TdRight">
                    <div class="PageContent">
                     <div class="PageTitleBar"><div class="PageTitleName">【客户域名绑定】列表</div></div>
                     
                       <div class="PageCenterContent" >
                         <table class="searchTable">
                                 <colgroup>
                                     <col width="50px" />
                                     <col width="116px"/>
                                     <col width="150px" />
                                     <col width="116px"/>
                                     <col width="150px" />
                                   
                                     <col />
                                 </colgroup> 
                                 <tbody>
                                     <tr>
                                      <td class="head">&nbsp;搜&nbsp;索：</td>
                                      <td class="headRight">客户名称</td>
                                      <td><asp:TextBox ID="txtCustomerTitle" runat="server" CssClass="textbox" Width="95%" MaxLength="50"   ></asp:TextBox></td>
                                      <td class="headRight">域名名称</td>
                                      <td><asp:TextBox ID="txtDomainTitle" runat="server" CssClass="textbox" Width="95%" MaxLength="50"   ></asp:TextBox></td>
                                   
                                      <td><input type="button" id="btnSearch" value=" 查 询 " class="button" onclick="setpagination(0)" /> </td>   
                                     </tr> 
                                 </tbody>
                             </table>
                             <div style="margin-top: 6px; margin-bottom: 6px">
                                 <input class="buttonTwo" id="btnAdd" onclick="newoperation('systemdomainbinddetail.aspx?action=new',400,200,'【绑定客户域名】：新增')" type="button" value="新 增 " runat="server" />
                                 <input class="buttonTwo" id="btnBatchDel" onclick="batchDel();" type="button" value="批量删除" runat="server" visible="false" />
                              </div>
                             <div id="divContent" runat="server" ></div>
                             <div id="divPageBar" style="margin-top:8px;"  runat="server" class="pageBar"></div>
                         </div> 
                    </div>
                     </td>
                </tr>
                </table>
            </td>
        </tr>
        <tr id="trFooter" >
            <td id="TdFooter"   runat="server" class="PageTableTd" >
            </td>
        </tr>
        </table> 
    <div style="display:none">
            <asp:TextBox ID="txtAutoID" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtPageIndex" runat="server"></asp:TextBox>
     </div>
    <asp:Literal ID="litScript" runat="server"></asp:Literal>
   </form>
</body>
</html>
