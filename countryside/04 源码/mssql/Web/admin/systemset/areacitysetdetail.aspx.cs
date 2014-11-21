﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntity;
using System.Text;
using BLL.Service;

public partial class admin_systemset_areacitysetdetail : SystemPopUpBasePage
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
            areacityEntity obj = new areacityEntity();
            obj.AutoID = id;
            obj.Retrieve();
            UtilitySearch.LoadProvince(this.ddlProvinceID, obj.ProvinceID, Action, "请选择");
            if (obj.IsPersistent)
            {
                ControlAndValue.GetValues4Control<areacityEntity>(this.form1, obj);
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
        if (txtTitle.Text.Trim().Length == 0) { AlertError("城市名称不可以为空！"); Select(txtTitle); return; }
        if (ddlProvinceID.SelectedValue.Length == 0) { AlertError("请选择所属省、直辖市！"); return; }
        AjaxHelper ajaxEntity = new AjaxHelper();
        ajaxEntity.Title = CommonMethod.ClearInputText(txtTitle.Text, 50);
        ajaxEntity.Status = ddlStatus.SelectedValue;
        ajaxEntity.Action = SystemData.CheckCityNameExist;
        ajaxEntity.Extend1 = ddlProvinceID.SelectedValue;
        ajaxEntity.PageStatus = "2";
        ajaxEntity.AutoID = txtAutoID.Text.ToInt(0);
        SystemSet sset = new SystemSet(ajaxEntity.PageStatus);
        string returnValue = sset.CheckCityNameExist(ajaxEntity);
        if (returnValue == "Y")
        {
            AlertError("城市名称已存在,请重新输入！");
            Select(txtTitle);
            return;
        }
        #endregion

        int AutoId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        areacityEntity objEntity = new areacityEntity();
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
        ControlAndValue.SetValues4Controls<areacityEntity>(this.form1, objEntity);
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
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/areacitysetdetail.aspx.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    #endregion
}