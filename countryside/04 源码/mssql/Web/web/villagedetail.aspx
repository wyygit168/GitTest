<%@ Page Language="C#" AutoEventWireup="true" CodeFile="villagedetail.aspx.cs" Inherits="web_villagedetail" %>

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
      <div class="siteMap"> &nbsp; 当前位置：<span><a id="nva0" runat="server" href="###">首页</a> &gt;&gt;  </span><span><a id="nva1" runat="server" href="###">魅力乡村</a>&gt;&gt; </span><span id="spanVillagedetail" runat="server"></span> </div>
 
        <div class="villagedetail_1">
                <div class="villagedetail_1_height">
                    <div class="villagedetail_1_left">
                        <p style="color: #FFF; font-family: SimSun; font-size: 12pt; font-weight: bold; padding: 10px 0 0 70px;">
                            该村最新资讯</p>
                    </div>
                    <div class="villagedetail_1_left_content">
                        <ul id="ulVliiageNews" runat="server"></ul>
                    </div>
                </div>
                <div class="villagedetail_1_height" style="margin-left:29px">
                    <div class="villagedetail_1_left">
                        <p style="color: #FFF; font-family: SimSun; font-size: 12pt; font-weight: bold; padding: 10px 0 0 90px;">
                            该村视频</p>
                    </div>
                    <div class="villagedetail_1_vidimage"> 
                        <a target="_blank" href="###">
                            <img id="imgvideo" alt=""  title="" width="344" height="219" src="###" runat="server" />
                        </a> 
                        <p style=" margin-top:10px;"><a href="###">更多视频&gt;&gt; </a></p> 
                    </div>
                </div>
            </div>
        
        <div class="villagedetail_2"  >
            <div  class="villagedetail_2_top"></div>
            <div class="villagedetail_2_header">
                <div class="divtitle">梁寨村</div>
                <div id="divSlide"  class="divSlide"  >
                    <ul id="ulSlide" runat="server"></ul> 
                    <div class="clear_float"></div>
                </div>
                <div class="divimgmore" ><a href="###" id="amoreimg" runat="server" >更多图片&gt;&gt;</a></div> 
            </div>
            <div class="villagedetail_2_content">
                <h1> 该村介绍</h1>
                <div id="divIntro" runat="server" > </div>
            </div>
            <div class="villagedetail_2_content">
                <h1> 生产美</h1>
                <div id="divYield" runat="server" > </div>
            </div>
            <div class="villagedetail_2_content">
                <h1>生活美</h1>
                <div id="divLive" runat="server" > </div>
            </div>
            <div class="villagedetail_2_content">
                <h1> 环境美</h1>
                <div id="divEnvironment" runat="server" > </div>
            </div>
            <div class="villagedetail_2_content">
                <h1> 人文美</h1>
                <div id="divHumanism" runat="server" > </div>
            </div>
            <div  class="villagedetail_2_bot"></div> 
        </div> 
     </div>
     <asp:Literal ID="litBottomScript" runat="server"></asp:Literal>
    </form>
</body>
</html>
