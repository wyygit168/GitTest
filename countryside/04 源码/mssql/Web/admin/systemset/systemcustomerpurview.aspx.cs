using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PersistenceLayer;
using BusinessEntity;

public partial class admin_systemset_systemcustomerpurview :SystemPopUpBasePage
{

    #region 属性
    public int OpId
    {
        get{
            int opId = -1;
            if (Request.QueryString["opId"] != null)
            {
                opId = Request.QueryString["opId"].Trim().ToInt(0);
            }
            return opId;
        }
    }

    #endregion

    #region 页面加载
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetPageElementValue();
        }
    }
    #endregion

    #region 绑定页面元素
    /// <summary>
    /// 绑定页面元素
    /// </summary>
    private void GetPageElementValue()
    {
        if (Request.QueryString["curId"] != null && Request.QueryString["opId"] != null && Request.QueryString["cusn"] != null)
        {
            int id = CommonMethod.ConvertToInt(Request.QueryString["curId"], 0);
            lblSupplierTitle.Text = Server.UrlDecode(Request.QueryString["cusn"].Trim());
            DataTable dt = GetDataTable(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                lblDomainTitle.Text = dt.Rows[0]["domainTitle"].ToString().Replace(",","<br/>");
                this.btnDomain.Visible = false; trPrview.Style.Value = "display:''";
            }
            else
            {
                lblDomainTitle.Text = "暂未绑定域名";
                this.btnDomain.Visible = true;
                trPrview.Style.Value = "display:none";
            }

            if (OpId == 1)
            {
                btnPriview.Text = "关闭权限";
                lblPurviewTitle.Text = "关闭权限：";
            }
        }
    }

    #endregion

    #region  查询客户拥有的有效域名
    /// <summary>
    /// 查询客户拥有的有效域名
    /// </summary>
    /// <param name="autoID">客户ID</param>
    /// <returns></returns>
    private DataTable GetDataTable(int autoID)
    {
        string strSql = string.Format(@"SELECT  
                        STUFF((SELECT  ','+d.Title
                        FROM system_customer_domain cd 
                        LEFT JOIN  systemcustomer c  ON cd.CustomerID=c.AutoID
                        LEFT JOIN  systemdomain d  ON cd.DomainID=d.AutoID
                        WHERE c.AutoID='{0}'   
                        FOR XML PATH('')),1, 1, '')    AS domainTitle
                        FROM system_customer_domain cd 
                        LEFT JOIN  systemcustomer c  ON cd.CustomerID=c.AutoID
                        LEFT JOIN  systemdomain d  ON cd.DomainID=d.AutoID
                        WHERE c.AutoID='{0}'   GROUP BY c.AutoID   ", autoID);
        return Query.ProcessSql(strSql, DataHelper.DataBase);
    }
    #endregion

    #region  客户如没有域名，跳转到域名页面绑定
    /// <summary>
    /// 客户如没有域名，跳转到域名页面绑定
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnDomain_Click(object sender, EventArgs e)
    {
        ExecScript("parent.openurl('systemdomainbind.aspx')");
    }
    #endregion

    #region 开通权限
    protected void btnPriview_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["curId"] != null && Request.QueryString["opId"] != null)
        {
            int id = CommonMethod.ConvertToInt(Request.QueryString["curId"], 0);
            string purviewvalue = "开通";
           
            #region 第一次开通
            if (OpId == 0)
            {
                bool done = false;
                Transaction tran = new Transaction();
                try
                {
                    #region 建立初始用户
                    systemuserEntity userObj = new systemuserEntity();
                    DateTime dt = DateTime.Now;
                    userObj.CreateDate = dt;
                    userObj.CreatorID = CurrentUser.AutoID;
                    userObj.ModifyDate = dt;
                    userObj.Modifier = CurrentUser.AutoID;
                    userObj.Title = "admin"+id;
                    userObj.UserPassword = "6A3D6D38B5F7F883"; 
                    userObj.Status = 1;
                    userObj.CustomerID = id;
                    userObj.RealName = lblSupplierTitle.Text + "_" + id;
                    userObj.Remark = "客户id：" + id;
                    tran.DoSaveObject(userObj);
                    #endregion

                    #region 建立管理员角色
                    int userID = userObj.AutoID;
                    systemroleEntity roleObj = new systemroleEntity();
                    roleObj.Title= "系统管理员";
                    roleObj.Status = 1;
                    roleObj.CustomerID = id;
                    roleObj.CreateDate = dt;
                    roleObj.ModifyDate= dt;
                    roleObj.CreatorID= CurrentUser.AutoID;
                    roleObj.Modifier= CurrentUser.AutoID;
                    tran.DoSaveObject(roleObj);
                    int roleID = roleObj.AutoID;
                    #endregion

                    #region 授予用户角色
                    system_user_roleEntity userRoleObj = new system_user_roleEntity();
                    userRoleObj.RoleID = roleID;
                    userRoleObj.UserID = userID;
                    userRoleObj.CustomerID = id;
                    userRoleObj.Modifier = CurrentUserID;
                    userRoleObj.ModifyDate = dt;
                    userRoleObj.CreateDate = dt;
                    userRoleObj.CreatorID = CurrentUserID;
                    tran.DoSaveObject(userRoleObj);
                    int userRoleID = userRoleObj.AutoID;
                    #endregion

                    #region 授予角色资源菜单
                    for (int i = 1; i <=41; i++)
                    {
                        system_role_menuEntity srm = new system_role_menuEntity();
                        srm.CreateDate = dt;
                        srm.CreatorID = CurrentUserID;
                        srm.Modifier = CurrentUserID; ;
                        srm.ModifyDate = dt;
                        srm.IsAdd = 1;
                        srm.IsDelete = 1;
                        srm.IsEdit = 1;
                        srm.IsView = 1;
                        srm.MenuID = i;
                        if (i == 1 || i == 2 || i == 3 || i == 5 || i == 7 || i == 11 || i == 12
                            ||  i == 32 || i == 33 || i == 34 || i == 36 || i == 38 || i == 40
                            )
                        {
                            srm.IsShowMenu = 1;
                        }
                        else
                        {
                            srm.IsShowMenu = 0;
                        }
                        srm.RoleID = roleID;
                        srm.CustomerID = id;
                        srm.IsPurview = 1;
                        if (i == 12) { i = 31; }
                        tran.DoSaveObject(srm);
                    }
                    #endregion

                    #region 权限开通
                    systemcustomerEntity supplierObj = new systemcustomerEntity();
                    supplierObj.AutoID = id;
                    supplierObj.Retrieve();
                    if (supplierObj.IsPersistent)
                    {
                        supplierObj.OpenStatus = 1; 
                        tran.DoSaveObject(supplierObj);
                    }
                    #endregion

                    #region 登陆标题设置
                   
                    //OperateXml xml = new OperateXml();
                    //string logintitleValue = "系统";
                    //xml.AddbaseconfigFile(id.ToString(), "logintitle", logintitleValue); 
                
                    #endregion

                    done = tran.Commit();
                }
                finally
                {
                    if (!done) tran.RollBack();
                }
            }
            #endregion

            #region 关闭后在开通
            else if (OpId == 2)
            {
                systemcustomerEntity supplierObj = new systemcustomerEntity();
                supplierObj.AutoID = id;
                supplierObj.Retrieve();
                if (supplierObj.IsPersistent)
                {
                    supplierObj.OpenStatus = 1;
                    supplierObj.Save();
                }
            }
            #endregion
            
            #region 关闭权限
            else if (OpId == 1)
            {
                purviewvalue = "关闭";
                systemcustomerEntity supplierObj = new systemcustomerEntity();
                supplierObj.AutoID = id;
                supplierObj.Retrieve();
                if (supplierObj.IsPersistent)
                {
                    supplierObj.OpenStatus = 2;
                    supplierObj.Save();
                }
            }
            #endregion

            ExecScript("parent.returnopenpriview('" + purviewvalue + "');");
        }
    }
    #endregion
}