<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" EnableViewState="false"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" id="Head">
    <title ></title> 
    <link rel="shortcut icon" id="lnkico" runat="server" />
    <asp:Literal ID="litTopCssAndScript" runat="server"></asp:Literal>
</head>
<body>
    <form id="form1" runat="server"> 
     <div id="divtop" runat="server"></div> 
     <div id="Main">
        <div style="width:100%; height:360px;" id="OneDiv"> 

              <div class="L_Affiche">
                    <div class="L_AfficheTop">最新公告</div>
                    <div class="L_AfficheMiddle">
                        <ul id="ulnewaffiche" runat="server"> 
                        </ul>
                    </div>
                    <div class="L_AfficheBottom"></div>
              </div>  
              <div id="C_SlideImg" class="SlideImg" runat="server" > 
              </div> 
              <div class="R_New">
                    <div class="R_NewTop">
                        <div id="divNewTitle" class="R_NewTopTitle">
                            <div class="R_NewTopTitleItemSel" id="R_NewSN">三农快报</div>
                            <div class="R_NewTopTitleItem" id="R_NewInfor">各村资讯</div>
                            <div class="R_NewTopTitleItem" id="R_Nk">农科信息</div>
                        </div>
                    </div>
                    <div id="divShow" class="R_NewMiddle"> 
                          <div id="divSN" style="display:block">    
                           <ul id="ulSN" runat="server"> </ul>
                           <div class="divmore"><a href="###" id="amore1" runat="server">更多&gt;&gt;&gt;</a></div>
                           </div>           
                          <div style="display:none" id="divNewInfor">                         
                           <ul id="ulNewInfor" runat="server"> </ul>
                            <div class="divmore"><a href="###" id="amore2" runat="server">更多&gt;&gt;&gt;</a></div>
                          </div>
                          <div style="display:none" id="divUK">                
                           <ul id="ulNk" runat="server">
                                <li><a href="http://www.hljxcw.com/system/2010/07/02/010661323.shtml" target="_blank">农药质量合格率比上年提高3.8个百分点</a></li>
                                <li><a href="http://www.hljxcw.com/system/2010/07/02/010661324.shtml" target="_blank">中央财政农业综合开发资金完成预算66％</a></li>
                                <li><a href="http://www.hljxcw.com/system/2010/07/02/010661326.shtml" target="_blank">农业部部署稳定农产品市场运行</a></li>
                                <li><a href="http://www.hljxcw.com/system/2010/07/02/010661312.shtml" target="_blank">农民逐步跨入"信息化时代" </a></li>
                                <li><a href="http://www.hljxcw.com/system/2010/07/02/010661313.shtml" target="_blank">我国蔬菜质量安全水平稳步提升</a></li>
                                <li><a href="http://www.hljxcw.com/system/2010/07/02/010661314.shtml" target="_blank">国家级农业产业化龙头企业销售过万亿</a></li>
                            </ul>
                            <div class="divmore"><a href="/Category_64/Index.htm">更多&gt;&gt;&gt;</a></div>
                          </div>                  
                    </div>
                    <div class="R_NewBottom"></div>
               </div> 
        </div> 
     </div> 
     <asp:Literal ID="litBottomScript" runat="server"></asp:Literal>
    </form>
</body>
</html>
