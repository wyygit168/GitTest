<%@ Page Language="C#" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="web_news"  EnableViewState="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" id="Head">
    <title></title>
     <link rel="shortcut icon" id="lnkico" runat="server" />
     <asp:Literal ID="litTopCssAndScript" runat="server"></asp:Literal>
</head>
<body>
    <form id="form1" runat="server">
     <div id="divtop" runat="server"></div> 
     <div id="Main">
        <div class="siteMap">
            &nbsp;
            当前位置：<span><a id="nva0" runat="server" href="###" >首页</a> &gt;&gt;  </span><span> 资讯速递</span>
        </div>
    
        <div id="left" style="margin-top:4px;">
        <%--<div class="sidebar199">        
            <img src="Images/Page/SidebarImage/sidebar_image.gif" alt="" title="" />
            </div>--%> 

          <div class="sidebar199">
            <div class="top"><a id="a1" href="###" atype="newaffice" ><span id="span1" runat="server">最新公告</span></a></div>
                <div class="middle">
                <div id="diva1">
                    <div class="content">        
                        <div><ul id="ula1" runat="server"></ul></div>
                    </div>
        
                    <div class="more">
                        <div><a href="###">更多&gt;&gt;</a></div>
                    </div>
                </div>
    
                </div>
            <div class="bottom"></div>
          </div>

          <div class="sidebar199">
            <div class="top"><a id="a0" href="###" atype="farming" ><span id="span0" runat="server">三农快报</span></a></div>
            <div class="middle">
            <div id="diva0">
                <div class="content">        
                    <div><ul id="ula0" runat="server"></ul></div>
                </div>
        
                <div class="more">
                    <div><a href="###">更多&gt;&gt;</a></div>
                </div>
            </div>
    
            </div>
            <div class="bottom"></div>
        </div>

         
        </div>
        
        <div id="right">
                    <div  class="articleList" >
                        <div style="text-align: left;" class="top">
                            <span style="color:#fff;" id="lblTitle" atype="village" runat="server" >各村资讯</span>
                        </div>
                        <div class="middle">
                    
                            <table width="100%;" >
                                      <tbody  id="tbContent" runat="server"> 
                                  <%--<tr>
                                    <td colspan="2" style="text-align: right;">
                                       <div class="pageBar" id="divPageBar"><strong class="pagelistselected">1</strong> 共1页&nbsp;19条记录</div>
                                    </td>
                                </tr>--%>
                                </tbody>
                                </table>
                        </div>
                        <div class="bottom">
                        </div>
                    </div> 
        </div>
    </div> 
     <asp:Literal ID="litBottomScript" runat="server"></asp:Literal>
    </form>
</body>
</html>
