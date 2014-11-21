<%@ Page Language="C#" AutoEventWireup="true" CodeFile="villageimage.aspx.cs" Inherits="web_villageimage" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="shortcut icon" id="lnkico" runat="server" />
    <asp:Literal ID="litTopCssAndScript" runat="server"></asp:Literal>  
</head>
<body>
    <form id="form1" runat="server" >
    <div id="divtop" runat="server"></div> 
     <div id="Main">
        <div class="hd header">
            <div class="nav" id="nav" runat="server" >
                    <a target="_blank" href="http://news.qq.com">首页</a> <em>&gt;</em> <a target="_blank" href="http://news.qq.com/photo.shtml">图片站</a> <span>&gt;</span> <a target="_blank" href="http://news.qq.com/l/photon/list20100920155222.htm">国内图片</a> <span>&gt;</span> 正文
            </div>
        </div>

       <div id="MainContext" class="wrapper-inner">

            <div class="hd">
                 <h1 id="htitle" runat="server"  ></h1> 
            </div>
       </div>

        <div id="gallery" class="ad-gallery">
            <div class="ad-image-wrapper"> </div>
            <div class="ad-controls"> </div>
            <div class="ad-nav">
                <div class="ad-thumbs">
                     <ul class="ad-thumb-list" id="adullist" runat="server">
                        <li>
                              <a href="images/1.jpg">
                                <img src="images/thumbs/t1.jpg"  >
                              </a>
                        </li>
                        <li>
                              <a href="images/10.jpg">
                                <img src="images/thumbs/t10.jpg" title="梁寨渊子湖" alt=""  >
                              </a>
                        </li>
                        <li>
                              <a href="images/11.jpg">
                                <img src="images/thumbs/t11.jpg" title="A title for 11.jpg" longdesc="http://coffeescripter.com" alt="This is a nice, and incredibly descriptive, description of the image 11.jpg"  >
                              </a>
                        </li>
                        <li>
                              <a href="images/12.jpg">
                                   <img src="images/thumbs/t12.jpg" title="A title for 12.jpg" alt="This is a nice, and incredibly descriptive, description of the image 12.jpg"  >
                              </a>
                        </li>
                        <li>
                              <a href="images/13.jpg">
                                   <img src="images/thumbs/t13.jpg" title="A title for 13.jpg" alt="This is a nice, and incredibly descriptive, description of the image 13.jpg"  >
                              </a>
                        </li>
                        <li>
                              <a href="images/14.jpg">
                                    <img src="images/thumbs/t14.jpg" title="A title for 14.jpg" alt="This is a nice, and incredibly descriptive, description of the image 14.jpg"  >
                              </a>
                        </li>
                        <li>
                              <a href="images/2.jpg">
                                     <img src="images/thumbs/t2.jpg" title="A title for 2.jpg" alt="This is a nice, and incredibly descriptive, description of the image 2.jpg"  >
                              </a>
                        </li>
                        <li>
                          <a href="images/3.jpg">
                            <img src="images/thumbs/t3.jpg" title="A title for 3.jpg" alt="This is a nice, and incredibly descriptive, description of the image 3.jpg" class="image7">
                          </a>
                        </li>
                        <li>
                          <a href="images/4.jpg">
                            <img src="images/thumbs/t4.jpg" title="A title for 4.jpg" alt="This is a nice, and incredibly descriptive, description of the image 4.jpg" class="image8">
                          </a>
                        </li>
                        <li>
                          <a href="images/5.jpg">
                            <img src="images/thumbs/t5.jpg" title="A title for 5.jpg" alt="This is a nice, and incredibly descriptive, description of the image 5.jpg" class="image9">
                          </a>
                        </li>
                        <li>
                          <a href="images/6.jpg">
                            <img src="images/thumbs/t6.jpg" title="A title for 6.jpg" alt="This is a nice, and incredibly descriptive, description of the image 6.jpg" class="image10">
                          </a>
                        </li>
                        <li>
                          <a href="images/7.jpg">
                            <img src="images/thumbs/t7.jpg" title="A title for 7.jpg" alt="This is a nice, and incredibly descriptive, description of the image 7.jpg" class="image11">
                          </a>
                        </li>
                        <li>
                          <a href="images/8.jpg">
                            <img src="images/thumbs/t8.jpg" title="A title for 8.jpg" alt="This is a nice, and incredibly descriptive, description of the image 8.jpg" class="image12">
                          </a>
                        </li>
                        <li>
                          <a href="images/9.jpg">
                            <img src="images/thumbs/t9.jpg" title="A title for 9.jpg" alt="This is a nice, and incredibly descriptive, description of the image 9.jpg" class="image13">
                          </a>
                        </li>

                        <li>
                        <a href="images/1-2.jpg">
                        <img src="images/1-1.jpg" title="A title for 8.jpg" alt="This is a nice, and incredibly descriptive, description of the image 8.jpg" class="image12">
                        </a>
                    </li>
                    <li>
                      <a href="images/2-2.jpg">
                        <img src="images/2-1.jpg" title="A title for 9.jpg" alt="This is a nice, and incredibly descriptive, description of the image 9.jpg" class="image13">
                      </a>
                    </li>
                    <li>
                       <a href="images/3-2.jpg">
                            <img src="images/3_1.jpg" title="A title for 8.jpg" alt="This is a nice, and incredibly descriptive, description of the image 8.jpg" class="image12">
                        </a>
                    </li>
                    <li>
                      <a href="images/4-2.jpg">
                            <img src="images/4-1.jpg" title="A title for 9.jpg" alt="This is a nice, and incredibly descriptive, description of the image 9.jpg" class="image13">
                      </a>
                     </li>

                    <li>
                          <a href="images/5-2.jpg">
                                <img src="images/5-1.jpg" title="A title for 8.jpg" alt="This is a nice, and incredibly descriptive, description of the image 8.jpg" class="image12">
                          </a>
                    </li>
                    <li>
                          <a href="images/6-2.jpg">
                                <img src="images/6-1.jpg" title="A title for 9.jpg" alt="This is a nice, and incredibly descriptive, description of the image 9.jpg" class="image13">
                          </a>
                    </li>  
          </ul>
                </div>
            </div>
        </div>
     </div>
        <asp:Literal ID="litBottomScript" runat="server"></asp:Literal>
    </form>
</body>
</html>
