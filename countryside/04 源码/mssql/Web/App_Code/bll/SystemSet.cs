using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using BusinessEntity;
using PersistenceLayer;
using System.IO;

namespace BLL.Service
{
    /// <summary>
    ///系统设置功能方法实现
    /// </summary>
    public class SystemSet : SystemBasePage
    {
        public SystemSet(string pagestatus)
        {
            PageStatus = pagestatus;
        }

        #region 更新缓存
        public string UpdataCache(AjaxHelper ajaxEntity)
        {
            #region 删除模块菜单权限缓存
            CacheHelper.Instance.Remove(CacheDTName);//删除模块菜单权限缓存
            #endregion

            #region 删除登录url地区权限缓存
            string cachename = CurrentDomainNoHttp.Replace(".", "").Replace(":", "");
            CacheHelper.Instance.Remove(cachename);

            #endregion

            #region 删除三农快讯缓存
            string farmingnewscachename = CommonMethod.GetConfigValueByKey("FNC") + "_" + CurrentCustomerID;
            CacheHelper.Instance.Remove(farmingnewscachename);

            #endregion

            #region 删除缓存文件夹
            string onefolder = CommonMethod.GetConfigValueByKey("Folder");
            HttpServerUtility hsu = HttpContext.Current.Server;
            string physicspath = hsu.MapPath("~" + onefolder); //物理路径
            DeleteFolder(physicspath);
            #endregion

           return "";
        }

        public void DeleteFolder(string physicspath)
        {
             if (Directory.Exists(physicspath))
            {
                //Directory.Delete(physicspath, true);
                foreach (string d in Directory.GetFileSystemEntries(physicspath))
                {
                    if (File.Exists(d))
                        File.Delete(d);
                    else
                        DeleteFolder(d);
                }
                //Directory.Delete(physicspath);

            }
        }
        #endregion

        #region SystemUser 用户

        #region 查询用户列表
        /// <summary>
        /// 获取系统用户的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForSystemUser(AjaxHelper ajaxEntity)
        {
            string strWhere = string.Empty;
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend1.Length > 0) strWhere += string.Format(@" and RealName like '%{0}%' ", ajaxEntity.Extend1);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and Status='{0}'  and CustomerID='{1}' ", ajaxEntity.Status, CurrentUser.CustomerID);
            else strWhere += string.Format(@"  and  Status <> 2  and CustomerID='{0}' ", CurrentUser.CustomerID);
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = "AutoID,Title,RealName,Status,CreateDate,OrderValue ";
            ajaxEntity.Table = "systemuser";
            ajaxEntity = DataHelper.SinglePaginationSearch(ajaxEntity);
            return ajaxEntity;
        }
         
