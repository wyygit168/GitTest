using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using BusinessEntity;
using PersistenceLayer;

/// <summary>
///OperationMethod 的摘要说明
/// </summary>
public class OperationMethod:WebBasePage
{
    #region 网站用户登录 
    
    public string WebUserLgin(AjaxHelper ajaxEntity)
    {
        string returnValue = "0";
        string strUsername = ajaxEntity.Title;
        string strPwd = ajaxEntity.SAutoID;
        if (strUsername.Length == 0 || strPwd.Length == 0) returnValue = "-1";
        else
        {
            string strSql = string.Format("select AutoID from webuser where CustomerID='{0}' and Title='{1}' and UserPassword='{2}'", CustomerId, strUsername, strPwd);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                HttpCookie cookies = new HttpCookie(WULC);
                cookies[WULCN] = strUsername;
                cookies[WULCD] = strPwd;
                System.Web.HttpContext.Current.Response.Cookies.Add(cookies);
                returnValue = string.Format("<div class=\"inside_top\"><div id=\"login_bar\"><span class=\"top_hello \">您好， {0}！<a href=\"###\" id=\"afavorite\" title=\"点击收藏\" >欢迎光临{1}！</a>&nbsp;&nbsp;<a href=\"###\" id=\"aexit\" >[退出登录]</a></span> </div></div>", strUsername, WebTitle);
            }
        }
        return returnValue;
    }
    #endregion

    #region 网站用户退出
    /// <summary>
    /// 网站用户退出
    /// </summary>
    /// <returns></returns>
    public string WebUserExit()
    {
        string returnvalue = "0";
        HttpCookie cookie = new HttpCookie(WULC);
        if (cookie != null)
        {
            cookie.Expires = new DateTime(1900, 1, 1);// 删除Cookie，其实就是设置一个【过期的日期】
            HttpContext.Current.Response.Cookies.Add(cookie);
            StringBuilder sb = new StringBuilder();
            sb.Append("<div id=\"login_bar\">");
            sb.AppendFormat("<span class=\"top_hello \">您好，欢迎光临{0}！</span>", WebTitle);
            sb.Append("<div class=\"sign_in_box\" id=\"loginBox\">");
            sb.AppendFormat("<div class=\"set_float\" id=\"loginText\"><a href=\"javascript:void(0)\" >登录</a><span class=\"sign_in_down\" id=\"loginTextArrow\"><img src=\"{0}images/page/top/cn_common_new24.png\"  alt=\"\" title=\"\" /></span></div>", CurrentDomainRootPath);
            sb.Append("<div  id=\"sign_in_form_box\" class=\"none\" >");
            sb.Append("<div class=\"sign_fm\" id=\"sign_in_form_box_inner\">");
            sb.AppendFormat("<span class=\"sign_close\" id=\"cancel_img\"><img alt=\"关闭\" title=\"关闭\" src=\"{0}images/page/top/cn_common_new24.png\"  /></span>", CurrentDomainRootPath);
            sb.Append("<p class=\"sign_tip\" style=\"visibility: hidden;\" id=\"login_tip\">用户名或密码错误，请重新输入。</p>");
            sb.Append("<div class=\"item\">");
            sb.Append("<label for=\"account\">帐号：</label><input type=\"text\" value=\"\" maxlength=\"30\" name=\"name\" id=\"txtaccount\" />");
            sb.Append("</div>");
            sb.Append("<div class=\"item\">");
            sb.Append("<label for=\"actpwd\">密码：</label><input type=\"password\" value=\"\" maxlength=\"30\" id=\"txtactpwd\" />&nbsp;<a rel=\"nofollow\" href=\"###\" class=\"sign_lostfound\">忘记密码？</a>");
            sb.Append("</div>");
            sb.Append("<div class=\"item\"><input type=\"checkbox\" name=\"remIt\" value=\"7\" id=\"rem_it_1w\" ><label for=\"rem_it_1w\" class=\"ri1_label\">记住密码（一周）</label></input></div>");
            sb.Append("<div class=\"item si_set_float_wrap\">");
            sb.Append("<input type=\"button\"  title=\"登 录\" class=\"btn_sign_in\"   id=\"btnlogin\"  />");
            //sb.AppendFormat("<span class=\"wait4sign none\" id=\"logining\" style=\"display: none;\"><img src=\"{0}images/page/top/wait.gif\" title=\"\" alt=\"\" />登录中…</span>", CurrentDomainRootPath);
            sb.Append("<a href=\"javascript:void(0)\" class=\"cancel_sign\" id=\"sign_in_cancel\">取消</a>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.AppendFormat("<a rel=\"nofollow\" href=\"{0}\" class=\"sgin_up\">注册</a>", CurrentDomainRootPath + "reg/");
            sb.Append("</div>");
            sb.Append("</div>");
            returnvalue = sb.ToString();
        }
        return returnvalue;
    }
    #endregion

    #region 注册

    #region 网站用户注册

    /// <summary>
    /// 网站用户注册
    /// </summary>
    /// <param name="ajaxEntity"></param>
    /// <returns></returns>
    public string WebUserRegister(AjaxHelper ajaxEntity)
    {

        string returnValue = "0";
        string checkcode = ajaxEntity.Table2;
        if (checkcode.Length == 0 || !HttpContext.Current.Session["CheckCode"].ToString().ToLower().Equals(checkcode.ToLower()))
        {
            returnValue = "2";
        }
        else
        {
            webuserEntity objentity = new webuserEntity();
            objentity.Title = ajaxEntity.Title;
            objentity.UserPassword = ajaxEntity.SAutoID;
            objentity.RealName = ajaxEntity.Extend1;
            if (ajaxEntity.Extend2.Length > 0)
            {
                objentity.UserBirthday = Convert.ToDateTime(ajaxEntity.Extend2);
            }
            objentity.IdentityCard = ajaxEntity.Extend3;
            objentity.UserEmail = ajaxEntity.Extend4;
            objentity.MobilePhone = ajaxEntity.Extend5;
            objentity.Phone = ajaxEntity.Extend6;
            objentity.Address = ajaxEntity.Extend7;
            objentity.UserSex = ajaxEntity.Extend8;
            objentity.CustomerID = CustomerId;
            objentity.Status = 1;
            DateTime dtNow = DateTime.Now;
            objentity.CreateDate = objentity.ModifyDate = dtNow;
            int i = objentity.Save();
            if (i > 0)
            {
                returnValue = "1";
            }



        }
        return returnValue; 
    }
    #endregion 
    
    #region 检查注册验证码

    public string RegisterCheckCode(AjaxHelper ajaxEntity)
    {
        string returnValue = "1";
        string checkcode = ajaxEntity.Table2;
        if (checkcode.Length == 0 || !HttpContext.Current.Session["CheckCode"].ToString().ToLower().Equals(checkcode.ToLower()))
        {
            returnValue = "2";
        }
        return returnValue; 
    }

    #endregion 
    
    #region 检查注册姓名是否存在

    public string RegisterNameExist(AjaxHelper ajaxEntity)
    {
        string returnValue = "N";
        int curId = ajaxEntity.AutoID;
        string strSql = string.Format("SELECT Count(*) from webuser Where Title='{0}' and  Status<> 2 and CustomerID='{1}'", ajaxEntity.Title,CustomerId);
        if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        if (dt != null && dt.Rows.Count > 0)
        {
            if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
        }
        return returnValue;
    }

    #endregion 

    #endregion

    #region 三农快报 New页面

    /// <summary>
    /// 根据类型，判断是 三农快报、各村资讯、最新公告
    /// </summary>
    /// <param name="ajaxEntity"></param>
    /// <returns></returns>
    public string GetFarmingNewForAjax(AjaxHelper ajaxEntity)
    {
        
        string c_type = ajaxEntity.Extend2;
        string rHtml = GetHtmlString(ajaxEntity);
        string lhtml = "";
        switch (c_type.ToLower())
        {
            case "farming": lhtml = GetFarmingNew(); break;
            case "newaffice": lhtml = GetNewAffiche(); break;
            case "village": lhtml = GetVillageNew(); break;
            default:
                break;
        }

        return lhtml + "!@#$%%$#@!" + rHtml;

    }


    #region 查询三农快报
    /// <summary>
    /// 获取三农快报的Ajax实体
    /// </summary>
    /// <param name="ajaxEntity"></param>
    /// <returns></returns>
    public AjaxHelper GetAjaxHelperForfarming(AjaxHelper ajaxEntity)
    {
        string strWhere="";
        switch (ajaxEntity.Extend1.ToLower())
        {
            case "farming": strWhere = string.Format("AND  Status=1 AND Opertype=0 "); //三农快报
                            break;
            case "newaffice": strWhere = string.Format(" AND  Status=1 AND Opertype=1 AND CustomerID={0} AND TownID={1} AND VillageID=0  ",CustomerId,TownID);  //最新公告
                           break;
            case "village": strWhere = string.Format(" AND  Status=1 AND Opertype=1 AND CustomerID={0} AND TownID={1} AND VillageID<>0  ",CustomerId,TownID);  //最新公告
                           break;
            default:
                break;
        }
        string strPage = string.Empty;
        string strContent = string.Empty;
        ajaxEntity.StrWhere = strWhere;
        ajaxEntity.Column = "AutoID,Title";
        ajaxEntity.Table = "webfarmingnews";
        ajaxEntity = DataHelper.SinglePaginationSearch(ajaxEntity);
        return ajaxEntity;
    }

    /// <summary>
    /// 系统用户列表_拼接Table
    /// </summary>
    public string CreateTableForSystemUser(DataTable dt)
    {
        StringBuilder sb = new StringBuilder();
        if (dt != null && dt.Rows.Count > 0)
        { 
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("<tr>");
                sb.Append("<td  class=\"QTitle\">");
                sb.AppendFormat("<a title=\"{0}\" style=\"margin-left: 10px;\" href=\"{1}\">{0}</a>", dr["Title"], CurrentDomainRootPath + "newsdetail/" + dr["AutoID"] + "/");
                sb.Append("</td>");
                sb.Append("</tr>");
            }
         }
        return sb.ToString();
    }
    #endregion 

    #region 拼装最新公告
    /// <summary>
    /// 拼装最新公告
    /// </summary>
    public string  GetNewAffiche()
    {
        StringBuilder sb = new StringBuilder();
        DataRow[] drow = DTFarmingNews.Select(" VillageID=0 and Opertype=1 ");
        return GetCommonString(drow);
    }
    #endregion

    #region 拼装三农资讯
    /// <summary>
    /// 拼装三农资讯
    /// </summary>
    public string GetFarmingNew()
    {
        DataRow[] drow = DTFarmingNews.Select(" Opertype=0 ");
        return GetCommonString(drow);
    }
    #endregion

    #region 拼装各村资讯
    /// <summary>
    /// 拼装各村资讯
    /// </summary>
    public string  GetVillageNew()
    {
        StringBuilder sb = new StringBuilder();
        DataRow[] drow = DTFarmingNews.Select(" VillageID>0 and Opertype=1 ");
        return GetCommonString(drow);
    }
    #endregion

    #region 拼装公共字符串
    /// <summary>
    /// 拼装公共字符串
    /// </summary>
    /// <param name="drow"></param>
    /// <returns></returns>
    public string GetCommonString(DataRow[] drow)
    {
        StringBuilder sb = new StringBuilder();
        if (drow != null && drow.Length > 0)
        {
            int i = 0;
            foreach (DataRow dr in drow)
            {
                if (i < 10 && drow.Length > i)
                {
                    sb.AppendFormat("<li><a  title=\"{0}\" href=\"{1}\">{0}</a></li>", dr["Title"],CurrentDomainRootPath+"newsdetail/"+dr["AutoID"]+"/");
                }
                else
                {
                    break;
                }
            }
        }
        return sb.ToString();
    }
    #endregion
    #endregion 

    #region 查询通用方法
    /// <summary>
    ///  通用方法：获取查询列表字符串
    /// </summary>
    /// <param name="ajaxEntity"></param>
    /// <returns></returns>
    public string GetHtmlString(AjaxHelper ajaxEntity)
    {
        string strPage = string.Empty;
        string strContent = string.Empty;
        ajaxEntity = GetAjaxHelper(ajaxEntity);

        DataTable dt = ajaxEntity.DTable;
        if ((dt == null || dt.Rows.Count == 0) && ajaxEntity.PageIndex != 0)
        {
            ajaxEntity.PageIndex = ajaxEntity.PageIndex - 1;
            return GetHtmlString(ajaxEntity);
        }
        else
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                //int i = 1;
                //dt.Columns.Add(new DataColumn("No"));
                //foreach (DataRow dr in dt.Rows)
                //{
                //    dr["No"] = (ajaxEntity.PageIndex * ajaxEntity.PageSize) + i;
                //    i++;

                //}
                strContent = CreateTable(dt, ajaxEntity.Action);
            }
            else
            {
                strContent = "";
            }
            strPage = DataHelper.SetPagination(ajaxEntity.PageSize, ajaxEntity.TotleCount, ajaxEntity.PageIndex);
        }

        return strContent + "$$$$" + strPage + "$$$$" + ajaxEntity.PageIndex;
    }

    /// <summary>
    /// 通用方法：获取AjaxHelper
    /// </summary>
    /// <param name="ajaxEntity"></param>
    /// <returns></returns>
    public AjaxHelper GetAjaxHelper(AjaxHelper ajaxEntity)
    {
        switch (ajaxEntity.Action.ToLower())
        {
            case "farmingnews": ajaxEntity = GetAjaxHelperForfarming(ajaxEntity); break;
            default:
                break;
        }
        return ajaxEntity;
    }


    /// <summary>
    /// 通用方法：拼接Table
    /// </summary>
    public string CreateTable(DataTable dt, string action)
    {
        string strData = "";
        switch (action.ToLower())
        {
            case "farmingnews": strData = CreateTableForSystemUser(dt); break;
             
            default: break;
        }
        return strData;
    }

    #endregion
}