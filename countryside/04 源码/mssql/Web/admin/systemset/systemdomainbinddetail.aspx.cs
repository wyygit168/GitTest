using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntity;
using System.Text;
using BLL.Service;

public partial class admin_systemset_systemdomainbinddetail : SystemPopUpBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetPageElementValue();
        }
    }

    #region 获取页面元素的值

    private void GetPageElementValue()
    {
        
        if (Request.QueryString["curId"] != null)
        {
            int id = CommonMethod.ConvertToInt(Request.QueryString["curId"], 0);
            system_customer_domainEntity obj = new system_customer_domainEntity();
            obj.AutoID = id;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                UtilitySearch.LoadBindCustomer(this.ddlCustomerID, obj.CustomerID);
                if (Action == "view")
                {
                    UtilitySearch.LoadBindDomain(this.ddlDomainID, obj.DomainID,"view");
                }
                else
                {
                    UtilitySearch.LoadBindDomain(this.ddlDomainID, obj.DomainID,"type");
                }
                ControlAndValue.GetValues4Control<system_customer_domainEntity>(this.form1, obj);
                txtDomainAutoID.Text = obj.DomainID.ToString();
            }
            txtAutoID.Text = id.ToString();
            if (Action == "view")
            {
                this.btnSave.Visible = false; this.btnCancel.Visible = false;
            }
        }
        else
        {
            UtilitySearch.LoadBindDomain(this.ddlDomainID);
            UtilitySearch.LoadBindCustomer(this.ddlCustomerID);
        }
         

    }

    #endregion

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region 验证

        if (ddlCustomerID.SelectedValue.Length == 0) { AlertError("请选择客户名称！");  return; }
        if (ddlDomainID.SelectedValue.Length == 0) { AlertError("请选择域名名称！");  return; }
        
        #endregion

        bool isNew = false;
        int AutoId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        system_customer_domainEntity objEntity = new system_customer_domainEntity();
        objEntity.AutoID = AutoId;
        objEntity.Retrieve();
        DateTime dtNow = DateTime.Now;
        if (!objEntity.IsPersistent)
        {
            objEntity.CreateDate = dtNow;
            objEntity.CreatorID = CurrentUser.AutoID;
            objEntity.CustomerID = CurrentUser.CustomerID;
            isNew = true;
        }
        objEntity.ModifyDate = dtNow;
        objEntity.Modifier = CurrentUser.AutoID;
        ControlAndValue.SetValues4Controls<system_customer_domainEntity>(this.form1, objEntity);
        objEntity.Save();
        if (isNew)
        {
            systemdomainEntity sdobj = new systemdomainEntity();
            sdobj.AutoID = objEntity.DomainID;
            sdobj.Retrieve();
            if (sdobj.IsPersistent)
            {
                sdobj.Status = 1;
                sdobj.Save();
            }
        }
        else if (!txtDomainAutoID.Text.Trim().Equals(ddlDomainID.SelectedValue))
        {
            systemdomainEntity sdobj = new systemdomainEntity();
            sdobj.AutoID = txtDomainAutoID.Text.ToInt();
            sdobj.Retrieve();
            if (sdobj.IsPersistent)
            {
                sdobj.Status = 0;
                sdobj.Save();
            }
            systemdomainEntity sdobj1 = new systemdomainEntity();
            sdobj.AutoID = ddlDomainID.SelectedValue.ToInt();
            sdobj.Retrieve();
            if (sdobj.IsPersistent)
            {
                sdobj.Status = 1;
                sdobj.Save();
            }
        }
        if (AutoId <= 0) { setNull(); ExecScript("savesucceed();"); }
        else ExecScript("parent.returnfunction();");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        int curId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        if (curId > 0) ExecScript("parent.ymPrompt.close();");
        else ExecScript("parent.ymPrompt.close();parent.succeed();");
    }

    private void setNull()
    {
        UtilitySearch.LoadBindCustomer(this.ddlCustomerID);
        UtilitySearch.LoadBindDomain(this.ddlDomainID);
        ddlCustomerID.SelectedValue = "";
        ddlDomainID.SelectedValue = "";
    }

}