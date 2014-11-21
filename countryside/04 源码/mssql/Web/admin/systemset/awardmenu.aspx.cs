using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using PersistenceLayer;
using System.Data;
using BusinessEntity;

public partial class admin_systemset_awardmenu : SystemPopUpBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadScript();
            int autoId = Request.QueryString["curId"] == null ? 0 : CommonMethod.ConvertToInt(Request.QueryString["curId"], 0);
            systemroleEntity objEntity = new systemroleEntity();
            objEntity.AutoID = autoId;
            objEntity.Retrieve();
            if (objEntity.IsPersistent) { lblRoleName.Text = objEntity.Title; txtRoleId.Text = objEntity.AutoID.ToString(); }
            StringBuilder sb = new StringBuilder();
            string strIsSuperAdmin = " and IsSuperAdmin=0 ";
            if (CurrentCustomerID == 0)
            {
                strIsSuperAdmin = "";
            }
            string strSql =string.Format( @"SELECT AutoID , CustomerID, Title, MenuUrl,IsSuperAdmin,IsTopMenu,MenuType, TopMenuID, ParentId, OrderValue  
                            FROM  systemmenu   where status =1  {0} order by OrderValue desc,AutoID asc  ",strIsSuperAdmin);
           
            string strSqlRole = string.Format(@"select  srm.RoleID,srm.MenuID, srm.IsShowMenu,srm.IsPurview,srm.IsAdd,srm.IsView,srm.IsEdit,srm.IsDelete,srm.CustomerID   from  system_role_menu srm 
                                  inner join systemmenu sm  on sm.AutoID=srm.MenuID 
                                  inner join systemrole sr  on sr.AutoID=srm.RoleId  
                                  where srm.RoleID='{0}' and srm.CustomerID='{1}'
                                  order by sm.OrderValue desc,sm.AutoID asc ", txtRoleId.Text, CurrentUser.CustomerID);
            DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
            DataTable dtRole = Query.ProcessSql(strSqlRole, DataHelper.DataBase);
            bool isRole = false;
            if (dtRole != null && dtRole.Rows.Count > 0) isRole = true;
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow[] drTop = dt.Select("IsTopMenu=1");
                if (drTop != null && drTop.Length > 0)
                {
                    foreach (DataRow dr in drTop)
                    {
                        DataRow[] drOne = dt.Select(string.Format("IsTopMenu=0 and TopMenuID={0} and ParentId=0", dr["AutoID"]));

                        string strCheckedIsPurview = "";
                        string strCheckedIsShowMenu = "";
                        string strCheckedIsAdd = "";
                        string strCheckedIsView = "";
                        string strCheckedIsEdit = "";
                        string strCheckedIsDelete = "";                       
                        if (isRole) strCheckedIsPurview = getCheckedState(dtRole, autoId, dr["AutoID"].ToString(), "IsPurview");
                        if (drOne != null && drOne.Length > 0)
                            sb.AppendFormat("<div   style=\"background-color:#C0C0C0; border-bottom:2px solid #CCCCCC;height:38px; width:775px;\"><input style=\"padding-left:40px;margin-top:12px;\"  id=\"IsPurview_{0}\"  type=\"checkbox\" {2} /><a href=\"###\" type=\"{0}\" style=\"font-size:18px;color:#fff;line-height:17pt;\">{1}</a></div>", dr["AutoID"], dr["Title"], strCheckedIsPurview);
                        else
                            sb.AppendFormat("<div   style=\"background-color:#C0C0C0; border-bottom:2px solid #CCCCCC;height:38px; width:775px;\"><input style=\"padding-left:40px;margin-top:12px;\" id=\"IsPurview_{0}\" type=\"checkbox\"  {2} /><a   type=\"{0}\" style=\"font-size:18px;color:#fff;line-height:17pt;\">{1}</a></div>", dr["AutoID"], dr["Title"], strCheckedIsPurview);
                        foreach (DataRow drone in drOne)
                        {
                            sb.AppendFormat("<dl type=\"{0}\" style=\"display:none; margin-top:0px; margin-bottom:0px;\">", dr["AutoID"]);
                            strCheckedIsPurview = "";
                            if (isRole) strCheckedIsPurview = getCheckedState(dtRole, autoId, drone["AutoID"].ToString(), "IsPurview");
                            sb.AppendFormat("<dt  style=\"width:735px; padding:5px 0 5px 40px; \"><input id=\"IsPurview_{0}\" type=\"checkbox\"  {2}  /><lable for=\"{0}\">{1}</lable></dt>", drone["AutoID"], drone["Title"], strCheckedIsPurview);

                            DataRow[] drPage = dt.Select(string.Format("IsTopMenu=0 and TopMenuID={0} and ParentId={1}", dr["AutoID"], drone["AutoID"]));
                            foreach (DataRow drpage in drPage)
                            {
                                strCheckedIsPurview = "";
                                strCheckedIsShowMenu = "";
                                strCheckedIsAdd = "";
                                strCheckedIsEdit = "";
                                strCheckedIsDelete = "";
                                if (isRole)
                                {
                                    strCheckedIsPurview = getCheckedState(dtRole, autoId, drpage["AutoID"].ToString(), "IsPurview");
                                    strCheckedIsShowMenu = getCheckedState(dtRole, autoId, drpage["AutoID"].ToString(), "IsShowMenu");
                                    strCheckedIsAdd = getCheckedState(dtRole, autoId, drpage["AutoID"].ToString(), "IsAdd");
                                    strCheckedIsView = getCheckedState(dtRole, autoId, drpage["AutoID"].ToString(), "IsView"); 
                                    strCheckedIsEdit = getCheckedState(dtRole, autoId, drpage["AutoID"].ToString(), "IsEdit");
                                    strCheckedIsDelete = getCheckedState(dtRole, autoId, drpage["AutoID"].ToString(), "IsDelete");
                                }
                                    if(drpage["MenuType"].ToString()=="0") //访问权限  菜单显示
                                {
                                    sb.AppendFormat("<dd style=\"width:695px; padding:5px 0 5px 40px;\"><div style='float:left;width:215px;'>{1}</div> <input id=\"IsPurview_{0}\" type=\"checkbox\"  {2}  /><lable for=\"IsPurview_{0}\">页面权限</lable>&nbsp;&nbsp;<input id=\"IsShowMenu_{0}\" type=\"checkbox\"  {3}  /><lable for=\"IsShowMenu_{0}\">菜单显示</lable></dt>", drpage["AutoID"], drpage["Title"], strCheckedIsPurview, strCheckedIsShowMenu);

                                }
                                    else if (drpage["MenuType"].ToString() == "1" || drpage["MenuType"].ToString() == "3") //分页面 包括新增 修改 查看 删除 删除权限 ，MenuType=1代表弹出详细页面，MenuType==3 代表链接详细页面
                                {
                                    sb.AppendFormat("<dd style=\"width:695px; padding:5px 0 5px 40px;\"><div style='float:left;width:215px;'>{1}</div> <input id=\"IsPurview_{0}\" type=\"checkbox\"  {2}  /><lable for=\"IsPurview_{0}\">页面权限</lable>&nbsp;&nbsp;<input id=\"IsAdd_{0}\" type=\"checkbox\"  {3}  /><lable for=\"IsAdd_\">新增权限</lable>&nbsp;&nbsp;<input id=\"IsView_{0}\" type=\"checkbox\"  {6}  /><lable for=\"IsView_{0}\">查看权限</lable>&nbsp;&nbsp;<input id=\"IsEdit_{0}\" type=\"checkbox\"  {4}  /><lable for=\"IsEdit_{0}\">修改权限</lable>&nbsp;&nbsp;<input id=\"IsDelete_{0}\" type=\"checkbox\"  {5}  /><lable for=\"IsDelete_{0}\">删除权限</lable></dt>", drpage["AutoID"], drpage["Title"], strCheckedIsPurview, strCheckedIsAdd, strCheckedIsEdit, strCheckedIsDelete,strCheckedIsView);

                                }
                                else if (drpage["MenuType"].ToString() == "2")
                                {
                                    sb.AppendFormat("<dd style=\"width:695px; padding:5px 0 5px 40px;\"><div style='float:left;width:215px;'>{1}</div> <input id=\"IsPurview_{0}\" type=\"checkbox\"  {2}  /><lable for=\"IsPurview_{0}\">页面权限</lable></dt>", drpage["AutoID"], drpage["Title"], strCheckedIsPurview);
                                }
  
                            }
                            sb.Append("</dl>");
                        }
                    }
                }
            }
            this.ltResourceList.Text = sb.ToString();
        }

    }
    private string getCheckedState(DataTable dtRole, int RoleID, string MenuID, string Type)
    {
        DataRow[] drArray = dtRole.Select(string.Format("MenuID='{0}' and RoleID='{1}' and CustomerID='{2}' ", MenuID, RoleID, CurrentUser.CustomerID));
        string returnValue = "";
        if (drArray != null && drArray.Length > 0)
        {
            switch (Type)
            {
                case "IsPurview": returnValue = getCheckedValue(drArray[0]["IsPurview"].ToString()); break;
                case "IsShowMenu": returnValue = getCheckedValue(drArray[0]["IsShowMenu"].ToString()); break;
                case "IsAdd": returnValue = getCheckedValue(drArray[0]["IsAdd"].ToString()); break;
                case "IsView": returnValue = getCheckedValue(drArray[0]["IsView"].ToString()); break;
                case "IsEdit": returnValue = getCheckedValue(drArray[0]["IsEdit"].ToString()); break;
                case "IsDelete": returnValue = getCheckedValue(drArray[0]["IsDelete"].ToString()); break;
                default: break;
            }
        }
        return returnValue;
    }

    private string getCheckedValue(string value)
    {
        string returnValue = ""; 
        if (value =="1") returnValue = "checked=true";
        return returnValue;
    }

    #region 加载Js文件
    /// <summary>
    /// 加载Js文件
    /// </summary>
    private void LoadScript()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/dataset.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/awardmenu.aspx.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    #endregion


}