        /// <summary>
        /// 系统用户列表_拼接Table
        /// </summary>
        public  string CreateTableForSystemUser(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = SystemData.DetailForUser;
                string urlRole = SystemData.DetailForAwardRole;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperRoleFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                string purviewvalueforview = GetPurviewForUrl(url, "view");
                string purviewvalueforawardrole = GetPurviewForUrl(urlRole, "");
                string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                int opertionWidth = 0;
                if (purviewvalueforedit == "1") opertionWidth += 50;
                if (purviewvalueforview == "1") opertionWidth += 50;
                if (purviewvaluefordel == "1") opertionWidth += 50;
                if (purviewvalueforawardrole == "1")
                {
                    if (opertionWidth == 0) opertionWidth += 80;
                    else if (opertionWidth == 50) opertionWidth += 70;
                    else if (opertionWidth == 100) opertionWidth += 60;
                    else if (opertionWidth == 150) opertionWidth += 50;
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
                            <col width='140px'/>
                            <col width='75px'/>
                            <col width='70px'/>
                            <col width='180px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>用户名</td>
                            <td  class='head allowRow'>姓名</td>
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
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["RealName"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemuserdetail.aspx?curId={0}&action=edit',900,450,'【系统用户】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemuserdetail.aspx?curId={0}&action=view',900,450,'【系统用户】：查看')\">查看</a>", dr["AutoID"]);
                        if (purviewvalueforawardrole == "1") strOperRoleFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('awardrole.aspx?curId={0}',500,250,'用户-【授予角色】')\">授予角色</a>", dr["AutoID"]);
                        if (purviewvaluefordel == "1") strOperDelFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"deletesinglerecord({0})\">删除</a>", dr["AutoID"]);
                        sb.AppendFormat("<td class=\"tdCenter\">{0}{1}{2}{3}&nbsp;</td>", strOperViewFunc, strOperEditFunc, strOperDelFunc, strOperRoleFunc);
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table><script type='text/javascript'>rowOutAndOver('tbList');</script>");
            }
            return sb.ToString();
        }
        #endregion

        #region 更新用户状态
        /// <summary>
        /// 改变用户状态,返回查询字符串
        /// </summary>
        public string ChangeUserStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeUserStatus(ajaxEntity);
            ajaxEntity.Action = SystemData.SystemUser;
            return GetHtmlString(ajaxEntity);
        }
      
        /// <summary>
        /// 改变用户状态 
        /// </summary>
        public void ChangeUserStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            systemuserEntity userEntity = new systemuserEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }
            
        }
        #endregion

        #region 判断系统用户名称是否存在
        public string CheckUserNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from systemuser Where Title='{0}' and  Status<>2 and CustomerID='{1}'", ajaxEntity.Title, CurrentUser.CustomerID);
            if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }
        
        #endregion

        #region 删除单个系统用户
        /// <summary>
        /// 删除单个系统用户
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForUser(AjaxHelper ajaxEntity)
        { 
            systemuserEntity obj = new systemuserEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = SystemData.SystemUser;
            return GetHtmlString(ajaxEntity);
        }
        #endregion
        
        #region 批量删除系统用户
        /// <summary>
        /// 批量删除系统用户
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForUser(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;             
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(systemuserEntity));
            uc.GetNewCondition().AddIn(systemuserEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(systemuserEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = SystemData.SystemUser;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 检查原始密码是否正确
        /// <summary>
        /// 检查原始密码是否正确
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckOriginalPwd(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            systemuserEntity objEntity = new systemuserEntity();
            objEntity.AutoID = ajaxEntity.AutoID;;
            objEntity.Retrieve();
            if (!DESEncrypt.Encrypt(ajaxEntity.Title).Equals(objEntity.UserPassword))
            {
                returnValue = "Y";
            }
            return returnValue;
        }
        #endregion

        #endregion

        #region SystemRole 角色

        #region 查询角色列表
        /// <summary>
        /// 获取系统角色的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForSystemRole(AjaxHelper ajaxEntity)
        {
            string strWhere = string.Empty;
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and Status='{0}' and CustomerID='{1}' ", ajaxEntity.Status, CurrentUser.CustomerID);
            else strWhere += string.Format("  and  Status <> 2 and CustomerID='{0}' ",CurrentUser.CustomerID);
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = "AutoID,Title,Status,CreateDate,OrderValue ";
            ajaxEntity.Table = "systemrole";
            ajaxEntity = DataHelper.SinglePaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 系统角色列表_拼接Table
        /// </summary>
        public string CreateTableForSystemRole(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = SystemData.DetailForRole;
                string urlRole = SystemData.DetailForAwardMenu;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperRoleFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                string purviewvalueforview = GetPurviewForUrl(url, "view");
                string purviewvalueforawardrole = GetPurviewForUrl(urlRole, "");
                string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                int opertionWidth = 0;
                if(purviewvalueforedit=="1") opertionWidth+=50;
                if(purviewvalueforview=="1") opertionWidth+=50;
                if (purviewvaluefordel == "1") opertionWidth += 50;
                if (purviewvalueforawardrole == "1")
                {
                    if (opertionWidth == 0) opertionWidth += 80;
                    else if (opertionWidth == 50) opertionWidth += 70;
                    else if (opertionWidth == 100) opertionWidth += 60;
                    else if (opertionWidth == 150) opertionWidth += 50;
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
                            <col width='75px'/>
                            <col width='70px'/>
                            <col width='180px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>角色名称</td> 
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
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemroledetail.aspx?curId={0}&action=edit',900,450,'【系统角色】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemroledetail.aspx?curId={0}&action=view',900,450,'【系统角色】：查看')\">查看</a>", dr["AutoID"]);
                        if (purviewvalueforawardrole == "1") strOperRoleFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('awardmenu.aspx?curId={0}',955,600,'角色-【授予资源】')\">授予资源</a>", dr["AutoID"]);
                        if (purviewvaluefordel == "1") strOperDelFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"deletesinglerecord({0})\">删除</a>", dr["AutoID"]);
                        sb.AppendFormat("<td class=\"tdCenter\">{0}{1}{2}{3}&nbsp;</td>", strOperViewFunc, strOperEditFunc, strOperDelFunc, strOperRoleFunc);
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table><script type='text/javascript'>rowOutAndOver('tbList');</script>");
            }
            return sb.ToString();
        }
        #endregion

        #region 更新角色状态
        /// <summary>
        /// 改变角色状态,返回查询字符串
        /// </summary>
        public string ChangeRoleStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeRoleStatus(ajaxEntity);
            ajaxEntity.Action = SystemData.SystemRole;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变角色状态 
        /// </summary>
        public void ChangeRoleStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            systemroleEntity userEntity = new systemroleEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 判断系统角色名称是否存在
        /// <summary>
        /// 判断系统角色名称是否存在
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckRoleNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from systemrole Where Title='{0}' and  Status<>2 and CustomerID='{1}'", ajaxEntity.Title, CurrentUser.CustomerID);
            if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }

        #endregion

        #region 删除单个角色
        /// <summary>
        /// 删除单个角色
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForRole(AjaxHelper ajaxEntity)
        {
            systemroleEntity obj = new systemroleEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = SystemData.SystemRole;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除系统角色
        /// <summary>
        /// 批量删除系统角色
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForRole(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(systemroleEntity));
            uc.GetNewCondition().AddIn(systemroleEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(systemroleEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = SystemData.SystemRole;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion

        #region SystemMenu 资源

        #region 查询资源列表
        /// <summary>
        /// 获取系统资源的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForSystemMenu(AjaxHelper ajaxEntity)
        {
            if (CurrentCustomerID == 0)
            {
                string strWhere = string.Empty;
                string strPage = string.Empty;
                string strContent = string.Empty;
                if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and Title like '%{0}%' ", ajaxEntity.Title);
                if (ajaxEntity.Extend1.Length > 0) strWhere = string.Format(@" and MenuUrl like '%{0}%' ", ajaxEntity.Extend1);
                if (ajaxEntity.Extend4.Length > 0) strWhere += string.Format(@" and TopMenuID='{0}'", ajaxEntity.Extend4);
                if (ajaxEntity.Extend3.Length > 0) strWhere += string.Format(@" and ParentId='{0}'", ajaxEntity.Extend3);
                if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and Status='{0}'", ajaxEntity.Status);
                else strWhere += string.Format("  and  Status <> 2   ");
                ajaxEntity.StrWhere = strWhere;
                ajaxEntity.Column = "AutoID,Title,MenuUrl,IsTopMenu,TopMenuid,ParentId,Status,CreateDate,OrderValue ";
                ajaxEntity.Table = "systemmenu";
                ajaxEntity = DataHelper.SinglePaginationSearch(ajaxEntity);
            }
            return ajaxEntity;
        }

        /// <summary>
        /// 系统资源列表_拼接Table
        /// </summary>
        public string CreateTableForSystemMenu(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CurrentCustomerID == 0)
                {
                    string url = SystemData.DetailForMenu;
                    string strOperEditFunc = "";
                    string strOperViewFunc = "";
                    string strOperDelFunc = "";
                    string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                    string purviewvalueforview = GetPurviewForUrl(url, "view");
                    string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                    int opertionWidth = 0;
                    if (purviewvalueforedit == "1") opertionWidth += 55;
                    if (purviewvalueforview == "1") opertionWidth += 55;
                    if (purviewvaluefordel == "1") opertionWidth += 55;
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
                            <col width='210px'/>
                            <col />
                            <col width='80px'/>
                            <col width='80px'/>
                            {0}
                    </colgroup>
                     <tr>
                            <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td class='head'>编号</td>
                            <td class='head'>资源名称</td>
                            <td class='head'>资源URL</td>
                            <td class='head'>排序值</td>
                            <td class='head'>状态</td>
                            {1}
                    </tr>", opertionColTitle, opertionTdTitle);

                    foreach (DataRow dr in dt.Rows)
                    {
                        sb.AppendFormat("<tr>");
                        sb.AppendFormat("<td><input type=\"checkbox\" name=\"ckbAllList\" value=\"{0}\" onclick=\"ckbclick()\"  /></td>", dr["AutoID"]);
                        sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["No"]);
                        sb.AppendFormat("<td title=\"{0}\">{0}</td> ", dr["Title"]);
                        string strMenuUrl = dr["MenuUrl"].ToString();
                        if (dr["IsTopMenu"].ToString().Equals("1")) strMenuUrl = "顶级菜单";
                        else if (dr["ParentId"].ToString().Equals("0")) strMenuUrl = "一级菜单";
                        sb.AppendFormat("<td title=\"{0}\">{0}</td> ", strMenuUrl);
                        sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                        sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                        if (opertionWidth > 0)
                        {
                            if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemmenudetail.aspx?curId={0}&action=edit',920,460,'【系统资源】：修改')\">修改</a>", dr["AutoID"]);
                            if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemmenudetail.aspx?curId={0}&action=view',920,460,'【系统资源】：查看')\">查看</a>", dr["AutoID"]);
                            if (purviewvaluefordel == "1") strOperDelFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"deletesinglerecord({0})\">删除</a>", dr["AutoID"]);
                            sb.AppendFormat("<td class=\"tdCenter\">{0}{1}{2}&nbsp;</td>", strOperViewFunc, strOperEditFunc, strOperDelFunc);
                        }
                        sb.Append("</tr>");
                    }
                    sb.Append("</table><script type='text/javascript'>rowOutAndOver('tbList');</script>");
                }
            }
            return sb.ToString();
        }

         #endregion

        #region 更新资源状态
        /// <summary>
        /// 改变资源状态,返回查询字符串
        /// </summary>
        public string ChangeMenuStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeMenuStatus(ajaxEntity);
            ajaxEntity.Action = SystemData.SystemMenu;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变资源状态 
        /// </summary>
        public void ChangeMenuStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            systemmenuEntity objEntity = new systemmenuEntity();
            objEntity.AutoID = ajaxEntity.AutoID;
            objEntity.Retrieve();
            if (objEntity.IsPersistent)
            {
                objEntity.Status = Convert.ToByte(iUpdataStatus);
                objEntity.Save();
            }

        }
        #endregion

        #region 判断系统资源名称是否存在
        /// <summary>
        /// 判断系统资源名称是否存在
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckMenuNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from systemmenu Where Title='{0}' and  Status<>2 and CustomerID='{1}'", ajaxEntity.Title, CurrentUser.CustomerID);
            if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }

        #endregion

        #region 获取系统资源的一级菜单
        /// <summary>
        /// 获取系统资源的一级菜单
        /// </summary>
        /// <param name="topMenuId">所属顶级菜单ID</param>
        public string ChangeTopMenu(AjaxHelper ajaxEntity)
        {
            string strSql = string.Format("select AutoID,Title from systemmenu  where status <> 2 and IsTopMenu=0 and TopMenuID='{0}' and ParentId=0   order by OrderValue desc,AutoID desc  ", ajaxEntity.Title);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            StringBuilder sb = new StringBuilder();
            sb.Append("<option value=''>请选择</option>");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.AppendFormat("<option value='{0}'>{1}</option>", dt.Rows[i]["AutoID"], dt.Rows[i]["Title"]);
            }
            return sb.ToString();
        }

        #endregion

        #region 删除单个系统资源
        /// <summary>
        /// 删除单个系统资源
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForMenu(AjaxHelper ajaxEntity)
        {
            systemmenuEntity obj = new systemmenuEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = SystemData.SystemMenu;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除系统资源
        /// <summary>
        /// 批量删除系统资源
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForMenu(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(systemmenuEntity));
            uc.GetNewCondition().AddIn(systemmenuEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(systemmenuEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = SystemData.SystemMenu;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion

        #region 授予资源
        /// <summary>
        /// 授予资源
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string AwardMenu(AjaxHelper ajaxEntity)
        {
            string menuID = ajaxEntity.Extend1;
            string roleID = ajaxEntity.Extend2;
            string menuType = ajaxEntity.Extend3;
            string permission = ajaxEntity.Extend4;
            string strColumnvalue = ""; 
            string strSql = string.Format("select count(*) from system_role_menu where RoleID='{1}' and MenuID='{0}' and CustomerID='{2}'", menuID, roleID,CurrentUser.CustomerID);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            bool isInsert = true;
            if (dt != null && dt.Rows.Count > 0)
            {
                if(dt.Rows[0][0].ToInt(0)>0) isInsert = false;
            }
            switch (menuType)
            {
                case "IsPurview": strColumnvalue = "IsPurview"; break;
                case "IsShowMenu": strColumnvalue = "IsShowMenu"; break;
                case "IsView": strColumnvalue = "IsView"; break;
                case "IsAdd": strColumnvalue = "IsAdd"; break;
                case "IsEdit": strColumnvalue = "IsEdit"; break;
                case "IsDelete": strColumnvalue = "IsDelete"; break;
            }
            DateTime dtNow = DateTime.Now;
            string execStrSql = "";
            if (isInsert)
            {
                execStrSql = string.Format("insert into system_role_menu  (RoleID,MenuID,CustomerID,{6},CreatorID,CreateDate,Modifier,ModifyDate) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{4}','{5}')", roleID, menuID, CurrentUser.CustomerID, permission, CurrentUser.AutoID, dtNow, strColumnvalue);
            }
            else
            {
                execStrSql = string.Format("update system_role_menu  set {0}='{1}',Modifier='{5}',ModifyDate='{6}' where RoleID='{2}' and MenuID='{3}' and CustomerID='{4}' ", strColumnvalue, permission, roleID, menuID, CurrentUser.CustomerID, CurrentUser.AutoID, dtNow);
            }
            int iCount = Query.ProcessSqlNonQuery(execStrSql, DataHelper.DataBase);
            string returnValue = "0";
            if (iCount > 0)
            {
                returnValue = "1";
                string cachedtname = CommonMethod.GetConfigValueByKey("DTC") + "_" + roleID;
                CacheHelper.Instance.Remove(cachedtname);
                //OperateTxt.DelPurviewFilePath(CurrentCustomerID);
                string purviewcahce = CommonMethod.GetConfigValueByKey("DTC"); 
                OperateTxt.DelPurviewFile(CurrentCustomerID, roleID.ToInt(),purviewcahce); //删除缓存文件
            }
            return returnValue;
        }
        #endregion 

        #region 基础信息设置

        #region 新增/修改登陆系统标题
        /// <summary>
        /// 新增/修改登陆系统标题
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SetLoginTitle(AjaxHelper ajaxEntity)
        {
            string returnvalue = "Y";
            try
            {
                OperateXml xml = new OperateXml();
                xml.AddbaseconfigFile(CurrentCustomerID.ToString(), SystemData.BaseInfo_LoginTitle, ajaxEntity.Title);
                CacheHelper.Instance.Remove(ConfigLoginTitle);
            }
            catch
            {
                returnvalue = "N";
            }
            return returnvalue;

        }

        #endregion

        #region 查询登陆系统标题
        /// <summary>
        /// 查询登陆系统标题
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SelectLoginTitle(AjaxHelper ajaxEntity)
        {
            OperateXml xml = new OperateXml();
            string returnvalue = xml.SelectbaseconfigFile(CurrentCustomerID.ToString(), SystemData.BaseInfo_LoginTitle);
            return returnvalue;
        }

        #endregion

        #region 新增/修改网站标题
        /// <summary>
        /// 新增/修改网站标题
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SetWebTitle(AjaxHelper ajaxEntity)
        {
            string returnvalue = "Y";
            try
            {
                OperateXml xml = new OperateXml();
                xml.AddbaseconfigFile(CurrentCustomerID.ToString(), SystemData.BaseInfo_WebTitle, ajaxEntity.Title);
                CacheHelper.Instance.Remove(ConfigWebTitle);
            }
            catch
            {
                returnvalue = "N";
            }
            return returnvalue;

        }

        #endregion

        #region 查询网站标题
        /// <summary>
        /// 查询网站标题
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SelectWebTitle(AjaxHelper ajaxEntity)
        {
            OperateXml xml = new OperateXml();
            string returnvalue = xml.SelectbaseconfigFile(CurrentCustomerID.ToString(), SystemData.BaseInfo_WebTitle);
            return returnvalue;
        }

        #endregion

        #endregion

        #region SystemCusetomer 客户

        #region 查询客户列表
        /// <summary>
        /// 获取系统客户的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForSystemCustomer(AjaxHelper ajaxEntity)
        {
            string strWhere = string.Empty;
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend1.Length > 0) strWhere += string.Format(@" and LinkMan like '%{0}%' ", ajaxEntity.Extend1);

            if (ajaxEntity.Extend2.Length > 0)
            {
                string openstatus = "and OpenStatus='1'";
                if (ajaxEntity.Extend2 == "0")
                {
                    openstatus = " and (OpenStatus='0' or OpenStatus='2')";
                }
                strWhere += string.Format(@" {0}", openstatus);

            }
            //if (ajaxEntity.Extend2.Length > 0) strWhere += string.Format(@" and OpenStatus='{0}'", ajaxEntity.Extend2);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and Status='{0}'", ajaxEntity.Status);
            else strWhere += string.Format(@"  and  Status <> 2    ");
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = "AutoID,Title,LinkMan,Phone,Status,OpenStatus,CreateDate,OrderValue ";
            ajaxEntity.Table = "systemcustomer";
            ajaxEntity = DataHelper.SinglePaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 系统客户列表_拼接Table
        /// </summary>
        public string CreateTableForSystemCustomer(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = SystemData.DetailForCustomer;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                int opertionWidth = 0;
                string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                if (purviewvalueforedit == "1") opertionWidth += 50;
                string purviewvalueforview = GetPurviewForUrl(url, "view");
                if (purviewvalueforview == "1") opertionWidth += 50;
                string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                if (purviewvaluefordel == "1") opertionWidth += 50;

                string opertionColTitle = "";
                string opertionTdTitle = "";
                if (opertionWidth > 0)
                {
                    opertionColTitle = string.Format("<col width='{0}px' />", opertionWidth + 70);
                    opertionTdTitle = "<td class='head'>操作</td>";
                }
                sb.AppendFormat(@"<table class='showList' id='tbList' >
                     <colgroup>
                            <col width='20px'/>
                            <col width='50px'/>
                            <col />
                            <col width='100px'/>
                            <col width='140px'/>
                            <col width='75px'/>
                            <col width='70px'/>
                            <col width='175px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>客户名称</td>
                            <td  class='head allowRow'>联系人</td>
                            <td  class='head allowRow'>联系电话</td>
                            <td  class='head'>排序值</td>
                            <td  class='head'>状态</td>
                            <td  class='head'>创建日期</td>
                            {1}
                    </tr>", opertionColTitle, opertionTdTitle);

                foreach (DataRow dr in dt.Rows)
                {
                    string title = dr["Title"].ToString();
                    sb.AppendFormat("<tr>");
                    sb.AppendFormat("<td><input type=\"checkbox\" name=\"ckbAllList\" value=\"{0}\" onclick=\"ckbclick()\"  /></td>", dr["AutoID"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["No"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", title);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["LinkMan"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["Phone"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemcustomerdetail.aspx?curId={0}&action=edit',900,450,'【系统客户】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemcustomerdetail.aspx?curId={0}&action=view',900,450,'【系统客户】：查看')\">查看</a>", dr["AutoID"]);
                        if (purviewvaluefordel == "1") strOperDelFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"deletesinglerecord({0})\">删除</a>", dr["AutoID"]);
                        int openStatusId = dr["OpenStatus"].ToInt();

                        string cusname = Server.UrlEncode(title);
                        string purviewTitle = "开通权限";
                        if (openStatusId == 1) purviewTitle = "关闭权限";
                        string strOpenStatus = string.Format("editoperation('systemcustomerpurview.aspx?curId={0}&opId={1}&cusn={2}',400,200,'【{3}】')", dr["AutoID"], openStatusId, cusname, purviewTitle);
                        string purviewstatus = string.Format("&nbsp;<a href=\"###\" onclick=\"{0}\">{1}</a>", strOpenStatus, purviewTitle);
                        //string openStatus = string.Format("editoperation('systemcustomerpurview.aspx?curId={0}&opId={1}&cusn={2}',400,200,'【开通权限】')", dr["AutoID"], openStatusId,cusname);
                        //string strOpenStatus = string.Format("editoperation('systemcustomerpurview.aspx?curId={0}&opId={1}&cusn={2}',400,200,'【开通权限】')", dr["AutoID"], openStatusId, cusname);

                        //if (openStatusId == 1)
                        //{
                        //strOpenStatus = string.Format("editoperation('systemcustomerpurview.aspx?curId={0}&opId={1}&cusn={2}',400,200,'【关闭权限】')", dr["AutoID"], openStatusId, cusname);
                        //strOpenStatus = string.Format("&nbsp;<a href=\"###\" onclick=\"closepriview({0})\">关闭权限</a>", dr["AutoID"]);
                        //}
                        sb.AppendFormat("<td class=\"tdCenter\">{0}{1}{2}{3}&nbsp;</td>", strOperViewFunc, strOperEditFunc, strOperDelFunc, purviewstatus);
                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table><script type='text/javascript'>rowOutAndOver('tbList');</script>");
            }
            return sb.ToString();
        }
        #endregion

        #region 更新客户状态
        /// <summary>
        /// 改变客户状态,返回查询字符串
        /// </summary>
        public string ChangeCustomerStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeCustomerStatus(ajaxEntity);
            ajaxEntity.Action = SystemData.SystemCustomer;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变客户状态 
        /// </summary>
        public void ChangeCustomerStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            systemcustomerEntity userEntity = new systemcustomerEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 判断系统客户名称是否存在
        /// <summary>
        /// 判断系统客户名称是否存在
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckCustomerNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from systemcustomer Where Title='{0}' and  Status<>2 ", ajaxEntity.Title);
            if (curId != -1) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }

        #endregion

        #region 删除单个系统客户
        /// <summary>
        /// 删除单个系统客户
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForCustomer(AjaxHelper ajaxEntity)
        {
            systemcustomerEntity obj = new systemcustomerEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = SystemData.SystemCustomer;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除系统客户
        /// <summary>
        /// 批量删除系统客户
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForCustomer(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(systemcustomerEntity));
            uc.GetNewCondition().AddIn(systemcustomerEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(systemcustomerEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = SystemData.SystemCustomer;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion

        #region SystemDomain 域名

        #region 查询域名列表
        /// <summary>
        /// 获取系统域名的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForSystemDomain(AjaxHelper ajaxEntity)
        {
            string strWhere = string.Empty;
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and Status='{0}'", ajaxEntity.Status);
            else strWhere += string.Format(@"  and  Status <> 2    ");
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = "AutoID,Title,Status,CreateDate,OrderValue ";
            ajaxEntity.Table = "systemdomain";
            ajaxEntity = DataHelper.SinglePaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 系统域名列表_拼接Table
        /// </summary>
        public string CreateTableForSystemDomain(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = SystemData.DetailForDomain;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                int opertionWidth = 0;
                string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                if (purviewvalueforedit == "1") opertionWidth += 50;
                string purviewvalueforview = GetPurviewForUrl(url, "view");
                if (purviewvalueforview == "1") opertionWidth += 50;
                string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                if (purviewvaluefordel == "1") opertionWidth += 50;

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
                            <col width='140px'/>
                            <col width='140px'/>
                            <col width='180px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>域名名称</td>
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
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    //sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToDomainStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", CommonMethod.ConvertToDomainStatus(dr["Status"].ToString()));

                    
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemdomaindetail.aspx?curId={0}&action=edit',600,280,'【系统域名】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemdomaindetail.aspx?curId={0}&action=view',600,280,'【系统域名】：查看')\">查看</a>", dr["AutoID"]);
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

        #region 更新域名状态
        /// <summary>
        /// 改变域名状态,返回查询字符串
        /// </summary>
        public string ChangeDomainStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeDomainStatus(ajaxEntity);
            ajaxEntity.Action = SystemData.SystemDomain;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变域名状态 
        /// </summary>
        public void ChangeDomainStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            systemdomainEntity userEntity = new systemdomainEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 判断系统域名名称是否存在
        /// <summary>
        /// 判断系统域名名称是否存在
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckDomainNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from systemdomain Where Title='{0}' and  Status<>2 ", ajaxEntity.Title);
            if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }

        #endregion

        #region 删除单个系统域名
        /// <summary>
        /// 删除单个系统域名
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForDomain(AjaxHelper ajaxEntity)
        {
            systemdomainEntity obj = new systemdomainEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = SystemData.SystemDomain;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除系统域名
        /// <summary>
        /// 批量删除系统域名
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForDomain(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(systemdomainEntity));
            uc.GetNewCondition().AddIn(systemdomainEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(systemdomainEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = SystemData.SystemDomain;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion

        #region CustomerDomain 绑定客户域名

        #region 查询绑定客户域名
        /// <summary>
        /// 获取绑定客户域名的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForCustomerDomain(AjaxHelper ajaxEntity)
        {
            string strWhere = "";
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and c.Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend1.Length > 0) strWhere += string.Format(@" and d.Title like '%{0}%' ", ajaxEntity.Extend1);
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = @" h.AutoID, c.Title CustomerTitle, d.Title DomainTitle ";
            ajaxEntity.Table = " system_customer_domain h ";
            ajaxEntity.Table2 = @" left join  systemcustomer c  ON h.CustomerID=c.AutoID
                                 left join  systemdomain d  ON h.DomainID=d.AutoID ";
            ajaxEntity.StrOrderBy = "  order by  h.AutoID asc "; 
            ajaxEntity = DataHelper.MultiPaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 绑定客户域名列表_拼接Table
        /// </summary>
        public string CreateTableForCustomerDomain(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = SystemData.DetailForCustomerDomain;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                int opertionWidth = 0;
                string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                if (purviewvalueforedit == "1") opertionWidth += 50;
                string purviewvalueforview = GetPurviewForUrl(url, "view");
                if (purviewvalueforview == "1") opertionWidth += 50;
                string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                if (purviewvaluefordel == "1") opertionWidth += 50;
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
                            <col width='260px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>客户名称</td>
                            <td  class='head allowRow'>域名名称</td>
                            {1}
                    </tr>", opertionColTitle, opertionTdTitle);

                foreach (DataRow dr in dt.Rows)
                {
                    sb.AppendFormat("<tr>");
                    sb.AppendFormat("<td><input type=\"checkbox\" name=\"ckbAllList\" value=\"{0}\" onclick=\"ckbclick()\"  /></td>", dr["AutoID"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["No"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["CustomerTitle"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["DomainTitle"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemdomainbinddetail.aspx?curId={0}&action=edit',400,200,'【绑定客户域名】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('systemdomainbinddetail.aspx?curId={0}&action=view',400,150,'【绑定客户域名】：查看')\">查看</a>", dr["AutoID"]);
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

        #region 删除单个绑定客户域名
        /// <summary>
        /// 删除单个绑定客户域名
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForCustomerDomain(AjaxHelper ajaxEntity)
        {
            int iDomainID = -1;
            int iCustomerID=-1;
            system_customer_domainEntity obj = new system_customer_domainEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                iDomainID = obj.DomainID;
                iCustomerID = obj.CustomerID;
                obj.Delete();
            }
            systemdomainEntity sdobj = new systemdomainEntity();
            sdobj.AutoID = iDomainID;
            sdobj.Retrieve();
            if (sdobj.IsPersistent)
            {
                sdobj.Status = 0;
                sdobj.Save();
            }

            int icount=0;
            string strSql = string.Format(@"select count(*) from system_customer_domain cd
                                            where cd.customerid={0} and cd.domainid<>{1}", iCustomerID, iDomainID);
            DataTable dtcount = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dtcount != null && dtcount.Rows.Count > 0)
            {
                icount = dtcount.Rows[0][0].ToInt(0);
            }
            if (icount == 0)
            {
                systemcustomerEntity scobj = new systemcustomerEntity();
                scobj.AutoID = iCustomerID;
                scobj.Retrieve();
                if (sdobj.IsPersistent)
                {
                    scobj.OpenStatus = 2;
                    scobj.Save();
                }
            }
            ajaxEntity.Action = SystemData.SystemCustomerDomain;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除绑定客户域名
        ///// <summary>
        ///// 批量删除绑定客户域名
        ///// </summary>
        ///// <param name="ajaxEntity"></param>
        ///// <returns></returns>
        //public string BatchDeleteForCustomerDomain(AjaxHelper ajaxEntity)
        //{
        //    string delId = ajaxEntity.Extend2;
        //    object[] list = delId.Split(new char[] { '_' });
        //    DeleteCriteria uc = new DeleteCriteria(typeof(system_customer_domainEntity));
        //    uc.GetNewCondition().AddIn(system_customer_domainEntity.Columns.AutoID, list);
        //    int mun = uc.Perform();
        //    ajaxEntity.Extend5 = mun.ToString();
        //    ajaxEntity.Action = DataSetHelper.SystemCustomerDomain;
        //    return GetHtmlString(ajaxEntity);
        //}
        #endregion


        #endregion

        #region 省设置

        #region 查询省列表
        /// <summary>
        /// 获取省的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForProvince(AjaxHelper ajaxEntity)
        {
            string strWhere = string.Empty;
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and Status='{0}'", ajaxEntity.Status);
            else strWhere += string.Format("  and  Status <> 2 ");
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = "AutoID,Title,Status,CreateDate,OrderValue ";
            ajaxEntity.Table = "areaprovince";
            ajaxEntity = DataHelper.SinglePaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 省列表_拼接Table
        /// </summary>
        public string CreateTableForProvince(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = SystemData.DetailForProvince;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                string purviewvalueforview = GetPurviewForUrl(url, "view");               
                string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                int opertionWidth = 0;
                if (purviewvalueforedit == "1") opertionWidth += 50;
                if (purviewvalueforview == "1") opertionWidth += 50;
                if (purviewvaluefordel == "1") opertionWidth += 50;
               
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
                            <col width='75px'/>
                            <col width='70px'/>
                            <col width='180px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>省、直辖市名称</td> 
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
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('areaprovincesetdetail.aspx?curId={0}&action=edit',900,450,'【省、直辖市】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('areaprovincesetdetail.aspx?curId={0}&action=view',900,450,'【省、直辖市】：查看')\">查看</a>", dr["AutoID"]);
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

        #region 更新省状态
        /// <summary>
        /// 改变省状态,返回查询字符串
        /// </summary>
        public string ChangeProvinceStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeProvinceStatus(ajaxEntity);
            ajaxEntity.Action = SystemData.AreaProvince;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变省状态 
        /// </summary>
        public void ChangeProvinceStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            areaprovinceEntity userEntity = new areaprovinceEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 判断省名称是否存在
        /// <summary>
        /// 判断省名称是否存在
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckProvinceNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from areaprovince Where Title='{0}' and  Status<>2 ", ajaxEntity.Title);
            if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }

        #endregion

        #region 删除单个省
        /// <summary>
        /// 删除单个省
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForProvince(AjaxHelper ajaxEntity)
        {
            areaprovinceEntity obj = new areaprovinceEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = SystemData.AreaProvince;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除省
        /// <summary>
        /// 批量删除省
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForProvince(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(areaprovinceEntity));
            uc.GetNewCondition().AddIn(areaprovinceEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(areaprovinceEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = SystemData.AreaProvince;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion

        #region 城市设置

        #region 查询城市列表
        /// <summary>
        /// 获取城市的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForCity(AjaxHelper ajaxEntity)
        {
            string strWhere = " where 1=1 ";
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and h.Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend1.Length > 0) strWhere += string.Format(@" and h.ProvinceID='{0}'", ajaxEntity.Extend1);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and h.Status='{0}'", ajaxEntity.Status);
            else strWhere += string.Format("  and  h.Status <> 2 ");
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = "h.AutoID,h.Title,h.Status,h.CreateDate,h.OrderValue,p.title provincetitle ";
            ajaxEntity.Table = " areacity h ";
            ajaxEntity.Table2 = "inner join areaprovince p on h.ProvinceID=p.AutoID ";
            ajaxEntity.StrOrderBy = "  order by  h.AutoID asc ";
            ajaxEntity = DataHelper.MultiPaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 城市列表_拼接Table
        /// </summary>
        public string CreateTableForCity(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = SystemData.DetailForCity;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                string purviewvalueforview = GetPurviewForUrl(url, "view");
                string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                int opertionWidth = 0;
                if (purviewvalueforedit == "1") opertionWidth += 50;
                if (purviewvalueforview == "1") opertionWidth += 50;
                if (purviewvaluefordel == "1") opertionWidth += 50;

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
                            <col width='150px'/>
                            <col width='75px'/>
                            <col width='70px'/>
                            <col width='180px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>城市名称</td> 
                            <td  class='head allowRow'>所属省、直辖市</td>
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
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["provincetitle"]);                    
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('areacitysetdetail.aspx?curId={0}&action=edit',900,450,'【城市设置】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('areacitysetdetail.aspx?curId={0}&action=view',900,450,'【城市设置】：查看')\">查看</a>", dr["AutoID"]);
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

        #region 更新城市状态
        /// <summary>
        /// 改变城市状态,返回查询字符串
        /// </summary>
        public string ChangeCityStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeCityStatus(ajaxEntity);
            ajaxEntity.Action = SystemData.AreaCity;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变城市状态 
        /// </summary>
        public void ChangeCityStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            areacityEntity userEntity = new areacityEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 判断城市名称是否存在
        /// <summary>
        /// 判断城市名称是否存在
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckCityNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from areacity Where Title='{0}'and ProvinceID='{1}' and  Status<>2 ", ajaxEntity.Title, ajaxEntity.Extend1);
            if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }

        #endregion

        #region 删除单个城市
        /// <summary>
        /// 删除单个城市
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForCity(AjaxHelper ajaxEntity)
        {
            areacityEntity obj = new areacityEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = SystemData.AreaCity;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除城市
        /// <summary>
        /// 批量删除城市
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForCity(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(areacityEntity));
            uc.GetNewCondition().AddIn(areacityEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(areacityEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = SystemData.AreaCity;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion

        #region 县、区设置

        #region 查询县、区列表
        /// <summary>
        /// 获取县、区的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForCounty(AjaxHelper ajaxEntity)
        {
            string strWhere = " where 1=1 ";
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and h.Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend1.Length > 0) strWhere += string.Format(@" and h.ProvinceID='{0}'", ajaxEntity.Extend1);
            if (ajaxEntity.Extend3.Length > 0) strWhere += string.Format(@" and h.CityID='{0}'", ajaxEntity.Extend3);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and h.Status='{0}'", ajaxEntity.Status);
            else strWhere += string.Format("  and  h.Status <> 2 ");
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = "h.AutoID,h.Title,h.Status,h.CreateDate,h.OrderValue,p.title provincetitle,c.title citytitle ";
            ajaxEntity.Table = " areacounty h ";
            ajaxEntity.Table2 = @"inner join areaprovince p on h.ProvinceID=p.AutoID
                                  inner join areacity c on h.CityID=c.AutoID ";
            ajaxEntity.StrOrderBy = "  order by  h.AutoID asc ";
            ajaxEntity = DataHelper.MultiPaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 县、区列表_拼接Table
        /// </summary>
        public string CreateTableForCounty(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = SystemData.DetailForCounty;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                string purviewvalueforview = GetPurviewForUrl(url, "view");
                string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                int opertionWidth = 0;
                if (purviewvalueforedit == "1") opertionWidth += 50;
                if (purviewvalueforview == "1") opertionWidth += 50;
                if (purviewvaluefordel == "1") opertionWidth += 50;

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
                            <col width='150px'/>
                            <col width='150px'/>
                            <col width='75px'/>
                            <col width='70px'/>
                            <col width='180px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>县、区名称</td> 
                            <td  class='head allowRow'>所属省、直辖市</td>
                            <td  class='head allowRow'>所属城市</td>
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
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["provincetitle"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["citytitle"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('areacountysetdetail.aspx?curId={0}&action=edit',900,450,'【县、区设置】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('areacountysetdetail.aspx?curId={0}&action=view',900,450,'【县、区设置】：查看')\">查看</a>", dr["AutoID"]);
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

        #region 更新县、区状态
        /// <summary>
        /// 改变县、区状态,返回查询字符串
        /// </summary>
        public string ChangeCountyStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeCountyStatus(ajaxEntity);
            ajaxEntity.Action = SystemData.AreaCounty;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变县、区状态 
        /// </summary>
        public void ChangeCountyStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            areacountyEntity userEntity = new areacountyEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 判断县、区名称是否存在
        /// <summary>
        /// 判断县、区名称是否存在
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckCountyNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from areacounty Where Title='{0}' and ProvinceID='{1}'  and CityID='{2}'  and  Status<>2 ", ajaxEntity.Title, ajaxEntity.Extend1, ajaxEntity.Extend3);
            if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }

        #endregion

        #region 删除单个县、区
        /// <summary>
        /// 删除单个县、区
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForCounty(AjaxHelper ajaxEntity)
        {
            areacountyEntity obj = new areacountyEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = SystemData.AreaCounty;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除县、区
        /// <summary>
        /// 批量删除县、区
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForCounty(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(areacountyEntity));
            uc.GetNewCondition().AddIn(areacountyEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(areacountyEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = SystemData.AreaCounty;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion

        #region 乡镇设置

        #region 查询乡镇列表
        /// <summary>
        /// 获取乡镇的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForTown(AjaxHelper ajaxEntity)
        {
            string strWhere = " where 1=1 ";
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and h.Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend1.Length > 0) strWhere += string.Format(@" and h.ProvinceID='{0}'", ajaxEntity.Extend1);
            if (ajaxEntity.Extend3.Length > 0) strWhere += string.Format(@" and h.CityID='{0}'", ajaxEntity.Extend3);
            if (ajaxEntity.Extend4.Length > 0) strWhere += string.Format(@" and h.CountyID='{0}'", ajaxEntity.Extend4);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and h.Status='{0}'", ajaxEntity.Status);
            else strWhere += string.Format("  and  h.Status <> 2 ");
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = "h.AutoID,h.Title,h.Status,h.CreateDate,h.OrderValue,p.title provincetitle,c.title citytitle,o.title countytitle";
            ajaxEntity.Table = " areatown h ";
            ajaxEntity.Table2 = @"inner join areaprovince p on h.ProvinceID=p.AutoID
                                  inner join areacity c on h.CityID=c.AutoID  
                                  inner join areacounty o on h.CountyID=o.AutoID ";
            ajaxEntity.StrOrderBy = "  order by  h.AutoID asc ";
            ajaxEntity = DataHelper.MultiPaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 乡镇列表_拼接Table
        /// </summary>
        public string CreateTableForTown(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = SystemData.DetailForTown;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                string purviewvalueforview = GetPurviewForUrl(url, "view");
                string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                int opertionWidth = 0;
                if (purviewvalueforedit == "1") opertionWidth += 50;
                if (purviewvalueforview == "1") opertionWidth += 50;
                if (purviewvaluefordel == "1") opertionWidth += 50;

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
                            <col width='145px'/>
                            <col width='145px'/>
                            <col width='90px'/>
                            <col width='73px'/>
                            <col width='65px'/>
                            <col width='180px'/>
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>乡镇名称</td> 
                            <td  class='head allowRow'>所属省、直辖市</td>
                            <td  class='head allowRow'>所属城市</td>
                            <td  class='head allowRow'>所属县、区</td>
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
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["provincetitle"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["citytitle"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["countytitle"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["CreateDate"]);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('areatownsetdetail.aspx?curId={0}&action=edit',900,450,'【乡镇设置】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('areatownsetdetail.aspx?curId={0}&action=view',900,450,'【乡镇设置】：查看')\">查看</a>", dr["AutoID"]);
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

        #region 更新乡镇状态
        /// <summary>
        /// 改变乡镇状态,返回查询字符串
        /// </summary>
        public string ChangeTownStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeTownStatus(ajaxEntity);
            ajaxEntity.Action = SystemData.AreaTown;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变乡镇状态 
        /// </summary>
        public void ChangeTownStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            areatownEntity userEntity = new areatownEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 判断乡镇名称是否存在
        /// <summary>
        /// 判断乡镇名称是否存在
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckTownNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from areatown Where Title='{0}' and ProvinceID='{1}'  and CityID='{2}'  and CountyID='{3}' and  Status<>2 ", ajaxEntity.Title, ajaxEntity.Extend1, ajaxEntity.Extend3, ajaxEntity.Extend4);
            if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }

        #endregion

        #region 删除单个乡镇
        /// <summary>
        /// 删除单个乡镇
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForTown(AjaxHelper ajaxEntity)
        {
            areatownEntity obj = new areatownEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = SystemData.AreaTown;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除乡镇
        /// <summary>
        /// 批量删除乡镇
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForTown(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(areatownEntity));
            uc.GetNewCondition().AddIn(areatownEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(areatownEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = SystemData.AreaTown;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion

        #region 乡村设置

        #region 查询乡村列表
        /// <summary>
        /// 获取乡村的Ajax实体
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public AjaxHelper GetAjaxHelperForVillage(AjaxHelper ajaxEntity)
        {
            string strWhere =" where 1=1 ";
            string strPage = string.Empty;
            string strContent = string.Empty;
            if (ajaxEntity.Title.Length > 0) strWhere = string.Format(@" and h.Title like '%{0}%' ", ajaxEntity.Title);
            if (ajaxEntity.Extend1.Length > 0) strWhere += string.Format(@" and h.ProvinceID='{0}'", ajaxEntity.Extend1);
            if (ajaxEntity.Extend3.Length > 0) strWhere += string.Format(@" and h.CityID='{0}'", ajaxEntity.Extend3);
            if (ajaxEntity.Extend4.Length > 0) strWhere += string.Format(@" and h.CountyID='{0}'", ajaxEntity.Extend4);
            if (ajaxEntity.Extend5.Length > 0) strWhere += string.Format(@" and h.TownD='{0}'", ajaxEntity.Extend5);
            if (ajaxEntity.Status.Length > 0) strWhere += string.Format(@" and h.Status='{0}'", ajaxEntity.Status);
            else strWhere += string.Format("  and  h.Status <> 2 ");
            ajaxEntity.StrWhere = strWhere;
            ajaxEntity.Column = "h.AutoID,h.Title,h.Status, h.OrderValue,p.title provincetitle,c.title citytitle,o.title countytitle,t.title towntitle";
            ajaxEntity.Table = " areavillage h ";
            ajaxEntity.Table2 = @"inner join areaprovince p on h.ProvinceID=p.AutoID
                                  inner join areacity c on h.CityID=c.AutoID  
                                  inner join areacounty o on h.CountyID=o.AutoID 
                                  inner join areatown t on h.TownID=t.AutoID ";
            ajaxEntity.StrOrderBy = "  order by  h.AutoID asc ";
            ajaxEntity = DataHelper.MultiPaginationSearch(ajaxEntity);
            return ajaxEntity;
        }

        /// <summary>
        /// 乡村列表_拼接Table
        /// </summary>
        public string CreateTableForVillage(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                string url = SystemData.DetailForVillage
                    ;
                string strOperEditFunc = "";
                string strOperViewFunc = "";
                string strOperDelFunc = "";
                string purviewvalueforedit = GetPurviewForUrl(url, "edit");
                string purviewvalueforview = GetPurviewForUrl(url, "view");
                string purviewvaluefordel = GetPurviewForUrl(url, "delete");
                int opertionWidth = 0;
                if (purviewvalueforedit == "1") opertionWidth += 50;
                if (purviewvalueforview == "1") opertionWidth += 50;
                if (purviewvaluefordel == "1") opertionWidth += 50;

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
                            <col width='145px'/>
                            <col width='145px'/>
                            <col width='90px'/>
                            <col width='90px'/>
                            <col width='73px'/>
                            <col width='65px'/> 
                            {0}
                    </colgroup>
                     <tr>   <td  class='head'><input type='checkbox' id='ckbAll' title='全选' onclick='allckbclick(this)' /></td>
                            <td  class='head'>编号</td>
                            <td  class='head allowRow'>乡村名称</td> 
                            <td  class='head allowRow'>所属省、直辖市</td>
                            <td  class='head allowRow'>所属城市</td>
                            <td  class='head allowRow'>所属县、区</td>
                            <td  class='head allowRow'>所属乡镇</td>
                            <td  class='head'>排序值</td>
                            <td  class='head'>状态</td>
                           
                            {1}
                    </tr>", opertionColTitle, opertionTdTitle);

                foreach (DataRow dr in dt.Rows)
                {
                    sb.AppendFormat("<tr>");
                    sb.AppendFormat("<td><input type=\"checkbox\" name=\"ckbAllList\" value=\"{0}\" onclick=\"ckbclick()\"  /></td>", dr["AutoID"]);
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["No"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["Title"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["provincetitle"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["citytitle"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["countytitle"]);
                    sb.AppendFormat("<td class=\"tdCenter allowRow\">{0}</td>", dr["towntitle"]); 
                    sb.AppendFormat("<td class=\"tdCenter\">{0}</td>", dr["Ordervalue"]);
                    sb.AppendFormat("<td class=\"tdCenter\"><a href=\"###\" onclick=\"changestate('{1}','{2}','{3}')\">{0}</a></td>", CommonMethod.ConvertToStatus(dr["Status"].ToString()), dr["AutoID"], dr["Status"], CurrentUserID);
                    if (opertionWidth > 0)
                    {
                        if (purviewvalueforedit == "1") strOperEditFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('areavillagesetdetail.aspx?curId={0}&action=edit',900,450,'【乡村设置】：修改')\">修改</a>", dr["AutoID"]);
                        if (purviewvalueforview == "1") strOperViewFunc = string.Format("&nbsp;<a href=\"###\" onclick=\"editoperation('areavillagesetdetail.aspx?curId={0}&action=view',900,450,'【乡村设置】：查看')\">查看</a>", dr["AutoID"]);
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

        #region 更新乡村状态
        /// <summary>
        /// 改变乡村状态,返回查询字符串
        /// </summary>
        public string ChangeVillageStatusAndSearchList(AjaxHelper ajaxEntity)
        {
            ChangeVillageStatus(ajaxEntity);
            ajaxEntity.Action = SystemData.AreaVillage;
            return GetHtmlString(ajaxEntity);
        }

        /// <summary>
        /// 改变乡村状态 
        /// </summary>
        public void ChangeVillageStatus(AjaxHelper ajaxEntity)
        {
            int iUpdataStatus = ajaxEntity.Extend2 == "0" ? 1 : 0;
            areavillageEntity userEntity = new areavillageEntity();
            userEntity.AutoID = ajaxEntity.AutoID;
            userEntity.Retrieve();
            if (userEntity.IsPersistent)
            {
                userEntity.Status = Convert.ToByte(iUpdataStatus);
                userEntity.Save();
            }

        }
        #endregion

        #region 判断乡村名称是否存在
        /// <summary>
        /// 判断乡村名称是否存在
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string CheckVillageNameExist(AjaxHelper ajaxEntity)
        {
            string returnValue = "N";
            int curId = ajaxEntity.AutoID;
            string strSql = string.Format("SELECT Count(*) from areavillage Where Title='{0}' and ProvinceID='{1}'  and CityID='{2}'  and CountyID='{3}'  and TownID='{4}' and  Status<>2 ", ajaxEntity.Title, ajaxEntity.Extend1, ajaxEntity.Extend3, ajaxEntity.Extend4, ajaxEntity.Extend5);
            if (curId > 0) strSql += string.Format(" AND AutoID <> '{0}' ", curId);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (CommonMethod.ConvertToInt(dt.Rows[0][0].ToString(), 0) > 0) returnValue = "Y";
            }
            return returnValue;
        }

        #endregion

        #region 删除单个乡村
        /// <summary>
        /// 删除单个乡村
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string SingleDeleteForVillage(AjaxHelper ajaxEntity)
        {
            areatownEntity obj = new areatownEntity();
            obj.AutoID = ajaxEntity.AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                obj.Status = 2;
                obj.Save();
            }
            ajaxEntity.Action = SystemData.AreaTown;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #region 批量删除乡村
        /// <summary>
        /// 批量删除乡村
        /// </summary>
        /// <param name="ajaxEntity"></param>
        /// <returns></returns>
        public string BatchDeleteForVillage(AjaxHelper ajaxEntity)
        {
            string delId = ajaxEntity.Extend2;
            object[] list = delId.Split(new char[] { '_' });
            UpdateCriteria uc = new UpdateCriteria(typeof(areavillageEntity));
            uc.GetNewCondition().AddIn(areavillageEntity.Columns.AutoID, list);
            uc.AddAttributeForUpdate(areavillageEntity.Columns.Status, 2);
            int mun = uc.Perform();
            ajaxEntity.Extend5 = mun.ToString();
            ajaxEntity.Action = SystemData.AreaVillage;
            return GetHtmlString(ajaxEntity);
        }
        #endregion

        #endregion

        #region 获取地区列表
        /// <summary>
        /// 获取地区列表
        /// </summary>
        public string GetAreaList(AjaxHelper ajaxEntity)
        {
            StringBuilder sb = new StringBuilder();
            string areatype="";
            string strSql = "";
            string strHeadOption = "";
            switch (ajaxEntity.Action.ToLower())
            {
                case SystemData.GetCityByProvince: strSql = string.Format("select AutoID,Title from areacity  where status <> 2 and ProvinceID='{0}'  order by OrderValue desc,AutoID asc  ", ajaxEntity.Extend1); areatype = "1"; strHeadOption = "请选择所属城市"; break;
                case SystemData.GetCountyByCity: strSql = string.Format("select AutoID,Title from areacounty  where status <> 2 and CityID='{0}'  order by OrderValue desc,AutoID asc  ", ajaxEntity.Extend1); areatype = "2"; strHeadOption = "请选择所属县、区"; break;
                case SystemData.GetTownByCounty: strSql = string.Format("select AutoID,Title from areatown  where status <> 2 and CountyID='{0}'  order by OrderValue desc,AutoID asc  ", ajaxEntity.Extend1); areatype = "3"; strHeadOption = "请选择所属乡镇"; break;
                default:
                    break;
            }
            sb.AppendFormat("<option value=''>{0}</option>", strHeadOption);
            if (ajaxEntity.Extend1.Length > 0)
            {
              
                DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
                 for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sb.AppendFormat("<option value='{0}'>{1}</option>", dt.Rows[i]["AutoID"], dt.Rows[i]["Title"]);
                }
            }
            return sb.ToString() + "$&%$" + areatype;
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
                case SystemData.SystemUser: ajaxEntity = GetAjaxHelperForSystemUser(ajaxEntity); break;
                case SystemData.SystemRole: ajaxEntity = GetAjaxHelperForSystemRole(ajaxEntity); break;
                case SystemData.SystemMenu: ajaxEntity = GetAjaxHelperForSystemMenu(ajaxEntity); break;
                case SystemData.SystemCustomer: ajaxEntity = GetAjaxHelperForSystemCustomer(ajaxEntity); break;
                case SystemData.SystemDomain: ajaxEntity = GetAjaxHelperForSystemDomain(ajaxEntity); break;
                case SystemData.SystemCustomerDomain: ajaxEntity = GetAjaxHelperForCustomerDomain(ajaxEntity); break;
                case SystemData.AreaProvince: ajaxEntity = GetAjaxHelperForProvince(ajaxEntity); break;
                case SystemData.AreaCity: ajaxEntity = GetAjaxHelperForCity(ajaxEntity); break;
                case SystemData.AreaCounty: ajaxEntity = GetAjaxHelperForCounty(ajaxEntity); break;
                case SystemData.AreaTown: ajaxEntity = GetAjaxHelperForTown(ajaxEntity); break;
                case SystemData.AreaVillage: ajaxEntity = GetAjaxHelperForVillage(ajaxEntity); break;
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
                case SystemData.SystemUser: strData = CreateTableForSystemUser(dt); break;
                case SystemData.SystemRole: strData = CreateTableForSystemRole(dt); break;
                case SystemData.SystemMenu: strData = CreateTableForSystemMenu(dt); break;
                case SystemData.SystemCustomer: strData = CreateTableForSystemCustomer(dt); break;
                case SystemData.SystemDomain: strData = CreateTableForSystemDomain(dt); break;
                case SystemData.SystemCustomerDomain: strData = CreateTableForCustomerDomain(dt); break;
                case SystemData.AreaProvince: strData = CreateTableForProvince(dt); break;
                case SystemData.AreaCity: strData = CreateTableForCity(dt); break;
                case SystemData.AreaCounty: strData = CreateTableForCounty(dt); break;
                case SystemData.AreaTown: strData = CreateTableForTown(dt); break;
                case SystemData.AreaVillage: strData = CreateTableForVillage(dt); break;
                default: break;
            }
            return strData;
        }

        #endregion

    }
}