using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntity;
using System.Text;
using BLL.Service;


public partial class admin_systemset_areacountysetdetail : SystemPopUpBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadScript();
            GetPageElementValue();

        }
    }

    #region 获取页面元素的值

    private void GetPageElementValue()
    {
        if (Request.QueryString["curId"] != null)
        {
            int id = CommonMethod.ConvertToInt(Request.QueryString["curId"], 0);
            areacountyEntity obj = new areacountyEntity();
            obj.AutoID = id;
            obj.Retrieve();
            UtilitySearch.LoadProvince(this.ddlProvinceID, obj.ProvinceID, Action, "请选择");
            UtilitySearch.LoadCity(this.ddlCityID, obj.CityID, Action, obj.ProvinceID, "请选择");
            if (obj.IsPersistent)
            {
                ControlAndValue.GetValues4Control<areacountyEntity>(this.form1, obj);
            }
            txtAutoID.Text = id.ToString();
            if (Action == "view")
            {
                this.btnSave.Visible = false; this.btnCancel.Visible = false;
            }
        }
        else
        {
            UtilitySearch.LoadProvince(this.ddlProvinceID, 0, Action, "请选择");
        }
    }

    #endregion

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region 验证
        if (txtTitle.Text.Trim().Length == 0) { AlertError("县、区名称不可以为空！"); Select(txtTitle); return; }
        if (ddlProvinceID.SelectedValue.Length == 0) { AlertError("请选择所属省、直辖市！"); return; }
        if (Request.Form["ddlCityID"].Trim().Length == 0) { AlertError("请选择城市！"); return; }
        
        AjaxHelper ajaxEntity = new AjaxHelper();
        ajaxEntity.Title = CommonMethod.ClearInputText(txtTitle.Text, 50);
        ajaxEntity.Status = ddlStatus.SelectedValue;
        ajaxEntity.Action = SystemData.CheckCountyNameExist;
        ajaxEntity.Extend1 = ddlProvinceID.SelectedValue;
        ajaxEntity.Extend3 = Request.Form["ddlCityID"].Trim();
        ajaxEntity.PageStatus = "2";
        ajaxEntity.AutoID = txtAutoID.Text.ToInt(0);
        SystemSet sset = new SystemSet(ajaxEntity.PageStatus);
        string returnValue = sset.CheckCountyNameExist(ajaxEntity);
        if (returnValue == "Y")
        {
            AlertError("县、区名称已存在,请重新输入！");
            ddlCityID.SelectedValue=ajaxEntity.Extend3;
            Select(txtTitle);
            return;
        }
        #endregion

        int AutoId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        areacountyEntity objEntity = new areacountyEntity();
        objEntity.AutoID = AutoId;
        objEntity.Retrieve();
        DateTime dtNow = DateTime.Now;
        if (!objEntity.IsPersistent)
        {
            objEntity.CreateDate = dtNow;
            objEntity.CreatorID = CurrentUser.AutoID;
        }
        objEntity.ModifyDate = dtNow;
        objEntity.Modifier = CurrentUser.AutoID;
        ControlAndValue.SetValues4Controls<areacountyEntity>(this.form1, objEntity);
        objEntity.CityID = CommonMethod.ConvertToInt(Request.Form["ddlCityID"], 0);
        objEntity.Save();
        setNull();
        if (AutoId <= 0) ExecScript("savesucceed();");
        else ExecScript("parent.returnfunction();");
    }

    private void setNull()
    {
        foreach (Control var in this.form1.Controls)
        {
            if (var.ID != null && var.ID.Contains("txt"))
            {
                TextBox tBox = (TextBox)var;
                if (tBox != null) { tBox.Text = ""; }
            }
        }
        this.ddlStatus.SelectedValue = "1";
        this.ddlProvinceID.SelectedValue = "";
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        int curId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        if (curId > 0)
        {
            ExecScript("parent.ymPrompt.close();");
        }
        else
        {
            ExecScript("parent.ymPrompt.close();parent.succeed();");
        }
    }

    #region 加载Js文件
    /// <summary>
    /// 加载Js文件
    /// </summary>
    private void LoadScript()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/dataset.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/areacountysetdetail.aspx.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    #endregion
}