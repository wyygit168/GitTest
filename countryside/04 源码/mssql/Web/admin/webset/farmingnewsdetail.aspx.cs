using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntity;
using System.Text;
using BLL.Service;
using System.Data;
using PersistenceLayer;

public partial class admin_webset_farmingnewsdetail : SystemPopUpBasePage
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
        if (CurrentCustomerID == 0)
        {
            this.tropertype.Style.Value = "display:'';";
        }

        if (CurrentUser.TownID > 0)
        {
            this.trVillageID.Style.Value = "display:'';";
            UtilitySearch.LoadVillage(ddlVillageID, CurrentUser.TownID, "请选择乡村");
        }
        else
        {
            this.trVillageID.Style.Value = "display:none;";
        }

        if (Request.QueryString["curId"] != null)
        {
            int id = CommonMethod.ConvertToInt(Request.QueryString["curId"], 0);
            webfarmingnewsEntity obj = new webfarmingnewsEntity();
            obj.AutoID = id;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                ControlAndValue.GetValues4Control<webfarmingnewsEntity>(this.form1, obj);
                ddlVillageID.SelectedValue = obj.VillageID.ToString();
                if (ddlVillageID.SelectedValue != "")
                {
                    spanvillageid.Style.Value = "display:none";
                }
                drpOpertype.SelectedValue = obj.Opertype.ToString();
            }
            if (CurrentCustomerID == 0 && obj.Opertype==0)
            {
                this.trVillageID.Style.Value = "display:none;";
            }
            txtAutoID.Text = id.ToString();
            if (Action == "view")
            {
                this.drpOpertype.Enabled = false;
                this.btnSave.Visible =false; this.btnCancel.Visible = false; 
            }
        }
    }

    #endregion


    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region 验证
        if (txtTitle.Text.Trim().Length == 0) { AlertError("资讯标题不可以为空！"); Select(txtTitle); return; }
        if (CurrentCustomerID == 0)
        {
            if (drpOpertype.SelectedValue.Length == 0) { AlertError("请选择资讯类型"); return; }
        }
        //AjaxHelper ajaxEntity = new AjaxHelper();
        //ajaxEntity.Title = CommonMethod.ClearInputText(txtTitle.Text, 50);
        //ajaxEntity.Status = ddlStatus.SelectedValue;
        //ajaxEntity.Action = WebData.CheckWebMenuNameExist;
        //ajaxEntity.PageStatus = "2";
        //ajaxEntity.AutoID = txtAutoID.Text.ToInt(0);
        //WebSet wset = new WebSet(ajaxEntity.PageStatus);
        //string returnValue = wset.CheckWebMenuNameExist(ajaxEntity);
        //if (returnValue == "Y")
        //{
        //    AlertError("菜单名称已存在,请重新输入！");
        //    Select(txtTitle);
        //    return;
        //}
        #endregion

        int AutoId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        webfarmingnewsEntity objEntity = new webfarmingnewsEntity();
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
        ControlAndValue.SetValues4Controls<webfarmingnewsEntity>(this.form1, objEntity);
        if (CurrentCustomerID == 0)
        {
            objEntity.Opertype = drpOpertype.SelectedValue.ToInt(0);
        }
        else
            objEntity.Opertype = 1;
        objEntity.ProvinceID = CurrentUser.ProvinceID;
        objEntity.CityID = CurrentUser.CityID;
        objEntity.CountyID = CurrentUser.CountyID;
        objEntity.TownID = CurrentUser.TownID;
        objEntity.VillageID = ddlVillageID.SelectedValue.ToInt(0);
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
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/webset/dataset.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/webset/farmingnewsdetail.aspx.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    #endregion
}