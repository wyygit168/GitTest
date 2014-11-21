<%@ Page Language="C#" AutoEventWireup="true" CodeFile="beautifulvillage.aspx.cs" Inherits="admin_webset_beautifulvillage" %>

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
                       <div class="PageTitleBar">
                              <div class="PageTitleName">【魅力乡村】列表</div>
                              <div class="PageTab">
                                   <div class="tabs" >
                                        <a id="aoverview" class="selected"   href="###"><span>乡村概述</span></a>
                                        <a id="aimage" href="###"><span>乡村图片</span></a>
                                        <a id="avideo" href="###"><span>乡村视频</span></a>
                                   </div>
                               </div>
                         </div>
                     
                       <div class="PageCenterContent" >
                         <table class="searchTable">
                                 <colgroup>
                                     <col width="50px" />
                                     <col width="60px"/>
                                     <col width="150px" />
                                     <col width="110px"/>
                                     <col width="150px" />
                                     <col width="90px"/>
                                     <col width="150px" />
                                     <col />
                                 </colgroup> 
                                 <tbody>
                                     <tr>
                                      <td class="head">&nbsp;搜&nbsp;索：</td>
                                      <td class="headRight">标题</td>
                                      <td><asp:TextBox ID="txtTitle" runat="server" CssClass="textbox" Width="95%" MaxLength="50"   ></asp:TextBox></td>
                                      <td class="headRight">所属乡村</td>
                                      <td><asp:DropDownList ID="ddlVillageID"   runat="server"   Width="95%" >
                                           <asp:ListItem Value="">请选择乡村</asp:ListItem>
                                          </asp:DropDownList></td>
                                      <td class="headRight">状态</td>
                                      <td><asp:DropDownList ID="ddlStatus"   runat="server"   Width="95%" >
                                          <asp:ListItem Value="">请选择</asp:ListItem>
                                          <asp:ListItem Value="1">有效</asp:ListItem>
                                          <asp:ListItem Value="0">无效</asp:ListItem>
                                          </asp:DropDownList></td>
                                       
                                      
                                      <td><input type="button" id="btnSearch" value=" 查 询 " class="button" onclick="setpagination(0)" /> </td>   
                                     </tr> 
                                 </tbody>
                             </table>
                             <div style="margin-top: 6px; margin-bottom: 6px">
                                 <input class="buttonTwo" id="btnAdd" type="button" value="新 增 " runat="server" />
                                 <input class="buttonTwo" id="btnBatchDel" onclick="batchDel();" type="button" value="批量删除" runat="server" />
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
      <%--用于对.jpg,gif等文件进行预览--%>
     <div id="previewArea" style="display:none;position:absolute;overflow:hidden;">
            <img id="realImg" alt="图片预览" src=""/>
     </div>
    <asp:Literal ID="litScript" runat="server"></asp:Literal>
    <script type="text/javascript">
        //预览图片
    
    
    </script>
   </form>
</body>
</html>
