using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using BusinessEntity;
using PersistenceLayer;

namespace BLL.Service
{
    /// <summary>
    ///系统设置功能方法实现
    /// </summary>
    public class WebSet : SystemBasePage
    {
        public WebSet(string pagestatus)
        {
            PageStatus = pagestatus;
        }
         
        #region WebMen 网站菜单

        #region 查询网站菜单列表
        /// <summary>
        /// 获取网站菜单的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForWebMenu(AjaxHelper ajaxEntity)
        {
            string strWhere = "where 1=1 ";
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere += string.Format(@" and h.Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend1.Length > 0)
            {
                if (ajaxEntity.Extend1 == "1") strWhere += string.Format(@" and wcm.status =1 ");
                else strWhere += string.Format(@" and (wcm.status =0 or  wcm.status is null ) "); 
            } 
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and h.Status='{0}' ", ajaxEntity.Status);
            else strWhere +="  and  h.Status <> 2  ";
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = "h.Title,h.AutoID,h.OrderValue,h.url,h.Status,h.CreateDate,wcm.CustomerID,wcm.status wcmstatus ";
            ajaxEntity.Table = " webmenu h ";
            ajaxEntity.Table2 = " left join web_customer_menu wcm on h.AutoID=wcm.MenuID ";
            ajaxEntity.StrOrderBy = "  order by  wcm.OrderValue desc, h.ordervalue desc,h.AutoID asc ";
            ajaxEntity = DataHelper.MultiPaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 网站菜单列表_拼接Table
        /// </summary>
        public string CreateTableForWebMenu(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = WebData.DetailForWebMenu;
                
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                 string purviewvalueforedit = "";
                 string purviewvalueforview = "";
                 string purviewvaluefordel = "";
                int opertionWidth = 0;
                if (CurrentCustomerID == 0)
                {
                    purviewvalueforedit = GetPurviewForUrl(url, "edit");
                    purviewvalueforview = GetPurviewForUrl(url, "view");
                    purviewvaluefordel = GetPurviewForUrl(url, "delete");
                    if (purviewvalueforedit == "1") opertionWidth += 50;
                    if (purviewvalueforview == "1") opertionWidth += 50;
                    if (purviewvaluefordel == "1") opertionWidth += 50;
                }
                string opertionColTitle = "";
                string opertionTdTitle = "";
                if (opertionWidth > 0)
                {
                    opertionColTitle = string.Format("<col width='{0}px' />", opertionWidth);
                    opertionTdTitle = "<td class='head'>操作</td>"; 
                }
                sb.AppendFormat(@"<table class='showList' id='tbList' >
                     <colgroup>
                            <col width='20px'/>
                            <col width='50px'/>
                            <col /> 
                            <col width='180px'/>
                            <col width='75px'/>
                            <col width='90px'/>
                            <col width='90px'/>
                            <col width='170px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>菜单名称</td> 
                            <td  class='head allowRow'>菜单Url</td> 
                            <td  class='head'>排序值</td>
                            <td  class='head'>菜单状态</td>
                            <td  class='head'>启用状态</td>
                            <td  class='head'>创建日期</td>
                            {1}
                    </tr>", opertionColTitle, opertionTdTitle);

                foreach (DataRow dr in dt.Rows)
                {
                    sb.AppendFormat("<tr>");
                    sb.AppendFormat("<td><input type=\"checkbox\" name=\"ckbAllList\" value=\"{0}\" onclick=\"ckbclick()\"  /></td>", dr["AutoID"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["No"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["Title"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["Url"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    if(CurrentCustomerID==0)
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    else
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    string enablestatus =string.IsNullOrEmpty(dr["wcmstatus"].ToString())? "3" : dr["wcmstatus"].ToString();
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changeenablestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToEnableStatus(enablestatus), dr["AutoID"], enablestatus, CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('webmenusetdetail.aspx?curId={0}&action=edit',900,450,'【网站菜单】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('webmenusetdetail.aspx?curId={0}&action=view',900,450,'【网站菜单】：查看')\">查看</a>", dr["AutoID"]);
                        if (purviewvaluefordel == "1") strOperDelFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"deletesinglerecord({0})\">删除</a>", dr["AutoID"]);
                        sb.AppendFormat("<td class=\"tdCenter\">{0}{1}{2}&nbsp;</td>", strOperViewFunc, strOperEditFunc, strOperDelFunc);
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table><script type='text/javascript'>rowOutAndOver('tbList');</script>");
            }
            return sb.ToString();
        }
        #endregion

        #region 更新网站菜单状态
        /// <summary>
        /// 改变网站菜单状态,返回查询字符串
        /// </summary>
        public string ChangeWebMenuStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeWebMenuStatus(ajaxEntity);
            ajaxEntity.Action = WebData.WebMenu;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变网站菜单状态 
        /// </summary>
        public void ChangeWebMenuStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            webmenuEntity userEntity = new webmenuEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 更新网站启用状态
        /// <summary>
        /// 改变网站启用状态,返回查询字符串
        /// </summary>
        public string ChangeWebMenuEnableStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeWebMenuEnableStatus(ajaxEntity);
            ajaxEntity.Action = WebData.WebMenu;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变网站启用状态
        /// </summary>
        public void ChangeWebMenuEnableStatus(AjaxHelper ajaxEntity)
        {
            string iUpdataStatus = ajaxEntity.Extend2; 
            string modifyStatus = "0";
            bool isInsert=false;
            if (iUpdataStatus == "3")
            {
                isInsert = true;
                modifyStatus = "1";
            }
            else modifyStatus = iUpdataStatus == "0" ? "1" : "0";
            DateTime dtNow=DateTime.Now;
            string strSql = "";
            if (isInsert)
            {

                strSql = string.Format(@"insert into  web_customer_menu values({0},{1},{2},{3},
                                              {4},'{5}',{6},'{7}' )", ajaxEntity.AutoID, CurrentCustomerID, modifyStatus,
                                                              0, CurrentUserID, dtNow, CurrentUserID, dtNow);

            }
            else
            {
                strSql = string.Format(@"update web_customer_menu  set Status='{0}' where MenuID='{1}' and CustomerID='{2}'", modifyStatus,ajaxEntity.AutoID, CurrentCustomerID);

            }
            Query.ProcessSqlNonQuery(strSql, DataHelper.DataBase);
          
        }
        #endregion

        #region 判断网站菜单名称是否存在
        /// <summary>
        /// 判断网站菜单名称是否存在
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckWebMenuNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from webmenu Where Title='{0}' and  Status<>2 ", ajaxEntity.Title);
            if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }

        #endregion

        #region 删除单个网站菜单
        /// <summary>
        /// 删除单个网站菜单
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForWebMenu(AjaxHelper ajaxEntity)
        {
            webmenuEntity obj = new webmenuEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = WebData.WebMenu;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除网站菜单
        /// <summary>
        /// 批量删除网站菜单
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForWebMenu(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(webmenuEntity));
            uc.GetNewCondition().AddIn(webmenuEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(webmenuEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = WebData.WebMenu;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion 

        #region FarmingNews 资讯速递

        #region 查询资讯速递列表
        /// <summary>
        /// 获取资讯速递的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForWebFarmingNews(AjaxHelper ajaxEntity)
        {
            string strWhere = string.Format(" and CustomerID='{0}' and   TownID='{1}'  ", CurrentCustomerID,  CurrentUser.TownID);
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere += string.Format(@" and Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend1.Length > 0)
            {
                if (ajaxEntity.Extend1 == "0")
                {
                    strWhere += string.Format(@" and Opertype ='0' ");
                }
                else if(ajaxEntity.Extend1=="1")
                {
                    strWhere += string.Format(@" and Opertype ='1' and VillageID<>0 ", ajaxEntity.Extend1);
                }
                else if (ajaxEntity.Extend1 == "2")
                {
                    strWhere += string.Format(@" and Opertype ='1' and VillageID='0' ", ajaxEntity.Extend1);
                }
            }
            if (ajaxEntity.Extend1 != "0" && ajaxEntity.Extend3.Length > 0)
            {
                strWhere += string.Format(@" and VillageID ='{0}' and Opertype <>0 ", ajaxEntity.Extend3);
             }
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and  Status='{0}' ", ajaxEntity.Status);
            else strWhere += "  and   Status <> 2  ";
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = " Title, AutoID,OrderValue,Opertype,VillageID,Status,CreateDate,(select Title from areavillage av where av.AutoID=h.VillageID) as avtitle   ";
            ajaxEntity.Table = " webfarmingnews ";
            ajaxEntity.StrOrderBy = "  order by  ordervalue desc,AutoID asc  ";
            ajaxEntity = DataHelper.SinglePaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 资讯速递列表_拼接Table
        /// </summary>
        public string CreateTableForWebFarmingNews(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = WebData.DetailForWebFarmingNews;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = "";
                string purviewvalueforview = "";
                string purviewvaluefordel = "";
                int opertionWidth = 0;
                if (CurrentCustomerID == 0)
                {
                    purviewvalueforedit = GetPurviewForUrl(url, "edit");
                    purviewvalueforview = GetPurviewForUrl(url, "view");
                    purviewvaluefordel = GetPurviewForUrl(url, "delete");
                    if (purviewvalueforedit == "1") opertionWidth += 50;
                    if (purviewvalueforview == "1") opertionWidth += 50;
                    if (purviewvaluefordel == "1") opertionWidth += 50;
                }
                string opertionColTitle = "";
                string opertionTdTitle = "";
                if (opertionWidth > 0)
                {
                    opertionColTitle = string.Format("<col width='{0}px' />", opertionWidth);
                    opertionTdTitle = "<td class='head'>操作</td>";
                }
                sb.AppendFormat(@"<table class='showList' id='tbList' >
                     <colgroup>
                            <col width='20px'/>
                            <col width='50px'/>
                            <col />  
                            <col width='150spx'/>
                            <col width='70px'/>
                            <col width='60px'/> 
                            <col width='165px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>标题名称</td>
                            <td  class='head allowRow'>资讯类型</td>    
                            <td  class='head'>排序值</td>
                            <td  class='head'>状态</td> 
                            <td  class='head'>创建日期</td>
                            {1}
                    </tr>", opertionColTitle, opertionTdTitle);

                foreach (DataRow dr in dt.Rows)
                {
                    sb.AppendFormat("<tr>");
                    sb.AppendFormat("<td><input type=\"checkbox\" name=\"ckbAllList\" value=\"{0}\" onclick=\"ckbclick()\"  /></td>", dr["AutoID"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["No"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["Title"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", CommonMethod.ConvertToFarmingNewStatus(dr["Opertype"].ToString(), dr["VillageID"].ToString(), dr["avtitle"] == null ? "" : dr["avtitle"].ToString()));
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('farmingnewsdetail.aspx?curId={0}&action=edit',1000,600,'【资讯速递】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('farmingnewsdetail.aspx?curId={0}&action=view',1000,600,'【资讯速递】：查看')\">查看</a>", dr["AutoID"]);
                        if (purviewvaluefordel == "1") strOperDelFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"deletesinglerecord({0})\">删除</a>", dr["AutoID"]);
                        sb.AppendFormat("<td class=\"tdCenter\">{0}{1}{2}&nbsp;</td>", strOperViewFunc, strOperEditFunc, strOperDelFunc);
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table><script type='text/javascript'>rowOutAndOver('tbList');</script>");
            }
            return sb.ToString();
        }
        #endregion

        #region 更新资讯速递状态
        /// <summary>
        /// 改变资讯速递状态,返回查询字符串
        /// </summary>
        public string ChangeWebFarmingNewsStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeWebFarmingNewsStatus(ajaxEntity);
            ajaxEntity.Action = WebData.WebFarmingNews;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变资讯速递状态 
        /// </summary>
        public void ChangeWebFarmingNewsStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            webfarmingnewsEntity userEntity = new webfarmingnewsEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion  

        #region 删除单个资讯速递
        /// <summary>
        /// 删除单个资讯速递
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForWebFarmingNews(AjaxHelper ajaxEntity)
        {
            webfarmingnewsEntity obj = new webfarmingnewsEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = WebData.WebFarmingNews;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除资讯速递
        /// <summary>
        /// 批量删除资讯速递
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForWebFarmingNews(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(webfarmingnewsEntity));
            uc.GetNewCondition().AddIn(webfarmingnewsEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(webfarmingnewsEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = WebData.WebFarmingNews;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion 

        #region BeautifulVillage 魅力乡村-概述

        #region 查询魅力乡村列表
        /// <summary>
        /// 获取魅力乡村的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForWebBeautifulVillage(AjaxHelper ajaxEntity)
        {
            string strWhere = string.Format(" where h.CustomerID='{0}' and   h.TownID='{1}'  ", CurrentCustomerID, CurrentUser.TownID);
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere += string.Format(@" and h.Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend3.Length > 0) strWhere += string.Format(@" and h.VillageID ='{0}' ", ajaxEntity.Extend3);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and   h.Status='{0}' ", ajaxEntity.Status);
            else strWhere += "  and    h.Status <> 2  "; 

            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = " h.Title, h.AutoID,h.OrderValue, h.Status,h.CreateDate,v.Title VillageTitle  ";
            ajaxEntity.Table = " webbeautifulvillage  h ";
            ajaxEntity.Table2 = " inner join areavillage v on h.VillageID=v.AutoID ";
            ajaxEntity.StrOrderBy = "  order by  h.ordervalue desc,h.AutoID asc ";
            ajaxEntity = DataHelper.MultiPaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 魅力乡村列表_拼接Table
        /// </summary>
        public string CreateTableForWebBeautifulVillage(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = WebData.DetailForWebBeautifulVillage;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = "";
                string purviewvalueforview = "";
                string purviewvaluefordel = "";
                int opertionWidth = 0;
                if (CurrentCustomerID == 0)
                {
                    purviewvalueforedit = GetPurviewForUrl(url, "edit");
                    purviewvalueforview = GetPurviewForUrl(url, "view");
                    purviewvaluefordel = GetPurviewForUrl(url, "delete");
                    if (purviewvalueforedit == "1") opertionWidth += 50;
                    if (purviewvalueforview == "1") opertionWidth += 50;
                    if (purviewvaluefordel == "1") opertionWidth += 50;
                }
                string opertionColTitle = "";
                string opertionTdTitle = "";
                if (opertionWidth > 0)
                {
                    opertionColTitle = string.Format("<col width='{0}px' />", opertionWidth);
                    opertionTdTitle = "<td class='head'>操作</td>";
                }
                sb.AppendFormat(@"<table class='showList' id='tbList' >
                     <colgroup>
                            <col width='20px'/>
                            <col width='50px'/>
                            <col />  
                            <col width='120px'/>
                            <col width='75px'/>
                            <col width='70px'/> 
                            <col width='180px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>标题名称</td>  
                            <td  class='head allowRow'>所属乡村</td> 
                            <td  class='head'>排序值</td>
                            <td  class='head'>状态</td> 
                            <td  class='head'>创建日期</td>
                            {1}
                    </tr>", opertionColTitle, opertionTdTitle);

                foreach (DataRow dr in dt.Rows)
                {
                    sb.AppendFormat("<tr>");
                    sb.AppendFormat("<td><input type=\"checkbox\" name=\"ckbAllList\" value=\"{0}\" onclick=\"ckbclick()\"  /></td>", dr["AutoID"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["No"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["Title"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["VillageTitle"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('beautifulvillagedetail.aspx?curId={0}&action=edit',1000,600,'【魅力乡村】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('beautifulvillagedetail.aspx?curId={0}&action=view',1000,600,'【魅力乡村】：查看')\">查看</a>", dr["AutoID"]);
                        if (purviewvaluefordel == "1") strOperDelFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"deletesinglerecord({0})\">删除</a>", dr["AutoID"]);
                        sb.AppendFormat("<td class=\"tdCenter\">{0}{1}{2}&nbsp;</td>", strOperViewFunc, strOperEditFunc, strOperDelFunc);
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table><script type='text/javascript'>rowOutAndOver('tbList');</script>");
            }
            return sb.ToString();
        }
        #endregion

        #region 更新魅力乡村状态
        /// <summary>
        /// 改变魅力乡村状态,返回查询字符串
        /// </summary>
        public string ChangeWebBeautifulVillageStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeWebBeautifulVillageStatus(ajaxEntity);
            ajaxEntity.Action = WebData.WebBeautifulVillage;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变魅力乡村状态 
        /// </summary>
        public void ChangeWebBeautifulVillageStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            webbeautifulvillageEntity userEntity = new webbeautifulvillageEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 删除单个魅力乡村
        /// <summary>
        /// 删除单个魅力乡村
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForWebBeautifulVillage(AjaxHelper ajaxEntity)
        {
            webbeautifulvillageEntity obj = new webbeautifulvillageEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = WebData.WebBeautifulVillage;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除魅力乡村
        /// <summary>
        /// 批量删除魅力乡村
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForWebBeautifulVillage(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(webbeautifulvillageEntity));
            uc.GetNewCondition().AddIn(webbeautifulvillageEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(webbeautifulvillageEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = WebData.WebBeautifulVillage;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion 

        #region BeautifulVillage 魅力乡村文件：图片、视频 

        #region 查询魅力乡村文件列表
        /// <summary>
        /// 获取魅力乡村文件的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForWebBeautifulVillageFlie(AjaxHelper ajaxEntity)
        {
            string strWhere = string.Format(" where h.FileType='{2}' and  h.CustomerID='{0}' and   h.TownID='{1}'  ", CurrentCustomerID, CurrentUser.TownID,ajaxEntity.Extend8);

            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere += string.Format(@" and h.Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend3.Length > 0) strWhere += string.Format(@" and h.VillageID ='{0}' ", ajaxEntity.Extend3);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and   h.Status='{0}' ", ajaxEntity.Status);
            else strWhere += "  and    h.Status <> 2  ";

            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = " h.Title, h.AutoID,h.OrderValue,h.FileSUrl,h.FileUrl,h.Status,h.CreateDate,v.Title VillageTitle  ";
            ajaxEntity.Table = " webbeautifulvillageFile  h ";
            ajaxEntity.Table2 = " inner join areavillage v on h.VillageID=v.AutoID ";
            ajaxEntity.StrOrderBy = "  order by  h.ordervalue desc,h.AutoID asc ";
            ajaxEntity = DataHelper.MultiPaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 魅力乡村文件列表_拼接Table
        /// </summary>
        public string CreateTableForWebBeautifulVillageFile(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = WebData.DetailForWebBeautifulImageVillage;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = "";
                string purviewvalueforview = "";
                string purviewvaluefordel = "";
                int opertionWidth = 0;
                if (CurrentCustomerID == 0)
                {
                    purviewvalueforedit = GetPurviewForUrl(url, "edit");
                    purviewvalueforview = GetPurviewForUrl(url, "view");
                    purviewvaluefordel = GetPurviewForUrl(url, "delete");
                    if (purviewvalueforedit == "1") opertionWidth += 50;
                    if (purviewvalueforview == "1") opertionWidth += 50;
                    if (purviewvaluefordel == "1") opertionWidth += 50;
                }
                string opertionColTitle = "";
                string opertionTdTitle = "";
                if (opertionWidth > 0)
                {
                    opertionColTitle = string.Format("<col width='{0}px' />", opertionWidth);
                    opertionTdTitle = "<td class='head'>操作</td>";
                }
                sb.AppendFormat(@"<table class='showList' id='tbList' >
                     <colgroup>
                            <col width='20px'/>
                            <col width='50px'/>
                            <col width='50px'/>
                            <col />  
                            <col width='120px'/>
                            <col width='180px'/>
                            <col width='75px'/>
                            <col width='180px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>预览</td>  
                            <td  class='head allowRow'>图片名称</td>
                            <td  class='head allowRow'>所属乡村</td>
                            <td  class='head'>排序值</td>
                            <td  class='head'>状态</td> 
                            <td  class='head'>创建日期</td>
                            {1}
                    </tr>", opertionColTitle, opertionTdTitle);

                foreach (DataRow dr in dt.Rows)
                {
                    sb.AppendFormat("<tr>");
                    sb.AppendFormat("<td><input type=\"checkbox\" name=\"ckbAllList\" value=\"{0}\" onclick=\"ckbclick()\"  /></td>", dr["AutoID"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["No"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a target=\"_blank\" href=\"{1}\"><img src='{0}' style='width:25px;height:20px;' onmouseover='InPreviewImage(this,\"{1}\",100,220,400,300)' onmouseout='OutPreviewImage()'/ ></a></td>", CurrentDomainRootPath + dr["FileSUrl"], CurrentDomainRootPath + dr["FileUrl"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["Title"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["VillageTitle"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('beautifulvillagedetail.aspx?curId={0}&action=edit&pagetype=0',550,599,'【魅力乡村-图片】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('beautifulvillagedetail.aspx?curId={0}&action=view&pagetype=0',550,550,'【魅力乡村-图片】：查看')\">查看</a>", dr["AutoID"]);
                        if (purviewvaluefordel == "1") strOperDelFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"deletesinglerecord({0})\">删除</a>", dr["AutoID"]);
                        sb.AppendFormat("<td class=\"tdCenter\">{0}{1}{2}&nbsp;</td>", strOperViewFunc, strOperEditFunc, strOperDelFunc);
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table><script type='text/javascript'>rowOutAndOver('tbList');</script>");
            }
            return sb.ToString();
        }


       
        #endregion

        #region 更新魅力乡村文件状态-文件
        /// <summary>
        /// 改变魅力乡村文件状态,返回查询字符串
        /// </summary>
        public string ChangeWebBeautifulVillageFileStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeWebBeautifulVillageFileStatus(ajaxEntity);
            if (ajaxEntity.Extend8 == "2") ajaxEntity.Action = WebData.WebLbtImage;
            else ajaxEntity.Action = WebData.WebBeautifulVillageImage;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变魅力乡村文件状态 
        /// </summary>
        public void ChangeWebBeautifulVillageFileStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            webbeautifulvillageFileEntity userEntity = new webbeautifulvillageFileEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 删除单个魅力乡村-文件
        /// <summary>
        /// 删除单个魅力乡村-文件
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForWebBeautifulVillageFile(AjaxHelper ajaxEntity)
        {
            webbeautifulvillageFileEntity obj = new webbeautifulvillageFileEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            if (ajaxEntity.Extend8 == "2") ajaxEntity.Action = WebData.WebLbtImage;
            else ajaxEntity.Action = WebData.WebBeautifulVillageImage;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除魅力乡村-文件
        /// <summary>
        /// 批量删除魅力乡村-文件
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForWebBeautifulVillageFile(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(webbeautifulvillageFileEntity));
            uc.GetNewCondition().AddIn(webbeautifulvillageFileEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(webbeautifulvillageFileEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            if (ajaxEntity.Extend8 == "2") ajaxEntity.Action = WebData.WebLbtImage;
            else ajaxEntity.Action = WebData.WebBeautifulVillageImage;

            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion 

        #region ImageSet 图片设置 图片设置

        
        /// <summary>
        /// 获取图片设置的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForWebLbtImage(AjaxHelper ajaxEntity)
        {
            string strWhere = string.Format(" where h.FileType='{2}' and  h.CustomerID='{0}' and   h.TownID='{1}'  ", CurrentCustomerID, CurrentUser.TownID, ajaxEntity.Extend8);

            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere += string.Format(@" and h.Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend3.Length > 0) strWhere += string.Format(@" and h.VillageID ='{0}' ", ajaxEntity.Extend3);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and   h.Status='{0}' ", ajaxEntity.Status);
            else strWhere += "  and    h.Status <> 2  ";

            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = " h.Title, h.AutoID,h.OrderValue,h.FileSUrl,h.FileUrl,h.Status,h.CreateDate ";
            ajaxEntity.Table = " webbeautifulvillageFile  h ";
            //ajaxEntity.Table2 = " inner join areavillage v on h.VillageID=v.AutoID ";
            ajaxEntity.StrOrderBy = "  order by  h.ordervalue desc,h.AutoID asc ";
            ajaxEntity = DataHelper.MultiPaginationSearch(ajaxEntity);
            return ajaxEntity;
        }


        /// <summary>
        /// 图片设置_拼接Table
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public string CreateTableForWebLbtImage(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = WebData.ImageSetDetail;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = "";
                string purviewvalueforview = "";
                string purviewvaluefordel = "";
                int opertionWidth = 0;
                if (CurrentCustomerID == 0)
                {
                    purviewvalueforedit = GetPurviewForUrl(url, "edit");
                    purviewvalueforview = GetPurviewForUrl(url, "view");
                    purviewvaluefordel = GetPurviewForUrl(url, "delete");
                    if (purviewvalueforedit == "1") opertionWidth += 50;
                    if (purviewvalueforview == "1") opertionWidth += 50;
                    if (purviewvaluefordel == "1") opertionWidth += 50;
                }
                string opertionColTitle = "";
                string opertionTdTitle = "";
                if (opertionWidth > 0)
                {
                    opertionColTitle = string.Format("<col width='{0}px' />", opertionWidth);
                    opertionTdTitle = "<td class='head'>操作</td>";
                }
                sb.AppendFormat(@"<table class='showList' id='tbList' >
                     <colgroup>
                            <col width='20px'/>
                            <col width='50px'/>
                            <col width='50px'/>
                            <col />  
                            
                            <col width='180px'/>
                            <col width='75px'/>
                            <col width='180px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>预览</td>  
                            <td  class='head allowRow'>图片名称</td>
                            
                            <td  class='head'>排序值</td>
                            <td  class='head'>状态</td> 
                            <td  class='head'>创建日期</td>
                            {1}
                    </tr>", opertionColTitle, opertionTdTitle);

                foreach (DataRow dr in dt.Rows)
                {
                    sb.AppendFormat("<tr>");
                    sb.AppendFormat("<td><input type=\"checkbox\" name=\"ckbAllList\" value=\"{0}\" onclick=\"ckbclick()\"  /></td>", dr["AutoID"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["No"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a target=\"_blank\" href=\"{1}\"><img src='{0}' style='width:25px;height:20px;' onmouseover='InPreviewImage(this,\"{1}\",380,220,960,120)' onmouseout='OutPreviewImage()'/ ></a></td>", CurrentDomainRootPath + dr["FileSUrl"], CurrentDomainRootPath + dr["FileUrl"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["Title"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('imagesetdetail.aspx?curId={0}&action=edit',960,400,'【首页轮播图】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('imagesetdetail.aspx?curId={0}&action=view',960,390,'【首页轮播图】：查看')\">查看</a>", dr["AutoID"]);
                        if (purviewvaluefordel == "1") strOperDelFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"deletesinglerecord({0})\">删除</a>", dr["AutoID"]);
                        sb.AppendFormat("<td class=\"tdCenter\">{0}{1}{2}&nbsp;</td>", strOperViewFunc, strOperEditFunc, strOperDelFunc);
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table><script type='text/javascript'>rowOutAndOver('tbList');</script>");
            }
            return sb.ToString();
        }

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
                    int i = 1;
                    dt.Columns.Add(new DataColumn("No"));
                    foreach (DataRow dr in dt.Rows)
                    {
                        dr["No"] = (ajaxEntity.PageIndex * ajaxEntity.PageSize) + i;
                        i++;

                    }
                    strContent = CreateTable(dt, ajaxEntity.Action);
                }
                else
                {
                    strContent = "";
                }
                strPage = DataHelper.SetPagination(ajaxEntity.PageSize, ajaxEntity.TotleCount, ajaxEntity.PageIndex);
            }

            return strContent + "$$$$" + strPage + "$$$$" + ajaxEntity.PageIndex + "$$$$" + ajaxEntity.Extend5;
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
                case WebData.WebMenu: ajaxEntity = GetAjaxHelperForWebMenu(ajaxEntity); break;
                case WebData.WebFarmingNews: ajaxEntity = GetAjaxHelperForWebFarmingNews(ajaxEntity); break;
                case WebData.WebBeautifulVillage: ajaxEntity = GetAjaxHelperForWebBeautifulVillage(ajaxEntity); break;
                case WebData.WebLbtImage: ajaxEntity = GetAjaxHelperForWebLbtImage(ajaxEntity);  break;
                case WebData.WebBeautifulVillageImage: ajaxEntity = GetAjaxHelperForWebBeautifulVillageFlie(ajaxEntity); break;
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
                case WebData.WebMenu: strData = CreateTableForWebMenu(dt); break;
                case WebData.WebFarmingNews: strData = CreateTableForWebFarmingNews(dt); break;
                case WebData.WebBeautifulVillage: strData = CreateTableForWebBeautifulVillage(dt); break;
                case WebData.WebBeautifulVillageImage: strData = CreateTableForWebBeautifulVillageFile(dt); break;
                case WebData.WebLbtImage: strData = CreateTableForWebLbtImage(dt); break;
                default: break;
            }
            return strData;
        }

        #endregion


    }
}