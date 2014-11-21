<%@ Page Language="C#" AutoEventWireup="true" CodeFile="village.aspx.cs" Inherits="web_village" %>

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
      <div class="siteMap"> &nbsp; 当前位置：<span><a id="nva0" runat="server" href="###">首页</a> &gt;&gt;  </span><span>魅力乡村</span>
        </div> 
      <div class="village"> <h1 style="" >魅  力  乡  村</h1> </div> 
      <div class="villagecontent" id="divVillageList" runat="server"> </div> 
      <div class="villagebottom" ></div>  
    </div>
     <asp:Literal ID="litBottomScript" runat="server"></asp:Literal>
    </form>
</body>
</html>
