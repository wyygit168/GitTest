using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PersistenceLayer;

public partial class admin_systemset_awardrole :SystemPopUpBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["curId"] != null)
            {
                string strAutoId = Request.QueryString["curId"].Trim();
                GetSystemUserName(strAutoId);
                BindSystemRole();
                DataTable dt = GetCurrentUserRole(strAutoId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    ddlRole.SelectedValue = dt.Rows[0]["RoleID"].ToString();
                }
            }
        }

    }
    /// <summary>
    ///   绑定角色
    /// </summary>
    private void BindSystemRole()
    {
        string strSql =string.Format("select AutoID,Title from systemrole WITH(NOLOCK)  where status<>2 and CustomerID='{0}' order by OrderValue desc,AutoID desc  ",CurrentUser.CustomerID );
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        ControlAndValue.ListControlDataBind(this.ddlRole, dt, "Title", "AutoID");
    }
    /// <summary>
    ///  获取用户名称
    /// </summary>
    private void GetSystemUserName(string strAutoId)
    {
        string strSql = string.Format("select Title from systemuser WITH(NOLOCK)  where AutoID='{0}'", strAutoId);
        DataTable dt = Query.ProcessSql(strSql, DataHelper.DataBase);
        if (dt != null && dt.Rows.Count > 0)
        {
            lblUserAccount.Text = dt.Rows[0]["Title"].ToString();
        }
    }

    /// <summary>
    /// 当前用户角色查询
    /// </summary>
    /// <param name="strAutoId"></param>
    /// <returns></returns>
    private DataTable GetCurrentUserRole(string strUserId)
    {
        string strSql = string.Format("select AutoID, RoleID from system_user_role WITH(NOLOCK) where UserID='{0}' AND CustomerID='{1}' ", strUserId, CurrentUser.CustomerID);
        return Query.ProcessSql(strSql, DataHelper.DataBase);
    }


    /// <summary>
    /// 保存
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["curId"] != null)
        {
            bool isInsert = true;
            string userRoelID = "";
            string strUserID = Request.QueryString["curId"].Trim();
            DataTable dt = GetCurrentUserRole(strUserID);
            if (dt != null && dt.Rows.Count > 0)
            {
                isInsert = false;
                userRoelID = dt.Rows[0]["AutoID"].ToString();
            }
            string strSql = "";
            DateTime dtNow = DateTime.Now;
            if (isInsert) strSql = string.Format("Insert system_user_role Values('{0}','{1}','{2}','{3}','{4}','{3}','{4}')", strUserID, ddlRole.SelectedValue,CurrentUser.CustomerID,CurrentUser.AutoID,dtNow);
            else strSql = string.Format("Update system_user_role set RoleID='{0}',Modifier='{2}',ModifyDate='{3}'  where AutoID='{1}' and CustomerID='{4}'", ddlRole.SelectedValue.ToInt(0), userRoelID, CurrentUser.AutoID, dtNow,CurrentUser.CustomerID);
            Query.ProcessSqlNonQuery(strSql, DataHelper.DataBase);
            ExecScript("parent.returnfunction();"); 
        }
    }
}