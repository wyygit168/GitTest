using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntity;
using System.Text;
using BLL.Service;

public partial class admin_systemset_systemmenudetail : SystemPopUpBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadScript();
            UtilitySearch.LoadTopMenuID(this.ddlTopMenuID);
            GetPageElementValue();

        }
    }

    #region 获取页面元素的值

    private void GetPageElementValue()
    {
        if (Request.QueryString["curId"] != null)
        {
            int id = CommonMethod.ConvertToInt(Request.QueryString["curId"], 0);
            systemmenuEntity obj = new systemmenuEntity();
            obj.AutoID = id;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                ControlAndValue.GetValues4Control<systemmenuEntity>(this.form1, obj);
                 
                if (obj.TopMenuID > 0)
                {
                    UtilitySearch.LoadOneMenu(ddlOneMenu, obj.TopMenuID);
                    ddlOneMenu.SelectedValue = obj.ParentId.ToString();
                    spanonemenu.Style.Value = "display:''";
                }
                else {  spanonemenu.Style.Value = "display:none"; }
            }
            txtAutoID.Text = id.ToString();
            if (Action == "view")
            {
                this.btnSave.Visible = false; this.btnCancel.Visible = false;
            }
        }
        else {  spanonemenu.Style.Value = "display:none"; }

    }

    #endregion

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region 验证
        if (txtTitle.Text.Trim().Length == 0) { Alert("资源名称不可以为空！"); Select(txtTitle); return; }

        AjaxHelper ajaxEntity = new AjaxHelper();
        ajaxEntity.Title = CommonMethod.ClearInputText(txtTitle.Text, 50);
        ajaxEntity.Status = ddlStatus.SelectedValue;
        ajaxEntity.Action = SystemData.CheckMenuNameExist;
        ajaxEntity.PageStatus = "2";
        ajaxEntity.AutoID = txtAutoID.Text.ToInt(0);
        SystemSet sset = new SystemSet(ajaxEntity.PageStatus);
        string returnValue = sset.CheckMenuNameExist(ajaxEntity);
        if (returnValue == "Y")
        {
            AlertError("资源名称已存在,请重新输入！");
            Select(txtTitle);
            return;
        }
        
        
        #endregion

        int AutoId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        systemmenuEntity objEntity = new systemmenuEntity();
        objEntity.AutoID = AutoId;
        objEntity.Retrieve();
        DateTime dtNow = DateTime.Now;
        if (!objEntity.IsPersistent)
        {
            objEntity.CreateDate = dtNow;
            objEntity.CreatorID = CurrentUser.AutoID;
            objEntity.CustomerID = CurrentUser.CustomerID;
        }
        objEntity.ModifyDate = dtNow;
        objEntity.Modifier = CurrentUser.AutoID;
        objEntity.IsTopMenu = CommonMethod.ConvertToInt(ddlTopMenuID.SelectedValue, 0) > 0 ? 0 : 1;
        objEntity.ParentId = CommonMethod.ConvertToInt(Request.Form["ddlOneMenu"], 0);
        ControlAndValue.SetValues4Controls<systemmenuEntity>(this.form1, objEntity);
        objEntity.Save();
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
        txtTitle.Text = "";
        txtMenuUrl.Text = "";
        txtAlt.Text = "";
        txtOrderValue.Text = "";
        ddlStatus.SelectedValue = "1";
        ddlOneMenu.SelectedValue = "0";
        //ddlOneMenu.Enabled = false;
        ddlTopMenuID.SelectedValue = "";
        spanonemenu.Style.Value = "display:none";
    }

    #region 加载Js文件
    /// <summary>
    /// 加载Js文件
    /// </summary>
    private void LoadScript()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/dataset.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/systemmenudetail.aspx.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    #endregion
}