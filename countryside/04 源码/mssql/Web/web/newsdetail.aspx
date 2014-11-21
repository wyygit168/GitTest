<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newsdetail.aspx.cs" Inherits="web_newsdetail" %>

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
            当前位置：<span><a id="nva0" runat="server" href="###">首页</a> &gt;&gt;  </span><span><a id="nva1" runat="server" href="###">资讯速递</a>&gt;&gt;</span><span> 资讯速递详情</span>
        </div> 
        <div id="left" style="margin-top:4px;">
        <%--<div class="sidebar199">        
            <img src="Images/Page/SidebarImage/sidebar_image.gif" alt="" title="" />
            </div>--%>
          <div class="sidebar199">
            <div class="top"><a id="a1" href="###" atype="newaffice">最新公告</a></div>
                <div class="middle">
                <div id="diva1">
                    <div class="content">        
                        <div><ul id="ula1" runat="server"></ul></div>
                    </div>
        
                    <div class="more">
                        <div><a id="amore1" runat="server" href="###">更多&gt;&gt;</a></div>
                    </div>
                </div>
    
                </div>
            <div class="bottom"></div>
        </div>
          <div class="sidebar199" >
            <div class="top"><a id="a0" href="###" atype="farming">三农快报</a></div>
            <div class="middle">
            <div id="diva0">
                <div class="content">        
                    <div><ul id="ula0" runat="server"></ul></div>
                </div>
        
                <div class="more">
                    <div><a id="amore0" runat="server" href="###">更多&gt;&gt;</a></div>
                </div>
            </div>
    
            </div>
            <div class="bottom"></div>
        </div>
         
          <div class="sidebar199" >
            <div class="top"><a id="a2" href="###" atype="farming">各村资讯</a></div>
            <div class="middle">
            <div id="div1">
                <div class="content">        
                    <div><ul id="ula2" runat="server"></ul></div>
                </div>
        
                <div class="more">
                    <div><a id="amore2" runat="server" href="###">更多&gt;&gt;</a></div>
                </div>
            </div>
    
            </div>
            <div class="bottom"></div>
        </div>
         
        </div>
        
        <div id="right">
            <div id="article" class="article" runat="server"> </div>
        </div>
    </div>
     <asp:Literal ID="litBottomScript" runat="server"></asp:Literal>
    </form>
</body>
</html>
