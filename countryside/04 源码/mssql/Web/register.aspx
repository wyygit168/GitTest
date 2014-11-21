<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"  id="Head">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="shortcut icon" id="lnkico" runat="server" />
    <asp:Literal ID="litTopCssAndScript" runat="server"></asp:Literal>
    <link href="style/admin/one/validator.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
     <%-- <div id="divtop" runat="server"></div> --%>
      <div id="Main"> 
          <div class="register">
              <div class="reg_top">
	               <div class="reg_top_title"><img  id="imgtop" runat="server" src="###" alt="" title="" />新用户注册</div>
	          </div>
              <div class="reg_titleinfor">基本信息<span class="spansign"> （* 为必填项）</span></div>
              <table  border="0"  class="reg_table">
		        <tbody>
                    <tr>
			            <td  class="tdleft"><span class="spansign">*</span>用户名：</td>
			            <td  class="tdcenter"><input type="text" maxlength="30" id="txtTitle" style=" width:214px;" class="input_20txt" /></td>
			            <td  class="tdright">
                           <span class="onshow" id="spanname" runat="server">由字母、数字或“_”组成，长度不少于3位，不多于30位</span>
                         </td>
		            </tr>
                    <tr>
			            <td class="tdleft"><span class="spansign">*</span>性别：</td>
			            <td class="tdcenter"><input type="radio" name="rdoUserSex" value="1" checked="checked" id="gender"/>男 <input type="radio" name="rdoUserSex" value="0" id="Radio1"/>女</td>
			            <td class="tdright"></td>
		            </tr>
                    
		            <tr>
			            <td class="tdleft"><span class="spansign">*</span>密码：</td>
			            <td class="tdcenter"><input type="password"   maxlength="30" value="" id="txtUserPassword" style=" width:214px;" class="input_20txt" /></td>
			            <td class="tdright"><span class="onshow" id="spanpwd" runat="server">不少于3位字符</span>
 			            </td>
		            </tr>
		            <tr>
			            <td class="tdleft"><span class="spansign">*</span>密码确认：</td>
			            <td class="tdcenter"><input type="password"   maxlength="30" value="" id="txtconfirmUserPassWord" style="width:214px;" class="input_20txt" /></td>
			            <td class="tdright"> <span class="onshow" id="spanpwdsure" runat="server">请再次输入密码</span>
                         </td>
		            </tr> 
		            <tr>
			            <td class="tdleft"><span class="spansign">*</span>验证码：</td>
			            <td class="tdcenter"><div class="checkcodetxt" ><input type="text"   maxlength="4" value="" id="randcode" style="width:152px;" class="input_20txt" /></div><div class="checkcodeImage" ><img  id="imgVerify" runat="server"  src="#" onclick="this.src=this.src.substring(0, this.src.lastIndexOf('/')+1)+Math.rand(1, 5000);" alt="看不清？点击更换！" title="看不清？点击更换！" /></div><div class="clear_float"></div></td>
			            <td class="tdright"><span class="onshow" id="spancheckcode" runat="server"><a href="###" id="acheckcode" onclick="getcheckcode()" style="color:#2c72ba">看不清，换一张</a></span></td>
		            </tr>
	          </tbody> 
            </table>
              <div class="reg_titleinfor">详细信息</div>
              <table   border="0"  class="reg_table">
		        <tbody>
                    <tr>
			            <td  class="tdleft" >姓名：</td>
			            <td  class="tdcenter"><input type="text"   maxlength="20" value="" id="txtRealName" style=" width:214px;" class="input_20txt"/></td>
			            <td  class="tdright">&nbsp;</td>
		            </tr>
		            <tr>
			            <td class="tdleft">出生日期：</td>
			            <td class="tdcenter"><input type="text"  value="" id="txtUserBirthday" style="ime-mode:disabled;width:214px;" class="input_20txt" /></td>
			            <td class="tdright"><span class="onshow" id="spanbirthday" runat="server">格式如：1988-01-08</span>
			            </td>

			           
		            </tr>
		            <tr>
			            <td class="tdleft">身份证号：</td>
			            <td class="tdcenter"><input type="text"   maxlength="50" value="" id="txtIdentityCard" style=" width:214px;text-transform:uppercase;" class="input_20txt" /></td>
			            <td class="tdright"> &nbsp;</td>
	               </tr>
                    <tr>
			            <td class="tdleft">电子邮件：</td>
			            <td class="tdcenter"><input type="text"   maxlength="50" value="" id="txtUserEmail" style="width:214px;" class="input_20txt" /></td>
			            <td class="tdright">&nbsp;</td>
		            </tr>
                   <tr>
			            <td class="tdleft">手机号码：</td>
			            <td class="tdcenter"><input type="text"   maxlength="50" value="" id="txtMobilePhone" style=" width:214px;" class="input_20txt" /></td>
			            <td class="tdright"> &nbsp; </td>
		          </tr>
		          <tr>
			            <td class="tdleft">固定电话：</td>
			            <td class="tdcenter"><input type="text"  maxlength="50" value="" id="txtPhone" style="width:214px;" class="input_20txt" /></td>
			            <td class="tdright">&nbsp;</td>
		          </tr>
		
		          <tr>
			            <td class="tdleft">居住地址：</td>
			            <td class="tdcenter"><input type="text"  maxlength="50" size="50" value="" id="txtAddress" style="width:214px;" class="input_20txt" /></td>
			            <td class="tdright">&nbsp;</td>
		          </tr>
		        </tbody> 
              </table>
              <div class="tj1">
                  <a href="#" class="button_c" id="submitLink"><span><ins>提交信息</ins></span></a>
                 
                  <a href="#" class="button_c" id="aindex" runat="server"><span><ins>返回首页</ins></span></a>
              </div>
         </div> 
       </div>
       <div style="display:none"><input type="text" id="txtbk" value="" /> </div>
       <asp:Literal ID="litBottomScript" runat="server"></asp:Literal> 
         
    </form>
</body>
</html>
