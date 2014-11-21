using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessEntity;
using System.Text;
using BLL.Service;

public partial class admin_systemset_edituser : SystemMainBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCssAndScript();
            GetPageElementValue();
        }
    }

    #region 获取页面元素的值

    private void GetPageElementValue()
    {
        int id = CurrentUserID;
        txtOldPwd.Attributes["value"] = "";
        systemuserEntity obj = new systemuserEntity();
        obj.AutoID = id;
        obj.Retrieve();
        if (obj.IsPersistent)
        {
            ControlAndValue.GetValues4Control<systemuserEntity>(this.form1, obj);
            string pwd = DESEncrypt.Decrypt(obj.UserPassword);
            txbUserPasswordSure.Attributes["value"] = pwd;
            txtUserPassword.Attributes["value"] =pwd;
        }
        txtAutoID.Text = id.ToString();
    }

    #endregion

    protected void btnSave_Click(object sender, EventArgs e)
    {
        #region 验证
        if (txtTitle.Text.Trim().Length == 0) { Alert("用户名不可以为空！"); Select(txtTitle); return; }
        if (txtOldPwd.Text.Trim().Length == 0) { Alert("原密码不可以为空！"); Select(txtOldPwd); return; }
        if (txtUserPassword.Text.Trim().Length == 0) { Alert("用户密码不可以为空！"); Select(txtUserPassword); return; }

        AjaxHelper ajaxEntity = new AjaxHelper();
        ajaxEntity.Title = CommonMethod.ClearInputText(txtTitle.Text, 50);
        ajaxEntity.Status = ddlStatus.SelectedValue;
        ajaxEntity.Action = SystemData.CheckUserNameExist;
        ajaxEntity.PageStatus = "2";
        ajaxEntity.AutoID = txtAutoID.Text.ToInt(0);
        SystemSet sset = new SystemSet(ajaxEntity.PageStatus);
        string returnValue = sset.CheckUserNameExist(ajaxEntity);
        if (returnValue == "Y")
        {
            AlertError("用户名称已存在,请重新输入！");
            Select(txtTitle);
            return;
        }
        #endregion

        int AutoId = CommonMethod.ConvertToInt(txtAutoID.Text, 0);
        systemuserEntity objEntity = new systemuserEntity();
        objEntity.AutoID = AutoId;
        objEntity.Retrieve();
        if (!DESEncrypt.Encrypt(txtOldPwd.Text).Equals(objEntity.UserPassword))
        {
            AlertError("原密码输入不正确,请重新输入！");
            Select(txtOldPwd);
            return;
        }
        DateTime dtNow = DateTime.Now;
        if (!objEntity.IsPersistent)
        {
            objEntity.CreateDate = dtNow;
            objEntity.CreatorID = CurrentUser.AutoID;
        }
        objEntity.ModifyDate = dtNow;
        objEntity.Modifier = CurrentUser.AutoID;
        ControlAndValue.SetValues4Controls<systemuserEntity>(this.form1, objEntity);
        objEntity.UserPassword = DESEncrypt.Encrypt(txtUserPassword.Text);
        objEntity.Save();
        string pwd=DESEncrypt.Decrypt(objEntity.UserPassword);
        txtOldPwd.Attributes["value"] = pwd;
        txbUserPasswordSure.Attributes["value"] = pwd;
        txtUserPassword.Attributes["value"] = pwd;
        AlertSucceed("恭喜，保存成功！");
    }

    #region 加载Css、Js文件
    /// <summary>
    /// 加载Css、Js文件
    /// </summary>
    private void LoadCssAndScript()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", CurrentDomainRootPath + "style/admin/one/pop-up.css?v=" + CommonMethod.Version);
        sb.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", CurrentDomainRootPath + "style/admin/one/validator.css?v=" + CommonMethod.Version);
        litCss.Text = sb.ToString();
        sb = new StringBuilder();
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/dataset.js?v=" + CommonMethod.Version);
        sb.AppendFormat("<script type=\"text/javascript\" src=\"{0}\"></script>", CurrentDomainRootPath + "scripts/admin/systemset/edituser.aspx.js?v=" + CommonMethod.Version);
        litScript.Text = sb.ToString();
    }
    #endregion

}