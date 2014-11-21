<%@ Page Language="C#" AutoEventWireup="true" CodeFile="baseinfoset.aspx.cs" Inherits="admin_systemset_baseinfoset" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title> 
     <asp:Literal ID="litCss" runat="server"></asp:Literal>
</head>
<body>
      <form id="form1" runat="server" >
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
                     <div class="PageTitleBar"><div class="PageTitleName">【基础信息设置】</div></div>
                     <div class="PageCenterContent" >
                      <table  class="tblset"    >
                        <colgroup>
                             <col width="10px" />
                             <col /> 
                         </colgroup> 
                        <tr>
                                <td  class="rowalternation1td  lhead"  >1</td>
                                <td class="rowalternation1td" >
                                    <table class="tblcontent"  >
                                          <col class="col1" />
                                          <col class="col2" />
                                          <col class="col3"/> 
                                          <col /> 
                                        <tr>
                                            <td class="lhead">设置登陆系统标题</td>
                                            <td class="length"><input type="text" class="textbox" id="txtlogintitle" runat="server"   /></td>
                                            <td class="length"><input type="button" class="button" id="btnlogintitle" value=" 保 存 " /></td>
                                            <td class="length" >
                                                 <div class="tishi" style="display:none"   >
										            <div class="tishi_left"></div>
										            <div class="tishi_cen"></div>
										            <div class="tishi_right"></div>
						                         </div>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                       </tr>
                        <tr>
                            <td  class="rowalternation2td  lhead"  > 2 </td>
                            <td class="rowalternation2td" >
                                 <table class="tblcontent"  >
                           <col class="col1" />
                             <col  class="col2" />
                             <col  class="col3" />
                             <col /> 
                            <tr>
                                <td class="lhead">设置网站标题</td>
                                <td class="length"><input type="text" class="textbox" id="txtwebtitle" runat="server"   /></td>
                                <td class="length"><input type="button" class="button"  id="btnwebtitle" value=" 保 存 " /></td>
                                <td class="length">
                                                 <div class="tishi" style="display:none"    >
										            <div class="tishi_left"></div>
										            <div class="tishi_cen"></div>
										            <div class="tishi_right"></div>
						                         </div>
                                </td>
                            </tr>
                        </table>
                            </td>
                        </tr>
                        <tr>
                        <td  class="rowalternation1td  lhead"  > 3 </td>
                        <td class="rowalternation1td" >
                        <table class="tblcontent"  >
                             <col class="col1" />
                             <col  class="col2" />
                             <col  class="col3" />
                             <col /> 
                            <tr>
                                <td class="lhead">设置网站信息</td>
                                <td class="length"><input type="text" class="textbox"   /></td>
                                <td class="length"><input type="button" class="button" value=" 保 存 " /></td>
                                <td class="length">
                                                 <div class="tishi" style="display:none">
										            <div class="tishi_left"></div>
										            <div class="tishi_cen"></div>
										            <div class="tishi_right"></div>
						                         </div>
                                </td>
                            </tr>
                        </table>
                        </td>
                        </tr>
                     </table>
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
    <asp:Literal ID="litScript" runat="server"></asp:Literal>
   </form>
</body>
</html>
